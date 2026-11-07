<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlVentas))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridControlVentas = New System.Windows.Forms.DataGridView()
        Me.IDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDColaboradores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductoSuministro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDeProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet38 = New Farmacia._BD_CruzDataSet38()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet34 = New Farmacia._BD_CruzDataSet34()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet13 = New Farmacia._BD_CruzDataSet13()
        Me.VentasTableAdapter = New Farmacia._BD_CruzDataSet13TableAdapters.VentasTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.VentasTableAdapter1 = New Farmacia._BD_CruzDataSet34TableAdapters.VentasTableAdapter()
        Me._BD_CruzDataSet37 = New Farmacia._BD_CruzDataSet37()
        Me.VentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter2 = New Farmacia._BD_CruzDataSet37TableAdapters.VentasTableAdapter()
        Me.VentasTableAdapter3 = New Farmacia._BD_CruzDataSet38TableAdapters.VentasTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridControlVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(45, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 69)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(294, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1053, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de ventas"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridControlVentas)
        Me.Panel1.Location = New System.Drawing.Point(144, 297)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridControlVentas
        '
        Me.DataGridControlVentas.AutoGenerateColumns = False
        Me.DataGridControlVentas.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridControlVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridControlVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVenta, Me.IDColaboradores, Me.IDCliente, Me.IDProducto, Me.IDProductoSuministro, Me.DetalleDeProducto, Me.Cantidad, Me.PrecioUnitario, Me.Total, Me.FechaDeVenta})
        Me.DataGridControlVentas.DataSource = Me.VentasBindingSource3
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridControlVentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridControlVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridControlVentas.EnableHeadersVisualStyles = False
        Me.DataGridControlVentas.GridColor = System.Drawing.Color.White
        Me.DataGridControlVentas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridControlVentas.Name = "DataGridControlVentas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridControlVentas.RowHeadersWidth = 62
        Me.DataGridControlVentas.RowTemplate.Height = 28
        Me.DataGridControlVentas.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridControlVentas.TabIndex = 0
        '
        'IDVenta
        '
        Me.IDVenta.DataPropertyName = "IDVenta"
        Me.IDVenta.HeaderText = "IDVenta"
        Me.IDVenta.MinimumWidth = 8
        Me.IDVenta.Name = "IDVenta"
        Me.IDVenta.Width = 150
        '
        'IDColaboradores
        '
        Me.IDColaboradores.DataPropertyName = "IDColaboradores"
        Me.IDColaboradores.HeaderText = "IDColaboradores"
        Me.IDColaboradores.MinimumWidth = 8
        Me.IDColaboradores.Name = "IDColaboradores"
        Me.IDColaboradores.Width = 150
        '
        'IDCliente
        '
        Me.IDCliente.DataPropertyName = "IDCliente"
        Me.IDCliente.HeaderText = "IDCliente"
        Me.IDCliente.MinimumWidth = 8
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.Width = 150
        '
        'IDProducto
        '
        Me.IDProducto.DataPropertyName = "IDProducto"
        Me.IDProducto.HeaderText = "IDProducto"
        Me.IDProducto.MinimumWidth = 8
        Me.IDProducto.Name = "IDProducto"
        Me.IDProducto.Width = 150
        '
        'IDProductoSuministro
        '
        Me.IDProductoSuministro.DataPropertyName = "IDProductoSuministro"
        Me.IDProductoSuministro.HeaderText = "IDProductoSuministro"
        Me.IDProductoSuministro.MinimumWidth = 8
        Me.IDProductoSuministro.Name = "IDProductoSuministro"
        Me.IDProductoSuministro.Width = 150
        '
        'DetalleDeProducto
        '
        Me.DetalleDeProducto.DataPropertyName = "DetalleDeProducto"
        Me.DetalleDeProducto.HeaderText = "DetalleDeProducto"
        Me.DetalleDeProducto.MinimumWidth = 8
        Me.DetalleDeProducto.Name = "DetalleDeProducto"
        Me.DetalleDeProducto.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 150
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitario.HeaderText = "PrecioUnitario"
        Me.PrecioUnitario.MinimumWidth = 8
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.Width = 150
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.Width = 150
        '
        'FechaDeVenta
        '
        Me.FechaDeVenta.DataPropertyName = "FechaDeVenta"
        Me.FechaDeVenta.HeaderText = "FechaDeVenta"
        Me.FechaDeVenta.MinimumWidth = 8
        Me.FechaDeVenta.Name = "FechaDeVenta"
        Me.FechaDeVenta.Width = 150
        '
        'VentasBindingSource3
        '
        Me.VentasBindingSource3.DataMember = "Ventas"
        Me.VentasBindingSource3.DataSource = Me._BD_CruzDataSet38
        '
        '_BD_CruzDataSet38
        '
        Me._BD_CruzDataSet38.DataSetName = "_BD_CruzDataSet38"
        Me._BD_CruzDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "Ventas"
        Me.VentasBindingSource1.DataSource = Me._BD_CruzDataSet34
        '
        '_BD_CruzDataSet34
        '
        Me._BD_CruzDataSet34.DataSetName = "_BD_CruzDataSet34"
        Me._BD_CruzDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me._BD_CruzDataSet13
        '
        '_BD_CruzDataSet13
        '
        Me._BD_CruzDataSet13.DataSetName = "_BD_CruzDataSet13"
        Me._BD_CruzDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(662, 831)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 80)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(740, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Búsqueda por ID"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.DarkGreen
        Me.TxtBuscar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.White
        Me.TxtBuscar.Location = New System.Drawing.Point(695, 218)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(179, 44)
        Me.TxtBuscar.TabIndex = 3
        Me.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(918, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 45)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(980, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 45)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        '_BD_CruzDataSet37
        '
        Me._BD_CruzDataSet37.DataSetName = "_BD_CruzDataSet37"
        Me._BD_CruzDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource2
        '
        Me.VentasBindingSource2.DataMember = "Ventas"
        Me.VentasBindingSource2.DataSource = Me._BD_CruzDataSet37
        '
        'VentasTableAdapter2
        '
        Me.VentasTableAdapter2.ClearBeforeFill = True
        '
        'VentasTableAdapter3
        '
        Me.VentasTableAdapter3.ClearBeforeFill = True
        '
        'ControlVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ControlVentas"
        Me.Text = "ControlVentas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridControlVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _BD_CruzDataSet13 As _BD_CruzDataSet13
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _BD_CruzDataSet13TableAdapters.VentasTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents _BD_CruzDataSet34 As _BD_CruzDataSet34
    Friend WithEvents VentasBindingSource1 As BindingSource
    Friend WithEvents VentasTableAdapter1 As _BD_CruzDataSet34TableAdapters.VentasTableAdapter
    Friend WithEvents _BD_CruzDataSet37 As _BD_CruzDataSet37
    Friend WithEvents VentasBindingSource2 As BindingSource
    Friend WithEvents VentasTableAdapter2 As _BD_CruzDataSet37TableAdapters.VentasTableAdapter
    Friend WithEvents DataGridControlVentas As DataGridView
    Friend WithEvents _BD_CruzDataSet38 As _BD_CruzDataSet38
    Friend WithEvents VentasBindingSource3 As BindingSource
    Friend WithEvents VentasTableAdapter3 As _BD_CruzDataSet38TableAdapters.VentasTableAdapter
    Friend WithEvents IDVenta As DataGridViewTextBoxColumn
    Friend WithEvents IDColaboradores As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents IDProducto As DataGridViewTextBoxColumn
    Friend WithEvents IDProductoSuministro As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDeProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeVenta As DataGridViewTextBoxColumn
End Class
