Public Class main

    Private Sub Button_hunt_Click(sender As Object, e As EventArgs) Handles BtnStart_hunt.Click
        Timer_hunt.Interval = TbhuntIn.Text * 1000
        Timer_hunt.Start()
    End Sub

    Private Sub Timerhunt_Tick(sender As Object, e As EventArgs) Handles Timer_hunt.Tick
        SendKeys.Send(Tbhunt.Text)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub BtnStop_hunt_Click(sender As Object, e As EventArgs) Handles BtnStop_hunt.Click
        Timer_hunt.Stop()
    End Sub

    Private Sub BtnStop_axe_Click(sender As Object, e As EventArgs) Handles BtnStop_axe.Click
        Timer_Axe.Stop()
    End Sub

    Private Sub BtnStart_axe_Click(sender As Object, e As EventArgs) Handles BtnStart_axe.Click
        Timer_Axe.Interval = TbAxe_In.Text * 1000
        Timer_Axe.Start()
    End Sub

    Private Sub Timer_Axe_Tick(sender As Object, e As EventArgs) Handles Timer_Axe.Tick
        SendKeys.Send(tbAxe.Text)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub BtnStop_All_Click(sender As Object, e As EventArgs) Handles BtnStop_All.Click
        Timer_hunt.Stop()
        Timer_Axe.Stop()
    End Sub

    Private Sub BtnStart_All_Click(sender As Object, e As EventArgs) Handles BtnStart_All.Click
        Timer_hunt.Interval = TbhuntIn.Text * 1000
        Timer_hunt.Start()

        Timer_Axe.Interval = TbAxe_In.Text * 1000
        Timer_Axe.Start()

    End Sub

    Private Sub TbhuntIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbhuntIn.KeyPress
        Dim inputan As Char = e.KeyChar
        If Not Char.IsDigit(inputan) AndAlso Asc(inputan) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbAxe_In_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAxe_In.KeyPress
        Dim inputan2 As Char = e.KeyChar
        If Not Char.IsDigit(inputan2) AndAlso Asc(inputan2) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class
