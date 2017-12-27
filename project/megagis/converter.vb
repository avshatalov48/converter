Public Class Main_Form

    Dim Sod(10) As String

    Dim ShowZoomForm, ShowOptionsForm As Boolean

    Dim I As Integer
    Dim J As Integer
    Dim K As Integer
    Dim L As Integer
    Dim M As Integer

    Dim A As String
    Dim B As String
    Dim C As String
    Dim F As String
    Dim S As String
    Dim SK As String
    Dim T As String
    Dim Interval, Tabulation, Geonics, XreverseY, UnitedFiles As String

    Dim response As MsgBoxResult
    Dim infoReader As System.IO.FileInfo

    '������� ���� - ���� �� ���� �����
    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.Location = New Point(Me.Location.X, 0)
        Me.Height = Me.MaximumSize.Height
    End Sub

    '�������� �����
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' -----------------------------------------------------------------------------------------------------------
        ' ������ ----------------------------------------------------------------------------------------------------
        If My.Forms.Options_Form.Visible = True Then
            ' ���������� ���� X � Y -------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_x", My.Forms.Options_Form.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_location_y", My.Forms.Options_Form.Location.Y)
            ' �������� --------------------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_1", My.Forms.Options_Form.CheckBox1.Checked)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "options_izmenit_2", My.Forms.Options_Form.CheckBox2.Checked)
        End If
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        If My.Forms.Zoom_Form.Visible = True Then
            ' ���������� ���� X � Y -------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_x", My.Forms.Zoom_Form.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_location_y", My.Forms.Zoom_Form.Location.Y)
            ' ������� ---------------------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_mashtab", My.Forms.Zoom_Form.ComboBox1.Text)
            ' �������� --------------------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_znachenie", My.Forms.Zoom_Form.TextBox1.Text)
            ' ������� ���� ----------------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicaplan", My.Forms.Zoom_Form.ComboBox2.Text)
            ' ������� ��������� -----------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_edinicamestnost", My.Forms.Zoom_Form.ComboBox3.Text)
            ' ����������� �������� --------------------------------------------------------------------------------------
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "zoom_napravlenie", My.Forms.Zoom_Form.Label3.Text)
        End If
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Gisit\Converter")
        ' ������ � ������ ��������� X � Y ---------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_x", Me.Location.X)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_y", Me.Location.Y)
        ' ������ � ������ �������� ���� -----------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formwidth", Me.Width)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formheight", Me.Height)
        ' ������ ������� �������� -----------------------------------------------------------------------------------
        If RadioButton1.Checked = True Then I = 1
        If RadioButton2.Checked = True Then I = 2
        If RadioButton3.Checked = True Then I = 3
        If RadioButton4.Checked = True Then I = 4
        If RadioButton5.Checked = True Then I = 5
        If RadioButton6.Checked = True Then I = 6
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "operation", I)
        ' ���������� ------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "preview", CheckBox1.Checked)
        ' ��������� -------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "tabulation", CheckBox2.Checked)
        ' ������ ----------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "interval", CheckBox3.Checked)
        ' X<>Y ------------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "xreversey", CheckBox5.Checked)
        ' ���������� ------------------------------------------------------------------------------------------------
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "united", CheckBox6.Checked)
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

    '�������� �����
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Point(619, My.Computer.Screen.WorkingArea.Height)
        For I = 0 To 10
            ComboBox2.Items.Add(I)
            ComboBox3.Items.Add(I)
        Next I
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ' ������ ���������� �� ������� ------------------------------------------------------------------------------
        ' ��������� ���� X � Y --------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_x", Nothing)
        J = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "location_y", Nothing)
        If I <= 0 Or J <= 0 Then
            I = Math.Round((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2)
            J = Math.Round((My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        End If
        Me.Location = New Point(I, J)
        ' ������� ���� ----------------------------------------------------------------------------------------------
        Me.Width = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formwidth", Nothing)
        Me.Height = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "formheight", Nothing)
        ' ����� �������� --------------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "operation", Nothing)
        If I = 1 Then RadioButton1.Checked = True
        If I = 2 Then RadioButton2.Checked = True
        If I = 3 Then RadioButton3.Checked = True
        If I = 4 Then RadioButton4.Checked = True
        If I = 5 Then RadioButton5.Checked = True
        If I = 6 Then RadioButton6.Checked = True
        ' ���������� ------------------------------------------------------------------------------------------------
        CheckBox1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "preview", Nothing)
        If (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "preview", Nothing) = "") Then CheckBox1.Checked = True
        ' ��������� -------------------------------------------------------------------------------------------------
        CheckBox2.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "tabulation", Nothing)
        ' ������ ----------------------------------------------------------------------------------------------------
        CheckBox3.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "interval", Nothing)
        ' X<>Y ------------------------------------------------------------------------------------------------------
        CheckBox5.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "xreversey", Nothing)
        ' ���������� ------------------------------------------------------------------------------------------------
        CheckBox6.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "united", Nothing)
        ' Geonics ---------------------------------------------------------------------------------------------------
        CheckBox4.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "geonics", Nothing)
        ' CutX ------------------------------------------------------------------------------------------------------
        ComboBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cutx", Nothing)
        If ComboBox2.Text = "" Then ComboBox2.SelectedIndex = 0
        ' CutY ------------------------------------------------------------------------------------------------------
        ComboBox3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "cuty", Nothing)
        If ComboBox3.Text = "" Then ComboBox3.SelectedIndex = 0
        ' PlusX -----------------------------------------------------------------------------------------------------
        TextBox2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusx", Nothing)
        ' PlusY -----------------------------------------------------------------------------------------------------
        TextBox3.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "plusy", Nothing)
        ' ������� ������ --------------------------------------------------------------------------------------------
        FastButtonLabel1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "fastbutton1", Nothing)
        FastButtonLabel2.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "fastbutton2", Nothing)
        ' ������� ������ 1
        If (FastButtonLabel1.Text = "" Or LCase(FastButtonLabel1.Text) = LCase("G:\����������") Or LCase(FastButtonLabel1.Text) = LCase("G:\����������\")) Then
            FastButtonLabel1.Text = "G:\����������\"
            Button1.Text = "�"
        End If
        If (FastButtonLabel1.Text = "" Or LCase(FastButtonLabel1.Text) = LCase("H:\�����������") Or LCase(FastButtonLabel1.Text) = LCase("H:\�����������\")) Then
            FastButtonLabel1.Text = "H:\�����������\"
            Button1.Text = "�"
        End If
        ToolTip1.SetToolTip(Me.Button1, FastButtonLabel1.Text)
        If ((Button1.Text <> "�") And (Button1.Text <> "�")) Then Button1.Text = "1"
        ' ������� ������ 2
        If (FastButtonLabel2.Text = "" Or LCase(FastButtonLabel2.Text) = LCase("H:\�����������") Or LCase(FastButtonLabel2.Text) = LCase("H:\�����������\")) Then
            FastButtonLabel2.Text = "H:\�����������\"
            Button2.Text = "�"
        End If
        If (FastButtonLabel2.Text = "" Or LCase(FastButtonLabel2.Text) = LCase("G:\����������") Or LCase(FastButtonLabel2.Text) = LCase("G:\����������\")) Then
            FastButtonLabel2.Text = "G:\����������\"
            Button2.Text = "�"
        End If
        ToolTip1.SetToolTip(Me.Button2, FastButtonLabel2.Text)
        If ((Button2.Text <> "�") And (Button2.Text <> "�")) Then Button2.Text = "2"
        ' Drive -----------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "drive", Nothing)
        If S <> "" Then DriveListBox1.Drive = S
        ' Dir -------------------------------------------------------------------------------------------------------
        S = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "dir", Nothing)
        If S <> "" Then DirListBox1.Path = S
        ' -----------------------------------------------------------------------------------------------------------
        ' -----------------------------------------------------------------------------------------------------------
        ComboBox1.Items.Add("*.csv;*.prt;*.txt")
        ComboBox1.Items.Add("*.csv")
        ComboBox1.Items.Add("*.prt")
        ComboBox1.Items.Add("*.txt")
        ComboBox1.SelectedIndex = 0
        Call StrokaSostoyaniya()
        ' -----------------------------------------------------------------------------------------------------------
        ' ������������ ----------------------------------------------------------------------------------------------
        I = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Gisit\Converter", "opacity", Nothing)
        If (I > 100 Or I = 0) Then I = 100
        If I < 30 Then I = 30
        My.Forms.Options_Form.TrackBar1.Value = I
        Me.Opacity = My.Forms.Options_Form.TrackBar1.Value / 100
        My.Forms.Zoom_Form.Opacity = My.Forms.Options_Form.TrackBar1.Value / 100
        My.Forms.Options_Form.Opacity = My.Forms.Options_Form.TrackBar1.Value / 100
        My.Forms.Rescue.Opacity = My.Forms.Options_Form.TrackBar1.Value / 100
        My.Forms.Rescue_Copy.Opacity = My.Forms.Options_Form.TrackBar1.Value / 100
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
        My.Forms.Options_Form.TextBox1.Text = DirListBox1.Path
        My.Forms.Options_Form.TextBox2.Text = DirListBox1.Path
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        FileListBox1.Pattern = ComboBox1.Text
    End Sub

    Private Sub FileListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged
        RichTextBox1.Text = ""
        If FileListBox1.FileName <> "" Then
            ' ��� ���������� �����
            If Len(DirListBox1.Path) > 2 Then S = "\" Else S = ""
            F = DirListBox1.Path & S & FileListBox1.FileName
            TextBox1.Text = F
            ' ����������
            If CheckBox1.Checked = True Then
                infoReader = My.Computer.FileSystem.GetFileInfo(F)
                response = MsgBoxResult.Ignore
                If (infoReader.Length > 15000) Then response = MsgBox("���� " & F & " ����� ������ ����� 15 �����, ��� ����� ���������� ��� ����������. ���������� ��� ��������?", MsgBoxStyle.YesNo, "��������")
                If response = MsgBoxResult.No Then
                Else
                    FileOpen(1, F, OpenMode.Input)
                    While Not EOF(1)
                        S = LineInput(1)
                        RichTextBox1.Text = RichTextBox1.Text + S + Chr(13)
                    End While
                    FileClose(1)
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        RichTextBox1.Text = ""
        If CheckBox1.Checked = True And FileListBox1.FileName <> "" Then
            ' ��� ���������� �����
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

            For M = 0 To FileListBox1.SelectedItems.Count - 1

                ' ��� ���������� �����
                If Len(DirListBox1.Path) > 2 Then S = "\" Else S = ""
                F = DirListBox1.Path & S & FileListBox1.SelectedItems.Item(M)

                If (CheckBox6.Checked = True And M = 0) Then
                    FileOpen(2, DirListBox1.Path & S & System.IO.Path.GetFileNameWithoutExtension(FileListBox1.SelectedItems.Item(M)) + "_�����" + System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)), OpenMode.Output)
                    MessageBox.Show("�������� ""�����������"" ��������� � ������ ����-������������." & Chr(13) & "�������� ������.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                ' ����������� ����� ����� � �������� ����� ����� �������
                I = 0
                FileOpen(1, F, OpenMode.Input)
                While Not EOF(1)
                    I = I + 1 : LineInput(1)
                End While
                FileClose(1)

                ReDim Sod(I + 5)

                ' TXT <> CSV -----------------------------------------------------------------------------------------------
                If RadioButton1.Checked = True Then
                    If System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".txt" Or System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".csv" Then
                        FileOpen(1, F, OpenMode.Input)

                        If System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".csv" Then
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

                        If CheckBox6.Checked = False Then FileOpen(2, Mid(F, 1, Len(F) - 3) + S, OpenMode.Output)
                        While Not EOF(1)
                            S = Replace(LineInput(1), Chr(9), " ")
                            S = Replace(S, ";", " ")
                            S = SpaceDestroy(S)
                            S = Replace(S, A, B)
                            Dim TempArray() As String = Split(S, " ")

                            '��������� ���������
                            TempArray(0) = CoordinatesCuts(TempArray(0))
                            TempArray(1) = CoordinatesCuts(TempArray(1))
                            '�������� � X
                            TempArray(0) = TextBox2.Text & TempArray(0)
                            '�������� � Y
                            TempArray(1) = TextBox3.Text & TempArray(1)

                            If CheckBox5.Checked = True Then Array.Reverse(TempArray)
                            If S <> "" Then PrintLine(2, TempArray(0) & T & TempArray(1))
                            If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                        End While
                        If CheckBox6.Checked = False Then FileClose(2)
                        FileClose(1)
                        Label1.Text = "����������� " & FileListBox1.SelectedItems.Item(M) & " ���������"
                    End If
                End If


                ' PRT => CSV => TXT ----------------------------------------------------------------------------------------
                If RadioButton2.Checked = True Or RadioButton3.Checked = True Then

                    If System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".prt" Then
                        I = 0
                        '���-�� ����� � ����� + ����������� ���� �������
                        FileOpen(1, F, OpenMode.Input)
                        While Not EOF(1)
                            I = I + 1
                            Sod(I) = SpaceDestroy(LCase(LineInput(1)))
                            ' �������
                            If InStr(Sod(I), "������� �������") <> 0 Then L = 3
                            ' �������� ����
                            If InStr(Sod(I), "�����") <> 0 Then L = 1
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

                        If CheckBox6.Checked = False Then FileOpen(2, Mid(F, 1, Len(F) - 3) + S, OpenMode.Output) '�����������

                        '���������� �����
                        'For J = 5 To I - L Step 2

                        For J = 1 To I - L
                            S = ""
                            If (InStr(Sod(J), "��������") = 0) And (InStr(Sod(J), "___") = 0) And (Sod(J) <> "") And (InStr(Sod(J), "��hh��") = 0) And (InStr(Sod(J), "���������") = 0) And (InStr(Sod(J), "��������") = 0) And (InStr(Sod(J), "�����") = 0) Then
                                Dim TempArray() As String = Split(Sod(J), " ")
                                If ((J > I - L - 2) And (L = 1) And (TempArray.Length > 2)) Then
                                    '��������� ���������
                                    TempArray(0) = CoordinatesCuts(TempArray(0))
                                    TempArray(1) = CoordinatesCuts(TempArray(1))
                                    '�������� � X
                                    TempArray(0) = TextBox2.Text & TempArray(0)
                                    '�������� � Y
                                    TempArray(1) = TextBox3.Text & TempArray(1)

                                    If CheckBox5.Checked = True Then C = TempArray(0) : TempArray(0) = TempArray(1) : TempArray(1) = C
                                    S = TempArray(0) & T & TempArray(1)
                                ElseIf TempArray.Length > 3 Then
                                    '��������� ���������
                                    TempArray(1) = CoordinatesCuts(TempArray(1))
                                    TempArray(2) = CoordinatesCuts(TempArray(2))
                                    '�������� � X
                                    TempArray(1) = TextBox2.Text & TempArray(1)
                                    '�������� � Y
                                    TempArray(2) = TextBox3.Text & TempArray(2)

                                    If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                                    S = TempArray(1) & T & TempArray(2)
                                End If
                                S = Replace(S, A, B) '������ ��������
                                If S <> "" Then PrintLine(2, S) '������ � ����
                                If S <> "" And CheckBox3.Checked = True Then PrintLine(2) '����� ������
                            End If
                        Next J

                        If CheckBox6.Checked = False Then FileClose(2) '�����������
                        Label1.Text = "����������� " & FileListBox1.SelectedItems.Item(M) & " ���������"
                    End If

                End If

                '�� => TXT -----------------------------------------------------------------------------------------
                If RadioButton4.Checked = True And System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".txt" Then
                    I = 0
                    '���-�� ����� � �����
                    FileOpen(1, F, OpenMode.Input)
                    While Not EOF(1)
                        S = LineInput(1)
                        '���������� ����� �� 2-� �����
                        If (InStr(S, "NAME=") <> 0 Or InStr(S, "KOLTCH=") <> 0) Then S = ""
                        S = Replace(S, ",", " ")
                        S = SpaceDestroy(S)
                        If S = "/" Then Exit While
                        If S <> "" Then I = I + 1 : Sod(I) = S
                    End While
                    FileClose(1)

                    If CheckBox4.Checked = True Then S = "_geonics.txt" Else S = "_text.txt"

                    If CheckBox6.Checked = False Then FileOpen(2, Mid(F, 1, Len(F) - 4) + S, OpenMode.Output)

                    If CheckBox2.Checked = True Then T = Chr(9) Else T = " "

                    For J = 1 To I
                        Dim TempArray() As String = Split(Sod(J), " ")

                        '��������� ���������
                        TempArray(1) = CoordinatesCuts(TempArray(1))
                        TempArray(2) = CoordinatesCuts(TempArray(2))
                        '�������� � X
                        TempArray(1) = TextBox2.Text & TempArray(1)
                        '�������� � Y
                        TempArray(2) = TextBox3.Text & TempArray(2)

                        ' ������ ������� X � Y
                        If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                        If CheckBox4.Checked = True Then
                            S = TempArray(0) + T + TempArray(1) + T + TempArray(2) + T + TempArray(3)
                        Else
                            S = TempArray(1) + T + TempArray(2)
                        End If
                        If S <> "" Then PrintLine(2, S)
                        If S <> "" And CheckBox3.Checked = True Then PrintLine(2) '������� ������
                    Next J

                    If CheckBox6.Checked = False Then FileClose(2)
                    Label1.Text = "����������� " & FileListBox1.SelectedItems.Item(M) & " ���������"
                End If


                'OL => TXT -----------------------------------------------------------------------------------------
                If RadioButton6.Checked = True And System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".txt" Then
                    '���-�� ����� � �����
                    FileOpen(1, F, OpenMode.Input)
                    '���������� ����� �� 8-� �����
                    For J = 1 To 8 : LineInput(1) : Next J
                    I = 0
                    While Not EOF(1)
                        S = LineInput(1)
                        S = Replace(S, Chr(179), " ")
                        S = SpaceDestroy(S)
                        If (InStr(S, Chr(192)) <> 0) Then Exit While
                        If S <> "" Then I = I + 1 : Sod(I) = S
                    End While
                    FileClose(1)

                    If Sod(1) = Sod(I) Then I = I - 1

                    S = "_ol.txt"

                    If CheckBox6.Checked = False Then FileOpen(2, Mid(F, 1, Len(F) - 4) + S, OpenMode.Output)

                    If CheckBox2.Checked = True Then T = Chr(9) Else T = " "

                    For J = 1 To I Step 2
                        Dim TempArray() As String = Split(Sod(J), " ")
                        If J < 2 Then
                            If (Mid$(TempArray(1), 1, 1) = "3" Or Mid$(TempArray(1), 1, 1) = "4") And (Mid$(TempArray(2), 1, 2) = "13" Or Mid$(TempArray(2), 1, 2) = "12") Then
                                MessageBox.Show("��������� ������� ����� ������� ��������� 48-�� ����!" & Chr(13) & "��� ������������ �������� � ��������� ObjectLand ����������� ������ 7 �������� ����������." & Chr(13) & "��������� �������� ��������� �� ��� Y.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                        '���������(���������)
                        TempArray(1) = CoordinatesCuts(TempArray(1))
                        TempArray(2) = CoordinatesCuts(TempArray(2))
                        '�������� � X
                        TempArray(1) = TextBox2.Text & TempArray(1)
                        '�������� � Y
                        TempArray(2) = TextBox3.Text & TempArray(2)
                        '������ ������� X � Y
                        If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                        S = TempArray(1) + T + TempArray(2)
                        If S <> "" Then PrintLine(2, S)
                        If S <> "" And CheckBox3.Checked = True Then PrintLine(2) '������� ������
                    Next J

                    If CheckBox6.Checked = False Then FileClose(2)
                    Label1.Text = "����������� " & FileListBox1.SelectedItems.Item(M) & " ���������"
                End If


                'PIN <=> TXT -----------------------------------------------------------------------------------------
                If RadioButton5.Checked = True And System.IO.Path.GetExtension(FileListBox1.SelectedItems.Item(M)) = ".txt" Then

                    I = 0 : SK = ""

                    If Label2.Text = "PIN <= TXT" Then
                        FileOpen(1, F, OpenMode.Input)
                        While Not EOF(1)
                            S = Replace(LineInput(1), ",", ".")
                            S = Replace(S, Chr(9), " ")
                            S = SpaceDestroy(S)
                            If S <> "" Then
                                Dim TempArray() As String = Split(S, " ")

                                '��������� ���������
                                TempArray(0) = CoordinatesCuts(TempArray(0))
                                TempArray(1) = CoordinatesCuts(TempArray(1))
                                '�������� � X
                                TempArray(0) = TextBox2.Text & TempArray(0)
                                '�������� � Y
                                TempArray(1) = TextBox3.Text & TempArray(1)

                                If I < 1 Then
                                    ' ����������� ������� ���������
                                    If (Mid$(TempArray(0), 1, 2) = "57" Or Mid$(TempArray(0), 1, 2) = "58") And (Mid$(TempArray(1), 1, 2) = "75" Or Mid$(TempArray(1), 1, 2) = "74") Then SK = "SK42"
                                    If (Mid$(TempArray(0), 1, 1) = "3" Or Mid$(TempArray(0), 1, 1) = "4") And (Mid$(TempArray(1), 1, 2) = "13" Or Mid$(TempArray(1), 1, 2) = "12") Then SK = "SK48"
                                    If (Mid$(TempArray(0), 1, 2) = "57" Or Mid$(TempArray(0), 1, 2) = "58") And (Mid$(TempArray(1), 1, 2) = "33" Or Mid$(TempArray(1), 1, 2) = "32") Then SK = "SK63"
                                    ' �������� ����� � �������� ��� ��� ������
                                    If CheckBox6.Checked = False Then FileOpen(2, Mid(F, 1, Len(F) - 4) & "_pin_" & LCase(SK) & ".txt", OpenMode.Output)
                                    ' ������� ����� Pinnacle
                                    PrintLine(2, " Table calculator")
                                    PrintLine(2)
                                    PrintLine(2)
                                    PrintLine(2, " Left pane :")
                                    PrintLine(2, " Grid : " & SK & " ")
                                    If (SK = "SK63") Then
                                        response = MsgBoxResult.Ignore
                                        response = MsgBox("���� " & F & " �������� ���������� � ������� 63-�� ����. ������� 3 ���� (��) ��� 4 ���� (���)?", MsgBoxStyle.YesNo, "��������")
                                        If response = MsgBoxResult.Yes Then
                                            PrintLine(2, " Zone:  3 Zone")
                                        Else
                                            PrintLine(2, " Zone:  4 Zone")
                                        End If
                                    End If
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
                        If CheckBox6.Checked = False Then FileClose(2)
                    End If

                    If Label2.Text = "PIN => TXT" Then
                        FileOpen(1, F, OpenMode.Input)
                        If CheckBox6.Checked = False Then FileOpen(2, Replace(Mid(F, 1, Len(F) - 4) & ".txt", "_pin", ""), OpenMode.Output)
                        While Not EOF(1)
                            If InStr(LineInput(1), "Height,m") <> 0 Then Exit While
                        End While
                        While Not EOF(1)
                            S = LineInput(1)
                            If InStr(S, "-----------") <> 0 Then Exit While
                            S = Replace(S, ",", ".")
                            S = Replace(S, Chr(9), " ")
                            S = SpaceDestroy(S)
                            If S <> "" Then
                                Dim TempArray() As String = Split(S, " ")

                                '��������� ���������
                                TempArray(1) = CoordinatesCuts(TempArray(1))
                                TempArray(2) = CoordinatesCuts(TempArray(2))
                                '�������� � X
                                TempArray(1) = TextBox2.Text & TempArray(1)
                                '�������� � Y
                                TempArray(2) = TextBox3.Text & TempArray(2)

                                If CheckBox5.Checked = True Then Array.Reverse(TempArray, 1, 2)
                                If CheckBox2.Checked = True Then T = Chr(9) Else T = " "
                                PrintLine(2, TempArray(1) & T & TempArray(2))
                                If S <> "" And CheckBox3.Checked = True Then PrintLine(2)
                            End If
                        End While
                        FileClose(1)
                        If CheckBox6.Checked = False Then FileClose(2)
                    End If

                    Label1.Text = "����������� " & FileListBox1.SelectedItems.Item(M) & " ���������"

                End If

            Next M
            If CheckBox6.Checked = True Then FileClose(2)
        Else
            MessageBox.Show("�������� ����������� ���� � ��������� ��������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        FileListBox1.Refresh()
        FileListBox1.Focus()
    End Sub

    ' ������� ������ 1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DriveListBox1.Drive = Mid(FastButtonLabel1.Text, 1, 3)
        DirListBox1.Path = FastButtonLabel1.Text
        FileListBox1.Path = FastButtonLabel1.Text
    End Sub

    ' ������� ������ 2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DriveListBox1.Drive = Mid(FastButtonLabel2.Text, 1, 3)
        DirListBox1.Path = FastButtonLabel2.Text
        FileListBox1.Path = FastButtonLabel2.Text
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

    ' ��������� ��������� ������������� OL => TXT
    Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Call StrokaSostoyaniya()
    End Sub

    '����������� - ����� ���������
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Tabulation = ""
        If CheckBox2.CheckState = CheckState.Checked Then Tabulation = "+���������"
        Call StrokaSostoyaniya()
    End Sub

    '����������� - ����� ������
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Interval = ""
        If CheckBox3.CheckState = CheckState.Checked Then Interval = "+������"
        Call StrokaSostoyaniya()
    End Sub

    '����������� - ����� ������� Geonics
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Geonics = ""
        If CheckBox4.CheckState = CheckState.Checked Then Geonics = "+Geonics" : CheckBox2.Checked = True
        Call StrokaSostoyaniya()
    End Sub

    '����������� - �������� ������� X � Y
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        XreverseY = ""
        If CheckBox5.CheckState = CheckState.Checked Then XreverseY = "+X<>Y"
        Call StrokaSostoyaniya()
    End Sub

    '����������� - ���������� �����
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        UnitedFiles = ""
        If CheckBox6.CheckState = CheckState.Checked Then UnitedFiles = "+���������� �����"
        Call StrokaSostoyaniya()
    End Sub

    ' ������������� ������ ������ ��������� -------------------------------------------------------------------------
    Sub StrokaSostoyaniya()
        CheckBox4.Visible = False
        If RadioButton1.Checked = True Then A = "TXT <> CSV"
        If RadioButton2.Checked = True Then A = "PRT => TXT"
        If RadioButton3.Checked = True Then A = "PRT => CSV"
        If RadioButton4.Checked = True Then A = "���-����������� => TXT" : CheckBox4.Visible = True
        If RadioButton5.Checked = True And Label2.Text = "PIN => TXT" Then A = "JNS Pinnacle => TXT"
        If RadioButton5.Checked = True And Label2.Text = "PIN <= TXT" Then A = "JNS Pinnacle <= TXT"
        If RadioButton6.Checked = True Then A = "ObjectLand => TXT"
        S = " ("
        If Tabulation <> "" Or Interval <> "" Or Geonics <> "" Or UnitedFiles <> "" Then
            If Tabulation <> "" Then S = S & " " & Tabulation
            If Interval <> "" Then S = S & " " & Interval
            If XreverseY <> "" Then S = S & " " & XreverseY
            If UnitedFiles <> "" Then S = S & " " & UnitedFiles
            If Geonics <> "" And RadioButton4.Checked = True Then S = S & " " & Geonics
        End If
        S = S & " )"
        Label1.Text = "������ ����� " & A & S
    End Sub

    ' ������������� �������� ������� �������� -------------------------------------------------------------------------
    Function SpaceDestroy(ByVal TempString As String) As String
        '������ ������� � ������ � ����� ������
        TempString = Trim(TempString)
        '�������� ������� �������� � ����������
        Do
            K = Len(TempString)
            TempString = Replace(TempString, "  ", " ")
        Loop While K <> Len(TempString)
        Return TempString
    End Function

    ' ������������� ��������� ��������� -------------------------------------------------------------------------------
    Function CoordinatesCuts(ByVal Coordinate As String) As String
        '��������� ��������� � ������
        If ComboBox2.Text <> "0" Then Coordinate = Microsoft.VisualBasic.Right(Coordinate, Len(Coordinate) - Val(ComboBox2.Text))
        '��������� ��������� � �����
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

    '����������� � ����� ������ ���������� TextBox1
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(TextBox1.Text, TextDataFormat.Text)
    End Sub

    '������� �� ������ ������ � TextBox1
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = My.Computer.Clipboard.GetText()
        T = TextBox1.Text
        DriveListBox1.Drive = System.IO.Path.GetPathRoot(T)
        DirListBox1.Path = System.IO.Path.GetDirectoryName(T)
        FileListBox1.FileName = System.IO.Path.GetFileName(T)
    End Sub

    '����������� � ����� ������ ���������� ���� RichTextBox1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Clipboard.Clear()
        S = Replace(RichTextBox1.Text, Chr(10), Chr(13) + Chr(10))
        My.Computer.Clipboard.SetText(S, TextDataFormat.Text)
    End Sub

    '������������ ������� PIN <=> TXT
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Label2.Text = "PIN => TXT" Then Label2.Text = "PIN <= TXT" Else Label2.Text = "PIN => TXT"
        RadioButton5.Checked = True
        Call StrokaSostoyaniya()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FileListBox1.Refresh()
        FileListBox1.Focus()
    End Sub

    '��������� �������� �������� �����
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'FileListBox1.Height = Me.Height - Me.MinimumSize.Height + 199
        'DirListBox1.Height = FileListBox1.Height

        ' ������� � ��������������� �������� ���� ��� ������������ ���������
        If Me.WindowState = FormWindowState.Minimized Then
            If My.Forms.Zoom_Form.Visible = True Then
                ShowZoomForm = True
            Else
                ShowZoomForm = False
            End If
            If ShowZoomForm = True Then My.Forms.Zoom_Form.Visible = False
            If My.Forms.Options_Form.Visible = True Then
                ShowOptionsForm = True
            Else
                ShowOptionsForm = False
            End If
            If ShowOptionsForm = True Then My.Forms.Options_Form.Visible = False
        Else
            If ShowZoomForm = True Then My.Forms.Zoom_Form.Visible = True
            If ShowOptionsForm = True Then My.Forms.Options_Form.Visible = True
        End If
    End Sub

    '������ ����������� "��������� ��������"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        With My.Forms.Zoom_Form
            If (.Visible = True) Then .Visible = False Else .Visible = True
        End With
    End Sub

    '������ ����������� "�����"
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        With My.Forms.Options_Form
            If (.Visible = True) Then .Visible = False Else .Visible = True
        End With
    End Sub

    '������ ����������� "����������� �������"
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        With My.Forms.Rescue
            If (.Visible = True) Then .Visible = False Else .Visible = True
        End With
    End Sub

End Class