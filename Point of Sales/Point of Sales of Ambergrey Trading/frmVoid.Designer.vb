<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoid
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
        Me.dgvVoid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearchTrans = New System.Windows.Forms.TextBox()
        Me.btnSearchTrans = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.POSPanel1.SuspendLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVoid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.POSPanel1.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Mohave", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(553, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(235, 45)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Void Transaction"
        '
        'pbxExitPOS
        '
        Me.pbxExitPOS.Image = Global.Point_of_Sales_of_Ambergrey_Trading.My.Resources.Resources.exit_26px
        Me.pbxExitPOS.Location = New System.Drawing.Point(748, 12)
        Me.pbxExitPOS.Name = "pbxExitPOS"
        Me.pbxExitPOS.Size = New System.Drawing.Size(40, 40)
        Me.pbxExitPOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExitPOS.TabIndex = 3
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
        'dgvVoid
        '
        Me.dgvVoid.AllowUserToAddRows = False
        Me.dgvVoid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVoid.BackgroundColor = System.Drawing.Color.White
        Me.dgvVoid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVoid.Location = New System.Drawing.Point(26, 184)
        Me.dgvVoid.Name = "dgvVoid"
        Me.dgvVoid.ReadOnly = True
        Me.dgvVoid.RowTemplate.Height = 25
        Me.dgvVoid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVoid.Size = New System.Drawing.Size(438, 232)
        Me.dgvVoid.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(511, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 232)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(70, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Mohave", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "VOID TRANSACTION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearchTrans
        '
        Me.txtSearchTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTrans.Location = New System.Drawing.Point(170, 152)
        Me.txtSearchTrans.Name = "txtSearchTrans"
        Me.txtSearchTrans.Size = New System.Drawing.Size(176, 26)
        Me.txtSearchTrans.TabIndex = 37
        '
        'btnSearchTrans
        '
        Me.btnSearchTrans.Font = New System.Drawing.Font("Mohave", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTrans.Location = New System.Drawing.Point(352, 152)
        Me.btnSearchTrans.Name = "btnSearchTrans"
        Me.btnSearchTrans.Size = New System.Drawing.Size(112, 26)
        Me.btnSearchTrans.TabIndex = 38
        Me.btnSearchTrans.Text = "SEARCH"
        Me.btnSearchTrans.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Enter transaction ID:"
        '
        'frmVoid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearchTrans)
        Me.Controls.Add(Me.txtSearchTrans)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvVoid)
        Me.Controls.Add(Me.POSPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVoid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVoid"
        Me.POSPanel1.ResumeLayout(False)
        Me.POSPanel1.PerformLayout()
        CType(Me.pbxExitPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVoid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents POSPanel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbxExitPOS As PictureBox
    Friend WithEvents dgvVoid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearchTrans As TextBox
    Friend WithEvents btnSearchTrans As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label18 As Label
End Class
