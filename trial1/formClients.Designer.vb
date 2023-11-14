<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formClients
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClNameTb = New System.Windows.Forms.TextBox()
        Me.GenCb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClPhoneTb = New System.Windows.Forms.TextBox()
        Me.ClAge = New System.Windows.Forms.TextBox()
        Me.CountryCb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.IconButtonsearch = New FontAwesome.Sharp.IconButton()
        Me.ClientDGV = New System.Windows.Forms.DataGridView()
        CType(Me.ClientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(178, 82)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(289, 41)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "BRNWAVE HOTEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Client Name"
        '
        'ClNameTb
        '
        Me.ClNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClNameTb.Location = New System.Drawing.Point(15, 274)
        Me.ClNameTb.Name = "ClNameTb"
        Me.ClNameTb.Size = New System.Drawing.Size(156, 36)
        Me.ClNameTb.TabIndex = 8
        '
        'GenCb
        '
        Me.GenCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenCb.FormattingEnabled = True
        Me.GenCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenCb.Location = New System.Drawing.Point(223, 272)
        Me.GenCb.Name = "GenCb"
        Me.GenCb.Size = New System.Drawing.Size(121, 37)
        Me.GenCb.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(760, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Client Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(559, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Client Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Client Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(218, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Client Gender"
        '
        'ClPhoneTb
        '
        Me.ClPhoneTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClPhoneTb.Location = New System.Drawing.Point(564, 274)
        Me.ClPhoneTb.Name = "ClPhoneTb"
        Me.ClPhoneTb.Size = New System.Drawing.Size(156, 36)
        Me.ClPhoneTb.TabIndex = 15
        '
        'ClAge
        '
        Me.ClAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClAge.Location = New System.Drawing.Point(410, 273)
        Me.ClAge.Name = "ClAge"
        Me.ClAge.Size = New System.Drawing.Size(107, 36)
        Me.ClAge.TabIndex = 16
        '
        'CountryCb
        '
        Me.CountryCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryCb.FormattingEnabled = True
        Me.CountryCb.Items.AddRange(New Object() {"Kenya", "India", "Uganda", "USA", "Congo", "Tanzania", "Rwanda", "Burundi", "Ethiopia", "Sudan", "Somalia", "Chad", "Nigeria", "Egypt"})
        Me.CountryCb.Location = New System.Drawing.Point(765, 273)
        Me.CountryCb.Name = "CountryCb"
        Me.CountryCb.Size = New System.Drawing.Size(131, 37)
        Me.CountryCb.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(661, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(474, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(285, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 43)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(112, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 43)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 31)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Clients List"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(573, 472)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 36)
        Me.TextBox1.TabIndex = 23
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 60
        Me.Iconimagelabel.Location = New System.Drawing.Point(41, 63)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(91, 92)
        Me.Iconimagelabel.TabIndex = 25
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
        Me.Iconlabel.Location = New System.Drawing.Point(10, 22)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(162, 208)
        Me.Iconlabel.TabIndex = 24
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'IconButtonsearch
        '
        Me.IconButtonsearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonsearch.IconColor = System.Drawing.Color.Black
        Me.IconButtonsearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonsearch.IconSize = 35
        Me.IconButtonsearch.Location = New System.Drawing.Point(722, 466)
        Me.IconButtonsearch.Name = "IconButtonsearch"
        Me.IconButtonsearch.Size = New System.Drawing.Size(59, 42)
        Me.IconButtonsearch.TabIndex = 26
        Me.IconButtonsearch.UseVisualStyleBackColor = True
        '
        'ClientDGV
        '
        Me.ClientDGV.AllowUserToOrderColumns = True
        Me.ClientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientDGV.Location = New System.Drawing.Point(95, 522)
        Me.ClientDGV.Name = "ClientDGV"
        Me.ClientDGV.RowHeadersWidth = 51
        Me.ClientDGV.RowTemplate.Height = 24
        Me.ClientDGV.Size = New System.Drawing.Size(693, 130)
        Me.ClientDGV.TabIndex = 27
        '
        'formClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(902, 679)
        Me.Controls.Add(Me.ClientDGV)
        Me.Controls.Add(Me.IconButtonsearch)
        Me.Controls.Add(Me.Iconimagelabel)
        Me.Controls.Add(Me.Iconlabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CountryCb)
        Me.Controls.Add(Me.ClAge)
        Me.Controls.Add(Me.ClPhoneTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GenCb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClNameTb)
        Me.Controls.Add(Me.LabelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formClients"
        Me.Text = "formHome"
        CType(Me.ClientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClNameTb As TextBox
    Friend WithEvents GenCb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ClPhoneTb As TextBox
    Friend WithEvents ClAge As TextBox
    Friend WithEvents CountryCb As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonsearch As FontAwesome.Sharp.IconButton
    Friend WithEvents ClientDGV As DataGridView
End Class
