Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshDGVs()

        cboDay.Enabled = False
        cboMonth.Enabled = False
        cboYear.Enabled = False
        cboEmployeeID.Enabled = False
        loadDailySalesLineGraph()
        loadPopularProductsBarGraph()
        loadMonthlySalesLineGraph()


    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlReports.Visible = False
        pnlSales.Visible = False
        pnlSettings.Visible = False
        pnlEmployees.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False

        pnlProducts.Visible = True

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        pnlSuppliers.Visible = False
        pnlReports.Visible = False
        pnlSales.Visible = False
        pnlSettings.Visible = False
        pnlEmployees.Visible = False
        pnlProducts.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlCustomers.Visible = True
        refreshDGVs()


    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click

        pnlReports.Visible = False
        pnlSales.Visible = False
        pnlSettings.Visible = False
        pnlEmployees.Visible = False
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlSuppliers.Visible = True
        refreshDGVs()

    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click

        pnlReports.Visible = False
        pnlSales.Visible = False
        pnlSettings.Visible = False
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlEmployees.Visible = True
        refreshDGVs()

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        pnlReports.Visible = False
        pnlSettings.Visible = False
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlSales.Visible = True
        refreshDGVs()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        pnlSettings.Visible = False
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        pnlSales.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlReports.Visible = True
        refreshDGVs()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        pnlSales.Visible = False
        pnlReports.Visible = False
        Panel2.Visible = False
        pnlDashboard.Visible = False
        pnlSettings.Visible = True
        refreshDGVs()

    End Sub

    Private Sub pbxExit_Click(sender As Object, e As EventArgs) Handles pbxExit.Click

        Dim response
        response = MessageBox.Show("Are you sure you want to exit?", "Exit Admin", MessageBoxButtons.YesNo)
        If response = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub


    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim exists As Boolean = False
        If txtSupplierNameDetails.Text = "" Or txtSupplierContactDetails.Text = "" Or txtSupplierAddressDetails.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            Do
                generateSupplierID()
                Try
                    openConn()
                    Dim theQuery As String = "SELECT * FROM tblsupplier WHERE supplier_id = @sup"
                    Dim cmd1 As New MySqlCommand
                    cmd1.Connection = conn
                    cmd1.CommandText = theQuery
                    cmd1.Parameters.AddWithValue("sup", idsuppliergeneration)

                    Using rdr As MySqlDataReader = cmd1.ExecuteReader
                        If rdr.HasRows Then
                            suppliernum += 1
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
            addSupplierDetails()
            refreshDGVs()
            AddSupplierClear()
        End If
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
            addCustomerDetails()
            refreshDGVs()
            AddCustomerClear()
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim exists As Boolean = False
        If cboProdName.Text = "" Or cboVariant.Text = "" Or txtProductPrice.Text = "" Or cboSize.Text = "" Or cboContainer.Text = "" Or cboCategory.Text = "" Or cboSupplier.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            Do
                generateID()
                Try
                    openConn()
                    Dim theQuery As String = "SELECT * FROM tblproducts WHERE product_id = @prod"
                    Dim cmd1 As New MySqlCommand
                    cmd1.Connection = conn
                    cmd1.CommandText = theQuery
                    cmd1.Parameters.AddWithValue("prod", txtProductID.Text)

                    Using rdr As MySqlDataReader = cmd1.ExecuteReader
                        If rdr.HasRows Then
                            tries += 1
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

            addProductDetails()
            refreshDGVs()
            AddProductClear()

        End If

        tries = 0

    End Sub

    Private Sub generateCustomerID()
        Dim yearstring As String = Date.Now.Year.ToString
        Dim cusnumstr As String = customernum.ToString.PadLeft(4, "0")
        idcustomergeneration = yearstring + cusnumstr
    End Sub

    Private Sub generateSupplierID()
        Dim yearstring As String = Date.Now.Year.ToString
        Dim supnumstr As String = suppliernum.ToString.PadLeft(4, "0")
        idsuppliergeneration = yearstring + supnumstr
    End Sub

    Private Sub generateID()
        Dim pname As String = cboProdName.Text.Trim
        Dim size As String = cboSize.Text.Trim
        Dim var As String = cboVariant.Text.Trim
        Dim supp As String = cboSupplier.Text.Trim
        Dim num1 As String = tries.ToString


        pname = pname.Replace(" ", "")
        size = size.Replace(" ", "")
        var = var.Replace(" ", "")
        supp = supp.Replace(" ", "")

        pname = pname.PadRight(4, "R")
        size = size.PadRight(4, "R")
        var = var.PadRight(2, "R")
        supp = supp.PadRight(2, "R")
        num1 = num1.PadLeft(2, "0")

        idgeneration = pname.Substring(0, 4) + size + var.Substring(0, 2) + supp.Substring(0, 2) + num1
        idgeneration = idgeneration.ToUpper
        txtProductID.Text = idgeneration
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        If txtProductIDAddStock.Text = "" Or txtQuantityAddStock.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addProductStockHistory()
            getProductQuantity()
            addStockProduct()
            AddStockClear()
            refreshDGVs()
            MsgBox("Stock successfully added!", MsgBoxStyle.Information, "Stock Added")
        End If
    End Sub


    Private Sub dgvAddStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddStock.CellClick
        Dim i As Integer
        With dgvAddStock
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtProductIDAddStock.Text = .Rows(i).Cells(0).Value.ToString()
            End If
        End With
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click

        btnDeleteCustomer.Text = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo)
        If btnDeleteCustomer.Text = DialogResult.Yes Then
            btnDeleteCustomer.Text = "DELETE"
            deleteCustomerDetails()
            refreshDGVs()
            MsgBox("Customer successfully deleted!", MsgBoxStyle.Information, "Customer Deleted")

        Else
            btnDeleteCustomer.Text = "DELETE"
        End If
        AddCustomerClear()

    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        btnDeleteProduct.Text = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo)
        If btnDeleteProduct.Text = DialogResult.Yes Then
            btnDeleteProduct.Text = "DELETE"
            deleteProductDetails()
            refreshDGVs()
            MsgBox("Product successfully deleted!", MsgBoxStyle.Information, "Product Deleted")
        Else
            btnDeleteProduct.Text = "DELETE"
        End If
        AddProductClear()

    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        btnDeleteSupplier.Text = MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Supplier", MessageBoxButtons.YesNo)
        If btnDeleteSupplier.Text = DialogResult.Yes Then
            btnDeleteSupplier.Text = "DELETE"
            deleteSupplierDetails()
            refreshDGVs()
            MsgBox("Supplier successfully deleted!", MsgBoxStyle.Information, "Supplier Deleted")
        Else
            btnDeleteSupplier.Text = "DELETE"
        End If
        AddSupplierClear()
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        If dgvProductsProductList.SelectedRows.Count > 0 Then
            If btnUpdateProduct.Text = "SAVE" Then
                If txtProductID.Text = "" Or cboProdName.Text = "" Or cboVariant.Text = "" Or txtProductPrice.Text = "" Or cboSize.Text = "" Or cboContainer.Text = "" Or cboCategory.Text = "" Or cboSupplier.Text = "" Then
                    MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateProductDetails()
                    refreshDGVs()
                    AddProductClear()
                End If
            Else
                txtProductID.Text = dgvProductsProductList.SelectedRows(0).Cells("PRODUCT_ID").Value.ToString
                cboProdName.Text = dgvProductsProductList.SelectedRows(0).Cells("NAME").Value.ToString
                cboVariant.Text = dgvProductsProductList.SelectedRows(0).Cells("VARIANT").Value.ToString
                cboSize.Text = dgvProductsProductList.SelectedRows(0).Cells("SIZE_in_ml").Value.ToString
                cboContainer.Text = dgvProductsProductList.SelectedRows(0).Cells("CONTAINER_TYPE").Value.ToString
                txtProductPrice.Text = dgvProductsProductList.SelectedRows(0).Cells("PRICE").Value.ToString
                cboCategory.Text = dgvProductsProductList.SelectedRows(0).Cells("CATEGORY").Value.ToString
                cboSupplier.Text = dgvProductsProductList.SelectedRows(0).Cells("SUPPLIER").Value.ToString
                btnAddProduct.Enabled = False
                txtProductID.Enabled = False
                btnDeleteProduct.Enabled = True
                btnUpdateProduct.Text = "SAVE"
            End If
        End If
    End Sub


    Private Sub btnUpdateSupplier_Click(sender As Object, e As EventArgs) Handles btnUpdateSupplier.Click

        If dgvSupplierDetails.SelectedRows.Count > 0 Then
            If btnUpdateSupplier.Text = "SAVE" Then
                If txtSupplierNameDetails.Text = "" Or txtSupplierContactDetails.Text = "" Or txtSupplierAddressDetails.Text = "" Then
                    MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateSupplierDetails()
                    refreshDGVs()
                    AddSupplierClear()
                End If
            Else
                txtSupplierID.Text = dgvSupplierDetails.SelectedRows(0).Cells("SUPPLIER_ID").Value.ToString
                txtSupplierNameDetails.Text = dgvSupplierDetails.SelectedRows(0).Cells("SUPPLIER_NAME").Value.ToString
                txtSupplierContactDetails.Text = dgvSupplierDetails.SelectedRows(0).Cells("CONTACT_NUMBER").Value.ToString
                txtSupplierAddressDetails.Text = dgvSupplierDetails.SelectedRows(0).Cells("ADDRESS").Value.ToString
                supplier_id = dgvSupplierDetails.SelectedRows(0).Cells("SUPPLIER_ID").Value.ToString
                btnAddSupplier.Enabled = False
                btnDeleteSupplier.Enabled = True
                btnUpdateSupplier.Text = "SAVE"
            End If
        End If

    End Sub



    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click

        If dgvCustomerList.SelectedRows.Count > 0 Then
            If btnUpdateCustomer.Text = "SAVE" Then
                If txtCustomerID.Text = "" Or txtFirstNameCustomer.Text = "" Or txtLastNameCustomer.Text = "" Or txtHouseNoCustomer.Text = "" Or txtStreetCustomer.Text = "" Or txtBarangayCustomer.Text = "" Or txtContactCustomer.Text = "" Or txtMunicipalityCustomer.Text = "" Then
                    MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateCustomerDetails()
                    refreshDGVs()
                    AddCustomerClear()
                End If
            Else
                getCustomerDetails()
                txtCustomerID.Text = dgvCustomerList.SelectedRows(0).Cells("CUSTOMER_ID").Value.ToString
                txtFirstNameCustomer.Text = fname
                txtMiddleNameCustomer.Text = mname
                txtLastNameCustomer.Text = lname
                txtContactCustomer.Text = contact
                txtHouseNoCustomer.Text = houseno
                txtStreetCustomer.Text = stname
                txtBarangayCustomer.Text = brgy
                txtMunicipalityCustomer.Text = city
                txtCustomerID.Enabled = False
                btnAddCustomer.Enabled = False
                btnDeleteCustomer.Enabled = True
                btnUpdateCustomer.Text = "SAVE"
            End If
        End If

    End Sub


    Private Sub btnClearProductDetails_Click(sender As Object, e As EventArgs) Handles btnClearProductDetails.Click
        AddProductClear()
        refreshDGVs()
    End Sub

    Private Sub btnClearSupplier_Click(sender As Object, e As EventArgs) Handles btnClearSupplier.Click
        AddSupplierClear()
        refreshDGVs()
    End Sub

    Private Sub btnClearCustomer_Click(sender As Object, e As EventArgs) Handles btnClearCustomer.Click
        AddCustomerClear()
        refreshDGVs()
    End Sub


    Private Sub dgvProductListDefect_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductListDefect.CellClick
        Dim i As Integer
        With dgvProductListDefect
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtProductNameDefect.Text = .Rows(i).Cells(0).Value.ToString()
                txtSupplierDefect.Text = .Rows(i).Cells(6).Value.ToString()
            End If
        End With
    End Sub

    Private Sub btnAddDefectiveDetails_Click(sender As Object, e As EventArgs) Handles btnAddDefectiveDetails.Click
        If txtProductNameDefect.Text = "" Or txtSupplierDefect.Text = "" Or txtRemarksDefect.Text = "" Or txtQuantityDefect.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            getProductQuantityDefection()
            If selectedproductquantity < txtQuantityDefect.Text Then
                MsgBox("The quantity cannot be bigger than the number of product in stock!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                AddDefectedItem()
                deductStockProduct()
                DefectProductClear()
                refreshDGVs()
                MsgBox("Product successfully added to the defective list!", MsgBoxStyle.Information, "Defective Product Added")
            End If
        End If
    End Sub

    Private Sub btnClearDefectiveDetails_Click(sender As Object, e As EventArgs) Handles btnClearDefectiveDetails.Click
        DefectProductClear()
        refreshDGVs()
    End Sub

    Private Sub btnClearStockIn_Click(sender As Object, e As EventArgs) Handles btnClearStockIn.Click
        AddStockClear()
        refreshDGVs()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If txtEmployeeFirstName.Text = "" Or txtEmployeeLastName.Text = "" Or txtEmployeeUsername.Text = "" Or txtEmployeePassword.Text = "" Or txtEmployeeContactNo.Text = "" Or cboUserLevel.Text = "" Or cboSecurityQuestion.Text = "" Or txtSecurityAnswer.Text = "" Then
            MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addEmployeeDetails()
            refreshDGVs()
            AddEmployeeClear()
            MsgBox("Employee successfully added!", MsgBoxStyle.Information, "Employee Added")
        End If

    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click

        btnDeleteEmployee.Text = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo)
        If btnDeleteEmployee.Text = DialogResult.Yes Then
            btnDeleteEmployee.Text = "DELETE"
            deleteEmployeeDetails()
            refreshDGVs()
            MsgBox("Employee successfully deleted!", MsgBoxStyle.Information, "Employee Deleted")
        Else
            btnDeleteEmployee.Text = "DELETE"
        End If
        AddEmployeeClear()
    End Sub

    Private Sub btnClearEmployee_Click(sender As Object, e As EventArgs) Handles btnClearEmployee.Click
        AddEmployeeClear()
        refreshDGVs()
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click


        If dgvEmployeeList.SelectedRows.Count > 0 Then
            If btnUpdateEmployee.Text = "SAVE" Then
                If txtEmployeeFirstName.Text = "" Or txtEmployeeLastName.Text = "" Or txtEmployeeUsername.Text = "" Or txtEmployeePassword.Text = "" Or txtEmployeeContactNo.Text = "" Or cboUserLevel.Text = "" Or cboSecurityQuestion.Text = "" Or txtSecurityAnswer.Text = "" Then
                    MsgBox("The fields are incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateEmployeeDetails()
                    refreshDGVs()
                    AddEmployeeClear()
                End If
            Else
                getEmployeeDetails()
                cboUserLevel.Text = ulevel
                txtEmployeeFirstName.Text = efname
                txtEmployeeMiddleName.Text = emname
                txtEmployeeLastName.Text = elname
                txtEmployeeContactNo.Text = econtact
                txtEmployeeUsername.Text = username
                txtEmployeePassword.Text = password
                txtSecurityAnswer.Text = secan
                cboSecurityQuestion.Text = secq
                btnUpdateEmployee.Text = "SAVE"
                btnAddEmployee.Enabled = False
                btnDeleteEmployee.Enabled = True
            End If
        End If

    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged

        dtpUntil.MaxDate = Date.Today
        dtpFrom.MaxDate = Date.Today

        cboDay.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        cboMonth.SelectedIndex = -1
        cboEmployeeID.SelectedIndex = -1

        dtpFrom.Visible = False
        dtpUntil.Visible = False
        lblDtp.Visible = False
        lblDtpFrom.Visible = False

        If cboFilter.Text = "Employee" Then
            cboDay.Enabled = False
            cboMonth.Enabled = False
            cboYear.Enabled = False
            cboEmployeeID.Enabled = True

            filtercondition = 1
        ElseIf cboFilter.Text = "Day" Then
            cboDay.Enabled = True
            cboMonth.Enabled = True
            cboYear.Enabled = True
            cboEmployeeID.Enabled = False
            filtercondition = 2
        ElseIf cboFilter.Text = "Month" Then
            cboDay.Enabled = False
            cboMonth.Enabled = True
            cboYear.Enabled = True
            cboEmployeeID.Enabled = False
            filtercondition = 3
        ElseIf cboFilter.Text = "Year" Then
            cboDay.Enabled = False
            cboMonth.Enabled = False
            cboYear.Enabled = True
            cboEmployeeID.Enabled = False
            filtercondition = 4
        ElseIf cboFilter.Text = "All filter" Then
            cboDay.Enabled = True
            cboMonth.Enabled = True
            cboYear.Enabled = True
            cboEmployeeID.Enabled = True
            filtercondition = 5
        ElseIf cboFilter.Text = "None" Then
            cboDay.Enabled = False
            cboMonth.Enabled = False
            cboYear.Enabled = False
            cboEmployeeID.Enabled = False
            filtercondition = 9
        ElseIf cboFilter.Text = "Custom" Then
            cboDay.Enabled = False
            cboMonth.Enabled = False
            cboYear.Enabled = False
            cboEmployeeID.Enabled = False
            dtpFrom.Visible = True
            dtpUntil.Visible = True
            lblDtp.Visible = True
            lblDtpFrom.Visible = True
            filtercondition = 6
        Else
            cboDay.Enabled = False
            cboMonth.Enabled = False
            cboYear.Enabled = False
            cboEmployeeID.Enabled = False
            filtercondition = 0
        End If
    End Sub

    Private Sub btnSearchSalesRecord_Click(sender As Object, e As EventArgs) Handles btnSearchSalesRecord.Click
        If filtercondition = 1 Then
            If cboEmployeeID.Text = "" Then
                MsgBox("Filter value incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                showSalesHistoryEmpID()
            End If
        ElseIf filtercondition = 2 Then
            If cboDay.Text = "" Or cboMonth.Text = "" Or cboYear.Text = "" Then
                MsgBox("Filter value incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                showSalesHistoryDay()
            End If
        ElseIf filtercondition = 3 Then
            If cboMonth.Text = "" Or cboYear.Text = "" Then
                MsgBox("Filter value incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                showSalesHistoryMonth()
            End If
        ElseIf filtercondition = 4 Then
            If cboYear.Text = "" Then
                MsgBox("Filter value incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                showSalesHistoryYear()
            End If
        ElseIf filtercondition = 5 Then
            If cboDay.Text = "" Or cboMonth.Text = "" Or cboYear.Text = "" Or cboEmployeeID.Text = "" Then
                MsgBox("Filter value incomplete!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                showSalesHistoryAll()
            End If
        ElseIf filtercondition = 6 Then
            showSalesHistoryCustom()
        Else
            MsgBox("Please select a filter!", vbOKOnly + MsgBoxStyle.Critical, "")
        End If
    End Sub

    Private Sub pbxRefreshSalesHistory_Click(sender As Object, e As EventArgs) Handles pbxRefreshSalesHistory.Click
        showSalesHistory()
        cboFilter.SelectedIndex = -1
        cboDay.SelectedIndex = -1
        cboYear.SelectedIndex = -1
        cboMonth.SelectedIndex = -1
        cboEmployeeID.SelectedIndex = -1
        dgvSalesHistory.ClearSelection()
        cboDay.Enabled = False
        cboMonth.Enabled = False
        cboYear.Enabled = False
        cboEmployeeID.Enabled = False

        dtpFrom.Visible = False
        dtpUntil.Visible = False
        lblDtp.Visible = False
        lblDtpFrom.Visible = False
        filtercondition = 0
    End Sub

    Private Sub btnPrintPreviewSalesRecord_Click(sender As Object, e As EventArgs) Handles btnPrintPreviewSalesRecord.Click

        If dgvSalesHistory.RowCount > 0 Then
            If Not filtercondition = 1 And Not filtercondition = 2 And Not filtercondition = 3 And Not filtercondition = 4 And Not filtercondition = 5 And Not filtercondition = 6 Then
                Dim dtable As New DataTable
                Dim columnsum As Double

                Try
                    openConn()
                    com.Connection = conn
                    com.CommandText = "SELECT transaction_ID, totaldue, date_time FROM tbltransaction"
                    com.ExecuteNonQuery()
                    adapter.SelectCommand = com
                    dtable.Clear()
                    adapter.Fill(dtable)
                    dgvReports.DataSource = dtable
                    For Each row In dgvReports.Rows
                        columnsum += Decimal.Parse(row.Cells(1).value)
                    Next
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                    dtable = New DataTable
                    With dtable
                        .Columns.Add("TransactionID")
                        .Columns.Add("TotalAmount")
                        .Columns.Add("TransactionDate")
                        .Columns.Add("TotalSales")
                    End With
                    For Each dr As DataGridViewRow In dgvReports.Rows
                        dtable.Rows.Add(dr.Cells(0).Value, "P" + Format(Decimal.Parse(dr.Cells(1).Value), "0.00"), FormatDateTime(dr.Cells(2).Value.ToString, DateFormat.ShortDate), "P" + Format(Decimal.Parse(columnsum), "0.00"))
                    Next
                    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New rptSalesReport
                    rptDoc.SetDataSource(dtable)
                    frmProductsReport.CrystalReportViewer1.ReportSource = rptDoc
                    frmProductsReport.ShowDialog()
                    frmProductsReport.Dispose()
                End Try
            Else
                Dim columnsum As Decimal
                Dim filtertype As String
                Dim dt As New DataTable
                With dt
                    .Columns.Add("TransactionID")
                    .Columns.Add("TotalAmount")
                    .Columns.Add("EmployeeName")
                    .Columns.Add("CustomerName")
                    .Columns.Add("TransactionDate")
                    .Columns.Add("TotalSales")
                    .Columns.Add("FilterType")
                End With
                For Each row In dgvSalesHistory.Rows
                    columnsum += Decimal.Parse(row.Cells(1).value)
                Next
                If filtercondition = 1 Then
                    filtertype = "Filter type: Employee          Value: " + dgvSalesHistory.Rows(0).Cells(2).Value.ToString
                ElseIf filtercondition = 2 Then
                    filtertype = "Filter type: Day          Value: " + cboMonth.Text.ToString + " " + cboDay.Text.ToString + "," + cboYear.Text.ToString
                ElseIf filtercondition = 3 Then
                    filtertype = "Filter type: Month          Value: " + cboMonth.Text.ToString + " " + cboYear.Text.ToString
                ElseIf filtercondition = 4 Then
                    filtertype = "Filter type: Year          Value: " + cboYear.Text.ToString
                ElseIf filtercondition = 5 Then
                    filtertype = "Filter type: All filter          Value: " + dgvSalesHistory.Rows(0).Cells(2).Value.ToString + " " + cboMonth.Text.ToString + " " + cboDay.Text.ToString + "," + cboYear.Text.ToString
                ElseIf filtercondition = 6 Then
                    filtertype = "Filter type: Custom          Value: " + from_temp + " to " + to_temp
                Else
                    filtertype = "Filter type: None"
                End If

                For Each dr As DataGridViewRow In dgvSalesHistory.Rows
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, FormatDateTime(dr.Cells(4).Value.ToString, DateFormat.ShortDate), columnsum.ToString, filtertype)
                Next

                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New rptSalesHistory
                rptDoc.SetDataSource(dt)
                frmSalesHistory.CrystalReportViewer1.ReportSource = rptDoc
                frmSalesHistory.ShowDialog()
                frmSalesHistory.Dispose()
            End If

        Else
            MsgBox("The result is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        End If


    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        btnBackUp.Text = MessageBox.Show("Do you want to back-up the database?", "BACK-UP DATABASE", MessageBoxButtons.YesNo)
        If btnBackUp.Text = DialogResult.Yes Then
            btnBackUp.Text = "BACKUP DATABASE"
            Dim file As String
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                file = SaveFileDialog1.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump -u root --password= " &
            "-h localhost ""ambergrey_trading"" > """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Successfully created a backup database!", MsgBoxStyle.Information, "Backup Database")
            End If
        Else
            btnBackUp.Text = "BACKUP DATABASE"
        End If
    End Sub

    Private Sub pbxBackUp_Click(sender As Object, e As EventArgs) Handles pbxBackUp.Click
        btnBackUp.Text = MessageBox.Show("Do you want to create a backup database?", "Backup Database", MessageBoxButtons.YesNo)
        If btnBackUp.Text = DialogResult.Yes Then
            btnBackUp.Text = "BACKUP DATABASE"
            Dim file As String
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                file = SaveFileDialog1.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump -u root --password= " &
            "-h localhost ""ambergrey_trading"" > """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Successfully created a backup database!", MsgBoxStyle.Information, "Backup Database")
            End If
        Else
            btnBackUp.Text = "BACKUP DATABASE"
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        btnRestore.Text = MessageBox.Show("Do you want to restore database?", "Restore Database", MessageBoxButtons.YesNo)
        If btnRestore.Text = DialogResult.Yes Then
            btnRestore.Text = "RESTORE DATABASE"
            Dim OFD As FileDialog = New OpenFileDialog()
            Dim file As String
            OFD.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            If OFD.ShowDialog = DialogResult.OK Then
                file = OFD.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysql -u root --password= " &
                    "-h localhost ""ambergrey_trading"" < """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Database has been restored!", MsgBoxStyle.Information, "Restore Database")
            End If
        Else
            btnRestore.Text = "RESTORE DATABASE"
        End If
        refreshDGVs()

    End Sub

    Private Sub pbxRestore_Click(sender As Object, e As EventArgs) Handles pbxRestore.Click
        btnRestore.Text = MessageBox.Show("Do you want to restore database?", "Restore Database", MessageBoxButtons.YesNo)
        If btnRestore.Text = DialogResult.Yes Then
            btnRestore.Text = "RESTORE DATABASE"
            Dim OFD As FileDialog = New OpenFileDialog()
            Dim file As String
            OFD.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            If OFD.ShowDialog = DialogResult.OK Then
                file = OFD.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysql -u root --password= " &
                    "-h localhost ""ambergrey_trading"" < """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Database has been restored!", MsgBoxStyle.Information, "Restore Database")
            End If
        Else
            btnRestore.Text = "RESTORE DATABASE"
        End If

        refreshDGVs()

    End Sub

    Private Sub btnProductsReport_Click(sender As Object, e As EventArgs) Handles btnProductsReport.Click

        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                "tblproducts.category as CATEGORY, tblsupplier.supplier_name as SUPPLIER,  tblproducts.price as PRICE, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("ProductID")
                .Columns.Add("ProductName")
                .Columns.Add("Category")
                .Columns.Add("SupplierName")
                .Columns.Add("Price")
                .Columns.Add("Quantity")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "P" + Format(Decimal.Parse(dr.Cells(4).Value), "0.00"), dr.Cells(5).Value)
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptProductsReport
            rptDoc.SetDataSource(dtable)
            frmProductsReport.CrystalReportViewer1.ReportSource = rptDoc
            frmProductsReport.ShowDialog()
            frmProductsReport.Dispose()
        End Try
    End Sub

    Private Sub pbxProductsReport_Click(sender As Object, e As EventArgs) Handles pbxProductsReport.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                "tblproducts.category as CATEGORY, tblsupplier.supplier_name as SUPPLIER,  tblproducts.price as PRICE, tblproducts.quantity as QUANTITY " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("ProductID")
                .Columns.Add("ProductName")
                .Columns.Add("Category")
                .Columns.Add("SupplierName")
                .Columns.Add("Price")
                .Columns.Add("Quantity")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "P" + Format(Decimal.Parse(dr.Cells(4).Value), "0.00"), dr.Cells(5).Value)
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptProductsReport
            rptDoc.SetDataSource(dtable)
            frmProductsReport.CrystalReportViewer1.ReportSource = rptDoc
            frmProductsReport.ShowDialog()
            frmProductsReport.Dispose()
        End Try
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs)
        Dim dtable As New DataTable
        Dim columnsum As Double

        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT transaction_ID, totaldue, date_time FROM tbltransaction"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
            For Each row In dgvReports.Rows
                columnsum += Decimal.Parse(row.Cells(1).value)
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("TransactionID")
                .Columns.Add("TotalAmount")
                .Columns.Add("TransactionDate")
                .Columns.Add("TotalSales")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, "P" + Format(Decimal.Parse(dr.Cells(1).Value), "0.00"), FormatDateTime(dr.Cells(2).Value.ToString, DateFormat.ShortDate), "P" + Format(Decimal.Parse(columnsum), "0.00"))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptSalesReport
            rptDoc.SetDataSource(dtable)
            frmProductsReport.CrystalReportViewer1.ReportSource = rptDoc
            frmProductsReport.ShowDialog()
            frmProductsReport.Dispose()
        End Try
    End Sub

    Private Sub pbxSalesReport_Click(sender As Object, e As EventArgs)
        Dim dtable As New DataTable
        Dim columnsum As Double

        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT transaction_ID, totaldue, date_time FROM tbltransaction"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
            For Each row In dgvReports.Rows
                columnsum += Decimal.Parse(row.Cells(1).value)
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("TransactionID")
                .Columns.Add("TotalAmount")
                .Columns.Add("TransactionDate")
                .Columns.Add("TotalSales")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, "P" + Format(Decimal.Parse(dr.Cells(1).Value), "0.00"), FormatDateTime(dr.Cells(2).Value.ToString, DateFormat.ShortDate), "P" + Format(Decimal.Parse(columnsum), "0.00"))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptSalesReport
            rptDoc.SetDataSource(dtable)
            frmSalesReport.CrystalReportViewer1.ReportSource = rptDoc
            frmSalesReport.ShowDialog()
            frmSalesReport.Dispose()
        End Try
    End Sub

    Private Sub btnStockInReports_Click(sender As Object, e As EventArgs) Handles btnStockInReports.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblstockin.stock_id as STOCK_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tblsupplier.supplier_name as SUPPLIER, tblstockin.quantity as QUANTITY, tblstockin.date_added as DATE_ADDED " +
                "FROM (tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id)  INNER JOIN tblstockin ON tblproducts.product_id = tblstockin.product_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("StockID")
                .Columns.Add("StockName")
                .Columns.Add("SupplierName")
                .Columns.Add("Quantity")
                .Columns.Add("DateStock")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, FormatDateTime(dr.Cells(4).Value.ToString, DateFormat.ShortDate))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptStockHistory
            rptDoc.SetDataSource(dtable)
            frmStockInHistory.CrystalReportViewer1.ReportSource = rptDoc
            frmStockInHistory.ShowDialog()
            frmStockInHistory.Dispose()
        End Try
    End Sub

    Private Sub pbxStockInHistory_Click(sender As Object, e As EventArgs) Handles pbxStockInHistory.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblstockin.stock_id as STOCK_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tblsupplier.supplier_name as SUPPLIER, tblstockin.quantity as QUANTITY, tblstockin.date_added as DATE_ADDED " +
                "FROM (tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id)  INNER JOIN tblstockin ON tblproducts.product_id = tblstockin.product_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("StockID")
                .Columns.Add("StockName")
                .Columns.Add("SupplierName")
                .Columns.Add("Quantity")
                .Columns.Add("DateStock")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, FormatDateTime(dr.Cells(4).Value.ToString, DateFormat.ShortDate))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptStockHistory
            rptDoc.SetDataSource(dtable)
            frmStockInHistory.CrystalReportViewer1.ReportSource = rptDoc
            frmStockInHistory.ShowDialog()
            frmStockInHistory.Dispose()
        End Try
    End Sub

    Private Sub btnStockOutReports_Click(sender As Object, e As EventArgs) Handles btnStockOutReports.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tblproducts.quantity, tblsupplier.supplier_name as SUPPLIER " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id WHERE tblproducts.quantity < 20"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("ProductID")
                .Columns.Add("ProductName")
                .Columns.Add("Quantity")
                .Columns.Add("SupplierName")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value)
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptStockOut
            rptDoc.SetDataSource(dtable)
            frmStockOut.CrystalReportViewer1.ReportSource = rptDoc
            frmStockOut.ShowDialog()
            frmStockOut.Dispose()
        End Try
    End Sub

    Private Sub pbxStockOutReport_Click(sender As Object, e As EventArgs) Handles pbxStockOutReport.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tblproducts.product_id as PRODUCT_ID, CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tblproducts.quantity, tblsupplier.supplier_name as SUPPLIER " +
                "FROM tblproducts INNER JOIN tblsupplier ON tblproducts.supplier_id = tblsupplier.supplier_id WHERE tblproducts.quantity < 20"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("ProductID")
                .Columns.Add("ProductName")
                .Columns.Add("Quantity")
                .Columns.Add("SupplierName")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value)
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptStockOut
            rptDoc.SetDataSource(dtable)
            frmStockOut.CrystalReportViewer1.ReportSource = rptDoc
            frmStockOut.ShowDialog()
            frmStockOut.Dispose()
        End Try
    End Sub

    Private Sub btnLossReport_Click(sender As Object, e As EventArgs) Handles btnLossReport.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tbldefective.defective_id as DEFECTION_ID,  CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tbldefective.defective_quantity as QUANTITY, tbldefective.defective_comment as COMMENT, tbldefective.defection_date as DEFECTION_DATE " +
                "FROM tblproducts INNER JOIN tbldefective ON tbldefective.product_id = tblproducts.product_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("DefectiveID")
                .Columns.Add("ProductName")
                .Columns.Add("Quantity")
                .Columns.Add("Remarks")
                .Columns.Add("DateLoss")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, FormatDateTime(dr.Cells(4).Value.ToString, DateFormat.ShortDate))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptProductLoss
            rptDoc.SetDataSource(dtable)
            frmProductLoss.CrystalReportViewer1.ReportSource = rptDoc
            frmProductLoss.ShowDialog()
            frmProductLoss.Dispose()
        End Try
    End Sub

    Private Sub pbxLossReport_Click(sender As Object, e As EventArgs) Handles pbxLossReport.Click
        Dim dtable As New DataTable
        Try
            openConn()
            com.Connection = conn
            com.CommandText = "SELECT tbldefective.defective_id as DEFECTION_ID,  CONCAT(tblproducts.product_name,' ',tblproducts.size,'ml ' , tblproducts.container) as NAME," +
                " tbldefective.defective_quantity as QUANTITY, tbldefective.defective_comment as COMMENT, tbldefective.defection_date as DEFECTION_DATE " +
                "FROM tblproducts INNER JOIN tbldefective ON tbldefective.product_id = tblproducts.product_id"
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvReports.DataSource = dtable
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dtable = New DataTable
            With dtable
                .Columns.Add("DefectiveID")
                .Columns.Add("ProductName")
                .Columns.Add("Quantity")
                .Columns.Add("Remarks")
                .Columns.Add("DateLoss")
            End With
            For Each dr As DataGridViewRow In dgvReports.Rows
                dtable.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, FormatDateTime(dr.Cells(4).Value.ToString, DateFormat.ShortDate))
            Next
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New rptProductLoss
            rptDoc.SetDataSource(dtable)
            frmProductLoss.CrystalReportViewer1.ReportSource = rptDoc
            frmProductLoss.ShowDialog()
            frmProductLoss.Dispose()
        End Try
    End Sub

    Private Sub btnEmployeeSearch_Click(sender As Object, e As EventArgs) Handles btnEmployeeSearch.Click
        If txtEmployeeSearch.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvEmployeeList.ClearSelection()
        Else
            showEmployeeDetailsSearch()
        End If
    End Sub

    Private Sub txtEmployeeSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeSearch.TextChanged
        If txtEmployeeSearch.Text = "" Then
            showEmployeeDetails()
        Else
            showEmployeeDetailsSearch()
        End If
    End Sub

    Private Sub txtSearchSupplierDetails_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplierDetails.TextChanged
        If txtSearchSupplierDetails.Text = "" Then
            showSupplierDetails()
        Else
            showSupplierDetailsSearch()
        End If
    End Sub

    Private Sub btnSearchSupplierDetails_Click(sender As Object, e As EventArgs) Handles btnSearchSupplierDetails.Click
        If txtSearchSupplierDetails.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvSupplierDetails.ClearSelection()
        Else
            showSupplierDetailsSearch()
        End If
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        If txtCustomerSearch.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvCustomerList.ClearSelection()
        Else
            showCustomerDetailsSearch()
        End If
    End Sub

    Private Sub txtCustomerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerSearch.TextChanged
        If txtCustomerSearch.Text = "" Then
            showCustomerDetails()
        Else
            showCustomerDetailsSearch()
        End If
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        If txtSearchProduct.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvProductsProductList.ClearSelection()
        Else
            showProductDetailsSearch()
        End If
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        If txtSearchProduct.Text = "" Then
            showProductDetails()
        Else
            showProductDetailsSearch()
        End If
    End Sub

    Private Sub btnSearchProductStockIn_Click(sender As Object, e As EventArgs) Handles btnSearchProductStockIn.Click
        If txtSearchProductStockIn.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvAddStock.ClearSelection()
        Else
            showProductDetailsStockInSearch()
        End If
    End Sub

    Private Sub txtSearchProductStockIn_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProductStockIn.TextChanged
        If txtSearchProductStockIn.Text = "" Then
            showProductDetailsStockIn()
        Else
            showProductDetailsStockInSearch()
        End If
    End Sub

    Private Sub txtSearchProductDefective_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProductDefective.TextChanged
        If txtSearchProductDefective.Text = "" Then
            showProductDefective()
        Else
            showProductDefectiveSearch()
        End If
    End Sub

    Private Sub btnSearchProductDefective_Click(sender As Object, e As EventArgs) Handles btnSearchProductDefective.Click
        If txtSearchProductDefective.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            dgvProductListDefect.ClearSelection()
        Else
            showProductDefectiveSearch()
        End If
    End Sub

    Private Sub btnDataAnalysis_Click(sender As Object, e As EventArgs) Handles btnDataAnalysis.Click
        frmDataAnalysis.ShowDialog()
        frmDataAnalysis.Dispose()

    End Sub


    Private Sub txtSize_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProductPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductPrice.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub


    Private Sub txtQuantityAddStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityAddStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtQuantityDefect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityDefect.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        pnlReports.Visible = False
        pnlSales.Visible = False
        pnlSettings.Visible = False
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        Panel2.Visible = True

    End Sub

    Private Sub btnProdNameAddVar_Click(sender As Object, e As EventArgs) Handles btnProdNameAddVar.Click
        If txtProdNameVar.Text = "" Then
            MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addProductName()
            refreshDGVs()
            AddProductNameClear()
        End If
    End Sub

    Private Sub btnProdNameUpdateVar_Click(sender As Object, e As EventArgs) Handles btnProdNameUpdateVar.Click


        If dgvProductName.SelectedRows.Count > 0 Then
            If btnProdNameUpdateVar.Text = "SAVE" Then
                If txtProdNameVar.Text = "" Then
                    MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateProductName()
                    refreshDGVs()
                    AddProductNameClear()
                End If
            Else
                getProductNameID()
                txtProdNameVar.Text = dgvProductName.SelectedRows(0).Cells("PRODUCT_NAME").Value.ToString
                btnProdNameAddVar.Enabled = False
                btnProdNameDeleteVar.Enabled = True
                btnProdNameUpdateVar.Text = "SAVE"
            End If
        End If
    End Sub

    Private Sub btnProdNameVarClear_Click(sender As Object, e As EventArgs) Handles btnProdNameVarClear.Click
        AddProductNameClear()
    End Sub

    Private Sub btnProdNameDeleteVar_Click(sender As Object, e As EventArgs) Handles btnProdNameDeleteVar.Click
        btnProdNameDeleteVar.Text = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo)
        If btnProdNameDeleteVar.Text = DialogResult.Yes Then
            btnProdNameDeleteVar.Text = "DELETE"
            deleteProductName()
            refreshDGVs()
            MsgBox("Product successfully deleted!", MsgBoxStyle.Information, "Product Deleted")

        Else
            btnProdNameDeleteVar.Text = "DELETE"
        End If
        AddProductNameClear()
    End Sub

    Private Sub btnAddVariant_Click(sender As Object, e As EventArgs) Handles btnAddVariant.Click
        If txtVariant.Text = "" Then
            MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addProductVariant()
            refreshDGVs()
            AddVariantClear()
        End If
    End Sub

    Private Sub btnUpdateVariant_Click(sender As Object, e As EventArgs) Handles btnUpdateVariant.Click


        If dgvVariants.SelectedRows.Count > 0 Then
            If btnUpdateVariant.Text = "SAVE" Then
                If txtVariant.Text = "" Then
                    MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateVariant()
                    refreshDGVs()
                    AddVariantClear()
                End If
            Else
                getVariantID()
                txtVariant.Text = dgvVariants.SelectedRows(0).Cells("VARIANT").Value.ToString
                btnAddVariant.Enabled = False
                btnDeleteVariant.Enabled = True
                btnUpdateVariant.Text = "SAVE"
            End If
        End If

    End Sub

    Private Sub btnDeleteVariant_Click(sender As Object, e As EventArgs) Handles btnDeleteVariant.Click
        btnDeleteVariant.Text = MessageBox.Show("Are you sure you want to delete this variant?", "Delete Variant", MessageBoxButtons.YesNo)
        If btnDeleteVariant.Text = DialogResult.Yes Then
            btnDeleteVariant.Text = "DELETE"
            deleteVariant()
            refreshDGVs()
            MsgBox("Variant successfully deleted!", MsgBoxStyle.Information, "Variant Deleted")

        Else
            btnDeleteVariant.Text = "DELETE"
        End If
        AddVariantClear()
    End Sub

    Private Sub btnClearVariant_Click(sender As Object, e As EventArgs) Handles btnClearVariant.Click
        AddVariantClear()
    End Sub

    Private Sub btnAddContainer_Click(sender As Object, e As EventArgs) Handles btnAddContainer.Click
        If txtContainerName.Text = "" Then
            MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addContainer()
            refreshDGVs()
            AddContainerClear()
        End If
    End Sub

    Private Sub btnUpdateContainer_Click(sender As Object, e As EventArgs) Handles btnUpdateContainer.Click


        If dgvContainer.SelectedRows.Count > 0 Then
            If btnUpdateContainer.Text = "SAVE" Then
                If txtContainerName.Text = "" Then
                    MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateContainer()
                    refreshDGVs()
                    AddContainerClear()
                End If
            Else
                getContainerID()
                txtContainerName.Text = dgvContainer.SelectedRows(0).Cells("CONTAINER").Value.ToString
                btnAddContainer.Enabled = False
                btnDeleteContainer.Enabled = True
                btnUpdateContainer.Text = "SAVE"
            End If
        End If

    End Sub

    Private Sub btnDeleteContainer_Click(sender As Object, e As EventArgs) Handles btnDeleteContainer.Click
        btnDeleteContainer.Text = MessageBox.Show("Are you sure you want to delete this container?", "Delete Container", MessageBoxButtons.YesNo)
        If btnDeleteContainer.Text = DialogResult.Yes Then
            btnDeleteContainer.Text = "DELETE"
            deleteContainer()
            refreshDGVs()
            MsgBox("Container successfully deleted!", MsgBoxStyle.Information, "Container Deleted")

        Else
            btnDeleteContainer.Text = "DELETE"
        End If
        AddContainerClear()
    End Sub

    Private Sub btnClearContainer_Click(sender As Object, e As EventArgs) Handles btnClearContainer.Click
        AddContainerClear()
    End Sub

    Private Sub btnAddSize_Click(sender As Object, e As EventArgs) Handles btnAddSize.Click
        If txtSizeVariable.Text = "" Then
            MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            addSize()
            refreshDGVs()
            AddSizeClear()
        End If
    End Sub

    Private Sub btnUpdateSize_Click(sender As Object, e As EventArgs) Handles btnUpdateSize.Click

        If dgvSize.SelectedRows.Count > 0 Then
            If btnUpdateSize.Text = "SAVE" Then
                If txtSizeVariable.Text = "" Then
                    MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateSize()
                    refreshDGVs()
                    AddSizeClear()
                End If
            Else
                getSizeID()
                txtSizeVariable.Text = dgvSize.SelectedRows(0).Cells("SIZE").Value.ToString
                btnAddSize.Enabled = False
                btnDeleteSize.Enabled = True
                btnUpdateSize.Text = "SAVE"
            End If
        End If
    End Sub

    Private Sub btnDeleteSize_Click(sender As Object, e As EventArgs) Handles btnDeleteSize.Click
        btnDeleteSize.Text = MessageBox.Show("Are you sure you want to delete this size?", "Delete Size", MessageBoxButtons.YesNo)
        If btnDeleteSize.Text = DialogResult.Yes Then
            btnDeleteSize.Text = "DELETE"
            deleteSize()
            refreshDGVs()
            MsgBox("Size successfully deleted!", MsgBoxStyle.Information, "Size Deleted")

        Else
            btnDeleteSize.Text = "DELETE"
        End If
        AddSizeClear()
    End Sub

    Private Sub btnClearSize_Click(sender As Object, e As EventArgs) Handles btnClearSize.Click
        AddSizeClear()
    End Sub

    Private Sub pbxReturnToSettings_Click(sender As Object, e As EventArgs) Handles pbxReturnToSettings.Click
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        pnlSales.Visible = False
        pnlReports.Visible = False
        Panel2.Visible = False
        pnlSettings.Visible = True
    End Sub

    Private Sub dtpFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFrom.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub dtpUntil_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpUntil.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnSearchProdBySupp_Click(sender As Object, e As EventArgs) Handles btnSearchProdBySupp.Click

        If Not cboSupplierBy.Text = "" Then
            showProductDetailsbySupplier()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cboSupplierBy.SelectedIndex = -1
        dgvProductsBySupplier.DataSource = Nothing
    End Sub

    Private Sub loadDailySalesLineGraph()
        Try
            With Chart5
                .Series.Clear()
                .Series.Add("Series5")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT DATE(date_time) as DAY, SUM(totaldue) AS TOTAL_SALES FROM tbltransaction GROUP BY DATE(date_time)"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Daily Sales")
            Chart5.DataSource = ds.Tables("Daily Sales")
            Dim series5 As Series = Chart5.Series("Series5")
            series5.ChartType = SeriesChartType.Line
            series5.Name = "Daily Sales"

            With Chart5
                .Series(series5.Name).XValueMember = "DAY"
                .Series(series5.Name).YValueMembers = "TOTAL_SALES"
                .Series(0).BorderWidth = 3
                .Series(0).BorderColor = System.Drawing.Color.FromArgb(12, 12, 12)
                .Series(0).IsVisibleInLegend = False
                .ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
                .ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = False
                .ChartAreas(0).BackColor = Color.FromArgb(196, 221, 255)
            End With

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        loadDailySalesLineGraph()
        loadPopularProductsBarGraph()
        loadMonthlySalesLineGraph()
        pnlProducts.Visible = False
        pnlCustomers.Visible = False
        pnlSuppliers.Visible = False
        pnlEmployees.Visible = False
        pnlSales.Visible = False
        pnlReports.Visible = False
        Panel2.Visible = False
        pnlSettings.Visible = False
        pnlDashboard.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmDataAnalysis.ShowDialog()
        frmDataAnalysis.Dispose()
    End Sub


    Private Sub loadPopularProductsBarGraph()
        Try
            With Chart3
                .Series.Clear()
                .Series.Add("Series3")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT CONCAT(tblproducts.product_name,' ', tblproducts.prod_variant,' ',tblproducts.size, 'ml ') AS PRODUCT_NAME, SUM(tblorders.quantity) AS QUANTITY FROM tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id GROUP BY tblorders.product_id ORDER BY SUM(tblorders.quantity) DESC LIMIT 5"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Product Popularity")
            Chart3.DataSource = ds.Tables("Product Popularity")
            Dim series3 As Series = Chart3.Series("Series3")
            series3.ChartType = SeriesChartType.Bar
            series3.Name = "Product Popularity"

            With Chart3
                .Series(series3.Name).XValueMember = "PRODUCT_NAME"
                .Series(series3.Name).YValueMembers = "QUANTITY"
                .Series(0).LabelFormat = "{#,##0}"

                .Legends(0).LegendStyle = LegendStyle.Column
                .Legends(0).Docking = Docking.Right
                .Legends(0).Alignment = System.Drawing.StringAlignment.Center

                .Series(0).IsVisibleInLegend = False

                .ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True
                .ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = False
                .ChartAreas(0).BackColor = Color.FromArgb(196, 221, 255)
            End With


            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub loadMonthlySalesLineGraph()
        Try
            With Chart2
                .Series.Clear()
                .Series.Add("Series2")
            End With
            Dim datatable As New DataTable
            openConn()

            com = New MySqlCommand
            com.Connection = conn
            com.CommandText = "SELECT MONTHNAME(tbltransaction.date_time) as MONTH, SUM(tblproducts.price*tblorders.quantity) AS TOTAL_SALES FROM (tblproducts INNER JOIN tblorders ON tblproducts.product_id = tblorders.product_id) INNER JOIN tbltransaction ON tblorders.transaction_id = tbltransaction.transaction_id GROUP BY MONTH(tbltransaction.date_time)"
            adapter.SelectCommand = com
            Dim ds As New DataSet

            adapter.Fill(ds, "Monthly Sales")
            Chart2.DataSource = ds.Tables("Monthly Sales")
            Dim series2 As Series = Chart2.Series("Series2")
            series2.ChartType = SeriesChartType.Line
            series2.Name = "Monthly Sales"

            With Chart2
                .Series(series2.Name).XValueMember = "MONTH"
                .Series(series2.Name).YValueMembers = "TOTAL_SALES"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).BorderWidth = 3
                .Series(0).BorderColor = System.Drawing.Color.FromArgb(12, 12, 12)

                .Series(0).IsVisibleInLegend = False
                .ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True
                .ChartAreas("ChartArea1").AxisY.LabelStyle.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisX.MinorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
                .ChartAreas("ChartArea1").AxisY.MinorGrid.Enabled = False
                .ChartAreas(0).BackColor = Color.FromArgb(196, 221, 255)

            End With

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateDiscount_Click(sender As Object, e As EventArgs) Handles btnUpdateDiscount.Click
        If dgvDiscount.SelectedRows.Count > 0 Then
            If btnUpdateDiscount.Text = "SAVE" Then
                If txtDiscount.Text = "" Then
                    MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    updateDiscount()
                    refreshDGVs()
                    AddDiscountClear()
                End If
            Else
                getDiscountID()
                txtDiscount.Text = dgvDiscount.SelectedRows(0).Cells("DISCOUNT").Value.ToString
                btnAddDiscount.Enabled = False
                btnDeleteDiscount.Enabled = True
                btnUpdateDiscount.Text = "SAVE"
            End If
        End If
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs) Handles btnAddDiscount.Click
        If txtDiscount.Text = "" Then
            MsgBox("The field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else

            If (Integer.Parse(txtDiscount.Text) > 100) Or (Integer.Parse(txtDiscount.Text) < 0) Then
                MsgBox("Invalid discount!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                addDiscount()
                refreshDGVs()
                AddDiscountClear()
            End If
        End If
    End Sub

    Private Sub btnDeleteDiscount_Click(sender As Object, e As EventArgs) Handles btnDeleteDiscount.Click
        btnDeleteDiscount.Text = MessageBox.Show("Are you sure you want to delete this discount?", "Delete Discount", MessageBoxButtons.YesNo)
        If btnDeleteDiscount.Text = DialogResult.Yes Then
            btnDeleteDiscount.Text = "DELETE"
            deleteDiscount()
            refreshDGVs()
            MsgBox("Discount successfully deleted!", MsgBoxStyle.Information, "Discount Deleted")

        Else
            btnDeleteDiscount.Text = "DELETE"
        End If
        AddDiscountClear()
    End Sub

    Private Sub btnClearDiscount_Click(sender As Object, e As EventArgs) Handles btnClearDiscount.Click
        AddDiscountClear()
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
