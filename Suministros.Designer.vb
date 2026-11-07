<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suministros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suministros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridSuministros = New System.Windows.Forms.DataGridView()
        Me.ProductosSuministrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet24 = New Farmacia._BD_CruzDataSet24()
        Me.ProductosSuministrosTableAdapter = New Farmacia._BD_CruzDataSet24TableAdapters.ProductosSuministrosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IDProductoSuministroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClasificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMínimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMáximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridSuministros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosSuministrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 50.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(243, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1121, 122)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visualizar Suministros"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridSuministros)
        Me.Panel1.Location = New System.Drawing.Point(148, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridSuministros
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridSuministros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSuministros.AutoGenerateColumns = False
        Me.DataGridSuministros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSuministros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSuministros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoSuministroDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.StockActual, Me.StockMínimo, Me.StockMáximo})
        Me.DataGridSuministros.DataSource = Me.ProductosSuministrosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridSuministros.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridSuministros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSuministros.EnableHeadersVisualStyles = False
        Me.DataGridSuministros.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridSuministros.Location = New System.Drawing.Point(0, 0)
        Me.DataGridSuministros.Name = "DataGridSuministros"
        Me.DataGridSuministros.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSuministros.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridSuministros.RowHeadersWidth = 62
        Me.DataGridSuministros.RowTemplate.Height = 28
        Me.DataGridSuministros.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridSuministros.TabIndex = 0
        '
        'ProductosSuministrosBindingSource
        '
        Me.ProductosSuministrosBindingSource.DataMember = "ProductosSuministros"
        Me.ProductosSuministrosBindingSource.DataSource = Me._BD_CruzDataSet24
        '
        '_BD_CruzDataSet24
        '
        Me._BD_CruzDataSet24.DataSetName = "_BD_CruzDataSet24"
        Me._BD_CruzDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosSuministrosTableAdapter
        '
        Me.ProductosSuministrosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(709, 177)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(647, 233)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(199, 44)
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
        Me.Button2.Location = New System.Drawing.Point(895, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(967, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "<-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'IDProductoSuministroDataGridViewTextBoxColumn
        '
        Me.IDProductoSuministroDataGridViewTextBoxColumn.DataPropertyName = "IDProductoSuministro"
        Me.IDProductoSuministroDataGridViewTextBoxColumn.HeaderText = "IDProductoSuministro"
        Me.IDProductoSuministroDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDProductoSuministroDataGridViewTextBoxColumn.Name = "IDProductoSuministroDataGridViewTextBoxColumn"
        Me.IDProductoSuministroDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProductoSuministroDataGridViewTextBoxColumn.Width = 150
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
        'IDClasificaciónDataGridViewTextBoxColumn
        '
        Me.IDClasificaciónDataGridViewTextBoxColumn.DataPropertyName = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.HeaderText = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDClasificaciónDataGridViewTextBoxColumn.Name = "IDClasificaciónDataGridViewTextBoxColumn"
        Me.IDClasificaciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDClasificaciónDataGridViewTextBoxColumn.Width = 150
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
        'StockActual
        '
        Me.StockActual.DataPropertyName = "StockActual"
        Me.StockActual.HeaderText = "StockActual"
        Me.StockActual.MinimumWidth = 8
        Me.StockActual.Name = "StockActual"
        Me.StockActual.ReadOnly = True
        Me.StockActual.Width = 150
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
        'Suministros
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
        Me.Name = "Suministros"
        Me.Text = "Suministros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridSuministros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosSuministrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridSuministros As DataGridView
    Friend WithEvents _BD_CruzDataSet24 As _BD_CruzDataSet24
    Friend WithEvents ProductosSuministrosBindingSource As BindingSource
    Friend WithEvents ProductosSuministrosTableAdapter As _BD_CruzDataSet24TableAdapters.ProductosSuministrosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents IDProductoSuministroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClasificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents StockMínimo As DataGridViewTextBoxColumn
    Friend WithEvents StockMáximo As DataGridViewTextBoxColumn
End Class
