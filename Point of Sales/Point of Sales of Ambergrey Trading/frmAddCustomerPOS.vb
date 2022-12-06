Imports MySql.Data.MySqlClient

Public Class frmAddCustomerPOS
    Private Sub pbxExitPOS_Click(sender As Object, e As EventArgs) Handles pbxExitPOS.Click

        Me.Close()
    End Sub

    Private Sub btnClearCustomer_Click(sender As Object, e As EventArgs) Handles btnClearCustomer.Click
        txtFirstNameCustomer.Clear()
        txtMiddleNameCustomer.Clear()
        txtLastNameCustomer.Clear()
        txtStreetCustomer.Clear()
        txtMunicipalityCustomer.Clear()
        txtHouseNoCustomer.Clear()
        txtBarangayCustomer.Clear()
        txtCustomerID.Clear()
        txtContactCustomer.Clear()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim exists As Boolean = False
        If txtFirstNameCustomer.Text = "" Or txtLastNameCustomer.Text = "" Or txtHouseNoCustomer.Text = "" Or txtStreetCustomer.Text = "" Or txtBarangayCustomer.Text = "" Or txtContactCustomer.Text = "" Or txtMunicipalityCustomer.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            Do
                generateCustomerID()
                Try
                    openConn()
                    Dim theQuery As String = "SELECT * FROM tblcustomer WHERE customer_id = @cus"
                    Dim cmd1 As New MySqlCommand
                    cmd1.Connection = conn
                    cmd1.CommandText = theQuery
                    cmd1.Parameters.AddWithValue("cus", idcustomergeneration)

                    Using rdr As MySqlDataReader = cmd1.ExecuteReader
                        If rdr.HasRows Then
                            customernum += 1
                            exists = False
                        Else
                            exists = True
                        End If
                    End Using
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Loop While exists = False
            addCustomerDetailsPOS()
            showPOSCustomerDetails()
            Me.Close()
        End If
    End Sub
    Private Sub generateCustomerID()
        Dim yearstring As String = Date.Now.Year.ToString
        Dim cusnumstr As String = customernum.ToString.PadLeft(4, "0")
        idcustomergeneration = yearstring + cusnumstr
    End Sub

End Class