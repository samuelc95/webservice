Imports System.Xml
Public Class Ins_util


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oXML As New XmlDocument

        Dim ArquivoXML As String = "C:\Users\Samuel Costa\Documents\GitHub\webservice\Index\config.xml"
        oXML.Load(ArquivoXML)
        Dim linkkk As String = oXML.SelectSingleNode("ln").ChildNodes(0).InnerText

        WebBrowser1.Navigate(linkkk)





    End Sub


    Private Sub Btn_criar_Click(sender As Object, e As EventArgs) Handles Btn_criar.Click

        WebBrowser1.Document.GetElementById("username").SetAttribute("value", txt_nick.Text)
        WebBrowser1.Document.GetElementById("email").SetAttribute("value", txt_email.Text)
        WebBrowser1.Document.GetElementById("password").SetAttribute("value", txt_pass.Text)
        WebBrowser1.Document.GetElementById("submit").InvokeMember("click")
        MessageBox.Show("Inserido com sucesso")
        txt_nick.Text = ""
        txt_email.Text = ""
        txt_pass.Text = ""
        WebBrowser1.Document.GetElementById("refresh").InvokeMember("click")

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub
End Class