Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Public Class ModificarInventario
    Dim conexion As String = ("Data Source=USER;Initial Catalog=BD.Cruz;Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub
    Private Sub ModificarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CruzDataSet7.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._BD_CruzDataSet7.Producto)
        adaptador = New SqlDataAdapter("SELECT * FROM Producto", conexion)

        Dim constructor As New SqlCommandBuilder(adaptador)

        adaptador.Fill(dt)
        DataGridModificarInventario.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            adaptador.Update(dt)
            MsgBox("Datos guardados correctamente.")
        Catch ex As Exception
            MsgBox("Error al guardar.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IdBusqueda As Integer
        dt = DataGridModificarInventario.DataSource
        If Integer.TryParse(TxtBuscar.Text.Trim(), IdBusqueda) Then
            dt.DefaultView.RowFilter = $"IDProducto = {IdBusqueda}"

            If DataGridModificarInventario.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún registro con ese ID.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número de ID válido.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dt = DataGridModificarInventario.DataSource
        dt.DefaultView.RowFilter = ""

        TxtBuscar.Clear()
    End Sub
End Class