Imports System.IO

Public Class Form1
    Public traceTrap As UInt16
    Public pubTextDelim As String
    Public pubFieldDelim As String
    Public pubMultiValDelim As String = ";"
    Public pubParamComponents()
    Public pubTSText(10) As String
    Public pubFSText(10) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter1 As UInt16 = 0

        '/Set seperator character selection options for display
        pubTSText(0) = """ (Double Quotes)"
        pubTSText(1) = "char 2"
        pubTSText(2) = "char 3"
        pubTSText(3) = "char 4"
        pubTSText(4) = "char 5"
        pubTSText(5) = "char 6"
        pubTSText(6) = "char 7"
        pubTSText(7) = "char 8"
        pubTSText(8) = "char 9"
        pubTSText(9) = "char 10"

        pubFSText(0) = ", (Comma)"
        pubFSText(1) = "char 2"
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
        MsgBox("Text Seperator is " + textSepBox.SelectedItem.ToString())
    End Sub
    Private Sub fieldSepBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fieldSepBox.SelectedIndexChanged
        MsgBox("Field Seperator is " + fieldSepBox.SelectedItem.ToString())
    End Sub
    Private Sub checkFile_Click(sender As Object, e As EventArgs) Handles checkFile.Click
        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)
        Dim stringReader As String = ""

        '/ Read first line which must contain headings,correctly formatted.
        stringReader = fileReader.ReadLine()
        '/ The first character must be a text seperator.
        pubTextDelim = stringReader.Substring(0, 1)
        '/ Validate text delimiter.
        '/ cannot be ; which is multiValue delimiter
        '/ won't be 0-9, a-z or common punctuation characters.
        pubParamComponents = Split(stringReader, pubTextDelim, -1, vbTextCompare)
        '/if the text delimiter is correct then:
        '/ cell(0) should be null, cell(1),(3),(5) etc. should contain field names, cell(2),(4),(6) etc should contain the field seperator, last cell should be null.
        If pubParamComponents(0) = "" Then
            traceTrap = 1
        End If

        traceTrap = 1

        Do Until fileReader.EndOfStream
            stringReader = fileReader.ReadLine()
        Loop

        MsgBox("The last line of the file is " & stringReader)

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
        traceTrap = 1


    End Sub


End Class
