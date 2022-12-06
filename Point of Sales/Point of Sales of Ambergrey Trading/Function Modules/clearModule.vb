Module clearModule

    Public Sub AddProductClear()
        frmMain.txtProductID.Enabled = True
        frmMain.cboSupplier.Enabled = True
        frmMain.btnUpdateProduct.Text = "UPDATE"
        frmMain.dgvProductsProductList.ClearSelection()
        frmMain.txtProductID.Clear()
        frmMain.txtProductPrice.Clear()
        frmMain.btnDeleteProduct.Enabled = False
        frmMain.btnAddProduct.Enabled = True
        frmMain.cboContainer.SelectedIndex = -1
        frmMain.cboCategory.SelectedIndex = -1
        frmMain.cboSupplier.SelectedIndex = -1
        frmMain.cboSize.SelectedIndex = -1
        frmMain.cboProdName.SelectedIndex = -1
    End Sub

    Public Sub AddStockClear()
        frmMain.dgvAddStock.ClearSelection()
        frmMain.txtProductIDAddStock.Clear()
        frmMain.txtQuantityAddStock.Clear()
    End Sub

    Public Sub AddProductNameClear()
        frmMain.dgvProductName.ClearSelection()
        frmMain.txtProdNameVar.Clear()
        frmMain.btnProdNameAddVar.Enabled = True
        frmMain.btnProdNameUpdateVar.Text = "UPDATE"
        frmMain.btnProdNameDeleteVar.Enabled = False
    End Sub


    Public Sub AddVariantClear()
        frmMain.dgvVariants.ClearSelection()
        frmMain.txtVariant.Clear()
        frmMain.btnAddVariant.Enabled = True
        frmMain.btnUpdateVariant.Text = "UPDATE"
        frmMain.btnDeleteVariant.Enabled = False
    End Sub

    Public Sub AddContainerClear()
        frmMain.dgvContainer.ClearSelection()
        frmMain.txtContainerName.Clear()
        frmMain.btnAddContainer.Enabled = True
        frmMain.btnUpdateContainer.Text = "UPDATE"
        frmMain.btnDeleteContainer.Enabled = False
    End Sub

    Public Sub AddSizeClear()
        frmMain.dgvSize.ClearSelection()
        frmMain.txtSizeVariable.Clear()
        frmMain.btnAddSize.Enabled = True
        frmMain.btnUpdateSize.Text = "UPDATE"
        frmMain.btnDeleteSize.Enabled = False
    End Sub
    Public Sub AddDiscountClear()
        frmMain.dgvDiscount.ClearSelection()
        frmMain.txtDiscount.Clear()
        frmMain.btnAddDiscount.Enabled = True
        frmMain.btnUpdateDiscount.Text = "UPDATE"
        frmMain.btnDeleteDiscount.Enabled = False
    End Sub

    Public Sub AddSupplierClear()
        frmMain.btnUpdateSupplier.Text = "UPDATE"
        frmMain.dgvSupplierDetails.ClearSelection()
        frmMain.txtSupplierNameDetails.Clear()
        frmMain.txtSupplierContactDetails.Clear()
        frmMain.txtSupplierID.Clear()
        frmMain.txtSupplierAddressDetails.Clear()
        frmMain.btnAddSupplier.Enabled = True
        frmMain.btnDeleteSupplier.Enabled = False
    End Sub

    Public Sub AddCustomerClear()
        frmMain.btnUpdateCustomer.Text = "UPDATE"
        frmMain.dgvCustomerList.ClearSelection()
        frmMain.txtCustomerID.Clear()
        frmMain.txtFirstNameCustomer.Clear()
        frmMain.txtMiddleNameCustomer.Clear()
        frmMain.txtLastNameCustomer.Clear()
        frmMain.txtHouseNoCustomer.Clear()
        frmMain.txtContactCustomer.Clear()
        frmMain.txtStreetCustomer.Clear()
        frmMain.txtMunicipalityCustomer.Clear()
        frmMain.txtBarangayCustomer.Clear()
        frmMain.btnAddCustomer.Enabled = True
        frmMain.btnDeleteCustomer.Enabled = False
    End Sub

    Public Sub DefectProductClear()
        frmMain.dgvProductListDefect.ClearSelection()
        frmMain.txtProductNameDefect.Clear()
        frmMain.txtSupplierDefect.Clear()
        frmMain.txtQuantityDefect.Clear()
        frmMain.txtRemarksDefect.Clear()
    End Sub

    Public Sub AddEmployeeClear()
        frmMain.txtEmployeeFirstName.Clear()
        frmMain.txtEmployeeMiddleName.Clear()
        frmMain.txtEmployeeLastName.Clear()
        frmMain.txtEmployeePassword.Clear()
        frmMain.txtEmployeeUsername.Clear()
        frmMain.txtEmployeeContactNo.Clear()
        frmMain.txtSecurityAnswer.Clear()
        frmMain.cboSecurityQuestion.SelectedIndex = -1
        frmMain.cboUserLevel.SelectedIndex = -1
        frmMain.btnUpdateEmployee.Text = "UPDATE"
        frmMain.btnAddEmployee.Enabled = True
        frmMain.btnDeleteEmployee.Enabled = False

    End Sub


    Public Sub AddToCartClear()
        frmPOS.txtPOSProductCode.Clear()
        frmPOS.txtPOSProductContainer.Clear()
        frmPOS.txtPOSProductName.Clear()
        frmPOS.txtPOSProductSize.Clear()
        frmPOS.txtPOSVariant.Clear()
        frmPOS.txtPOSQty.Clear()
        frmPOS.txtPOSStock.Clear()
    End Sub

    Public Sub POSClear()
        AddToCartClear()
        frmPOS.txtTotal.Clear()
        frmPOS.txtVAT.Clear()
        frmPOS.txtNetTotal.Clear()
        frmPOS.txtCash.Clear()
        frmPOS.txtChange.Clear()
        frmPOS.lblCustomerID.Text = ""
        frmPOS.lblCustomerName.Text = ""
        frmPOS.txtSearchPOS.Clear()
        frmPOS.btnSearchCustomer.Text = "Search customer"
        frmPOS.txtPOSVariant.Clear()


        frmPOS.pnlCustomer.Visible = False
        frmPOS.btnSearchCustomerDGV.Visible = False
        frmPOS.txtSearchCustomer.Visible = False
        pos_total = 0

        loadDiscount()

    End Sub


End Module
