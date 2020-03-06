Imports System.IO

Public Class Form1
    Public traceTrap As UInt16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '/ Description
        '/ Delimited file format checker
        '/ Input = Delimited file in text format, first line must contain field headings, 
        '/ formatted as {textDelim}Field-name-1{textDelim}{fieldDelim} .e.g. "Field-name-1","Field-name-2","Field-name-3" etc.
        '/ Field and text delimiters can be any character, multi-field delimiter is assumed to be ";" (semi colon) for this version.

        OpenFileDialog1.Title = "Please Select a File to examine"
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Me.fileName.Text = OpenFileDialog1.FileName.ToString
        Me.fileName.Update()
        traceTrap = 1

        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Me.fileName.Text)
        Dim stringReader As String = ""
        '/ Read first line which must contain headings.
        stringReader = fileReader.ReadLine()
        Do Until fileReader.EndOfStream
            stringReader = fileReader.ReadLine()
        Loop

        MsgBox("The last line of the file is " & stringReader)

    End Sub
End Class
