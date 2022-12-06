<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomerPOS
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
        Me.POSPanel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbxExitPOS = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtLastNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtMiddleNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtFirstNameCustomer = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.POSPanel1.SuspendLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POSPanel1
        '
        Me.POSPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.POSPanel1.Controls.Add(Me.Label18)
        Me.POSPanel1.Controls.Add(Me.pbxExitPOS)
        Me.POSPanel1.Controls.Add(Me.Label1)
        Me.POSPanel1.Location = New System.Drawing.Point(0, 0)
        Me.POSPanel1.Name = "POSPanel1"
        Me.POSPanel1.Size = New System.Drawing.Size(800, 126)
        Me.POSPanel1.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Mohave", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(595, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(200, 45)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Add Customer"
        '
        'pbxExitPOS
        '
        Me.pbxExitPOS.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExitPOS.Location = New System.Drawing.Point(756, 12)
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(79, 390)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 20)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Municipality:"
        '
        'txtMunicipalityCustomer
        '
        Me.txtMunicipalityCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipalityCustomer.Location = New System.Drawing.Point(194, 387)
        Me.txtMunicipalityCustomer.Name = "txtMunicipalityCustomer"
        Me.txtMunicipalityCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtMunicipalityCustomer.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(79, 360)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 20)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Barangay:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(79, 330)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 20)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "Street:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(79, 300)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 20)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "House No.:"
        '
        'txtBarangayCustomer
        '
        Me.txtBarangayCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangayCustomer.Location = New System.Drawing.Point(194, 357)
        Me.txtBarangayCustomer.Name = "txtBarangayCustomer"
        Me.txtBarangayCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtBarangayCustomer.TabIndex = 7
        '
        'txtStreetCustomer
        '
        Me.txtStreetCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetCustomer.Location = New System.Drawing.Point(194, 327)
        Me.txtStreetCustomer.Name = "txtStreetCustomer"
        Me.txtStreetCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtStreetCustomer.TabIndex = 6
        '
        'txtHouseNoCustomer
        '
        Me.txtHouseNoCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNoCustomer.Location = New System.Drawing.Point(194, 297)
        Me.txtHouseNoCustomer.Name = "txtHouseNoCustomer"
        Me.txtHouseNoCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtHouseNoCustomer.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(79, 270)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 20)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Contact No.:"
        '
        'txtContactCustomer
        '
        Me.txtContactCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactCustomer.Location = New System.Drawing.Point(194, 267)
        Me.txtContactCustomer.Name = "txtContactCustomer"
        Me.txtContactCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtContactCustomer.TabIndex = 4
        '
        'btnClearCustomer
        '
        Me.btnClearCustomer.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearCustomer.Location = New System.Drawing.Point(563, 297)
        Me.btnClearCustomer.Name = "btnClearCustomer"
        Me.btnClearCustomer.Size = New System.Drawing.Size(100, 59)
        Me.btnClearCustomer.TabIndex = 10
        Me.btnClearCustomer.Text = "CLEAR"
        Me.btnClearCustomer.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(563, 203)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(100, 59)
        Me.btnAddCustomer.TabIndex = 9
        Me.btnAddCustomer.Text = "ADD"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(79, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 20)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Last Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(79, 210)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 20)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Middle Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(79, 180)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 20)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "First Name:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(79, 150)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 20)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Customer ID:"
        '
        'txtLastNameCustomer
        '
        Me.txtLastNameCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameCustomer.Location = New System.Drawing.Point(194, 237)
        Me.txtLastNameCustomer.Name = "txtLastNameCustomer"
        Me.txtLastNameCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtLastNameCustomer.TabIndex = 3
        '
        'txtMiddleNameCustomer
        '
        Me.txtMiddleNameCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleNameCustomer.Location = New System.Drawing.Point(194, 207)
        Me.txtMiddleNameCustomer.Name = "txtMiddleNameCustomer"
        Me.txtMiddleNameCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtMiddleNameCustomer.TabIndex = 2
        '
        'txtFirstNameCustomer
        '
        Me.txtFirstNameCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNameCustomer.Location = New System.Drawing.Point(194, 177)
        Me.txtFirstNameCustomer.Name = "txtFirstNameCustomer"
        Me.txtFirstNameCustomer.Size = New System.Drawing.Size(212, 26)
        Me.txtFirstNameCustomer.TabIndex = 1
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(194, 147)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(212, 26)
        Me.txtCustomerID.TabIndex = 34
        Me.txtCustomerID.TabStop = False
        '
        'frmAddCustomerPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtMunicipalityCustomer)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtBarangayCustomer)
        Me.Controls.Add(Me.txtStreetCustomer)
        Me.Controls.Add(Me.txtHouseNoCustomer)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtContactCustomer)
        Me.Controls.Add(Me.btnClearCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtLastNameCustomer)
        Me.Controls.Add(Me.txtMiddleNameCustomer)
        Me.Controls.Add(Me.txtFirstNameCustomer)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.POSPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddCustomerPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.POSPanel1.ResumeLayout(False)
        Me.POSPanel1.PerformLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents POSPanel1 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents pbxExitPOS As PictureBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtLastNameCustomer As TextBox
    Friend WithEvents txtMiddleNameCustomer As TextBox
    Friend WithEvents txtFirstNameCustomer As TextBox
    Friend WithEvents txtCustomerID As TextBox
End Class
