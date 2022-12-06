<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword1
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUsernameForgot = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.POSPanel1 = New System.Windows.Forms.Panel()
        Me.pbxExitForgot = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.POSPanel1.SuspendLayout()
        CType(Me.pbxExitForgot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Mohave", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(325, 332)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 50)
        Me.btnSubmit.TabIndex = 52
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtUsernameForgot
        '
        Me.txtUsernameForgot.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameForgot.Location = New System.Drawing.Point(325, 230)
        Me.txtUsernameForgot.Name = "txtUsernameForgot"
        Me.txtUsernameForgot.Size = New System.Drawing.Size(283, 34)
        Me.txtUsernameForgot.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Username:"
        '
        'POSPanel1
        '
        Me.POSPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.POSPanel1.Controls.Add(Me.pbxExitForgot)
        Me.POSPanel1.Controls.Add(Me.Label1)
        Me.POSPanel1.Location = New System.Drawing.Point(0, 0)
        Me.POSPanel1.Name = "POSPanel1"
        Me.POSPanel1.Size = New System.Drawing.Size(800, 126)
        Me.POSPanel1.TabIndex = 45
        '
        'pbxExitForgot
        '
        Me.pbxExitForgot.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExitForgot.Location = New System.Drawing.Point(748, 12)
        Me.pbxExitForgot.Name = "pbxExitForgot"
        Me.pbxExitForgot.Size = New System.Drawing.Size(40, 40)
        Me.pbxExitForgot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExitForgot.TabIndex = 2
        Me.pbxExitForgot.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mohave", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forgot Password"
        '
        'frmForgotPassword1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtUsernameForgot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.POSPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmForgotPassword1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmForgotPassword1"
        Me.POSPanel1.ResumeLayout(False)
        Me.POSPanel1.PerformLayout()
        CType(Me.pbxExitForgot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtUsernameForgot As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents POSPanel1 As Panel
    Friend WithEvents pbxExitForgot As PictureBox
    Friend WithEvents Label1 As Label
End Class
