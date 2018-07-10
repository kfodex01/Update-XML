Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = ""
        lblMessage.Update()
        tbSavePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    End Sub

    Private Sub BtnCreateXml_Click(sender As Object, e As EventArgs) Handles btnCreateXml.Click
        Dim workbookPath As String = tbWorkbookPath.Text
        Dim savePath As String = tbSavePath.Text
        If Not System.IO.File.Exists(workbookPath) Then
            lblMessage.Text = "Workbook path doesn't exist."
            lblMessage.Update()
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(savePath) Then
            lblMessage.Text = "Save directory doesn't exist."
            lblMessage.Update()
            Exit Sub
        End If
        lblMessage.Text = "Working"
        lblMessage.Update()
        If CreateXml(workbookPath, savePath) Then
            lblMessage.Text = "Done"
        Else
            lblMessage.Text = "Error"
        End If
        lblMessage.Update()
    End Sub
End Class
