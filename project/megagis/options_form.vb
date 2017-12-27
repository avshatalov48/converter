Imports System
Imports Microsoft.Win32
Imports System.Diagnostics


Public Class Options_Form

    Dim I, J As Integer

    Private Sub Options_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' -----------------------------------------------------------------------------------------------------------
        ' Реестр ----------------------------------------------------------------------------------------------------
        ' Координаты окна X и Y -------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_x", Me.Location.X)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_y", Me.Location.Y)
        ' Изменить --------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_1", CheckBox1.Checked)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_2", CheckBox2.Checked)
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Options_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Прозрачность ----------------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "opacity", Nothing)
        If (I > 100 Or I = 0) Then I = 100
        If I < 30 Then I = 30
        TrackBar1.Value = I
        Label2.Text = TrackBar1.Value & " %"
        ' Быстрые Кнопки --------------------------------------------------------------------------------------------
        Label3.Text = My.Forms.Main_Form.FastButtonLabel1.Text
        Label4.Text = My.Forms.Main_Form.FastButtonLabel2.Text
        TextBox1.Text = My.Forms.Main_Form.DirListBox1.Path
        TextBox2.Text = My.Forms.Main_Form.DirListBox1.Path
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ' ЧТЕНИЕ ПАРАМЕТРОВ ИЗ РЕЕСТРА ------------------------------------------------------------------------------
        ' Положение окна X и Y --------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_x", Nothing)
        J = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_y", Nothing)
        If I <= 0 Or J <= 0 Then
            I = Math.Round((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2)
            J = Math.Round((My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        End If
        Me.Location = New Point(I, J)
        ' Изменить ------------------------------------------------------------------------------------------------
        CheckBox1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_1", Nothing)
        CheckBox2.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_2", Nothing)
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TrackBar1.Value = 100
        TextBox1.Text = "G:\Физические\"
        TextBox2.Text = "H:\Юридические\"
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Label2.Text = TrackBar1.Value & " %"
        My.Forms.Main_Form.Opacity = TrackBar1.Value / 100
        My.Forms.Zoom_Form.Opacity = TrackBar1.Value / 100
        My.Forms.Rescue.Opacity = TrackBar1.Value / 100
        My.Forms.Rescue_Copy.Opacity = TrackBar1.Value / 100
        Me.Opacity = TrackBar1.Value / 100
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveOptions.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "opacity", TrackBar1.Value)
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "fastbutton1", TextBox1.Text)
            My.Forms.Main_Form.FastButtonLabel1.Text = TextBox1.Text
            My.Forms.Main_Form.ToolTip1.SetToolTip(My.Forms.Main_Form.Button1, TextBox1.Text)
            Label3.Text = My.Forms.Main_Form.FastButtonLabel1.Text
            If (LCase(Label3.Text) = LCase("G:\Физические") Or LCase(Label3.Text) = LCase("G:\Физические\")) Then
                My.Forms.Main_Form.Button1.Text = "Ф"
            ElseIf (LCase(Label3.Text) = LCase("H:\Юридические") Or LCase(Label3.Text) = LCase("H:\Юридические\")) Then
                My.Forms.Main_Form.Button1.Text = "Ю"
            Else
                My.Forms.Main_Form.Button1.Text = "1"
            End If
        End If
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "fastbutton2", TextBox2.Text)
            My.Forms.Main_Form.FastButtonLabel2.Text = TextBox2.Text
            My.Forms.Main_Form.ToolTip1.SetToolTip(My.Forms.Main_Form.Button2, TextBox2.Text)
            Label4.Text = My.Forms.Main_Form.FastButtonLabel2.Text
            If (LCase(Label4.Text) = LCase("G:\Физические") Or LCase(Label4.Text) = LCase("G:\Физические\")) Then
                My.Forms.Main_Form.Button2.Text = "Ф"
            ElseIf (LCase(Label4.Text) = LCase("H:\Юридические") Or LCase(Label4.Text) = LCase("H:\Юридические\")) Then
                My.Forms.Main_Form.Button2.Text = "Ю"
            Else
                My.Forms.Main_Form.Button2.Text = "2"
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.CurrentUser.DeleteSubKeyTree("Software\Gisit\Converter")
    End Sub
End Class