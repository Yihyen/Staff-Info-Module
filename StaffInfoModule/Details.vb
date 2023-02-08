Imports System.Data.SqlClient

Public Class frmDetails


    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlClient.SqlDataReader
    Friend strPic As String
    Dim strpath As String
    Dim Name As String



    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSave.Enabled = False
        btnBrowse.Enabled = False
        txtName.Enabled = False
        txtNRIC.Enabled = False
        cldDateHired.Enabled = False
        txtContactNo.Enabled = False
        cboPosition.Enabled = False
        txtAddress.Enabled = False

        lblStaffID.Text = View.strDlt



        lblStaffID.Text = View.strID
        txtName.Text = View.strName
        If View.strGender = "Male" Then
            radMale.Checked = True

        Else
            radFemale.Checked = True
        End If

        txtNRIC.Text = View.strNRIC

        If View.strPosition = "Staff" Then
            cboPosition.SelectedIndex = 0

        Else
            cboPosition.SelectedIndex = 1

        End If



        txtContactNo.Text = View.strContact
        txtAddress.Text = View.strAdress
        Dim Bpathstring As String = System.IO.Path.Combine(frmAdd.folder, View.strPicture)
        ProfilePicPictureBox.Image = Image.FromFile(Bpathstring)
        strPath = Bpathstring
        Name = View.strPicture
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click




        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yen\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30"


        Dim fname As String = lblStaffID.Text & ".jpg"
        Dim pathstring As String = System.IO.Path.Combine(frmAdd.folder, fname)
        Dim a As Image = ProfilePicPictureBox.Image



        If con.State = ConnectionState.Open Then
            con.Close()

        End If



        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        Dim NFname As String
        NFname = "New" & Name
        cmd.CommandText = "update Staff set Name = '" + txtName.Text + "', NRIC = '" + txtNRIC.Text + "', Position = '" + cboPosition.SelectedItem.ToString() + "', DateHired = '" + cldDateHired.SelectionStart.ToString() + "', ContactNo = '" + txtContactNo.Text + "', Address = '" + txtAddress.Text + "' , profilePic = '" & NFname & "' WHERE staffID = '" + lblStaffID.Text + "' "
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.ExecuteNonQuery()
        Dim bpathstring As String = System.IO.Path.Combine(frmAdd.folder, NFname)
        Dim b As Image = ProfilePicPictureBox.Image
        b.Save(bpathstring)


        con.Close()
        MessageBox.Show("Update Successfully!", "Update")
        btnSave.Enabled = False
        txtName.Enabled = False
        txtNRIC.Enabled = False
        txtContactNo.Enabled = False
        cboPosition.Enabled = False
        txtAddress.Enabled = False
        btnEdit.Text = "Edit"
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProfilePicPictureBox.Image = Image.FromFile(opf.FileName)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If btnEdit.Text = "Edit" Then
            txtName.Enabled = True
            txtNRIC.Enabled = True
            txtContactNo.Enabled = True
            cboPosition.Enabled = True
            cldDateHired.Enabled = True
            txtAddress.Enabled = True
            btnSave.Enabled = True
            btnBrowse.Enabled = True
            btnEdit.Text = "Cancel"
        Else
            Dim confirmation As DialogResult = MessageBox.Show("Confirm cancel ?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                btnSave.Enabled = False
                btnBrowse.Enabled = False
                txtName.Enabled = False
                txtNRIC.Enabled = False
                cldDateHired.Enabled = False
                txtContactNo.Enabled = False
                cboPosition.Enabled = False
                txtAddress.Enabled = False
                btnEdit.Text = "Edit"
            End If


        End If

    End Sub


End Class