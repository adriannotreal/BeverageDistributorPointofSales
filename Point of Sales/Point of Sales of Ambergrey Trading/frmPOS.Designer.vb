<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.btnProceedPayment = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtNetTotal = New System.Windows.Forms.TextBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.POSPanel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.lblCashierID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pbxExitPOS = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnLiquor = New System.Windows.Forms.Button()
        Me.btnSoda = New System.Windows.Forms.Button()
        Me.pbxLiquor = New System.Windows.Forms.PictureBox()
        Me.pbxSoda = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPOSVariant = New System.Windows.Forms.TextBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPOSQty = New System.Windows.Forms.TextBox()
        Me.txtPOSStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPOSProductContainer = New System.Windows.Forms.TextBox()
        Me.txtPOSProductSize = New System.Windows.Forms.TextBox()
        Me.txtPOSProductName = New System.Windows.Forms.TextBox()
        Me.txtPOSProductCode = New System.Windows.Forms.TextBox()
        Me.pnlNonAlchohol = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pbxReturnSoda = New System.Windows.Forms.PictureBox()
        Me.dgvSoda = New System.Windows.Forms.DataGridView()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.productIDPOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productNamePOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPricePOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityPOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPricePOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAlcohol = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pbxReturnLiquor = New System.Windows.Forms.PictureBox()
        Me.dgvLiquor = New System.Windows.Forms.DataGridView()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.pnlCustomer = New System.Windows.Forms.Panel()
        Me.dgvPOSCustomer = New System.Windows.Forms.DataGridView()
        Me.txtSearchPOS = New System.Windows.Forms.TextBox()
        Me.btnSearchPOS = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.btnSearchCustomerDGV = New System.Windows.Forms.Button()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnAddNewCustomer = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.POSPanel1.SuspendLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        CType(Me.pbxLiquor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSoda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.pnlNonAlchohol.SuspendLayout()
        CType(Me.pbxReturnSoda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSoda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlcohol.SuspendLayout()
        CType(Me.pbxReturnLiquor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLiquor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomer.SuspendLayout()
        CType(Me.dgvPOSCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboDiscount)
        Me.GroupBox1.Controls.Add(Me.btnProceedPayment)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtChange)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtVAT)
        Me.GroupBox1.Controls.Add(Me.txtNetTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(537, 526)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 148)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 18)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Subtotal:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(141, 16)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotal.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(228, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 18)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "%"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 18)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Discount(%)"
        '
        'cboDiscount
        '
        Me.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscount.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.IntegralHeight = False
        Me.cboDiscount.Items.AddRange(New Object() {"Can", "Glass Bottle", "Plastic Bottle"})
        Me.cboDiscount.Location = New System.Drawing.Point(141, 35)
        Me.cboDiscount.MaxDropDownItems = 5
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(80, 23)
        Me.cboDiscount.TabIndex = 38
        '
        'btnProceedPayment
        '
        Me.btnProceedPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnProceedPayment.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceedPayment.ForeColor = System.Drawing.Color.White
        Me.btnProceedPayment.Location = New System.Drawing.Point(320, 63)
        Me.btnProceedPayment.Name = "btnProceedPayment"
        Me.btnProceedPayment.Size = New System.Drawing.Size(138, 80)
        Me.btnProceedPayment.TabIndex = 36
        Me.btnProceedPayment.Text = "PROCEED PAYMENT"
        Me.btnProceedPayment.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 18)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Change:"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(141, 122)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(137, 20)
        Me.txtChange.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Cash Rendered:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 18)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Total Amount Due:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(275, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "VAT(12%):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(275, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Net total:"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(141, 103)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(137, 20)
        Me.txtCash.TabIndex = 29
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(141, 59)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtTotal.TabIndex = 28
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(348, 36)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(137, 20)
        Me.txtVAT.TabIndex = 27
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Location = New System.Drawing.Point(348, 16)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.ReadOnly = True
        Me.txtNetTotal.Size = New System.Drawing.Size(137, 20)
        Me.txtNetTotal.TabIndex = 26
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnRemoveItem.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Location = New System.Drawing.Point(717, 482)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(159, 46)
        Me.btnRemoveItem.TabIndex = 39
        Me.btnRemoveItem.Text = "REMOVE ITEM"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnClearCart
        '
        Me.btnClearCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnClearCart.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCart.ForeColor = System.Drawing.Color.White
        Me.btnClearCart.Location = New System.Drawing.Point(558, 482)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(159, 46)
        Me.btnClearCart.TabIndex = 38
        Me.btnClearCart.Text = "CLEAR CART"
        Me.btnClearCart.UseVisualStyleBackColor = False
        '
        'POSPanel1
        '
        Me.POSPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.POSPanel1.Controls.Add(Me.Label18)
        Me.POSPanel1.Controls.Add(Me.lblCashierName)
        Me.POSPanel1.Controls.Add(Me.lblCashierID)
        Me.POSPanel1.Controls.Add(Me.Label19)
        Me.POSPanel1.Controls.Add(Me.Label20)
        Me.POSPanel1.Controls.Add(Me.pbxExitPOS)
        Me.POSPanel1.Controls.Add(Me.Label1)
        Me.POSPanel1.Location = New System.Drawing.Point(0, 0)
        Me.POSPanel1.Name = "POSPanel1"
        Me.POSPanel1.Size = New System.Drawing.Size(1048, 126)
        Me.POSPanel1.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Mohave", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(832, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(201, 45)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Point of Sales"
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierName.ForeColor = System.Drawing.Color.White
        Me.lblCashierName.Location = New System.Drawing.Point(920, 29)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(14, 13)
        Me.lblCashierName.TabIndex = 49
        Me.lblCashierName.Text = "q"
        '
        'lblCashierID
        '
        Me.lblCashierID.AutoSize = True
        Me.lblCashierID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierID.ForeColor = System.Drawing.Color.White
        Me.lblCashierID.Location = New System.Drawing.Point(920, 11)
        Me.lblCashierID.Name = "lblCashierID"
        Me.lblCashierID.Size = New System.Drawing.Size(14, 13)
        Me.lblCashierID.TabIndex = 48
        Me.lblCashierID.Tag = ""
        Me.lblCashierID.Text = "p"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(837, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Cashier Name:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(837, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Cashier ID:"
        '
        'pbxExitPOS
        '
        Me.pbxExitPOS.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExitPOS.Location = New System.Drawing.Point(993, 12)
        Me.pbxExitPOS.Name = "pbxExitPOS"
        Me.pbxExitPOS.Size = New System.Drawing.Size(40, 40)
        Me.pbxExitPOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExitPOS.TabIndex = 2
        Me.pbxExitPOS.TabStop = False
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
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnLiquor)
        Me.pnlButtons.Controls.Add(Me.btnSoda)
        Me.pnlButtons.Controls.Add(Me.pbxLiquor)
        Me.pnlButtons.Controls.Add(Me.pbxSoda)
        Me.pnlButtons.Location = New System.Drawing.Point(0, 182)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(535, 310)
        Me.pnlButtons.TabIndex = 33
        '
        'btnLiquor
        '
        Me.btnLiquor.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnLiquor.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquor.ForeColor = System.Drawing.Color.White
        Me.btnLiquor.Location = New System.Drawing.Point(314, 192)
        Me.btnLiquor.Name = "btnLiquor"
        Me.btnLiquor.Size = New System.Drawing.Size(125, 68)
        Me.btnLiquor.TabIndex = 3
        Me.btnLiquor.Text = "Alcoholic Beverages"
        Me.btnLiquor.UseVisualStyleBackColor = False
        '
        'btnSoda
        '
        Me.btnSoda.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSoda.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoda.ForeColor = System.Drawing.Color.White
        Me.btnSoda.Location = New System.Drawing.Point(88, 192)
        Me.btnSoda.Name = "btnSoda"
        Me.btnSoda.Size = New System.Drawing.Size(125, 68)
        Me.btnSoda.TabIndex = 2
        Me.btnSoda.Text = "Non-Alcoholic Beverages"
        Me.btnSoda.UseVisualStyleBackColor = False
        '
        'pbxLiquor
        '
        Me.pbxLiquor.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.liquor
        Me.pbxLiquor.Location = New System.Drawing.Point(314, 61)
        Me.pbxLiquor.Name = "pbxLiquor"
        Me.pbxLiquor.Size = New System.Drawing.Size(125, 125)
        Me.pbxLiquor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLiquor.TabIndex = 1
        Me.pbxLiquor.TabStop = False
        '
        'pbxSoda
        '
        Me.pbxSoda.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.soft_drinks
        Me.pbxSoda.Location = New System.Drawing.Point(88, 61)
        Me.pbxSoda.Name = "pbxSoda"
        Me.pbxSoda.Size = New System.Drawing.Size(125, 125)
        Me.pbxSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSoda.TabIndex = 0
        Me.pbxSoda.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtPOSVariant)
        Me.GroupBox6.Controls.Add(Me.btnAddToCart)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtPOSQty)
        Me.GroupBox6.Controls.Add(Me.txtPOSStock)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtPOSProductContainer)
        Me.GroupBox6.Controls.Add(Me.txtPOSProductSize)
        Me.GroupBox6.Controls.Add(Me.txtPOSProductName)
        Me.GroupBox6.Controls.Add(Me.txtPOSProductCode)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 521)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(520, 153)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Product Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Variant:"
        '
        'txtPOSVariant
        '
        Me.txtPOSVariant.Location = New System.Drawing.Point(120, 63)
        Me.txtPOSVariant.Name = "txtPOSVariant"
        Me.txtPOSVariant.ReadOnly = True
        Me.txtPOSVariant.Size = New System.Drawing.Size(137, 20)
        Me.txtPOSVariant.TabIndex = 31
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Mohave", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(289, 82)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(208, 46)
        Me.btnAddToCart.TabIndex = 30
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Stock:"
        '
        'txtPOSQty
        '
        Me.txtPOSQty.Location = New System.Drawing.Point(402, 54)
        Me.txtPOSQty.Name = "txtPOSQty"
        Me.txtPOSQty.Size = New System.Drawing.Size(95, 20)
        Me.txtPOSQty.TabIndex = 27
        '
        'txtPOSStock
        '
        Me.txtPOSStock.Location = New System.Drawing.Point(402, 27)
        Me.txtPOSStock.Name = "txtPOSStock"
        Me.txtPOSStock.ReadOnly = True
        Me.txtPOSStock.Size = New System.Drawing.Size(95, 20)
        Me.txtPOSStock.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Container:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Size:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Product Code:"
        '
        'txtPOSProductContainer
        '
        Me.txtPOSProductContainer.Location = New System.Drawing.Point(120, 111)
        Me.txtPOSProductContainer.Name = "txtPOSProductContainer"
        Me.txtPOSProductContainer.ReadOnly = True
        Me.txtPOSProductContainer.Size = New System.Drawing.Size(137, 20)
        Me.txtPOSProductContainer.TabIndex = 21
        '
        'txtPOSProductSize
        '
        Me.txtPOSProductSize.Location = New System.Drawing.Point(120, 87)
        Me.txtPOSProductSize.Name = "txtPOSProductSize"
        Me.txtPOSProductSize.ReadOnly = True
        Me.txtPOSProductSize.Size = New System.Drawing.Size(137, 20)
        Me.txtPOSProductSize.TabIndex = 20
        '
        'txtPOSProductName
        '
        Me.txtPOSProductName.Location = New System.Drawing.Point(120, 39)
        Me.txtPOSProductName.Name = "txtPOSProductName"
        Me.txtPOSProductName.ReadOnly = True
        Me.txtPOSProductName.Size = New System.Drawing.Size(137, 20)
        Me.txtPOSProductName.TabIndex = 19
        '
        'txtPOSProductCode
        '
        Me.txtPOSProductCode.Location = New System.Drawing.Point(120, 15)
        Me.txtPOSProductCode.Name = "txtPOSProductCode"
        Me.txtPOSProductCode.ReadOnly = True
        Me.txtPOSProductCode.Size = New System.Drawing.Size(137, 20)
        Me.txtPOSProductCode.TabIndex = 18
        '
        'pnlNonAlchohol
        '
        Me.pnlNonAlchohol.Controls.Add(Me.Label14)
        Me.pnlNonAlchohol.Controls.Add(Me.pbxReturnSoda)
        Me.pnlNonAlchohol.Controls.Add(Me.dgvSoda)
        Me.pnlNonAlchohol.Location = New System.Drawing.Point(0, 182)
        Me.pnlNonAlchohol.Name = "pnlNonAlchohol"
        Me.pnlNonAlchohol.Size = New System.Drawing.Size(535, 310)
        Me.pnlNonAlchohol.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Mohave", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(160, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(215, 27)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Non-Alcoholic Beverages"
        '
        'pbxReturnSoda
        '
        Me.pbxReturnSoda.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.up_left_26px
        Me.pbxReturnSoda.Location = New System.Drawing.Point(14, 13)
        Me.pbxReturnSoda.Name = "pbxReturnSoda"
        Me.pbxReturnSoda.Size = New System.Drawing.Size(30, 30)
        Me.pbxReturnSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxReturnSoda.TabIndex = 1
        Me.pbxReturnSoda.TabStop = False
        '
        'dgvSoda
        '
        Me.dgvSoda.AllowUserToAddRows = False
        Me.dgvSoda.AllowUserToDeleteRows = False
        Me.dgvSoda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSoda.BackgroundColor = System.Drawing.Color.White
        Me.dgvSoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSoda.Location = New System.Drawing.Point(13, 46)
        Me.dgvSoda.Name = "dgvSoda"
        Me.dgvSoda.ReadOnly = True
        Me.dgvSoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSoda.Size = New System.Drawing.Size(509, 251)
        Me.dgvSoda.TabIndex = 0
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productIDPOS, Me.productNamePOS, Me.unitPricePOS, Me.quantityPOS, Me.totalPricePOS})
        Me.dgvCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCart.Location = New System.Drawing.Point(557, 218)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(476, 258)
        Me.dgvCart.TabIndex = 36
        '
        'productIDPOS
        '
        Me.productIDPOS.HeaderText = "Product_ID"
        Me.productIDPOS.Name = "productIDPOS"
        Me.productIDPOS.ReadOnly = True
        '
        'productNamePOS
        '
        Me.productNamePOS.HeaderText = "Name"
        Me.productNamePOS.Name = "productNamePOS"
        Me.productNamePOS.ReadOnly = True
        '
        'unitPricePOS
        '
        Me.unitPricePOS.HeaderText = "Unit Price"
        Me.unitPricePOS.Name = "unitPricePOS"
        Me.unitPricePOS.ReadOnly = True
        '
        'quantityPOS
        '
        Me.quantityPOS.HeaderText = "Qty"
        Me.quantityPOS.Name = "quantityPOS"
        Me.quantityPOS.ReadOnly = True
        '
        'totalPricePOS
        '
        Me.totalPricePOS.HeaderText = "Total Price"
        Me.totalPricePOS.Name = "totalPricePOS"
        Me.totalPricePOS.ReadOnly = True
        '
        'pnlAlcohol
        '
        Me.pnlAlcohol.Controls.Add(Me.Label13)
        Me.pnlAlcohol.Controls.Add(Me.pbxReturnLiquor)
        Me.pnlAlcohol.Controls.Add(Me.dgvLiquor)
        Me.pnlAlcohol.Location = New System.Drawing.Point(0, 182)
        Me.pnlAlcohol.Name = "pnlAlcohol"
        Me.pnlAlcohol.Size = New System.Drawing.Size(535, 310)
        Me.pnlAlcohol.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Mohave", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(180, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 27)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Alcoholic Beverages"
        '
        'pbxReturnLiquor
        '
        Me.pbxReturnLiquor.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.up_left_26px
        Me.pbxReturnLiquor.Location = New System.Drawing.Point(14, 13)
        Me.pbxReturnLiquor.Name = "pbxReturnLiquor"
        Me.pbxReturnLiquor.Size = New System.Drawing.Size(30, 30)
        Me.pbxReturnLiquor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxReturnLiquor.TabIndex = 3
        Me.pbxReturnLiquor.TabStop = False
        '
        'dgvLiquor
        '
        Me.dgvLiquor.AllowUserToAddRows = False
        Me.dgvLiquor.AllowUserToDeleteRows = False
        Me.dgvLiquor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLiquor.BackgroundColor = System.Drawing.Color.White
        Me.dgvLiquor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLiquor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLiquor.Location = New System.Drawing.Point(13, 46)
        Me.dgvLiquor.Name = "dgvLiquor"
        Me.dgvLiquor.ReadOnly = True
        Me.dgvLiquor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLiquor.Size = New System.Drawing.Size(509, 251)
        Me.dgvLiquor.TabIndex = 2
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomer.Location = New System.Drawing.Point(558, 166)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(96, 46)
        Me.btnSearchCustomer.TabIndex = 41
        Me.btnSearchCustomer.Text = "Search customer"
        Me.btnSearchCustomer.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(565, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Customer ID:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(565, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Customer Name:"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(649, 131)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(13, 13)
        Me.lblCustomerID.TabIndex = 44
        Me.lblCustomerID.Tag = ""
        Me.lblCustomerID.Text = "p"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(649, 151)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(13, 13)
        Me.lblCustomerName.TabIndex = 45
        Me.lblCustomerName.Text = "q"
        '
        'pnlCustomer
        '
        Me.pnlCustomer.Controls.Add(Me.dgvPOSCustomer)
        Me.pnlCustomer.Location = New System.Drawing.Point(554, 215)
        Me.pnlCustomer.Name = "pnlCustomer"
        Me.pnlCustomer.Size = New System.Drawing.Size(482, 267)
        Me.pnlCustomer.TabIndex = 46
        '
        'dgvPOSCustomer
        '
        Me.dgvPOSCustomer.AllowUserToAddRows = False
        Me.dgvPOSCustomer.AllowUserToDeleteRows = False
        Me.dgvPOSCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPOSCustomer.BackgroundColor = System.Drawing.Color.White
        Me.dgvPOSCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOSCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPOSCustomer.Location = New System.Drawing.Point(4, 3)
        Me.dgvPOSCustomer.Name = "dgvPOSCustomer"
        Me.dgvPOSCustomer.ReadOnly = True
        Me.dgvPOSCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPOSCustomer.Size = New System.Drawing.Size(475, 261)
        Me.dgvPOSCustomer.TabIndex = 0
        '
        'txtSearchPOS
        '
        Me.txtSearchPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPOS.Location = New System.Drawing.Point(227, 151)
        Me.txtSearchPOS.Name = "txtSearchPOS"
        Me.txtSearchPOS.Size = New System.Drawing.Size(212, 22)
        Me.txtSearchPOS.TabIndex = 47
        '
        'btnSearchPOS
        '
        Me.btnSearchPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSearchPOS.Font = New System.Drawing.Font("Mohave", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPOS.ForeColor = System.Drawing.Color.White
        Me.btnSearchPOS.Location = New System.Drawing.Point(445, 147)
        Me.btnSearchPOS.Name = "btnSearchPOS"
        Me.btnSearchPOS.Size = New System.Drawing.Size(90, 31)
        Me.btnSearchPOS.TabIndex = 48
        Me.btnSearchPOS.Text = "SEARCH"
        Me.btnSearchPOS.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.dgvSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(0, 182)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(535, 310)
        Me.pnlSearch.TabIndex = 34
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSearch.Location = New System.Drawing.Point(13, 13)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(509, 284)
        Me.dgvSearch.TabIndex = 2
        '
        'btnSearchCustomerDGV
        '
        Me.btnSearchCustomerDGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSearchCustomerDGV.Font = New System.Drawing.Font("Mohave", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomerDGV.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomerDGV.Location = New System.Drawing.Point(776, 174)
        Me.btnSearchCustomerDGV.Name = "btnSearchCustomerDGV"
        Me.btnSearchCustomerDGV.Size = New System.Drawing.Size(61, 31)
        Me.btnSearchCustomerDGV.TabIndex = 50
        Me.btnSearchCustomerDGV.Text = "SEARCH"
        Me.btnSearchCustomerDGV.UseVisualStyleBackColor = False
        Me.btnSearchCustomerDGV.Visible = False
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCustomer.Location = New System.Drawing.Point(660, 178)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(110, 22)
        Me.txtSearchCustomer.TabIndex = 49
        Me.txtSearchCustomer.Visible = False
        '
        'btnAddNewCustomer
        '
        Me.btnAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnAddNewCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddNewCustomer.Location = New System.Drawing.Point(890, 166)
        Me.btnAddNewCustomer.Name = "btnAddNewCustomer"
        Me.btnAddNewCustomer.Size = New System.Drawing.Size(96, 46)
        Me.btnAddNewCustomer.TabIndex = 51
        Me.btnAddNewCustomer.Text = "Add New Customer"
        Me.btnAddNewCustomer.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnVoid.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(876, 482)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(159, 46)
        Me.btnVoid.TabIndex = 52
        Me.btnVoid.Text = "VOID TRANSACTION"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.shopping_cart_26px
        Me.PictureBox1.Location = New System.Drawing.Point(1003, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(857, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 33)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Print Previous Receipt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 686)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnAddNewCustomer)
        Me.Controls.Add(Me.btnSearchCustomerDGV)
        Me.Controls.Add(Me.txtSearchCustomer)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlCustomer)
        Me.Controls.Add(Me.pnlNonAlchohol)
        Me.Controls.Add(Me.btnSearchPOS)
        Me.Controls.Add(Me.txtSearchPOS)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.POSPanel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnClearCart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlAlcohol)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.POSPanel1.ResumeLayout(False)
        Me.POSPanel1.PerformLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.pbxLiquor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSoda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.pnlNonAlchohol.ResumeLayout(False)
        Me.pnlNonAlchohol.PerformLayout()
        CType(Me.pbxReturnSoda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSoda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlcohol.ResumeLayout(False)
        Me.pnlAlcohol.PerformLayout()
        CType(Me.pbxReturnLiquor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLiquor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomer.ResumeLayout(False)
        CType(Me.dgvPOSCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnProceedPayment As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtNetTotal As TextBox
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents POSPanel1 As Panel
    Friend WithEvents pbxExitPOS As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnLiquor As Button
    Friend WithEvents btnSoda As Button
    Friend WithEvents pbxLiquor As PictureBox
    Friend WithEvents pbxSoda As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPOSQty As TextBox
    Friend WithEvents txtPOSStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPOSProductContainer As TextBox
    Friend WithEvents txtPOSProductSize As TextBox
    Friend WithEvents txtPOSProductName As TextBox
    Friend WithEvents txtPOSProductCode As TextBox
    Friend WithEvents pnlNonAlchohol As Panel
    Friend WithEvents pbxReturnSoda As PictureBox
    Friend WithEvents dgvSoda As DataGridView
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents pnlAlcohol As Panel
    Friend WithEvents pbxReturnLiquor As PictureBox
    Friend WithEvents dgvLiquor As DataGridView
    Friend WithEvents productIDPOS As DataGridViewTextBoxColumn
    Friend WithEvents productNamePOS As DataGridViewTextBoxColumn
    Friend WithEvents unitPricePOS As DataGridViewTextBoxColumn
    Friend WithEvents quantityPOS As DataGridViewTextBoxColumn
    Friend WithEvents totalPricePOS As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents pnlCustomer As Panel
    Friend WithEvents dgvPOSCustomer As DataGridView
    Friend WithEvents lblCashierName As Label
    Friend WithEvents lblCashierID As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSearchPOS As TextBox
    Friend WithEvents btnSearchPOS As Button
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPOSVariant As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSearchCustomerDGV As Button
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents btnAddNewCustomer As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents cboDiscount As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Button1 As Button
End Class
