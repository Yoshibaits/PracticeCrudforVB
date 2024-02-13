Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=CRUD")
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete()
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Edit()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_crud`(`PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `TYPEOFGROUP`, `EXPDATE`, `STATUS`) 
            VALUES (@PRODUCTNO,@PRODUCTNAME,@PRICE,@TYPEOFGROUP,@EXPDATE,@STATUS)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prodno.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_prodname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@TYPEOFGROUP", combo_prodGroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datePicker.Text))
            cmd.Parameters.AddWithValue("@STATUS", CBool(status_checkbox.Checked.ToString))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub
    Public Sub delete()
        If MsgBox("Are you sure you want to delete this record?") Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `tbl_crud` WHERE `PRODUCTNO`=@PRODUCTNO", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prodno.Text)
                cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_prodname.Text)
                cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
                cmd.Parameters.AddWithValue("@TYPEOFGROUP", combo_prodGroup.Text)
                cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datePicker.Text))
                cmd.Parameters.AddWithValue("@STATUS", CBool(status_checkbox.Checked.ToString))

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Delete Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
            DGV_load()
        Else
            Return
        End If

    End Sub

    Public Sub clear()

        txt_prodno.Clear()
        txt_prodname.Clear()
        txt_price.Clear()
        combo_prodGroup.Text = ""
        exp_datePicker.Value = Now
        status_checkbox.CheckState = False

    End Sub
    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_crud` SET `PRODUCTNAME`=@PRODUCTNAME,`PRICE`=@PRICE,`TYPEOFGROUP`=@TYPEOFGROUP,`EXPDATE`=@EXPDATE,`STATUS`=@STATUS WHERE `PRODUCTNO`=@PRODUCTNO", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prodno.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_prodname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            cmd.Parameters.AddWithValue("@TYPEOFGROUP", combo_prodGroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_datePicker.Text))
            cmd.Parameters.AddWithValue("@STATUS", CBool(status_checkbox.Checked.ToString))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub
    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("TYPEOFGROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_load()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_prodno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_prodname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_prodGroup.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_datePicker.Text = DataGridView1.CurrentRow.Cells(4).Value
        status_checkbox.Checked = DataGridView1.CurrentRow.Cells(5).Value

        txt_prodno.ReadOnly = True
        btn_save.Enabled = False

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud WHERE PRODUCTNO like '%" & txt_search.Text & "%' OR PRODUCTNAME like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("TYPEOFGROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
