Imports MySql.Data.MySqlClient
Imports System.Globalization

Module setterAndGetterModule

    Public Sub loadCombobox()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT supplier_id, supplier_name FROM tblsupplier"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboSupplier.DataSource = dtable
            frmMain.cboSupplier.ValueMember = "supplier_id"
            frmMain.cboSupplier.DisplayMember = "supplier_name"
            frmMain.cboSupplier.SelectedIndex = -1

            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadComboboxSupplierProducts()

        Try
            Dim dtable As New DataTable
            openConn()

            com.Connection = conn
            com.CommandText = "SELECT supplier_id, supplier_name FROM tblsupplier"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboSupplierBy.DataSource = dtable
            frmMain.cboSupplierBy.ValueMember = "supplier_id"
            frmMain.cboSupplierBy.DisplayMember = "supplier_name"
            frmMain.cboSupplierBy.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadSizes()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT size_id, size_quantity FROM tblsize"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboSize.DataSource = dtable
            frmMain.cboSize.ValueMember = "size_id"
            frmMain.cboSize.DisplayMember = "size_quantity"
            frmMain.cboSize.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadDiscount()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT discount_id, discount FROM tbldiscounts"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.cboDiscount.DataSource = dtable
            frmPOS.cboDiscount.ValueMember = "discount_id"
            frmPOS.cboDiscount.DisplayMember = "discount"
            frmPOS.cboDiscount.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadProdName()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT prodname_id, prod_name FROM tblprodname"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboProdName.DataSource = dtable
            frmMain.cboProdName.ValueMember = "prodname_id"
            frmMain.cboProdName.DisplayMember = "prod_name"
            frmMain.cboProdName.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub loadContainer()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT container_id, container_name FROM tblcontainer"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboContainer.DataSource = dtable
            frmMain.cboContainer.ValueMember = "container_id"
            frmMain.cboContainer.DisplayMember = "container_name"
            frmMain.cboContainer.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub loadVariant()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT variant_id, variant_name FROM tblvariants"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboVariant.DataSource = dtable
            frmMain.cboVariant.ValueMember = "variant_id"
            frmMain.cboVariant.DisplayMember = "variant_name"
            frmMain.cboVariant.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getProductNameID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT prodname_id FROM tblprodname WHERE prod_name = '" & frmMain.dgvProductName.SelectedRows(0).Cells("PRODUCT_NAME").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            prodname_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getVariantID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT variant_id FROM tblvariants WHERE variant_name = '" & frmMain.dgvVariants.SelectedRows(0).Cells("VARIANT").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            variant_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getContainerID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT container_id FROM tblcontainer WHERE container_name = '" & frmMain.dgvContainer.SelectedRows(0).Cells("CONTAINER").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            container_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getSizeID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT size_id FROM tblsize WHERE size_quantity = '" & frmMain.dgvSize.SelectedRows(0).Cells("SIZE").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            size_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getDiscountID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT discount_id FROM tbldiscounts WHERE discount = '" & frmMain.dgvDiscount.SelectedRows(0).Cells("DISCOUNT").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            disc_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getSupplierID()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT supplier_id FROM tblsupplier WHERE supplier_name = '" & frmMain.cboSupplier.Text & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            selectedsupplier = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getSupplierIDBy()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT supplier_id FROM tblsupplier WHERE supplier_id = '" & frmMain.cboSupplierBy.SelectedValue & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            selectedsupplier = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getProductQuantity()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT quantity FROM tblproducts WHERE product_id = '" & frmMain.txtProductIDAddStock.Text & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            selectedproductquantity = Integer.Parse(dtable.Rows(0).Item(0).ToString)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getProductQuantityDefection()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT quantity FROM tblproducts WHERE product_id = '" & frmMain.txtProductNameDefect.Text & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            selectedproductquantity = Integer.Parse(dtable.Rows(0).Item(0).ToString)

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getCustomerDetails()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT * FROM tblcustomer WHERE customer_id = '" & frmMain.dgvCustomerList.SelectedRows(0).Cells("CUSTOMER_ID").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            fname = dtable.Rows(0).Item(1).ToString
            mname = dtable.Rows(0).Item(2).ToString
            lname = dtable.Rows(0).Item(3).ToString
            contact = dtable.Rows(0).Item(4).ToString
            houseno = dtable.Rows(0).Item(5).ToString
            stname = dtable.Rows(0).Item(6).ToString
            brgy = dtable.Rows(0).Item(7).ToString
            city = dtable.Rows(0).Item(8).ToString

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub getEmployeeDetails()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT * FROM tblemployees WHERE employee_id = '" & frmMain.dgvEmployeeList.SelectedRows(0).Cells("EMPLOYEE_ID").Value.ToString & "'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            emp_id = dtable.Rows(0).Item(0).ToString
            efname = dtable.Rows(0).Item(1).ToString
            emname = dtable.Rows(0).Item(2).ToString
            elname = dtable.Rows(0).Item(3).ToString
            username = dtable.Rows(0).Item(4).ToString
            password = dtable.Rows(0).Item(5).ToString
            ulevel = dtable.Rows(0).Item(6).ToString
            econtact = dtable.Rows(0).Item(7).ToString
            secq = dtable.Rows(0).Item(8).ToString
            secan = dtable.Rows(0).Item(9).ToString
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub getTransactionID()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT * FROM tbltransaction ORDER BY UNIX_TIMESTAMP(date_time) DESC LIMIT 1"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            transaction_id = Integer.Parse(dtable.Rows(0).Item(0).ToString)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub loadEmployeeCombobox()
        Dim dtable As New DataTable
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "SELECT employee_id FROM tblemployees WHERE NOT user_level = 'admin'"
            com.ExecuteNonQuery()
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.cboEmployeeID.DataSource = dtable
            frmMain.cboEmployeeID.ValueMember = "employee_id"
            frmMain.cboEmployeeID.DisplayMember = "employee_id"
            frmMain.cboEmployeeID.SelectedIndex = -1
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub getMonthNumber()
        Select Case frmMain.cboMonth.Text
            Case "January"
                monthnumber = "01"
            Case "February"
                monthnumber = "02"
            Case "March"
                monthnumber = "03"
            Case "April"
                monthnumber = "04"
            Case "May"
                monthnumber = "05"
            Case "June"
                monthnumber = "06"
            Case "July"
                monthnumber = "07"
            Case "August"
                monthnumber = "08"
            Case "September"
                monthnumber = "09"
            Case "October"
                monthnumber = "10"
            Case "November"
                monthnumber = "11"
            Case "December"
                monthnumber = "12"
        End Select
    End Sub



End Module
