Public Class Ventana_Administrador
    Private Sub Ventana_Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        PanelLaboresAdministrador.Controls.Add(formulariohijo)
        PanelLaboresAdministrador.Tag = formulariohijo
        formulariohijo.Show()
    End Sub

    Private Sub BtnControlInventario_Click(sender As Object, e As EventArgs) Handles BtnControlInventario.Click
        abrirformulariohijo(New ControlDeInventario())
    End Sub

    Private Sub BtnRegistroEmpleados_Click(sender As Object, e As EventArgs) Handles BtnRegistroEmpleados.Click
        abrirformulariohijo(New RegistroDelPersonal)
    End Sub

    Private Sub BtnRegistroProveedores_Click(sender As Object, e As EventArgs) Handles BtnRegistroProveedores.Click
        abrirformulariohijo(New RegistroProveedores)
    End Sub

    Private Sub BtnRegistroClientes_Click(sender As Object, e As EventArgs) Handles BtnRegistroClientes.Click
        abrirformulariohijo(New RegistroClientes)
    End Sub

    Private Sub BtnControlCompras_Click(sender As Object, e As EventArgs) Handles BtnControlCompras.Click
        abrirformulariohijo(New ControlCompras)
    End Sub

    Private Sub BtnControlVentas_Click(sender As Object, e As EventArgs) Handles BtnControlVentas.Click
        abrirformulariohijo(New ControlVentas)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirformulariohijo(New ControlVencimiento)
    End Sub

    Private Sub BtnControlLaboratorios_Click(sender As Object, e As EventArgs) Handles BtnControlLaboratorios.Click
        abrirformulariohijo(New ControlLaboratorios)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirformulariohijo(New ControlSuministros)
    End Sub
End Class