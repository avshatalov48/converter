Public Class Zoom_Form

    Dim I, J As Integer
    Dim ZnacheniePlan As Double
    Dim ZnachenieMestnost As Double
    Dim KoeficientMashtab As Double
    Dim KoeficientItog As Double
    Dim EdinicaPlan As Double
    Dim EdinicaMestnost As Double

    Private Sub Zoom_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' -----------------------------------------------------------------------------------------------------------
        ' Реестр ----------------------------------------------------------------------------------------------------
        ' Координаты окна X и Y -------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_x", Me.Location.X)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_y", Me.Location.Y)
        ' Масштаб ---------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_mashtab", ComboBox1.Text)
        ' Значение --------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_znachenie", TextBox1.Text)
        ' Единицы План ----------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicaplan", ComboBox2.Text)
        ' Единицы Местность -----------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicamestnost", ComboBox3.Text)
        ' Направление Перевода --------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_napravlenie", Label3.Text)
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub


    Private Sub Zoom_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Значения Масштабов
        ComboBox1.Items.Add(100)
        ComboBox1.Items.Add(200)
        ComboBox1.Items.Add(500)
        ComboBox1.Items.Add(1000)
        ComboBox1.Items.Add(2000)
        ComboBox1.Items.Add(5000)
        ComboBox1.Items.Add(10000)
        ComboBox1.Items.Add(25000)
        ComboBox1.Items.Add(50000)

        ' Единицы измерения План
        ComboBox2.Items.Add("км")
        ComboBox2.Items.Add("м")
        ComboBox2.Items.Add("дм")
        ComboBox2.Items.Add("см")
        ComboBox2.Items.Add("мм")

        ' Единицы измерения Местность
        ComboBox3.Items.Add("км")
        ComboBox3.Items.Add("м")
        ComboBox3.Items.Add("дм")
        ComboBox3.Items.Add("см")
        ComboBox3.Items.Add("мм")

        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ' ЧТЕНИЕ ПАРАМЕТРОВ ИЗ РЕЕСТРА ------------------------------------------------------------------------------
        ' Положение окна X и Y --------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_x", Nothing)
        J = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_y", Nothing)
        If I <= 0 Or J <= 0 Then
            I = Math.Round((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2)
            J = Math.Round((My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        End If
        Me.Location = New Point(I, J)
        ' Масштаб ---------------------------------------------------------------------------------------------------
        ComboBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_mashtab", Nothing)
        If ComboBox1.Text = "" Then ComboBox1.SelectedIndex = 3
        ' Единицы План ----------------------------------------------------------------------------------------------
        ComboBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicaplan", Nothing)
        If ComboBox2.Text = "" Then ComboBox2.SelectedIndex = 3
        ' Единицы Местность -----------------------------------------------------------------------------------------
        ComboBox3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicamestnost", Nothing)
        If ComboBox3.Text = "" Then ComboBox3.SelectedIndex = 1
        ' Значение --------------------------------------------------------------------------------------------------
        TextBox1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_znachenie", Nothing)
        If TextBox1.Text = "" Then TextBox1.Text = "0"
        ' Направление Перевода --------------------------------------------------------------------------------------
        Label3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_napravlenie", Nothing)
        If Label3.Text = "" Then Label3.Text = ">>"
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------

        Call Pereschet()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If (Label3.Text = ">>") Then Label3.Text = "<<" Else Label3.Text = ">>"
        Call Pereschet()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Pereschet()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Call Pereschet()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call Pereschet()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Pereschet()
    End Sub

    ' Подпрограммка Пересчёта
    Sub Pereschet()
        If Val(TextBox1.Text) > 0 Then
            If ComboBox2.Text = "км" Then EdinicaPlan = 0.001
            If ComboBox2.Text = "м" Then EdinicaPlan = 1
            If ComboBox2.Text = "дм" Then EdinicaPlan = 10
            If ComboBox2.Text = "см" Then EdinicaPlan = 100
            If ComboBox2.Text = "мм" Then EdinicaPlan = 1000

            If ComboBox3.Text = "км" Then EdinicaMestnost = 0.001
            If ComboBox3.Text = "м" Then EdinicaMestnost = 1
            If ComboBox3.Text = "дм" Then EdinicaMestnost = 10
            If ComboBox3.Text = "см" Then EdinicaMestnost = 100
            If ComboBox3.Text = "мм" Then EdinicaMestnost = 1000

            KoeficientMashtab = EdinicaPlan / EdinicaMestnost

            KoeficientItog = Val(ComboBox1.Text) / KoeficientMashtab

            If (Label3.Text = ">>") Then
                ZnacheniePlan = Val(TextBox1.Text)
                ZnachenieMestnost = ZnacheniePlan * KoeficientItog
            Else
                ZnachenieMestnost = Val(TextBox1.Text)
                ZnacheniePlan = ZnachenieMestnost / KoeficientItog
            End If

            Label5.Text = ZnacheniePlan
            Label6.Text = ZnachenieMestnost
        Else
            Label5.Text = 0
            Label6.Text = 0
        End If
    End Sub

End Class