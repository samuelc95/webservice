Public Class Ins_util

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://127.0.0.1/webservice/index.php")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_listar.Click
        Listar.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_criar_Click(sender As Object, e As EventArgs) Handles Btn_criar.Click

        WebBrowser1.Document.GetElementById("username").SetAttribute("value", txt_nick.Text)
        WebBrowser1.Document.GetElementById("email").SetAttribute("value", txt_email.Text)
        WebBrowser1.Document.GetElementById("password").SetAttribute("value", txt_pass.Text)
        WebBrowser1.Document.GetElementById("submit").InvokeMember("click")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
