<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDeInventario
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDeInventario))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridControlInventario = New System.Windows.Forms.DataGridView()
        Me.IDProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClasificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetarioMédicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMínimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMáximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdaddeConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet8 = New Farmacia._BD_CruzDataSet8()
        Me.ProductoTableAdapter = New Farmacia._BD_CruzDataSet8TableAdapters.ProductoTableAdapter()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridControlInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(30, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1280, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de inventario"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridControlInventario)
        Me.Panel1.Location = New System.Drawing.Point(143, 321)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridControlInventario
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridControlInventario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridControlInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridControlInventario.AutoGenerateColumns = False
        Me.DataGridControlInventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridControlInventario.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridControlInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridControlInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentaciónDataGridViewTextBoxColumn, Me.UsoDataGridViewTextBoxColumn, Me.RecetarioMédicoDataGridViewTextBoxColumn, Me.PrecioUnitario, Me.StockMínimo, Me.StockMáximo, Me.StockActual, Me.VencimientoDataGridViewTextBoxColumn, Me.EdaddeConsumoDataGridViewTextBoxColumn})
        Me.DataGridControlInventario.DataSource = Me.ProductoBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridControlInventario.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridControlInventario.EnableHeadersVisualStyles = False
        Me.DataGridControlInventario.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridControlInventario.Location = New System.Drawing.Point(0, 0)
        Me.DataGridControlInventario.Name = "DataGridControlInventario"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlInventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridControlInventario.RowHeadersWidth = 62
        Me.DataGridControlInventario.RowTemplate.Height = 28
        Me.DataGridControlInventario.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridControlInventario.TabIndex = 0
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
        Me.IDClasificaciónDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'PresentaciónDataGridViewTextBoxColumn
        '
        Me.PresentaciónDataGridViewTextBoxColumn.DataPropertyName = "Presentación"
        Me.PresentaciónDataGridViewTextBoxColumn.HeaderText = "Presentación"
        Me.PresentaciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PresentaciónDataGridViewTextBoxColumn.Name = "PresentaciónDataGridViewTextBoxColumn"
        Me.PresentaciónDataGridViewTextBoxColumn.Width = 150
        '
        'UsoDataGridViewTextBoxColumn
        '
        Me.UsoDataGridViewTextBoxColumn.DataPropertyName = "Uso"
        Me.UsoDataGridViewTextBoxColumn.HeaderText = "Uso"
        Me.UsoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsoDataGridViewTextBoxColumn.Name = "UsoDataGridViewTextBoxColumn"
        Me.UsoDataGridViewTextBoxColumn.Width = 150
        '
        'RecetarioMédicoDataGridViewTextBoxColumn
        '
        Me.RecetarioMédicoDataGridViewTextBoxColumn.DataPropertyName = "RecetarioMédico"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.HeaderText = "RecetarioMédico"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RecetarioMédicoDataGridViewTextBoxColumn.Name = "RecetarioMédicoDataGridViewTextBoxColumn"
        Me.RecetarioMédicoDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitario.HeaderText = "PrecioUnitario"
        Me.PrecioUnitario.MinimumWidth = 8
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.Width = 150
        '
        'StockMínimo
        '
        Me.StockMínimo.DataPropertyName = "StockMínimo"
        Me.StockMínimo.HeaderText = "StockMínimo"
        Me.StockMínimo.MinimumWidth = 8
        Me.StockMínimo.Name = "StockMínimo"
        Me.StockMínimo.Width = 150
        '
        'StockMáximo
        '
        Me.StockMáximo.DataPropertyName = "StockMáximo"
        Me.StockMáximo.HeaderText = "StockMáximo"
        Me.StockMáximo.MinimumWidth = 8
        Me.StockMáximo.Name = "StockMáximo"
        Me.StockMáximo.Width = 150
        '
        'StockActual
        '
        Me.StockActual.DataPropertyName = "StockActual"
        Me.StockActual.HeaderText = "StockActual"
        Me.StockActual.MinimumWidth = 8
        Me.StockActual.Name = "StockActual"
        Me.StockActual.Width = 150
        '
        'VencimientoDataGridViewTextBoxColumn
        '
        Me.VencimientoDataGridViewTextBoxColumn.DataPropertyName = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento"
        Me.VencimientoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VencimientoDataGridViewTextBoxColumn.Name = "VencimientoDataGridViewTextBoxColumn"
        Me.VencimientoDataGridViewTextBoxColumn.Width = 150
        '
        'EdaddeConsumoDataGridViewTextBoxColumn
        '
        Me.EdaddeConsumoDataGridViewTextBoxColumn.DataPropertyName = "EdaddeConsumo"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.HeaderText = "EdaddeConsumo"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EdaddeConsumoDataGridViewTextBoxColumn.Name = "EdaddeConsumoDataGridViewTextBoxColumn"
        Me.EdaddeConsumoDataGridViewTextBoxColumn.Width = 150
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me._BD_CruzDataSet8
        '
        '_BD_CruzDataSet8
        '
        Me._BD_CruzDataSet8.DataSetName = "_BD_CruzDataSet8"
        Me._BD_CruzDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.DarkGreen
        Me.TxtBuscar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.White
        Me.TxtBuscar.Location = New System.Drawing.Point(642, 233)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(228, 44)
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
        Me.Button2.Location = New System.Drawing.Point(906, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 48)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(983, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 48)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "<-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(711, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Búsqueda por ID"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(660, 868)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(351, 57)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Guardar cambios"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ControlDeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ControlDeInventario"
        Me.Text = "ControlDeInventario"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridControlInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridControlInventario As DataGridView
    Friend WithEvents _BD_CruzDataSet8 As _BD_CruzDataSet8
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _BD_CruzDataSet8TableAdapters.ProductoTableAdapter
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents IDProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClasificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecetarioMédicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents StockMínimo As DataGridViewTextBoxColumn
    Friend WithEvents StockMáximo As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents VencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdaddeConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
