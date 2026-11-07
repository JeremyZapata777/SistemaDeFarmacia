<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridPersonal = New System.Windows.Forms.DataGridView()
        Me.IDColaboradoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColaboradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet22 = New Farmacia._BD_CruzDataSet22()
        Me.ColaboradoresTableAdapter = New Farmacia._BD_CruzDataSet22TableAdapters.ColaboradoresTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 50.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(169, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1298, 122)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visualización del Personal"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 62)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridPersonal)
        Me.Panel1.Location = New System.Drawing.Point(148, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1351, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridPersonal
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridPersonal.AutoGenerateColumns = False
        Me.DataGridPersonal.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPersonal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDColaboradoresDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn})
        Me.DataGridPersonal.DataSource = Me.ColaboradoresBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridPersonal.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridPersonal.EnableHeadersVisualStyles = False
        Me.DataGridPersonal.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridPersonal.Location = New System.Drawing.Point(0, 0)
        Me.DataGridPersonal.Name = "DataGridPersonal"
        Me.DataGridPersonal.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPersonal.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridPersonal.RowHeadersWidth = 62
        Me.DataGridPersonal.RowTemplate.Height = 28
        Me.DataGridPersonal.Size = New System.Drawing.Size(1351, 508)
        Me.DataGridPersonal.TabIndex = 0
        '
        'IDColaboradoresDataGridViewTextBoxColumn
        '
        Me.IDColaboradoresDataGridViewTextBoxColumn.DataPropertyName = "IDColaboradores"
        Me.IDColaboradoresDataGridViewTextBoxColumn.HeaderText = "IDColaboradores"
        Me.IDColaboradoresDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDColaboradoresDataGridViewTextBoxColumn.Name = "IDColaboradoresDataGridViewTextBoxColumn"
        Me.IDColaboradoresDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDColaboradoresDataGridViewTextBoxColumn.Width = 150
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCompletoDataGridViewTextBoxColumn.Width = 150
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "Rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "Rol"
        Me.RolDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        Me.RolDataGridViewTextBoxColumn.ReadOnly = True
        Me.RolDataGridViewTextBoxColumn.Width = 150
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TeléfonoDataGridViewTextBoxColumn.Width = 150
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Width = 150
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContraseñaDataGridViewTextBoxColumn.Width = 150
        '
        'ColaboradoresBindingSource
        '
        Me.ColaboradoresBindingSource.DataMember = "Colaboradores"
        Me.ColaboradoresBindingSource.DataSource = Me._BD_CruzDataSet22
        '
        '_BD_CruzDataSet22
        '
        Me._BD_CruzDataSet22.DataSetName = "_BD_CruzDataSet22"
        Me._BD_CruzDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColaboradoresTableAdapter
        '
        Me.ColaboradoresTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(674, 149)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(606, 205)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(223, 44)
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
        Me.Button2.Location = New System.Drawing.Point(863, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(921, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = " <-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1652, 994)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Personal"
        Me.Text = "Personal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColaboradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridPersonal As DataGridView
    Friend WithEvents _BD_CruzDataSet22 As _BD_CruzDataSet22
    Friend WithEvents ColaboradoresBindingSource As BindingSource
    Friend WithEvents ColaboradoresTableAdapter As _BD_CruzDataSet22TableAdapters.ColaboradoresTableAdapter
    Friend WithEvents IDColaboradoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
