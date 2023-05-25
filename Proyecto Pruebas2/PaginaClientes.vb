Imports System.IO
Public Class PaginaClientes
    Private producto1 As String() = Directory.GetFiles("C:\Users\Saulm\Desktop\Productos\1.Audifonos")
    Private producto2 As String() = Directory.GetFiles("C:\Users\Saulm\Desktop\Productos\2.Audifonos")
    Private nump1 As Integer = 0
    Private indice As Integer = 0
    Private nump2 As Integer = 0
    Private indice2 As Integer = 0

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
        PictureBox1.TabStop = False
        PictureBox1.Image = New System.Drawing.Bitmap(producto1(nump1))
    End Sub

    Private Sub pictureBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.DoubleClick
        pictureBox1.Parent = Me
        pictureBox1.BringToFront()
        pictureBox1.SetBounds(0, 0, Me.Width, Me.Height)
    End Sub

    Private Sub PaginaClientes_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Dim ultimo As Integer = producto1.Length - 1
        Dim ultimo2 As Integer = producto2.Length - 1

        Select Case e.KeyCode
            Case Keys.D
                indice += 1
                indice2 += 1
                If indice > ultimo Then
                    indice = 0
                End If
                If indice2 > ultimo2 Then
                    indice2 = 0
                End If
                PictureBox1.Image = New System.Drawing.Bitmap(producto1(indice))

            Case Keys.A
                indice -= 1
                indice2 -= 1
                If indice < 0 Then
                    indice = ultimo
                End If
                If indice2 < 0 Then
                    indice2 = ultimo2
                End If
                PictureBox1.Image = New System.Drawing.Bitmap(producto1(indice))

            Case Keys.Q
                pictureBox1_DoubleClick(Nothing, Nothing)

            Case Keys.Escape
                pictureBox1.Dock = DockStyle.None
                pictureBox1.Parent = Me
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox1.Location = New Point(137, 137)
                PictureBox1.Size = New Size(200, 158)
        End Select
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod1 As Producto1
        prod1.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim regreso As Form1
        regreso.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_DoubleClick_1(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        PictureBox1.Parent = Me
        PictureBox1.BringToFront()
        PictureBox1.SetBounds(0, 0, Me.Width, Me.Height)
    End Sub
End Class