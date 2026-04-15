Imports MySql.Data.MySqlClient

Public Class insert
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Private dbadapter As MySqlDataAdapter

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim isbn As String
        Dim titol As String
        Dim autor As String
        Dim editorial As String
        Dim preu As Decimal
        Dim categoria As String
        isbn = TextBox1_isbn.Text
        titol = TextBox2_titol.Text
        autor = TextBox4_autor.Text
        editorial = TextBox5_editorial.Text
        preu = Decimal.Parse(TextBox6_preu.Text)
        categoria = TextBox3_Categoria.Text
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;password=;port=3306;database=biblioteca")
        Try
            dbconn.Open()
            sql = "INSERT INTO llibre (isbn, titol, autor, editorial, preu, categoria) VALUES (@isbn, @titol, @autor, @editorial, @preu, @categoria)"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbcomm.Parameters.AddWithValue("@isbn", isbn)
            dbcomm.Parameters.AddWithValue("@titol", titol)
            dbcomm.Parameters.AddWithValue("@autor", autor)
            dbcomm.Parameters.AddWithValue("@editorial", editorial)
            dbcomm.Parameters.AddWithValue("@preu", preu)
            dbcomm.Parameters.AddWithValue("@categoria", categoria)
            dbcomm.ExecuteNonQuery()
            dbconn.Close()

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        update1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete.Show()
        Me.Hide()
    End Sub
End Class