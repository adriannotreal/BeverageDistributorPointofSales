<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TabPage10 As System.Windows.Forms.TabPage
        Dim TabPage2 As System.Windows.Forms.TabPage
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label44 = New System.Windows.Forms.Label()
        Me.dgvEmployeeLogs = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearStockIn = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQuantityAddStock = New System.Windows.Forms.TextBox()
        Me.txtProductIDAddStock = New System.Windows.Forms.TextBox()
        Me.btnSearchProductStockIn = New System.Windows.Forms.Button()
        Me.txtSearchProductStockIn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvAddStock = New System.Windows.Forms.DataGridView()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlSuppliers = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtSupplierContactDetails = New System.Windows.Forms.TextBox()
        Me.btnClearSupplier = New System.Windows.Forms.Button()
        Me.btnUpdateSupplier = New System.Windows.Forms.Button()
        Me.btnDeleteSupplier = New System.Windows.Forms.Button()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtSupplierAddressDetails = New System.Windows.Forms.TextBox()
        Me.txtSupplierNameDetails = New System.Windows.Forms.TextBox()
        Me.btnSearchSupplierDetails = New System.Windows.Forms.Button()
        Me.txtSearchSupplierDetails = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dgvSupplierDetails = New System.Windows.Forms.DataGridView()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboSupplierBy = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.btnSearchProdBySupp = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.dgvProductsBySupplier = New System.Windows.Forms.DataGridView()
        Me.pnlSales = New System.Windows.Forms.Panel()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.lblDtpFrom = New System.Windows.Forms.Label()
        Me.lblDtp = New System.Windows.Forms.Label()
        Me.dtpUntil = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.pbxRefreshSalesHistory = New System.Windows.Forms.PictureBox()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.dgvSalesHistory = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnPrintPreviewSalesRecord = New System.Windows.Forms.Button()
        Me.btnSearchSalesRecord = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.pbxRestore = New System.Windows.Forms.PictureBox()
        Me.pbxBackUp = New System.Windows.Forms.PictureBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.pbxLossReport = New System.Windows.Forms.PictureBox()
        Me.btnLossReport = New System.Windows.Forms.Button()
        Me.pbxStockOutReport = New System.Windows.Forms.PictureBox()
        Me.pbxStockInHistory = New System.Windows.Forms.PictureBox()
        Me.pbxProductsReport = New System.Windows.Forms.PictureBox()
        Me.btnProductsReport = New System.Windows.Forms.Button()
        Me.btnStockOutReports = New System.Windows.Forms.Button()
        Me.btnStockInReports = New System.Windows.Forms.Button()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDataAnalysis = New System.Windows.Forms.Button()
        Me.pnlEmployees = New System.Windows.Forms.Panel()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.cboUserLevel = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtEmployeePassword = New System.Windows.Forms.TextBox()
        Me.txtEmployeeUsername = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtEmployeeContactNo = New System.Windows.Forms.TextBox()
        Me.btnClearEmployee = New System.Windows.Forms.Button()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtEmployeeLastName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeMiddleName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeFirstName = New System.Windows.Forms.TextBox()
        Me.btnEmployeeSearch = New System.Windows.Forms.Button()
        Me.txtEmployeeSearch = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dgvEmployeeList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxExit = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cboVariant = New System.Windows.Forms.ComboBox()
        Me.cboProdName = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.cboContainer = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.btnClearProductDetails = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProductsProductList = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvStockInHistory = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClearDefectiveDetails = New System.Windows.Forms.Button()
        Me.btnAddDefectiveDetails = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRemarksDefect = New System.Windows.Forms.TextBox()
        Me.txtQuantityDefect = New System.Windows.Forms.TextBox()
        Me.txtSupplierDefect = New System.Windows.Forms.TextBox()
        Me.txtProductNameDefect = New System.Windows.Forms.TextBox()
        Me.btnSearchProductDefective = New System.Windows.Forms.Button()
        Me.txtSearchProductDefective = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvProductListDefect = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvDefectiveItemHistory = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvOutOfStock = New System.Windows.Forms.DataGridView()
        Me.pnlCustomers = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMunicipalityCustomer = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBarangayCustomer = New System.Windows.Forms.TextBox()
        Me.txtStreetCustomer = New System.Windows.Forms.TextBox()
        Me.txtHouseNoCustomer = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtContactCustomer = New System.Windows.Forms.TextBox()
        Me.btnClearCustomer = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtLastNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtMiddleNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtFirstNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgvCustomerList = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbxReturnToSettings = New System.Windows.Forms.PictureBox()
        Me.TabControl6 = New System.Windows.Forms.TabControl()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.dgvProductName = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtProdNameVar = New System.Windows.Forms.TextBox()
        Me.btnProdNameVarClear = New System.Windows.Forms.Button()
        Me.btnProdNameUpdateVar = New System.Windows.Forms.Button()
        Me.btnProdNameDeleteVar = New System.Windows.Forms.Button()
        Me.btnProdNameAddVar = New System.Windows.Forms.Button()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.dgvVariants = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtVariant = New System.Windows.Forms.TextBox()
        Me.btnClearVariant = New System.Windows.Forms.Button()
        Me.btnUpdateVariant = New System.Windows.Forms.Button()
        Me.btnDeleteVariant = New System.Windows.Forms.Button()
        Me.btnAddVariant = New System.Windows.Forms.Button()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.dgvContainer = New System.Windows.Forms.DataGridView()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtContainerName = New System.Windows.Forms.TextBox()
        Me.btnClearContainer = New System.Windows.Forms.Button()
        Me.btnUpdateContainer = New System.Windows.Forms.Button()
        Me.btnDeleteContainer = New System.Windows.Forms.Button()
        Me.btnAddContainer = New System.Windows.Forms.Button()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.dgvSize = New System.Windows.Forms.DataGridView()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtSizeVariable = New System.Windows.Forms.TextBox()
        Me.btnClearSize = New System.Windows.Forms.Button()
        Me.btnUpdateSize = New System.Windows.Forms.Button()
        Me.btnDeleteSize = New System.Windows.Forms.Button()
        Me.btnAddSize = New System.Windows.Forms.Button()
        Me.TabPage17 = New System.Windows.Forms.TabPage()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.dgvDiscount = New System.Windows.Forms.DataGridView()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnClearDiscount = New System.Windows.Forms.Button()
        Me.btnUpdateDiscount = New System.Windows.Forms.Button()
        Me.btnDeleteDiscount = New System.Windows.Forms.Button()
        Me.btnAddDiscount = New System.Windows.Forms.Button()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.dgvOut = New System.Windows.Forms.DataGridView()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        TabPage10 = New System.Windows.Forms.TabPage()
        TabPage2 = New System.Windows.Forms.TabPage()
        TabPage10.SuspendLayout()
        CType(Me.dgvEmployeeLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAddStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSuppliers.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvSupplierDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage16.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dgvProductsBySupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSales.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        CType(Me.pbxRefreshSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBackUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReports.SuspendLayout()
        CType(Me.pbxLossReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStockOutReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStockInHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxProductsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmployees.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProducts.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductsProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvStockInHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvProductListDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvDefectiveItemHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvOutOfStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomers.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pbxReturnToSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl6.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        CType(Me.dgvProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        CType(Me.dgvVariants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        CType(Me.dgvContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        CType(Me.dgvSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.TabPage17.SuspendLayout()
        CType(Me.dgvDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage10
        '
        TabPage10.BackColor = System.Drawing.Color.Transparent
        TabPage10.Controls.Add(Me.Label44)
        TabPage10.Controls.Add(Me.dgvEmployeeLogs)
        TabPage10.Location = New System.Drawing.Point(4, 27)
        TabPage10.Name = "TabPage10"
        TabPage10.Padding = New System.Windows.Forms.Padding(3)
        TabPage10.Size = New System.Drawing.Size(896, 430)
        TabPage10.TabIndex = 1
        TabPage10.Text = "Login Logs"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(33, 19)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(111, 18)
        Me.Label44.TabIndex = 9
        Me.Label44.Text = "Employee Logs:"
        '
        'dgvEmployeeLogs
        '
        Me.dgvEmployeeLogs.AllowUserToAddRows = False
        Me.dgvEmployeeLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployeeLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployeeLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployeeLogs.Location = New System.Drawing.Point(27, 41)
        Me.dgvEmployeeLogs.Name = "dgvEmployeeLogs"
        Me.dgvEmployeeLogs.ReadOnly = True
        Me.dgvEmployeeLogs.RowTemplate.Height = 25
        Me.dgvEmployeeLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeLogs.Size = New System.Drawing.Size(843, 359)
        Me.dgvEmployeeLogs.TabIndex = 8
        '
        'TabPage2
        '
        TabPage2.BackColor = System.Drawing.Color.Transparent
        TabPage2.Controls.Add(Me.GroupBox2)
        TabPage2.Controls.Add(Me.btnSearchProductStockIn)
        TabPage2.Controls.Add(Me.txtSearchProductStockIn)
        TabPage2.Controls.Add(Me.Label7)
        TabPage2.Controls.Add(Me.dgvAddStock)
        TabPage2.Location = New System.Drawing.Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New System.Windows.Forms.Padding(3)
        TabPage2.Size = New System.Drawing.Size(896, 430)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Stock In"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClearStockIn)
        Me.GroupBox2.Controls.Add(Me.btnAddStock)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtQuantityAddStock)
        Me.GroupBox2.Controls.Add(Me.txtProductIDAddStock)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Details"
        '
        'btnClearStockIn
        '
        Me.btnClearStockIn.Location = New System.Drawing.Point(708, 89)
        Me.btnClearStockIn.Name = "btnClearStockIn"
        Me.btnClearStockIn.Size = New System.Drawing.Size(100, 26)
        Me.btnClearStockIn.TabIndex = 14
        Me.btnClearStockIn.Text = "CLEAR"
        Me.btnClearStockIn.UseVisualStyleBackColor = True
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(708, 31)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(100, 26)
        Me.btnAddStock.TabIndex = 5
        Me.btnAddStock.Text = "ADD"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 18)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Quantity:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 18)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Product ID:"
        '
        'txtQuantityAddStock
        '
        Me.txtQuantityAddStock.Location = New System.Drawing.Point(133, 91)
        Me.txtQuantityAddStock.Name = "txtQuantityAddStock"
        Me.txtQuantityAddStock.Size = New System.Drawing.Size(212, 23)
        Me.txtQuantityAddStock.TabIndex = 2
        '
        'txtProductIDAddStock
        '
        Me.txtProductIDAddStock.Location = New System.Drawing.Point(133, 33)
        Me.txtProductIDAddStock.Name = "txtProductIDAddStock"
        Me.txtProductIDAddStock.ReadOnly = True
        Me.txtProductIDAddStock.Size = New System.Drawing.Size(212, 23)
        Me.txtProductIDAddStock.TabIndex = 0
        '
        'btnSearchProductStockIn
        '
        Me.btnSearchProductStockIn.Location = New System.Drawing.Point(795, 15)
        Me.btnSearchProductStockIn.Name = "btnSearchProductStockIn"
        Me.btnSearchProductStockIn.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchProductStockIn.TabIndex = 7
        Me.btnSearchProductStockIn.Text = "SEARCH"
        Me.btnSearchProductStockIn.UseVisualStyleBackColor = True
        '
        'txtSearchProductStockIn
        '
        Me.txtSearchProductStockIn.Location = New System.Drawing.Point(606, 17)
        Me.txtSearchProductStockIn.Name = "txtSearchProductStockIn"
        Me.txtSearchProductStockIn.Size = New System.Drawing.Size(183, 23)
        Me.txtSearchProductStockIn.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Product List:"
        '
        'dgvAddStock
        '
        Me.dgvAddStock.AllowUserToAddRows = False
        Me.dgvAddStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAddStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvAddStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAddStock.Location = New System.Drawing.Point(27, 41)
        Me.dgvAddStock.Name = "dgvAddStock"
        Me.dgvAddStock.ReadOnly = True
        Me.dgvAddStock.RowTemplate.Height = 25
        Me.dgvAddStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAddStock.Size = New System.Drawing.Size(843, 189)
        Me.dgvAddStock.TabIndex = 4
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnProducts.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Location = New System.Drawing.Point(-1, 125)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(188, 68)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "PRODUCTS"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCustomers.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(-1, 191)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(188, 68)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "CUSTOMERS"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnSuppliers
        '
        Me.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSuppliers.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnSuppliers.Location = New System.Drawing.Point(-1, 257)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(188, 68)
        Me.btnSuppliers.TabIndex = 2
        Me.btnSuppliers.Text = "SUPPLIERS"
        Me.btnSuppliers.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnEmployees.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnEmployees.ForeColor = System.Drawing.Color.White
        Me.btnEmployees.Location = New System.Drawing.Point(-1, 323)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(188, 68)
        Me.btnEmployees.TabIndex = 3
        Me.btnEmployees.Text = "EMPLOYEES"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSales.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(-1, 389)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(188, 68)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = "SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(-1, 455)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(188, 68)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(-1, 521)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(188, 68)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "SETTINGS"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'pnlSuppliers
        '
        Me.pnlSuppliers.Controls.Add(Me.TabControl3)
        Me.pnlSuppliers.Location = New System.Drawing.Point(186, 126)
        Me.pnlSuppliers.Name = "pnlSuppliers"
        Me.pnlSuppliers.Size = New System.Drawing.Size(916, 464)
        Me.pnlSuppliers.TabIndex = 8
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage16)
        Me.TabControl3.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TabControl3.Location = New System.Drawing.Point(9, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(904, 461)
        Me.TabControl3.TabIndex = 10
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.Transparent
        Me.TabPage8.Controls.Add(Me.GroupBox5)
        Me.TabPage8.Controls.Add(Me.btnSearchSupplierDetails)
        Me.TabPage8.Controls.Add(Me.txtSearchSupplierDetails)
        Me.TabPage8.Controls.Add(Me.Label39)
        Me.TabPage8.Controls.Add(Me.dgvSupplierDetails)
        Me.TabPage8.Location = New System.Drawing.Point(4, 27)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(896, 430)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Supplier Details"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label85)
        Me.GroupBox5.Controls.Add(Me.txtSupplierID)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.txtSupplierContactDetails)
        Me.GroupBox5.Controls.Add(Me.btnClearSupplier)
        Me.GroupBox5.Controls.Add(Me.btnUpdateSupplier)
        Me.GroupBox5.Controls.Add(Me.btnDeleteSupplier)
        Me.GroupBox5.Controls.Add(Me.btnAddSupplier)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.txtSupplierAddressDetails)
        Me.GroupBox5.Controls.Add(Me.txtSupplierNameDetails)
        Me.GroupBox5.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Supplier Details"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(21, 34)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(83, 18)
        Me.Label85.TabIndex = 20
        Me.Label85.Text = "Supplier ID:"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(133, 32)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(212, 23)
        Me.txtSupplierID.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(21, 123)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 18)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "Contact No.:"
        '
        'txtSupplierContactDetails
        '
        Me.txtSupplierContactDetails.Location = New System.Drawing.Point(133, 121)
        Me.txtSupplierContactDetails.Name = "txtSupplierContactDetails"
        Me.txtSupplierContactDetails.Size = New System.Drawing.Size(212, 23)
        Me.txtSupplierContactDetails.TabIndex = 17
        '
        'btnClearSupplier
        '
        Me.btnClearSupplier.Location = New System.Drawing.Point(708, 118)
        Me.btnClearSupplier.Name = "btnClearSupplier"
        Me.btnClearSupplier.Size = New System.Drawing.Size(100, 26)
        Me.btnClearSupplier.TabIndex = 16
        Me.btnClearSupplier.Text = "CLEAR"
        Me.btnClearSupplier.UseVisualStyleBackColor = True
        '
        'btnUpdateSupplier
        '
        Me.btnUpdateSupplier.Location = New System.Drawing.Point(708, 60)
        Me.btnUpdateSupplier.Name = "btnUpdateSupplier"
        Me.btnUpdateSupplier.Size = New System.Drawing.Size(100, 26)
        Me.btnUpdateSupplier.TabIndex = 15
        Me.btnUpdateSupplier.Text = "UPDATE"
        Me.btnUpdateSupplier.UseVisualStyleBackColor = True
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(708, 89)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(100, 26)
        Me.btnDeleteSupplier.TabIndex = 14
        Me.btnDeleteSupplier.Text = "DELETE"
        Me.btnDeleteSupplier.UseVisualStyleBackColor = True
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.Location = New System.Drawing.Point(708, 31)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(100, 26)
        Me.btnAddSupplier.TabIndex = 5
        Me.btnAddSupplier.Text = "ADD"
        Me.btnAddSupplier.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(21, 94)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(63, 18)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Address:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(21, 65)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(109, 18)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Supplier Name:"
        '
        'txtSupplierAddressDetails
        '
        Me.txtSupplierAddressDetails.Location = New System.Drawing.Point(133, 92)
        Me.txtSupplierAddressDetails.Name = "txtSupplierAddressDetails"
        Me.txtSupplierAddressDetails.Size = New System.Drawing.Size(212, 23)
        Me.txtSupplierAddressDetails.TabIndex = 2
        '
        'txtSupplierNameDetails
        '
        Me.txtSupplierNameDetails.Location = New System.Drawing.Point(133, 63)
        Me.txtSupplierNameDetails.Name = "txtSupplierNameDetails"
        Me.txtSupplierNameDetails.Size = New System.Drawing.Size(212, 23)
        Me.txtSupplierNameDetails.TabIndex = 1
        '
        'btnSearchSupplierDetails
        '
        Me.btnSearchSupplierDetails.Location = New System.Drawing.Point(795, 15)
        Me.btnSearchSupplierDetails.Name = "btnSearchSupplierDetails"
        Me.btnSearchSupplierDetails.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchSupplierDetails.TabIndex = 13
        Me.btnSearchSupplierDetails.Text = "SEARCH"
        Me.btnSearchSupplierDetails.UseVisualStyleBackColor = True
        '
        'txtSearchSupplierDetails
        '
        Me.txtSearchSupplierDetails.Location = New System.Drawing.Point(606, 17)
        Me.txtSearchSupplierDetails.Name = "txtSearchSupplierDetails"
        Me.txtSearchSupplierDetails.Size = New System.Drawing.Size(183, 23)
        Me.txtSearchSupplierDetails.TabIndex = 12
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(33, 19)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(90, 18)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "Supplier List:"
        '
        'dgvSupplierDetails
        '
        Me.dgvSupplierDetails.AllowUserToAddRows = False
        Me.dgvSupplierDetails.AllowUserToOrderColumns = True
        Me.dgvSupplierDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSupplierDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvSupplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplierDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSupplierDetails.Location = New System.Drawing.Point(27, 41)
        Me.dgvSupplierDetails.Name = "dgvSupplierDetails"
        Me.dgvSupplierDetails.ReadOnly = True
        Me.dgvSupplierDetails.RowTemplate.Height = 25
        Me.dgvSupplierDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSupplierDetails.Size = New System.Drawing.Size(843, 189)
        Me.dgvSupplierDetails.TabIndex = 10
        '
        'TabPage16
        '
        Me.TabPage16.BackColor = System.Drawing.Color.Transparent
        Me.TabPage16.Controls.Add(Me.GroupBox12)
        Me.TabPage16.Controls.Add(Me.Label60)
        Me.TabPage16.Controls.Add(Me.dgvProductsBySupplier)
        Me.TabPage16.Location = New System.Drawing.Point(4, 27)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage16.Size = New System.Drawing.Size(896, 430)
        Me.TabPage16.TabIndex = 1
        Me.TabPage16.Text = "Supplier Products"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button1)
        Me.GroupBox12.Controls.Add(Me.cboSupplierBy)
        Me.GroupBox12.Controls.Add(Me.Label61)
        Me.GroupBox12.Controls.Add(Me.btnSearchProdBySupp)
        Me.GroupBox12.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(843, 99)
        Me.GroupBox12.TabIndex = 15
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Controls"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboSupplierBy
        '
        Me.cboSupplierBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplierBy.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboSupplierBy.FormattingEnabled = True
        Me.cboSupplierBy.IntegralHeight = False
        Me.cboSupplierBy.Location = New System.Drawing.Point(87, 55)
        Me.cboSupplierBy.MaxDropDownItems = 5
        Me.cboSupplierBy.Name = "cboSupplierBy"
        Me.cboSupplierBy.Size = New System.Drawing.Size(212, 24)
        Me.cboSupplierBy.TabIndex = 19
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(82, 29)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(191, 18)
        Me.Label61.TabIndex = 16
        Me.Label61.Text = "Search products by supplier:"
        '
        'btnSearchProdBySupp
        '
        Me.btnSearchProdBySupp.Location = New System.Drawing.Point(301, 54)
        Me.btnSearchProdBySupp.Name = "btnSearchProdBySupp"
        Me.btnSearchProdBySupp.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchProdBySupp.TabIndex = 18
        Me.btnSearchProdBySupp.Text = "SEARCH"
        Me.btnSearchProdBySupp.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(25, 129)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(88, 18)
        Me.Label60.TabIndex = 13
        Me.Label60.Text = "Product List:"
        '
        'dgvProductsBySupplier
        '
        Me.dgvProductsBySupplier.AllowUserToAddRows = False
        Me.dgvProductsBySupplier.AllowUserToOrderColumns = True
        Me.dgvProductsBySupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductsBySupplier.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductsBySupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductsBySupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductsBySupplier.Location = New System.Drawing.Point(19, 151)
        Me.dgvProductsBySupplier.Name = "dgvProductsBySupplier"
        Me.dgvProductsBySupplier.ReadOnly = True
        Me.dgvProductsBySupplier.RowTemplate.Height = 25
        Me.dgvProductsBySupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsBySupplier.Size = New System.Drawing.Size(843, 251)
        Me.dgvProductsBySupplier.TabIndex = 12
        '
        'pnlSales
        '
        Me.pnlSales.Controls.Add(Me.TabControl5)
        Me.pnlSales.Location = New System.Drawing.Point(186, 126)
        Me.pnlSales.Name = "pnlSales"
        Me.pnlSales.Size = New System.Drawing.Size(916, 464)
        Me.pnlSales.TabIndex = 8
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabPage11)
        Me.TabControl5.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TabControl5.Location = New System.Drawing.Point(9, 3)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(904, 461)
        Me.TabControl5.TabIndex = 10
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.Color.Transparent
        Me.TabPage11.Controls.Add(Me.lblDtpFrom)
        Me.TabPage11.Controls.Add(Me.lblDtp)
        Me.TabPage11.Controls.Add(Me.dtpUntil)
        Me.TabPage11.Controls.Add(Me.dtpFrom)
        Me.TabPage11.Controls.Add(Me.pbxRefreshSalesHistory)
        Me.TabPage11.Controls.Add(Me.cboFilter)
        Me.TabPage11.Controls.Add(Me.Label50)
        Me.TabPage11.Controls.Add(Me.dgvSalesHistory)
        Me.TabPage11.Controls.Add(Me.GroupBox7)
        Me.TabPage11.Location = New System.Drawing.Point(4, 27)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(896, 430)
        Me.TabPage11.TabIndex = 0
        Me.TabPage11.Text = "Sales History"
        '
        'lblDtpFrom
        '
        Me.lblDtpFrom.AutoSize = True
        Me.lblDtpFrom.Location = New System.Drawing.Point(373, 20)
        Me.lblDtpFrom.Name = "lblDtpFrom"
        Me.lblDtpFrom.Size = New System.Drawing.Size(46, 18)
        Me.lblDtpFrom.TabIndex = 19
        Me.lblDtpFrom.Text = "From:"
        Me.lblDtpFrom.Visible = False
        '
        'lblDtp
        '
        Me.lblDtp.AutoSize = True
        Me.lblDtp.Location = New System.Drawing.Point(526, 20)
        Me.lblDtp.Name = "lblDtp"
        Me.lblDtp.Size = New System.Drawing.Size(24, 18)
        Me.lblDtp.TabIndex = 18
        Me.lblDtp.Text = "to:"
        Me.lblDtp.Visible = False
        '
        'dtpUntil
        '
        Me.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpUntil.Location = New System.Drawing.Point(557, 18)
        Me.dtpUntil.MaxDate = New Date(2022, 5, 29, 0, 0, 0, 0)
        Me.dtpUntil.Name = "dtpUntil"
        Me.dtpUntil.Size = New System.Drawing.Size(100, 23)
        Me.dtpUntil.TabIndex = 17
        Me.dtpUntil.Value = New Date(2022, 5, 29, 0, 0, 0, 0)
        Me.dtpUntil.Visible = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(422, 18)
        Me.dtpFrom.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(98, 23)
        Me.dtpFrom.TabIndex = 16
        Me.dtpFrom.Visible = False
        '
        'pbxRefreshSalesHistory
        '
        Me.pbxRefreshSalesHistory.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.refresh_32px
        Me.pbxRefreshSalesHistory.Location = New System.Drawing.Point(837, 11)
        Me.pbxRefreshSalesHistory.Name = "pbxRefreshSalesHistory"
        Me.pbxRefreshSalesHistory.Size = New System.Drawing.Size(30, 30)
        Me.pbxRefreshSalesHistory.TabIndex = 15
        Me.pbxRefreshSalesHistory.TabStop = False
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"None", "Employee", "Year", "Month", "Day", "All filter", "Custom"})
        Me.cboFilter.Location = New System.Drawing.Point(113, 16)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(180, 26)
        Me.cboFilter.TabIndex = 14
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(49, 19)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(62, 18)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Filter by:"
        '
        'dgvSalesHistory
        '
        Me.dgvSalesHistory.AllowUserToAddRows = False
        Me.dgvSalesHistory.AllowUserToDeleteRows = False
        Me.dgvSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSalesHistory.Location = New System.Drawing.Point(27, 141)
        Me.dgvSalesHistory.Name = "dgvSalesHistory"
        Me.dgvSalesHistory.ReadOnly = True
        Me.dgvSalesHistory.RowTemplate.Height = 25
        Me.dgvSalesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesHistory.Size = New System.Drawing.Size(843, 279)
        Me.dgvSalesHistory.TabIndex = 6
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnPrintPreviewSalesRecord)
        Me.GroupBox7.Controls.Add(Me.btnSearchSalesRecord)
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.Controls.Add(Me.cboYear)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.Label46)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.cboDay)
        Me.GroupBox7.Controls.Add(Me.cboMonth)
        Me.GroupBox7.Controls.Add(Me.cboEmployeeID)
        Me.GroupBox7.Location = New System.Drawing.Point(33, 52)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(837, 84)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filter"
        '
        'btnPrintPreviewSalesRecord
        '
        Me.btnPrintPreviewSalesRecord.Location = New System.Drawing.Point(703, 47)
        Me.btnPrintPreviewSalesRecord.Name = "btnPrintPreviewSalesRecord"
        Me.btnPrintPreviewSalesRecord.Size = New System.Drawing.Size(131, 26)
        Me.btnPrintPreviewSalesRecord.TabIndex = 10
        Me.btnPrintPreviewSalesRecord.Text = "PRINT PREVIEW"
        Me.btnPrintPreviewSalesRecord.UseVisualStyleBackColor = True
        '
        'btnSearchSalesRecord
        '
        Me.btnSearchSalesRecord.Location = New System.Drawing.Point(726, 19)
        Me.btnSearchSalesRecord.Name = "btnSearchSalesRecord"
        Me.btnSearchSalesRecord.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchSalesRecord.TabIndex = 9
        Me.btnSearchSalesRecord.Text = "SEARCH"
        Me.btnSearchSalesRecord.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(266, 34)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(54, 18)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Month:"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.IntegralHeight = False
        Me.cboYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045"})
        Me.cboYear.Location = New System.Drawing.Point(604, 30)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(73, 26)
        Me.cboYear.TabIndex = 2
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(466, 34)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(37, 18)
        Me.Label47.TabIndex = 6
        Me.Label47.Text = "Day:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(565, 34)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(39, 18)
        Me.Label46.TabIndex = 5
        Me.Label46.Text = "Year:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(15, 34)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(95, 18)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Employee ID:"
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.IntegralHeight = False
        Me.cboDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboDay.Location = New System.Drawing.Point(503, 30)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(58, 26)
        Me.cboDay.TabIndex = 3
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.IntegralHeight = False
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(320, 30)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(142, 26)
        Me.cboMonth.TabIndex = 1
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.IntegralHeight = False
        Me.cboEmployeeID.Location = New System.Drawing.Point(110, 30)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(150, 26)
        Me.cboEmployeeID.TabIndex = 0
        '
        'pnlSettings
        '
        Me.pnlSettings.Controls.Add(Me.PictureBox2)
        Me.pnlSettings.Controls.Add(Me.btnVariables)
        Me.pnlSettings.Controls.Add(Me.pbxRestore)
        Me.pnlSettings.Controls.Add(Me.pbxBackUp)
        Me.pnlSettings.Controls.Add(Me.btnRestore)
        Me.pnlSettings.Controls.Add(Me.btnBackUp)
        Me.pnlSettings.Location = New System.Drawing.Point(186, 126)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(916, 464)
        Me.pnlSettings.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.variables
        Me.PictureBox2.Location = New System.Drawing.Point(86, 101)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnVariables
        '
        Me.btnVariables.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnVariables.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVariables.ForeColor = System.Drawing.Color.White
        Me.btnVariables.Location = New System.Drawing.Point(75, 284)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(243, 107)
        Me.btnVariables.TabIndex = 4
        Me.btnVariables.Text = "SYSTEM VARIABLES"
        Me.btnVariables.UseVisualStyleBackColor = False
        '
        'pbxRestore
        '
        Me.pbxRestore.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.restore
        Me.pbxRestore.Location = New System.Drawing.Point(595, 103)
        Me.pbxRestore.Name = "pbxRestore"
        Me.pbxRestore.Size = New System.Drawing.Size(220, 180)
        Me.pbxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxRestore.TabIndex = 3
        Me.pbxRestore.TabStop = False
        '
        'pbxBackUp
        '
        Me.pbxBackUp.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.backup
        Me.pbxBackUp.Location = New System.Drawing.Point(344, 103)
        Me.pbxBackUp.Name = "pbxBackUp"
        Me.pbxBackUp.Size = New System.Drawing.Size(220, 180)
        Me.pbxBackUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBackUp.TabIndex = 2
        Me.pbxBackUp.TabStop = False
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnRestore.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Location = New System.Drawing.Point(584, 286)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(243, 107)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "RESTORE DATABASE"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btnBackUp
        '
        Me.btnBackUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBackUp.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.ForeColor = System.Drawing.Color.White
        Me.btnBackUp.Location = New System.Drawing.Point(333, 286)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(243, 107)
        Me.btnBackUp.TabIndex = 0
        Me.btnBackUp.Text = "BACKUP DATABASE"
        Me.btnBackUp.UseVisualStyleBackColor = False
        '
        'pnlReports
        '
        Me.pnlReports.Controls.Add(Me.pbxLossReport)
        Me.pnlReports.Controls.Add(Me.btnLossReport)
        Me.pnlReports.Controls.Add(Me.pbxStockOutReport)
        Me.pnlReports.Controls.Add(Me.pbxStockInHistory)
        Me.pnlReports.Controls.Add(Me.pbxProductsReport)
        Me.pnlReports.Controls.Add(Me.btnProductsReport)
        Me.pnlReports.Controls.Add(Me.btnStockOutReports)
        Me.pnlReports.Controls.Add(Me.btnStockInReports)
        Me.pnlReports.Controls.Add(Me.dgvReports)
        Me.pnlReports.Location = New System.Drawing.Point(186, 126)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(916, 464)
        Me.pnlReports.TabIndex = 8
        '
        'pbxLossReport
        '
        Me.pbxLossReport.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.breakage
        Me.pbxLossReport.Location = New System.Drawing.Point(263, 104)
        Me.pbxLossReport.Name = "pbxLossReport"
        Me.pbxLossReport.Size = New System.Drawing.Size(165, 131)
        Me.pbxLossReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLossReport.TabIndex = 12
        Me.pbxLossReport.TabStop = False
        '
        'btnLossReport
        '
        Me.btnLossReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnLossReport.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLossReport.ForeColor = System.Drawing.Color.White
        Me.btnLossReport.Location = New System.Drawing.Point(245, 235)
        Me.btnLossReport.Name = "btnLossReport"
        Me.btnLossReport.Size = New System.Drawing.Size(200, 85)
        Me.btnLossReport.TabIndex = 11
        Me.btnLossReport.Text = "PRODUCT LOSS REPORT"
        Me.btnLossReport.UseVisualStyleBackColor = False
        '
        'pbxStockOutReport
        '
        Me.pbxStockOutReport.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.out_of_stock__2_
        Me.pbxStockOutReport.Location = New System.Drawing.Point(697, 104)
        Me.pbxStockOutReport.Name = "pbxStockOutReport"
        Me.pbxStockOutReport.Size = New System.Drawing.Size(165, 131)
        Me.pbxStockOutReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStockOutReport.TabIndex = 9
        Me.pbxStockOutReport.TabStop = False
        '
        'pbxStockInHistory
        '
        Me.pbxStockInHistory.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.delivery
        Me.pbxStockInHistory.Location = New System.Drawing.Point(480, 104)
        Me.pbxStockInHistory.Name = "pbxStockInHistory"
        Me.pbxStockInHistory.Size = New System.Drawing.Size(165, 131)
        Me.pbxStockInHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStockInHistory.TabIndex = 8
        Me.pbxStockInHistory.TabStop = False
        '
        'pbxProductsReport
        '
        Me.pbxProductsReport.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.box__1_
        Me.pbxProductsReport.Location = New System.Drawing.Point(46, 104)
        Me.pbxProductsReport.Name = "pbxProductsReport"
        Me.pbxProductsReport.Size = New System.Drawing.Size(165, 131)
        Me.pbxProductsReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxProductsReport.TabIndex = 6
        Me.pbxProductsReport.TabStop = False
        '
        'btnProductsReport
        '
        Me.btnProductsReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnProductsReport.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductsReport.ForeColor = System.Drawing.Color.White
        Me.btnProductsReport.Location = New System.Drawing.Point(28, 235)
        Me.btnProductsReport.Name = "btnProductsReport"
        Me.btnProductsReport.Size = New System.Drawing.Size(200, 85)
        Me.btnProductsReport.TabIndex = 5
        Me.btnProductsReport.Text = "PRODUCTS REPORT"
        Me.btnProductsReport.UseVisualStyleBackColor = False
        '
        'btnStockOutReports
        '
        Me.btnStockOutReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnStockOutReports.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOutReports.ForeColor = System.Drawing.Color.White
        Me.btnStockOutReports.Location = New System.Drawing.Point(679, 235)
        Me.btnStockOutReports.Name = "btnStockOutReports"
        Me.btnStockOutReports.Size = New System.Drawing.Size(200, 85)
        Me.btnStockOutReports.TabIndex = 3
        Me.btnStockOutReports.Text = "STOCK-OUT REPORT"
        Me.btnStockOutReports.UseVisualStyleBackColor = False
        '
        'btnStockInReports
        '
        Me.btnStockInReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnStockInReports.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockInReports.ForeColor = System.Drawing.Color.White
        Me.btnStockInReports.Location = New System.Drawing.Point(462, 235)
        Me.btnStockInReports.Name = "btnStockInReports"
        Me.btnStockInReports.Size = New System.Drawing.Size(200, 85)
        Me.btnStockInReports.TabIndex = 2
        Me.btnStockInReports.Text = "STOCK-IN HISTORY REPORT"
        Me.btnStockInReports.UseVisualStyleBackColor = False
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = False
        Me.dgvReports.AllowUserToDeleteRows = False
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(38, 248)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.ReadOnly = True
        Me.dgvReports.Size = New System.Drawing.Size(50, 50)
        Me.dgvReports.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.analysis
        Me.PictureBox1.Location = New System.Drawing.Point(46, 283)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnDataAnalysis
        '
        Me.btnDataAnalysis.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDataAnalysis.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataAnalysis.ForeColor = System.Drawing.Color.Black
        Me.btnDataAnalysis.Location = New System.Drawing.Point(46, 389)
        Me.btnDataAnalysis.Name = "btnDataAnalysis"
        Me.btnDataAnalysis.Size = New System.Drawing.Size(138, 54)
        Me.btnDataAnalysis.TabIndex = 13
        Me.btnDataAnalysis.Text = "DATA ANALYTICS"
        Me.btnDataAnalysis.UseVisualStyleBackColor = False
        '
        'pnlEmployees
        '
        Me.pnlEmployees.Controls.Add(Me.TabControl4)
        Me.pnlEmployees.Location = New System.Drawing.Point(186, 126)
        Me.pnlEmployees.Name = "pnlEmployees"
        Me.pnlEmployees.Size = New System.Drawing.Size(916, 464)
        Me.pnlEmployees.TabIndex = 8
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage9)
        Me.TabControl4.Controls.Add(TabPage10)
        Me.TabControl4.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TabControl4.Location = New System.Drawing.Point(9, 3)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(904, 461)
        Me.TabControl4.TabIndex = 10
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.Transparent
        Me.TabPage9.Controls.Add(Me.GroupBox6)
        Me.TabPage9.Controls.Add(Me.btnEmployeeSearch)
        Me.TabPage9.Controls.Add(Me.txtEmployeeSearch)
        Me.TabPage9.Controls.Add(Me.Label43)
        Me.TabPage9.Controls.Add(Me.dgvEmployeeList)
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(896, 430)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Employee Details"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboSecurityQuestion)
        Me.GroupBox6.Controls.Add(Me.cboUserLevel)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.txtSecurityAnswer)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.txtEmployeePassword)
        Me.GroupBox6.Controls.Add(Me.txtEmployeeUsername)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.txtEmployeeContactNo)
        Me.GroupBox6.Controls.Add(Me.btnClearEmployee)
        Me.GroupBox6.Controls.Add(Me.btnUpdateEmployee)
        Me.GroupBox6.Controls.Add(Me.btnDeleteEmployee)
        Me.GroupBox6.Controls.Add(Me.btnAddEmployee)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.Label42)
        Me.GroupBox6.Controls.Add(Me.txtEmployeeLastName)
        Me.GroupBox6.Controls.Add(Me.txtEmployeeMiddleName)
        Me.GroupBox6.Controls.Add(Me.txtEmployeeFirstName)
        Me.GroupBox6.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Customer Details"
        '
        'cboSecurityQuestion
        '
        Me.cboSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecurityQuestion.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSecurityQuestion.FormattingEnabled = True
        Me.cboSecurityQuestion.Items.AddRange(New Object() {"What is your mother's maiden name?", "What is the name of your first pet?", "What was your first car?", "What elementary school did you attend?", "Who was your childhood hero?"})
        Me.cboSecurityQuestion.Location = New System.Drawing.Point(436, 104)
        Me.cboSecurityQuestion.Name = "cboSecurityQuestion"
        Me.cboSecurityQuestion.Size = New System.Drawing.Size(250, 23)
        Me.cboSecurityQuestion.TabIndex = 28
        '
        'cboUserLevel
        '
        Me.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserLevel.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboUserLevel.FormattingEnabled = True
        Me.cboUserLevel.Items.AddRange(New Object() {"Cashier"})
        Me.cboUserLevel.Location = New System.Drawing.Point(133, 32)
        Me.cboUserLevel.Name = "cboUserLevel"
        Me.cboUserLevel.Size = New System.Drawing.Size(167, 24)
        Me.cboUserLevel.TabIndex = 27
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(312, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 18)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "Security Answer:"
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(436, 129)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(250, 23)
        Me.txtSecurityAnswer.TabIndex = 25
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(312, 107)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(125, 18)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "Security Question:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(312, 59)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 18)
        Me.Label32.TabIndex = 23
        Me.Label32.Text = "Password:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(312, 35)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(79, 18)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Username:"
        '
        'txtEmployeePassword
        '
        Me.txtEmployeePassword.Location = New System.Drawing.Point(436, 57)
        Me.txtEmployeePassword.Name = "txtEmployeePassword"
        Me.txtEmployeePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmployeePassword.Size = New System.Drawing.Size(182, 23)
        Me.txtEmployeePassword.TabIndex = 20
        '
        'txtEmployeeUsername
        '
        Me.txtEmployeeUsername.Location = New System.Drawing.Point(436, 33)
        Me.txtEmployeeUsername.Name = "txtEmployeeUsername"
        Me.txtEmployeeUsername.Size = New System.Drawing.Size(182, 23)
        Me.txtEmployeeUsername.TabIndex = 19
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(21, 131)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(87, 18)
        Me.Label35.TabIndex = 18
        Me.Label35.Text = "Contact No.:"
        '
        'txtEmployeeContactNo
        '
        Me.txtEmployeeContactNo.Location = New System.Drawing.Point(133, 129)
        Me.txtEmployeeContactNo.Name = "txtEmployeeContactNo"
        Me.txtEmployeeContactNo.Size = New System.Drawing.Size(167, 23)
        Me.txtEmployeeContactNo.TabIndex = 17
        '
        'btnClearEmployee
        '
        Me.btnClearEmployee.Location = New System.Drawing.Point(708, 121)
        Me.btnClearEmployee.Name = "btnClearEmployee"
        Me.btnClearEmployee.Size = New System.Drawing.Size(100, 26)
        Me.btnClearEmployee.TabIndex = 16
        Me.btnClearEmployee.Text = "CLEAR"
        Me.btnClearEmployee.UseVisualStyleBackColor = True
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(708, 57)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(100, 26)
        Me.btnUpdateEmployee.TabIndex = 15
        Me.btnUpdateEmployee.Text = "UPDATE"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Enabled = False
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(708, 96)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(100, 26)
        Me.btnDeleteEmployee.TabIndex = 14
        Me.btnDeleteEmployee.Text = "DELETE"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(708, 31)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(100, 26)
        Me.btnAddEmployee.TabIndex = 5
        Me.btnAddEmployee.Text = "ADD"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(21, 107)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(82, 18)
        Me.Label38.TabIndex = 7
        Me.Label38.Text = "Last Name:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(21, 83)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(99, 18)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Middle Name:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(21, 59)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(82, 18)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "First Name:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(21, 35)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 18)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "User Level:"
        '
        'txtEmployeeLastName
        '
        Me.txtEmployeeLastName.Location = New System.Drawing.Point(133, 105)
        Me.txtEmployeeLastName.Name = "txtEmployeeLastName"
        Me.txtEmployeeLastName.Size = New System.Drawing.Size(167, 23)
        Me.txtEmployeeLastName.TabIndex = 3
        '
        'txtEmployeeMiddleName
        '
        Me.txtEmployeeMiddleName.Location = New System.Drawing.Point(133, 81)
        Me.txtEmployeeMiddleName.Name = "txtEmployeeMiddleName"
        Me.txtEmployeeMiddleName.Size = New System.Drawing.Size(167, 23)
        Me.txtEmployeeMiddleName.TabIndex = 2
        '
        'txtEmployeeFirstName
        '
        Me.txtEmployeeFirstName.Location = New System.Drawing.Point(133, 57)
        Me.txtEmployeeFirstName.Name = "txtEmployeeFirstName"
        Me.txtEmployeeFirstName.Size = New System.Drawing.Size(167, 23)
        Me.txtEmployeeFirstName.TabIndex = 1
        '
        'btnEmployeeSearch
        '
        Me.btnEmployeeSearch.Location = New System.Drawing.Point(795, 15)
        Me.btnEmployeeSearch.Name = "btnEmployeeSearch"
        Me.btnEmployeeSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnEmployeeSearch.TabIndex = 13
        Me.btnEmployeeSearch.Text = "SEARCH"
        Me.btnEmployeeSearch.UseVisualStyleBackColor = True
        '
        'txtEmployeeSearch
        '
        Me.txtEmployeeSearch.Location = New System.Drawing.Point(606, 17)
        Me.txtEmployeeSearch.Name = "txtEmployeeSearch"
        Me.txtEmployeeSearch.Size = New System.Drawing.Size(183, 23)
        Me.txtEmployeeSearch.TabIndex = 12
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(33, 19)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(102, 18)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Employee List:"
        '
        'dgvEmployeeList
        '
        Me.dgvEmployeeList.AllowUserToAddRows = False
        Me.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployeeList.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployeeList.Location = New System.Drawing.Point(27, 41)
        Me.dgvEmployeeList.Name = "dgvEmployeeList"
        Me.dgvEmployeeList.ReadOnly = True
        Me.dgvEmployeeList.RowTemplate.Height = 25
        Me.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeList.Size = New System.Drawing.Size(843, 189)
        Me.dgvEmployeeList.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbxExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 126)
        Me.Panel1.TabIndex = 9
        '
        'pbxExit
        '
        Me.pbxExit.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExit.Location = New System.Drawing.Point(1048, 12)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(40, 40)
        Me.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExit.TabIndex = 1
        Me.pbxExit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mohave", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ambergrey Trading"
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(Me.TabControl1)
        Me.pnlProducts.Location = New System.Drawing.Point(186, 126)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(916, 464)
        Me.pnlProducts.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TabControl1.Location = New System.Drawing.Point(9, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(904, 461)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnSearchProduct)
        Me.TabPage1.Controls.Add(Me.txtSearchProduct)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgvProductsProductList)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(896, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Products"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.cboVariant)
        Me.GroupBox1.Controls.Add(Me.cboProdName)
        Me.GroupBox1.Controls.Add(Me.cboSize)
        Me.GroupBox1.Controls.Add(Me.cboContainer)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.btnClearProductDetails)
        Me.GroupBox1.Controls.Add(Me.btnUpdateProduct)
        Me.GroupBox1.Controls.Add(Me.btnDeleteProduct)
        Me.GroupBox1.Controls.Add(Me.btnAddProduct)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProductPrice)
        Me.GroupBox1.Controls.Add(Me.txtProductID)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(21, 91)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(57, 18)
        Me.Label59.TabIndex = 23
        Me.Label59.Text = "Variant:"
        '
        'cboVariant
        '
        Me.cboVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVariant.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboVariant.FormattingEnabled = True
        Me.cboVariant.IntegralHeight = False
        Me.cboVariant.Items.AddRange(New Object() {"Can", "Glass Bottle", "Plastic Bottle"})
        Me.cboVariant.Location = New System.Drawing.Point(133, 88)
        Me.cboVariant.MaxDropDownItems = 5
        Me.cboVariant.Name = "cboVariant"
        Me.cboVariant.Size = New System.Drawing.Size(212, 24)
        Me.cboVariant.TabIndex = 22
        '
        'cboProdName
        '
        Me.cboProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProdName.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboProdName.FormattingEnabled = True
        Me.cboProdName.IntegralHeight = False
        Me.cboProdName.Items.AddRange(New Object() {"Can", "Glass Bottle", "Plastic Bottle"})
        Me.cboProdName.Location = New System.Drawing.Point(133, 58)
        Me.cboProdName.MaxDropDownItems = 5
        Me.cboProdName.Name = "cboProdName"
        Me.cboProdName.Size = New System.Drawing.Size(212, 24)
        Me.cboProdName.TabIndex = 21
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.IntegralHeight = False
        Me.cboSize.Items.AddRange(New Object() {"Can", "Glass Bottle", "Plastic Bottle"})
        Me.cboSize.Location = New System.Drawing.Point(440, 58)
        Me.cboSize.MaxDropDownItems = 5
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(212, 24)
        Me.cboSize.TabIndex = 20
        '
        'cboContainer
        '
        Me.cboContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContainer.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboContainer.FormattingEnabled = True
        Me.cboContainer.IntegralHeight = False
        Me.cboContainer.Location = New System.Drawing.Point(133, 118)
        Me.cboContainer.MaxDropDownItems = 5
        Me.cboContainer.Name = "cboContainer"
        Me.cboContainer.Size = New System.Drawing.Size(212, 24)
        Me.cboContainer.TabIndex = 19
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(21, 121)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(109, 18)
        Me.Label49.TabIndex = 18
        Me.Label49.Text = "Container Type:"
        '
        'btnClearProductDetails
        '
        Me.btnClearProductDetails.Location = New System.Drawing.Point(708, 118)
        Me.btnClearProductDetails.Name = "btnClearProductDetails"
        Me.btnClearProductDetails.Size = New System.Drawing.Size(100, 26)
        Me.btnClearProductDetails.TabIndex = 16
        Me.btnClearProductDetails.Text = "CLEAR"
        Me.btnClearProductDetails.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(708, 60)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(100, 26)
        Me.btnUpdateProduct.TabIndex = 15
        Me.btnUpdateProduct.Text = "UPDATE"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Enabled = False
        Me.btnDeleteProduct.Location = New System.Drawing.Point(708, 89)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(100, 26)
        Me.btnDeleteProduct.TabIndex = 14
        Me.btnDeleteProduct.Text = "DELETE"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProduct.Location = New System.Drawing.Point(708, 31)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(100, 26)
        Me.btnAddProduct.TabIndex = 5
        Me.btnAddProduct.Text = "ADD"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Alcoholic", "Non-Alcoholic"})
        Me.cboCategory.Location = New System.Drawing.Point(440, 118)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(212, 24)
        Me.cboCategory.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Category:"
        '
        'cboSupplier
        '
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.IntegralHeight = False
        Me.cboSupplier.Location = New System.Drawing.Point(440, 88)
        Me.cboSupplier.MaxDropDownItems = 5
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(212, 24)
        Me.cboSupplier.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(368, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Supplier:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Size(ml):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product ID:"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(440, 29)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(212, 23)
        Me.txtProductPrice.TabIndex = 2
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(133, 29)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(212, 23)
        Me.txtProductID.TabIndex = 0
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSearchProduct.Location = New System.Drawing.Point(795, 15)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchProduct.TabIndex = 3
        Me.btnSearchProduct.Text = "SEARCH"
        Me.btnSearchProduct.UseVisualStyleBackColor = False
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(606, 17)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(183, 23)
        Me.txtSearchProduct.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product List:"
        '
        'dgvProductsProductList
        '
        Me.dgvProductsProductList.AllowUserToAddRows = False
        Me.dgvProductsProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductsProductList.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductsProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductsProductList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductsProductList.Location = New System.Drawing.Point(27, 41)
        Me.dgvProductsProductList.Name = "dgvProductsProductList"
        Me.dgvProductsProductList.ReadOnly = True
        Me.dgvProductsProductList.RowTemplate.Height = 25
        Me.dgvProductsProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductsProductList.Size = New System.Drawing.Size(843, 189)
        Me.dgvProductsProductList.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.dgvStockInHistory)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(896, 430)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock History"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Stock In History:"
        '
        'dgvStockInHistory
        '
        Me.dgvStockInHistory.AllowUserToAddRows = False
        Me.dgvStockInHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockInHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvStockInHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockInHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvStockInHistory.Location = New System.Drawing.Point(27, 41)
        Me.dgvStockInHistory.Name = "dgvStockInHistory"
        Me.dgvStockInHistory.ReadOnly = True
        Me.dgvStockInHistory.RowTemplate.Height = 25
        Me.dgvStockInHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStockInHistory.Size = New System.Drawing.Size(843, 359)
        Me.dgvStockInHistory.TabIndex = 5
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.btnSearchProductDefective)
        Me.TabPage4.Controls.Add(Me.txtSearchProductDefective)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.dgvProductListDefect)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(896, 430)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Add Defective Items"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClearDefectiveDetails)
        Me.GroupBox3.Controls.Add(Me.btnAddDefectiveDetails)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtRemarksDefect)
        Me.GroupBox3.Controls.Add(Me.txtQuantityDefect)
        Me.GroupBox3.Controls.Add(Me.txtSupplierDefect)
        Me.GroupBox3.Controls.Add(Me.txtProductNameDefect)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Details"
        '
        'btnClearDefectiveDetails
        '
        Me.btnClearDefectiveDetails.Location = New System.Drawing.Point(708, 89)
        Me.btnClearDefectiveDetails.Name = "btnClearDefectiveDetails"
        Me.btnClearDefectiveDetails.Size = New System.Drawing.Size(100, 26)
        Me.btnClearDefectiveDetails.TabIndex = 14
        Me.btnClearDefectiveDetails.Text = "CLEAR"
        Me.btnClearDefectiveDetails.UseVisualStyleBackColor = True
        '
        'btnAddDefectiveDetails
        '
        Me.btnAddDefectiveDetails.Location = New System.Drawing.Point(708, 31)
        Me.btnAddDefectiveDetails.Name = "btnAddDefectiveDetails"
        Me.btnAddDefectiveDetails.Size = New System.Drawing.Size(100, 26)
        Me.btnAddDefectiveDetails.TabIndex = 5
        Me.btnAddDefectiveDetails.Text = "ADD"
        Me.btnAddDefectiveDetails.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Remarks:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Quantity:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 18)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Supplier:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 18)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Product ID:"
        '
        'txtRemarksDefect
        '
        Me.txtRemarksDefect.Location = New System.Drawing.Point(133, 120)
        Me.txtRemarksDefect.Name = "txtRemarksDefect"
        Me.txtRemarksDefect.Size = New System.Drawing.Size(212, 23)
        Me.txtRemarksDefect.TabIndex = 3
        '
        'txtQuantityDefect
        '
        Me.txtQuantityDefect.Location = New System.Drawing.Point(133, 91)
        Me.txtQuantityDefect.Name = "txtQuantityDefect"
        Me.txtQuantityDefect.Size = New System.Drawing.Size(212, 23)
        Me.txtQuantityDefect.TabIndex = 2
        '
        'txtSupplierDefect
        '
        Me.txtSupplierDefect.Location = New System.Drawing.Point(133, 62)
        Me.txtSupplierDefect.Name = "txtSupplierDefect"
        Me.txtSupplierDefect.ReadOnly = True
        Me.txtSupplierDefect.Size = New System.Drawing.Size(212, 23)
        Me.txtSupplierDefect.TabIndex = 1
        '
        'txtProductNameDefect
        '
        Me.txtProductNameDefect.Location = New System.Drawing.Point(133, 33)
        Me.txtProductNameDefect.Name = "txtProductNameDefect"
        Me.txtProductNameDefect.ReadOnly = True
        Me.txtProductNameDefect.Size = New System.Drawing.Size(212, 23)
        Me.txtProductNameDefect.TabIndex = 0
        '
        'btnSearchProductDefective
        '
        Me.btnSearchProductDefective.Location = New System.Drawing.Point(795, 15)
        Me.btnSearchProductDefective.Name = "btnSearchProductDefective"
        Me.btnSearchProductDefective.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchProductDefective.TabIndex = 8
        Me.btnSearchProductDefective.Text = "SEARCH"
        Me.btnSearchProductDefective.UseVisualStyleBackColor = True
        '
        'txtSearchProductDefective
        '
        Me.txtSearchProductDefective.Location = New System.Drawing.Point(606, 17)
        Me.txtSearchProductDefective.Name = "txtSearchProductDefective"
        Me.txtSearchProductDefective.Size = New System.Drawing.Size(183, 23)
        Me.txtSearchProductDefective.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Product List:"
        '
        'dgvProductListDefect
        '
        Me.dgvProductListDefect.AllowUserToAddRows = False
        Me.dgvProductListDefect.AllowUserToDeleteRows = False
        Me.dgvProductListDefect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductListDefect.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductListDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductListDefect.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductListDefect.Location = New System.Drawing.Point(27, 41)
        Me.dgvProductListDefect.Name = "dgvProductListDefect"
        Me.dgvProductListDefect.ReadOnly = True
        Me.dgvProductListDefect.RowTemplate.Height = 25
        Me.dgvProductListDefect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductListDefect.Size = New System.Drawing.Size(843, 189)
        Me.dgvProductListDefect.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Transparent
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.dgvDefectiveItemHistory)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(896, 430)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Defective Items"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Defective Items History:"
        '
        'dgvDefectiveItemHistory
        '
        Me.dgvDefectiveItemHistory.AllowUserToAddRows = False
        Me.dgvDefectiveItemHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDefectiveItemHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvDefectiveItemHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDefectiveItemHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDefectiveItemHistory.Location = New System.Drawing.Point(27, 41)
        Me.dgvDefectiveItemHistory.Name = "dgvDefectiveItemHistory"
        Me.dgvDefectiveItemHistory.ReadOnly = True
        Me.dgvDefectiveItemHistory.RowTemplate.Height = 25
        Me.dgvDefectiveItemHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDefectiveItemHistory.Size = New System.Drawing.Size(843, 359)
        Me.dgvDefectiveItemHistory.TabIndex = 6
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.Transparent
        Me.TabPage6.Controls.Add(Me.Label12)
        Me.TabPage6.Controls.Add(Me.dgvOutOfStock)
        Me.TabPage6.Location = New System.Drawing.Point(4, 27)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(896, 430)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Stock Out Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Out of Stock List:"
        '
        'dgvOutOfStock
        '
        Me.dgvOutOfStock.AllowUserToAddRows = False
        Me.dgvOutOfStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutOfStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvOutOfStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutOfStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOutOfStock.Location = New System.Drawing.Point(27, 41)
        Me.dgvOutOfStock.Name = "dgvOutOfStock"
        Me.dgvOutOfStock.ReadOnly = True
        Me.dgvOutOfStock.RowTemplate.Height = 25
        Me.dgvOutOfStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOutOfStock.Size = New System.Drawing.Size(843, 359)
        Me.dgvOutOfStock.TabIndex = 7
        '
        'pnlCustomers
        '
        Me.pnlCustomers.Controls.Add(Me.TabControl2)
        Me.pnlCustomers.Location = New System.Drawing.Point(186, 126)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Size = New System.Drawing.Size(916, 464)
        Me.pnlCustomers.TabIndex = 10
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TabControl2.Location = New System.Drawing.Point(9, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(904, 461)
        Me.TabControl2.TabIndex = 10
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.Transparent
        Me.TabPage7.Controls.Add(Me.GroupBox4)
        Me.TabPage7.Controls.Add(Me.btnSearchCustomer)
        Me.TabPage7.Controls.Add(Me.txtCustomerSearch)
        Me.TabPage7.Controls.Add(Me.Label26)
        Me.TabPage7.Controls.Add(Me.dgvCustomerList)
        Me.TabPage7.Location = New System.Drawing.Point(4, 27)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(896, 430)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Customer Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtMunicipalityCustomer)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txtBarangayCustomer)
        Me.GroupBox4.Controls.Add(Me.txtStreetCustomer)
        Me.GroupBox4.Controls.Add(Me.txtHouseNoCustomer)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtContactCustomer)
        Me.GroupBox4.Controls.Add(Me.btnClearCustomer)
        Me.GroupBox4.Controls.Add(Me.btnUpdateCustomer)
        Me.GroupBox4.Controls.Add(Me.btnDeleteCustomer)
        Me.GroupBox4.Controls.Add(Me.btnAddCustomer)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtLastNameCustomer)
        Me.GroupBox4.Controls.Add(Me.txtMiddleNameCustomer)
        Me.GroupBox4.Controls.Add(Me.txtFirstNameCustomer)
        Me.GroupBox4.Controls.Add(Me.txtCustomerID)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(843, 160)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Details"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(356, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 18)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Municipality:"
        '
        'txtMunicipalityCustomer
        '
        Me.txtMunicipalityCustomer.Location = New System.Drawing.Point(468, 105)
        Me.txtMunicipalityCustomer.Name = "txtMunicipalityCustomer"
        Me.txtMunicipalityCustomer.Size = New System.Drawing.Size(182, 23)
        Me.txtMunicipalityCustomer.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(356, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 18)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Barangay:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(356, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(50, 18)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Street:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(356, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 18)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "House No.:"
        '
        'txtBarangayCustomer
        '
        Me.txtBarangayCustomer.Location = New System.Drawing.Point(468, 81)
        Me.txtBarangayCustomer.Name = "txtBarangayCustomer"
        Me.txtBarangayCustomer.Size = New System.Drawing.Size(182, 23)
        Me.txtBarangayCustomer.TabIndex = 21
        '
        'txtStreetCustomer
        '
        Me.txtStreetCustomer.Location = New System.Drawing.Point(468, 57)
        Me.txtStreetCustomer.Name = "txtStreetCustomer"
        Me.txtStreetCustomer.Size = New System.Drawing.Size(182, 23)
        Me.txtStreetCustomer.TabIndex = 20
        '
        'txtHouseNoCustomer
        '
        Me.txtHouseNoCustomer.Location = New System.Drawing.Point(468, 33)
        Me.txtHouseNoCustomer.Name = "txtHouseNoCustomer"
        Me.txtHouseNoCustomer.Size = New System.Drawing.Size(182, 23)
        Me.txtHouseNoCustomer.TabIndex = 19
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(21, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 18)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Contact No.:"
        '
        'txtContactCustomer
        '
        Me.txtContactCustomer.Location = New System.Drawing.Point(133, 129)
        Me.txtContactCustomer.Name = "txtContactCustomer"
        Me.txtContactCustomer.Size = New System.Drawing.Size(212, 23)
        Me.txtContactCustomer.TabIndex = 17
        '
        'btnClearCustomer
        '
        Me.btnClearCustomer.Location = New System.Drawing.Point(708, 118)
        Me.btnClearCustomer.Name = "btnClearCustomer"
        Me.btnClearCustomer.Size = New System.Drawing.Size(100, 26)
        Me.btnClearCustomer.TabIndex = 16
        Me.btnClearCustomer.Text = "CLEAR"
        Me.btnClearCustomer.UseVisualStyleBackColor = True
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(708, 60)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(100, 26)
        Me.btnUpdateCustomer.TabIndex = 15
        Me.btnUpdateCustomer.Text = "UPDATE"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Enabled = False
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(708, 89)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(100, 26)
        Me.btnDeleteCustomer.TabIndex = 14
        Me.btnDeleteCustomer.Text = "DELETE"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(708, 31)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(100, 26)
        Me.btnAddCustomer.TabIndex = 5
        Me.btnAddCustomer.Text = "ADD"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(21, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 18)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Last Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(21, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 18)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Middle Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 18)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "First Name:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 18)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Customer ID:"
        '
        'txtLastNameCustomer
        '
        Me.txtLastNameCustomer.Location = New System.Drawing.Point(133, 105)
        Me.txtLastNameCustomer.Name = "txtLastNameCustomer"
        Me.txtLastNameCustomer.Size = New System.Drawing.Size(212, 23)
        Me.txtLastNameCustomer.TabIndex = 3
        '
        'txtMiddleNameCustomer
        '
        Me.txtMiddleNameCustomer.Location = New System.Drawing.Point(133, 81)
        Me.txtMiddleNameCustomer.Name = "txtMiddleNameCustomer"
        Me.txtMiddleNameCustomer.Size = New System.Drawing.Size(212, 23)
        Me.txtMiddleNameCustomer.TabIndex = 2
        '
        'txtFirstNameCustomer
        '
        Me.txtFirstNameCustomer.Location = New System.Drawing.Point(133, 57)
        Me.txtFirstNameCustomer.Name = "txtFirstNameCustomer"
        Me.txtFirstNameCustomer.Size = New System.Drawing.Size(212, 23)
        Me.txtFirstNameCustomer.TabIndex = 1
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(133, 33)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(212, 23)
        Me.txtCustomerID.TabIndex = 0
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(795, 15)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(75, 26)
        Me.btnSearchCustomer.TabIndex = 8
        Me.btnSearchCustomer.Text = "SEARCH"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.Location = New System.Drawing.Point(606, 17)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.Size = New System.Drawing.Size(183, 23)
        Me.txtCustomerSearch.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(33, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 18)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Customer List:"
        '
        'dgvCustomerList
        '
        Me.dgvCustomerList.AllowUserToAddRows = False
        Me.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomerList.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomerList.Location = New System.Drawing.Point(27, 41)
        Me.dgvCustomerList.Name = "dgvCustomerList"
        Me.dgvCustomerList.ReadOnly = True
        Me.dgvCustomerList.RowTemplate.Height = 25
        Me.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerList.Size = New System.Drawing.Size(843, 189)
        Me.dgvCustomerList.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbxReturnToSettings)
        Me.Panel2.Controls.Add(Me.TabControl6)
        Me.Panel2.Location = New System.Drawing.Point(186, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(916, 464)
        Me.Panel2.TabIndex = 9
        '
        'pbxReturnToSettings
        '
        Me.pbxReturnToSettings.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.up_left_26px
        Me.pbxReturnToSettings.Location = New System.Drawing.Point(853, 13)
        Me.pbxReturnToSettings.Name = "pbxReturnToSettings"
        Me.pbxReturnToSettings.Size = New System.Drawing.Size(30, 30)
        Me.pbxReturnToSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxReturnToSettings.TabIndex = 2
        Me.pbxReturnToSettings.TabStop = False
        '
        'TabControl6
        '
        Me.TabControl6.Controls.Add(Me.TabPage12)
        Me.TabControl6.Controls.Add(Me.TabPage13)
        Me.TabControl6.Controls.Add(Me.TabPage14)
        Me.TabControl6.Controls.Add(Me.TabPage15)
        Me.TabControl6.Controls.Add(Me.TabPage17)
        Me.TabControl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl6.Location = New System.Drawing.Point(13, 49)
        Me.TabControl6.Name = "TabControl6"
        Me.TabControl6.SelectedIndex = 0
        Me.TabControl6.Size = New System.Drawing.Size(881, 401)
        Me.TabControl6.TabIndex = 0
        '
        'TabPage12
        '
        Me.TabPage12.BackColor = System.Drawing.Color.Transparent
        Me.TabPage12.Controls.Add(Me.Label58)
        Me.TabPage12.Controls.Add(Me.dgvProductName)
        Me.TabPage12.Controls.Add(Me.GroupBox8)
        Me.TabPage12.Location = New System.Drawing.Point(4, 29)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(873, 368)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Product Name"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(19, 34)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(76, 20)
        Me.Label58.TabIndex = 9
        Me.Label58.Text = "Products:"
        '
        'dgvProductName
        '
        Me.dgvProductName.AllowUserToAddRows = False
        Me.dgvProductName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductName.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductName.Location = New System.Drawing.Point(15, 58)
        Me.dgvProductName.Name = "dgvProductName"
        Me.dgvProductName.ReadOnly = True
        Me.dgvProductName.RowTemplate.Height = 25
        Me.dgvProductName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductName.Size = New System.Drawing.Size(470, 294)
        Me.dgvProductName.TabIndex = 3
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label51)
        Me.GroupBox8.Controls.Add(Me.txtProdNameVar)
        Me.GroupBox8.Controls.Add(Me.btnProdNameVarClear)
        Me.GroupBox8.Controls.Add(Me.btnProdNameUpdateVar)
        Me.GroupBox8.Controls.Add(Me.btnProdNameDeleteVar)
        Me.GroupBox8.Controls.Add(Me.btnProdNameAddVar)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(497, 58)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(363, 296)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Product Details"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(16, 86)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(114, 20)
        Me.Label51.TabIndex = 22
        Me.Label51.Text = "Product Name:"
        '
        'txtProdNameVar
        '
        Me.txtProdNameVar.Location = New System.Drawing.Point(136, 83)
        Me.txtProdNameVar.Name = "txtProdNameVar"
        Me.txtProdNameVar.Size = New System.Drawing.Size(197, 26)
        Me.txtProdNameVar.TabIndex = 21
        '
        'btnProdNameVarClear
        '
        Me.btnProdNameVarClear.Location = New System.Drawing.Point(235, 236)
        Me.btnProdNameVarClear.Name = "btnProdNameVarClear"
        Me.btnProdNameVarClear.Size = New System.Drawing.Size(100, 40)
        Me.btnProdNameVarClear.TabIndex = 20
        Me.btnProdNameVarClear.Text = "CLEAR"
        Me.btnProdNameVarClear.UseVisualStyleBackColor = True
        '
        'btnProdNameUpdateVar
        '
        Me.btnProdNameUpdateVar.Location = New System.Drawing.Point(235, 189)
        Me.btnProdNameUpdateVar.Name = "btnProdNameUpdateVar"
        Me.btnProdNameUpdateVar.Size = New System.Drawing.Size(100, 40)
        Me.btnProdNameUpdateVar.TabIndex = 19
        Me.btnProdNameUpdateVar.Text = "UPDATE"
        Me.btnProdNameUpdateVar.UseVisualStyleBackColor = True
        '
        'btnProdNameDeleteVar
        '
        Me.btnProdNameDeleteVar.Enabled = False
        Me.btnProdNameDeleteVar.Location = New System.Drawing.Point(68, 236)
        Me.btnProdNameDeleteVar.Name = "btnProdNameDeleteVar"
        Me.btnProdNameDeleteVar.Size = New System.Drawing.Size(100, 40)
        Me.btnProdNameDeleteVar.TabIndex = 18
        Me.btnProdNameDeleteVar.Text = "DELETE"
        Me.btnProdNameDeleteVar.UseVisualStyleBackColor = True
        '
        'btnProdNameAddVar
        '
        Me.btnProdNameAddVar.BackColor = System.Drawing.Color.Transparent
        Me.btnProdNameAddVar.Location = New System.Drawing.Point(68, 189)
        Me.btnProdNameAddVar.Name = "btnProdNameAddVar"
        Me.btnProdNameAddVar.Size = New System.Drawing.Size(100, 40)
        Me.btnProdNameAddVar.TabIndex = 17
        Me.btnProdNameAddVar.Text = "ADD"
        Me.btnProdNameAddVar.UseVisualStyleBackColor = False
        '
        'TabPage13
        '
        Me.TabPage13.BackColor = System.Drawing.Color.Transparent
        Me.TabPage13.Controls.Add(Me.Label57)
        Me.TabPage13.Controls.Add(Me.dgvVariants)
        Me.TabPage13.Controls.Add(Me.GroupBox9)
        Me.TabPage13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage13.Location = New System.Drawing.Point(4, 29)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(873, 368)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Variants"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(19, 34)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(72, 20)
        Me.Label57.TabIndex = 9
        Me.Label57.Text = "Variants:"
        '
        'dgvVariants
        '
        Me.dgvVariants.AllowUserToAddRows = False
        Me.dgvVariants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVariants.BackgroundColor = System.Drawing.Color.White
        Me.dgvVariants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVariants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVariants.Location = New System.Drawing.Point(15, 58)
        Me.dgvVariants.Name = "dgvVariants"
        Me.dgvVariants.ReadOnly = True
        Me.dgvVariants.RowTemplate.Height = 25
        Me.dgvVariants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVariants.Size = New System.Drawing.Size(470, 294)
        Me.dgvVariants.TabIndex = 5
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label52)
        Me.GroupBox9.Controls.Add(Me.txtVariant)
        Me.GroupBox9.Controls.Add(Me.btnClearVariant)
        Me.GroupBox9.Controls.Add(Me.btnUpdateVariant)
        Me.GroupBox9.Controls.Add(Me.btnDeleteVariant)
        Me.GroupBox9.Controls.Add(Me.btnAddVariant)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(497, 58)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(363, 296)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Variant Details"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(16, 86)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(107, 20)
        Me.Label52.TabIndex = 22
        Me.Label52.Text = "Variant Label:"
        '
        'txtVariant
        '
        Me.txtVariant.Location = New System.Drawing.Point(136, 83)
        Me.txtVariant.Name = "txtVariant"
        Me.txtVariant.Size = New System.Drawing.Size(197, 26)
        Me.txtVariant.TabIndex = 21
        '
        'btnClearVariant
        '
        Me.btnClearVariant.Location = New System.Drawing.Point(235, 236)
        Me.btnClearVariant.Name = "btnClearVariant"
        Me.btnClearVariant.Size = New System.Drawing.Size(100, 40)
        Me.btnClearVariant.TabIndex = 20
        Me.btnClearVariant.Text = "CLEAR"
        Me.btnClearVariant.UseVisualStyleBackColor = True
        '
        'btnUpdateVariant
        '
        Me.btnUpdateVariant.Location = New System.Drawing.Point(235, 189)
        Me.btnUpdateVariant.Name = "btnUpdateVariant"
        Me.btnUpdateVariant.Size = New System.Drawing.Size(100, 40)
        Me.btnUpdateVariant.TabIndex = 19
        Me.btnUpdateVariant.Text = "UPDATE"
        Me.btnUpdateVariant.UseVisualStyleBackColor = True
        '
        'btnDeleteVariant
        '
        Me.btnDeleteVariant.Enabled = False
        Me.btnDeleteVariant.Location = New System.Drawing.Point(68, 236)
        Me.btnDeleteVariant.Name = "btnDeleteVariant"
        Me.btnDeleteVariant.Size = New System.Drawing.Size(100, 40)
        Me.btnDeleteVariant.TabIndex = 18
        Me.btnDeleteVariant.Text = "DELETE"
        Me.btnDeleteVariant.UseVisualStyleBackColor = True
        '
        'btnAddVariant
        '
        Me.btnAddVariant.BackColor = System.Drawing.Color.Transparent
        Me.btnAddVariant.Location = New System.Drawing.Point(68, 189)
        Me.btnAddVariant.Name = "btnAddVariant"
        Me.btnAddVariant.Size = New System.Drawing.Size(100, 40)
        Me.btnAddVariant.TabIndex = 17
        Me.btnAddVariant.Text = "ADD"
        Me.btnAddVariant.UseVisualStyleBackColor = False
        '
        'TabPage14
        '
        Me.TabPage14.BackColor = System.Drawing.Color.Transparent
        Me.TabPage14.Controls.Add(Me.Label56)
        Me.TabPage14.Controls.Add(Me.dgvContainer)
        Me.TabPage14.Controls.Add(Me.GroupBox10)
        Me.TabPage14.Location = New System.Drawing.Point(4, 29)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(873, 368)
        Me.TabPage14.TabIndex = 2
        Me.TabPage14.Text = "Containers"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(21, 34)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(90, 20)
        Me.Label56.TabIndex = 8
        Me.Label56.Text = "Containers:"
        '
        'dgvContainer
        '
        Me.dgvContainer.AllowUserToAddRows = False
        Me.dgvContainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContainer.BackgroundColor = System.Drawing.Color.White
        Me.dgvContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContainer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvContainer.Location = New System.Drawing.Point(15, 58)
        Me.dgvContainer.Name = "dgvContainer"
        Me.dgvContainer.ReadOnly = True
        Me.dgvContainer.RowTemplate.Height = 25
        Me.dgvContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContainer.Size = New System.Drawing.Size(470, 294)
        Me.dgvContainer.TabIndex = 7
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label53)
        Me.GroupBox10.Controls.Add(Me.txtContainerName)
        Me.GroupBox10.Controls.Add(Me.btnClearContainer)
        Me.GroupBox10.Controls.Add(Me.btnUpdateContainer)
        Me.GroupBox10.Controls.Add(Me.btnDeleteContainer)
        Me.GroupBox10.Controls.Add(Me.btnAddContainer)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(497, 58)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(363, 296)
        Me.GroupBox10.TabIndex = 6
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Container Details"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(16, 86)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(82, 20)
        Me.Label53.TabIndex = 22
        Me.Label53.Text = "Container:"
        '
        'txtContainerName
        '
        Me.txtContainerName.Location = New System.Drawing.Point(136, 83)
        Me.txtContainerName.Name = "txtContainerName"
        Me.txtContainerName.Size = New System.Drawing.Size(197, 26)
        Me.txtContainerName.TabIndex = 21
        '
        'btnClearContainer
        '
        Me.btnClearContainer.Location = New System.Drawing.Point(235, 236)
        Me.btnClearContainer.Name = "btnClearContainer"
        Me.btnClearContainer.Size = New System.Drawing.Size(100, 40)
        Me.btnClearContainer.TabIndex = 20
        Me.btnClearContainer.Text = "CLEAR"
        Me.btnClearContainer.UseVisualStyleBackColor = True
        '
        'btnUpdateContainer
        '
        Me.btnUpdateContainer.Location = New System.Drawing.Point(235, 189)
        Me.btnUpdateContainer.Name = "btnUpdateContainer"
        Me.btnUpdateContainer.Size = New System.Drawing.Size(100, 40)
        Me.btnUpdateContainer.TabIndex = 19
        Me.btnUpdateContainer.Text = "UPDATE"
        Me.btnUpdateContainer.UseVisualStyleBackColor = True
        '
        'btnDeleteContainer
        '
        Me.btnDeleteContainer.Enabled = False
        Me.btnDeleteContainer.Location = New System.Drawing.Point(68, 236)
        Me.btnDeleteContainer.Name = "btnDeleteContainer"
        Me.btnDeleteContainer.Size = New System.Drawing.Size(100, 40)
        Me.btnDeleteContainer.TabIndex = 18
        Me.btnDeleteContainer.Text = "DELETE"
        Me.btnDeleteContainer.UseVisualStyleBackColor = True
        '
        'btnAddContainer
        '
        Me.btnAddContainer.BackColor = System.Drawing.Color.Transparent
        Me.btnAddContainer.Location = New System.Drawing.Point(68, 189)
        Me.btnAddContainer.Name = "btnAddContainer"
        Me.btnAddContainer.Size = New System.Drawing.Size(100, 40)
        Me.btnAddContainer.TabIndex = 17
        Me.btnAddContainer.Text = "ADD"
        Me.btnAddContainer.UseVisualStyleBackColor = False
        '
        'TabPage15
        '
        Me.TabPage15.BackColor = System.Drawing.Color.Transparent
        Me.TabPage15.Controls.Add(Me.Label55)
        Me.TabPage15.Controls.Add(Me.dgvSize)
        Me.TabPage15.Controls.Add(Me.GroupBox11)
        Me.TabPage15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage15.Location = New System.Drawing.Point(4, 29)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(873, 368)
        Me.TabPage15.TabIndex = 3
        Me.TabPage15.Text = "Size in mL"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(19, 35)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(161, 20)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "Sizes Available in mL:"
        '
        'dgvSize
        '
        Me.dgvSize.AllowUserToAddRows = False
        Me.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSize.BackgroundColor = System.Drawing.Color.White
        Me.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSize.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSize.Location = New System.Drawing.Point(15, 58)
        Me.dgvSize.Name = "dgvSize"
        Me.dgvSize.ReadOnly = True
        Me.dgvSize.RowTemplate.Height = 25
        Me.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSize.Size = New System.Drawing.Size(470, 294)
        Me.dgvSize.TabIndex = 9
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label54)
        Me.GroupBox11.Controls.Add(Me.txtSizeVariable)
        Me.GroupBox11.Controls.Add(Me.btnClearSize)
        Me.GroupBox11.Controls.Add(Me.btnUpdateSize)
        Me.GroupBox11.Controls.Add(Me.btnDeleteSize)
        Me.GroupBox11.Controls.Add(Me.btnAddSize)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(497, 58)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(363, 296)
        Me.GroupBox11.TabIndex = 8
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Size in mL"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(16, 86)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(86, 20)
        Me.Label54.TabIndex = 22
        Me.Label54.Text = "Size in mL:"
        '
        'txtSizeVariable
        '
        Me.txtSizeVariable.Location = New System.Drawing.Point(136, 83)
        Me.txtSizeVariable.Name = "txtSizeVariable"
        Me.txtSizeVariable.Size = New System.Drawing.Size(197, 26)
        Me.txtSizeVariable.TabIndex = 21
        '
        'btnClearSize
        '
        Me.btnClearSize.Location = New System.Drawing.Point(235, 236)
        Me.btnClearSize.Name = "btnClearSize"
        Me.btnClearSize.Size = New System.Drawing.Size(100, 40)
        Me.btnClearSize.TabIndex = 20
        Me.btnClearSize.Text = "CLEAR"
        Me.btnClearSize.UseVisualStyleBackColor = True
        '
        'btnUpdateSize
        '
        Me.btnUpdateSize.Location = New System.Drawing.Point(235, 189)
        Me.btnUpdateSize.Name = "btnUpdateSize"
        Me.btnUpdateSize.Size = New System.Drawing.Size(100, 40)
        Me.btnUpdateSize.TabIndex = 19
        Me.btnUpdateSize.Text = "UPDATE"
        Me.btnUpdateSize.UseVisualStyleBackColor = True
        '
        'btnDeleteSize
        '
        Me.btnDeleteSize.Enabled = False
        Me.btnDeleteSize.Location = New System.Drawing.Point(68, 236)
        Me.btnDeleteSize.Name = "btnDeleteSize"
        Me.btnDeleteSize.Size = New System.Drawing.Size(100, 40)
        Me.btnDeleteSize.TabIndex = 18
        Me.btnDeleteSize.Text = "DELETE"
        Me.btnDeleteSize.UseVisualStyleBackColor = True
        '
        'btnAddSize
        '
        Me.btnAddSize.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSize.Location = New System.Drawing.Point(68, 189)
        Me.btnAddSize.Name = "btnAddSize"
        Me.btnAddSize.Size = New System.Drawing.Size(100, 40)
        Me.btnAddSize.TabIndex = 17
        Me.btnAddSize.Text = "ADD"
        Me.btnAddSize.UseVisualStyleBackColor = False
        '
        'TabPage17
        '
        Me.TabPage17.Controls.Add(Me.Label67)
        Me.TabPage17.Controls.Add(Me.dgvDiscount)
        Me.TabPage17.Controls.Add(Me.GroupBox17)
        Me.TabPage17.Location = New System.Drawing.Point(4, 29)
        Me.TabPage17.Name = "TabPage17"
        Me.TabPage17.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage17.Size = New System.Drawing.Size(873, 368)
        Me.TabPage17.TabIndex = 4
        Me.TabPage17.Text = "Discounts"
        Me.TabPage17.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(18, 25)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(84, 20)
        Me.Label67.TabIndex = 13
        Me.Label67.Text = "Discounts:"
        '
        'dgvDiscount
        '
        Me.dgvDiscount.AllowUserToAddRows = False
        Me.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiscount.BackgroundColor = System.Drawing.Color.White
        Me.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiscount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDiscount.Location = New System.Drawing.Point(14, 48)
        Me.dgvDiscount.Name = "dgvDiscount"
        Me.dgvDiscount.ReadOnly = True
        Me.dgvDiscount.RowTemplate.Height = 25
        Me.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDiscount.Size = New System.Drawing.Size(470, 294)
        Me.dgvDiscount.TabIndex = 12
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Label68)
        Me.GroupBox17.Controls.Add(Me.txtDiscount)
        Me.GroupBox17.Controls.Add(Me.btnClearDiscount)
        Me.GroupBox17.Controls.Add(Me.btnUpdateDiscount)
        Me.GroupBox17.Controls.Add(Me.btnDeleteDiscount)
        Me.GroupBox17.Controls.Add(Me.btnAddDiscount)
        Me.GroupBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(496, 48)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(363, 296)
        Me.GroupBox17.TabIndex = 11
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Discount"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(16, 86)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(76, 20)
        Me.Label68.TabIndex = 22
        Me.Label68.Text = "Discount:"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(136, 83)
        Me.txtDiscount.MaxLength = 3
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(197, 26)
        Me.txtDiscount.TabIndex = 21
        '
        'btnClearDiscount
        '
        Me.btnClearDiscount.Location = New System.Drawing.Point(235, 236)
        Me.btnClearDiscount.Name = "btnClearDiscount"
        Me.btnClearDiscount.Size = New System.Drawing.Size(100, 40)
        Me.btnClearDiscount.TabIndex = 20
        Me.btnClearDiscount.Text = "CLEAR"
        Me.btnClearDiscount.UseVisualStyleBackColor = True
        '
        'btnUpdateDiscount
        '
        Me.btnUpdateDiscount.Location = New System.Drawing.Point(235, 189)
        Me.btnUpdateDiscount.Name = "btnUpdateDiscount"
        Me.btnUpdateDiscount.Size = New System.Drawing.Size(100, 40)
        Me.btnUpdateDiscount.TabIndex = 19
        Me.btnUpdateDiscount.Text = "UPDATE"
        Me.btnUpdateDiscount.UseVisualStyleBackColor = True
        '
        'btnDeleteDiscount
        '
        Me.btnDeleteDiscount.Enabled = False
        Me.btnDeleteDiscount.Location = New System.Drawing.Point(68, 236)
        Me.btnDeleteDiscount.Name = "btnDeleteDiscount"
        Me.btnDeleteDiscount.Size = New System.Drawing.Size(100, 40)
        Me.btnDeleteDiscount.TabIndex = 18
        Me.btnDeleteDiscount.Text = "DELETE"
        Me.btnDeleteDiscount.UseVisualStyleBackColor = True
        '
        'btnAddDiscount
        '
        Me.btnAddDiscount.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDiscount.Location = New System.Drawing.Point(68, 189)
        Me.btnAddDiscount.Name = "btnAddDiscount"
        Me.btnAddDiscount.Size = New System.Drawing.Size(100, 40)
        Me.btnAddDiscount.TabIndex = 17
        Me.btnAddDiscount.Text = "ADD"
        Me.btnAddDiscount.UseVisualStyleBackColor = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDashboard.Controls.Add(Me.PictureBox1)
        Me.pnlDashboard.Controls.Add(Me.btnDataAnalysis)
        Me.pnlDashboard.Controls.Add(Me.GroupBox16)
        Me.pnlDashboard.Controls.Add(Me.GroupBox15)
        Me.pnlDashboard.Controls.Add(Me.GroupBox14)
        Me.pnlDashboard.Controls.Add(Me.GroupBox13)
        Me.pnlDashboard.Controls.Add(Me.Label62)
        Me.pnlDashboard.Location = New System.Drawing.Point(186, 126)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(916, 464)
        Me.pnlDashboard.TabIndex = 11
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label66)
        Me.GroupBox16.Controls.Add(Me.Chart2)
        Me.GroupBox16.Location = New System.Drawing.Point(205, 257)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(328, 200)
        Me.GroupBox16.TabIndex = 11
        Me.GroupBox16.TabStop = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(14, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(245, 22)
        Me.Label66.TabIndex = 6
        Me.Label66.Text = "Montly Sales Performance - Trend"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(6, 48)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(316, 145)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label65)
        Me.GroupBox15.Controls.Add(Me.Chart3)
        Me.GroupBox15.Location = New System.Drawing.Point(543, 257)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(351, 200)
        Me.GroupBox15.TabIndex = 6
        Me.GroupBox15.TabStop = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(6, 16)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(206, 22)
        Me.Label65.TabIndex = 5
        Me.Label65.Text = "Top 5 Most Popular Products"
        '
        'Chart3
        '
        Me.Chart3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend2)
        Me.Chart3.Location = New System.Drawing.Point(7, 48)
        Me.Chart3.Name = "Chart3"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Size = New System.Drawing.Size(337, 145)
        Me.Chart3.TabIndex = 1
        Me.Chart3.Text = "Chart3"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.dgvOut)
        Me.GroupBox14.Controls.Add(Me.Label64)
        Me.GroupBox14.Location = New System.Drawing.Point(434, 41)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(460, 210)
        Me.GroupBox14.TabIndex = 6
        Me.GroupBox14.TabStop = False
        '
        'dgvOut
        '
        Me.dgvOut.AllowUserToAddRows = False
        Me.dgvOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOut.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOut.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOut.Location = New System.Drawing.Point(12, 46)
        Me.dgvOut.Name = "dgvOut"
        Me.dgvOut.ReadOnly = True
        Me.dgvOut.RowTemplate.Height = 25
        Me.dgvOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOut.Size = New System.Drawing.Size(437, 159)
        Me.dgvOut.TabIndex = 8
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(8, 21)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(162, 22)
        Me.Label64.TabIndex = 4
        Me.Label64.Text = "Out of Stock Products"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Chart5)
        Me.GroupBox13.Controls.Add(Me.Label63)
        Me.GroupBox13.Location = New System.Drawing.Point(28, 41)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(393, 210)
        Me.GroupBox13.TabIndex = 5
        Me.GroupBox13.TabStop = False
        '
        'Chart5
        '
        Me.Chart5.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend3)
        Me.Chart5.Location = New System.Drawing.Point(12, 52)
        Me.Chart5.Name = "Chart5"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart5.Series.Add(Series3)
        Me.Chart5.Size = New System.Drawing.Size(339, 150)
        Me.Chart5.TabIndex = 3
        Me.Chart5.Text = "Chart5"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(8, 21)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(232, 22)
        Me.Label63.TabIndex = 4
        Me.Label63.Text = "Daily Sales Performance - Trend"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Mohave", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(8, 6)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(143, 41)
        Me.Label62.TabIndex = 2
        Me.Label62.Text = "Dashboard"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 588)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlProducts)
        Me.Controls.Add(Me.pnlSuppliers)
        Me.Controls.Add(Me.pnlReports)
        Me.Controls.Add(Me.pnlCustomers)
        Me.Controls.Add(Me.pnlEmployees)
        Me.Controls.Add(Me.pnlSales)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        TabPage10.ResumeLayout(False)
        TabPage10.PerformLayout()
        CType(Me.dgvEmployeeLogs, System.ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAddStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSuppliers.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvSupplierDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage16.ResumeLayout(False)
        Me.TabPage16.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.dgvProductsBySupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSales.ResumeLayout(False)
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        CType(Me.pbxRefreshSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pnlSettings.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRestore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBackUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReports.ResumeLayout(False)
        CType(Me.pbxLossReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStockOutReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStockInHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxProductsReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmployees.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProducts.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProductsProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvStockInHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvProductListDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvDefectiveItemHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dgvOutOfStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomers.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbxReturnToSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl6.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        CType(Me.dgvProductName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        CType(Me.dgvVariants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage14.PerformLayout()
        CType(Me.dgvContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout()
        CType(Me.dgvSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.TabPage17.ResumeLayout(False)
        Me.TabPage17.PerformLayout()
        CType(Me.dgvDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents pnlSuppliers As Panel
    Friend WithEvents pnlEmployees As Panel
    Friend WithEvents pnlSales As Panel
    Friend WithEvents pnlReports As Panel
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabControl5 As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents btnProductsReport As Button
    Friend WithEvents btnStockOutReports As Button
    Friend WithEvents btnStockInReports As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnBackUp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlProducts As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearProductDetails As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvProductsProductList As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClearStockIn As Button
    Friend WithEvents btnAddStock As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtQuantityAddStock As TextBox
    Friend WithEvents txtProductIDAddStock As TextBox
    Friend WithEvents btnSearchProductStockIn As Button
    Friend WithEvents txtSearchProductStockIn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvAddStock As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvStockInHistory As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClearDefectiveDetails As Button
    Friend WithEvents btnAddDefectiveDetails As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtRemarksDefect As TextBox
    Friend WithEvents txtQuantityDefect As TextBox
    Friend WithEvents txtSupplierDefect As TextBox
    Friend WithEvents txtProductNameDefect As TextBox
    Friend WithEvents btnSearchProductDefective As Button
    Friend WithEvents txtSearchProductDefective As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dgvProductListDefect As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDefectiveItemHistory As DataGridView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvOutOfStock As DataGridView
    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMunicipalityCustomer As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBarangayCustomer As TextBox
    Friend WithEvents txtStreetCustomer As TextBox
    Friend WithEvents txtHouseNoCustomer As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtContactCustomer As TextBox
    Friend WithEvents btnClearCustomer As Button
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtLastNameCustomer As TextBox
    Friend WithEvents txtMiddleNameCustomer As TextBox
    Friend WithEvents txtFirstNameCustomer As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents txtCustomerSearch As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents dgvCustomerList As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtSupplierContactDetails As TextBox
    Friend WithEvents btnClearSupplier As Button
    Friend WithEvents btnUpdateSupplier As Button
    Friend WithEvents btnDeleteSupplier As Button
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txtSupplierAddressDetails As TextBox
    Friend WithEvents txtSupplierNameDetails As TextBox
    Friend WithEvents btnSearchSupplierDetails As Button
    Friend WithEvents txtSearchSupplierDetails As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents dgvSupplierDetails As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cboSecurityQuestion As ComboBox
    Friend WithEvents cboUserLevel As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtEmployeePassword As TextBox
    Friend WithEvents txtEmployeeUsername As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtEmployeeContactNo As TextBox
    Friend WithEvents btnClearEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents txtEmployeeLastName As TextBox
    Friend WithEvents txtEmployeeMiddleName As TextBox
    Friend WithEvents txtEmployeeFirstName As TextBox
    Friend WithEvents btnEmployeeSearch As Button
    Friend WithEvents txtEmployeeSearch As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents dgvEmployeeList As DataGridView
    Friend WithEvents Label44 As Label
    Friend WithEvents dgvEmployeeLogs As DataGridView
    Friend WithEvents dgvSalesHistory As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnPrintPreviewSalesRecord As Button
    Friend WithEvents btnSearchSalesRecord As Button
    Friend WithEvents Label48 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents cboEmployeeID As ComboBox
    Friend WithEvents pbxExit As PictureBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents pbxRefreshSalesHistory As PictureBox
    Friend WithEvents pbxRestore As PictureBox
    Friend WithEvents pbxBackUp As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents pbxStockOutReport As PictureBox
    Friend WithEvents pbxStockInHistory As PictureBox
    Friend WithEvents pbxProductsReport As PictureBox
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents pbxLossReport As PictureBox
    Friend WithEvents btnLossReport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDataAnalysis As Button
    Friend WithEvents cboContainer As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnVariables As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl6 As TabControl
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents dgvProductName As DataGridView
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtProdNameVar As TextBox
    Friend WithEvents btnProdNameVarClear As Button
    Friend WithEvents btnProdNameUpdateVar As Button
    Friend WithEvents btnProdNameDeleteVar As Button
    Friend WithEvents btnProdNameAddVar As Button
    Friend WithEvents dgvVariants As DataGridView
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtVariant As TextBox
    Friend WithEvents btnClearVariant As Button
    Friend WithEvents btnUpdateVariant As Button
    Friend WithEvents btnDeleteVariant As Button
    Friend WithEvents btnAddVariant As Button
    Friend WithEvents TabPage14 As TabPage
    Friend WithEvents dgvContainer As DataGridView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtContainerName As TextBox
    Friend WithEvents btnClearContainer As Button
    Friend WithEvents btnUpdateContainer As Button
    Friend WithEvents btnDeleteContainer As Button
    Friend WithEvents btnAddContainer As Button
    Friend WithEvents TabPage15 As TabPage
    Friend WithEvents dgvSize As DataGridView
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtSizeVariable As TextBox
    Friend WithEvents btnClearSize As Button
    Friend WithEvents btnUpdateSize As Button
    Friend WithEvents btnDeleteSize As Button
    Friend WithEvents btnAddSize As Button
    Friend WithEvents pbxReturnToSettings As PictureBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents cboVariant As ComboBox
    Friend WithEvents cboProdName As ComboBox
    Friend WithEvents lblDtp As Label
    Friend WithEvents dtpUntil As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblDtpFrom As Label
    Friend WithEvents TabPage16 As TabPage
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label61 As Label
    Friend WithEvents btnSearchProdBySupp As Button
    Friend WithEvents Label60 As Label
    Friend WithEvents dgvProductsBySupplier As DataGridView
    Friend WithEvents cboSupplierBy As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents dgvOut As DataGridView
    Friend WithEvents Label64 As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label85 As Label
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label66 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage17 As TabPage
    Friend WithEvents Label67 As Label
    Friend WithEvents dgvDiscount As DataGridView
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Label68 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents btnClearDiscount As Button
    Friend WithEvents btnUpdateDiscount As Button
    Friend WithEvents btnDeleteDiscount As Button
    Friend WithEvents btnAddDiscount As Button
End Class
