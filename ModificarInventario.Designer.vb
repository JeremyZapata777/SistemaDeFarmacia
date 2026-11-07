<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarInventario))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelmInventario = New System.Windows.Forms.Panel()
        Me.DataGridModificarInventario = New System.Windows.Forms.DataGridView()
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
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet7 = New Farmacia._BD_CruzDataSet7()
        Me.ProductoTableAdapter = New Farmacia._BD_CruzDataSet7TableAdapters.ProductoTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PanelmInventario.SuspendLayout()
        CType(Me.DataGridModificarInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(21, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 62)
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
        Me.Label1.Location = New System.Drawing.Point(196, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1236, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modificar Inventario"
        '
        'PanelmInventario
        '
        Me.PanelmInventario.AutoScroll = True
        Me.PanelmInventario.Controls.Add(Me.DataGridModificarInventario)
        Me.PanelmInventario.Location = New System.Drawing.Point(149, 278)
        Me.PanelmInventario.Name = "PanelmInventario"
        Me.PanelmInventario.Size = New System.Drawing.Size(1351, 508)
        Me.PanelmInventario.TabIndex = 2
        '
        'DataGridModificarInventario
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridModificarInventario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridModificarInventario.AutoGenerateColumns = False
        Me.DataGridModificarInventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridModificarInventario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridModificarInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridModificarInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PresentaciónDataGridViewTextBoxColumn, Me.UsoDataGridViewTextBoxColumn, Me.RecetarioMédicoDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.StockMínimoDataGridViewTextBoxColumn, Me.StockMáximoDataGridViewTextBoxColumn, Me.StockActualDataGridViewTextBoxColumn, Me.VencimientoDataGridViewTextBoxColumn, Me.EdaddeConsumoDataGridViewTextBoxColumn})
        Me.DataGridModificarInventario.DataSource = Me.ProductoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridModificarInventario.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridModificarInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridModificarInventario.EnableHeadersVisualStyles = False
        Me.DataGridModificarInventario.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridModificarInventario.Location = New System.Drawing.Point(0, 0)
        Me.DataGridModificarInventario.Name = "DataGridModificarInventario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridModificarInventario.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridModificarInventario.RowHeadersWidth = 62
        Me.DataGridModificarInventario.RowTemplate.Height = 28
        Me.DataGridModificarInventario.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridModificarInventario.TabIndex = 0
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
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 150
        '
        'StockMínimoDataGridViewTextBoxColumn
        '
        Me.StockMínimoDataGridViewTextBoxColumn.DataPropertyName = "StockMínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.HeaderText = "StockMínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockMínimoDataGridViewTextBoxColumn.Name = "StockMínimoDataGridViewTextBoxColumn"
        Me.StockMínimoDataGridViewTextBoxColumn.Width = 150
        '
        'StockMáximoDataGridViewTextBoxColumn
        '
        Me.StockMáximoDataGridViewTextBoxColumn.DataPropertyName = "StockMáximo"
        Me.StockMáximoDataGridViewTextBoxColumn.HeaderText = "StockMáximo"
        Me.StockMáximoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockMáximoDataGridViewTextBoxColumn.Name = "StockMáximoDataGridViewTextBoxColumn"
        Me.StockMáximoDataGridViewTextBoxColumn.Width = 150
        '
        'StockActualDataGridViewTextBoxColumn
        '
        Me.StockActualDataGridViewTextBoxColumn.DataPropertyName = "StockActual"
        Me.StockActualDataGridViewTextBoxColumn.HeaderText = "StockActual"
        Me.StockActualDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StockActualDataGridViewTextBoxColumn.Name = "StockActualDataGridViewTextBoxColumn"
        Me.StockActualDataGridViewTextBoxColumn.Width = 150
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
        Me.ProductoBindingSource.DataSource = Me._BD_CruzDataSet7
        '
        '_BD_CruzDataSet7
        '
        Me._BD_CruzDataSet7.DataSetName = "_BD_CruzDataSet7"
        Me._BD_CruzDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(682, 828)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(353, 85)
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
        Me.Label2.Location = New System.Drawing.Point(739, 157)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(682, 214)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(223, 44)
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
        Me.Button3.Location = New System.Drawing.Point(941, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(1000, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 44)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ModificarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.PanelmInventario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ModificarInventario"
        Me.Text = "ModificarInventario"
        Me.PanelmInventario.ResumeLayout(False)
        CType(Me.DataGridModificarInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelmInventario As Panel
    Friend WithEvents DataGridModificarInventario As DataGridView
    Friend WithEvents _BD_CruzDataSet7 As _BD_CruzDataSet7
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _BD_CruzDataSet7TableAdapters.ProductoTableAdapter
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
