Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging

Public Class frmAdd


    Friend strPicture As String
    Friend folder As String = "C:\Users\yen\Desktop\Profile Picture"
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDataSet)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yen\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
        ProfilePicPictureBox.Image = Nothing
        'TODO: This line of code loads data into the 'StaffDataSet.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.StaffDataSet.Staff)
        getOrderId()
        txtName.Text = ""
        radFemale.Checked = False
        radMale.Checked = False
        txtNRIC.Text = ""
        cboPosition.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" And txtNRIC.Text = "" And radFemale.Checked = False Or radMale.Checked = False And cboPosition.SelectedIndex > -1 And txtContactNo.Text = "" And txtAddress.Text = "" Then
            MessageBox.Show("Please Enter Something, Dont leave It Blank!", "Error")
        Else
            AddStaff()
            MessageBox.Show("Your data has been successfully added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Me.Close()

        txtName.Text = ""
        radFemale.Checked = False
        radMale.Checked = False
        txtNRIC.Text = ""
        cboPosition.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""

    End Sub

    Private Sub getOrderId()
        Dim intDigit As Integer
        Dim strResult As String

        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yen\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30")
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            Dim cmd = New SqlCommand("Select MAX(StaffID) from [Staff]", con)
            strResult = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(strResult) Then
                strResult = "S0001"
                lblStaffID.Text = strResult
            End If
            strResult = strResult.Substring(3)
            Int32.TryParse(strResult, intDigit)
            intDigit = intDigit + 1
            strResult = "S" + intDigit.ToString("D4")
            lblStaffID.Text = strResult

            con.Close()
        End Using

    End Sub



    Public Sub AddStaff()

        Dim strGender As String
        If radFemale.Checked = True Then
            strGender = radFemale.Text
        Else
            strGender = radMale.Text
        End If

        Dim fname As String = lblStaffID.Text & ".jpg"

        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Staff Values('" + lblStaffID.Text + "' ,'" + txtName.Text + "','" + strGender + "','" + txtNRIC.Text + "','" + cboPosition.SelectedItem.ToString() + "','" + cldDateHired.SelectionStart.ToString() + "', '" + txtContactNo.Text + "', '" + txtAddress.Text + "' ,'" & fname & "')"
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.ExecuteNonQuery()
        Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        Dim a As Image = ProfilePicPictureBox.Image
        a.Save(pathstring)

        con.Close()

        'Dim er As New StringBuilder()
        'Dim control As Control = Nothing


        'Dim aStaff As New StaffDataSet()
        'Dim ms As New MemoryStream
        'Dim img() As Byte

        'ProfilePicPictureBox.Image.Save(ms, ProfilePicPictureBox.Image.RawFormat)
        'img = ms.ToArray()

        'aStaff.StaffID = lblStaffID.Text
        'aStaff.Name = txtStockName.Text.Trim()
        'tStock.StockSize = cboSize.SelectedItem.ToString()
        'tStock.StockColor = cboColor.SelectedItem.ToString()
        'tStock.StockPrice = Decimal.Parse(txtStockPrice.Text)
        'tStock.StockQuantity = Integer.Parse(txtStockQuantity.Text)
        'tStock.StockImage = img



        'Dim db As New stockDataContext
        'db.Stocks.InsertOnSubmit(tStock)
        'db.SubmitChanges()
        'getNxtID()
        'MessageBox.Show("Stock Add")


        ''Dim mstream As New System.IO.MemoryStream()
        ''ProfilePicPictureBox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        ''Dim arrImage As Object
        ''arrImage = mstream.GetBuffer()
        ''Dim FileSize As UInt32
        ''FileSize = CUInt(mstream.Length)

        ''mstream.Close()
        ''con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yen\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30"

        ''If con.State = ConnectionState.Open Then
        ''    con.Close()

        ''End If

        ''con.Open()

        ''cmd.CommandText = "insert into Staff(StaffID,Name,Gender,NRIC,Position,DataHired,ContactNo,ProfilePic) Values(@StaffID,@Name,@Gender,@NRIC,@Position,@DataHired,@ContactNo,@ProfilePic)"
        ''cmd.Parameters.AddWithValue("@StaffID", lblStaffID.Text)
        ''cmd.Parameters.AddWithValue("@Name", txtName.Text)
        ''cmd.Parameters.AddWithValue("@Gender", strGender)
        ''cmd.Parameters.AddWithValue("@NRIC", txtNRIC.Text)
        ''cmd.Parameters.AddWithValue("@Position", cboPosition.SelectedItem.ToString)
        ''cmd.Parameters.AddWithValue("@DataHired", cldDateHired.SelectionStart.ToString)
        ''cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
        ''cmd.Parameters.AddWithValue("@ProfilePic", arrImage)












        '    StaffTableAdapter.InsertStaff(lblStaffID.Text, txtName.Text, strGender, txtNRIC.Text, CType(cboPosition.SelectedItem, String), CType(cldDateHired.SelectionStart, String), txtContactNo.Text, txtAddress.Text, ms.ToArray())
        '
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        radFemale.Checked = False
        radMale.Checked = False
        txtNRIC.Text = ""
        cboPosition.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        'Picture.ShowDialog()
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProfilePicPictureBox.Image = Image.FromFile(opf.FileName)
        End If

    End Sub




End Class
