<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.ChkContraseña = New System.Windows.Forms.CheckBox()
        Me.BtnRealizar = New System.Windows.Forms.Button()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.ChkCorreo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(156, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1586, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresa tu correo de usuario y contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(711, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(536, 73)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Correo de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(802, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 73)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtContraseña.Font = New System.Drawing.Font("Constantia", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña.Location = New System.Drawing.Point(675, 647)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtContraseña.Size = New System.Drawing.Size(585, 69)
        Me.TxtContraseña.TabIndex = 4
        Me.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkContraseña
        '
        Me.ChkContraseña.AutoSize = True
        Me.ChkContraseña.BackColor = System.Drawing.Color.Transparent
        Me.ChkContraseña.Location = New System.Drawing.Point(1279, 676)
        Me.ChkContraseña.Name = "ChkContraseña"
        Me.ChkContraseña.Size = New System.Drawing.Size(22, 21)
        Me.ChkContraseña.TabIndex = 2
        Me.ChkContraseña.UseVisualStyleBackColor = False
        '
        'BtnRealizar
        '
        Me.BtnRealizar.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnRealizar.Font = New System.Drawing.Font("Constantia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRealizar.Location = New System.Drawing.Point(572, 758)
        Me.BtnRealizar.Name = "BtnRealizar"
        Me.BtnRealizar.Size = New System.Drawing.Size(792, 140)
        Me.BtnRealizar.TabIndex = 5
        Me.BtnRealizar.Text = "Realizar operaciones"
        Me.BtnRealizar.UseVisualStyleBackColor = False
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtCorreo.Font = New System.Drawing.Font("Constantia", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtCorreo.Location = New System.Drawing.Point(675, 428)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtCorreo.Size = New System.Drawing.Size(585, 69)
        Me.TxtCorreo.TabIndex = 4
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkCorreo
        '
        Me.ChkCorreo.AutoSize = True
        Me.ChkCorreo.BackColor = System.Drawing.Color.Transparent
        Me.ChkCorreo.Location = New System.Drawing.Point(1279, 457)
        Me.ChkCorreo.Name = "ChkCorreo"
        Me.ChkCorreo.Size = New System.Drawing.Size(22, 21)
        Me.ChkCorreo.TabIndex = 2
        Me.ChkCorreo.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.BtnRealizar)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.ChkCorreo)
        Me.Controls.Add(Me.ChkContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents ChkContraseña As CheckBox
    Friend WithEvents BtnRealizar As Button
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents ChkCorreo As CheckBox
End Class
