<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroClientes))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridRegistroClientes = New System.Windows.Forms.DataGridView()
        Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet11 = New Farmacia._BD_CruzDataSet11()
        Me.ClientesTableAdapter = New Farmacia._BD_CruzDataSet11TableAdapters.ClientesTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridRegistroClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(41, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 68)
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
        Me.Label1.Location = New System.Drawing.Point(250, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1169, 146)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de clientes"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridRegistroClientes)
        Me.Panel1.Location = New System.Drawing.Point(144, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridRegistroClientes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridRegistroClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistroClientes.AutoGenerateColumns = False
        Me.DataGridRegistroClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridRegistroClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistroClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRegistroClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.NombreDelClienteDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn})
        Me.DataGridRegistroClientes.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistroClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridRegistroClientes.EnableHeadersVisualStyles = False
        Me.DataGridRegistroClientes.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridRegistroClientes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridRegistroClientes.Name = "DataGridRegistroClientes"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistroClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRegistroClientes.RowHeadersWidth = 62
        Me.DataGridRegistroClientes.RowTemplate.Height = 28
        Me.DataGridRegistroClientes.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridRegistroClientes.TabIndex = 0
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
        Me.ClientesBindingSource.DataSource = Me._BD_CruzDataSet11
        '
        '_BD_CruzDataSet11
        '
        Me._BD_CruzDataSet11.DataSetName = "_BD_CruzDataSet11"
        Me._BD_CruzDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(679, 853)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 68)
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
        Me.Label2.Location = New System.Drawing.Point(701, 168)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(655, 218)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(195, 44)
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
        Me.Button3.Location = New System.Drawing.Point(894, 218)
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
        Me.Button4.Location = New System.Drawing.Point(953, 218)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 44)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RegistroClientes
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
        Me.Name = "RegistroClientes"
        Me.Text = "RegistroClientes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridRegistroClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridRegistroClientes As DataGridView
    Friend WithEvents _BD_CruzDataSet11 As _BD_CruzDataSet11
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _BD_CruzDataSet11TableAdapters.ClientesTableAdapter
    Friend WithEvents IDClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
