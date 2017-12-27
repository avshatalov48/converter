Imports System
Imports System.IO
Imports System.Text

Public Class Rescue

    Dim FileNameApr, DataRecord, FileNameRecord, DirRecord, Log, FileNameIn, FileNameOut As String
    Dim I, J, K As Integer
    Dim S, SodFileApr(), CopyFiles() As String

    Private Sub Rescue_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' -----------------------------------------------------------------------------------------------------------
        ' Реестр ----------------------------------------------------------------------------------------------------
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Gisit\Converter")
        ' Запись в реестр координат X и Y ---------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_location_x", Me.Location.X)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_location_y", Me.Location.Y)
        ' Запись в реестр размеров окна -----------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_formwidth", Me.Width)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_formheight", Me.Height)
        ' Копировать растровые данные -------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_copy_rastr", CheckBox1.Checked)
        ' По завершении выдать отчёт --------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_otchet", CheckBox2.Checked)
        ' Исходный файл проекта -------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_old_apr", TextBox1.Text)
        ' Новый рабочий каталог -------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_new_dir", TextBox2.Text)
        ' Каталог шейпов --------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_shapes", TextBox3.Text)
        ' Каталог растров -------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_rasters", TextBox4.Text)
        ' Остальные файлы -------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_others", TextBox5.Text)
        ' Новый файл проекта ----------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_new_apr", TextBox6.Text)
        ' Drive -----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_drive", DriveListBox1.Drive)
        ' Dir -------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir", DirListBox1.Path)
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Rescue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("*.apr")
        ComboBox1.Items.Add("*.*")
        ComboBox1.SelectedIndex = 0
        TextBox3.Text = "\shapes"
        TextBox4.Text = "\rasters"
        TextBox5.Text = "\others"
        TextBox6.Text = "\___проект.apr"
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ' Чтение параметров из реестра ------------------------------------------------------------------------------
        ' Положение окна X и Y --------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_location_x", Nothing)
        J = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_location_y", Nothing)
        If I <= 0 Or J <= 0 Then I = 150 : J = 150
        Me.Location = New Point(I, J)
        ' Размеры окна ----------------------------------------------------------------------------------------------
        Me.Width = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_formwidth", Nothing)
        Me.Height = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_formheight", Nothing)
        ' Копировать растровые данные ------------------------------------------------------------------------------------------------
        CheckBox1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_copy_rastr", Nothing)
        ' По завершении выдать отчёт -------------------------------------------------------------------------------------------------
        CheckBox2.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_otchet", Nothing)
        ' Исходный файл проекта -------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_old_apr", Nothing)
        If S <> "" Then TextBox1.Text = S
        ' Новый рабочий каталог -------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_new_dir", Nothing)
        If S <> "" Then TextBox2.Text = S
        ' Каталог шейпов --------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_shapes", Nothing)
        If S <> "" Then TextBox3.Text = S
        ' Каталог растров -------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_rasters", Nothing)
        If S <> "" Then TextBox4.Text = S
        ' Остальные файлы -------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir_others", Nothing)
        If S <> "" Then TextBox5.Text = S
        ' Новый файл проекта ----------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_new_apr", Nothing)
        If S <> "" Then TextBox6.Text = S
        ' Drive -----------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_drive", Nothing)
        If S <> "" Then DriveListBox1.Drive = S
        ' Dir -------------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "rescue_dir", Nothing)
        If S <> "" Then DirListBox1.Path = S
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub DriveListBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedValueChanged
        DirListBox1.Path = DriveListBox1.Drive
    End Sub

    Private Sub DirListBox1_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirListBox1.Change
        FileListBox1.Path = DirListBox1.Path
        TextBox1.Text = DirListBox1.Path
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        FileListBox1.Pattern = ComboBox1.Text
    End Sub

    Private Sub FileListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged
        If FileListBox1.FileName <> "" Then
            TextBox1.Text = Replace(DirListBox1.Path & "\" & FileListBox1.FileName, "\\", "\")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And FileListBox1.FileName <> "" Then
            If TextBox2.Text <> "" Then
                If TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then

                    '----------------------------------------------------------------------------------------------------------
                    ' запись инфы в лог
                    Log = "Дата и время генерации: " & DateTime.Now & Chr(13) & Chr(10) & Chr(13) & Chr(10)

                    Log = Log & "Каталог запуска программы: " & My.Application.Info.DirectoryPath & Chr(13) & Chr(10)
                    Log = Log & "Пользователь: " & My.User.Name & Chr(13) & Chr(10)
                    Log = Log & My.Computer.Name & Chr(13) & Chr(10)
                    Log = Log & My.Computer.Info.OSFullName & Chr(13) & Chr(10)
                    Log = Log & My.Computer.Info.OSPlatform & Chr(13) & Chr(10)
                    Log = Log & My.Computer.Info.OSVersion & Chr(13) & Chr(10) & Chr(13) & Chr(10)

                    Log = Log & Label1.Text & " " & TextBox1.Text & Chr(13) & Chr(10)
                    Log = Log & Label2.Text & " " & TextBox2.Text & Chr(13) & Chr(10)
                    Log = Log & Label3.Text & " " & TextBox3.Text & Chr(13) & Chr(10)
                    Log = Log & Label4.Text & " " & TextBox4.Text & Chr(13) & Chr(10)
                    Log = Log & Label5.Text & " " & TextBox5.Text & Chr(13) & Chr(10)
                    Log = Log & Label6.Text & " " & TextBox6.Text & Chr(13) & Chr(10)
                    Log = Log & CheckBox1.Text & ": " & CheckBox1.Checked.ToString & Chr(13) & Chr(10)
                    Log = Log & CheckBox2.Text & ": " & CheckBox2.Checked.ToString & Chr(13) & Chr(10) & Chr(13) & Chr(10)

                    FileNameApr = Replace(DirListBox1.Path & "\" & FileListBox1.FileName, "\\", "\")
                    If System.IO.Path.GetExtension(FileNameApr) = ".apr" Then
                        ' Создание каталога нового проекта
                        My.Computer.FileSystem.CreateDirectory(TextBox2.Text)
                        ' \шейпы
                        My.Computer.FileSystem.CreateDirectory(TextBox2.Text & "\" & TextBox3.Text)
                        ' \растры
                        If CheckBox1.Checked = True Then My.Computer.FileSystem.CreateDirectory(TextBox2.Text & "\" & TextBox4.Text)
                        ' \others
                        My.Computer.FileSystem.CreateDirectory(TextBox2.Text & "\others")

                        ' Определение длины файла
                        I = 0
                        FileOpen(1, FileNameApr, OpenMode.Input)
                        While Not EOF(1)
                            I = I + 1 : LineInput(1)
                        End While
                        FileClose(1)
                        ' Изменение длины массива содержащего файл проекта
                        ReDim SodFileApr(I)

                        ' Считывание содержимого файла в массив
                        I = 0 : J = 0
                        FileOpen(1, FileNameApr, OpenMode.Input)
                        While Not EOF(1)
                            SodFileApr(I) = LineInput(1)
                            If (InStr(SodFileApr(I), "Path:") > 0) And (InStr(SodFileApr(I), "$AVEXT") < 1) Then
                                J = J + 1
                            End If
                            I = I + 1
                        End While
                        FileClose(1)
                        ' Изменение длины массива содержащего пути файлов
                        ReDim CopyFiles(J)

                        ' Изменение файла apr
                        K = 0
                        FileOpen(2, TextBox2.Text & TextBox6.Text, OpenMode.Output)
                        For J = 0 To I - 1
                            DataRecord = SodFileApr(J)

                            If (InStr(SodFileApr(J), "Path:") > 0) And (InStr(SodFileApr(J), "$AVEXT") < 1) Then
                                FileNameRecord = Replace(LCase(SodFileApr(J)), Chr(9) & "path:" & Chr(9), "")
                                FileNameRecord = Replace(FileNameRecord, """", "")
                                FileNameRecord = Replace(FileNameRecord, "/", "\")

                                If (File.Exists(FileNameRecord) = True) Or ((File.Exists(FileNameRecord) = False) And (System.IO.Path.GetExtension(FileNameRecord) = "")) Then
                                    'Файл Существует --------------------------------------------------------
                                    'Запись исходного пути файла
                                    CopyFiles(K) = FileNameRecord & "[*****]"
                                    FileNameRecord = System.IO.Path.GetFileName(FileNameRecord)
                                    DirRecord = LCase(TextBox2.Text)

                                    If (System.IO.Path.GetExtension(FileNameRecord)) = ".shp" Or (System.IO.Path.GetExtension(FileNameRecord)) = ".shx" Or (System.IO.Path.GetExtension(FileNameRecord)) = ".dbf" Then
                                        DirRecord = DirRecord & TextBox3.Text
                                    ElseIf (System.IO.Path.GetExtension(FileNameRecord)) = ".tif" Or (System.IO.Path.GetExtension(FileNameRecord)) = ".jpeg" Or (System.IO.Path.GetExtension(FileNameRecord)) = ".jpg" Or (System.IO.Path.GetExtension(FileNameRecord)) = ".bmp" Then
                                        DirRecord = DirRecord & TextBox4.Text
                                    ElseIf (System.IO.Path.GetExtension(FileNameRecord)) <> "" Then
                                        DirRecord = DirRecord & TextBox5.Text
                                    End If

                                    CopyFiles(K) = CopyFiles(K) & DirRecord & "\" & FileNameRecord
                                    DirRecord = Replace(DirRecord, "\", "/")
                                    DataRecord = Chr(9) & "Path:" & Chr(9) & """" & DirRecord & "/" & FileNameRecord & """"

                                    ' Без копирования растровых данных
                                    If (CheckBox1.Checked = False) And ((InStr(SodFileApr(J), ".tif") > 0) Or (InStr(SodFileApr(J), ".bmp") > 0) Or (InStr(SodFileApr(J), ".jpg") > 0) Or (InStr(SodFileApr(J), ".jpeg") > 0)) Then
                                        CopyFiles(K) = ""
                                        DataRecord = SodFileApr(J)
                                    End If
                                Else
                                    'Файл Не Существует --------------------------------------------------------
                                    CopyFiles(K) = ""
                                    DataRecord = SodFileApr(J)
                                    Log = Log & FileNameRecord & " - не существует!" & Chr(13) & Chr(10)
                                End If

                                K = K + 1
                            End If

                            PrintLine(2, DataRecord)

                        Next J
                        FileClose(2)

                        ' Удаление дублирующихся файлов
                        Array.Sort(CopyFiles)
                        Do
                            K = 0
                            For J = 1 To CopyFiles.Length - 1
                                If (CopyFiles(J) = CopyFiles(J - 1)) And (CopyFiles(J) <> "") Then CopyFiles(J) = "" : K = 1
                            Next J
                            Array.Sort(CopyFiles)
                        Loop While K <> 0

                        Log = Log & Chr(13) & Chr(10)

                        ' Копирование файлов
                        Rescue_Copy.Show()
                        For J = 0 To CopyFiles.Length - 1
                            Dim TempArray() As String = Split(CopyFiles(J), "[*****]")
                            If (TempArray.Length > 1) And (System.IO.Path.GetExtension(TempArray(0)) <> "") Then
                                FileNameIn = TempArray(0) : FileNameOut = TempArray(1)
                                Call ProgressBarCopy()
                                If (System.IO.Path.GetExtension(FileNameIn)) = ".shp" Then
                                    ' Копирование файла SHX
                                    FileNameIn = System.IO.Path.GetDirectoryName(FileNameIn) & "\" & System.IO.Path.GetFileNameWithoutExtension(FileNameIn) + ".shx"
                                    FileNameOut = System.IO.Path.GetDirectoryName(FileNameOut) & "\" & System.IO.Path.GetFileNameWithoutExtension(FileNameOut) + ".shx"
                                    Call ProgressBarCopy()
                                End If
                            End If
                        Next J
                        Rescue_Copy.Close()

                        MsgBox("Перенос проекта завершен!!!", MsgBoxStyle.Information, "")
                        Log = Log & Chr(13) & Chr(10) & "Перенос проекта завершен!!!"

                        If (CheckBox2.Checked = True) Then
                            FileOpen(2, TextBox2.Text & "\___otchet.txt", OpenMode.Output)
                            PrintLine(2, Log)
                            FileClose(2)
                            Call Shell("notepad.exe " & TextBox2.Text & "\___otchet.txt", AppWinStyle.NormalFocus)
                        End If

                    End If

                    '----------------------------------------------------------------------------------------------------------

                Else
                    MsgBox("Заполните все поля новых каталогов!", MsgBoxStyle.Exclamation, "Внимание!")
                End If

            Else
                MsgBox("Введите путь нового рабочего каталога!", MsgBoxStyle.Exclamation, "Внимание!")
            End If

        Else
            MsgBox("Выбирите исходный файл проекта!", MsgBoxStyle.Exclamation, "Внимание!")
        End If
    End Sub

    Sub ProgressBarCopy()
        Rescue_Copy.Label2.Text = "Из: " & FileNameIn
        Rescue_Copy.Label3.Text = "в: " & FileNameOut
        If Len(FileNameIn) > Len(FileNameOut) Then
            Rescue_Copy.Width = Rescue_Copy.Label2.Width + 40
        Else
            Rescue_Copy.Width = Rescue_Copy.Label3.Width + 40
        End If
        If Rescue_Copy.Width < 150 Then Rescue_Copy.Width = 150
        Rescue_Copy.Location = New Point(Math.Round((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2) - Math.Round(Rescue_Copy.Width / 2), Math.Round((My.Computer.Screen.WorkingArea.Height - Me.Height) / 2) - Math.Round(Rescue_Copy.Height / 2))
        Rescue_Copy.Update()
        Me.Update()
        Log = Log & FileNameIn
        If (File.Exists(FileNameOut) = True) Then
            Log = Log & " - перезаписан заново!"
        Else
            Log = Log & " - скопирован!"
        End If
        Log = Log & Chr(13) & Chr(10)
        My.Computer.FileSystem.CopyFile(FileNameIn, FileNameOut, True)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
        End If
    End Sub

End Class