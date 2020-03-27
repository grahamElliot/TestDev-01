Imports System.IO

Public Class Form1
    Public traceTrap As UInt16

    Public pubAlphanumCheck As String = "0123456789abcdefghijklmnopqrstuvwxyz"
    Public pubFieldDelim As String
    Public pubFieldNames() As String
    Public pubFSChosen As Boolean = False
    Public pubFSText(10) As String
    Public pubLastFieldNumber As UInt16 = 0
    Public pubMultiValDelim As String = ";"
    Public pubParamComponents()
    Public pubTextDelim As String
    Public pubTSChosen As Boolean = False
    Public pubTSText(10) As String
    Public pubUDIChosen As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter1 As UInt16 = 0

        '/Set seperator character selection options for display
        pubTSText(0) = "   (no text seperator)"
        pubTSText(1) = """ (Double Quotes)"
        pubTSText(2) = Chr(&H7E) & " (Tilde)"
        pubTSText(3) = Chr(&HA6) & " (Broken Bar)"
        pubTSText(4) = Chr(&HAC) & " (NOT sign)"
        pubTSText(5) = Chr(&HB6) & " (Pilcrow sign)"
        pubTSText(6) = Chr(&HFE) & " (Thorn Ascii 254)"
        pubTSText(7) = ""
        pubTSText(8) = ""
        pubTSText(9) = ""

        '/ Field seperators
        pubFSText(0) = ", (Comma)"
        pubFSText(1) = Chr(&H14) & " (DC4 Ascii 20)"
        pubFSText(2) = Chr(&H7E) & " (Tilde)"
        pubFSText(3) = Chr(&HA6) & " (Broken Bar)"
        pubFSText(4) = Chr(&HAC) & " (NOT sign)"
        pubFSText(5) = Chr(&HB6) & " (Pilcrow sign)"
        pubFSText(6) = ""
        pubFSText(7) = ""
        pubFSText(8) = ""
        pubFSText(9) = ""

        For counter1 = 0 To 9
            textSepBox.Items.Add(pubTSText(counter1))
            fieldSepBox.Items.Add(pubFSText(counter1))
        Next counter1
    End Sub
    Private Sub textSepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textSepBox.SelectedIndexChanged
        Me.runProgress.Text = "Text Seperator is " + textSepBox.SelectedItem.ToString()
        pubTextDelim = textSepBox.SelectedItem.ToString.Substring(0, 1)
        pubTSChosen = True
        If pubFSChosen = True Then
            Call check_seperators_differ()
            Me.checkFile.Visible = True
        End If
    End Sub
    Private Sub fieldSepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldSepBox.SelectedIndexChanged
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Field Seperator is " + fieldSepBox.SelectedItem.ToString()
        pubFieldDelim = fieldSepBox.SelectedItem.ToString.Substring(0, 1)
        pubFSChosen = True
        If pubTSChosen = True Then
            Call check_seperators_differ()
            Me.checkFile.Visible = True
        End If
    End Sub
    Private Sub fieldNamesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldNamesList.SelectedIndexChanged
        Me.runProgress.Text = "Unique Document Identifier is " + fieldNamesList.SelectedItem.ToString()
        pubUDIChosen = True
        Me.checkData.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles selectFile.Click
        '/ Description
        '/ Delimited file format checker
        '/ Input = Delimited file in text format, first line must contain field headings, 
        '/ formatted as {pubTextDelim}Field-name-1{pubTextDelim}{pubFieldDelim} .e.g. "Field-name-1","Field-name-2","Field-name-3" etc.
        '/ Field and text delimiters can be any character, multi-field delimiter is assumed to be ";" (semi colon) for this version.
        Dim dataString As String = ""
        Dim fileReader As StreamReader
        Dim stringReader As String = ""

        OpenFileDialog1.Title = "Please Select a File to examine"
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Me.fileName.Text = OpenFileDialog1.FileName.ToString
        Me.fileName.Update()
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)
        Me.fileEncoding.Text = fileReader.CurrentEncoding.ToString
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Opening file " + Me.fileName.Text + " encoding is " + dataString
        stringReader = fileReader.ReadLine()
        fileReader.Close()
        Me.headerLine.Text = stringReader
        Me.runProgress.Update()
        Me.Label4.Visible = True
        Me.Label5.Visible = True
        Me.textSepBox.Visible = True
        Me.fieldSepBox.Visible = True
        MsgBox("Please select a text seperator and a field seperator.")
    End Sub
    Private Sub checkFile_Click(sender As Object, e As EventArgs) Handles checkFile.Click

        Dim assembledFieldNames As String = ""
        Dim counter1 As UInt16 = 0
        Dim dataString As String = ""
        Dim fileReader As StreamReader
        Dim Style, Title, Response
        Dim stringReader As String = ""
        Dim firstChar As String = ""
        Dim lastChar As String = ""

        Me.Label6.Visible = True
        Me.fieldNamesList.Visible = True
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)

        dataString = fileReader.CurrentEncoding.ToString
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Opening file " + Me.fileName.Text + " encoding is " + dataString
        stringReader = fileReader.ReadLine()
        Me.headerLine.Text = stringReader
        Me.runProgress.Update()
        fileReader.Close()
        '/Try the selected field delimiter
        pubParamComponents = Split(stringReader, pubFieldDelim, -1, vbTextCompare)

        '/store the field names
        ReDim pubFieldNames(UBound(pubParamComponents))
        pubLastFieldNumber = UBound(pubParamComponents)
        For counter1 = 0 To UBound(pubParamComponents)
            If pubTextDelim <> " " Then
                pubFieldNames(counter1) = Replace(pubParamComponents(counter1), pubTextDelim, "", 1, -1, vbTextCompare)
            Else
                pubFieldNames(counter1) = pubParamComponents(counter1)
            End If

            '/If no text delimiter has been specified, run some basic checks that none exist.
            If pubTextDelim = " " Then
                pubTSChosen = False
                '/Check if the first and last characters are identical, if so check if they are a-z or 0-9
                firstChar = LCase(pubFieldNames(counter1).Substring(0, 1))
                lastChar = LCase(pubFieldNames(counter1).Substring(pubFieldNames(counter1).Length - 1, 1))
                If firstChar = lastChar Then
                    If Not pubAlphanumCheck.Contains(firstChar) Then
                        Style = vbYesNo + MsgBoxStyle.MsgBoxHelp + vbDefaultButton2 ' Define buttons.
                        Title = "Header Validation" ' Define title.
                        Response = MsgBox("The first (" & firstChar & ") and last (" & lastChar & ") characters in this field name are identical and potentially text seperators" & vbCrLf & "Do you want to restart the run ad select a text seperator?", Style, Title)
                        If Response = vbYes Then
                            MsgBox("Please re-run with text seperator selected.")
                            Application.Exit()
                        End If
                    End If
                End If
            End If

            assembledFieldNames = assembledFieldNames & "," & pubFieldNames(counter1)
            fieldNamesList.Items.Add(pubFieldNames(counter1))
        Next counter1
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Extracted field names are:"
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & assembledFieldNames

        Style = vbYesNo + MsgBoxStyle.MsgBoxHelp + vbDefaultButton2 ' Define buttons.
        Title = "Header Validation" ' Define title.
        Response = MsgBox("Do the fields match the header line?", Style, Title)

        If Response = vbNo Then
            MsgBox("Please re-run using different field seperator.")
            Application.Exit()
        Else
            MsgBox("Please select the unique document identifier field" & vbCrLf & " from the Field Names list.")
            traceTrap = 1
        End If
    End Sub

    Private Sub checkData_Click(sender As Object, e As EventArgs) Handles checkData.Click
        Dim assembledFieldNames As String = ""
        Dim counter1 As UInt16 = 0
        Dim dataString As String = ""
        Dim fileReader As StreamReader
        Dim stringReader As String = ""

        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)

        dataString = fileReader.CurrentEncoding.ToString
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Opening file " + Me.fileName.Text + " encoding is " + dataString
        '/ Skip over headings line.
        stringReader = fileReader.ReadLine()

        Do Until fileReader.EndOfStream
            stringReader = fileReader.ReadLine()
            pubParamComponents = Split(stringReader, pubFieldDelim, -1, vbTextCompare)

        Loop

        MsgBox("The last line of the file is " & stringReader)
    End Sub
    Private Sub check_seperators_differ()
        '/The text and field seperators can't be the same character.
        If pubTextDelim = pubFieldDelim Then
            MsgBox("The text and field seperators can't be the same character, please fix and re-run.")
            Application.Exit()
        End If
    End Sub
End Class
