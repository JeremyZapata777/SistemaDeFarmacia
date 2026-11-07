<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroProveedores))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridRegistroProveedor = New System.Windows.Forms.DataGridView()
        Me.IDProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombredelProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NúmeroRUCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet15 = New Farmacia._BD_CruzDataSet15()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet10 = New Farmacia._BD_CruzDataSet10()
        Me.ProveedoresTableAdapter = New Farmacia._BD_CruzDataSet10TableAdapters.ProveedoresTableAdapter()
        Me._BD_CruzDataSet14 = New Farmacia._BD_CruzDataSet14()
        Me.ColaboradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColaboradoresTableAdapter = New Farmacia._BD_CruzDataSet14TableAdapters.ColaboradoresTableAdapter()
        Me.ProveedoresTableAdapter1 = New Farmacia._BD_CruzDataSet15TableAdapters.ProveedoresTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridRegistroProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(29, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 50.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(239, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1191, 122)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de Proveedores"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(656, 804)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(301, 66)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridRegistroProveedor)
        Me.Panel1.Location = New System.Drawing.Point(140, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridRegistroProveedor
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridRegistroProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistroProveedor.AutoGenerateColumns = False
        Me.DataGridRegistroProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridRegistroProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistroProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistroProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRegistroProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProveedorDataGridViewTextBoxColumn, Me.IDLaboratorioDataGridViewTextBoxColumn, Me.NombredelProveedorDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.NúmeroRUCDataGridViewTextBoxColumn})
        Me.DataGridRegistroProveedor.DataSource = Me.ProveedoresBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistroProveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRegistroProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridRegistroProveedor.EnableHeadersVisualStyles = False
        Me.DataGridRegistroProveedor.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridRegistroProveedor.Location = New System.Drawing.Point(0, 0)
        Me.DataGridRegistroProveedor.Name = "DataGridRegistroProveedor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistroProveedor.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRegistroProveedor.RowHeadersWidth = 62
        Me.DataGridRegistroProveedor.RowTemplate.Height = 28
        Me.DataGridRegistroProveedor.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridRegistroProveedor.TabIndex = 0
        '
        'IDProveedorDataGridViewTextBoxColumn
        '
        Me.IDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.HeaderText = "IDProveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDProveedorDataGridViewTextBoxColumn.Name = "IDProveedorDataGridViewTextBoxColumn"
        Me.IDProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProveedorDataGridViewTextBoxColumn.Width = 150
        '
        'IDLaboratorioDataGridViewTextBoxColumn
        '
        Me.IDLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.HeaderText = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDLaboratorioDataGridViewTextBoxColumn.Name = "IDLaboratorioDataGridViewTextBoxColumn"
        Me.IDLaboratorioDataGridViewTextBoxColumn.Width = 150
        '
        'NombredelProveedorDataGridViewTextBoxColumn
        '
        Me.NombredelProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombredelProveedor"
        Me.NombredelProveedorDataGridViewTextBoxColumn.HeaderText = "NombredelProveedor"
        Me.NombredelProveedorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombredelProveedorDataGridViewTextBoxColumn.Name = "NombredelProveedorDataGridViewTextBoxColumn"
        Me.NombredelProveedorDataGridViewTextBoxColumn.Width = 150
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.Width = 150
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        Me.DirecciónDataGridViewTextBoxColumn.Width = 150
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
        '
        'NúmeroRUCDataGridViewTextBoxColumn
        '
        Me.NúmeroRUCDataGridViewTextBoxColumn.DataPropertyName = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.HeaderText = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NúmeroRUCDataGridViewTextBoxColumn.Name = "NúmeroRUCDataGridViewTextBoxColumn"
        Me.NúmeroRUCDataGridViewTextBoxColumn.Width = 150
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "Proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me._BD_CruzDataSet15
        '
        '_BD_CruzDataSet15
        '
        Me._BD_CruzDataSet15.DataSetName = "_BD_CruzDataSet15"
        Me._BD_CruzDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me._BD_CruzDataSet10
        '
        '_BD_CruzDataSet10
        '
        Me._BD_CruzDataSet10.DataSetName = "_BD_CruzDataSet10"
        Me._BD_CruzDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        '_BD_CruzDataSet14
        '
        Me._BD_CruzDataSet14.DataSetName = "_BD_CruzDataSet14"
        Me._BD_CruzDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColaboradoresBindingSource
        '
        Me.ColaboradoresBindingSource.DataMember = "Colaboradores"
        Me.ColaboradoresBindingSource.DataSource = Me._BD_CruzDataSet14
        '
        'ColaboradoresTableAdapter
        '
        Me.ColaboradoresTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter1
        '
        Me.ProveedoresTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(732, 147)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(686, 198)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(193, 44)
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
        Me.Button3.Location = New System.Drawing.Point(935, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 46)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(1002, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 46)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RegistroProveedores
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
        Me.Name = "RegistroProveedores"
        Me.Text = "RegistroProveedores"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridRegistroProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _BD_CruzDataSet10 As _BD_CruzDataSet10
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As _BD_CruzDataSet10TableAdapters.ProveedoresTableAdapter
    Friend WithEvents _BD_CruzDataSet14 As _BD_CruzDataSet14
    Friend WithEvents ColaboradoresBindingSource As BindingSource
    Friend WithEvents ColaboradoresTableAdapter As _BD_CruzDataSet14TableAdapters.ColaboradoresTableAdapter
    Friend WithEvents DataGridRegistroProveedor As DataGridView
    Friend WithEvents _BD_CruzDataSet15 As _BD_CruzDataSet15
    Friend WithEvents ProveedoresBindingSource1 As BindingSource
    Friend WithEvents ProveedoresTableAdapter1 As _BD_CruzDataSet15TableAdapters.ProveedoresTableAdapter
    Friend WithEvents IDProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombredelProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NúmeroRUCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
