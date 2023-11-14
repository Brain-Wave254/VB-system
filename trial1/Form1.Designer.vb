<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.BtnClient = New FontAwesome.Sharp.IconButton()
        Me.btnRecords = New FontAwesome.Sharp.IconButton()
        Me.btnRooms = New FontAwesome.Sharp.IconButton()
        Me.btnStaff = New FontAwesome.Sharp.IconButton()
        Me.btnReservations = New FontAwesome.Sharp.IconButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Iconimagelabel = New FontAwesome.Sharp.IconButton()
        Me.Iconlabel = New FontAwesome.Sharp.IconButton()
        Me.TopPanel.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Navy
        Me.TopPanel.Controls.Add(Me.btnLogout)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(848, 41)
        Me.TopPanel.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.CadetBlue
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.btnLogout.IconColor = System.Drawing.Color.Black
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 25
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(713, 4)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(133, 35)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.CadetBlue
        Me.SidePanel.Controls.Add(Me.BtnClient)
        Me.SidePanel.Controls.Add(Me.btnRecords)
        Me.SidePanel.Controls.Add(Me.btnRooms)
        Me.SidePanel.Controls.Add(Me.btnStaff)
        Me.SidePanel.Controls.Add(Me.btnReservations)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 41)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(138, 567)
        Me.SidePanel.TabIndex = 1
        '
        'BtnClient
        '
        Me.BtnClient.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnClient.FlatAppearance.BorderSize = 0
        Me.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClient.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClient.ForeColor = System.Drawing.Color.Black
        Me.BtnClient.IconChar = FontAwesome.Sharp.IconChar.Palfed
        Me.BtnClient.IconColor = System.Drawing.Color.Black
        Me.BtnClient.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnClient.IconSize = 37
        Me.BtnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClient.Location = New System.Drawing.Point(2, 21)
        Me.BtnClient.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClient.Name = "BtnClient"
        Me.BtnClient.Size = New System.Drawing.Size(136, 45)
        Me.BtnClient.TabIndex = 5
        Me.BtnClient.Text = "Client"
        Me.BtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClient.UseVisualStyleBackColor = True
        '
        'btnRecords
        '
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.Black
        Me.btnRecords.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.btnRecords.IconColor = System.Drawing.Color.Black
        Me.btnRecords.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRecords.IconSize = 44
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(0, 288)
        Me.btnRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(134, 46)
        Me.btnRecords.TabIndex = 4
        Me.btnRecords.Text = "Records"
        Me.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'btnRooms
        '
        Me.btnRooms.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRooms.FlatAppearance.BorderSize = 0
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRooms.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.Black
        Me.btnRooms.IconChar = FontAwesome.Sharp.IconChar.Hive
        Me.btnRooms.IconColor = System.Drawing.Color.Black
        Me.btnRooms.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRooms.IconSize = 42
        Me.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRooms.Location = New System.Drawing.Point(0, 146)
        Me.btnRooms.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(138, 45)
        Me.btnRooms.TabIndex = 3
        Me.btnRooms.Text = "Room"
        Me.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRooms.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.Black
        Me.btnStaff.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsBy
        Me.btnStaff.IconColor = System.Drawing.Color.Black
        Me.btnStaff.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStaff.IconSize = 37
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 82)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(138, 45)
        Me.btnStaff.TabIndex = 2
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnReservations
        '
        Me.btnReservations.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReservations.FlatAppearance.BorderSize = 0
        Me.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservations.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.Black
        Me.btnReservations.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnReservations.IconColor = System.Drawing.Color.Black
        Me.btnReservations.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReservations.IconSize = 44
        Me.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservations.Location = New System.Drawing.Point(-6, 213)
        Me.btnReservations.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(144, 46)
        Me.btnReservations.TabIndex = 1
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReservations.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.DarkGray
        Me.PanelContainer.Controls.Add(Me.Label3)
        Me.PanelContainer.Controls.Add(Me.Iconimagelabel)
        Me.PanelContainer.Controls.Add(Me.Iconlabel)
        Me.PanelContainer.Location = New System.Drawing.Point(138, 41)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(708, 566)
        Me.PanelContainer.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 35)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "BRNWAVE HOTEL"
        '
        'Iconimagelabel
        '
        Me.Iconimagelabel.FlatAppearance.BorderSize = 0
        Me.Iconimagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iconimagelabel.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.Iconimagelabel.IconColor = System.Drawing.Color.Teal
        Me.Iconimagelabel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconimagelabel.IconSize = 200
        Me.Iconimagelabel.Location = New System.Drawing.Point(263, 202)
        Me.Iconimagelabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconimagelabel.Name = "Iconimagelabel"
        Me.Iconimagelabel.Size = New System.Drawing.Size(119, 141)
        Me.Iconimagelabel.TabIndex = 1
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
        Me.Iconlabel.IconSize = 400
        Me.Iconlabel.Location = New System.Drawing.Point(162, 126)
        Me.Iconlabel.Margin = New System.Windows.Forms.Padding(2)
        Me.Iconlabel.Name = "Iconlabel"
        Me.Iconlabel.Size = New System.Drawing.Size(328, 345)
        Me.Iconlabel.TabIndex = 0
        Me.Iconlabel.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 608)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopPanel.ResumeLayout(False)
        Me.SidePanel.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRooms As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReservations As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecords As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconlabel As FontAwesome.Sharp.IconButton
    Friend WithEvents Iconimagelabel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnClient As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
End Class
