Public Class Form1
    Public traceTrap As UInt16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Please Select a File to examine"
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"

        OpenFileDialog1.ShowDialog()
        Me.fileName.Text = OpenFileDialog1.FileName.ToString
        Me.fileName.Update()
        traceTrap = 1
    End Sub
End Class
