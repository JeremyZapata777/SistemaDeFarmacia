<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarInventario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarInventario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PanelConsulta = New System.Windows.Forms.Panel()
        Me.DataGridConsulta = New System.Windows.Forms.DataGridView()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet5 = New Farmacia._BD_CruzDataSet5()
        Me.ProductoTableAdapter = New Farmacia._BD_CruzDataSet5TableAdapters.ProductoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClasificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetarioMédicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMínimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMáximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdaddeConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelConsulta.SuspendLayout()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1238, 146)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultar inventario"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSalir.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Location = New System.Drawing.Point(44, 41)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(164, 54)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "X"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PanelConsulta
        '
        Me.PanelConsulta.AutoScroll = True
        Me.PanelConsulta.Controls.Add(Me.DataGridConsulta)
        Me.PanelConsulta.Location = New System.Drawing.Point(151, 313)
        Me.PanelConsulta.Name = "PanelConsulta"
        Me.PanelConsulta.Size = New System.Drawing.Size(1351, 508)
        Me.PanelConsulta.TabIndex = 2
        '
        'DataGridConsulta
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridConsulta.AutoGenerateColumns = False
        Me.DataGridConsulta.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridConsulta.ColumnHeadersHeight = 34
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentaciónDataGridViewTextBoxColumn, Me.UsoDataGridViewTextBoxColumn, Me.RecetarioMédicoDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.StockMínimo, Me.StockMáximo, Me.StockActual, Me.VencimientoDataGridViewTextBoxColumn, Me.EdaddeConsumoDataGridViewTextBoxColumn})
        Me.DataGridConsulta.DataSource = Me.ProductoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridConsulta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridConsulta.EnableHeadersVisualStyles = False
        Me.DataGridConsulta.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridConsulta.Location = New System.Drawing.Point(0, 0)
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridConsulta.RowHeadersWidth = 62
        Me.DataGridConsulta.RowTemplate.Height = 28
        Me.DataGridConsulta.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridConsulta.TabIndex = 0
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me._BD_CruzDataSet5
        '
        '_BD_CruzDataSet5
        '
        Me._BD_CruzDataSet5.DataSetName = "_BD_CruzDataSet5"
        Me._BD_CruzDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(736, 167)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(682, 223)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(185, 44)
        Me.TxtBuscar.TabIndex = 3
        Me.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(908, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(978, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "<-"
        Me.Button2.UseVisualStyleBackColor = False
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
        'StockMínimo
        '
        Me.StockMínimo.DataPropertyName = "StockMínimo"
        Me.StockMínimo.HeaderText = "StockMínimo"
        Me.StockMínimo.MinimumWidth = 8
        Me.StockMínimo.Name = "StockMínimo"
        Me.StockMínimo.ReadOnly = True
        Me.StockMínimo.Width = 150
        '
        'StockMáximo
        '
        Me.StockMáximo.DataPropertyName = "StockMáximo"
        Me.StockMáximo.HeaderText = "StockMáximo"
        Me.StockMáximo.MinimumWidth = 8
        Me.StockMáximo.Name = "StockMáximo"
        Me.StockMáximo.ReadOnly = True
        Me.StockMáximo.Width = 150
        '
        'StockActual
        '
        Me.StockActual.DataPropertyName = "StockActual"
        Me.StockActual.HeaderText = "StockActual"
        Me.StockActual.MinimumWidth = 8
        Me.StockActual.Name = "StockActual"
        Me.StockActual.ReadOnly = True
        Me.StockActual.Width = 150
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
        'ConsultarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.PanelConsulta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultarInventario"
        Me.Text = "ConsultarInventario"
        Me.PanelConsulta.ResumeLayout(False)
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PanelConsulta As Panel
    Friend WithEvents DataGridConsulta As DataGridView
    Friend WithEvents _BD_CruzDataSet5 As _BD_CruzDataSet5
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _BD_CruzDataSet5TableAdapters.ProductoTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IDProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClasificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecetarioMédicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMínimo As DataGridViewTextBoxColumn
    Friend WithEvents StockMáximo As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents VencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdaddeConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
