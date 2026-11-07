<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlLaboratorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlLaboratorios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridControlLaboratorios = New System.Windows.Forms.DataGridView()
        Me.IDLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NúmeroRUCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboratoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._BD_CruzDataSet20 = New Farmacia._BD_CruzDataSet20()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LaboratoriosTableAdapter = New Farmacia._BD_CruzDataSet20TableAdapters.LaboratoriosTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridControlLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._BD_CruzDataSet20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 55.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(131, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1298, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de Laboratorios"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridControlLaboratorios)
        Me.Panel1.Location = New System.Drawing.Point(502, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 508)
        Me.Panel1.TabIndex = 1
        '
        'DataGridControlLaboratorios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridControlLaboratorios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridControlLaboratorios.AutoGenerateColumns = False
        Me.DataGridControlLaboratorios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridControlLaboratorios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlLaboratorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridControlLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridControlLaboratorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDLaboratorioDataGridViewTextBoxColumn, Me.NombreDeLaboratorioDataGridViewTextBoxColumn, Me.FechaDeEntradaDataGridViewTextBoxColumn, Me.NúmeroRUCDataGridViewTextBoxColumn})
        Me.DataGridControlLaboratorios.DataSource = Me.LaboratoriosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridControlLaboratorios.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridControlLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridControlLaboratorios.EnableHeadersVisualStyles = False
        Me.DataGridControlLaboratorios.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridControlLaboratorios.Location = New System.Drawing.Point(0, 0)
        Me.DataGridControlLaboratorios.Name = "DataGridControlLaboratorios"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Constantia", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridControlLaboratorios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridControlLaboratorios.RowHeadersWidth = 62
        Me.DataGridControlLaboratorios.RowTemplate.Height = 28
        Me.DataGridControlLaboratorios.Size = New System.Drawing.Size(686, 508)
        Me.DataGridControlLaboratorios.TabIndex = 0
        '
        'IDLaboratorioDataGridViewTextBoxColumn
        '
        Me.IDLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.HeaderText = "IDLaboratorio"
        Me.IDLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDLaboratorioDataGridViewTextBoxColumn.Name = "IDLaboratorioDataGridViewTextBoxColumn"
        Me.IDLaboratorioDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDeLaboratorioDataGridViewTextBoxColumn
        '
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "NombreDeLaboratorio"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.HeaderText = "NombreDeLaboratorio"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.Name = "NombreDeLaboratorioDataGridViewTextBoxColumn"
        Me.NombreDeLaboratorioDataGridViewTextBoxColumn.Width = 150
        '
        'FechaDeEntradaDataGridViewTextBoxColumn
        '
        Me.FechaDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeEntrada"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.HeaderText = "FechaDeEntrada"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDeEntradaDataGridViewTextBoxColumn.Name = "FechaDeEntradaDataGridViewTextBoxColumn"
        Me.FechaDeEntradaDataGridViewTextBoxColumn.Width = 150
        '
        'NúmeroRUCDataGridViewTextBoxColumn
        '
        Me.NúmeroRUCDataGridViewTextBoxColumn.DataPropertyName = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.HeaderText = "NúmeroRUC"
        Me.NúmeroRUCDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NúmeroRUCDataGridViewTextBoxColumn.Name = "NúmeroRUCDataGridViewTextBoxColumn"
        Me.NúmeroRUCDataGridViewTextBoxColumn.Width = 150
        '
        'LaboratoriosBindingSource
        '
        Me.LaboratoriosBindingSource.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource.DataSource = Me._BD_CruzDataSet20
        '
        '_BD_CruzDataSet20
        '
        Me._BD_CruzDataSet20.DataSetName = "_BD_CruzDataSet20"
        Me._BD_CruzDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(721, 805)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(290, 77)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Label2.Location = New System.Drawing.Point(729, 151)
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
        Me.TxtBuscar.Location = New System.Drawing.Point(665, 203)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(184, 44)
        Me.TxtBuscar.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(922, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGreen
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(1000, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 44)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "<-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ControlLaboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1674, 1050)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ControlLaboratorios"
        Me.Text = "ControlLaboratorios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridControlLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._BD_CruzDataSet20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridControlLaboratorios As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents _BD_CruzDataSet20 As _BD_CruzDataSet20
    Friend WithEvents LaboratoriosBindingSource As BindingSource
    Friend WithEvents LaboratoriosTableAdapter As _BD_CruzDataSet20TableAdapters.LaboratoriosTableAdapter
    Friend WithEvents IDLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeLaboratorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NúmeroRUCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
