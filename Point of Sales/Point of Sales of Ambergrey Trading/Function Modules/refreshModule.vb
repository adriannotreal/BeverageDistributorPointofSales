Module refreshModule

    Public Sub refreshDGVs()
        showCustomerDetails()
        showProductDetails()
        showSupplierDetails()
        showProductDetailsStockIn()
        showProductStockHistory()
        showProductDefective()
        showProductDefectiveHistory()
        showProductStockOut()
        showEmployeeDetails()
        showEmployeeLogs()
        showSalesHistory()
        showProductNameVar()
        showContainer()
        showVariants()
        showSize()
        showProductStockOutDashboard()
        showDiscount()


        loadEmployeeCombobox()
        loadCombobox()
        loadContainer()
        loadProdName()
        loadSizes()
        loadVariant()
        loadComboboxSupplierProducts()


        selectedproductquantity = 0
        selectedsupplier = 0

        frmMain.dgvVariants.ClearSelection()
        frmMain.dgvProductName.ClearSelection()
        frmMain.dgvAddStock.ClearSelection()
        frmMain.dgvCustomerList.ClearSelection()
        frmMain.dgvDefectiveItemHistory.ClearSelection()
        frmMain.dgvEmployeeList.ClearSelection()
        frmMain.dgvEmployeeLogs.ClearSelection()
        frmMain.dgvSize.ClearSelection()
        frmMain.dgvOutOfStock.ClearSelection()
        frmMain.dgvProductListDefect.ClearSelection()
        frmMain.dgvProductsProductList.ClearSelection()
        frmMain.dgvSalesHistory.ClearSelection()
        frmMain.dgvStockInHistory.ClearSelection()
        frmMain.dgvSupplierDetails.ClearSelection()
        frmMain.dgvContainer.ClearSelection()



    End Sub

End Module
