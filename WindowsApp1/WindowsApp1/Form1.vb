Imports System.IO

Public Class Form1
    Public traceTrap As UInt16
    Public pubTextDelim As String
    Public pubFieldDelim As String
    Public pubMultiValDelim As String = ";"
    Public pubParamComponents()
    Public pubTSText(10) As String
    Public pubFSText(10) As String
    Public pubFieldNames() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter1 As UInt16 = 0

        '/Set seperator character selection options for display
        pubTSText(0) = """ (Double Quotes)"
        pubTSText(1) = Chr(&HFE) & " (Thorn Ascii 254)"
        pubTSText(2) = "char 3"
        pubTSText(3) = "char 4"
        pubTSText(4) = "char 5"
        pubTSText(5) = "char 6"
        pubTSText(6) = "char 7"
        pubTSText(7) = "char 8"
        pubTSText(8) = "char 9"
        pubTSText(9) = "char 10"

        pubFSText(0) = ", (Comma)"
        pubFSText(1) = Chr(&H14) & " (DC4 Ascii 20)"
        pubFSText(2) = "char 3"
        pubFSText(3) = "char 4"
        pubFSText(4) = "char 5"
        pubFSText(5) = "char 6"
        pubFSText(6) = "char 7"
        pubFSText(7) = "char 8"
        pubFSText(8) = "char 9"
        pubFSText(9) = "char 10"

        For counter1 = 0 To 9
            textSepBox.Items.Add(pubTSText(counter1))
            fieldSepBox.Items.Add(pubFSText(counter1))
        Next counter1
    End Sub
    Private Sub textSepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textSepBox.SelectedIndexChanged
        Me.runProgress.Text = "Text Seperator is " + textSepBox.SelectedItem.ToString()
        pubTextDelim = textSepBox.SelectedItem.ToString.Substring(0, 1)
    End Sub
    Private Sub fieldSepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldSepBox.SelectedIndexChanged
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Field Seperator is " + fieldSepBox.SelectedItem.ToString()
        pubFieldDelim = fieldSepBox.SelectedItem.ToString.Substring(0, 1)
    End Sub
    Private Sub fieldNamesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldNamesList.SelectedIndexChanged
        Me.runProgress.Text = "Unique Document Identifier is " + fieldNamesList.SelectedItem.ToString()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '/ Description
        '/ Delimited file format checker
        '/ Input = Delimited file in text format, first line must contain field headings, 
        '/ formatted as {pubTextDelim}Field-name-1{pubTextDelim}{pubFieldDelim} .e.g. "Field-name-1","Field-name-2","Field-name-3" etc.
        '/ Field and text delimiters can be any character, multi-field delimiter is assumed to be ";" (semi colon) for this version.
        OpenFileDialog1.Title = "Please Select a File to examine"
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Me.fileName.Text = OpenFileDialog1.FileName.ToString
        Me.fileName.Update()
    End Sub
    Private Sub checkFile_Click(sender As Object, e As EventArgs) Handles checkFile.Click

        Dim assembledFieldNames As String = ""
        Dim counter1 As UInt16 = 0
        Dim dataString As String = ""
        Dim fileReader As StreamReader

        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)
        Dim stringReader As String = ""
        dataString = fileReader.CurrentEncoding.ToString
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Opening file " + Me.fileName.Text + " encoding is " + dataString
        stringReader = fileReader.ReadLine()
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Headings line is:" + vbCrLf + stringReader
        Me.runProgress.Update()

        '/Try the selected field delimiter
        pubParamComponents = Split(stringReader, pubFieldDelim, -1, vbTextCompare)

        '/store the field names
        ReDim pubFieldNames(UBound(pubParamComponents))
        For counter1 = 0 To UBound(pubParamComponents)
            pubFieldNames(counter1) = Replace(pubParamComponents(counter1), """", "", 1, -1, vbTextCompare)
            assembledFieldNames = assembledFieldNames & "," & pubFieldNames(counter1)
            fieldNamesList.Items.Add(pubFieldNames(counter1))
        Next counter1
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & "Extracted field names are:"
        Me.runProgress.Text = Me.runProgress.Text & vbCrLf & assembledFieldNames


        Dim Style, Title, Response, MyString
        Style = vbYesNo + MsgBoxStyle.MsgBoxHelp + vbDefaultButton2 ' Define buttons.
        Title = "Header Validation" ' Define title.
        Response = MsgBox("Do the fields match the header line?", Style, Title)

        If Response = vbNo Then
            MyString = "No" ' Perform some action.
        Else

            traceTrap = 1

            Do Until fileReader.EndOfStream
                stringReader = fileReader.ReadLine()
            Loop

            MsgBox("The last line of the file is " & stringReader)
        End If
    End Sub


End Class
