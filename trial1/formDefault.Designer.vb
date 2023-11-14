<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDefault
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
        Me.components = New System.ComponentModel.Container()
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Myprogress = New System.Windows.Forms.ProgressBar()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 200
        Me.Iconimagelabel.Location = New System.Drawing.Point(259, 118)
        Me.Iconimagelabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(119, 141)
        Me.Iconimagelabel.TabIndex = 3
        Me.Iconimagelabel.UseVisualStyleBackColor = False
        '
        'Iconlabel
        '
        Me.Iconlabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Iconlabel.FlatAppearance.BorderSize = 0
        Me.Iconlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconlabel.IconChar = FontAwesome.Sharp.IconChar.Circle
        Me.Iconlabel.IconColor = System.Drawing.Color.Teal
        Me.Iconlabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconlabel.IconSize = 400
        Me.Iconlabel.Location = New System.Drawing.Point(157, 43)
        Me.Iconlabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(328, 345)
        Me.Iconlabel.TabIndex = 2
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(123, 7)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(453, 38)
        Me.LabelName.TabIndex = 4
        Me.LabelName.Text = "HOTEL MANAGEMENT SYSTEM"
        '
        'Myprogress
        '
        Me.Myprogress.ForeColor = System.Drawing.Color.Black
        Me.Myprogress.Location = New System.Drawing.Point(5, 393)
        Me.Myprogress.Margin = New System.Windows.Forms.Padding(2)
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Myprogress.Size = New System.Drawing.Size(662, 32)
        Me.Myprogress.TabIndex = 5
        '
        'Percentage
        '
        Me.Percentage.AutoSize = True
        Me.Percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage.Location = New System.Drawing.Point(315, 347)
        Me.Percentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(38, 31)
        Me.Percentage.TabIndex = 6
        Me.Percentage.Text = "%"
        '
        'Timer1
        '
        '
        'formDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(676, 431)
        Me.Controls.Add(Me.Percentage)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Iconimagelabel)
        Me.Controls.Add(Me.Iconlabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formDefault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDefault"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelName As Label
    Friend WithEvents Myprogress As ProgressBar
    Friend WithEvents Percentage As Label
    Friend WithEvents Timer1 As Timer
End Class
