Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Public Class ControlVentas
    Dim isFormatting As Boolean = False
    Dim conexion As String = ("Data Source=USER;Initial Catalog=BD.Cruz;Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub

    Private Sub ControlVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CruzDataSet38.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter3.Fill(Me._BD_CruzDataSet38.Ventas)

        adaptador = New SqlDataAdapter("SELECT * FROM Ventas", conexion)

        Dim constructor As New SqlCommandBuilder(adaptador)

        adaptador.Fill(dt)
        DataGridControlVentas.DataSource = dt
    End Sub

    Private Sub BuscarYAsignarProducto(id As String, tabla As String, colId As String, colNombre As String, colPrecio As String, fila As DataGridViewRow)
        Dim consulta As String = $"SELECT {colNombre}, {colPrecio} FROM {tabla} WHERE {colId} = @id"

        Using conn As New SqlConnection(conexion)
            Using cmd As New SqlCommand(consulta, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        fila.Cells("DetalleDeProducto").Value = reader(colNombre).ToString()
                        fila.Cells("PrecioUnitario").Value = Convert.ToDecimal(reader(colPrecio))
                    Else

                        fila.Cells("DetalleDeProducto").Value = "No encontrado"
                        fila.Cells("PrecioUnitario").Value = 0
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub CalcularTotalFila(fila As DataGridViewRow)

        Dim cantidad As Decimal = 0
        Dim precio As Decimal = 0

        If fila.Cells("Cantidad").Value IsNot DBNull.Value AndAlso IsNumeric(fila.Cells("Cantidad").Value) Then
            cantidad = Convert.ToDecimal(fila.Cells("Cantidad").Value)
        End If

        If fila.Cells("PrecioUnitario").Value IsNot DBNull.Value AndAlso IsNumeric(fila.Cells("PrecioUnitario").Value) Then
            precio = Convert.ToDecimal(fila.Cells("PrecioUnitario").Value)
        End If

        isFormatting = True
        fila.Cells("Total").Value = cantidad * precio
        isFormatting = False
    End Sub

    Private Sub DataGridControlVentas_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridControlVentas.CurrentCellDirtyStateChanged
        If DataGridControlVentas.IsCurrentCellDirty Then
            DataGridControlVentas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
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
        dt = DataGridControlVentas.DataSource
        If Integer.TryParse(TxtBuscar.Text.Trim(), IdBusqueda) Then
            dt.DefaultView.RowFilter = $"IDVenta = {IdBusqueda}"

            If DataGridControlVentas.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún registro con ese ID.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número de ID válido.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dt = DataGridControlVentas.DataSource
        dt.DefaultView.RowFilter = ""

        TxtBuscar.Clear()
    End Sub

    Private Sub DataGridControlVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridControlVentas.CellValueChanged

        If e.RowIndex > 0 Or isFormatting Then

            Dim filaActual As DataGridViewRow = DataGridControlVentas.Rows(e.RowIndex)

            Try

                If DataGridControlVentas.Columns(e.ColumnIndex).Name = "IDProducto" Then
                    Dim idProd As Object = filaActual.Cells("IDProducto").Value

                    If idProd IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(idProd.ToString()) Then
                        isFormatting = True

                        filaActual.Cells("IDProductoSuministro").Value = DBNull.Value

                        BuscarYAsignarProducto(idProd.ToString(), "Producto", "IDProducto", "Nombre", "PrecioUnitario", filaActual)

                        filaActual.Cells("FechaDeVenta").Value = DateTime.Today
                        isFormatting = False

                        CalcularTotalFila(filaActual)
                    End If

                ElseIf DataGridControlVentas.Columns(e.ColumnIndex).Name = "IDProductoSuministro" Then
                    Dim idSum As Object = filaActual.Cells("IDProductoSuministro").Value

                    If idSum IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(idSum.ToString()) Then
                        isFormatting = True

                        filaActual.Cells("IDProducto").Value = DBNull.Value


                        BuscarYAsignarProducto(idSum.ToString(), "ProductosSuministros", "IDProductoSuministro", "Nombre", "PrecioUnitario", filaActual)

                        filaActual.Cells("FechaDeVenta").Value = DateTime.Today
                        isFormatting = False

                        CalcularTotalFila(filaActual)
                    End If

                ElseIf DataGridControlVentas.Columns(e.ColumnIndex).Name = "Cantidad" Then
                    CalcularTotalFila(filaActual)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al procesar datos de la fila: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                isFormatting = False
            End Try
        End If
    End Sub
End Class