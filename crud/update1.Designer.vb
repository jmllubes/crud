<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4_autor = New System.Windows.Forms.TextBox()
        Me.TextBox5_editorial = New System.Windows.Forms.TextBox()
        Me.TextBox6_preu = New System.Windows.Forms.TextBox()
        Me.TextBox3_Categoria = New System.Windows.Forms.TextBox()
        Me.TextBox2_titol = New System.Windows.Forms.TextBox()
        Me.TextBox1_isbn = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(573, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "INSERT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(427, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(282, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Autor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Editorial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(415, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Preu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Titol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ISBN"
        '
        'TextBox4_autor
        '
        Me.TextBox4_autor.Location = New System.Drawing.Point(495, 334)
        Me.TextBox4_autor.Name = "TextBox4_autor"
        Me.TextBox4_autor.Size = New System.Drawing.Size(208, 22)
        Me.TextBox4_autor.TabIndex = 27
        '
        'TextBox5_editorial
        '
        Me.TextBox5_editorial.Location = New System.Drawing.Point(495, 268)
        Me.TextBox5_editorial.Name = "TextBox5_editorial"
        Me.TextBox5_editorial.Size = New System.Drawing.Size(208, 22)
        Me.TextBox5_editorial.TabIndex = 26
        '
        'TextBox6_preu
        '
        Me.TextBox6_preu.Location = New System.Drawing.Point(495, 211)
        Me.TextBox6_preu.Name = "TextBox6_preu"
        Me.TextBox6_preu.Size = New System.Drawing.Size(208, 22)
        Me.TextBox6_preu.TabIndex = 25
        '
        'TextBox3_Categoria
        '
        Me.TextBox3_Categoria.Location = New System.Drawing.Point(153, 337)
        Me.TextBox3_Categoria.Name = "TextBox3_Categoria"
        Me.TextBox3_Categoria.Size = New System.Drawing.Size(204, 22)
        Me.TextBox3_Categoria.TabIndex = 24
        '
        'TextBox2_titol
        '
        Me.TextBox2_titol.Location = New System.Drawing.Point(153, 271)
        Me.TextBox2_titol.Name = "TextBox2_titol"
        Me.TextBox2_titol.Size = New System.Drawing.Size(204, 22)
        Me.TextBox2_titol.TabIndex = 23
        '
        'TextBox1_isbn
        '
        Me.TextBox1_isbn.Enabled = False
        Me.TextBox1_isbn.Location = New System.Drawing.Point(153, 214)
        Me.TextBox1_isbn.Name = "TextBox1_isbn"
        Me.TextBox1_isbn.Size = New System.Drawing.Size(204, 22)
        Me.TextBox1_isbn.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(592, 380)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 40)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Actualitzar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(301, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(402, 24)
        Me.ComboBox1.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Tria llibre per modificar"
        '
        'update1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4_autor)
        Me.Controls.Add(Me.TextBox5_editorial)
        Me.Controls.Add(Me.TextBox6_preu)
        Me.Controls.Add(Me.TextBox3_Categoria)
        Me.Controls.Add(Me.TextBox2_titol)
        Me.Controls.Add(Me.TextBox1_isbn)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "update1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4_autor As TextBox
    Friend WithEvents TextBox5_editorial As TextBox
    Friend WithEvents TextBox6_preu As TextBox
    Friend WithEvents TextBox3_Categoria As TextBox
    Friend WithEvents TextBox2_titol As TextBox
    Friend WithEvents TextBox1_isbn As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
End Class
