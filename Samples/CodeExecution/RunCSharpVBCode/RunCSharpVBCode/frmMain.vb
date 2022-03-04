Imports Microsoft.CSharp
Imports System.CodeDom.Compiler
Imports System.Security.Principal

Public Class frmMain
    Private isvb As Boolean = True
    Private references As String() = {"mscorlib.dll", "System.Core.dll", "System.Windows.dll", "System.Windows.Forms.dll", "System.dll", "System.Drawing.dll", "System.Data.dll", "System.Xml.dll", "System.Xml.Linq.dll", "System.Deployment.dll", "System.Deployment.dll"}

    Private Sub btnCompile_Click(sender As Object, e As EventArgs) Handles btnCompile.Click
        If isvb = False Then
            Dim cSharpCode As CSharpCodeProvider = New CSharpCodeProvider(New Dictionary(Of String, String) From {
            {"ComplilerVersion", "4.0"}
        })
            Dim parameters As CompilerParameters = New CompilerParameters(references, txtFile.Text, True)
            parameters.GenerateExecutable = chexecutable.Checked
            Dim results As CompilerResults = cSharpCode.CompileAssemblyFromSource(parameters, txtCode.Text)

            If results.Errors.HasErrors Then
                results.Errors.Cast(Of CompilerError)().ToList().ForEach(Sub([error])
                                                                             txtOutput.Text += $"{[error].ErrorText}{vbCrLf}{Environment.NewLine}"
                                                                         End Sub)
            Else
                txtOutput.Text += $"----Build succeeded----{Environment.NewLine}"
                Process.Start($"{Application.StartupPath}\{txtFile.Text}")
            End If
        Else
            Dim VBCode As VBCodeProvider = New VBCodeProvider(New Dictionary(Of String, String) From {
                         {"ComplilerVersion", "4.0"}
            })
            Dim compilerParameters As CompilerParameters = New CompilerParameters(references, txtFile.Text, True)
            compilerParameters.GenerateExecutable = chexecutable.Checked
            Dim results1 As CompilerResults = VBCode.CompileAssemblyFromSource(compilerParameters, txtCode.Text)

            If results1.Errors.HasErrors Then
                results1.Errors.Cast(Of CompilerError)().ToList().ForEach(Sub([error])
                                                                              txtOutput.Text += $"{[error].ErrorText}{vbCrLf}"
                                                                          End Sub)
            Else
                txtOutput.Text += $"----Build succeeded----{Environment.NewLine}"
                Process.Start($"{Application.StartupPath}\{txtFile.Text}")
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsElevated() = False Then
            'start as admin
            Dim procStartInfo As New ProcessStartInfo
            Dim procExecuting As New Process

            With procStartInfo
                .UseShellExecute = True
                .FileName = $"{Application.StartupPath}\RunCSharpVBCode.exe"
                .WindowStyle = ProcessWindowStyle.Normal
                .Verb = "runas" 'add this to prompt for elevation
            End With
            procExecuting = Process.Start(procStartInfo)
            'this program
            Dim p As Process = Process.GetCurrentProcess()
            'kill it
            p.Kill()
        End If
    End Sub

    Private Function IsElevated()
        Dim elevated As Boolean

        Using identity As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim principal As WindowsPrincipal = New WindowsPrincipal(identity)

            elevated = principal.IsInRole(WindowsBuiltInRole.Administrator)
        End Using
        Return elevated
    End Function

    Private Sub rd_CheckedChanged(sender As Object, e As EventArgs) Handles rdVB.CheckedChanged, rdCSharp.CheckedChanged
        isvb = rdVB.Checked
        If Not isvb Then
            txtCode.Language = FastColoredTextBoxNS.Language.CSharp
        Else
            txtCode.Language = FastColoredTextBoxNS.Language.VB
        End If
    End Sub
End Class
