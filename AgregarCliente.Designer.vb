<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridCliente = New System.Windows.Forms.DataGridView()
        Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet6 = New Farmacia._BD_CruzDataSet6()
        Me.ClientesTableAdapter = New Farmacia._BD_CruzDataSet6TableAdapters.ClientesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSalir.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Location = New System.Drawing.Point(38, 48)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(173, 48)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "X"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardar.Location = New System.Drawing.Point(677, 845)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(346, 73)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar cambios"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(390, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(915, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar cliente"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridCliente)
        Me.Panel1.Location = New System.Drawing.Point(141, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridCliente
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCliente.AutoGenerateColumns = False
        Me.DataGridCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridCliente.ColumnHeadersHeight = 34
        Me.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.NombreDelClienteDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn})
        Me.DataGridCliente.DataSource = Me.ClientesBindingSource
        Me.DataGridCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridCliente.EnableHeadersVisualStyles = False
        Me.DataGridCliente.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridCliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGridCliente.Name = "DataGridCliente"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridCliente.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridCliente.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridCliente.RowTemplate.Height = 28
        Me.DataGridCliente.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridCliente.TabIndex = 0
        '
        'IDClienteDataGridViewTextBoxColumn
        '
        Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente"
        Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente"
        Me.IDClienteDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
        Me.IDClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDClienteDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDelClienteDataGridViewTextBoxColumn
        '
        Me.NombreDelClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreDelCliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn.HeaderText = "NombreDelCliente"
        Me.NombreDelClienteDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDelClienteDataGridViewTextBoxColumn.Name = "NombreDelClienteDataGridViewTextBoxColumn"
        Me.NombreDelClienteDataGridViewTextBoxColumn.Width = 150
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.Width = 150
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.Width = 150
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        Me.DirecciónDataGridViewTextBoxColumn.Width = 150
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me._BD_CruzDataSet6
        '
        '_BD_CruzDataSet6
        '
        Me._BD_CruzDataSet6.DataSetName = "_BD_CruzDataSet6"
        Me._BD_CruzDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(737, 173)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(660, 229)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(228, 44)
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
        Me.Button1.Location = New System.Drawing.Point(951, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1015, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 48)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "<-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AgregarCliente
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
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSalir)
        Me.DoubleBuffered = True
        Me.Name = "AgregarCliente"
        Me.Text = "AgregarCliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridCliente As DataGridView
    Friend WithEvents _BD_CruzDataSet6 As _BD_CruzDataSet6
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _BD_CruzDataSet6TableAdapters.ClientesTableAdapter
    Friend WithEvents IDClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
