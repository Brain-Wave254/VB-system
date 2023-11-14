Imports System.Data.SqlClient
Public Class formClients
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\mr brainwave\trial1\brainwave.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ClNameTb.Text = "" Or ClAge.Text = "" Or ClPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Or CountryCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into ClientTbl values('" & ClNameTb.Text & "','" & GenCb.SelectedItem.ToString() & "','" & ClAge.Text & "','" & ClPhoneTb.Text & "','" & CountryCb.SelectedItem.ToString() & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Inserted Successfully!")
                Con.Close()
                populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub populate()
        Con.Open()
        Dim sql = "select * from ClientTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ClientDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub Clear()
        ClNameTb.Clear()
        GenCb.SelectedIndex = -1
        ClAge.Clear()
        ClPhoneTb.Clear()
        CountryCb.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub

    Dim key = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Delete from ClientTbl where ClId = " & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Deleted Successfully!")
                Con.Close()
                populate()
                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ClientDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ClientDGV.CellMouseClick
        Dim row As DataGridViewRow = ClientDGV.Rows(e.RowIndex)
        ClNameTb.Text = row.Cells(1).Value.ToString
        GenCb.SelectedItem = row.Cells(2).Value.ToString
        ClAge.Text = row.Cells(3).Value.ToString
        ClPhoneTb.Text = row.Cells(4).Value.ToString
        CountryCb.SelectedItem = row.Cells(5).Value.ToString
        If ClNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ClNameTb.Text = "" Or ClAge.Text = "" Or ClPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Or CountryCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "update ClientTbl set ClName = '" & ClNameTb.Text & "', ClGender = '" & GenCb.SelectedItem.ToString() & "', ClAge = '" & ClAge.Text & "', ClPhone = '" & ClPhoneTb.Text & "', ClCountry = '" & CountryCb.SelectedItem.ToString() & "' where ClId = " & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Updated Successfully!")
                Con.Close()
                populate()
                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class