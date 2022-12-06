<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.pbxExitChange = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsernameChange = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRetypePassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmitChange = New System.Windows.Forms.Button()
        Me.POSPanel1.SuspendLayout()
        CType(Me.pbxExitChange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POSPanel1
        '
        Me.POSPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.POSPanel1.Controls.Add(Me.pbxExitChange)
        Me.POSPanel1.Controls.Add(Me.Label1)
        Me.POSPanel1.Location = New System.Drawing.Point(0, 0)
        Me.POSPanel1.Name = "POSPanel1"
        Me.POSPanel1.Size = New System.Drawing.Size(800, 126)
        Me.POSPanel1.TabIndex = 35
        '
        'pbxExitChange
        '
        Me.pbxExitChange.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExitChange.Location = New System.Drawing.Point(748, 12)
        Me.pbxExitChange.Name = "pbxExitChange"
        Me.pbxExitChange.Size = New System.Drawing.Size(40, 40)
        Me.pbxExitChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExitChange.TabIndex = 2
        Me.pbxExitChange.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mohave", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'txtUsernameChange
        '
        Me.txtUsernameChange.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameChange.Location = New System.Drawing.Point(344, 187)
        Me.txtUsernameChange.Name = "txtUsernameChange"
        Me.txtUsernameChange.ReadOnly = True
        Me.txtUsernameChange.Size = New System.Drawing.Size(283, 34)
        Me.txtUsernameChange.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Username:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(344, 227)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(283, 34)
        Me.txtNewPassword.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 28)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "New Password:"
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetypePassword.Location = New System.Drawing.Point(344, 267)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetypePassword.Size = New System.Drawing.Size(283, 34)
        Me.txtRetypePassword.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(153, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 28)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Retype Password:"
        '
        'btnSubmitChange
        '
        Me.btnSubmitChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSubmitChange.Font = New System.Drawing.Font("Mohave", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitChange.ForeColor = System.Drawing.Color.White
        Me.btnSubmitChange.Location = New System.Drawing.Point(325, 332)
        Me.btnSubmitChange.Name = "btnSubmitChange"
        Me.btnSubmitChange.Size = New System.Drawing.Size(150, 50)
        Me.btnSubmitChange.TabIndex = 46
        Me.btnSubmitChange.Text = "SUBMIT"
        Me.btnSubmitChange.UseVisualStyleBackColor = False
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmitChange)
        Me.Controls.Add(Me.txtRetypePassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsernameChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.POSPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.POSPanel1.ResumeLayout(False)
        Me.POSPanel1.PerformLayout()
        CType(Me.pbxExitChange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents POSPanel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsernameChange As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRetypePassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmitChange As Button
    Friend WithEvents pbxExitChange As PictureBox
End Class
