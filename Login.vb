Public Class Login '
    'orgsize:432, 147
    'panel2 location 98, 33 
    '
    Private FileDirDesktop As String = "C:\Users\Admin\Desktop" & "\Users.R"
    Private FileDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) & "\Users.R"
    Private FileDirBackup As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Back_Up.R"
    Private CurrentLogger As User
    Dim Userlist As New List(Of User)
    Private FileString As String = ""
    Private FileStringBackup As String = ""
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        saveAll()
        End
    End Sub
    Private Sub ClearAll()
        Try
            IO.File.WriteAllText(FileDir, "")
            IO.File.WriteAllText(FileDirBackup, "")
            IO.File.Delete(FileDir)
            IO.File.Delete(FileDirBackup)
            MsgBox("[Command : clearall] " & vbNewLine & "Response : All Entries / Users Was Cleared !", MsgBoxStyle.Information)
            IO.File.Create(FileDir)
            IO.File.Create(FileDirBackup)
            MsgBox("Exception Hanlder : [Restarting]", MsgBoxStyle.Exclamation)
            Application.Restart()
        Catch ex As Exception
            MsgBox("Exception Hanlder : [" & ex.Message & "]")
        End Try

    End Sub
    Public Sub clout()
        clearx()
        cleary()
    End Sub
    Private Sub clearx()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub cleary()
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Checklogin()
        End Select
        If (TextBox2.Text.Equals("signu")) Then
            'signup
            Panel2.Visible = False
            Panel3.Location = Panel2.Location
            Panel3.Visible = True
            clearx()
            MsgBox("[Command : signup] " & vbNewLine & "Response : Create new User!", MsgBoxStyle.Information)

        End If
        If (TextBox2.Text.Equals("clearal")) Then
            ClearAll()
        End If

    End Sub
    Private Sub startranrat()

        Form1.Text &= " @ User : " & CurrentLogger.getname

        Form1.Show()

        Me.Visible = False
    End Sub
    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox1.Text.Replace(vbNewLine, "")
        End Select
        If (TextBox1.Text.Equals("Guest")) Then
            Dim RanRAT As New Form1
            RanRAT.Text &= " @ User : " & "Guest"
            RanRAT.ShowInTaskbar = False
            RanRAT.Show()
            RanRAT.Visible = True
            Me.Visible = False
        End If
    End Sub
    Private Sub Checklogin()
        
        If (Userlist.Count = 0) Then
            MsgBox("Unhandled Exception Found [Error type : Logical Error] " & vbNewLine & "Default Handler " & vbNewLine & " An Error Occured during decryption process " & vbNewLine & "Detailed Error : Password invalid charachter which is used in encryption process was typed in user password" & vbNewLine & "Signup : type command singup in password field", MsgBoxStyle.Critical)
            'signup
            Panel2.Visible = False
            Panel3.Location = Panel2.Location
            Panel3.Visible = True
            clearx()
            MsgBox("(Emergency Recall) [Command : signup] " & vbNewLine & "Response : Create new User!", MsgBoxStyle.Information)


        Else
            CurrentLogger = New User(TextBox1.Text, TextBox2.Text)
            'Creates Object user



            For Each user As User In Userlist

                If user.getname.Equals(CurrentLogger.getname) Then
                    If user.getpass.Equals(CurrentLogger.getpass) Then
                        startranrat()
                        Exit For
                    Else

                        MsgBox("Error  : User :- " & CurrentLogger.getname & " [Wrong Password] ", MsgBoxStyle.Critical)
                        clearx()
                    End If
                Else
                    MsgBox("Error  : User :- " & CurrentLogger.getname & " Not exists ", MsgBoxStyle.Critical)
                    clearx()
                End If
            Next
        End If

    End Sub
    Private Sub Createnew()
        CurrentLogger = New User(TextBox3.Text, TextBox4.Text)
        'Creates Object user
        If Userlist.Contains(CurrentLogger) Then
            MsgBox("Error  : User :- " & CurrentLogger.getname & " Already exists !", MsgBoxStyle.Information)
        Else
            Userlist.Add(CurrentLogger)
            saveAll()
            MsgBox("User : " & CurrentLogger.getname & " Created !", MsgBoxStyle.Information)
            'return to login
            Panel2.Visible = True
            Panel3.Location = Panel2.Location
            Panel3.Visible = False
            cleary()
            clearx()
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'signup
        Panel2.Visible = False
        Panel3.Location = Panel2.Location
        Panel3.Visible = True
        clearx()
    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
