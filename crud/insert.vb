Public Class insert
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

        MsgBox("ISBN: " & isbn & vbCrLf &
               "Títol: " & titol & vbCrLf &
               "Autor: " & autor & vbCrLf &
               "Editorial: " & editorial & vbCrLf &
               "Preu: " & preu & vbCrLf &
               "Categoria: " & categoria)


    End Sub
End Class