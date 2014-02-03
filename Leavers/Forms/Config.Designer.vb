<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.cmdSave = New System.Windows.Forms.Button
        Me.lblIP = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.lblHomdirs = New System.Windows.Forms.Label
        Me.lblProfile = New System.Windows.Forms.Label
        Me.lblAppdataTerminal = New System.Windows.Forms.Label
        Me.lblAppdataWorkstation = New System.Windows.Forms.Label
        Me.lblAppdataLaptop = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtHomedirs = New System.Windows.Forms.TextBox
        Me.txtProfile = New System.Windows.Forms.TextBox
        Me.txtAppdataTerminal = New System.Windows.Forms.TextBox
        Me.txtAppdataWorkstation = New System.Windows.Forms.TextBox
        Me.txtAppdataLaptop = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdDefault = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(74, 253)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(12, 19)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(58, 16)
        Me.lblIP.TabIndex = 1
        Me.lblIP.Text = "LDAP IP"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(12, 47)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(73, 16)
        Me.lblPath.TabIndex = 2
        Me.lblPath.Text = "LDAP Path"
        '
        'lblHomdirs
        '
        Me.lblHomdirs.AutoSize = True
        Me.lblHomdirs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomdirs.Location = New System.Drawing.Point(12, 103)
        Me.lblHomdirs.Name = "lblHomdirs"
        Me.lblHomdirs.Size = New System.Drawing.Size(89, 16)
        Me.lblHomdirs.TabIndex = 3
        Me.lblHomdirs.Text = "Homdirs Path"
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(12, 132)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(76, 16)
        Me.lblProfile.TabIndex = 4
        Me.lblProfile.Text = "Profile Path"
        '
        'lblAppdataTerminal
        '
        Me.lblAppdataTerminal.AutoSize = True
        Me.lblAppdataTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppdataTerminal.Location = New System.Drawing.Point(12, 158)
        Me.lblAppdataTerminal.Name = "lblAppdataTerminal"
        Me.lblAppdataTerminal.Size = New System.Drawing.Size(146, 16)
        Me.lblAppdataTerminal.TabIndex = 5
        Me.lblAppdataTerminal.Text = "Appdata Terminal Path"
        '
        'lblAppdataWorkstation
        '
        Me.lblAppdataWorkstation.AutoSize = True
        Me.lblAppdataWorkstation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppdataWorkstation.Location = New System.Drawing.Point(12, 184)
        Me.lblAppdataWorkstation.Name = "lblAppdataWorkstation"
        Me.lblAppdataWorkstation.Size = New System.Drawing.Size(164, 16)
        Me.lblAppdataWorkstation.TabIndex = 6
        Me.lblAppdataWorkstation.Text = "Appdata Workstation Path"
        '
        'lblAppdataLaptop
        '
        Me.lblAppdataLaptop.AutoSize = True
        Me.lblAppdataLaptop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppdataLaptop.Location = New System.Drawing.Point(12, 210)
        Me.lblAppdataLaptop.Name = "lblAppdataLaptop"
        Me.lblAppdataLaptop.Size = New System.Drawing.Size(135, 16)
        Me.lblAppdataLaptop.TabIndex = 7
        Me.lblAppdataLaptop.Text = "Appdata Laptop Path"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(12, 74)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 16)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(193, 15)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(165, 20)
        Me.txtIP.TabIndex = 9
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(193, 43)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(165, 20)
        Me.txtPath.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(193, 70)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(165, 20)
        Me.txtPassword.TabIndex = 11
        '
        'txtHomedirs
        '
        Me.txtHomedirs.Location = New System.Drawing.Point(193, 99)
        Me.txtHomedirs.Name = "txtHomedirs"
        Me.txtHomedirs.Size = New System.Drawing.Size(165, 20)
        Me.txtHomedirs.TabIndex = 12
        '
        'txtProfile
        '
        Me.txtProfile.Location = New System.Drawing.Point(193, 128)
        Me.txtProfile.Name = "txtProfile"
        Me.txtProfile.Size = New System.Drawing.Size(165, 20)
        Me.txtProfile.TabIndex = 13
        '
        'txtAppdataTerminal
        '
        Me.txtAppdataTerminal.Location = New System.Drawing.Point(193, 154)
        Me.txtAppdataTerminal.Name = "txtAppdataTerminal"
        Me.txtAppdataTerminal.Size = New System.Drawing.Size(165, 20)
        Me.txtAppdataTerminal.TabIndex = 14
        '
        'txtAppdataWorkstation
        '
        Me.txtAppdataWorkstation.Location = New System.Drawing.Point(193, 180)
        Me.txtAppdataWorkstation.Name = "txtAppdataWorkstation"
        Me.txtAppdataWorkstation.Size = New System.Drawing.Size(165, 20)
        Me.txtAppdataWorkstation.TabIndex = 15
        '
        'txtAppdataLaptop
        '
        Me.txtAppdataLaptop.Location = New System.Drawing.Point(193, 206)
        Me.txtAppdataLaptop.Name = "txtAppdataLaptop"
        Me.txtAppdataLaptop.Size = New System.Drawing.Size(165, 20)
        Me.txtAppdataLaptop.TabIndex = 16
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(155, 253)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDefault
        '
        Me.cmdDefault.Location = New System.Drawing.Point(236, 253)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.Size = New System.Drawing.Size(75, 23)
        Me.cmdDefault.TabIndex = 18
        Me.cmdDefault.Text = "Default"
        Me.cmdDefault.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 288)
        Me.Controls.Add(Me.cmdDefault)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtAppdataLaptop)
        Me.Controls.Add(Me.txtAppdataWorkstation)
        Me.Controls.Add(Me.txtAppdataTerminal)
        Me.Controls.Add(Me.txtProfile)
        Me.Controls.Add(Me.txtHomedirs)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblAppdataLaptop)
        Me.Controls.Add(Me.lblAppdataWorkstation)
        Me.Controls.Add(Me.lblAppdataTerminal)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.lblHomdirs)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.cmdSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Config"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents lblHomdirs As System.Windows.Forms.Label
    Friend WithEvents lblProfile As System.Windows.Forms.Label
    Friend WithEvents lblAppdataTerminal As System.Windows.Forms.Label
    Friend WithEvents lblAppdataWorkstation As System.Windows.Forms.Label
    Friend WithEvents lblAppdataLaptop As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtHomedirs As System.Windows.Forms.TextBox
    Friend WithEvents txtProfile As System.Windows.Forms.TextBox
    Friend WithEvents txtAppdataTerminal As System.Windows.Forms.TextBox
    Friend WithEvents txtAppdataWorkstation As System.Windows.Forms.TextBox
    Friend WithEvents txtAppdataLaptop As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDefault As System.Windows.Forms.Button
End Class
