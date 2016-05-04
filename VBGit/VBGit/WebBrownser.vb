Public Class WebBrownser
    Private Sub btgo_Click(sender As Object, e As EventArgs) Handles btgo.Click
        WebBrowser1.Navigate(txtnav.Text)

    End Sub

    Private Sub btrefresh_Click(sender As Object, e As EventArgs) Handles btrefresh.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btforward_Click(sender As Object, e As EventArgs) Handles btforward.Click
        WebBrowser1.GoForward()
    End Sub
End Class