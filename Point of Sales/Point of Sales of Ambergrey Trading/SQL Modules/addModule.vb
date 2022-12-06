Imports MySql.Data.MySqlClient
Imports System.Globalization

Module addModule

    Public Sub addProductDetails()

        getSupplierID()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblproducts WHERE (product_name = @name AND prod_variant = @var AND size = @size AND container = @cont AND price = @price AND category = @cat AND supplier_id = @supp)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("name", frmMain.cboProdName.Text)
            cmd1.Parameters.AddWithValue("var", frmMain.cboVariant.Text)
            cmd1.Parameters.AddWithValue("size", frmMain.cboSize.Text)
            cmd1.Parameters.AddWithValue("cont", frmMain.cboContainer.Text)
            cmd1.Parameters.AddWithValue("price", Double.Parse(frmMain.txtProductPrice.Text))
            cmd1.Parameters.AddWithValue("cat", frmMain.cboCategory.Text)
            cmd1.Parameters.AddWithValue("supp", selectedsupplier)
            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Record already exists!", MsgBoxStyle.Exclamation, "Record exists")
                    test = False
                Else
                    test = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If test = True Then
            Try
                openConn()
                com.Connection = conn
                com.CommandText = "INSERT INTO tblproducts (product_id, product_name, prod_variant, size, container, price, category, supplier_id, quantity)" +
                                    "VALUES (@prod_id, @prod_name, @prod_var, @size, @container, @price, @category, @supplier_id, @quantity)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("prod_id", frmMain.txtProductID.Text)
                com.Parameters.AddWithValue("prod_name", frmMain.cboProdName.Text)
                com.Parameters.AddWithValue("prod_var", frmMain.cboVariant.Text)
                com.Parameters.AddWithValue("size", frmMain.cboSize.Text)
                com.Parameters.AddWithValue("container", frmMain.cboContainer.Text)
                com.Parameters.AddWithValue("price", Double.Parse(frmMain.txtProductPrice.Text))
                com.Parameters.AddWithValue("category", frmMain.cboCategory.Text)
                com.Parameters.AddWithValue("supplier_id", selectedsupplier)
                com.Parameters.AddWithValue("quantity", 0)
                com.ExecuteNonQuery()
                conn.Close()

                MsgBox("Product successfully added!", MsgBoxStyle.Information, "Product Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub addProductName()

        Dim usedprodname = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblprodname WHERE prod_name = @prodname"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("prodname", frmMain.txtProdNameVar.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Product already exists!", MsgBoxStyle.Exclamation, "Product exists")
                    usedprodname = False
                Else
                    usedprodname = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If usedprodname = True Then
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO tblprodname (prod_name) " +
                    "VALUES(@prod_name)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("prod_name", frmMain.txtProdNameVar.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Product successfully added!", MsgBoxStyle.Information, "Product Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub addProductVariant()

        Dim variantused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblvariants WHERE variant_name = @variant"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("variant", frmMain.txtVariant.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Variant already exists!", MsgBoxStyle.Exclamation, "Variant exists")
                    variantused = False
                Else
                    variantused = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If variantused = True Then
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO tblvariants (variant_name) " +
                    "VALUES(@variant_name)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("variant_name", frmMain.txtVariant.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Variant successfully added!", MsgBoxStyle.Information, "Variant Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub addContainer()

        Dim containerused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblcontainer WHERE container_name = @container"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("container", frmMain.txtContainerName.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Container already exists!", MsgBoxStyle.Exclamation, "Container exists")
                    containerused = False
                Else
                    containerused = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If containerused = True Then
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO tblcontainer (container_name) " +
                    "VALUES(@container)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("container", frmMain.txtContainerName.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Container successfully added!", MsgBoxStyle.Information, "Container Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub


    Public Sub addDiscount()

        Dim discountused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tbldiscounts WHERE discount = @discount"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("discount", frmMain.txtDiscount.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Discount already exists!", MsgBoxStyle.Exclamation, "Discount exists")
                    discountused = False
                Else
                    discountused = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If discountused = True Then
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO tbldiscounts (discount) " +
                    "VALUES(@discount)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("discount", frmMain.txtDiscount.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Discount successfully added!", MsgBoxStyle.Information, "Discount Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub addSize()

        Dim sizeused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblsize WHERE size_quantity = @size"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("size", frmMain.txtSizeVariable.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Size already exists!", MsgBoxStyle.Exclamation, "Size exists")
                    sizeused = False
                Else
                    sizeused = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If sizeused = True Then
            openConn()
            Try
                com.Connection = conn
                com.CommandText = "INSERT INTO tblsize (size_quantity) " +
                    "VALUES(@size)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("size", frmMain.txtSizeVariable.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Size successfully added!", MsgBoxStyle.Information, "Size Added")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub addProductStockHistory()
        openConn()

        Try
            com.Connection = conn
            com.CommandText = "INSERT INTO tblstockin (product_id, date_added, quantity) " +
                "VALUES(@prod_idstock, @date_added, @quantity_added)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("prod_idstock", frmMain.txtProductIDAddStock.Text)
            com.Parameters.AddWithValue("date_added", Date.Now.ToString((" yyyy-MM-dd")))
            com.Parameters.AddWithValue("quantity_added", frmMain.txtQuantityAddStock.Text)
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub addStockProduct()
        Dim sum As Integer = selectedproductquantity + Integer.Parse(frmMain.txtQuantityAddStock.Text)
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "UPDATE tblproducts SET quantity = @quantity_sum WHERE product_id = @prod_id"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("quantity_sum", sum)
            com.Parameters.AddWithValue("prod_id", frmMain.txtProductIDAddStock.Text)
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub addSupplierDetails()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblsupplier WHERE (supplier_name = @name AND supplier_address = @add AND supplier_contact_number = @cont)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("name", frmMain.txtSupplierNameDetails.Text)
            cmd1.Parameters.AddWithValue("add", frmMain.txtSupplierAddressDetails.Text)
            cmd1.Parameters.AddWithValue("cont", frmMain.txtSupplierContactDetails.Text)
            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Record already exists!", MsgBoxStyle.Exclamation, "Record exists")
                    test = False
                Else
                    test = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If test = True Then
            Try
                openConn()
                com.Connection = conn
                com.CommandText = "INSERT INTO tblsupplier (supplier_id, supplier_name, supplier_address, supplier_contact_number) " +
                "VALUES (@supp_id, @supp_name, @supp_add, @supp_contact)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("supp_id", idsuppliergeneration)
                com.Parameters.AddWithValue("supp_name", frmMain.txtSupplierNameDetails.Text)
                com.Parameters.AddWithValue("supp_add", frmMain.txtSupplierAddressDetails.Text)
                com.Parameters.AddWithValue("supp_contact", frmMain.txtSupplierContactDetails.Text)
                com.ExecuteNonQuery()
                conn.Close()

                MsgBox("Supplier successfully added!", MsgBoxStyle.Information, "Supplier Added")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If



    End Sub

    Public Sub addCustomerDetails()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblcustomer WHERE (`first_name` = @fn AND `middle_name` = @mn AND `last_name` = @ln AND `contact_number` = @cn AND `house_number` = @hn AND `street_name` = @sn AND `barangay` = @br AND `city` = @ct)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("fn", frmMain.txtFirstNameCustomer.Text)
            cmd1.Parameters.AddWithValue("mn", frmMain.txtMiddleNameCustomer.Text)
            cmd1.Parameters.AddWithValue("ln", frmMain.txtLastNameCustomer.Text)
            cmd1.Parameters.AddWithValue("cn", frmMain.txtContactCustomer.Text)
            cmd1.Parameters.AddWithValue("hn", frmMain.txtHouseNoCustomer.Text)
            cmd1.Parameters.AddWithValue("sn", frmMain.txtStreetCustomer.Text)
            cmd1.Parameters.AddWithValue("br", frmMain.txtBarangayCustomer.Text)
            cmd1.Parameters.AddWithValue("ct", frmMain.txtMunicipalityCustomer.Text)
            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Record already exists!", MsgBoxStyle.Exclamation, "Record exists")
                    test = False
                Else
                    test = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If test = True Then
            Try
                openConn()

                com.Connection = conn
                com.CommandText = "INSERT INTO `tblcustomer` (`customer_id`, `first_name`, `middle_name`, `last_name`, `contact_number`, `house_number`, `street_name`, `barangay`, `city`) " +
                    " VALUES (@cus, @f_name, @m_name, @l_name, @contact, @houseno, @stname, @brgy, @city)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("cus", idcustomergeneration)
                com.Parameters.AddWithValue("f_name", frmMain.txtFirstNameCustomer.Text)
                com.Parameters.AddWithValue("m_name", frmMain.txtMiddleNameCustomer.Text)
                com.Parameters.AddWithValue("l_name", frmMain.txtLastNameCustomer.Text)
                com.Parameters.AddWithValue("contact", frmMain.txtContactCustomer.Text)
                com.Parameters.AddWithValue("houseno", frmMain.txtHouseNoCustomer.Text)
                com.Parameters.AddWithValue("stname", frmMain.txtStreetCustomer.Text)
                com.Parameters.AddWithValue("brgy", frmMain.txtBarangayCustomer.Text)
                com.Parameters.AddWithValue("city", frmMain.txtMunicipalityCustomer.Text)

                com.ExecuteNonQuery()
                conn.Close()

                MsgBox("Customer successfully added!", MsgBoxStyle.Information, "Customer Added")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub addCustomerDetailsPOS()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblcustomer WHERE (`first_name` = @fn AND `middle_name` = @mn AND `last_name` = @ln AND `contact_number` = @cn AND `house_number` = @hn AND `street_name` = @sn AND `barangay` = @br AND `city` = @ct)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("fn", frmAddCustomerPOS.txtFirstNameCustomer.Text)
            cmd1.Parameters.AddWithValue("mn", frmAddCustomerPOS.txtMiddleNameCustomer.Text)
            cmd1.Parameters.AddWithValue("ln", frmAddCustomerPOS.txtLastNameCustomer.Text)
            cmd1.Parameters.AddWithValue("cn", frmAddCustomerPOS.txtContactCustomer.Text)
            cmd1.Parameters.AddWithValue("hn", frmAddCustomerPOS.txtHouseNoCustomer.Text)
            cmd1.Parameters.AddWithValue("sn", frmAddCustomerPOS.txtStreetCustomer.Text)
            cmd1.Parameters.AddWithValue("br", frmAddCustomerPOS.txtBarangayCustomer.Text)
            cmd1.Parameters.AddWithValue("ct", frmAddCustomerPOS.txtMunicipalityCustomer.Text)
            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Record already exists!", MsgBoxStyle.Exclamation, "Record exists")
                    test = False
                Else
                    test = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If test = True Then
            Try
                openConn()

                com.Connection = conn
                com.CommandText = "INSERT INTO `tblcustomer` (`customer_id`, `first_name`, `middle_name`, `last_name`, `contact_number`, `house_number`, `street_name`, `barangay`, `city`) " +
                    " VALUES (@cus, @f_name, @m_name, @l_name, @contact, @houseno, @stname, @brgy, @city)"
                com.Parameters.Clear()
                com.Parameters.AddWithValue("cus", idcustomergeneration)
                com.Parameters.AddWithValue("f_name", frmAddCustomerPOS.txtFirstNameCustomer.Text)
                com.Parameters.AddWithValue("m_name", frmAddCustomerPOS.txtMiddleNameCustomer.Text)
                com.Parameters.AddWithValue("l_name", frmAddCustomerPOS.txtLastNameCustomer.Text)
                com.Parameters.AddWithValue("contact", frmAddCustomerPOS.txtContactCustomer.Text)
                com.Parameters.AddWithValue("houseno", frmAddCustomerPOS.txtHouseNoCustomer.Text)
                com.Parameters.AddWithValue("stname", frmAddCustomerPOS.txtStreetCustomer.Text)
                com.Parameters.AddWithValue("brgy", frmAddCustomerPOS.txtBarangayCustomer.Text)
                com.Parameters.AddWithValue("city", frmAddCustomerPOS.txtMunicipalityCustomer.Text)

                com.ExecuteNonQuery()
                conn.Close()

                MsgBox("Customer successfully added!", MsgBoxStyle.Information, "Customer Added")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub AddDefectedItem()
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "INSERT INTO `tbldefective` (`product_id`, `defective_quantity`, `defective_comment`, `defection_date`) " +
                " VALUES (@prod_iddef, @def_qty, @def_comm, @dtr)"
            com.Parameters.AddWithValue("prod_iddef", frmMain.txtProductNameDefect.Text)
            com.Parameters.AddWithValue("def_qty", frmMain.txtQuantityDefect.Text)
            com.Parameters.AddWithValue("def_comm", frmMain.txtRemarksDefect.Text)
            com.Parameters.AddWithValue("dtr", Date.Now.ToString((" yyyy-MM-dd")))
            com.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub deductStockProduct()
        Dim diff As Integer = selectedproductquantity - Integer.Parse(frmMain.txtQuantityDefect.Text)
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "UPDATE tblproducts SET quantity = @difference WHERE product_id = @prod_iddefect"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("difference", diff)
            com.Parameters.AddWithValue("prod_iddefect", frmMain.txtProductNameDefect.Text)
            com.ExecuteNonQuery()
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub addEmployeeDetails()
        Dim usedusername As Boolean
        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblemployees WHERE (`first_name` = @fn AND `middle_name` = @mn AND `last_name` = @ln AND `username` = @un AND `password` = @pw AND `user_level` = @ul AND `contact_number` = @cn AND `security_question` = @sq AND  `security_answer` = @sa)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("fn", frmMain.txtEmployeeFirstName.Text)
            cmd1.Parameters.AddWithValue("mn", frmMain.txtEmployeeMiddleName.Text)
            cmd1.Parameters.AddWithValue("ln", frmMain.txtEmployeeLastName.Text)
            cmd1.Parameters.AddWithValue("un", frmMain.txtEmployeeUsername.Text)
            cmd1.Parameters.AddWithValue("pw", frmMain.txtEmployeePassword.Text)
            cmd1.Parameters.AddWithValue("ul", frmMain.cboUserLevel.Text)
            cmd1.Parameters.AddWithValue("cn", frmMain.txtEmployeeContactNo.Text)
            cmd1.Parameters.AddWithValue("sq", frmMain.cboSecurityQuestion.Text)
            cmd1.Parameters.AddWithValue("sa", frmMain.txtSecurityAnswer.Text)
            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Record already exists!", MsgBoxStyle.Exclamation, "Record exists")
                    test = False
                Else
                    test = True
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If test = True Then
            Try
                openConn()
                Dim theQuery As String = "SELECT * FROM tblemployees WHERE username = @uname"
                Dim cmd1 As New MySqlCommand
                cmd1.Connection = conn
                cmd1.CommandText = theQuery
                cmd1.Parameters.AddWithValue("uname", frmMain.txtEmployeeUsername.Text)

                Using rdr As MySqlDataReader = cmd1.ExecuteReader
                    If rdr.HasRows Then
                        MsgBox("Username is already in use. Please select a different username!", MsgBoxStyle.Exclamation, "Username taken")
                        usedusername = False
                    Else
                        usedusername = True
                    End If
                End Using
                conn.Close()
                If usedusername = True Then
                    openConn()
                    com.Connection = conn
                    com.CommandText = "INSERT INTO `tblemployees` (`first_name`, `middle_name`, `last_name`, `username`, `password`, `user_level`, `contact_number`, `security_question`,  `security_answer`) " +
                        " VALUES (@fi_name, @mid_name, @la_name, @username, @pass, @u_level, @contact_num, @sec_que, @sec_ans)"
                    com.Parameters.Clear()
                    com.Parameters.AddWithValue("fi_name", frmMain.txtEmployeeFirstName.Text)
                    com.Parameters.AddWithValue("mid_name", frmMain.txtEmployeeMiddleName.Text)
                    com.Parameters.AddWithValue("la_name", frmMain.txtEmployeeLastName.Text)
                    com.Parameters.AddWithValue("username", frmMain.txtEmployeeUsername.Text)
                    com.Parameters.AddWithValue("pass", frmMain.txtEmployeePassword.Text)
                    com.Parameters.AddWithValue("u_level", frmMain.cboUserLevel.Text)
                    com.Parameters.AddWithValue("contact_num", frmMain.txtEmployeeContactNo.Text)
                    com.Parameters.AddWithValue("sec_que", frmMain.cboSecurityQuestion.Text)
                    com.Parameters.AddWithValue("sec_ans", frmMain.txtSecurityAnswer.Text)
                    com.ExecuteNonQuery()
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub addTransaction()
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "INSERT INTO `tbltransaction` (`transaction_id`, `totaldue`, `date_time`, `employee_id`, `customer_id`, `discount` ) " +
                " VALUES(@trans_id, @totaldue, @date_timetrans, @emp_id, @cus_id, @disc)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("trans_id", idtransgeneration)
            com.Parameters.AddWithValue("totaldue", frmPOS.txtTotal.Text)
            com.Parameters.AddWithValue("date_timetrans", Date.Now.ToString((" yyyy-MM-dd HH:mm:ss")))
            com.Parameters.AddWithValue("emp_id", frmPOS.lblCashierID.Text)
            com.Parameters.AddWithValue("cus_id", frmPOS.lblCustomerID.Text)
            com.Parameters.AddWithValue("disc", frmPOS.cboDiscount.Text)
            com.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub addLoginLog()
        openConn()
        Try
            com.Connection = conn
            com.CommandText = "INSERT INTO `tblapplogs` (`employee_id`, `log_datetime`) " +
                " VALUES(@empid, @datetimelog)"
            com.Parameters.Clear()
            com.Parameters.AddWithValue("empid", frmLogin.empid)
            com.Parameters.AddWithValue("datetimelog", Date.Now.ToString((" yyyy-MM-dd hh:mm:ss")))
            com.ExecuteNonQuery()
            conn.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Public Sub addStockProduct()
    '    Dim sum As Integer = selectedproductquantity + Integer.Parse(frmMain.txtQuantityAddStock.Text)
    '    openConn()
    '    Try
    '        com.Connection = conn
    '        com.CommandText = "UPDATE tblproducts SET quantity = @quantity_sum WHERE product_id = @prod_id"
    '        com.Parameters.Clear()
    '        com.Parameters.AddWithValue("quantity_sum", sum)
    '        com.Parameters.AddWithValue("prod_id", frmMain.txtProductIDAddStock.Text)
    '        com.ExecuteNonQuery()
    '        conn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub

End Module
