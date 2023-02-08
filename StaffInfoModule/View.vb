Imports System.Data.SqlClient


Public Class View

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Friend strDlt As String
    Friend strID As String
    Friend strName As String
    Friend strGender As String
    Friend strNRIC As String
    Friend strPosition As String
    Friend strDate As String
    Friend strContact As String
    Friend strAdress As String
    Friend strPicture As String
    Dim dr As SqlClient.SqlDataReader

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDataSet)

    End Sub

    Private Sub Viewvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSet.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.StaffDataSet.Staff)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yen\Documents\Staff.mdf;Integrated Security=True;Connect Timeout=30"

        refresh()



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd.ShowDialog()
        refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()



        strDlt = StaffDataGridView.SelectedCells.Item(0).Value.ToString()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Staff WHERE staffID = '" + strDlt + "' "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)



        If StaffDataGridView.SelectedRows.Count > 0 Then
            Dim ans As DialogResult = MessageBox.Show("Are you sure want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                StaffDataGridView.Rows.Remove(StaffDataGridView.SelectedRows(0))

                MessageBox.Show("Item Deleted!")
            Else
                MessageBox.Show("Delete Fail!")
            End If
        Else
            MessageBox.Show("Please select a row to DELETE", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        refresh()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        frmDetails.ShowDialog()
        refresh()
    End Sub



    Private Sub StaffDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        GetData()
        refresh()
    End Sub

    Private Sub StaffDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        GetData()
        frmDetails.ShowDialog()
        refresh()

    End Sub

    Private Sub refresh()

        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Staff "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        StaffDataGridView.DataSource = dt

    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        GetData()
        With printPreDia
            .Document = printDoc
            .ShowDialog()
        End With

    End Sub

    Private Sub GetData()


        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()

        strID = StaffDataGridView.SelectedCells.Item(0).Value.ToString()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Staff where StaffID = '" + strID + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            strID = dr.GetString(0).ToString()
            strName = dr.GetString(1).ToString()
            strGender = dr.GetString(2).ToString()
            strNRIC = dr.GetString(3).ToString()
            strPosition = dr.GetString(4).ToString()
            strDate = dr.GetDateTime(5).ToString
            strContact = dr.GetString(6).ToString()
            strAdress = dr.GetString(7).ToString()
            strPicture = dr.GetString(8).ToString()
        End While

    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Try
            Dim fntPrint As New Font("Arial", 14)
            Dim fntHeading As New Font("Arial", 16, FontStyle.Bold)
            Dim sngLineHeight As Single = fntPrint.GetHeight + 2

            Dim sngYLoc As Single = e.MarginBounds.Top
            Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss:tt}" & vbNewLine & "Prepared by TARUC", DateTime.Now)
            Dim picture As Image

            Dim Bpathstring As String = System.IO.Path.Combine(frmAdd.folder, strPicture)
            Dim NewSize As New Size(200, 200)
            picture = Image.FromFile(Bpathstring)
            Dim a As New Bitmap(picture, NewSize)



            'Header

            Dim sngXLoc As Single = 200
            Dim BsngXloc As Single = 300
            e.Graphics.DrawString("Staff Information", New Drawing.Font("Arial", 34), Brushes.Black, sngXLoc, sngYLoc)
            sngYLoc += 70
            e.Graphics.DrawString(subHeader, fntHeading, Brushes.Black, sngXLoc, sngYLoc)
            sngYLoc += 70
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("                ---------------------------------", fntPrint, Brushes.Black, sngXLoc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawImage(a, 60, sngYLoc)

            e.Graphics.DrawString("Staff ID : " & strID, fntPrint, Brushes.Black, BsngXloc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("  Name : " & strName, fntPrint, Brushes.Black, BsngXloc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("Gender : " & strGender, fntPrint, Brushes.Black, BsngXloc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("    NRIC : " & strNRIC, fntPrint, Brushes.Black, BsngXloc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("Position : " & strPosition, fntPrint, Brushes.Black, 295, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("    Date : " & strDate, fntPrint, Brushes.Black, BsngXloc, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("Contact : " & strContact, fntPrint, Brushes.Black, 295, (sngYLoc + 10))
            sngYLoc += sngLineHeight
            e.Graphics.DrawString("Address : " & strAdress, fntPrint, Brushes.Black, 293, (sngYLoc + 10))
            sngYLoc += sngLineHeight

            e.Graphics.DrawString("                ---------------------------------", fntPrint, Brushes.Black, sngXLoc, (sngYLoc + 30))
        Catch ex As Exception
            MessageBox.Show("System Error Can't Print!")
        End Try
    End Sub

    Private Sub StaffDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StaffDataGridView.CellMouseDoubleClick
        GetData()
        frmDetails.ShowDialog()
    End Sub

    Private Sub StaffDataGridView_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellClick
        GetData()
    End Sub
End Class