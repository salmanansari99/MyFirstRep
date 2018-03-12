Imports System.IO
Imports System.IO.File


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReadFile(TextBox2.Text)
    End Sub


    Private Sub ReadFile(ByVal file_name As String)

        ' Read the file as text.
        'Dim sr As StreamReader
        'sr = OpenText(file_name)
        'txtAsText.Text = sr.ReadLine()
        'sr.Close()

        ' Read the file as Unicode.
        '        sr = OpenText(file_name)
        'sr = New StreamReader(file_name, System.Text.Encoding.UTF8)
        'txtAsUnicode.Text = sr.ReadToEnd()
        'sr.Close()

        txtAsUnicode.Text = My.Computer.FileSystem.ReadAllText(file_name, System.Text.Encoding.GetEncoding("windows-1256"))
        txtAsUnicode.Text = txtAsUnicode.Text.Replace("ã", "AM")

        txtAsUnicode.Select(0, 0)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("http://www.uet.edu.pk/index.html", "C:\download.html")

    End Sub
End Class
