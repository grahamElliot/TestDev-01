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
        Me.selectFile = New System.Windows.Forms.Button()
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
        Me.headerLine = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fileEncoding = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.checkData = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectFile
        '
        Me.selectFile.Location = New System.Drawing.Point(9, 50)
        Me.selectFile.Name = "selectFile"
        Me.selectFile.Size = New System.Drawing.Size(130, 20)
        Me.selectFile.TabIndex = 0
        Me.selectFile.Text = "Select data file."
        Me.selectFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fileName
        '
        Me.fileName.Location = New System.Drawing.Point(144, 50)
        Me.fileName.Name = "fileName"
        Me.fileName.Size = New System.Drawing.Size(212, 20)
        Me.fileName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Check the format of a delimited text file for consistency."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "The multi-value seperator is ; (semi-colon)."
        '
        'textSepBox
        '
        Me.textSepBox.FormattingEnabled = True
        Me.textSepBox.Location = New System.Drawing.Point(14, 179)
        Me.textSepBox.Name = "textSepBox"
        Me.textSepBox.Size = New System.Drawing.Size(125, 56)
        Me.textSepBox.TabIndex = 8
        Me.textSepBox.Visible = False
        '
        'fieldSepBox
        '
        Me.fieldSepBox.FormattingEnabled = True
        Me.fieldSepBox.Location = New System.Drawing.Point(161, 179)
        Me.fieldSepBox.Name = "fieldSepBox"
        Me.fieldSepBox.Size = New System.Drawing.Size(120, 56)
        Me.fieldSepBox.TabIndex = 9
        Me.fieldSepBox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Text Seperator."
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Select Field Seperator."
        Me.Label5.Visible = False
        '
        'checkFile
        '
        Me.checkFile.Location = New System.Drawing.Point(298, 179)
        Me.checkFile.Name = "checkFile"
        Me.checkFile.Size = New System.Drawing.Size(100, 30)
        Me.checkFile.TabIndex = 12
        Me.checkFile.Text = "Verify field names."
        Me.checkFile.UseVisualStyleBackColor = True
        Me.checkFile.Visible = False
        '
        'runProgress
        '
        Me.runProgress.Location = New System.Drawing.Point(7, 435)
        Me.runProgress.Multiline = True
        Me.runProgress.Name = "runProgress"
        Me.runProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.runProgress.Size = New System.Drawing.Size(781, 32)
        Me.runProgress.TabIndex = 13
        Me.runProgress.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Run Progress."
        '
        'fieldNamesList
        '
        Me.fieldNamesList.FormattingEnabled = True
        Me.fieldNamesList.Location = New System.Drawing.Point(10, 260)
        Me.fieldNamesList.Name = "fieldNamesList"
        Me.fieldNamesList.Size = New System.Drawing.Size(124, 121)
        Me.fieldNamesList.TabIndex = 15
        Me.fieldNamesList.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Field Names in Header"
        Me.Label6.Visible = False
        '
        'headerLine
        '
        Me.headerLine.BackColor = System.Drawing.SystemColors.Window
        Me.headerLine.Location = New System.Drawing.Point(9, 92)
        Me.headerLine.Multiline = True
        Me.headerLine.Name = "headerLine"
        Me.headerLine.ReadOnly = True
        Me.headerLine.Size = New System.Drawing.Size(755, 37)
        Me.headerLine.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Header line from data file."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(785, 413)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.checkData)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.fileEncoding)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.headerLine)
        Me.TabPage1.Controls.Add(Me.fieldNamesList)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.textSepBox)
        Me.TabPage1.Controls.Add(Me.fieldSepBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.selectFile)
        Me.TabPage1.Controls.Add(Me.checkFile)
        Me.TabPage1.Controls.Add(Me.fileName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(777, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Select data file."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(777, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'fileEncoding
        '
        Me.fileEncoding.Location = New System.Drawing.Point(139, 136)
        Me.fileEncoding.Name = "fileEncoding"
        Me.fileEncoding.Size = New System.Drawing.Size(212, 20)
        Me.fileEncoding.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Encoding used in data file."
        '
        'checkData
        '
        Me.checkData.Location = New System.Drawing.Point(161, 351)
        Me.checkData.Name = "checkData"
        Me.checkData.Size = New System.Drawing.Size(133, 30)
        Me.checkData.TabIndex = 33
        Me.checkData.Text = "Check data consistency."
        Me.checkData.UseVisualStyleBackColor = True
        Me.checkData.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(732, 189)
        Me.DataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.runProgress)
        Me.Name = "Form1"
        Me.Text = "CheckTextFile"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents selectFile As Button
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
    Friend WithEvents headerLine As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents fileEncoding As TextBox
    Friend WithEvents checkData As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
