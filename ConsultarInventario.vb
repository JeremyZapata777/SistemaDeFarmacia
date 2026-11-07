Imports System.ComponentModel.Design
Imports System.Data.SqlClient

Public Class ConsultarInventario
    Dim conexion As String = ("Data Source=USER;Initial Catalog=BD.Cruz;Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub

    Private Sub ConsultarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CruzDataSet5.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._BD_CruzDataSet5.Producto)
        adaptador = New SqlDataAdapter("SELECT * FROM Producto", conexion)

        Dim constructor As New SqlCommandBuilder(adaptador)

        adaptador.Fill(dt)
        DataGridConsulta.DataSource = dt
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IdBusqueda As Integer
        dt = DataGridConsulta.DataSource
        If Integer.TryParse(TxtBuscar.Text.Trim(), IdBusqueda) Then
            dt.DefaultView.RowFilter = $"IDProducto = {IdBusqueda}"

            If DataGridConsulta.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún registro con ese ID.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número de ID válido.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dt = DataGridConsulta.DataSource
        dt.DefaultView.RowFilter = ""

        TxtBuscar.Clear()
    End Sub

    ' Se usa el evento RowPrePaint para cambiar el color de la fila antes de que se pinte, e
    ' Esto nos permite cambiar el color de la fila dependiendo del valor de las celdas StockMinimo, StockMaximo y StockActual
    Private Sub DataGridConsulta_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridConsulta.RowPrePaint
        ' El Row Index nos da el indice de la fila que se va a pintar para poder seleccionarla en el DataGridView
        Dim index As Int16 = e.RowIndex
        ' Obtener el valor de la celda StockMinimo, StockMaximo y StockActual de la fila actual

        Dim stockMinimo As Integer = Convert.ToInt32(DataGridConsulta.Rows(index).Cells("StockMínimo").Value)
        Dim stockMaximo As Integer = Convert.ToInt32(DataGridConsulta.Rows(index).Cells("StockMáximo").Value)
        Dim stockActual As Integer = Convert.ToInt32(DataGridConsulta.Rows(index).Cells("StockActual").Value)
        ' Si el stock actual es menor al stock mínimo, se pinta la fila de rojo
        If stockActual < stockMinimo Then
            ' Obtenemos la fila que cambiará de color en base al indice y le aplicamos el color
            DataGridConsulta.Rows(index).DefaultCellStyle.BackColor = Color.Red

            'Si el stock actual es mayor al stock máximo, se pinta la fila de azul
        ElseIf stockActual > stockMaximo Then
            ' Obtenemos la fila que cambiará de color en base al indice y le aplicamos el color
            DataGridConsulta.Rows(index).DefaultCellStyle.BackColor = Color.Blue
        ElseIf stockActual >= stockMinimo AndAlso stockActual <= stockMaximo Then
            DataGridConsulta.Rows(index).DefaultCellStyle.BackColor = Color.DarkGreen
        End If

    End Sub
End Class