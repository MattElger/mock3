<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffDetails
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEmergencyNo = New System.Windows.Forms.TextBox()
        Me.txtHomeAdd = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmergencyNo = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHomeAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnRetreive = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbStaffID = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(3, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 32)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 29)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "   Staff"
        '
        'txtEmergencyNo
        '
        Me.txtEmergencyNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEmergencyNo.Location = New System.Drawing.Point(98, 136)
        Me.txtEmergencyNo.Name = "txtEmergencyNo"
        Me.txtEmergencyNo.Size = New System.Drawing.Size(112, 20)
        Me.txtEmergencyNo.TabIndex = 5
        '
        'txtHomeAdd
        '
        Me.txtHomeAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtHomeAdd.Location = New System.Drawing.Point(98, 112)
        Me.txtHomeAdd.Name = "txtHomeAdd"
        Me.txtHomeAdd.Size = New System.Drawing.Size(112, 20)
        Me.txtHomeAdd.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSurname.Location = New System.Drawing.Point(98, 88)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(112, 20)
        Me.txtSurname.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(98, 64)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(112, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'lblEmergencyNo
        '
        Me.lblEmergencyNo.AutoSize = True
        Me.lblEmergencyNo.Location = New System.Drawing.Point(8, 136)
        Me.lblEmergencyNo.Name = "lblEmergencyNo"
        Me.lblEmergencyNo.Size = New System.Drawing.Size(77, 13)
        Me.lblEmergencyNo.TabIndex = 14
        Me.lblEmergencyNo.Text = "Emergency No"
        '
        'txtStaffID
        '
        Me.txtStaffID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Location = New System.Drawing.Point(98, 40)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(112, 20)
        Me.txtStaffID.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbStaffID)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.lblDOB)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.txtDepartment)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtEmergencyNo)
        Me.Panel1.Controls.Add(Me.txtHomeAdd)
        Me.Panel1.Controls.Add(Me.txtSurname)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.lblEmergencyNo)
        Me.Panel1.Controls.Add(Me.txtStaffID)
        Me.Panel1.Controls.Add(Me.lblHomeAddress)
        Me.Panel1.Controls.Add(Me.lblSurname)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.lblStaffID)
        Me.Panel1.Controls.Add(Me.btnRetreive)
        Me.Panel1.Location = New System.Drawing.Point(32, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 284)
        Me.Panel1.TabIndex = 21
        '
        'lblHomeAddress
        '
        Me.lblHomeAddress.AutoSize = True
        Me.lblHomeAddress.Location = New System.Drawing.Point(8, 112)
        Me.lblHomeAddress.Name = "lblHomeAddress"
        Me.lblHomeAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblHomeAddress.TabIndex = 13
        Me.lblHomeAddress.Text = "Home Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(8, 88)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 12
        Me.lblSurname.Text = "Surname"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(8, 64)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 11
        Me.lblFirstName.Text = "First Name"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(8, 40)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(40, 13)
        Me.lblStaffID.TabIndex = 10
        Me.lblStaffID.Text = "StaffID"
        '
        'btnRetreive
        '
        Me.btnRetreive.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRetreive.Location = New System.Drawing.Point(114, 234)
        Me.btnRetreive.Name = "btnRetreive"
        Me.btnRetreive.Size = New System.Drawing.Size(96, 32)
        Me.btnRetreive.TabIndex = 0
        Me.btnRetreive.Text = "Retreive"
        Me.btnRetreive.UseVisualStyleBackColor = False
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(8, 161)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 19
        Me.lblDepartment.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDepartment.Location = New System.Drawing.Point(98, 158)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(112, 20)
        Me.txtDepartment.TabIndex = 20
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(98, 184)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(112, 20)
        Me.dtpDOB.TabIndex = 21
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(8, 190)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(66, 13)
        Me.lblDOB.TabIndex = 22
        Me.lblDOB.Text = "Date of Birth"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(114, 234)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 32)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'cmbStaffID
        '
        Me.cmbStaffID.FormattingEnabled = True
        Me.cmbStaffID.Location = New System.Drawing.Point(-13, 241)
        Me.cmbStaffID.Name = "cmbStaffID"
        Me.cmbStaffID.Size = New System.Drawing.Size(121, 21)
        Me.cmbStaffID.TabIndex = 24
        Me.cmbStaffID.Visible = False
        '
        'staffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 310)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "staffDetails"
        Me.Text = "staffDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtEmergencyNo As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmergencyNo As System.Windows.Forms.Label
    Friend WithEvents txtStaffID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblHomeAddress As System.Windows.Forms.Label
    Private WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents btnRetreive As System.Windows.Forms.Button
    Friend WithEvents cmbStaffID As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
