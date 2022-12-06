Imports MySql.Data.MySqlClient
Imports System.Globalization

Module displayModule
    Public Sub showProductDetails()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblproducts.category as CATEGORY, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductsProductList.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductNameVar()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT prod_name as PRODUCT_NAME FROM tblprodname"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductName.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showVariants()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT variant_name as VARIANT FROM tblvariants"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvVariants.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showContainer()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT container_name as CONTAINER FROM tblcontainer"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvContainer.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub showSize()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT size_quantity as SIZE FROM tblsize"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSize.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub showDiscount()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT discount as DISCOUNT FROM tbldiscounts"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvDiscount.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub showProductDetailsSearch()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblproducts.category as CATEGORY, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id " +
                "WHERE tblproducts.product_id LIKE @search OR tblproducts.product_name LIKE @search OR tblproducts.category LIKE @search OR tblsupplier.supplier_name LIKE @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtSearchProduct.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductsProductList.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub showProductDetailsStockIn()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvAddStock.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductDetailsStockInSearch()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id " +
                "WHERE tblproducts.product_id LIKE @search OR tblproducts.product_name LIKE @search OR tblsupplier.supplier_name LIKE @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtSearchProductStockIn.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvAddStock.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductStockHistory()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblstockin.stock_id as STOCK_ID, tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblsupplier.supplier_name as SUPPLIER, tblstockin.quantity as QUANTITY, tblstockin.date_added as DATE_ADDED " +
                "FROM (tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id)  INNER JOIN tblstockin ON tblproducts.product_id = tblstockin.product_id ORDER BY tblstockin.stock_id DESC"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvStockInHistory.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductDefective()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductListDefect.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductDefectiveSearch()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblsupplier.supplier_name as SUPPLIER, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id WHERE tblproducts.product_id LIKE @search OR tblproducts.product_name LIKE @search OR tblsupplier.supplier_name LIKE @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtSearchProductDefective.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductListDefect.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub showProductDefectiveHistory()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbldefective.defective_id as DEFECTION_ID, tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                " tblsupplier.supplier_name as SUPPLIER, tbldefective.defective_quantity as QUANTITY, tbldefective.defective_comment as COMMENT, tbldefective.defection_date as DEFECTION_DATE " +
                "FROM (tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id)  INNER JOIN tbldefective ON tblproducts.product_id = tbldefective.product_id ORDER BY tbldefective.defective_id DESC"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvDefectiveItemHistory.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductStockOut()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_ml, tblproducts.container as CONTAINER_TYPE," +
                "tblproducts.quantity as QUANTITY, tblsupplier.supplier_name as SUPPLIER, tblsupplier.supplier_contact_number " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id WHERE tblproducts.quantity < 20"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvOutOfStock.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub showProductStockOutDashboard()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT CONCAT(product_name,' ',prod_variant, ' ',size,' ',container) as PRODUCT, quantity as QUANTITY " +
                "FROM tblproducts WHERE quantity < 20"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvOut.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Public Sub showSupplierDetails()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT supplier_id as SUPPLIER_ID, supplier_name as SUPPLIER_NAME, supplier_address as ADDRESS, supplier_contact_number as CONTACT_NUMBER FROM tblsupplier"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSupplierDetails.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSupplierDetailsSearch()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT supplier_id as SUPPLIER_ID, supplier_name as SUPPLIER_NAME, supplier_address as ADDRESS, supplier_contact_number as CONTACT_NUMBER FROM tblsupplier WHERE supplier_id LIKE @search OR supplier_name LIKE @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtSearchSupplierDetails.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSupplierDetails.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showCustomerDetails()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT customer_id as CUSTOMER_ID, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME, CONCAT(house_number, ' ', street_name, ' Barangay ', barangay, ' ', city) as ADDRESS, contact_number as CONTACT_NUMBER FROM tblcustomer WHERE NOT customer_id = 6"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvCustomerList.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showCustomerDetailsSearch()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT customer_id as CUSTOMER_ID, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME, CONCAT(house_number, ' ', street_name, ' Barangay ', barangay, ' ', city) as ADDRESS, contact_number as CONTACT_NUMBER FROM tblcustomer WHERE (NOT customer_id = 6) AND (customer_id LIKE @search OR first_name LIKE @search OR middle_name LIKE @search OR last_name LIKE @search)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtCustomerSearch.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvCustomerList.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showEmployeeDetails()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT employee_id as EMPLOYEE_ID, username as USERNAME, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME, contact_number as CONTACT_NUMBER , user_level as USER_LEVEL FROM tblemployees WHERE NOT user_level = 'admin'"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvEmployeeList.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showEmployeeDetailsSearch()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT employee_id as EMPLOYEE_ID, username as USERNAME, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME, contact_number as CONTACT_NUMBER , user_level as USER_LEVEL FROM tblemployees WHERE (NOT user_level = 'admin') AND (employee_id LIKE @search OR first_name LIKE @search OR middle_name LIKE @search OR last_name LIKE @search OR username LIKE @search)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmMain.txtEmployeeSearch.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvEmployeeList.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showEmployeeLogs()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblapplogs.logs_id as LOG_ID, tblemployees.username as USERNAME, CONCAT(tblemployees.first_name, ' ', tblemployees.middle_name, ' ', tblemployees.last_name) as NAME, log_datetime as DATE_TIME from tblapplogs INNER JOIN tblemployees ON tblapplogs.employee_id = tblemployees.employee_id WHERE NOT tblapplogs.employee_id = 4 ORDER BY tblapplogs.logs_id DESC LIMIT 30"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvEmployeeLogs.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showPOSProductDetailsSoda()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT product_id as PRODUCT_ID, product_name as PRODUCT_NAME, prod_variant as VARIANT, size as SIZE_in_mL, container as CONTAINER , price as PRICE, quantity as STOCK FROM tblproducts WHERE category = 'Non-Alcoholic'"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.dgvSoda.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showPOSProductDetailsLiquor()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT product_id as PRODUCT_ID, product_name as PRODUCT_NAME, prod_variant as VARIANT, size as SIZE_in_mL, container as CONTAINER , price as PRICE, quantity as STOCK FROM tblproducts WHERE NOT category = 'Non-Alcoholic'"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.dgvLiquor.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showPOSCustomerDetails()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT customer_id as CUSTOMER_ID, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME FROM tblcustomer  WHERE NOT customer_id = 6"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.dgvPOSCustomer.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showPOSCustomerSearchDetails()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT customer_id as CUSTOMER_ID, CONCAT(first_name, ' ', middle_name, ' ', last_name) as NAME FROM tblcustomer  WHERE (NOT customer_id = 6) AND (customer_id LIKE @search OR first_name LIKE @search OR middle_name LIKE @search OR last_name LIKE @search)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmPOS.txtSearchCustomer.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.dgvPOSCustomer.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub showSalesHistory()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id ORDER BY  tbltransaction.transaction_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryEmpID()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE tbltransaction.employee_id = @emp_id"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("emp_id", frmMain.cboEmployeeID.Text)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryDay()

        getMonthNumber()
        Dim datefilter As String = frmMain.cboYear.Text.ToString + "-" + monthnumber + "-" + frmMain.cboDay.Text.ToString
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE DATE(tbltransaction.date_time) = @day"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("day", datefilter)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryCustom()

        getMonthNumber()
        Dim datefilter As String = frmMain.cboYear.Text.ToString + "-" + monthnumber + "-" + frmMain.cboDay.Text.ToString
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE (DATE(tbltransaction.date_time) BETWEEN @from AND @to)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("from", frmMain.dtpFrom.Value.ToString(" yyyy-MM-dd"))
            com.Parameters.AddWithValue("to", frmMain.dtpUntil.Value.ToString(" yyyy-MM-dd"))
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            from_temp = frmMain.dtpFrom.Value.ToString(" yyyy-MM-dd")
            to_temp = frmMain.dtpUntil.Value.ToString(" yyyy-MM-dd")
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryMonth()

        getMonthNumber()

        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE MONTH(tbltransaction.date_time) = @month AND YEAR(tbltransaction.date_time) = @year"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("month", monthnumber)
            com.Parameters.AddWithValue("year", frmMain.cboYear.Text)

            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryYear()
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE YEAR(tbltransaction.date_time) = @year"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("year", frmMain.cboYear.Text)

            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showSalesHistoryAll()

        getMonthNumber()
        Dim datefilter As String = frmMain.cboYear.Text.ToString + "-" + monthnumber + "-" + frmMain.cboDay.Text.ToString
        Dim dtable As New DataTable

        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tbltransaction.transaction_id as TRANSACTION_ID, tbltransaction.totaldue as TOTAL_AMOUNT, CONCAT(tblemployees.first_name,' ', tblemployees.middle_name, ' ' ,tblemployees.last_name) AS EMPLOYEE_NAME, CONCAT(tblcustomer.first_name , ' ',tblcustomer.middle_name ,' ' , tblcustomer.last_name) AS CUSTOMER_NAME, DATE(tbltransaction.date_time) as DATE FROM (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) INNER JOIN tblcustomer ON tbltransaction.customer_id = tblcustomer.customer_id WHERE DATE(tbltransaction.date_time) = @day AND tbltransaction.employee_id = @emp_id"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("day", datefilter)
            com.Parameters.AddWithValue("emp_id", frmMain.cboEmployeeID.Text)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvSalesHistory.DataSource = dtable
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductSearchPOS()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT product_id as PRODUCT_ID, product_name as PRODUCT_NAME, prod_variant as VARIANT, size as SIZE_in_mL, container as CONTAINER , price as PRICE, quantity as STOCK FROM tblproducts WHERE tblproducts.product_id LIKE @search OR tblproducts.product_name LIKE @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", "%" + frmPOS.txtSearchPOS.Text + "%")
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmPOS.dgvSearch.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showProductDetailsbySupplier()
        getSupplierIDBy()

        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT product_id as PRODUCT_ID, product_name as NAME, tblproducts.prod_variant as VARIANT, size as SIZE_in_ml, container as CONTAINER_TYPE," +
                " tblproducts.price as PRICE, tblproducts.category as CATEGORY, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts WHERE supplier_id = @search"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", selectedsupplier)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmMain.dgvProductsBySupplier.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub showTransactionVoid()
        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as PRODUCT_NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_mL, tblproducts.container as CONTAINER , tblproducts.price as PRICE, tblorders.quantity as QUANTITY FROM tblorders INNER JOIN tblproducts ON tblorders.product_id = tblproducts.product_id WHERE (tblorders.transaction_id = @search)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("search", frmVoid.txtSearchTrans.Text)
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            frmVoid.dgvVoid.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


End Module
