Public Class Ventana_Trabajador
    Private Sub Ventana_Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub

    Private formulario As Form = Nothing
    Private Sub abrirformulariohijo(formulariohijo As Form)
        If formulario IsNot Nothing Then formulario.Close()
        formulario = formulariohijo
        formulariohijo.TopLevel = False
        formulariohijo.FormBorderStyle = FormBorderStyle.None
        formulariohijo.Dock = DockStyle.Fill
        PanelLaboresTrabajador.Controls.Add(formulariohijo)
        PanelLaboresTrabajador.Tag = formulariohijo
        formulariohijo.Show()
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click
        abrirformulariohijo(New RealizarCompra)
    End Sub

    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        abrirformulariohijo(New RealizarVenta)
    End Sub

    Private Sub BtnConsultaInventario_Click(sender As Object, e As EventArgs) Handles BtnConsultaInventario.Click
        abrirformulariohijo(New ConsultarInventario)
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        abrirformulariohijo(New AgregarCliente)
    End Sub

    Private Sub BtnPersonal_Click(sender As Object, e As EventArgs) Handles BtnPersonal.Click
        abrirformulariohijo(New Personal)
    End Sub

    Private Sub BtnLaboratorios_Click(sender As Object, e As EventArgs) Handles BtnLaboratorios.Click
        abrirformulariohijo(New Laboratorios)
    End Sub

    Private Sub BtnSuministros_Click(sender As Object, e As EventArgs) Handles BtnSuministros.Click
        abrirformulariohijo(New Suministros)
    End Sub

    Private Sub BtnVencimientos_Click(sender As Object, e As EventArgs) Handles BtnVencimientos.Click
        abrirformulariohijo(New Vencimientos)
    End Sub
End Class