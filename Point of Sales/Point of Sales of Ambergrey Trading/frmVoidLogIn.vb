Imports MySql.Data.MySqlClient

Public Class frmVoidLogIn
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("The fields are empty", vbOKOnly + MsgBoxStyle.Critical, "")
        Else

            openConn()
            Try
                com.Connection = conn
                com.CommandText = "SELECT * FROM tblemployees"
                Dim rdr As MySqlDataReader = com.ExecuteReader
                While rdr.Read()
                    If txtUsername.Text = rdr("username").ToString And txtPassword.Text = rdr("password").ToString Then
                        If rdr("user_level").ToString = "admin" Then
                            system_mode = 1
                        End If
                    End If
                    If Not system_mode = 0 Then
                        Exit While
                    End If
                End While
                conn.Close()
                If system_mode = 1 Then
                    MsgBox("User verified", vbOKOnly + MsgBoxStyle.Information, "")
                    frmVoid.ShowDialog()
                    frmVoid.Dispose()
                    Me.Close()

                Else
                    MsgBox("Invalid credentials", vbOKOnly + MsgBoxStyle.Critical, "")

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub pbxExitPOS_Click(sender As Object, e As EventArgs) Handles pbxExitPOS.Click
        Me.Close()
    End Sub


End Class