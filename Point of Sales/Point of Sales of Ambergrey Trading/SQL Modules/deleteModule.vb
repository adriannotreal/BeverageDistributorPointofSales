Imports MySql.Data.MySqlClient
Imports System.Globalization

Module deleteModule

    Public Sub deleteProductDetails()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblproducts WHERE product_id ='" & frmMain.dgvProductsProductList.SelectedRows(0).Cells("PRODUCT_ID").Value & "'"
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteProductName()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblprodname WHERE prodname_id =" & prodname_id & ""
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteVariant()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblvariants WHERE variant_id = " & variant_id & ""
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteContainer()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblcontainer WHERE container_id = " & container_id & ""
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteSize()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblsize WHERE size_id = " & size_id & ""
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteDiscount()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tbldiscounts WHERE discount_id = " & disc_id & ""
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteCustomerDetails()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblcustomer WHERE customer_id ='" & frmMain.dgvCustomerList.SelectedRows(0).Cells("CUSTOMER_ID").Value & "'"
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteSupplierDetails()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblsupplier WHERE supplier_id ='" & frmMain.dgvSupplierDetails.SelectedRows(0).Cells("SUPPLIER_ID").Value & "'"
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deleteEmployeeDetails()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "DELETE FROM tblemployees WHERE employee_id ='" & frmMain.dgvEmployeeList.SelectedRows(0).Cells("EMPLOYEE_ID").Value & "'"
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