Reline:
        Dim P1 As String = InputBox("Enter new password", "Sign up password", "123456")
        Dim P2 As String = InputBox("Verify new password", "Sign up password", "123456")
        If (P1.Length = P2.Length) And P1.Length > 0 Then
            If P1.Equals(P2) Then
                TextBox4.Text = P1
                Createnew()
            Else
                MsgBox("Passwords don`t match each other ", MsgBoxStyle.Critical)
                GoTo Reline

            End If
        Else
            MsgBox("Please Don`t make Fun", MsgBoxStyle.Exclamation
            )
            MsgBox("Exiting", MsgBoxStyle.Critical)
            End
        End If


    End Sub
    Private Sub TextBox4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

        End Select
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'return to login
        Panel2.Visible = True
        Panel3.Location = Panel2.Location
        Panel3.Visible = False
        cleary()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If IO.File.Exists(FileDir) = True And IO.File.Exists(FileDirBackup) = True Then  'Here Ok
            If DecryptAll.Equals("password expetion") Then
                MsgBox("Unhandled Exception Found [Error type : Logical Error] " & vbNewLine & "Default Handler " & vbNewLine & " An Error Occured during decryption process " & vbNewLine & "Detailed Error : Password invalid charachter which is used in encryption process was typed in user password" & vbNewLine & "Signup : type command singup in password field", MsgBoxStyle.Critical)
                'signup
                Panel2.Visible = False
                Panel3.Location = Panel2.Location
                Panel3.Visible = True
                clearx()
                MsgBox("(Emergency Recall) [Command : signup] " & vbNewLine & "Response : Create new User!", MsgBoxStyle.Information)
            Else
                If DecryptAll.Equals(DecryptAllBackup) Then
                    Loadusers()
                ElseIf (DecryptAll.Length > DecryptAllBackup.Length Or DecryptAll.Length < DecryptAllBackup.Length) And DecryptAll.Length > 0 Then 'Users Changed value 
                    MsgBox("Failure : You Changed The Users Value [Cannot Read Values]" & vbNewLine & "[Handler] : Exit(0)", MsgBoxStyle.Critical)
                    End
                End If
            End If



            '########### End check file if 

        ElseIf IO.File.Exists(FileDir) = False And IO.File.Exists(FileDirBackup) = True Then  'Here not Ok
                MsgBox("Values File Deleted Manualy [Failure]" & vbNewLine & "[Handler] : Exit(0)", MsgBoxStyle.Critical)
                End
            ElseIf IO.File.Exists(FileDir) = True And IO.File.Exists(FileDirBackup) = False Then  'Here not Ok
                MsgBox("Values File Deleted Manualy [Failure]" & vbNewLine & "[Handler] : Exit(0)", MsgBoxStyle.Critical)
                End
            ElseIf IO.File.Exists(FileDir) = False And IO.File.Exists(FileDirBackup) = False Then  'create them 
                IO.File.Create(FileDir)
            IO.File.Create(FileDirBackup)
            MsgBox("Welcome to SaherBlueEagle RanRAT ", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub Loadusers()
        Try
            Dim Reads As String = FileString
            Dim ala As String() = Split(Reads, "====")
            For i As Integer = 0 To ala.Length - 1

                Dim usertype As String() = Split(ala(i), "||||")
                CurrentLogger = New User(usertype(0), usertype(1))
                Userlist.Add(CurrentLogger)

            Next
            CurrentLogger = Nothing
        Catch
        End Try

    End Sub

    Private Sub saveAll()
        Try
            Dim savestring As String = ""
            For Each user As User In Userlist
                savestring &= user.getname & "||||" & user.getpass & "===="
            Next
            EncryptAll(savestring)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed to Save inputs", MsgBoxStyle.Critical)
        End Try



    End Sub
    Private Sub EncryptAll(ByVal savestring As String) 'Encrypt before save
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(savestring)

        savestring = Convert.ToBase64String(byt)




        If savestring.Contains("M") Then
            savestring = savestring.Replace("M", "!!!")
        End If
        If savestring.Contains("/") Then
            savestring = savestring.Replace("/", "@@@")
        End If
        If savestring.Contains("y") Then
            savestring = savestring.Replace("y", "###")
        End If
        If savestring.Contains("A") Then
            savestring = savestring.Replace("A", "***")
        End If
        If savestring.Contains("U") Then
            savestring = savestring.Replace("U", "~~~")
        End If


        Dim byt2 As Byte() = System.Text.Encoding.UTF8.GetBytes(savestring)

        Dim password2 As String = Convert.ToBase64String(byt2)




        If password2.Contains("M") Then
            password2 = password2.Replace("M", "!!!")
        End If
        If password2.Contains("/") Then
            password2 = password2.Replace("/", "@@@")
        End If
        If password2.Contains("y") Then
            password2 = password2.Replace("y", "###")
        End If
        If password2.Contains("A") Then
            password2 = password2.Replace("A", "***")
        End If
        If savestring.Contains("U") Then
            savestring = savestring.Replace("U", "~~~")
        End If

        IO.File.WriteAllText(FileDir, password2)
        IO.File.WriteAllText(FileDirBackup, password2)
    End Sub
    Private Function DecryptAll() As String 'Decryt before Load

        Dim enc As String = IO.File.ReadAllText(FileDir)

        If enc.Length < 5 Then

        Else
            Try
                If enc.Contains("!!!") Then
                    enc = enc.Replace("!!!", "M")
                End If
                If enc.Contains("@@@") Then
                    enc = enc.Replace("@@@", "/")
                End If
                If enc.Contains("###") Then
                    enc = enc.Replace("###", "y")
                End If
                If enc.Contains("***") Then
                    enc = enc.Replace("***", "A")
                End If
                If enc.Contains("~~~") Then
                    enc = enc.Replace("~~~", "U")
                End If

                Dim encryptedKey As String = enc
                Dim bKey As Byte() = Convert.FromBase64String(encryptedKey)
                Dim decryptedKey As String = System.Text.Encoding.UTF8.GetString(bKey)

                '############### decrypt Space 2 


                If decryptedKey.Contains("!!!") Then
                    decryptedKey = decryptedKey.Replace("!!!", "M")
                End If
                If decryptedKey.Contains("@@@") Then
                    decryptedKey = decryptedKey.Replace("@@@", "/")
                End If
                If decryptedKey.Contains("###") Then
                    decryptedKey = decryptedKey.Replace("###", "y")
                End If
                If decryptedKey.Contains("***") Then
                    decryptedKey = decryptedKey.Replace("***", "A")
                End If
                If enc.Contains("~~~") Then
                    enc = enc.Replace("~~~", "U")
                End If

                Dim encryptedKey2 As String = decryptedKey
                Dim bKey2 As Byte() = Convert.FromBase64String(encryptedKey2)
                Dim decryptedKey2 As String = System.Text.Encoding.UTF8.GetString(bKey2)
                FileString = decryptedKey2
            Catch ex As Exception
                FileString = "password expetion"
            End Try

        End If
        Return FileString
    End Function
    Private Function DecryptAllBackup() As String 'Decryt before Load

        Dim enc As String = IO.File.ReadAllText(FileDirBackup)

        If enc.Length < 5 Then

        Else
            Try
                If enc.Contains("!!!") Then
                    enc = enc.Replace("!!!", "M")
                End If
                If enc.Contains("@@@") Then
                    enc = enc.Replace("@@@", "/")
                End If
                If enc.Contains("###") Then
                    enc = enc.Replace("###", "y")
                End If
                If enc.Contains("***") Then
                    enc = enc.Replace("***", "A")
                End If
                Dim encryptedKey As String = enc
                Dim bKey As Byte() = Convert.FromBase64String(encryptedKey)
                Dim decryptedKey As String = System.Text.Encoding.UTF8.GetString(bKey)

                '############### decrypt Space 2 


                If decryptedKey.Contains("!!!") Then
                    decryptedKey = decryptedKey.Replace("!!!", "M")
                End If
                If decryptedKey.Contains("@@@") Then
                    decryptedKey = decryptedKey.Replace("@@@", "/")
                End If
                If decryptedKey.Contains("###") Then
                    decryptedKey = decryptedKey.Replace("###", "y")
                End If
                If decryptedKey.Contains("***") Then
                    decryptedKey = decryptedKey.Replace("***", "A")
                End If
                Dim encryptedKey2 As String = decryptedKey
                Dim bKey2 As Byte() = Convert.FromBase64String(encryptedKey2)
                Dim decryptedKey2 As String = System.Text.Encoding.UTF8.GetString(bKey2)
                FileStringBackup = decryptedKey2
            Catch ex As Exception
                FileStringBackup = "password expetion"
            End Try

        End If
        Return FileStringBackup
    End Function
    Private Sub CheckBackup()

    End Sub

End Class