<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.StaffIdTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(154, 117)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(165, 24)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "ACCOUNT LOGIN"
        '
        'StaffIdTb
        '
        Me.StaffIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffIdTb.Location = New System.Drawing.Point(158, 193)
        Me.StaffIdTb.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffIdTb.Name = "StaffIdTb"
        Me.StaffIdTb.Size = New System.Drawing.Size(164, 30)
        Me.StaffIdTb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Staff Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 248)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(158, 284)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTb.Size = New System.Drawing.Size(164, 30)
        Me.PasswordTb.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CheckBox1.Location = New System.Drawing.Point(183, 318)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(313, 379)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(133, 35)
        Me.BtnLogin.TabIndex = 11
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 35)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "BRNWAVE HOTEL"
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 60
        Me.Iconimagelabel.Location = New System.Drawing.Point(40, 43)
        Me.Iconimagelabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(68, 75)
        Me.Iconimagelabel.TabIndex = 70
        Me.Iconimagelabel.UseVisualStyleBackColor = True
        '
        'Iconlabel
        '
        Me.Iconlabel.BackColor = System.Drawing.Color.Transparent
        Me.Iconlabel.FlatAppearance.BorderSize = 0
        Me.Iconlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconlabel.IconChar = FontAwesome.Sharp.IconChar.Circle
        Me.Iconlabel.IconColor = System.Drawing.Color.Teal
        Me.Iconlabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconlabel.IconSize = 200
        Me.Iconlabel.Location = New System.Drawing.Point(0, 10)
        Me.Iconlabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(152, 169)
        Me.Iconlabel.TabIndex = 69
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(313, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 35)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(676, 552)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Iconimagelabel)
        Me.Controls.Add(Me.Iconlabel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StaffIdTb)
        Me.Controls.Add(Me.LabelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents StaffIdTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
End Class
