<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Picture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Picture))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.radPicutre1 = New System.Windows.Forms.RadioButton()
        Me.radPicutre2 = New System.Windows.Forms.RadioButton()
        Me.radPicutre3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(277, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(537, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'btnComfirm
        '
        Me.btnComfirm.Location = New System.Drawing.Point(343, 406)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnComfirm.TabIndex = 3
        Me.btnComfirm.Text = "Comfirm"
        Me.btnComfirm.UseVisualStyleBackColor = True
        '
        'radPicutre1
        '
        Me.radPicutre1.AutoSize = True
        Me.radPicutre1.Location = New System.Drawing.Point(29, 19)
        Me.radPicutre1.Name = "radPicutre1"
        Me.radPicutre1.Size = New System.Drawing.Size(45, 17)
        Me.radPicutre1.TabIndex = 4
        Me.radPicutre1.TabStop = True
        Me.radPicutre1.Text = "Dog"
        Me.radPicutre1.UseVisualStyleBackColor = True
        '
        'radPicutre2
        '
        Me.radPicutre2.AutoSize = True
        Me.radPicutre2.Location = New System.Drawing.Point(309, 19)
        Me.radPicutre2.Name = "radPicutre2"
        Me.radPicutre2.Size = New System.Drawing.Size(57, 17)
        Me.radPicutre2.TabIndex = 5
        Me.radPicutre2.TabStop = True
        Me.radPicutre2.Text = "Sleepy"
        Me.radPicutre2.UseVisualStyleBackColor = True
        '
        'radPicutre3
        '
        Me.radPicutre3.AutoSize = True
        Me.radPicutre3.Location = New System.Drawing.Point(556, 19)
        Me.radPicutre3.Name = "radPicutre3"
        Me.radPicutre3.Size = New System.Drawing.Size(47, 17)
        Me.radPicutre3.TabIndex = 6
        Me.radPicutre3.TabStop = True
        Me.radPicutre3.Text = "Bear"
        Me.radPicutre3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPicutre1)
        Me.GroupBox1.Controls.Add(Me.radPicutre3)
        Me.GroupBox1.Controls.Add(Me.radPicutre2)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 55)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Picture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Picture"
        Me.Text = "Picuter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnComfirm As Button
    Friend WithEvents radPicutre1 As RadioButton
    Friend WithEvents radPicutre2 As RadioButton
    Friend WithEvents radPicutre3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
