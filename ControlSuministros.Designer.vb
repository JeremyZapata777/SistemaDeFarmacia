<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSuministros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlSuministros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridControlSuministros = New System.Windows.Forms.DataGridView()
        Me.ProductosSuministrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet21 = New Farmacia._BD_CruzDataSet21()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductosSuministrosTableAdapter = New Farmacia._BD_CruzDataSet21TableAdapters.ProductosSuministrosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IDProductoSuministroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClasificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMínimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMáximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridControlSuministros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosSuministrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(118, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1375, 146)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de Suministros"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridControlSuministros)
        Me.Panel1.Location = New System.Drawing.Point(143, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridControlSuministros
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridControlSuministros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridControlSuministros.AutoGenerateColumns = False
        Me.DataGridControlSuministros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridControlSuministros.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlSuministros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridControlSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridControlSuministros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProductoSuministroDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IDClasificaciónDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.StockActual, Me.StockMínimo, Me.StockMáximo})
        Me.DataGridControlSuministros.DataSource = Me.ProductosSuministrosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridControlSuministros.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridControlSuministros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridControlSuministros.EnableHeadersVisualStyles = False
        Me.DataGridControlSuministros.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridControlSuministros.Location = New System.Drawing.Point(0, 0)
        Me.DataGridControlSuministros.Name = "DataGridControlSuministros"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlSuministros.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridControlSuministros.RowHeadersWidth = 62
        Me.DataGridControlSuministros.RowTemplate.Height = 28
        Me.DataGridControlSuministros.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridControlSuministros.TabIndex = 0
        '
        'ProductosSuministrosBindingSource
        '
        Me.ProductosSuministrosBindingSource.DataMember = "ProductosSuministros"
        Me.ProductosSuministrosBindingSource.DataSource = Me._BD_CruzDataSet21
        '
        '_BD_CruzDataSet21
        '
        Me._BD_CruzDataSet21.DataSetName = "_BD_CruzDataSet21"
        Me._BD_CruzDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(725, 827)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 76)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Label2.Location = New System.Drawing.Point(733, 158)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(682, 221)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(185, 44)
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
        Me.Button3.Location = New System.Drawing.Point(920, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(979, 220)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 44)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'IDClasificaciónDataGridViewTextBoxColumn
        '
        Me.IDClasificaciónDataGridViewTextBoxColumn.DataPropertyName = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.HeaderText = "IDClasificación"
        Me.IDClasificaciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDClasificaciónDataGridViewTextBoxColumn.Name = "IDClasificaciónDataGridViewTextBoxColumn"
        Me.IDClasificaciónDataGridViewTextBoxColumn.Width = 150
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 150
        '
        'StockActual
        '
        Me.StockActual.DataPropertyName = "StockActual"
        Me.StockActual.HeaderText = "StockActual"
        Me.StockActual.MinimumWidth = 8
        Me.StockActual.Name = "StockActual"
        Me.StockActual.Width = 150
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
        'ControlSuministros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ControlSuministros"
        Me.Text = "ControlSuministros"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridControlSuministros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosSuministrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridControlSuministros As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents _BD_CruzDataSet21 As _BD_CruzDataSet21
    Friend WithEvents ProductosSuministrosBindingSource As BindingSource
    Friend WithEvents ProductosSuministrosTableAdapter As _BD_CruzDataSet21TableAdapters.ProductosSuministrosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents IDProductoSuministroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClasificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockActual As DataGridViewTextBoxColumn
    Friend WithEvents StockMínimo As DataGridViewTextBoxColumn
    Friend WithEvents StockMáximo As DataGridViewTextBoxColumn
End Class
