Imports MySql.Data.MySqlClient

Public Class update1
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbadapter As MySqlDataAdapter
    Public dt As DataTable
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
            sql = "UPDATE llibre SET titol = @titol, autor = @autor, editorial = @editorial, preu = @preu, categoria = @categoria WHERE isbn = @isbn"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbcomm.Parameters.AddWithValue("@isbn", isbn)
            dbcomm.Parameters.AddWithValue("@titol", titol)
            dbcomm.Parameters.AddWithValue("@autor", autor)
            dbcomm.Parameters.AddWithValue("@editorial", editorial)
            dbcomm.Parameters.AddWithValue("@preu", preu)
            dbcomm.Parameters.AddWithValue("@categoria", categoria)
            dbcomm.ExecuteNonQuery()
            dbconn.Close()
            MsgBox("Book updated successfully!")
            ComboBox1.Items.Clear()
            update1_Load(sender, e)
            TextBox1_isbn.Clear()
            TextBox2_titol.Clear()
            TextBox3_Categoria.Clear()
            TextBox4_autor.Clear()
            TextBox5_editorial.Clear()
            TextBox6_preu.Clear()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim isbn As String = ComboBox1.SelectedItem.ToString().Substring(0, ComboBox1.SelectedItem.ToString().IndexOf(" - "))
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;password=;port=3306;database=biblioteca")
        Try
            dbconn.Open()
            sql = "SELECT * FROM llibre WHERE Isbn = @isbn"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbcomm.Parameters.AddWithValue("@isbn", isbn)
            dbadapter = New MySqlDataAdapter(dbcomm)
            dt = New DataTable()
            dbadapter.Fill(dt)
            TextBox1_isbn.Text = dt.Rows(0)("Isbn").ToString()
            TextBox2_titol.Text = dt.Rows(0)("titol").ToString()
            TextBox3_Categoria.Text = dt.Rows(0)("categoria").ToString()
            TextBox4_autor.Text = dt.Rows(0)("autor").ToString()
            TextBox5_editorial.Text = dt.Rows(0)("editorial").ToString()
            TextBox6_preu.Text = dt.Rows(0)("preu").ToString()


            dbconn.Close()

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub update1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;user id=root;password=;port=3306;database=biblioteca")
        Try
            dbconn.Open()
            sql = "SELECT Isbn, titol FROM llibre"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbadapter = New MySqlDataAdapter(dbcomm)
            dt = New DataTable()
            dbadapter.Fill(dt)
            For Each row As DataRow In dt.Rows
                ComboBox1.Items.Add(row("Isbn").ToString() & " - " & row("titol").ToString())
            Next
            dbconn.Close()

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insert.Show()
        Me.Hide()
    End Sub
End Class