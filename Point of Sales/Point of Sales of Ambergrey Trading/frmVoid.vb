Imports MySql.Data.MySqlClient

Public Class frmVoid
    Private Sub pbxExitPOS_Click(sender As Object, e As EventArgs) Handles pbxExitPOS.Click

        Me.Close()
    End Sub

    Private Sub btnSearchTrans_Click(sender As Object, e As EventArgs) Handles btnSearchTrans.Click
        Dim test As Boolean = False

        If txtSearchTrans.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else

            Try
                openConn()
                Dim theQuery As String = "SELECT * FROM tbltransaction WHERE transaction_id = @trans"
                Dim cmd1 As New MySqlCommand
                cmd1.Connection = conn
                cmd1.CommandText = theQuery
                cmd1.Parameters.AddWithValue("trans", txtSearchTrans.Text)

                Using rdr As MySqlDataReader = cmd1.ExecuteReader
                    If rdr.HasRows Then
                        test = True
                    Else
                        test = False
                    End If
                End Using
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If test = True Then
                showTransactionVoid()
                txtSearchTrans.ReadOnly = True
            Else
                MsgBox("Transaction not found!", vbOKOnly + MsgBoxStyle.Critical, "")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSearchTrans.Clear()

        txtSearchTrans.ReadOnly = False

        dgvVoid.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If dgvVoid.RowCount > 0 Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to void this transaction?", vbYesNo + MsgBoxStyle.Question, "")
            If result = MsgBoxResult.Yes Then
                returnStocks()
                deleteTransaction()
                POSClear()
                showPOSProductDetailsSoda()
                showPOSProductDetailsLiquor()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub returnStocks()
        For Each row In dgvVoid.Rows
            Dim qty As Integer

            Try
                Dim dtable As New DataTable
                openConn()
                com.Connection = conn
                com.CommandText = "SELECT quantity FROM tblproducts WHERE product_id = '" & row.Cells(0).Value.ToString & "'"
                com.ExecuteNonQuery()
                dtable.Clear()
                adapter.Fill(dtable)
                qty = Integer.Parse(dtable.Rows(0).Item(0).ToString)

                conn.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            Try
                Dim sum As Integer = qty + Integer.Parse(row.Cells(6).Value.ToString)
                openConn()
                com.Connection = conn
                com.CommandText = "UPDATE tblproducts SET quantity = @quantity_sum WHERE product_id = @prod_id"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("quantity_sum", sum)
                com.Parameters.AddWithValue("prod_id", row.Cells(0).Value.ToString)
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub deleteTransaction()

        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tbltransaction WHERE transaction_id ='" & txtSearchTrans.Text & "'"
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub frmVoid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtable As New DataTable
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT * FROM tbltransaction ORDER BY UNIX_TIMESTAMP(date_time) DESC LIMIT 1"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            txtSearchTrans.Text = dtable.Rows(0).Item(0).ToString

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        showTransactionVoid()
        txtSearchTrans.ReadOnly = True

    End Sub

End Class