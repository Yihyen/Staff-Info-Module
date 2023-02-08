Public Class Picture
    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        If radPicutre1.Checked = True Then
            frmAdd.ProfilePicPictureBox.Image = PictureBox1.Image
            frmDetails.ProfilePicPictureBox.Image = PictureBox1.Image
            frmAdd.strPicture = "Dog"
            frmDetails.strPic = "Dog"
        ElseIf radPicutre2.Checked = True Then
            frmAdd.ProfilePicPictureBox.Image = PictureBox2.Image
            frmDetails.ProfilePicPictureBox.Image = PictureBox2.Image
            frmAdd.strPicture = "Sleepy"
            frmDetails.strPic = "Sleepy"
        ElseIf radPicutre3.Checked = True Then
            frmAdd.ProfilePicPictureBox.Image = PictureBox3.Image
            frmDetails.ProfilePicPictureBox.Image = PictureBox3.Image
            frmAdd.strPicture = "Bear"
            frmDetails.strPic = "Bear"
        End If

        Me.Close()
    End Sub
End Class