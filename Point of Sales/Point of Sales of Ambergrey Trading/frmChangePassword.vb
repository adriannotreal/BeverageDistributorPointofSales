Public Class frmChangePassword

    Public usernamechange As String

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmitChange_Click(sender As Object, e As EventArgs) Handles btnSubmitChange.Click
        If txtNewPassword.Text = txtRetypePassword.Text Then
            updatePassword()
            MsgBox("Password successfully changed!", MsgBoxStyle.Information, "Password Change")
            frmLogin.Show()
            Me.Close()
        Else
            MsgBox("Passwords does not match!", vbOKOnly + MsgBoxStyle.Critical, "")
        End If
    End Sub

    Private Sub pbxExitChange_Click(sender As Object, e As EventArgs) Handles pbxExitChange.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class