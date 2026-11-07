Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Public Class Login
    Dim connectionString As String = "Data Source=USER;Initial Catalog=BD.Cruz;Integrated Security=True"
    Dim query As String = "SELECT Rol FROM Colaboradores WHERE Correo = @user AND Contraseña = @pass"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DoubleBuffered = True
    End Sub
    Private Sub BtnRealizar_Click(sender As Object, e As EventArgs) Handles BtnRealizar.Click
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@user", TxtCorreo.Text)
                    cmd.Parameters.AddWithValue("@pass", TxtContraseña.Text)


                    Dim resultado = cmd.ExecuteScalar()

                    If resultado IsNot Nothing Then
                        Dim rolUsuario As String = resultado.ToString()
                        MessageBox.Show("Bienvenido: " & rolUsuario)

                        AbrirVentanaSegunRol(rolUsuario)
                        Me.Hide()
                        TxtCorreo.Clear()
                        TxtContraseña.Clear()
                        ChkCorreo.Checked = False
                        ChkContraseña.Checked = False
                    Else
                        MessageBox.Show("Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error de conexión: " & ex.Message)
            End Try


        End Using
    End Sub

    Private Sub AbrirVentanaSegunRol(rol As String)
        Select Case rol
            Case "Administrador"
                Ventana_Administrador.Show()
            Case "Trabajador"
                Ventana_Trabajador.Show()
            Case Else
                MessageBox.Show("Rol no reconocido.")
        End Select
    End Sub
    Private Sub ChkCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCorreo.CheckedChanged
        If ChkCorreo.Checked = True Then
            TxtCorreo.PasswordChar = ""
        Else
            TxtCorreo.PasswordChar = "#"
        End If
    End Sub

    Private Sub ChkContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles ChkContraseña.CheckedChanged
        If ChkContraseña.Checked = True Then
            TxtContraseña.PasswordChar = ""
        Else
            TxtContraseña.PasswordChar = "#"
        End If
    End Sub
End Class