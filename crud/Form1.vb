Imports MySql.Data.MySqlClient
Public Class Form1
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbadapter As MySqlDataAdapter
    Public dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;password=;port=3306;database=biblioteca")
        Try
            dbconn.Open()
            sql = "SELECT * FROM llibre"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbadapter = New MySqlDataAdapter(dbcomm)
            dt = New DataTable()
            dbadapter.Fill(dt)
            DataGridView1.DataSource = dt
            dbconn.Close()

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        update1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insert.Show()
        Me.Hide()
    End Sub
End Class
