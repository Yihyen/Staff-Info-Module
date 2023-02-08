<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetails
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
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim NRICLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim DateHiredLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ProfilePicPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNRIC = New System.Windows.Forms.TextBox()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.cldDateHired = New System.Windows.Forms.MonthCalendar()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        StaffIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        NRICLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        DateHiredLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.ProfilePicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.Location = New System.Drawing.Point(72, 65)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(46, 13)
        StaffIDLabel.TabIndex = 24
        StaffIDLabel.Text = "Staff ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(72, 94)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 26
        NameLabel.Text = "Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(72, 123)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 28
        GenderLabel.Text = "Gender:"
        '
        'NRICLabel
        '
        NRICLabel.AutoSize = True
        NRICLabel.Location = New System.Drawing.Point(72, 150)
        NRICLabel.Name = "NRICLabel"
        NRICLabel.Size = New System.Drawing.Size(36, 13)
        NRICLabel.TabIndex = 30
        NRICLabel.Text = "NRIC:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(72, 176)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 32
        PositionLabel.Text = "Position:"
        '
        'DateHiredLabel
        '
        DateHiredLabel.AutoSize = True
        DateHiredLabel.Location = New System.Drawing.Point(72, 206)
        DateHiredLabel.Name = "DateHiredLabel"
        DateHiredLabel.Size = New System.Drawing.Size(61, 13)
        DateHiredLabel.TabIndex = 34
        DateHiredLabel.Text = "Date Hired:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(72, 376)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 36
        ContactNoLabel.Text = "Contact No:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(72, 402)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 38
        AddressLabel.Text = "Address:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(425, 174)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(114, 23)
        Me.btnBrowse.TabIndex = 42
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'ProfilePicPictureBox
        '
        Me.ProfilePicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProfilePicPictureBox.Location = New System.Drawing.Point(412, 51)
        Me.ProfilePicPictureBox.Name = "ProfilePicPictureBox"
        Me.ProfilePicPictureBox.Size = New System.Drawing.Size(137, 116)
        Me.ProfilePicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePicPictureBox.TabIndex = 41
        Me.ProfilePicPictureBox.TabStop = False
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Location = New System.Drawing.Point(142, 64)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(69, 23)
        Me.lblStaffID.TabIndex = 25
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(142, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 20)
        Me.txtName.TabIndex = 27
        '
        'txtNRIC
        '
        Me.txtNRIC.Location = New System.Drawing.Point(142, 147)
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.Size = New System.Drawing.Size(178, 20)
        Me.txtNRIC.TabIndex = 31
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Staff", "Manager"})
        Me.cboPosition.Location = New System.Drawing.Point(142, 173)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(178, 21)
        Me.cboPosition.TabIndex = 33
        '
        'cldDateHired
        '
        Me.cldDateHired.Location = New System.Drawing.Point(142, 206)
        Me.cldDateHired.Name = "cldDateHired"
        Me.cldDateHired.TabIndex = 35
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(142, 373)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(178, 20)
        Me.txtContactNo.TabIndex = 37
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(142, 399)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 54)
        Me.txtAddress.TabIndex = 39
        '
        'radMale
        '
        Me.radMale.Location = New System.Drawing.Point(142, 117)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(178, 24)
        Me.radMale.TabIndex = 29
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.Location = New System.Drawing.Point(242, 117)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(104, 24)
        Me.radFemale.TabIndex = 40
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(136, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(261, 480)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 44
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(625, 527)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.ProfilePicPictureBox)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(NRICLabel)
        Me.Controls.Add(Me.txtNRIC)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(DateHiredLabel)
        Me.Controls.Add(Me.cldDateHired)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.txtAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDetails"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Update"
        CType(Me.ProfilePicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents ProfilePicPictureBox As PictureBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNRIC As TextBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents cldDateHired As MonthCalendar
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
End Class
