Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Public Class Desktop
    Public F As Form1
    Public Sock As Integer
    Private oldKeyboardkey As String = "old"
    Public Sz As Size
    Private Keyboardkey As String = ""
    Dim XTHX As Threading.Thread
    Private Sub Desktop_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For i As Integer = 0 To 13
            c1.Items.Add(QZ(i))
        Next
        For i As Integer = 1 To 10
            c2.Items.Add(i)
        Next
        p1.Image = New Bitmap(Sz.Width, Sz.Height)
        c1.SelectedIndex = 4
        c2.SelectedIndex = 4
        '   AddHandler Control.KeyUp, New KeyEventHandler(AddressOf Me.KUP)
        '  AddHandler Control.KeyDown, New KeyEventHandler(AddressOf Me.KDW)
    End Sub

    Public Sub PktToImage(ByVal BY As Byte())

        If Button1.Text = "Stop" Then

            '   F.s.Send(Sock, "@" & F.YY & c1.SelectedIndex & F.YY & c2.Text & F.YY & c.Value)
            Me.p1.Focus()
            If op = Nothing Then
            Else
                If Button1.Text = "Stop" Then

                    Dim pp As New Point(0, 0)
                    pp.X = op.X
                    pp.Y = op.Y
                    op = Nothing
                    If CheckBox2.Checked = True Then
                        F.s.Send(Sock, "$" & F.YY & pp.X & F.YY & pp.Y & F.YY)
                    End If

                End If
            End If
        End If
        Dim B As Array = fx(BY, "sblj3")
        Dim Q As New IO.MemoryStream(CType(B(1), Byte()))
        Dim L As Bitmap = Image.FromStream(Q)
        Dim QQ As String() = Split(BS(B(0)), ",")
        Me.Text = "Remote Desktop  " & "Size: " & siz(BY.LongLength) & " ,Changes: " & QQ.Length - 2
        Dim K As Bitmap = p1.Image.GetThumbnailImage(CType(Split(QQ(0), ".")(0), Integer), CType(Split(QQ(0), ".")(1), Integer), Nothing, Nothing)
        Dim G As Graphics = Graphics.FromImage(K)
        Dim tp As Integer = 0
        For i As Integer = 1 To QQ.Length - 2
            Dim P As New Point(Split(QQ(i), ".")(0), Split(QQ(i), ".")(1))
            Dim SZ As New Size(L.Width, Split(QQ(i), ".")(2))
            G.DrawImage(L.Clone(New Rectangle(0, tp, L.Width, CType(Split(QQ(i), ".")(2), Integer)), L.PixelFormat), New Point(CType(Split(QQ(i), ".")(0), Integer), CType(Split(QQ(i), ".")(1), Integer)))
            If CheckBox1.Checked Then
                Dim r As New Rectangle(Split(QQ(i), ".")(0), Split(QQ(i), ".")(1), SZ.Width, SZ.Height)
                G.DrawRectangle(Pens.Red, r)
            End If
            tp += SZ.Height
        Next
        G.Dispose()
        p1.Image = K


    End Sub
    Function QZ(ByVal q As Integer) As Size
        Dim zs As New Size(Sz)
        Select Case q
            Case 0
                Return Sz
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
    Private Sub P1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseDown
        If CheckBox2.Checked = True Then
            Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
            Dim but As Integer
            If e.Button = Windows.Forms.MouseButtons.Left Then
                but = 2
            End If
            If e.Button = Windows.Forms.MouseButtons.Right Then
                but = 8
            End If
            F.s.Send(Sock, "#" & F.YY & PP.X & F.YY & PP.Y & F.YY & but)
        End If
    End Sub
    Private Sub P1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseUp
        If CheckBox2.Checked = True Then
            Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
            Dim but As Integer
            If e.Button = Windows.Forms.MouseButtons.Left Then
                but = 4
            End If
            If e.Button = Windows.Forms.MouseButtons.Right Then
                but = 16
            End If
            F.s.Send(Sock, "#" & F.YY & PP.X & F.YY & PP.Y & F.YY & but)
        End If

    End Sub
    Dim op As New Point(1, 1)
    Private Sub P1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseMove
        If CheckBox2.Checked = True Then
            If Button1.Text = "Stop" Then
                Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
                If PP <> op Then
                    op = PP

                End If

            End If
        End If
    End Sub

    Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs) Handles p1.MouseWheel
        Dim box As PictureBox = Me.p1
        SyncLock box
            If (Me.CheckBox2.Checked AndAlso (Me.Button1.Text <> "Start")) Then
                Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
                If PP <> op Then
                    op = PP

                    'F.s.Send(Sock, "w" & F.YY & PP.X & F.YY & PP.Y & F.YY & but)
                End If

                '   Me.sk.Send(String.Concat(New String() {"@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(&H800)}))
            End If
        End SyncLock
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            F.s.Send(Sock, "@" & F.YY & c1.SelectedIndex & F.YY & c2.Text & F.YY & c.Value)
            Button1.Text = "Stop"
        Else
            Button1.Text = "Start"
        End If

    End Sub

    Private Sub CyberButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub SendKey(ByVal Key As String)
        If CheckBox3.Checked Then
            F.s.Send(Sock, "dekey" & F.YY & Conversions.ToString(0) & F.YY & Key)
        End If

    End Sub
    Private Sub KDW(ByVal sender As Object, ByVal e As KeyEventArgs)
      Me.p1.Focus()
        If Me.CheckBox3.Checked Then
            Select Case e.KeyCode
                Case Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
                    SendKey(&H10)
                    '  Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(&H10)}))
                    GoTo Label_00E8
            End Select
            Dim Key As Keys = CInt(e.KeyCode)
            SendKey(CInt(e.KeyCode))
            'Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode))}))
        End If
Label_00E8:
        e.SuppressKeyPress = True
    End Sub

    Private Sub KUP(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.p1.Focus()
        If Me.CheckBox3.Checked Then
            Select Case e.KeyCode
                Case Keys.Shift, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
                    SendKey(&H10)
                    '  Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(&H10)}))
                    GoTo Label_00E8
            End Select
            Dim Key As Keys = CInt(e.KeyCode)
            SendKey(CInt(e.KeyCode))
            '   Me.sk.Send(String.Concat(New String() {"#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode))}))
        End If
Label_00E8:
        e.SuppressKeyPress = True
    End Sub

    Private Sub p1_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles p1.PreviewKeyDown
        Keyboardkey = CInt(e.KeyCode)
        SendKey(CInt(e.KeyCode))
    End Sub
    Dim folderpath As String
    Dim counter As Integer = 0
    Dim showed As Boolean = False
    Private Sub getdir()
        saver.Stop()
        Dim s As New SaveFileDialog
        s.Filter = "Pic|*.png"
        s.Title = "Choose a Path to save images to"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            folderpath = System.IO.Path.GetDirectoryName(s.FileName)
            Flag = True
            saver.Start()
        Else
            MsgBox("Error : Please Choose a Path to save images to", MsgBoxStyle.Critical)
            Flag = False
        End If
    End Sub
    Private Flag As Boolean = False
    Private Sub saver_Tick(sender As System.Object, e As System.EventArgs) Handles saver.Tick
        If Flag = True And showed = False Then
            Process.Start(folderpath)
            showed = True
        End If
        If Flag = False Then
            getdir()
        ElseIf Flag = True Then
            Dim current = folderpath & "\" & counter & ".png"
            p1.Image.Save(current)
            counter += 1
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            saver.Start()
        Else
            saver.Stop()
        End If
    End Sub
End Class