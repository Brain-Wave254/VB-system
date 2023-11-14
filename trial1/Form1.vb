Imports FontAwesome.Sharp

Public Class Form1
    Private currentBtn As IconButton
    Private leftborderBtn As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("Form1")
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftborderBtn = New Panel
        leftborderBtn.Size = New Size(7, 71)
        SidePanel.Controls.Add(leftborderBtn)
    End Sub
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisabledButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.Navy
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black

            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.CadetBlue
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black
        End If
    End Sub

    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "Home"
                addForm(formClients)
            Case "Staff"
                addForm(formStaff)
            Case "Rooms"
                addForm(formRooms)
            Case "Reservations"
                addForm(formReservations)
            Case "Records"
                addForm(formRecords)
            Case "Clients"
                addForm(formClients)
            Case "Login"
                addForm(formStaff)

        End Select
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ActiveButton(sender, Color.Crimson)
        Me.Hide()
        Dim log = New formLogin
        formLogin.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        ActiveButton(sender, Color.Crimson)
        change_menu("Staff")
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        ActiveButton(sender, Color.Crimson)
        change_menu("Rooms")
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        ActiveButton(sender, Color.Crimson)
        change_menu("Reservations")
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        ActiveButton(sender, Color.Crimson)
        change_menu("Records")
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub

    Private Sub BtnClient_Click(sender As Object, e As EventArgs) Handles BtnClient.Click
        ActiveButton(sender, Color.Crimson)
        change_menu("Clients")
    End Sub

End Class
