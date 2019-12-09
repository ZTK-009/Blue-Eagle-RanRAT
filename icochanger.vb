Public Class icochanger
    Private c As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MapGadget.HackerIco = c
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub icochanger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If c = 0 Then
            c = 1
        End If
        MapGadget.TopMost = True
        MapGadget.Flager.Start()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next

        Dim ch As String = ListView1.SelectedItems(0).Text
        Select Case ch
            Case "Control Center"
                c = 1
            Case "Connector"
                c = 2
            Case "Network share"
                c = 3
            Case "I`m Online"
                c = 4
            Case "Sharing Data"
                c = 5
            Case "I`m Cool"
                c = 6
            Case "Agent Spy"
                c = 7
            Case Else
                c = 1
        End Select
    End Sub


End Class