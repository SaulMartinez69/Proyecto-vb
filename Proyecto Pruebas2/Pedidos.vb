Imports System.IO

Public Class Pedidos
    Private Sub bntLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de texto|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            LoadData(filePath)
        End If
    End Sub

    Private Sub LoadData(filePath As String)
        Try
            Using reader As New StreamReader(filePath)
                Dim dataTable As New DataTable()
                Dim headers As String() = reader.ReadLine().Split(","c)
                For Each header As String In headers
                    dataTable.Columns.Add(header)
                Next

                Dim rowCount As Integer = 1
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If Not String.IsNullOrWhiteSpace(line) Then
                        Dim rows As String() = line.Split(","c)
                        dataTable.Rows.Add(rows)
                        rowCount += 1
                    End If
                End While

                dtgvpedidos.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim regreso As Form1
        regreso.Show()
        Me.Hide()
    End Sub
End Class