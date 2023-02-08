<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdd
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
        Me.components = New System.ComponentModel.Container()
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim NRICLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim DateHiredLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffDataSet = New StaffInfoModule.StaffDataSet()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtNRIC = New System.Windows.Forms.TextBox()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.cldDateHired = New System.Windows.Forms.MonthCalendar()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StaffTableAdapter = New StaffInfoModule.StaffDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New StaffInfoModule.StaffDataSetTableAdapters.TableAdapterManager()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ProfilePicPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        StaffIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        NRICLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        DateHiredLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.Location = New System.Drawing.Point(55, 40)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(46, 13)
        StaffIDLabel.TabIndex = 1
        StaffIDLabel.Text = "Staff ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(55, 69)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(55, 98)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'NRICLabel
        '
        NRICLabel.AutoSize = True
        NRICLabel.Location = New System.Drawing.Point(55, 125)
        NRICLabel.Name = "NRICLabel"
        NRICLabel.Size = New System.Drawing.Size(36, 13)
        NRICLabel.TabIndex = 7
        NRICLabel.Text = "NRIC:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(55, 151)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 9
        PositionLabel.Text = "Position:"
        '
        'DateHiredLabel
        '
        DateHiredLabel.AutoSize = True
        DateHiredLabel.Location = New System.Drawing.Point(55, 181)
        DateHiredLabel.Name = "DateHiredLabel"
        DateHiredLabel.Size = New System.Drawing.Size(61, 13)
        DateHiredLabel.TabIndex = 11
        DateHiredLabel.Text = "Date Hired:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(55, 351)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 13
        ContactNoLabel.Text = "Contact No:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(55, 377)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.StaffDataSet
        '
        'StaffDataSet
        '
        Me.StaffDataSet.DataSetName = "StaffDataSet"
        Me.StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "StaffID", True))
        Me.lblStaffID.Location = New System.Drawing.Point(125, 40)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(69, 23)
        Me.lblStaffID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Name", True))
        Me.txtName.Location = New System.Drawing.Point(125, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 20)
        Me.txtName.TabIndex = 4
        '
        'radMale
        '
        Me.radMale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StaffBindingSource, "Gender", True))
        Me.radMale.Location = New System.Drawing.Point(125, 92)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(178, 24)
        Me.radMale.TabIndex = 6
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtNRIC
        '
        Me.txtNRIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "NRIC", True))
        Me.txtNRIC.Location = New System.Drawing.Point(125, 122)
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.Size = New System.Drawing.Size(178, 20)
        Me.txtNRIC.TabIndex = 8
        '
        'cboPosition
        '
        Me.cboPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Staff", "Manager"})
        Me.cboPosition.Location = New System.Drawing.Point(125, 148)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(178, 21)
        Me.cboPosition.TabIndex = 10
        '
        'cldDateHired
        '
        Me.cldDateHired.DataBindings.Add(New System.Windows.Forms.Binding("SelectionRange", Me.StaffBindingSource, "DateHired", True))
        Me.cldDateHired.Location = New System.Drawing.Point(125, 181)
        Me.cldDateHired.Name = "cldDateHired"
        Me.cldDateHired.TabIndex = 12
        '
        'txtContactNo
        '
        Me.txtContactNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "ContactNo", True))
        Me.txtContactNo.Location = New System.Drawing.Point(125, 348)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(178, 20)
        Me.txtContactNo.TabIndex = 14
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(125, 374)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(178, 54)
        Me.txtAddress.TabIndex = 16
        '
        'radFemale
        '
        Me.radFemale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StaffBindingSource, "Gender", True))
        Me.radFemale.Location = New System.Drawing.Point(225, 92)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(104, 24)
        Me.radFemale.TabIndex = 18
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(108, 456)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Add"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = StaffInfoModule.StaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(225, 456)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ProfilePicPictureBox
        '
        Me.ProfilePicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProfilePicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource, "ProfilePic", True))
        Me.ProfilePicPictureBox.Location = New System.Drawing.Point(426, 48)
        Me.ProfilePicPictureBox.Name = "ProfilePicPictureBox"
        Me.ProfilePicPictureBox.Size = New System.Drawing.Size(137, 116)
        Me.ProfilePicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePicPictureBox.TabIndex = 22
        Me.ProfilePicPictureBox.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(440, 170)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(114, 23)
        Me.btnBrowse.TabIndex = 23
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(635, 503)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.ProfilePicPictureBox)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
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
        Me.Name = "frmAdd"
        Me.Text = "Add"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StaffDataSet As StaffDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As StaffDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As StaffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblStaffID As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtNRIC As TextBox
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents cldDateHired As MonthCalendar
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ProfilePicPictureBox As PictureBox
    Friend WithEvents btnBrowse As Button
End Class
