<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlCompras))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridControlCompras = New System.Windows.Forms.DataGridView()
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
        Me.ComprasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet33 = New Farmacia._BD_CruzDataSet33()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet12 = New Farmacia._BD_CruzDataSet12()
        Me.ComprasTableAdapter = New Farmacia._BD_CruzDataSet12TableAdapters.ComprasTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me._BD_CruzDataSet32 = New Farmacia._BD_CruzDataSet32()
        Me.ComprasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter1 = New Farmacia._BD_CruzDataSet32TableAdapters.ComprasTableAdapter()
        Me.ComprasTableAdapter2 = New Farmacia._BD_CruzDataSet33TableAdapters.ComprasTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridControlCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(44, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 56)
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
        Me.Label1.Location = New System.Drawing.Point(225, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1168, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de compras"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridControlCompras)
        Me.Panel1.Location = New System.Drawing.Point(146, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridControlCompras
        '
        Me.DataGridControlCompras.AutoGenerateColumns = False
        Me.DataGridControlCompras.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridControlCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridControlCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridControlCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCompras, Me.IDColaboradores, Me.IDProveedor, Me.IDProducto, Me.IDProductoSuministro, Me.DetalledeCompra, Me.Cantidad, Me.PrecioUnitario, Me.Total, Me.FechaCompra})
        Me.DataGridControlCompras.DataSource = Me.ComprasBindingSource2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridControlCompras.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridControlCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridControlCompras.EnableHeadersVisualStyles = False
        Me.DataGridControlCompras.GridColor = System.Drawing.Color.White
        Me.DataGridControlCompras.Location = New System.Drawing.Point(0, 0)
        Me.DataGridControlCompras.Name = "DataGridControlCompras"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridControlCompras.RowHeadersWidth = 62
        Me.DataGridControlCompras.RowTemplate.Height = 28
        Me.DataGridControlCompras.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridControlCompras.TabIndex = 0
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
        'ComprasBindingSource2
        '
        Me.ComprasBindingSource2.DataMember = "Compras"
        Me.ComprasBindingSource2.DataSource = Me._BD_CruzDataSet33
        '
        '_BD_CruzDataSet33
        '
        Me._BD_CruzDataSet33.DataSetName = "_BD_CruzDataSet33"
        Me._BD_CruzDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me._BD_CruzDataSet12
        '
        '_BD_CruzDataSet12
        '
        Me._BD_CruzDataSet12.DataSetName = "_BD_CruzDataSet12"
        Me._BD_CruzDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(689, 821)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 77)
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
        Me.Label2.Location = New System.Drawing.Point(735, 176)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(664, 227)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(198, 44)
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
        Me.Button3.Location = New System.Drawing.Point(927, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 56)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(996, 220)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(63, 56)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        '_BD_CruzDataSet32
        '
        Me._BD_CruzDataSet32.DataSetName = "_BD_CruzDataSet32"
        Me._BD_CruzDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource1
        '
        Me.ComprasBindingSource1.DataMember = "Compras"
        Me.ComprasBindingSource1.DataSource = Me._BD_CruzDataSet32
        '
        'ComprasTableAdapter1
        '
        Me.ComprasTableAdapter1.ClearBeforeFill = True
        '
        'ComprasTableAdapter2
        '
        Me.ComprasTableAdapter2.ClearBeforeFill = True
        '
        'ControlCompras
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
        Me.Name = "ControlCompras"
        Me.Text = "ControlCompras"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridControlCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _BD_CruzDataSet12 As _BD_CruzDataSet12
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As _BD_CruzDataSet12TableAdapters.ComprasTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents _BD_CruzDataSet32 As _BD_CruzDataSet32
    Friend WithEvents ComprasBindingSource1 As BindingSource
    Friend WithEvents ComprasTableAdapter1 As _BD_CruzDataSet32TableAdapters.ComprasTableAdapter
    Friend WithEvents DataGridControlCompras As DataGridView
    Friend WithEvents _BD_CruzDataSet33 As _BD_CruzDataSet33
    Friend WithEvents ComprasBindingSource2 As BindingSource
    Friend WithEvents ComprasTableAdapter2 As _BD_CruzDataSet33TableAdapters.ComprasTableAdapter
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
