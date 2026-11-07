<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDelPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroDelPersonal))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridRegistro = New System.Windows.Forms.DataGridView()
        Me.IDColaboradoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColaboradoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet16 = New Farmacia._BD_CruzDataSet16()
        Me.ColaboradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet9 = New Farmacia._BD_CruzDataSet9()
        Me.ColaboradoresTableAdapter = New Farmacia._BD_CruzDataSet9TableAdapters.ColaboradoresTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColaboradoresTableAdapter1 = New Farmacia._BD_CruzDataSet16TableAdapters.ColaboradoresTableAdapter()
        Me._BD_CruzDataSet17 = New Farmacia._BD_CruzDataSet17()
        Me.LaboratoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriosTableAdapter = New Farmacia._BD_CruzDataSet17TableAdapters.LaboratoriosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColaboradoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 67)
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
        Me.Label1.Location = New System.Drawing.Point(250, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1151, 122)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personal de la farmacia"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridRegistro)
        Me.Panel1.Location = New System.Drawing.Point(152, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridRegistro
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridRegistro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistro.AutoGenerateColumns = False
        Me.DataGridRegistro.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRegistro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDColaboradoresDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn})
        Me.DataGridRegistro.DataSource = Me.ColaboradoresBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistro.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridRegistro.EnableHeadersVisualStyles = False
        Me.DataGridRegistro.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridRegistro.Location = New System.Drawing.Point(0, 0)
        Me.DataGridRegistro.Name = "DataGridRegistro"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistro.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRegistro.RowHeadersWidth = 62
        Me.DataGridRegistro.RowTemplate.Height = 28
        Me.DataGridRegistro.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridRegistro.TabIndex = 0
        '
        'IDColaboradoresDataGridViewTextBoxColumn
        '
        Me.IDColaboradoresDataGridViewTextBoxColumn.DataPropertyName = "IDColaboradores"
        Me.IDColaboradoresDataGridViewTextBoxColumn.HeaderText = "IDColaboradores"
        Me.IDColaboradoresDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDColaboradoresDataGridViewTextBoxColumn.Name = "IDColaboradoresDataGridViewTextBoxColumn"
        Me.IDColaboradoresDataGridViewTextBoxColumn.Width = 150
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 150
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "Rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "Rol"
        Me.RolDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        Me.RolDataGridViewTextBoxColumn.Width = 150
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
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.Width = 150
        '
        'ColaboradoresBindingSource1
        '
        Me.ColaboradoresBindingSource1.DataMember = "Colaboradores"
        Me.ColaboradoresBindingSource1.DataSource = Me._BD_CruzDataSet16
        '
        '_BD_CruzDataSet16
        '
        Me._BD_CruzDataSet16.DataSetName = "_BD_CruzDataSet16"
        Me._BD_CruzDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColaboradoresBindingSource
        '
        Me.ColaboradoresBindingSource.DataMember = "Colaboradores"
        Me.ColaboradoresBindingSource.DataSource = Me._BD_CruzDataSet9
        '
        '_BD_CruzDataSet9
        '
        Me._BD_CruzDataSet9.DataSetName = "_BD_CruzDataSet9"
        Me._BD_CruzDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColaboradoresTableAdapter
        '
        Me.ColaboradoresTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(695, 785)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 78)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ColaboradoresTableAdapter1
        '
        Me.ColaboradoresTableAdapter1.ClearBeforeFill = True
        '
        '_BD_CruzDataSet17
        '
        Me._BD_CruzDataSet17.DataSetName = "_BD_CruzDataSet17"
        Me._BD_CruzDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LaboratoriosBindingSource
        '
        Me.LaboratoriosBindingSource.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource.DataSource = Me._BD_CruzDataSet17
        '
        'LaboratoriosTableAdapter
        '
        Me.LaboratoriosTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(736, 138)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(653, 190)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(205, 44)
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
        Me.Button3.Location = New System.Drawing.Point(931, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(1008, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 44)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RegistroDelPersonal
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
        Me.Name = "RegistroDelPersonal"
        Me.Text = "RegistroDelPersonal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColaboradoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _BD_CruzDataSet9 As _BD_CruzDataSet9
    Friend WithEvents ColaboradoresBindingSource As BindingSource
    Friend WithEvents ColaboradoresTableAdapter As _BD_CruzDataSet9TableAdapters.ColaboradoresTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridRegistro As DataGridView
    Friend WithEvents _BD_CruzDataSet16 As _BD_CruzDataSet16
    Friend WithEvents ColaboradoresBindingSource1 As BindingSource
    Friend WithEvents ColaboradoresTableAdapter1 As _BD_CruzDataSet16TableAdapters.ColaboradoresTableAdapter
    Friend WithEvents IDColaboradoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents _BD_CruzDataSet17 As _BD_CruzDataSet17
    Friend WithEvents LaboratoriosBindingSource As BindingSource
    Friend WithEvents LaboratoriosTableAdapter As _BD_CruzDataSet17TableAdapters.LaboratoriosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
