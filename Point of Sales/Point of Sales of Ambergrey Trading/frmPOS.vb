Imports MySql.Data.MySqlClient
Public Class frmPOS
    Public disc As String = ""
    Public POS_customer_id As Integer
    Private Sub pbxLiquor_Click(sender As Object, e As EventArgs) Handles pbxLiquor.Click
        pnlButtons.Visible = False
        pnlNonAlchohol.Visible = False
        pnlSearch.Visible = False
        pnlAlcohol.Visible = True
    End Sub

    Private Sub btnLiquor_Click(sender As Object, e As EventArgs) Handles btnLiquor.Click
        pnlButtons.Visible = False
        pnlNonAlchohol.Visible = False
        pnlSearch.Visible = False
        pnlAlcohol.Visible = True
    End Sub

    Private Sub pbxSoda_Click(sender As Object, e As EventArgs) Handles pbxSoda.Click
        pnlButtons.Visible = False
        pnlAlcohol.Visible = False
        pnlSearch.Visible = False
        pnlNonAlchohol.Visible = True
    End Sub

    Private Sub btnSoda_Click(sender As Object, e As EventArgs) Handles btnSoda.Click
        pnlButtons.Visible = False
        pnlAlcohol.Visible = False
        pnlSearch.Visible = False
        pnlNonAlchohol.Visible = True
    End Sub

    Private Sub pbxReturnSoda_Click(sender As Object, e As EventArgs) Handles pbxReturnSoda.Click
        pnlAlcohol.Visible = False
        pnlNonAlchohol.Visible = False
        pnlSearch.Visible = False
        pnlButtons.Visible = True
    End Sub

    Private Sub pbxReturnLiquor_Click(sender As Object, e As EventArgs) Handles pbxReturnLiquor.Click
        pnlAlcohol.Visible = False
        pnlNonAlchohol.Visible = False
        pnlSearch.Visible = False
        pnlButtons.Visible = True
    End Sub

    Private Sub pbxExitPOS_Click(sender As Object, e As EventArgs) Handles pbxExitPOS.Click
        Dim response
        response = MessageBox.Show("Are you sure you want to exit POS?", "Exit POS", MessageBoxButtons.YesNo)
        If response = DialogResult.Yes Then
            POSClear()
            frmLogin.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        Dim discount As Double
        If cboDiscount.Text = "" Then
            discount = 0
        Else
            discount = Double.Parse(cboDiscount.Text) / 100
        End If
        If txtPOSProductCode.Text = "" Then
            MsgBox("Please select a product.", vbOKOnly + MsgBoxStyle.Critical, "")
        ElseIf txtPOSQty.Text = "" Then
            MsgBox("Please enter quantity of the product to add!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            If Val(txtPOSQty.Text) > Val(txtPOSStock.Text) Then
                MsgBox("The quantity value cannot be greater than the stock value!", vbOKOnly + MsgBoxStyle.Critical, "")
            Else
                Dim copy As Boolean = False
                Dim code As String = txtPOSProductCode.Text
                Dim name As String = txtPOSProductName.Text + " " + txtPOSVariant.Text
                Dim size As String = txtPOSProductSize.Text
                Dim container As String = txtPOSProductContainer.Text
                Dim qty As Decimal = txtPOSQty.Text
                Dim price As Decimal = pos_price
                Dim total As Decimal = price * qty

                If dgvCart.Rows.Count > 0 Then
                    For Each row In dgvCart.Rows
                        If code = row.Cells(0).Value Then
                            copy = True
                            Exit For
                        End If
                    Next
                    If copy = False Then
                        pos_total += total
                        dgvCart.Rows.Add(code, String.Concat(name, " ", size, "ml ", container), price, qty, total)
                        txtSubTotal.Text = Format(pos_total, "0.00 PHP")
                        txtTotal.Text = Format((pos_total - (pos_total * discount)), "0.00 PHP")
                        txtNetTotal.Text = Format(pos_total / 1.12, "0.00 PHP")
                        txtVAT.Text = Format((pos_total / 1.12) * 0.12, "0.00 PHP")
                        AddToCartClear()
                    Else
                        MsgBox("You can only add the same product once. Remove the item and add it again to update!", vbOKOnly + MsgBoxStyle.Critical, "")
                    End If
                Else
                    pos_total += total
                    dgvCart.Rows.Add(code, String.Concat(name, " ", size, "ml ", container), price, qty, total)
                    txtSubTotal.Text = Format(pos_total, "0.00 PHP")
                    txtTotal.Text = Format((pos_total - (pos_total * discount)), "0.00 PHP")
                    txtNetTotal.Text = Format(pos_total / 1.12, "0.00 PHP")
                    txtVAT.Text = Format((pos_total / 1.12) * 0.12, "0.00 PHP")
                    AddToCartClear()
                End If
            End If
        End If
    End Sub


    Private Sub dgvSoda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSoda.CellClick
        Dim i As Integer
        With dgvSoda
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtPOSProductCode.Text = .Rows(i).Cells(0).Value.ToString()
                txtPOSProductName.Text = .Rows(i).Cells(1).Value.ToString()
                txtPOSVariant.Text = .Rows(i).Cells(2).Value.ToString()
                txtPOSProductSize.Text = .Rows(i).Cells(3).Value.ToString()
                txtPOSProductContainer.Text = .Rows(i).Cells(4).Value.ToString()
                txtPOSStock.Text = .Rows(i).Cells(6).Value.ToString()
                pos_price = Decimal.Parse(.Rows(i).Cells(5).Value.ToString())
            End If
        End With
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPOSProductDetailsSoda()
        showPOSProductDetailsLiquor()
        showPOSCustomerDetails()
        loadDiscount()

        lblCustomerID.Text = ""
        lblCustomerName.Text = ""
        pnlCustomer.Visible = False
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim discount As Double
            If cboDiscount.Text = "" Then
                discount = 0
            Else
                discount = Double.Parse(cboDiscount.Text) / 100
            End If
            If Not txtCash.Text = "" Then
                Dim cash As Decimal = Decimal.Parse(txtCash.Text)
                If Val(txtCash.Text) >= Val(txtTotal.Text) Then
                    txtChange.Text = Format(cash - (((pos_total) - (pos_total * discount))), "0.00")
                End If
            Else
                txtChange.Text = ""
            End If

            If Val(txtTotal.Text) > Val(txtCash.Text) Then
                txtChange.Text = ""
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnProceedPayment_Click(sender As Object, e As EventArgs) Handles btnProceedPayment.Click
        'If lblCustomerID.Text = "" Then
        '    MsgBox("Please select a customer!", vbOKOnly + MsgBoxStyle.Critical, "")
        'Else
        '    If txtTotal.Text = "" Then
        '        MsgBox("The cart is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        '    Else
        '        If txtChange.Text = "" Then
        '            MsgBox("Please input valid payment!", vbOKOnly + MsgBoxStyle.Critical, "")
        '        Else
        '            addTransaction()
        '            getTransactionID()
        '            addOrders()
        '            Dim net As Decimal = pos_total / 1.12
        '            Dim vat As Decimal = (pos_total / 1.12) * 0.12
        '            Dim dt As New DataTable
        '            With dt
        '                .Columns.Add("TransactionID")
        '                .Columns.Add("DateTime")
        '                .Columns.Add("Product_Code")
        '                .Columns.Add("Product_Name")
        '                .Columns.Add("Price_Unit")
        '                .Columns.Add("Quantity")
        '                .Columns.Add("Total")
        '                .Columns.Add("NetTotal")
        '                .Columns.Add("VAT")
        '                .Columns.Add("AmountDue")
        '                .Columns.Add("Cashier_Name")
        '            End With
        '            For Each dr As DataGridViewRow In dgvCart.Rows
        '                dt.Rows.Add(transaction_id.ToString, System.DateTime.Now.ToString, dr.Cells(0).Value, dr.Cells(1).Value, "P " + Format(Double.Parse(dr.Cells(2).Value), "0.00"), dr.Cells(3).Value, "P " + Format(Double.Parse(dr.Cells(4).Value), "0.00"), "P " + Format(net, "0.00"), "P " + Format(vat, "0.00"), "P " + Format(Decimal.Parse(pos_total), "0.00"), lblCashierName.Text.ToString())

        '            Next
        '            updateProductsPOS()

        '            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        '            rptDoc = New rptReceipt
        '            rptDoc.SetDataSource(dt)
        '            frmReceipt.CrystalReportViewer1.ReportSource = rptDoc
        '            frmReceipt.ShowDialog()
        '            frmReceipt.Dispose()

        '            POSClear()
        '            showPOSProductDetailsSoda()
        '            showPOSProductDetailsLiquor()
        '            lblCustomerID.Text = ""
        '            lblCustomerName.Text = ""
        '            pnlAlcohol.Visible = False
        '            pnlNonAlchohol.Visible = False
        '            pnlButtons.Visible = True
        '            dgvCart.Rows.Clear()
        '            pos_total = 0
        '        End If
        '    End If
        'End If
        If dgvCart.Rows.Count > 0 Then
            Dim discount As Double
            If cboDiscount.Text = "" Then
                cboDiscount.Text = "0"
                discount = 0
            Else
                discount = Double.Parse(cboDiscount.Text) / 100
            End If
            Dim exists As Boolean = False
            If lblCustomerID.Text = "" Then
                lblCustomerID.Text = 6
            End If
            If txtTotal.Text = "" Then
                MsgBox("The cart is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
                lblCustomerID.Text = ""
            Else
                If Val(txtTotal.Text) > Val(txtCash.Text) Then
                    MsgBox("Please input valid payment!", vbOKOnly + MsgBoxStyle.Critical, "")
                Else
                    Do
                        generateTransID()
                        Try
                            openConn()
                            Dim theQuery As String = "SELECT * FROM tbltransaction WHERE transaction_id = @trans"
                            Dim cmd1 As New MySqlCommand
                            cmd1.Connection = conn
                            cmd1.CommandText = theQuery
                            cmd1.Parameters.AddWithValue("trans", idtransgeneration)

                            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                                If rdr.HasRows Then
                                    trans += 1
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
                    addTransaction()
                    'getTransactionID()
                    addOrders()
                    Dim net As Decimal = pos_total / 1.12
                    Dim vat As Decimal = (pos_total / 1.12) * 0.12
                    Dim dt As New DataTable
                    With dt
                        .Columns.Add("TransactionID")
                        .Columns.Add("DateTime")
                        .Columns.Add("Product_Code")
                        .Columns.Add("Product_Name")
                        .Columns.Add("Price_Unit")
                        .Columns.Add("Quantity")
                        .Columns.Add("Total")
                        .Columns.Add("NetTotal")
                        .Columns.Add("VAT")
                        .Columns.Add("AmountDue")
                        .Columns.Add("Cashier_Name")
                        .Columns.Add("Discount")
                        .Columns.Add("Subtotal")
                    End With
                    For Each dr As DataGridViewRow In dgvCart.Rows
                        dt.Rows.Add(idtransgeneration.ToString, System.DateTime.Now.ToString, dr.Cells(0).Value, dr.Cells(1).Value, "P " + Format(Double.Parse(dr.Cells(2).Value), "0.00"), dr.Cells(3).Value, "P " + Format(Double.Parse(dr.Cells(4).Value), "0.00"), "P " + Format(net, "0.00"), "P " + Format(vat, "0.00"), "P " + Format(Decimal.Parse((pos_total) - (pos_total * discount)), "0.00"), lblCashierName.Text.ToString, cboDiscount.Text.ToString + "% ", "P " + Format(pos_total, "0.00"))

                    Next
                    updateProductsPOS()

                    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New rptReceipt1
                    rptDoc.SetDataSource(dt)
                    frmReceipt.CrystalReportViewer1.ReportSource = rptDoc
                    frmReceipt.ShowDialog()
                    frmReceipt.Dispose()

                    POSClear()
                    showPOSProductDetailsSoda()
                    showPOSProductDetailsLiquor()
                    lblCustomerID.Text = ""
                    lblCustomerName.Text = ""
                    pnlAlcohol.Visible = False
                    pnlNonAlchohol.Visible = False
                    pnlButtons.Visible = True
                    dgvCart.Rows.Clear()
                    pos_total = 0
                End If
            End If
        Else
            MsgBox("The cart is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        End If

    End Sub

    Private Sub addOrders()
        For Each row In dgvCart.Rows
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO `tblorders` (`transaction_id`, `product_id`, `quantity`) " +
                    " VALUES ('" & idtransgeneration & "', '" & row.Cells(0).Value.ToString & "', '" & Integer.Parse(row.Cells(3).Value.ToString) & "')"
                com.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub updateProductsPOS()
        For Each row In dgvCart.Rows
            Dim tempq As Integer
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "SELECT `quantity` FROM  tblproducts where product_id = '" & row.Cells(0).Value.ToString & "'"
                com.ExecuteNonQuery()
                adapter.SelectCommand = com
                Dim dtable As New DataTable
                dtable.Clear()
                adapter.Fill(dtable)
                tempq = Integer.Parse(dtable.Rows(0).Item(0).ToString)
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Dim diff As Integer = tempq - Integer.Parse(row.Cells(3).Value.ToString)

            openConn()
            Try
                com.Connection = conn
                com.CommandText = "UPDATE `tblproducts` SET `quantity` = " & diff & " WHERE product_id = '" & row.Cells(0).Value.ToString & "'"
                com.ExecuteNonQuery()
                conn.Close()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub


    Private Sub dgvPOSCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPOSCustomer.CellClick
        Dim i As Integer
        With dgvPOSCustomer
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                lblCustomerID.Text = .Rows(i).Cells(0).Value.ToString()
                lblCustomerName.Text = .Rows(i).Cells(1).Value.ToString()
                pnlCustomer.Visible = False
                btnSearchCustomer.Text = "Search customer"
            End If
        End With
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click

        If btnSearchCustomer.Text = "Cancel" Then
            pnlCustomer.Visible = False
            btnSearchCustomerDGV.Visible = False
            txtSearchCustomer.Visible = False
            btnSearchCustomer.Text = "Search customer"
        Else
            pnlCustomer.Visible = True
            btnSearchCustomerDGV.Visible = True
            txtSearchCustomer.Visible = True
            btnSearchCustomer.Text = "Cancel"
        End If
    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to clear cart?", vbYesNo + MsgBoxStyle.Question, "")
        If result = MsgBoxResult.Yes Then
            dgvCart.Rows.Clear()
            POSClear()
        End If
    End Sub

    Private Sub removeItem()
        Dim discount As Double
        If cboDiscount.Text = "" Then
            discount = 0
        Else
            discount = Double.Parse(cboDiscount.Text) / 100
        End If
        With dgvCart
            If .SelectedRows.Count > 0 Then
                Dim newcount As Decimal = Val(txtSubTotal.Text) - .SelectedRows(0).Cells(4).Value
                If newcount = 0 Then
                    POSClear()
                Else
                    txtSubTotal.Text = Format(newcount, "0.00 PHP")
                    txtTotal.Text = Format(((newcount) - (newcount * discount)), "0.00 PHP")
                    txtNetTotal.Text = Format(newcount / 1.12, "0.00 PHP")
                    txtVAT.Text = Format((newcount / 1.12) * 0.12, "0.00 PHP")
                End If
                pos_total = newcount
                .Rows.Remove(.SelectedRows(0))
            Else
                MsgBox("Please select an item to delete!", vbOKOnly + MsgBoxStyle.Critical, "")
            End If
        End With
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        removeItem()
    End Sub


    Private Sub dgvLiquor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLiquor.CellClick
        Dim i As Integer
        With dgvLiquor
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtPOSProductCode.Text = .Rows(i).Cells(0).Value.ToString()
                txtPOSProductName.Text = .Rows(i).Cells(1).Value.ToString()
                txtPOSVariant.Text = .Rows(i).Cells(2).Value.ToString()
                txtPOSProductSize.Text = .Rows(i).Cells(3).Value.ToString()
                txtPOSProductContainer.Text = .Rows(i).Cells(4).Value.ToString()
                txtPOSStock.Text = .Rows(i).Cells(6).Value.ToString()
                pos_price = Decimal.Parse(.Rows(i).Cells(5).Value.ToString())
            End If
        End With
    End Sub


    Private Sub txtPOSQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPOSQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub


    Private Sub txtSearchPOS_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPOS.TextChanged
        If txtSearchPOS.Text = "" Then
            pnlAlcohol.Visible = False
            pnlNonAlchohol.Visible = False
            pnlSearch.Visible = False
            pnlButtons.Visible = True
        Else
            pnlAlcohol.Visible = False
            pnlNonAlchohol.Visible = False
            pnlButtons.Visible = False
            pnlSearch.Visible = True
            showProductSearchPOS()
        End If
    End Sub

    Private Sub generateTransID()
        Dim yearstring As String = Date.Now.Year.ToString
        Dim transnumstr As String = trans.ToString.PadLeft(6, "0")
        idtransgeneration = yearstring + transnumstr
    End Sub

    Private Sub btnSearchPOS_Click(sender As Object, e As EventArgs) Handles btnSearchPOS.Click
        If txtSearchPOS.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
            pnlAlcohol.Visible = False
            pnlNonAlchohol.Visible = False
            pnlSearch.Visible = False
            pnlButtons.Visible = True
        Else
            pnlAlcohol.Visible = False
            pnlNonAlchohol.Visible = False
            pnlButtons.Visible = False
            pnlSearch.Visible = True
            showProductSearchPOS()
        End If
    End Sub

    Private Sub dgvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearch.CellClick
        Dim i As Integer
        With dgvSearch
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtPOSProductCode.Text = .Rows(i).Cells(0).Value.ToString()
                txtPOSProductName.Text = .Rows(i).Cells(1).Value.ToString()
                txtPOSVariant.Text = .Rows(i).Cells(2).Value.ToString()
                txtPOSProductSize.Text = .Rows(i).Cells(3).Value.ToString()
                txtPOSProductContainer.Text = .Rows(i).Cells(4).Value.ToString()
                txtPOSStock.Text = .Rows(i).Cells(6).Value.ToString()
                pos_price = Decimal.Parse(.Rows(i).Cells(5).Value.ToString())
            End If
        End With
    End Sub

    Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCustomer.TextChanged
        If Not txtSearchCustomer.Text = "" Then
            showPOSCustomerSearchDetails()
        End If
    End Sub

    Private Sub btnSearchCustomerDGV_Click(sender As Object, e As EventArgs) Handles btnSearchCustomerDGV.Click
        If txtSearchCustomer.Text = "" Then
            MsgBox("The search field is empty!", vbOKOnly + MsgBoxStyle.Critical, "")
        Else
            showPOSCustomerSearchDetails()
        End If
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click

        frmAddCustomerPOS.ShowDialog()
        frmAddCustomerPOS.Dispose()

    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        frmVoidLogIn.ShowDialog()
        frmVoidLogIn.Dispose()

    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscount.SelectedIndexChanged
        If Not cboDiscount.Text = "" And Not cboDiscount.Text = "System.Data.DataRowView" Then
            Dim discount As Double = Double.Parse(cboDiscount.Text) / 100
            txtSubTotal.Text = Format(pos_total, "0.00 PHP")
            txtTotal.Text = Format((pos_total - (pos_total * discount)), "0.00 PHP")
            txtNetTotal.Text = Format(pos_total / 1.12, "0.00 PHP")
            txtVAT.Text = Format((pos_total / 1.12) * 0.12, "0.00 PHP")
            AddToCartClear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Double

        getTransactionID()


        Dim dtable As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT tblorders.transaction_id, tbltransaction.date_time, tblproducts.product_id as PRODUCT_ID, tblproducts.product_name as PRODUCT_NAME, tblproducts.prod_variant as VARIANT, tblproducts.size as SIZE_in_mL, tblproducts.container as CONTAINER , tblproducts.price as PRICE, tblorders.quantity as QUANTITY, tblorders.quantity as SUBTOTAL, tbltransaction.totaldue, tblemployees.first_name, tbltransaction.discount FROM (tblorders LEFT JOIN tblproducts ON tblorders.product_id = tblproducts.product_id) INNER JOIN (tbltransaction INNER JOIN tblemployees ON tbltransaction.employee_id = tblemployees.employee_id) ON tblorders.transaction_id = tbltransaction.transaction_id WHERE tblorders.transaction_id = '" & transaction_id & "'"
            com.Parameters.Clear()
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable.Clear()
            adapter.Fill(dtable)
            dgvSearch.DataSource = dtable
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim dtable1 As New DataTable
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "SELECT SUM(tblproducts.price*tblorders.quantity) FROM tblorders INNER JOIN tblproducts ON tblorders.product_id = tblproducts.product_id WHERE tblorders.transaction_id = '" & transaction_id & "'"
            com.Parameters.Clear()
            com.ExecuteNonQuery()
            adapter.SelectCommand = com
            dtable1.Clear()
            adapter.Fill(dtable1)
            sum = Double.Parse(dtable1.Rows(0).Item(0).ToString)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Dim dt As New DataTable
        With dt
            .Columns.Add("TransactionID")
            .Columns.Add("DateTime")
            .Columns.Add("Product_Code")
            .Columns.Add("Product_Name")
            .Columns.Add("Price_Unit")
            .Columns.Add("Quantity")
            .Columns.Add("Total")
            .Columns.Add("NetTotal")
            .Columns.Add("VAT")
            .Columns.Add("AmountDue")
            .Columns.Add("Cashier_Name")
            .Columns.Add("Discount")
            .Columns.Add("Subtotal")
        End With
        For Each dr As DataGridViewRow In dgvSearch.Rows
            dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value.ToString + " " + dr.Cells(4).Value.ToString + " " + dr.Cells(5).Value.ToString + " " + dr.Cells(6).Value.ToString, "P " + Format(Double.Parse(dr.Cells(7).Value), "0.00"), dr.Cells(8).Value, "P " + Format((Double.Parse(dr.Cells(7).Value) * Double.Parse(dr.Cells(8).Value)), "0.00"), "P " +
                        Format((Double.Parse(sum) / 1.12), "0.00"), "P " + Format(((Double.Parse(sum) / 1.12) * 0.12), "0.00"), "P " + Format(Double.Parse(dr.Cells(10).Value), "0.00"), dr.Cells(11).Value, dr.Cells(12).Value.ToString + "%", "P " + Format(Double.Parse(sum), "0.00"))

        Next
        updateProductsPOS()

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New rptReceipt1
        rptDoc.SetDataSource(dt)
        frmReceipt.CrystalReportViewer1.ReportSource = rptDoc
        frmReceipt.ShowDialog()
        frmReceipt.Dispose()
        POSClear()

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub
End Class