<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vencimientos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridVencimiento = New System.Windows.Forms.DataGridView()
        Me.IDProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClasificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetarioMédicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMínimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMáximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdaddeConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet31 = New Farmacia._BD_CruzDataSet31()
        Me.ProductosVencidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet25 = New Farmacia._BD_CruzDataSet25()
        Me.ProductosVencidosTableAdapter = New Farmacia._BD_CruzDataSet25TableAdapters.ProductosVencidosTableAdapter()
        Me._BD_CruzDataSet28 = New Farmacia._BD_CruzDataSet28()
        Me._BD_CruzDataSet29 = New Farmacia._BD_CruzDataSet29()
        Me._BD_CruzDataSet27 = New Farmacia._BD_CruzDataSet27()
        Me.BDCruzDataSet27BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet9 = New Farmacia._BD_CruzDataSet9()
        Me.BDCruzDataSet9BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDCruzDataSet28BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDCruzDataSet27BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet7 = New Farmacia._BD_CruzDataSet7()
        Me.BDCruzDataSet7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet30 = New Farmacia._BD_CruzDataSet30()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Farmacia._BD_CruzDataSet30TableAdapters.ProductoTableAdapter()
        Me.ProductoTableAdapter1 = New Farmacia._BD_CruzDataSet31TableAdapters.ProductoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosVencidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCruzDataSet27BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCruzDataSet9BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCruzDataSet28BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCruzDataSet27BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDCruzDataSet7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(310, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1035, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos en Vencimiento"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(47, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridVencimiento)
        Me.Panel1.Location = New System.Drawing.Point(143, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridVencimiento
        '
        Me.DataGridVencimiento.AutoGenerateColumns = False
        Me.DataGridVencimiento.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVencimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVencimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentaciónDataGridViewTextBoxColumn, Me.UsoDataGridViewTextBoxColumn, Me.RecetarioMédicoDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.StockMínimoDataGridViewTextBoxColumn, Me.StockMáximoDataGridViewTextBoxColumn, Me.StockActualDataGridViewTextBoxColumn, Me.VencimientoDataGridViewTextBoxColumn, Me.EdaddeConsumoDataGridViewTextBoxColumn})
        Me.DataGridVencimiento.DataSource = Me.ProductoBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridVencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridVencimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridVencimiento.EnableHeadersVisualStyles = False
        Me.DataGridVencimiento.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridVencimiento.Location = New System.Drawing.Point(0, 0)
        Me.DataGridVencimiento.Name = "DataGridVencimiento"
        Me.DataGridVencimiento.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVencimiento.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridVencimiento.RowHeadersWidth = 62
        Me.DataGridVencimiento.RowTemplate.Height = 28
        Me.DataGridVencimiento.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridVencimiento.TabIndex = 0
        '
        'IDProductoDataGridViewTextBoxColumn
        '
        Me.IDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto"
        Me.IDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto"
        Me.IDProductoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDProductoDataGridViewTextBoxColumn.Name = "IDProductoDataGridViewTextBoxColumn"
        Me.IDProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProductoDataGridViewTextBoxColumn.Width = 150
        '
        'IDClasificaciónDataGridViewTextBoxColumn
        '
        Me.IDClasificaciónDataGridViewTextBoxColumn.DataPropertyName = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.HeaderText = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDClasificaciónDataGridViewTextBoxColumn.Name = "IDClasificaciónDataGridViewTextBoxColumn"
        Me.IDClasificaciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDClasificaciónDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'PresentaciónDataGridViewTextBoxColumn
        '
        Me.PresentaciónDataGridViewTextBoxColumn.DataPropertyName = "Presentación"
        Me.PresentaciónDataGridViewTextBoxColumn.HeaderText = "Presentación"
        Me.PresentaciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PresentaciónDataGridViewTextBoxColumn.Name = "PresentaciónDataGridViewTextBoxColumn"
        Me.PresentaciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.PresentaciónDataGridViewTextBoxColumn.Width = 150
        '
        'UsoDataGridViewTextBoxColumn
        '
        Me.UsoDataGridViewTextBoxColumn.DataPropertyName = "Uso"
        Me.UsoDataGridViewTextBoxColumn.HeaderText = "Uso"
        Me.UsoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsoDataGridViewTextBoxColumn.Name = "UsoDataGridViewTextBoxColumn"
        Me.UsoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsoDataGridViewTextBoxColumn.Width = 150
        '
        'RecetarioMédicoDataGridViewTextBoxColumn
        '
        Me.RecetarioMédicoDataGridViewTextBoxColumn.DataPropertyName = "RecetarioMédico"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.HeaderText = "RecetarioMédico"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RecetarioMédicoDataGridViewTextBoxColumn.Name = "RecetarioMédicoDataGridViewTextBoxColumn"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecetarioMédicoDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 150
        '
        'StockMínimoDataGridViewTextBoxColumn
        '
        Me.StockMínimoDataGridViewTextBoxColumn.DataPropertyName = "StockMínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.HeaderText = "StockMínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockMínimoDataGridViewTextBoxColumn.Name = "StockMínimoDataGridViewTextBoxColumn"
        Me.StockMínimoDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockMínimoDataGridViewTextBoxColumn.Width = 150
        '
        'StockMáximoDataGridViewTextBoxColumn
        '
        Me.StockMáximoDataGridViewTextBoxColumn.DataPropertyName = "StockMáximo"
        Me.StockMáximoDataGridViewTextBoxColumn.HeaderText = "StockMáximo"
        Me.StockMáximoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockMáximoDataGridViewTextBoxColumn.Name = "StockMáximoDataGridViewTextBoxColumn"
        Me.StockMáximoDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockMáximoDataGridViewTextBoxColumn.Width = 150
        '
        'StockActualDataGridViewTextBoxColumn
        '
        Me.StockActualDataGridViewTextBoxColumn.DataPropertyName = "StockActual"
        Me.StockActualDataGridViewTextBoxColumn.HeaderText = "StockActual"
        Me.StockActualDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockActualDataGridViewTextBoxColumn.Name = "StockActualDataGridViewTextBoxColumn"
        Me.StockActualDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockActualDataGridViewTextBoxColumn.Width = 150
        '
        'VencimientoDataGridViewTextBoxColumn
        '
        Me.VencimientoDataGridViewTextBoxColumn.DataPropertyName = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VencimientoDataGridViewTextBoxColumn.Name = "VencimientoDataGridViewTextBoxColumn"
        Me.VencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VencimientoDataGridViewTextBoxColumn.Width = 150
        '
        'EdaddeConsumoDataGridViewTextBoxColumn
        '
        Me.EdaddeConsumoDataGridViewTextBoxColumn.DataPropertyName = "EdaddeConsumo"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.HeaderText = "EdaddeConsumo"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EdaddeConsumoDataGridViewTextBoxColumn.Name = "EdaddeConsumoDataGridViewTextBoxColumn"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EdaddeConsumoDataGridViewTextBoxColumn.Width = 150
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me._BD_CruzDataSet31
        '
        '_BD_CruzDataSet31
        '
        Me._BD_CruzDataSet31.DataSetName = "_BD_CruzDataSet31"
        Me._BD_CruzDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosVencidosBindingSource
        '
        Me.ProductosVencidosBindingSource.DataMember = "ProductosVencidos"
        Me.ProductosVencidosBindingSource.DataSource = Me._BD_CruzDataSet25
        '
        '_BD_CruzDataSet25
        '
        Me._BD_CruzDataSet25.DataSetName = "_BD_CruzDataSet25"
        Me._BD_CruzDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosVencidosTableAdapter
        '
        Me.ProductosVencidosTableAdapter.ClearBeforeFill = True
        '
        '_BD_CruzDataSet28
        '
        Me._BD_CruzDataSet28.DataSetName = "_BD_CruzDataSet28"
        Me._BD_CruzDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_BD_CruzDataSet29
        '
        Me._BD_CruzDataSet29.DataSetName = "_BD_CruzDataSet29"
        Me._BD_CruzDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_BD_CruzDataSet27
        '
        Me._BD_CruzDataSet27.DataSetName = "_BD_CruzDataSet27"
        Me._BD_CruzDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDCruzDataSet27BindingSource
        '
        Me.BDCruzDataSet27BindingSource.DataSource = Me._BD_CruzDataSet27
        Me.BDCruzDataSet27BindingSource.Position = 0
        '
        '_BD_CruzDataSet9
        '
        Me._BD_CruzDataSet9.DataSetName = "_BD_CruzDataSet9"
        Me._BD_CruzDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDCruzDataSet9BindingSource
        '
        Me.BDCruzDataSet9BindingSource.DataSource = Me._BD_CruzDataSet9
        Me.BDCruzDataSet9BindingSource.Position = 0
        '
        'BDCruzDataSet28BindingSource
        '
        Me.BDCruzDataSet28BindingSource.DataSource = Me._BD_CruzDataSet28
        Me.BDCruzDataSet28BindingSource.Position = 0
        '
        'BDCruzDataSet27BindingSource1
        '
        Me.BDCruzDataSet27BindingSource1.DataSource = Me._BD_CruzDataSet27
        Me.BDCruzDataSet27BindingSource1.Position = 0
        '
        '_BD_CruzDataSet7
        '
        Me._BD_CruzDataSet7.DataSetName = "_BD_CruzDataSet7"
        Me._BD_CruzDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDCruzDataSet7BindingSource
        '
        Me.BDCruzDataSet7BindingSource.DataSource = Me._BD_CruzDataSet7
        Me.BDCruzDataSet7BindingSource.Position = 0
        '
        '_BD_CruzDataSet30
        '
        Me._BD_CruzDataSet30.DataSetName = "_BD_CruzDataSet30"
        Me._BD_CruzDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me._BD_CruzDataSet30
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter1
        '
        Me.ProductoTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(729, 177)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(666, 233)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(200, 44)
        Me.TxtBuscar.TabIndex = 3
        Me.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(901, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(974, 233)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "<-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Vencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Vencimientos"
        Me.Text = "Vencimientos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosVencidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCruzDataSet27BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCruzDataSet9BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCruzDataSet28BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCruzDataSet27BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDCruzDataSet7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _BD_CruzDataSet25 As _BD_CruzDataSet25
    Friend WithEvents ProductosVencidosBindingSource As BindingSource
    Friend WithEvents ProductosVencidosTableAdapter As _BD_CruzDataSet25TableAdapters.ProductosVencidosTableAdapter
    Friend WithEvents BDCruzDataSet27BindingSource As BindingSource
    Friend WithEvents _BD_CruzDataSet27 As _BD_CruzDataSet27
    Friend WithEvents _BD_CruzDataSet28 As _BD_CruzDataSet28
    Friend WithEvents _BD_CruzDataSet29 As _BD_CruzDataSet29
    Friend WithEvents _BD_CruzDataSet9 As _BD_CruzDataSet9
    Friend WithEvents BDCruzDataSet9BindingSource As BindingSource
    Friend WithEvents BDCruzDataSet28BindingSource As BindingSource
    Friend WithEvents BDCruzDataSet27BindingSource1 As BindingSource
    Friend WithEvents _BD_CruzDataSet7 As _BD_CruzDataSet7
    Friend WithEvents BDCruzDataSet7BindingSource As BindingSource
    Friend WithEvents _BD_CruzDataSet30 As _BD_CruzDataSet30
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _BD_CruzDataSet30TableAdapters.ProductoTableAdapter
    Friend WithEvents DataGridVencimiento As DataGridView
    Friend WithEvents _BD_CruzDataSet31 As _BD_CruzDataSet31
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProductoTableAdapter1 As _BD_CruzDataSet31TableAdapters.ProductoTableAdapter
    Friend WithEvents IDProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClasificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecetarioMédicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMínimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMáximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockActualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdaddeConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
