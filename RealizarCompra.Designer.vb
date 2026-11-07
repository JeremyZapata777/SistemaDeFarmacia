<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarCompra))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCompra = New System.Windows.Forms.Panel()
        Me.DataGridCompras = New System.Windows.Forms.DataGridView()
        Me.IDCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDColaboradores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProductoSuministro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalledeCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprasBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet35 = New Farmacia._BD_CruzDataSet35()
        Me.ComprasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet3 = New Farmacia._BD_CruzDataSet3()
        Me.ComprasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet2 = New Farmacia._BD_CruzDataSet2()
        Me.BtnGuardarCompra = New System.Windows.Forms.Button()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet = New Farmacia._BD_CruzDataSet()
        Me.ComprasTableAdapter = New Farmacia._BD_CruzDataSetTableAdapters.ComprasTableAdapter()
        Me.BtnSalirCompra = New System.Windows.Forms.Button()
        Me._BD_CruzDataSet1 = New Farmacia._BD_CruzDataSet1()
        Me.ComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter1 = New Farmacia._BD_CruzDataSet1TableAdapters.ComprasTableAdapter()
        Me.ComprasTableAdapter2 = New Farmacia._BD_CruzDataSet2TableAdapters.ComprasTableAdapter()
        Me.ComprasTableAdapter3 = New Farmacia._BD_CruzDataSet3TableAdapters.ComprasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComprasTableAdapter4 = New Farmacia._BD_CruzDataSet35TableAdapters.ComprasTableAdapter()
        Me.PanelCompra.SuspendLayout()
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(236, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1174, 146)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comprar Mercancía"
        '
        'PanelCompra
        '
        Me.PanelCompra.Controls.Add(Me.DataGridCompras)
        Me.PanelCompra.Location = New System.Drawing.Point(146, 275)
        Me.PanelCompra.Name = "PanelCompra"
        Me.PanelCompra.Size = New System.Drawing.Size(1351, 508)
        Me.PanelCompra.TabIndex = 1
        '
        'DataGridCompras
        '
        Me.DataGridCompras.AutoGenerateColumns = False
        Me.DataGridCompras.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCompras, Me.IDColaboradores, Me.IDProveedor, Me.IDProducto, Me.IDProductoSuministro, Me.DetalledeCompra, Me.Cantidad, Me.PrecioUnitario, Me.Total, Me.FechaCompra})
        Me.DataGridCompras.DataSource = Me.ComprasBindingSource4
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridCompras.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridCompras.EnableHeadersVisualStyles = False
        Me.DataGridCompras.GridColor = System.Drawing.Color.White
        Me.DataGridCompras.Location = New System.Drawing.Point(0, 0)
        Me.DataGridCompras.Name = "DataGridCompras"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridCompras.RowHeadersWidth = 62
        Me.DataGridCompras.RowTemplate.Height = 28
        Me.DataGridCompras.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridCompras.TabIndex = 0
        '
        'IDCompras
        '
        Me.IDCompras.DataPropertyName = "IDCompras"
        Me.IDCompras.HeaderText = "IDCompras"
        Me.IDCompras.MinimumWidth = 8
        Me.IDCompras.Name = "IDCompras"
        Me.IDCompras.Width = 150
        '
        'IDColaboradores
        '
        Me.IDColaboradores.DataPropertyName = "IDColaboradores"
        Me.IDColaboradores.HeaderText = "IDColaboradores"
        Me.IDColaboradores.MinimumWidth = 8
        Me.IDColaboradores.Name = "IDColaboradores"
        Me.IDColaboradores.Width = 150
        '
        'IDProveedor
        '
        Me.IDProveedor.DataPropertyName = "IDProveedor"
        Me.IDProveedor.HeaderText = "IDProveedor"
        Me.IDProveedor.MinimumWidth = 8
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.Width = 150
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
        'DetalledeCompra
        '
        Me.DetalledeCompra.DataPropertyName = "DetalledeCompra"
        Me.DetalledeCompra.HeaderText = "DetalledeCompra"
        Me.DetalledeCompra.MinimumWidth = 8
        Me.DetalledeCompra.Name = "DetalledeCompra"
        Me.DetalledeCompra.Width = 150
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
        'FechaCompra
        '
        Me.FechaCompra.DataPropertyName = "FechaCompra"
        Me.FechaCompra.HeaderText = "FechaCompra"
        Me.FechaCompra.MinimumWidth = 8
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.Width = 150
        '
        'ComprasBindingSource4
        '
        Me.ComprasBindingSource4.DataMember = "Compras"
        Me.ComprasBindingSource4.DataSource = Me._BD_CruzDataSet35
        '
        '_BD_CruzDataSet35
        '
        Me._BD_CruzDataSet35.DataSetName = "_BD_CruzDataSet35"
        Me._BD_CruzDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource3
        '
        Me.ComprasBindingSource3.DataMember = "Compras"
        Me.ComprasBindingSource3.DataSource = Me._BD_CruzDataSet3
        '
        '_BD_CruzDataSet3
        '
        Me._BD_CruzDataSet3.DataSetName = "_BD_CruzDataSet3"
        Me._BD_CruzDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource2
        '
        Me.ComprasBindingSource2.DataMember = "Compras"
        Me.ComprasBindingSource2.DataSource = Me._BD_CruzDataSet2
        '
        '_BD_CruzDataSet2
        '
        Me._BD_CruzDataSet2.DataSetName = "_BD_CruzDataSet2"
        Me._BD_CruzDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnGuardarCompra
        '
        Me.BtnGuardarCompra.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnGuardarCompra.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarCompra.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardarCompra.Location = New System.Drawing.Point(683, 820)
        Me.BtnGuardarCompra.Name = "BtnGuardarCompra"
        Me.BtnGuardarCompra.Size = New System.Drawing.Size(370, 78)
        Me.BtnGuardarCompra.TabIndex = 1
        Me.BtnGuardarCompra.Text = "Guardar cambios"
        Me.BtnGuardarCompra.UseVisualStyleBackColor = False
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me._BD_CruzDataSet
        '
        '_BD_CruzDataSet
        '
        Me._BD_CruzDataSet.DataSetName = "_BD_CruzDataSet"
        Me._BD_CruzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'BtnSalirCompra
        '
        Me.BtnSalirCompra.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSalirCompra.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalirCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalirCompra.Location = New System.Drawing.Point(35, 30)
        Me.BtnSalirCompra.Name = "BtnSalirCompra"
        Me.BtnSalirCompra.Size = New System.Drawing.Size(161, 61)
        Me.BtnSalirCompra.TabIndex = 2
        Me.BtnSalirCompra.Text = "X"
        Me.BtnSalirCompra.UseVisualStyleBackColor = False
        '
        '_BD_CruzDataSet1
        '
        Me._BD_CruzDataSet1.DataSetName = "_BD_CruzDataSet1"
        Me._BD_CruzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource1
        '
        Me.ComprasBindingSource1.DataMember = "Compras"
        Me.ComprasBindingSource1.DataSource = Me._BD_CruzDataSet1
        '
        'ComprasTableAdapter1
        '
        Me.ComprasTableAdapter1.ClearBeforeFill = True
        '
        'ComprasTableAdapter2
        '
        Me.ComprasTableAdapter2.ClearBeforeFill = True
        '
        'ComprasTableAdapter3
        '
        Me.ComprasTableAdapter3.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(728, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Búsqueda por ID"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.DarkGreen
        Me.TxtBuscar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.White
        Me.TxtBuscar.Location = New System.Drawing.Point(658, 207)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(210, 44)
        Me.TxtBuscar.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(930, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1000, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "<-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComprasTableAdapter4
        '
        Me.ComprasTableAdapter4.ClearBeforeFill = True
        '
        'RealizarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnGuardarCompra)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSalirCompra)
        Me.Controls.Add(Me.PanelCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RealizarCompra"
        Me.Text = "RealizarCompra"
        Me.PanelCompra.ResumeLayout(False)
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCompra As Panel
    Friend WithEvents _BD_CruzDataSet As _BD_CruzDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As _BD_CruzDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents BtnSalirCompra As Button
    Friend WithEvents BtnGuardarCompra As Button
    Friend WithEvents _BD_CruzDataSet1 As _BD_CruzDataSet1
    Friend WithEvents ComprasBindingSource1 As BindingSource
    Friend WithEvents ComprasTableAdapter1 As _BD_CruzDataSet1TableAdapters.ComprasTableAdapter
    Friend WithEvents _BD_CruzDataSet2 As _BD_CruzDataSet2
    Friend WithEvents ComprasBindingSource2 As BindingSource
    Friend WithEvents ComprasTableAdapter2 As _BD_CruzDataSet2TableAdapters.ComprasTableAdapter
    Friend WithEvents _BD_CruzDataSet3 As _BD_CruzDataSet3
    Friend WithEvents ComprasBindingSource3 As BindingSource
    Friend WithEvents ComprasTableAdapter3 As _BD_CruzDataSet3TableAdapters.ComprasTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridCompras As DataGridView
    Friend WithEvents _BD_CruzDataSet35 As _BD_CruzDataSet35
    Friend WithEvents ComprasBindingSource4 As BindingSource
    Friend WithEvents ComprasTableAdapter4 As _BD_CruzDataSet35TableAdapters.ComprasTableAdapter
    Friend WithEvents IDCompras As DataGridViewTextBoxColumn
    Friend WithEvents IDColaboradores As DataGridViewTextBoxColumn
    Friend WithEvents IDProveedor As DataGridViewTextBoxColumn
    Friend WithEvents IDProducto As DataGridViewTextBoxColumn
    Friend WithEvents IDProductoSuministro As DataGridViewTextBoxColumn
    Friend WithEvents DetalledeCompra As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As DataGridViewTextBoxColumn
End Class
