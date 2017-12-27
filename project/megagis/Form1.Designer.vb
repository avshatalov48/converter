<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "TXT <> CSV"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "PRT => TXT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(13, 67)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "PRT => CSV"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 136)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Операции"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PIN => TXT"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(13, 113)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(13, 90)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "ГК => TXT"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'DriveListBox1
        '
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(71, 181)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(190, 21)
        Me.DriveListBox1.TabIndex = 19
        '
        'DirListBox1
        '
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(12, 208)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(249, 199)
        Me.DirListBox1.TabIndex = 21
        '
        'FileListBox1
        '
        Me.FileListBox1.FormattingEnabled = True
        Me.FileListBox1.Location = New System.Drawing.Point(270, 208)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.FileListBox1.Size = New System.Drawing.Size(260, 199)
        Me.FileListBox1.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(270, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(124, 17)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(374, 72)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(6, 11)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Предосмотр"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(13, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ф"
        Me.ToolTip1.SetToolTip(Me.Button1, "Перейти G:\Физические\")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button2.Location = New System.Drawing.Point(38, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 21)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Ю"
        Me.ToolTip1.SetToolTip(Me.Button2, "Перейти H:\Юридические\")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(101, 11)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.Text = "Табуляция"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(187, 11)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Строка"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Строка состояния"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 57)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(360, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(40, 20)
        Me.TextBox3.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "к Y:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(285, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Доб. к X:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "с кон.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Обрезать с нач.:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(187, 30)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(36, 21)
        Me.ComboBox3.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ComboBox3, "Обрезать координаты с конца")
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(101, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(36, 21)
        Me.ComboBox2.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Обрезать координаты с начала")
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(254, 11)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox5.TabIndex = 11
        Me.CheckBox5.TabStop = False
        Me.CheckBox5.Text = "X<>Y"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(312, 11)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.TabStop = False
        Me.CheckBox4.Text = "Geonics"
        Me.CheckBox4.UseVisualStyleBackColor = True
        Me.CheckBox4.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 25)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 155)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(366, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button7
        '
        Me.Button7.Image = Global.converter.My.Resources.Resources.RepeatHS
        Me.Button7.Location = New System.Drawing.Point(449, 154)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(26, 22)
        Me.Button7.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button7, "Обновить")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.converter.My.Resources.Resources.CopyHS
        Me.Button6.Location = New System.Drawing.Point(385, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 22)
        Me.Button6.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button6, "Копировать")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.converter.My.Resources.Resources.PasteHS
        Me.Button5.Location = New System.Drawing.Point(417, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 22)
        Me.Button5.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button5, "Вставить")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Image = Global.converter.My.Resources.Resources.CopyHS
        Me.Button3.Location = New System.Drawing.Point(504, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 22)
        Me.Button3.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Button3, "Копировать")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Image = Global.converter.My.Resources.Resources.PlayHS
        Me.Button4.Location = New System.Drawing.Point(481, 154)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 22)
        Me.Button4.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Button4, "Выполнить")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, -2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Label7"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 443)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.FileListBox1)
        Me.Controls.Add(Me.DirListBox1)
        Me.Controls.Add(Me.DriveListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(547, 470)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Конвертер 1.0 beta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents DirListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents FileListBox1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
