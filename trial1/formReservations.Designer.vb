<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formReservations
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
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbphone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbClientgender = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconButtonsearch = New FontAwesome.Sharp.IconButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(189, 65)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(289, 41)
        Me.LabelName.TabIndex = 34
        Me.LabelName.Text = "BRNWAVE HOTEL"
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 60
        Me.Iconimagelabel.Location = New System.Drawing.Point(39, 46)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(91, 92)
        Me.Iconimagelabel.TabIndex = 33
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
        Me.Iconlabel.Location = New System.Drawing.Point(8, 5)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(162, 208)
        Me.Iconlabel.TabIndex = 32
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(202, 329)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 43)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(359, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 43)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(515, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 43)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(669, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 43)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tbphone
        '
        Me.Tbphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbphone.Location = New System.Drawing.Point(39, 278)
        Me.Tbphone.Name = "Tbphone"
        Me.Tbphone.Size = New System.Drawing.Size(156, 36)
        Me.Tbphone.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Client Name"
        '
        'CbClientgender
        '
        Me.CbClientgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbClientgender.FormattingEnabled = True
        Me.CbClientgender.Location = New System.Drawing.Point(239, 276)
        Me.CbClientgender.Name = "CbClientgender"
        Me.CbClientgender.Size = New System.Drawing.Size(121, 37)
        Me.CbClientgender.TabIndex = 56
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(418, 285)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 60
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(676, 287)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Date In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(671, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Date Out"
        '
        'IconButtonsearch
        '
        Me.IconButtonsearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonsearch.IconColor = System.Drawing.Color.Black
        Me.IconButtonsearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonsearch.IconSize = 35
        Me.IconButtonsearch.Location = New System.Drawing.Point(702, 461)
        Me.IconButtonsearch.Name = "IconButtonsearch"
        Me.IconButtonsearch.Size = New System.Drawing.Size(59, 40)
        Me.IconButtonsearch.TabIndex = 66
        Me.IconButtonsearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(550, 465)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 36)
        Me.TextBox1.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 31)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Reservations List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 35)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Reservations"
        '
        'formReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(902, 679)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IconButtonsearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Tbphone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbClientgender)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Iconimagelabel)
        Me.Controls.Add(Me.Iconlabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formReservations"
        Me.Text = "formDownloads"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Tbphone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbClientgender As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButtonsearch As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
