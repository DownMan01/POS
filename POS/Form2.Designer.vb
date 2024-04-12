<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProdCode = New System.Windows.Forms.TextBox()
        Me.ProdName = New System.Windows.Forms.TextBox()
        Me.ProdPrice = New System.Windows.Forms.TextBox()
        Me.ProdQnty = New System.Windows.Forms.TextBox()
        Me.BSave = New System.Windows.Forms.Button()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(278, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantity:"
        '
        'ProdCode
        '
        Me.ProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdCode.Location = New System.Drawing.Point(370, 166)
        Me.ProdCode.Name = "ProdCode"
        Me.ProdCode.Size = New System.Drawing.Size(198, 29)
        Me.ProdCode.TabIndex = 5
        '
        'ProdName
        '
        Me.ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName.Location = New System.Drawing.Point(370, 218)
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Size = New System.Drawing.Size(349, 29)
        Me.ProdName.TabIndex = 6
        '
        'ProdPrice
        '
        Me.ProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice.Location = New System.Drawing.Point(370, 270)
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.Size = New System.Drawing.Size(127, 29)
        Me.ProdPrice.TabIndex = 7
        '
        'ProdQnty
        '
        Me.ProdQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQnty.Location = New System.Drawing.Point(370, 326)
        Me.ProdQnty.Name = "ProdQnty"
        Me.ProdQnty.Size = New System.Drawing.Size(127, 29)
        Me.ProdQnty.TabIndex = 8
        '
        'BSave
        '
        Me.BSave.BackColor = System.Drawing.Color.White
        Me.BSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSave.ForeColor = System.Drawing.Color.Red
        Me.BSave.Location = New System.Drawing.Point(26, 179)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(122, 51)
        Me.BSave.TabIndex = 9
        Me.BSave.Text = "Save"
        Me.BSave.UseVisualStyleBackColor = False
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.Color.White
        Me.BSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSearch.ForeColor = System.Drawing.Color.Red
        Me.BSearch.Location = New System.Drawing.Point(26, 236)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(122, 51)
        Me.BSearch.TabIndex = 10
        Me.BSearch.Text = "Search"
        Me.BSearch.UseVisualStyleBackColor = False
        '
        'BDelete
        '
        Me.BDelete.BackColor = System.Drawing.Color.White
        Me.BDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDelete.ForeColor = System.Drawing.Color.Red
        Me.BDelete.Location = New System.Drawing.Point(26, 350)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(122, 51)
        Me.BDelete.TabIndex = 11
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = False
        '
        'BClose
        '
        Me.BClose.BackColor = System.Drawing.Color.White
        Me.BClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClose.ForeColor = System.Drawing.Color.Red
        Me.BClose.Location = New System.Drawing.Point(26, 407)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(122, 51)
        Me.BClose.TabIndex = 12
        Me.BClose.Text = "Close"
        Me.BClose.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BClear)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BSave)
        Me.GroupBox1.Controls.Add(Me.BClose)
        Me.GroupBox1.Controls.Add(Me.BSearch)
        Me.GroupBox1.Controls.Add(Me.BDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(172, 472)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'BClear
        '
        Me.BClear.BackColor = System.Drawing.Color.White
        Me.BClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClear.ForeColor = System.Drawing.Color.Red
        Me.BClear.Location = New System.Drawing.Point(25, 293)
        Me.BClear.Name = "BClear"
        Me.BClear.Size = New System.Drawing.Size(122, 51)
        Me.BClear.TabIndex = 16
        Me.BClear.Text = "Clear"
        Me.BClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS.My.Resources.Resources._180_1804434_product_registration_book_register_icon_png
        Me.PictureBox1.Location = New System.Drawing.Point(20, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(631, 66)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PRODUCT REGISTRATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProdQnty)
        Me.Controls.Add(Me.ProdPrice)
        Me.Controls.Add(Me.ProdName)
        Me.Controls.Add(Me.ProdCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProdCode As TextBox
    Friend WithEvents ProdName As TextBox
    Friend WithEvents ProdPrice As TextBox
    Friend WithEvents ProdQnty As TextBox
    Friend WithEvents BSave As Button
    Friend WithEvents BSearch As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents BClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BClear As Button
End Class
