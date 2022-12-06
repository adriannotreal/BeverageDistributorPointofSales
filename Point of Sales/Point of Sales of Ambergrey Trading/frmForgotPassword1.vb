Public Class frmForgotPassword1
    Private Sub pbxExitForgot_Click(sender As Object, e As EventArgs) Handles pbxExitForgot.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dt As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT * FROM tblemployees WHERE username = @uname AND NOT username = 'admin'"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("uname", txtUsernameForgot.Text)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            adapter.Fill(dt)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If dt.Rows.Count < 1 Then
            MsgBox("Account not found!", vbOKOnly + MsgBoxStyle.Critical, "")
            txtUsernameForgot.Clear()
        Else
            MsgBox("Username found!", vbOKOnly + MsgBoxStyle.Information, "")
            frmForgotPassword.txtUsernameForgot.Text = dt.Rows(0).Item(4).ToString
            frmForgotPassword.Show()
            Me.Close()
        End If
    End Sub
End Class