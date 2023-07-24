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
        Me.lsbFileList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txbLog = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsbFileList
        '
        Me.lsbFileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsbFileList.FormattingEnabled = True
        Me.lsbFileList.ItemHeight = 19
        Me.lsbFileList.Location = New System.Drawing.Point(5, 30)
        Me.lsbFileList.Margin = New System.Windows.Forms.Padding(4)
        Me.lsbFileList.Name = "lsbFileList"
        Me.lsbFileList.Size = New System.Drawing.Size(605, 173)
        Me.lsbFileList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of files to convert"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Location = New System.Drawing.Point(345, 210)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(265, 50)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert!"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'txbLog
        '
        Me.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbLog.Location = New System.Drawing.Point(5, 270)
        Me.txbLog.Margin = New System.Windows.Forms.Padding(4)
        Me.txbLog.Multiline = True
        Me.txbLog.Name = "txbLog"
        Me.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbLog.Size = New System.Drawing.Size(605, 95)
        Me.txbLog.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(85, 210)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(200, 50)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Open Conversion Folder"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.Location = New System.Drawing.Point(5, 210)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(75, 50)
        Me.btnClearList.TabIndex = 5
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.BackColor = System.Drawing.Color.White
        Me.lblHint.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Silver
        Me.lblHint.Location = New System.Drawing.Point(200, 90)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(222, 66)
        Me.lblHint.TabIndex = 6
        Me.lblHint.Text = "Drag & drop your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WEBP files here"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHint.UseMnemonic = False
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(450, 325)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(140, 35)
        Me.btnLog.TabIndex = 7
        Me.btnLog.Text = "Open Debug Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 378)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txbLog)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsbFileList)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "WebP to PNG Converter - By Hevanafa 23-07-2023"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbFileList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txbLog As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnClearList As Button
    Friend WithEvents lblHint As Label
    Friend WithEvents btnLog As Button
End Class
