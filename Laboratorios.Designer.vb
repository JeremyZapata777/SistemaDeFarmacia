<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratorios
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laboratorios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridLaboratorios = New System.Windows.Forms.DataGridView()
        Me.IDLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NúmeroRUCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboratoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet23 = New Farmacia._BD_CruzDataSet23()
        Me.LaboratoriosTableAdapter = New Farmacia._BD_CruzDataSet23TableAdapters.LaboratoriosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 45.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(163, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1273, 110)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Información de Laboratorios"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridLaboratorios)
        Me.Panel1.Location = New System.Drawing.Point(506, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 508)
        Me.Panel1.TabIndex = 2
        '
        'DataGridLaboratorios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridLaboratorios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridLaboratorios.AutoGenerateColumns = False
        Me.DataGridLaboratorios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridLaboratorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLaboratorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDLaboratorioDataGridViewTextBoxColumn, Me.NombreDeLaboratorioDataGridViewTextBoxColumn, Me.FechaDeEntradaDataGridViewTextBoxColumn, Me.NúmeroRUCDataGridViewTextBoxColumn})
        Me.DataGridLaboratorios.DataSource = Me.LaboratoriosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridLaboratorios.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridLaboratorios.EnableHeadersVisualStyles = False
        Me.DataGridLaboratorios.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridLaboratorios.Location = New System.Drawing.Point(0, 0)
        Me.DataGridLaboratorios.Name = "DataGridLaboratorios"
        Me.DataGridLaboratorios.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridLaboratorios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridLaboratorios.RowHeadersWidth = 62
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridLaboratorios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridLaboratorios.RowTemplate.Height = 28
        Me.DataGridLaboratorios.Size = New System.Drawing.Size(742, 508)
        Me.DataGridLaboratorios.TabIndex = 0
        '
        'IDLaboratorioDataGridViewTextBoxColumn
        '
        Me.IDLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.HeaderText = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDLaboratorioDataGridViewTextBoxColumn.Name = "IDLaboratorioDataGridViewTextBoxColumn"
        Me.IDLaboratorioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDLaboratorioDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDeLaboratorioDataGridViewTextBoxColumn
        '
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "NombreDeLaboratorio"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.HeaderText = "NombreDeLaboratorio"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.Name = "NombreDeLaboratorioDataGridViewTextBoxColumn"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.Width = 150
        '
        'FechaDeEntradaDataGridViewTextBoxColumn
        '
        Me.FechaDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeEntrada"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.HeaderText = "FechaDeEntrada"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDeEntradaDataGridViewTextBoxColumn.Name = "FechaDeEntradaDataGridViewTextBoxColumn"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDeEntradaDataGridViewTextBoxColumn.Width = 150
        '
        'NúmeroRUCDataGridViewTextBoxColumn
        '
        Me.NúmeroRUCDataGridViewTextBoxColumn.DataPropertyName = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.HeaderText = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NúmeroRUCDataGridViewTextBoxColumn.Name = "NúmeroRUCDataGridViewTextBoxColumn"
        Me.NúmeroRUCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NúmeroRUCDataGridViewTextBoxColumn.Width = 150
        '
        'LaboratoriosBindingSource
        '
        Me.LaboratoriosBindingSource.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource.DataSource = Me._BD_CruzDataSet23
        '
        '_BD_CruzDataSet23
        '
        Me._BD_CruzDataSet23.DataSetName = "_BD_CruzDataSet23"
        Me._BD_CruzDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label2.Location = New System.Drawing.Point(752, 171)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(695, 229)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(193, 44)
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
        Me.Button2.Location = New System.Drawing.Point(933, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(1005, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "<-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Laboratorios
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
        Me.Name = "Laboratorios"
        Me.Text = "Laboratorios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridLaboratorios As DataGridView
    Friend WithEvents _BD_CruzDataSet23 As _BD_CruzDataSet23
    Friend WithEvents LaboratoriosBindingSource As BindingSource
    Friend WithEvents LaboratoriosTableAdapter As _BD_CruzDataSet23TableAdapters.LaboratoriosTableAdapter
    Friend WithEvents IDLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NúmeroRUCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
