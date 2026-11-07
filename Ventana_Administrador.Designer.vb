<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Administrador))
        Me.PanelAdministrador = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnControlLaboratorios = New System.Windows.Forms.Button()
        Me.BtnControlVentas = New System.Windows.Forms.Button()
        Me.BtnControlCompras = New System.Windows.Forms.Button()
        Me.BtnRegistroClientes = New System.Windows.Forms.Button()
        Me.BtnRegistroProveedores = New System.Windows.Forms.Button()
        Me.BtnRegistroEmpleados = New System.Windows.Forms.Button()
        Me.BtnControlInventario = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelLaboresAdministrador = New System.Windows.Forms.Panel()
        Me.PanelAdministrador.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAdministrador
        '
        Me.PanelAdministrador.AutoScroll = True
        Me.PanelAdministrador.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelAdministrador.Controls.Add(Me.Button2)
        Me.PanelAdministrador.Controls.Add(Me.Button1)
        Me.PanelAdministrador.Controls.Add(Me.BtnControlLaboratorios)
        Me.PanelAdministrador.Controls.Add(Me.BtnControlVentas)
        Me.PanelAdministrador.Controls.Add(Me.BtnControlCompras)
        Me.PanelAdministrador.Controls.Add(Me.BtnRegistroClientes)
        Me.PanelAdministrador.Controls.Add(Me.BtnRegistroProveedores)
        Me.PanelAdministrador.Controls.Add(Me.BtnRegistroEmpleados)
        Me.PanelAdministrador.Controls.Add(Me.BtnControlInventario)
        Me.PanelAdministrador.Controls.Add(Me.Panel1)
        Me.PanelAdministrador.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelAdministrador.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdministrador.Name = "PanelAdministrador"
        Me.PanelAdministrador.Size = New System.Drawing.Size(250, 1050)
        Me.PanelAdministrador.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(0, 970)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 90)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Control de suministros farmacéuticos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(0, 880)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 90)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Control de vencimientos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnControlLaboratorios
        '
        Me.BtnControlLaboratorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnControlLaboratorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnControlLaboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnControlLaboratorios.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnControlLaboratorios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnControlLaboratorios.Location = New System.Drawing.Point(0, 790)
        Me.BtnControlLaboratorios.Name = "BtnControlLaboratorios"
        Me.BtnControlLaboratorios.Size = New System.Drawing.Size(224, 90)
        Me.BtnControlLaboratorios.TabIndex = 7
        Me.BtnControlLaboratorios.Text = "Gestión de Laboratorios"
        Me.BtnControlLaboratorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlLaboratorios.UseVisualStyleBackColor = True
        '
        'BtnControlVentas
        '
        Me.BtnControlVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnControlVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnControlVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnControlVentas.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnControlVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnControlVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlVentas.Location = New System.Drawing.Point(0, 700)
        Me.BtnControlVentas.Name = "BtnControlVentas"
        Me.BtnControlVentas.Size = New System.Drawing.Size(224, 90)
        Me.BtnControlVentas.TabIndex = 6
        Me.BtnControlVentas.Text = "Salidas/Ventas"
        Me.BtnControlVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlVentas.UseVisualStyleBackColor = True
        '
        'BtnControlCompras
        '
        Me.BtnControlCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnControlCompras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnControlCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnControlCompras.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnControlCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnControlCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlCompras.Location = New System.Drawing.Point(0, 610)
        Me.BtnControlCompras.Name = "BtnControlCompras"
        Me.BtnControlCompras.Size = New System.Drawing.Size(224, 90)
        Me.BtnControlCompras.TabIndex = 5
        Me.BtnControlCompras.Text = "Entradas/Salida"
        Me.BtnControlCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlCompras.UseVisualStyleBackColor = True
        '
        'BtnRegistroClientes
        '
        Me.BtnRegistroClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistroClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroClientes.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroClientes.Location = New System.Drawing.Point(0, 520)
        Me.BtnRegistroClientes.Name = "BtnRegistroClientes"
        Me.BtnRegistroClientes.Size = New System.Drawing.Size(224, 90)
        Me.BtnRegistroClientes.TabIndex = 4
        Me.BtnRegistroClientes.Text = "Base de Clientes"
        Me.BtnRegistroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroClientes.UseVisualStyleBackColor = True
        '
        'BtnRegistroProveedores
        '
        Me.BtnRegistroProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistroProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistroProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroProveedores.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegistroProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroProveedores.Location = New System.Drawing.Point(0, 430)
        Me.BtnRegistroProveedores.Name = "BtnRegistroProveedores"
        Me.BtnRegistroProveedores.Size = New System.Drawing.Size(224, 90)
        Me.BtnRegistroProveedores.TabIndex = 3
        Me.BtnRegistroProveedores.Text = "Base de Proveedores"
        Me.BtnRegistroProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroProveedores.UseVisualStyleBackColor = True
        '
        'BtnRegistroEmpleados
        '
        Me.BtnRegistroEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistroEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegistroEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroEmpleados.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegistroEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroEmpleados.Location = New System.Drawing.Point(0, 340)
        Me.BtnRegistroEmpleados.Name = "BtnRegistroEmpleados"
        Me.BtnRegistroEmpleados.Size = New System.Drawing.Size(224, 90)
        Me.BtnRegistroEmpleados.TabIndex = 2
        Me.BtnRegistroEmpleados.Text = "Gestión de Personal"
        Me.BtnRegistroEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroEmpleados.UseVisualStyleBackColor = True
        '
        'BtnControlInventario
        '
        Me.BtnControlInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnControlInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnControlInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnControlInventario.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnControlInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnControlInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlInventario.Location = New System.Drawing.Point(0, 250)
        Me.BtnControlInventario.Name = "BtnControlInventario"
        Me.BtnControlInventario.Size = New System.Drawing.Size(224, 90)
        Me.BtnControlInventario.TabIndex = 1
        Me.BtnControlInventario.Text = "Stock de Productos"
        Me.BtnControlInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnControlInventario.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 250)
        Me.Panel1.TabIndex = 0
        '
        'PanelLaboresAdministrador
        '
        Me.PanelLaboresAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.PanelLaboresAdministrador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLaboresAdministrador.Location = New System.Drawing.Point(250, 0)
        Me.PanelLaboresAdministrador.Name = "PanelLaboresAdministrador"
        Me.PanelLaboresAdministrador.Size = New System.Drawing.Size(1674, 1050)
        Me.PanelLaboresAdministrador.TabIndex = 1
        '
        'Ventana_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.PanelLaboresAdministrador)
        Me.Controls.Add(Me.PanelAdministrador)
        Me.DoubleBuffered = True
        Me.Name = "Ventana_Administrador"
        Me.Text = "Ventana_Administrador"
        Me.PanelAdministrador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdministrador As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegistroProveedores As Button
    Friend WithEvents BtnRegistroEmpleados As Button
    Friend WithEvents BtnControlInventario As Button
    Friend WithEvents BtnControlVentas As Button
    Friend WithEvents BtnControlCompras As Button
    Friend WithEvents BtnRegistroClientes As Button
    Friend WithEvents PanelLaboresAdministrador As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnControlLaboratorios As Button
End Class
