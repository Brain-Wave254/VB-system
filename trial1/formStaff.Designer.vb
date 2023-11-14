<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formStaff
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
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Tbage = New System.Windows.Forms.TextBox()
        Me.Tbphone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbClientgender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clientName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IconButtonsearch = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 60
        Me.Iconimagelabel.Location = New System.Drawing.Point(32, 32)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(91, 92)
        Me.Iconimagelabel.TabIndex = 27
        Me.Iconimagelabel.UseVisualStyleBackColor = True
        '
        'Iconlabel
        '
        Me.Iconlabel.BackColor = System.Drawing.Color.DarkGray
        Me.Iconlabel.FlatAppearance.BorderSize = 0
        Me.Iconlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconlabel.IconChar = FontAwesome.Sharp.IconChar.Circle
        Me.Iconlabel.IconColor = System.Drawing.Color.Teal
        Me.Iconlabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconlabel.IconSize = 200
        Me.Iconlabel.Location = New System.Drawing.Point(1, -9)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(162, 208)
        Me.Iconlabel.TabIndex = 26
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(182, 51)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(289, 41)
        Me.LabelName.TabIndex = 28
        Me.LabelName.Text = "BRNWAVE HOTEL"
        '
        'Tbage
        '
        Me.Tbage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbage.Location = New System.Drawing.Point(702, 237)
        Me.Tbage.Name = "Tbage"
        Me.Tbage.Size = New System.Drawing.Size(174, 36)
        Me.Tbage.TabIndex = 38
        '
        'Tbphone
        '
        Me.Tbphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbphone.Location = New System.Drawing.Point(303, 236)
        Me.Tbphone.Name = "Tbphone"
        Me.Tbphone.Size = New System.Drawing.Size(156, 36)
        Me.Tbphone.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(513, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Staff Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(697, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 25)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Staff Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Staff Phone"
        '
        'CbClientgender
        '
        Me.CbClientgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbClientgender.FormattingEnabled = True
        Me.CbClientgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CbClientgender.Location = New System.Drawing.Point(518, 236)
        Me.CbClientgender.Name = "CbClientgender"
        Me.CbClientgender.Size = New System.Drawing.Size(121, 37)
        Me.CbClientgender.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Staff Name"
        '
        'clientName
        '
        Me.clientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientName.Location = New System.Drawing.Point(101, 237)
        Me.clientName.Name = "clientName"
        Me.clientName.Size = New System.Drawing.Size(156, 36)
        Me.clientName.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(574, 439)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 36)
        Me.TextBox1.TabIndex = 44
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(205, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 43)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(362, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 43)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(518, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 43)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(672, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 43)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IconButtonsearch
        '
        Me.IconButtonsearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonsearch.IconColor = System.Drawing.Color.Black
        Me.IconButtonsearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonsearch.IconSize = 35
        Me.IconButtonsearch.Location = New System.Drawing.Point(727, 435)
        Me.IconButtonsearch.Name = "IconButtonsearch"
        Me.IconButtonsearch.Size = New System.Drawing.Size(59, 40)
        Me.IconButtonsearch.TabIndex = 46
        Me.IconButtonsearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 31)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Agents List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 35)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Staff"
        '
        'formStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(902, 679)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconButtonsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tbage)
        Me.Controls.Add(Me.Tbphone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbClientgender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clientName)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Iconimagelabel)
        Me.Controls.Add(Me.Iconlabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formStaff"
        Me.Text = "formSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelName As Label
    Friend WithEvents Tbage As TextBox
    Friend WithEvents Tbphone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbClientgender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clientName As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents IconButtonsearch As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class
