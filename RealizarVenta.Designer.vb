<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarVenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCompra = New System.Windows.Forms.Panel()
        Me.DataGridVentas = New System.Windows.Forms.DataGridView()
        Me.IDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDColaboradores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductoSuministro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDeProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet39 = New Farmacia._BD_CruzDataSet39()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet36 = New Farmacia._BD_CruzDataSet36()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet4 = New Farmacia._BD_CruzDataSet4()
        Me.VentasTableAdapter = New Farmacia._BD_CruzDataSet4TableAdapters.VentasTableAdapter()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VentasTableAdapter1 = New Farmacia._BD_CruzDataSet36TableAdapters.VentasTableAdapter()
        Me.VentasTableAdapter2 = New Farmacia._BD_CruzDataSet39TableAdapters.VentasTableAdapter()
        Me.PanelCompra.SuspendLayout()
        CType(Me.DataGridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 54.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(365, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(967, 132)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vender Mercancía"
        '
        'PanelCompra
        '
        Me.PanelCompra.AutoScroll = True
        Me.PanelCompra.Controls.Add(Me.DataGridVentas)
        Me.PanelCompra.Location = New System.Drawing.Point(158, 263)
        Me.PanelCompra.Name = "PanelCompra"
        Me.PanelCompra.Size = New System.Drawing.Size(1351, 508)
        Me.PanelCompra.TabIndex = 1
        '
        'DataGridVentas
        '
        Me.DataGridVentas.AutoGenerateColumns = False
        Me.DataGridVentas.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVenta, Me.IDCliente, Me.IDColaboradores, Me.IDProducto, Me.IDProductoSuministro, Me.DetalleDeProducto, Me.Cantidad, Me.PrecioUnitario, Me.Total, Me.FechaDeVenta})
        Me.DataGridVentas.DataSource = Me.VentasBindingSource2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridVentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridVentas.EnableHeadersVisualStyles = False
        Me.DataGridVentas.GridColor = System.Drawing.Color.White
        Me.DataGridVentas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridVentas.Name = "DataGridVentas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridVentas.RowHeadersWidth = 62
        Me.DataGridVentas.RowTemplate.Height = 28
        Me.DataGridVentas.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridVentas.TabIndex = 0
        '
        'IDVenta
        '
        Me.IDVenta.DataPropertyName = "IDVenta"
        Me.IDVenta.HeaderText = "IDVenta"
        Me.IDVenta.MinimumWidth = 8
        Me.IDVenta.Name = "IDVenta"
        Me.IDVenta.Width = 150
        '
        'IDCliente
        '
        Me.IDCliente.DataPropertyName = "IDCliente"
        Me.IDCliente.HeaderText = "IDCliente"
        Me.IDCliente.MinimumWidth = 8
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.Width = 150
        '
        'IDColaboradores
        '
        Me.IDColaboradores.DataPropertyName = "IDColaboradores"
        Me.IDColaboradores.HeaderText = "IDColaboradores"
        Me.IDColaboradores.MinimumWidth = 8
        Me.IDColaboradores.Name = "IDColaboradores"
        Me.IDColaboradores.Width = 150
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
        'VentasBindingSource2
        '
        Me.VentasBindingSource2.DataMember = "Ventas"
        Me.VentasBindingSource2.DataSource = Me._BD_CruzDataSet39
        '
        '_BD_CruzDataSet39
        '
        Me._BD_CruzDataSet39.DataSetName = "_BD_CruzDataSet39"
        Me._BD_CruzDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "Ventas"
        Me.VentasBindingSource1.DataSource = Me._BD_CruzDataSet36
        '
        '_BD_CruzDataSet36
        '
        Me._BD_CruzDataSet36.DataSetName = "_BD_CruzDataSet36"
        Me._BD_CruzDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me._BD_CruzDataSet4
        '
        '_BD_CruzDataSet4
        '
        Me._BD_CruzDataSet4.DataSetName = "_BD_CruzDataSet4"
        Me._BD_CruzDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSalir.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Location = New System.Drawing.Point(22, 28)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 58)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "X"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuardar.Location = New System.Drawing.Point(707, 825)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(329, 71)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(753, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Búsqueda por ID"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.DarkGreen
        Me.TxtBuscar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(707, 197)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(183, 44)
        Me.TxtBuscar.TabIndex = 4
        Me.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(934, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(998, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "<-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        'VentasTableAdapter2
        '
        Me.VentasTableAdapter2.ClearBeforeFill = True
        '
        'RealizarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PanelCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RealizarVenta"
        Me.Text = "RealizarVenta"
        Me.PanelCompra.ResumeLayout(False)
        CType(Me.DataGridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCompra As Panel
    Friend WithEvents _BD_CruzDataSet4 As _BD_CruzDataSet4
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _BD_CruzDataSet4TableAdapters.VentasTableAdapter
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents _BD_CruzDataSet36 As _BD_CruzDataSet36
    Friend WithEvents VentasBindingSource1 As BindingSource
    Friend WithEvents VentasTableAdapter1 As _BD_CruzDataSet36TableAdapters.VentasTableAdapter
    Friend WithEvents DataGridVentas As DataGridView
    Friend WithEvents _BD_CruzDataSet39 As _BD_CruzDataSet39
    Friend WithEvents VentasBindingSource2 As BindingSource
    Friend WithEvents VentasTableAdapter2 As _BD_CruzDataSet39TableAdapters.VentasTableAdapter
    Friend WithEvents IDVenta As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents IDColaboradores As DataGridViewTextBoxColumn
    Friend WithEvents IDProducto As DataGridViewTextBoxColumn
    Friend WithEvents IDProductoSuministro As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDeProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeVenta As DataGridViewTextBoxColumn
End Class
