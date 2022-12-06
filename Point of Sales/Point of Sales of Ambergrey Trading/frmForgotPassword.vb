Imports MySql.Data.MySqlClient

Public Class frmForgotPassword

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dt As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT * FROM tblemployees WHERE username = @uname AND security_question = @ques AND security_answer = @ans"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("uname", txtUsernameForgot.Text)
            com.Parameters.AddWithValue("ques", cboSecurityQuestionForgot.Text)
            com.Parameters.AddWithValue("ans", txtSecurityAnswerForgot.Text)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            adapter.Fill(dt)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If dt.Rows.Count < 1 Then
            MsgBox("Security credentials incorrect!", vbOKOnly + MsgBoxStyle.Critical, "")
            txtSecurityAnswerForgot.Clear()
            cboSecurityQuestionForgot.SelectedIndex = -1
        Else
            MsgBox("Security credentials correct!", vbOKOnly + MsgBoxStyle.Information, "")
            frmChangePassword.txtUsernameChange.Text = dt.Rows(0).Item(4).ToString
            frmChangePassword.Show()
            Me.Close()
        End If


    End Sub

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSecurityQuestionForgot.SelectedIndex = -1
    End Sub

    Private Sub pbxExitForgot_Click(sender As Object, e As EventArgs) Handles pbxExitForgot.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class