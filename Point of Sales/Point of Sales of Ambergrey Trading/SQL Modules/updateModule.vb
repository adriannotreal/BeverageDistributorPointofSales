Imports MySql.Data.MySqlClient
Imports System.Globalization

Module updateModule



    Public Sub updateProductDetails()
        getSupplierID()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblproducts WHERE ((product_name = @name AND prod_variant = @var AND size = @size AND container = @cont AND price = @price AND category = @cat AND supplier_id = @supp) AND NOT product_id = @prod_id)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("prod_id", frmMain.txtProductID.Text)
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
            openConn()
            Try
                com = New MySqlCommand
                With com
                    .Connection = conn
                    .CommandText = "UPDATE tblproducts SET product_name = @product_name, prod_variant = @prodvar, size = @product_size, container = @product_container, price = @product_price, supplier_id = @product_supplier, category = @product_category WHERE product_id = @product_id"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@product_id", frmMain.txtProductID.Text)
                    .Parameters.AddWithValue("@product_name", frmMain.cboProdName.Text)
                    .Parameters.AddWithValue("@prodvar", frmMain.cboVariant.Text)
                    .Parameters.AddWithValue("@product_supplier", selectedsupplier)
                    .Parameters.AddWithValue("@product_size", frmMain.cboSize.Text)
                    .Parameters.AddWithValue("@product_container", frmMain.cboContainer.Text)
                    .Parameters.AddWithValue("@product_price", frmMain.txtProductPrice.Text)
                    .Parameters.AddWithValue("@product_category", frmMain.cboCategory.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()
                MsgBox("Product successfully updated!", MsgBoxStyle.Information, "Product Updated")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub updateProductName()

        Dim usedprodname = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblprodname WHERE prod_name = @prodname AND NOT prodname_id = @prod_id"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("prod_id", prodname_id)
            cmd1.Parameters.AddWithValue("prodname", frmMain.txtProdNameVar.Text)

            Using rdr As MySqlDataReader = cmd1.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Product ID is already in use. Please select a different username!", MsgBoxStyle.Exclamation, "Username taken")
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
                com.CommandText = "UPDATE tblprodname SET prod_name = @prod_name WHERE prodname_id = " & prodname_id & ""
                com.Parameters.Clear()
                com.Parameters.AddWithValue("prod_name", frmMain.txtProdNameVar.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Product successfully updated!", MsgBoxStyle.Information, "Product Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub updateVariant()

        Dim variantused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblvariants WHERE variant_name = @variant AND NOT variant_id = @var"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("var", variant_id)
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
                com.CommandText = "UPDATE tblvariants SET variant_name = @variant WHERE variant_id = " & variant_id & ""
                com.Parameters.Clear()
                com.Parameters.AddWithValue("variant", frmMain.txtVariant.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Variant successfully updated!", MsgBoxStyle.Information, "Variant Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub updateContainer()

        Dim containerused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblcontainer WHERE container_name = @container AND NOT container_id = @cont"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("cont", container_id)
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
                com.CommandText = "UPDATE tblcontainer SET container_name = @container WHERE container_id = " & container_id & ""
                com.Parameters.Clear()
                com.Parameters.AddWithValue("container", frmMain.txtContainerName.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Container successfully updated!", MsgBoxStyle.Information, "Container Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub updateSize()

        Dim sizeused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblsize WHERE size_quantity = @size AND NOT size_id = @sid"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("sid", size_id)
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
                com.CommandText = "UPDATE tblsize SET size_quantity = @size WHERE size_id = " & size_id & ""
                com.Parameters.Clear()
                com.Parameters.AddWithValue("size", frmMain.txtSizeVariable.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Size successfully updated!", MsgBoxStyle.Information, "Size Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub updateDiscount()

        Dim discountused = False
        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tbldiscounts WHERE discount = @discount AND NOT discount_id = @disc_id"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.AddWithValue("disc_id", disc_id)
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
                com.CommandText = "UPDATE tbldiscounts SET discount = @discount WHERE discount_id = " & disc_id & ""
                com.Parameters.Clear()
                com.Parameters.AddWithValue("discount", frmMain.txtDiscount.Text)
                com.ExecuteNonQuery()
                conn.Close()
                MsgBox("Discount successfully updated!", MsgBoxStyle.Information, "Discount Updated")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub updateSupplierDetails()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblsupplier WHERE (supplier_name = @name AND supplier_address = @add AND supplier_contact_number = @cont) AND NOT supplier_id = @supp_id"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("supp_id", frmMain.txtSupplierID.Text)
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
                com = New MySqlCommand
                With com
                    .Connection = conn
                    .CommandText = "UPDATE tblsupplier SET supplier_name = @supplier_name, supplier_address = @supplier_address, supplier_contact_number = @supplier_contact WHERE supplier_id = @supplier_id"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@supplier_id", frmMain.txtSupplierID.Text)
                    .Parameters.AddWithValue("@supplier_name", frmMain.txtSupplierNameDetails.Text)
                    .Parameters.AddWithValue("@supplier_address", frmMain.txtSupplierAddressDetails.Text)
                    .Parameters.AddWithValue("@supplier_contact", frmMain.txtSupplierContactDetails.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()

                MsgBox("Supplier successfully updated!", MsgBoxStyle.Information, "Supplier Updated")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub updateCustomerDetails()

        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblcustomer WHERE ((`first_name` = @fn AND `middle_name` = @mn AND `last_name` = @ln AND `contact_number` = @cn AND `house_number` = @hn AND `street_name` = @sn AND `barangay` = @br AND `city` = @ct) AND NOT customer_id = @cus_id)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("cus_id", frmMain.txtCustomerID.Text)
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
                com = New MySqlCommand
                With com
                    .Connection = conn
                    .CommandText = "UPDATE tblcustomer SET first_name = @fname, middle_name = @mname, last_name = @lname, contact_number = @contact, house_number = @houseno, street_name = @stname, barangay = @brgy , city = @city WHERE customer_id = @customer_id"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@customer_id", frmMain.txtCustomerID.Text)
                    .Parameters.AddWithValue("@fname", frmMain.txtFirstNameCustomer.Text)
                    .Parameters.AddWithValue("@mname", frmMain.txtMiddleNameCustomer.Text)
                    .Parameters.AddWithValue("@lname", frmMain.txtLastNameCustomer.Text)
                    .Parameters.AddWithValue("@contact", frmMain.txtContactCustomer.Text)
                    .Parameters.AddWithValue("@houseno", frmMain.txtHouseNoCustomer.Text)
                    .Parameters.AddWithValue("@stname", frmMain.txtStreetCustomer.Text)
                    .Parameters.AddWithValue("@brgy", frmMain.txtBarangayCustomer.Text)
                    .Parameters.AddWithValue("@city", frmMain.txtMunicipalityCustomer.Text)
                    .ExecuteNonQuery()
                End With
                conn.Close()

                MsgBox("Customer successfully updated!", MsgBoxStyle.Information, "Customer Updated")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


    End Sub

    Public Sub updateEmployeeDetails()

        Dim usedusername As Boolean
        Dim test As Boolean = False

        Try
            openConn()
            Dim theQuery As String = "SELECT * FROM tblemployees WHERE ((`first_name` = @fn AND `middle_name` = @mn AND `last_name` = @ln AND `username` = @un AND `password` = @pw AND `user_level` = @ul AND `contact_number` = @cn AND `security_question` = @sq AND  `security_answer` = @sa) AND NOT employee_id = @emp_id)"
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = theQuery
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("emp_id", emp_id)
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
                Dim theQuery As String = "SELECT * FROM tblemployees WHERE username = @uname AND NOT employee_id = @emp_id"
                Dim cmd1 As New MySqlCommand
                cmd1.Connection = conn
                cmd1.CommandText = theQuery
                cmd1.Parameters.AddWithValue("emp_id", emp_id)
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
                    com = New MySqlCommand
                    With com
                        .Connection = conn
                        .CommandText = "UPDATE tblemployees SET first_name = @fname, middle_name = @mname, last_name = @lname, contact_number = @contact, username = @uname, password = PASSWORD(@pword), user_level = @ulevel , security_question = @secq, security_answer = @secan WHERE employee_id = @employee_id"
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@employee_id", emp_id)
                        .Parameters.AddWithValue("@fname", frmMain.txtEmployeeFirstName.Text)
                        .Parameters.AddWithValue("@mname", frmMain.txtEmployeeMiddleName.Text)
                        .Parameters.AddWithValue("@lname", frmMain.txtEmployeeLastName.Text)
                        .Parameters.AddWithValue("@contact", frmMain.txtEmployeeContactNo.Text)
                        .Parameters.AddWithValue("@uname", frmMain.txtEmployeeUsername.Text)
                        .Parameters.AddWithValue("@pword", frmMain.txtEmployeePassword.Text)
                        .Parameters.AddWithValue("@ulevel", frmMain.cboUserLevel.Text)
                        .Parameters.AddWithValue("@secq", frmMain.cboSecurityQuestion.Text)
                        .Parameters.AddWithValue("@secan", frmMain.txtSecurityAnswer.Text)
                        .ExecuteNonQuery()
                    End With
                    conn.Close()

                    MsgBox("Employee successfully updated!", MsgBoxStyle.Information, "Employee Updated")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub



    Public Sub updatePassword()
        openConn()
        Try
            com = New MySqlCommand
            With com
                .Connection = conn
                .CommandText = "UPDATE tblemployees SET password = @pword WHERE username = @uname"
                .Parameters.Clear()
                .Parameters.AddWithValue("@uname", frmChangePassword.txtUsernameChange.Text)
                .Parameters.AddWithValue("@pword", frmChangePassword.txtNewPassword.Text)
                .ExecuteNonQuery()
            End With
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
