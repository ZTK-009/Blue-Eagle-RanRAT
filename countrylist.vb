Public Class countrylist





    Private Sub countrylist_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        Me.Focus()
        For i As Integer = 0 To RichTextBox1.Lines.Length
            Dim CurrentCountry As String = RichTextBox1.Lines(i).Replace("""", "")
            ListView1.Items.Add(CurrentCountry, GetCountryNumber(UCase(CurrentCountry)))
            i += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For Each item As ListViewItem In ListView1.Items
            If item.Checked = True Then
                Form1.ACvQRTLeTBGH(item.Text)
            End If
        Next
        Me.Close()

    End Sub

    Private Sub countrylist_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim ncount As Integer = ListView1.CheckedItems.Count
        Label2.Text = ncount
    End Sub
End Class