Public Class Form1

    Dim Sod(0 To 1000) As String
    Dim I As Integer
    Dim K As Integer
    Dim L As Integer
    Dim M As Integer
    Dim J As Integer
    Dim A As String
    Dim B As String
    Dim C As String
    Dim F As String
    Dim S As String
    Dim SK As String
    Dim T As String
    Dim Interval As String
    Dim Geonics As String
    Dim Tabulation As String
    Dim XreverseY As String

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.Location = New Point(Me.Location.X, 0)
        Me.Height = Me.MaximumSize.Height
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' -----------------------------------------------------------------------------------------------------------
        ' Реестр ----------------------------------------------------------------------------------------------------
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Gisit\Converter")
        ' Запись в реестр координат X и Y ---------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_x", Me.Location.X)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_y", Me.Location.Y)
        ' Запись в реестр размеров окна -----------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formwidth", Me.Width)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formheight", Me.Height)
        ' Запись текущей операции -----------------------------------------------------------------------------------
        If RadioButton1.Checked = True Then I = 1
        If RadioButton2.Checked = True Then I = 2
        If RadioButton3.Checked = True Then I = 3
        If RadioButton4.Checked = True Then I = 4
        If RadioButton5.Checked = True Then I = 5
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "operation", I)
        ' Предосмотр ------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "preview", CheckBox1.Checked)
        ' Табуляция -------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "tabulation", CheckBox2.Checked)
        ' Строка ----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "interval", CheckBox3.Checked)
        ' X<>Y ------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "xreversey", CheckBox5.Checked)
        ' Geonics ---------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "geonics", CheckBox4.Checked)
        ' CutX ------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cutx", ComboBox2.Text)
        ' CutY ------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cuty", ComboBox3.Text)
        ' PlusX -----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusx", TextBox2.Text)
        ' PlusY -----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusy", TextBox3.Text)
        ' Drive -----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "drive", DriveListBox1.Drive)
        ' Dir -------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "dir", DirListBox1.Path)
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Point(547, My.Computer.Screen.WorkingArea.Height)
        For I = 0 To 10
            ComboBox2.Items.Add(I)
            ComboBox3.Items.Add(I)
        Next I
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ' Чтение параметров из реестра ------------------------------------------------------------------------------
        ' Положение окна X и Y --------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_x", Nothing)
        J = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_y", Nothing)
        If I <= 0 Or J <= 0 Then
            I = Math.Round((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2)
            J = Math.Round((My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        End If
        Me.Location = New Point(I, J)
        ' Размеры окна ----------------------------------------------------------------------------------------------
        Me.Width = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formwidth", Nothing)
        Me.Height = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formheight", Nothing)
        ' Выбор операции --------------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "operation", Nothing)
        If I = 1 Then RadioButton1.Checked = True
        If I = 2 Then RadioButton2.Checked = True
        If I = 3 Then RadioButton3.Checked = True
        If I = 4 Then RadioButton4.Checked = True
        If I = 5 Then RadioButton5.Checked = True
        ' Предосмотр ------------------------------------------------------------------------------------------------
        CheckBox1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "preview", Nothing)
        ' Табуляция -------------------------------------------------------------------------------------------------
        CheckBox2.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "tabulation", Nothing)
        ' Строка ----------------------------------------------------------------------------------------------------
        CheckBox3.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "interval", Nothing)
        ' X<>Y ------------------------------------------------------------------------------------------------------
        CheckBox5.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "xreversey", Nothing)
        ' Geonics ---------------------------------------------------------------------------------------------------
        CheckBox4.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "geonics", Nothing)
        ' CutX ------------------------------------------------------------------------------------------------------
        ComboBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cutx", Nothing)
        ' CutY ------------------------------------------------------------------------------------------------------
        ComboBox3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cuty", Nothing)
        ' PlusX -----------------------------------------------------------------------------------------------------
        TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusx", Nothing)
        ' PlusY -----------------------------------------------------------------------------------------------------
        TextBox3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusy", Nothing)
        ' Drive -----------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "drive", Nothing)
        If S <> "" Then DriveListBox1.Drive = S
        ' Dir -------------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "dir", Nothing)
        If S <> "" Then DirListBox1.Path = S
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ComboBox1.Items.Add("*.csv;*.prt;*.txt")
        ComboBox1.SelectedIndex = 0
        Call StrokaSostoyaniya()
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub DriveListBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedValueChanged
        DirListBox1.Path = DriveListBox1.Drive
    End Sub

    Private Sub DirListBox1_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirListBox1.Change
        FileListBox1.Path = DirListBox1.Path
        If Len(DirListBox1.Path) > 3 Then S = "\" Else S = ""
        TextBox1.Text = DirListBox1.Path & S
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        FileListBox1.Pattern = ComboBox1.Text
    End Sub

    Private Sub FileListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged

        Label7.Text = ""
        For I = 0 To FileListBox1.SelectedItems.Count - 1
            Label7.Text = Label7.Text & FileListBox1.SelectedItems.Item(I)
        Next I


        RichTextBox1.Text = ""
        If FileListBox1.FileName <> "" Then
            ' Имя выбранного файла
            If Len(DirListBox1.Path) > 2 Then S = "\" Else S = ""
            F = DirListBox1.Path & S & FileListBox1.FileName
            TextBox1.Text = F
            ' Предосмотр
            If CheckBox1.Checked = True Then
                FileOpen(1, F, OpenMode.Input)
                While Not EOF(1)
                    S = LineInput(1)
                    RichTextBox1.Text = RichTextBox1.Text + S + Chr(13)
                End While
                FileClose(1)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        RichTextBox1.Text = ""
        If CheckBox1.Checked = True And FileListBox1.FileName <> "" Then
            ' Имя выбранного файла
            If Len(DirListBox1.Path) > 2 Then S = "\" Else S = ""
            F = DirListBox1.Path & S & FileListBox1.FileName
            FileOpen(1, F, OpenMode.Input)
            While Not EOF(1)
                S = LineInput(1)
                RichTextBox1.Text = RichTextBox1.Text + S + Chr(13)
            End While
            FileClose(1)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If FileListBox1.FileName <> "" Then

            ' Имя выбранного файла
            If Len(DirListBox1.Path) > 2 Then S = "\" Else S = ""
            F = DirListBox1.Path & S & FileListBox1.FileName

            ' TXT <> CSV -----------------------------------------------------------------------------------------------
            If RadioButton1.Checked = True Then
                If System.IO.Path.GetExtension(FileListBox1.FileName) = ".txt" Or System.IO.Path.GetExtension(FileListBox1.FileName) = ".csv" Then
                    FileOpen(1, F, OpenMode.Input)

                    If System.IO.Path.GetExtension(FileListBox1.FileName) = ".csv" Then
                        'CSV => TXT ------------------------------------------------------------------------------------
                        If CheckBox2.Checked = True Then T = Chr(9) Else T = " "
                        S = "txt"
                        A = ","
                        B = "."
                    Else
                        'TXT => CSV ------------------------------------------------------------------------------------
                        T = ";"
                        S = "csv"
                        A = "."
                        B = ","
                    End If

                    FileOpen(2, Mid(F, 1, Len(F) - 3) + S, OpenMode.Output)
                    While Not EOF(1)
                        S = Replace(LineInput(1), Chr(9), " ")
                        S = Replace(S, ";", " ")
                        S = SpaceDestroy(S)
                        S = Replace(S, A, B)
                        Dim TempArray() As String = Split(S, " ")

                        'Обрезание координат
                        TempArray(0) = CoordinatesCuts(TempArray(0))
                        TempArray(1) = CoordinatesCuts(TempArray(1))
                        'Добавить к X
                        TempArray(0) = TextBox2.Text & TempArray(0)
                        'Добавить к Y
                        TempArray(1) = TextBox3.Text & TempArray(1)

                        If CheckBox5.Checked = True Then Array.Reverse(TempArray)
                        If S <> "" Then PrintLine(2, TempArray(0) & T & TempArray(1))
                        If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                    End While
                    FileClose(2)
                    FileClose(1)
                    Label1.Text = "Конвертация " & FileListBox1.FileName & " завершена"
                End If
            End If


            ' PRT => CSV => TXT ----------------------------------------------------------------------------------------
            If RadioButton2.Checked = True Or RadioButton3.Checked = True Then

                If System.IO.Path.GetExtension(FileListBox1.FileName) = ".prt" Then
                    I = 0
                    'Кол-во строк в файле
                    FileOpen(1, F, OpenMode.Input)
                    While Not EOF(1)
                        I = I + 1
                        Sod(I) = SpaceDestroy(LineInput(1))
                        ' Полигон
                        If InStr(Sod(I), "Площадь участка") <> 0 Then L = 3
                        ' Линейная Тема
                        If InStr(Sod(I), "Длина") <> 0 Then L = 1
                    End While
                    FileClose(1)

                    'PRT => TXT ------------------------------------------------------------------------------------
                    If RadioButton2.Checked = True Then
                        If CheckBox2.Checked = True Then T = Chr(9) Else T = " "
                        S = "txt"
                        A = ","
                        B = "."
                    End If

                    'PRT => CSV ------------------------------------------------------------------------------------
                    If RadioButton3.Checked = True Then
                        T = ";"
                        S = "csv"
                        A = "."
                        B = ","
                    End If

                    FileOpen(2, Mid(F, 1, Len(F) - 3) + S, OpenMode.Output)

                    'Пропускаем шапку
                    For J = 5 To I - L Step 2
                        Dim TempArray() As String = Split(Sod(J), " ")
                        If (J > I - L - 2) And L = 1 Then

                            'Обрезание координат
                            TempArray(0) = CoordinatesCuts(TempArray(0))
                            TempArray(1) = CoordinatesCuts(TempArray(1))
                            'Добавить к X
                            TempArray(0) = TextBox2.Text & TempArray(0)
                            'Добавить к Y
                            TempArray(1) = TextBox3.Text & TempArray(1)

                            If CheckBox5.Checked = True Then C = TempArray(0) : TempArray(0) = TempArray(1) : TempArray(1) = C
                            S = TempArray(0) & T & TempArray(1)
                        Else

                            'Обрезание координат
                            TempArray(1) = CoordinatesCuts(TempArray(1))
                            TempArray(2) = CoordinatesCuts(TempArray(2))
                            'Добавить к X
                            TempArray(1) = TextBox2.Text & TempArray(1)
                            'Добавить к Y
                            TempArray(2) = TextBox3.Text & TempArray(2)

                            If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                            S = TempArray(1) & T & TempArray(2)
                        End If
                        S = Replace(S, A, B)
                        If S <> "" Then PrintLine(2, S)
                        If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                    Next J
                    FileClose(2)
                    Label1.Text = "Конвертация " & FileListBox1.FileName & " завершена"
                End If

            End If

            'ГК => TXT -----------------------------------------------------------------------------------------
            If RadioButton4.Checked = True And System.IO.Path.GetExtension(FileListBox1.FileName) = ".txt" Then
                I = 0
                'Кол-во строк в файле
                FileOpen(1, F, OpenMode.Input)
                'Пропускаем шапку из 2-х строк
                LineInput(1) : LineInput(1)
                While Not EOF(1)
                    S = Replace(LineInput(1), ",", " ")
                    S = SpaceDestroy(S)
                    If S = "/" Then Exit While
                    I = I + 1
                    Sod(I) = S
                End While
                FileClose(1)

                If CheckBox4.Checked = True Then S = "_geonics.txt" Else S = "_new.txt"

                FileOpen(2, Mid(F, 1, Len(F) - 4) + S, OpenMode.Output)

                If CheckBox2.Checked = True Then T = Chr(9) Else T = " "

                For J = 1 To I
                    Dim TempArray() As String = Split(Sod(J), " ")

                    'Обрезание координат
                    TempArray(1) = CoordinatesCuts(TempArray(1))
                    TempArray(2) = CoordinatesCuts(TempArray(2))
                    'Добавить к X
                    TempArray(1) = TextBox2.Text & TempArray(1)
                    'Добавить к Y
                    TempArray(2) = TextBox3.Text & TempArray(2)

                    ' Меняет местами X и Y
                    If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                    If CheckBox4.Checked = True Then
                        S = TempArray(0) + T + TempArray(1) + T + TempArray(2) + T + TempArray(3)
                    Else
                        S = TempArray(1) + T + TempArray(2)
                    End If
                    If S <> "" Then PrintLine(2, S)
                    If S <> "" And CheckBox3.Checked = True Then PrintLine(2) 'Вставка строки
                Next J

                FileClose(2)
                Label1.Text = "Конвертация " & FileListBox1.FileName & " завершена"
            End If

            'PIN <=> TXT -----------------------------------------------------------------------------------------
            If RadioButton5.Checked = True And System.IO.Path.GetExtension(FileListBox1.FileName) = ".txt" Then

                I = 0 : SK = ""

                If Label2.Text = "PIN <= TXT" Then
                    FileOpen(1, F, OpenMode.Input)
                    FileOpen(2, Mid(F, 1, Len(F) - 4) & "_pin.txt", OpenMode.Output)
                    While Not EOF(1)
                        S = Replace(LineInput(1), ",", ".")
                        S = Replace(S, Chr(9), " ")
                        S = SpaceDestroy(S)
                        Dim TempArray() As String = Split(S, " ")

                        'Обрезание координат
                        TempArray(0) = CoordinatesCuts(TempArray(0))
                        TempArray(1) = CoordinatesCuts(TempArray(1))
                        'Добавить к X
                        TempArray(0) = TextBox2.Text & TempArray(0)
                        'Добавить к Y
                        TempArray(1) = TextBox3.Text & TempArray(1)

                        If S <> "" Then
                            If I < 1 Then
                                ' Вставка шапки Pinnacle
                                PrintLine(2, " Table calculator")
                                PrintLine(2)
                                PrintLine(2)
                                PrintLine(2, " Left pane :")
                                If Mid$(TempArray(0), 1, 2) = "58" And Mid$(TempArray(1), 1, 2) = "75" Then SK = "SK42"
                                If Mid$(TempArray(0), 1, 2) = "40" And Mid$(TempArray(1), 1, 2) = "13" Then SK = "SK48"
                                PrintLine(2, " Grid : " & SK & " ")
                                PrintLine(2, " Unit name : Meters ")
                                PrintLine(2, " Name Northing,m     Easting,m      Height,m ")
                            End If
                            I = I + 1
                            If CheckBox5.Checked = True Then Array.Reverse(TempArray, 0, 1)
                            If CheckBox2.Checked = True Then
                                PrintLine(2, Trim(Str(I)) & Chr(9) & TempArray(0) & Chr(9) & TempArray(1) & Chr(9) & "0")
                            Else
                                PrintLine(2, " " & Mid$(Trim(Str(I)) & Space(4), 1, 4) & " " & Mid$(Trim(TempArray(0)) & Space(14), 1, 14) & " " & Mid$(Trim(TempArray(1)) & Space(14), 1, 14) & " 0")
                            End If
                            If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                        End If
                    End While
                    PrintLine(2, "-----------")
                    FileClose(1)
                    FileClose(2)
                End If

                If Label2.Text = "PIN => TXT" Then
                    FileOpen(1, F, OpenMode.Input)
                    FileOpen(2, Mid(F, 1, Len(F) - 4) & "_new.txt", OpenMode.Output)
                    While Not EOF(1)
                        If InStr(LineInput(1), "Height,m") <> 0 Then Exit While
                    End While
                    While Not EOF(1)
                        S = LineInput(1)
                        If InStr(S, "-----------") <> 0 Then Exit While
                        S = Replace(S, ",", ".")
                        S = Replace(S, Chr(9), " ")
                        S = SpaceDestroy(S)
                        Dim TempArray() As String = Split(S, " ")

                        'Обрезание координат
                        TempArray(1) = CoordinatesCuts(TempArray(1))
                        TempArray(2) = CoordinatesCuts(TempArray(2))
                        'Добавить к X
                        TempArray(1) = TextBox2.Text & TempArray(1)
                        'Добавить к Y
                        TempArray(2) = TextBox3.Text & TempArray(2)

                        If S <> "" Then
                            If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                            If CheckBox2.Checked = True Then T = Chr(9) Else T = " "
                            PrintLine(2, TempArray(1) & T & TempArray(2))
                            If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                        End If
                    End While
                    FileClose(1)
                    FileClose(2)
                End If

                Label1.Text = "Конвертация " & FileListBox1.FileName & " завершена"

            End If

        Else
            MessageBox.Show("Выбирите необходимый файл и повторите операцию", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        FileListBox1.Refresh()
        FileListBox1.Focus()
    End Sub

    ' Переход в папку G:\Физические\
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DriveListBox1.Drive = "G:\"
        DirListBox1.Path = "G:\Физические\"
        FileListBox1.Path = "G:\Физические\"
    End Sub

    ' Переход в папку H:\Юридические\
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DriveListBox1.Drive = "H:\"
        DirListBox1.Path = "H:\Юридические\"
        FileListBox1.Path = "H:\Юридические\"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Call StrokaSostoyaniya()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Call StrokaSostoyaniya()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Call StrokaSostoyaniya()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Call StrokaSostoyaniya()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Call StrokaSostoyaniya()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Call StrokaSostoyaniya()
    End Sub

    ' Режим Табуляции
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Tabulation = ""
        If CheckBox2.CheckState = CheckState.Checked Then Tabulation = "+Табуляция"
        Call StrokaSostoyaniya()
    End Sub

    ' Режим Строки
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Interval = ""
        If CheckBox3.CheckState = CheckState.Checked Then Interval = "+Строка"
        Call StrokaSostoyaniya()
    End Sub

    ' Режим формата Geonics
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Geonics = ""
        If CheckBox4.CheckState = CheckState.Checked Then Geonics = "+Geonics" : CheckBox2.Checked = True
        Call StrokaSostoyaniya()
    End Sub

    ' Поменять местами X и Y
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        XreverseY = ""
        If CheckBox5.CheckState = CheckState.Checked Then XreverseY = "+X<>Y"
        Call StrokaSostoyaniya()
    End Sub

    ' Подпрограммка вывода строки состояния -------------------------------------------------------------------------
    Sub StrokaSostoyaniya()
        CheckBox4.Visible = False
        If RadioButton1.Checked = True Then A = "TXT <> CSV"
        If RadioButton2.Checked = True Then A = "PRT => TXT"
        If RadioButton3.Checked = True Then A = "PRT => CSV"
        If RadioButton4.Checked = True Then A = "ГИС-Конструктор => TXT" : CheckBox4.Visible = True
        If RadioButton5.Checked = True And Label2.Text = "PIN => TXT" Then A = "JNS Pinnacle => TXT"
        If RadioButton5.Checked = True And Label2.Text = "PIN <= TXT" Then A = "JNS Pinnacle <= TXT"
        S = " ("
        If Tabulation <> "" Or Interval <> "" Or Geonics <> "" Then
            If Tabulation <> "" Then S = S & " " & Tabulation
            If Interval <> "" Then S = S & " " & Interval
            If XreverseY <> "" Then S = S & " " & XreverseY
            If Geonics <> "" And RadioButton4.Checked = True Then S = S & " " & Geonics
        End If
        S = S & " )"
        Label1.Text = "Выбран режим " & A & S
    End Sub

    ' Подпрограммка удаления двойных пробелов -------------------------------------------------------------------------
    Function SpaceDestroy(ByVal TempString As String) As String
        'Удаляю пробелы в начале и конце строки
        TempString = Trim(TempString)
        'Удаление двойных пробелов в переменной
        Do
            K = Len(TempString)
            TempString = Replace(TempString, "  ", " ")
        Loop While K <> Len(TempString)
        Return TempString
    End Function

    ' Подпрограммка обрезания координат -------------------------------------------------------------------------------
    Function CoordinatesCuts(ByVal Coordinate As String) As String
        'Обрезание координат с начала
        If ComboBox2.Text <> "0" Then Coordinate = Microsoft.VisualBasic.Right(Coordinate, Len(Coordinate) - Val(ComboBox2.Text))
        'Обрезание координат с конца
        If ComboBox3.Text <> "0" Then Coordinate = Microsoft.VisualBasic.Left(Coordinate, Len(Coordinate) - Val(ComboBox3.Text))
        Return Coordinate
    End Function

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            T = TextBox1.Text
            DriveListBox1.Drive = System.IO.Path.GetPathRoot(T)
            DirListBox1.Path = System.IO.Path.GetDirectoryName(T)
            FileListBox1.FileName = System.IO.Path.GetFileName(T)
        End If
    End Sub

    ' Копирование в буфер обмена содержимое TextBox1
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = My.Computer.Clipboard.GetText()
        T = TextBox1.Text
        DriveListBox1.Drive = System.IO.Path.GetPathRoot(T)
        DirListBox1.Path = System.IO.Path.GetDirectoryName(T)
        FileListBox1.FileName = System.IO.Path.GetFileName(T)
    End Sub

    ' Копирование в буфер обмена содержимое окна RichTextBox1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        S = Replace(RichTextBox1.Text, Chr(10), Chr(13) + Chr(10))
        My.Computer.Clipboard.SetText(S, TextDataFormat.Text)
    End Sub

    ' Вставка из буфера обмена в TextBox1
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Computer.Clipboard.SetText(TextBox1.Text, TextDataFormat.Text)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Label2.Text = "PIN => TXT" Then Label2.Text = "PIN <= TXT" Else Label2.Text = "PIN => TXT"
        RadioButton5.Checked = True
        Call StrokaSostoyaniya()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FileListBox1.Refresh()
        FileListBox1.Focus()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        FileListBox1.Height = Me.Height - 470 + 199
        DirListBox1.Height = FileListBox1.Height
        GroupBox3.Location = New Point(12, Me.Height - 470 + 410)
    End Sub

End Class