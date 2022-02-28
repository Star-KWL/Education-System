Public Class MainForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Opacipty
        Opacipty = Me.Opacity
        If Opacity > 0.55 Then
            Me.Opacity = Me.Opacity - 0.002
        Else
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Opacipty
        Opacipty = Me.Opacity
        If Opacity < 0.8 Then
            Me.Opacity = Me.Opacity + 0.002
        Else
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub
End Class