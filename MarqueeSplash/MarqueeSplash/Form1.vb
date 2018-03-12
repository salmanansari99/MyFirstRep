Public Class frmMain

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Animate_Marquee()
    End Sub

    Dim direction As Integer = 0 ' 0 to left, 1 to right
    Dim oneStepMove As Integer = 1

    Private Sub Animate_Marquee()

        'Move Left
        If direction = 0 Then
            If picSplash.Left >= -60 Then
                picSplash.Left = picSplash.Left - oneStepMove
            Else
                direction = 1
            End If
        End If

        'Move Right
        If direction = 1 Then
            If picSplash.Left <= 0 Then
                picSplash.Left = picSplash.Left + oneStepMove
            Else
                direction = 0
            End If
        End If

    End Sub

End Class
