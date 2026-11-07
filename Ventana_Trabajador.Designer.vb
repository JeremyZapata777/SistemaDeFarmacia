<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Trabajador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Trabajador))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnVencimientos = New System.Windows.Forms.Button()
        Me.BtnSuministros = New System.Windows.Forms.Button()
        Me.BtnLaboratorios = New System.Windows.Forms.Button()
        Me.BtnPersonal = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnConsultaInventario = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelLaboresTrabajador = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.BtnVencimientos)
        Me.Panel1.Controls.Add(Me.BtnSuministros)
        Me.Panel1.Controls.Add(Me.BtnLaboratorios)
        Me.Panel1.Controls.Add(Me.BtnPersonal)
        Me.Panel1.Controls.Add(Me.BtnCliente)
        Me.Panel1.Controls.Add(Me.BtnConsultaInventario)
        Me.Panel1.Controls.Add(Me.BtnVenta)
        Me.Panel1.Controls.Add(Me.BtnCompra)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 1050)
        Me.Panel1.TabIndex = 0
        '
        'BtnVencimientos
        '
        Me.BtnVencimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVencimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVencimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVencimientos.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVencimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVencimientos.Location = New System.Drawing.Point(0, 880)
        Me.BtnVencimientos.Name = "BtnVencimientos"
        Me.BtnVencimientos.Size = New System.Drawing.Size(250, 90)
        Me.BtnVencimientos.TabIndex = 5
        Me.BtnVencimientos.Text = "Productos en vencimiento"
        Me.BtnVencimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVencimientos.UseVisualStyleBackColor = True
        '
        'BtnSuministros
        '
        Me.BtnSuministros.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSuministros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSuministros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuministros.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuministros.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSuministros.Location = New System.Drawing.Point(0, 790)
        Me.BtnSuministros.Name = "BtnSuministros"
        Me.BtnSuministros.Size = New System.Drawing.Size(250, 90)
        Me.BtnSuministros.TabIndex = 5
        Me.BtnSuministros.Text = "Observar suministros"
        Me.BtnSuministros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSuministros.UseVisualStyleBackColor = True
        '
        'BtnLaboratorios
        '
        Me.BtnLaboratorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLaboratorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLaboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaboratorios.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaboratorios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLaboratorios.Location = New System.Drawing.Point(0, 700)
        Me.BtnLaboratorios.Name = "BtnLaboratorios"
        Me.BtnLaboratorios.Size = New System.Drawing.Size(250, 90)
        Me.BtnLaboratorios.TabIndex = 5
        Me.BtnLaboratorios.Text = "Información de laboratorios"
        Me.BtnLaboratorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaboratorios.UseVisualStyleBackColor = True
        '
        'BtnPersonal
        '
        Me.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersonal.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPersonal.Location = New System.Drawing.Point(0, 610)
        Me.BtnPersonal.Name = "BtnPersonal"
        Me.BtnPersonal.Size = New System.Drawing.Size(250, 90)
        Me.BtnPersonal.TabIndex = 5
        Me.BtnPersonal.Text = "Visualización del personal"
        Me.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPersonal.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCliente.Location = New System.Drawing.Point(0, 520)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(250, 90)
        Me.BtnCliente.TabIndex = 4
        Me.BtnCliente.Text = "Registro de Cliente"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnConsultaInventario
        '
        Me.BtnConsultaInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConsultaInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnConsultaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultaInventario.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnConsultaInventario.Location = New System.Drawing.Point(0, 430)
        Me.BtnConsultaInventario.Name = "BtnConsultaInventario"
        Me.BtnConsultaInventario.Size = New System.Drawing.Size(250, 90)
        Me.BtnConsultaInventario.TabIndex = 3
        Me.BtnConsultaInventario.Text = "Consulta Stock"
        Me.BtnConsultaInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultaInventario.UseVisualStyleBackColor = True
        '
        'BtnVenta
        '
        Me.BtnVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVenta.Location = New System.Drawing.Point(0, 340)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(250, 90)
        Me.BtnVenta.TabIndex = 2
        Me.BtnVenta.Text = "Realizar Venta"
        Me.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'BtnCompra
        '
        Me.BtnCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompra.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompra.Location = New System.Drawing.Point(0, 250)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(250, 90)
        Me.BtnCompra.TabIndex = 1
        Me.BtnCompra.Text = "Nueva Compra"
        Me.BtnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompra.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 250)
        Me.Panel2.TabIndex = 0
        '
        'PanelLaboresTrabajador
        '
        Me.PanelLaboresTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.PanelLaboresTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLaboresTrabajador.Location = New System.Drawing.Point(250, 0)
        Me.PanelLaboresTrabajador.Name = "PanelLaboresTrabajador"
        Me.PanelLaboresTrabajador.Size = New System.Drawing.Size(1674, 1050)
        Me.PanelLaboresTrabajador.TabIndex = 1
        '
        'Ventana_Trabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.PanelLaboresTrabajador)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Ventana_Trabajador"
        Me.Text = "Ventana_Trabajador"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnConsultaInventario As Button
    Friend WithEvents BtnVenta As Button
    Friend WithEvents BtnCompra As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCliente As Button
    Friend WithEvents PanelLaboresTrabajador As Panel
    Friend WithEvents BtnVencimientos As Button
    Friend WithEvents BtnSuministros As Button
    Friend WithEvents BtnLaboratorios As Button
    Friend WithEvents BtnPersonal As Button
End Class
