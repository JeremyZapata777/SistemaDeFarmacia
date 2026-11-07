Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Public Class Personal
    Dim conexion As String = ("Data Source=USER;Initial Catalog=BD.Cruz;Integrated Security=True")
    Dim adaptador As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub
    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CruzDataSet22.Colaboradores' Puede moverla o quitarla según sea necesario.
        Me.ColaboradoresTableAdapter.Fill(Me._BD_CruzDataSet22.Colaboradores)
        adaptador = New SqlDataAdapter("SELECT IDColaboradores, NombreCompleto, Rol, Teléfono, Correo FROM Colaboradores", conexion)

        Dim constructor As New SqlCommandBuilder(adaptador)

        adaptador.Fill(dt)
        DataGridPersonal.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IdBusqueda As Integer
        dt = DataGridPersonal.DataSource
        If Integer.TryParse(TxtBuscar.Text.Trim(), IdBusqueda) Then
            dt.DefaultView.RowFilter = $"IDColaboradores = {IdBusqueda}"

            If DataGridPersonal.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún registro con ese ID.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número de ID válido.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dt = DataGridPersonal.DataSource
        dt.DefaultView.RowFilter = ""

        TxtBuscar.Clear()
    End Sub
End Class