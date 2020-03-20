<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textSepBox = New System.Windows.Forms.ListBox()
        Me.fieldSepBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkFile = New System.Windows.Forms.Button()
        Me.runProgress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fieldNamesList = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fileName
        '
        Me.fileName.Location = New System.Drawing.Point(409, 107)
        Me.fileName.Name = "fileName"
        Me.fileName.Size = New System.Drawing.Size(212, 20)
        Me.fileName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Check the format of a delimited text file for consistency."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "The multi-value seperator must be ; (semi-colon) in this version."
        '
        'textSepBox
        '
        Me.textSepBox.FormattingEnabled = True
        Me.textSepBox.Location = New System.Drawing.Point(31, 107)
        Me.textSepBox.Name = "textSepBox"
        Me.textSepBox.Size = New System.Drawing.Size(125, 56)
        Me.textSepBox.TabIndex = 8
        '
        'fieldSepBox
        '
        Me.fieldSepBox.FormattingEnabled = True
        Me.fieldSepBox.Location = New System.Drawing.Point(169, 107)
        Me.fieldSepBox.Name = "fieldSepBox"
        Me.fieldSepBox.Size = New System.Drawing.Size(120, 56)
        Me.fieldSepBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Text Seperator."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Select Field Seperator."
        '
        'checkFile
        '
        Me.checkFile.Location = New System.Drawing.Point(337, 133)
        Me.checkFile.Name = "checkFile"
        Me.checkFile.Size = New System.Drawing.Size(100, 30)
        Me.checkFile.TabIndex = 12
        Me.checkFile.Text = "Check Header"
        Me.checkFile.UseVisualStyleBackColor = True
        '
        'runProgress
        '
        Me.runProgress.Location = New System.Drawing.Point(169, 190)
        Me.runProgress.Multiline = True
        Me.runProgress.Name = "runProgress"
        Me.runProgress.Size = New System.Drawing.Size(619, 121)
        Me.runProgress.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Run Progress."
        '
        'fieldNamesList
        '
        Me.fieldNamesList.FormattingEnabled = True
        Me.fieldNamesList.Location = New System.Drawing.Point(31, 190)
        Me.fieldNamesList.Name = "fieldNamesList"
        Me.fieldNamesList.Size = New System.Drawing.Size(124, 121)
        Me.fieldNamesList.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Field Names in Header"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fieldNamesList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.runProgress)
        Me.Controls.Add(Me.checkFile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fieldSepBox)
        Me.Controls.Add(Me.textSepBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fileName)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "CheckTextFile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents fileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textSepBox As ListBox
    Friend WithEvents fieldSepBox As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents checkFile As Button
    Friend WithEvents runProgress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fieldNamesList As ListBox
    Friend WithEvents Label6 As Label
End Class
