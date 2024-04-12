<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.ProdQnty = New System.Windows.Forms.TextBox()
        Me.ProdPrice = New System.Windows.Forms.TextBox()
        Me.ProdName = New System.Windows.Forms.TextBox()
        Me.ProdCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BAdd = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AmountTend = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AmountChange = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReceiptNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BSave = New System.Windows.Forms.Button()
        Me.BClose = New System.Windows.Forms.Button()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdQnty
        '
        Me.ProdQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdQnty.Location = New System.Drawing.Point(345, 299)
        Me.ProdQnty.Name = "ProdQnty"
        Me.ProdQnty.Size = New System.Drawing.Size(127, 29)
        Me.ProdQnty.TabIndex = 17
        '
        'ProdPrice
        '
        Me.ProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPrice.Location = New System.Drawing.Point(345, 264)
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.Size = New System.Drawing.Size(127, 29)
        Me.ProdPrice.TabIndex = 16
        '
        'ProdName
        '
        Me.ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdName.Location = New System.Drawing.Point(345, 229)
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Size = New System.Drawing.Size(410, 29)
        Me.ProdName.TabIndex = 15
        '
        'ProdCode
        '
        Me.ProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdCode.Location = New System.Drawing.Point(345, 194)
        Me.ProdCode.Name = "ProdCode"
        Me.ProdCode.Size = New System.Drawing.Size(239, 29)
        Me.ProdCode.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(247, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(247, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Code:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(251, 352)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(637, 176)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "     CODE"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                          NAME"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QUANTITY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUBTOTAL"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'BAdd
        '
        Me.BAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAdd.Location = New System.Drawing.Point(478, 299)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(47, 29)
        Me.BAdd.TabIndex = 19
        Me.BAdd.Text = "ADD"
        Me.BAdd.UseVisualStyleBackColor = False
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(761, 542)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(127, 29)
        Me.Total.TabIndex = 21
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(693, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total:"
        '
        'AmountTend
        '
        Me.AmountTend.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTend.Location = New System.Drawing.Point(761, 577)
        Me.AmountTend.Name = "AmountTend"
        Me.AmountTend.Size = New System.Drawing.Size(127, 29)
        Me.AmountTend.TabIndex = 23
        Me.AmountTend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(569, 580)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Amount Tendered:"
        '
        'AmountChange
        '
        Me.AmountChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountChange.Location = New System.Drawing.Point(761, 612)
        Me.AmountChange.Name = "AmountChange"
        Me.AmountChange.Size = New System.Drawing.Size(127, 29)
        Me.AmountChange.TabIndex = 25
        Me.AmountChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(666, 617)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Change:"
        '
        'ReceiptNo
        '
        Me.ReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptNo.Location = New System.Drawing.Point(761, 127)
        Me.ReceiptNo.Name = "ReceiptNo"
        Me.ReceiptNo.Size = New System.Drawing.Size(127, 29)
        Me.ReceiptNo.TabIndex = 31
        Me.ReceiptNo.Text = "6"
        Me.ReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(633, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Receipt No.:"
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, -7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(181, 676)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'BClear
        '
        Me.BClear.BackColor = System.Drawing.Color.White
        Me.BClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClear.ForeColor = System.Drawing.Color.Red
        Me.BClear.Location = New System.Drawing.Point(28, 367)
        Me.BClear.Name = "BClear"
        Me.BClear.Size = New System.Drawing.Size(122, 51)
        Me.BClear.TabIndex = 17
        Me.BClear.Text = "Clear"
        Me.BClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS.My.Resources.Resources.bae94e8b8d71f1297c7db707df83a54e
        Me.PictureBox1.Location = New System.Drawing.Point(28, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BSave
        '
        Me.BSave.BackColor = System.Drawing.Color.White
        Me.BSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSave.ForeColor = System.Drawing.Color.Red
        Me.BSave.Location = New System.Drawing.Point(28, 222)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(122, 51)
        Me.BSave.TabIndex = 9
        Me.BSave.Text = "Save"
        Me.BSave.UseVisualStyleBackColor = False
        '
        'BClose
        '
        Me.BClose.BackColor = System.Drawing.Color.White
        Me.BClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClose.ForeColor = System.Drawing.Color.Red
        Me.BClose.Location = New System.Drawing.Point(28, 518)
        Me.BClose.Name = "BClose"
        Me.BClose.Size = New System.Drawing.Size(122, 51)
        Me.BClose.TabIndex = 12
        Me.BClose.Text = "Close"
        Me.BClose.UseVisualStyleBackColor = False
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.Color.White
        Me.BSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSearch.ForeColor = System.Drawing.Color.Red
        Me.BSearch.Location = New System.Drawing.Point(28, 293)
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
        Me.BDelete.Location = New System.Drawing.Point(28, 443)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(122, 51)
        Me.BDelete.TabIndex = 11
        Me.BDelete.Text = "Delete"
        Me.BDelete.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, -7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(782, 89)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "PURCHASING"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 666)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ReceiptNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AmountChange)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AmountTend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ProdQnty)
        Me.Controls.Add(Me.ProdPrice)
        Me.Controls.Add(Me.ProdName)
        Me.Controls.Add(Me.ProdCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProdQnty As TextBox
    Friend WithEvents ProdPrice As TextBox
    Friend WithEvents ProdName As TextBox
    Friend WithEvents ProdCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BAdd As Button
    Friend WithEvents Total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AmountTend As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AmountChange As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ReceiptNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BSave As Button
    Friend WithEvents BClose As Button
    Friend WithEvents BSearch As Button
    Friend WithEvents BDelete As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BClear As Button
End Class
