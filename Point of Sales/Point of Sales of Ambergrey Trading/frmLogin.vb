Imports MySql.Data.MySqlClient


Public Class frmLogin
    Dim cashier_id As String
    Dim cashier_name As String

    Public empid As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("The fields are empty", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            Try
                openConn()
                Try
                    com.Connection = conn
                    com.CommandText = "SELECT * FROM tblemployees"
                    Dim rdr As MySqlDataReader = com.ExecuteReader
                    While rdr.Read()
                        If txtUsername.Text = rdr("username").ToString And txtPassword.Text = rdr("password").ToString Then
                            If rdr("user_level").ToString = "admin" Then
                                system_mode = 1
                            Else
                                system_mode = 2
                                cashier_id = rdr("employee_id").ToString
                                cashier_name = rdr("first_name").ToString
                            End If
                            empid = rdr("employee_id").ToString
                        End If
                        If Not system_mode = 0 Then
                            Exit While
                        End If
                    End While
                    conn.Close()
                    If system_mode = 1 Then
                        frmMain.Show()
                        Me.Close()
                    ElseIf system_mode = 2 Then
                        addLoginLog()
                        frmPOS.lblCashierID.Text = cashier_id
                        frmPOS.lblCashierName.Text = cashier_name
                        frmPOS.Show()
                        Me.Close()
                    Else
                        MsgBox("Account not found! Please enter valid credentials", vbOKOnly + MsgBoxStyle.Critical, "")
                    End If
                Catch ex As Exception
                    MsgBox("Cannot find the database")
                End Try
            Catch ex As Exception
                MsgBox("Cannot establish a database connection")
            End Try
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        system_mode = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblChangePassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblChangePassword.LinkClicked
        frmForgotPassword1.Show()
        Me.Close()
    End Sub


    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not txtPassword.Text = "" And Not txtUsername.Text = "" Then
                btnLogin.PerformClick()
            End If
        End If
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not txtPassword.Text = "" And Not txtUsername.Text = "" Then
                btnLogin.PerformClick()
            End If
        End If
    End Sub
End Class