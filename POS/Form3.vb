Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form3
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim i, a, b As Integer
    Dim item1 As ListViewItem
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn.Open()
        sql = "Select * from tblReceiptNum"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()

        dr.Read()

        ReceiptNo.Text = Val(dr(0)) + 1

        conn.Close()
    End Sub

    Private Sub ProdCode_TextChanged(sender As Object, e As EventArgs) Handles ProdCode.TextChanged

    End Sub

    Private Sub ProdCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProdCode.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim cmd As OleDbCommand
            Dim dr As OleDbDataReader
            Dim sql As String

            conn.Open()
            sql = "Select * from tblRegistration WHERE pcode='" & ProdCode.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
            ProdName.Text = ""
            ProdPrice.Text = ""

            Do While dr.Read = True
                ProdName.Text = dr(1)
                ProdPrice.Text = dr(2)
            Loop
            ProdPrice.Text = Format(Val(ProdPrice.Text), "#,##0.00;(#,##0.00)")
            ProdQnty.Focus()
            conn.Close()
        End If
    End Sub
    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click

        If ProdQnty.Text <> "" Then
            item1 = ListView1.Items.Add(ProdCode.Text)
            item1.SubItems.Add(ProdName.Text)
            item1.SubItems.Add(Format(Val(ProdPrice.Text), "#,##0.00;(#,##0.00)"))
            item1.SubItems.Add(ProdQnty.Text)
            item1.SubItems.Add(Format(Val(ProdPrice.Text * ProdQnty.Text), "#,##0.00;(#,##0.00)"))
            Total.Text = Format(Val(Total.Text) + Val(ProdPrice.Text) * Val(ProdQnty.Text), "#,##0.00;(#,##0.00)")
            AmountChange.Text = Format(Val(AmountTend.Text) - Val(Total.Text), "#,##0.00;(#,##0.00)")
            ProdCode.Text = ""
            ProdName.Text = ""
            ProdPrice.Text = ""
            ProdQnty.Text = ""
            ProdCode.Focus()
        End If
    End Sub
    Private Sub ProdQnty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProdQnty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BAdd.Focus()
        End If
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        ProdCode.Text = ""
        ProdName.Text = ""
        ProdPrice.Text = ""
        ProdQnty.Text = ""
        Total.Text = ""
        AmountTend.Text = ""
        AmountChange.Text = ""
        ProdCode.Focus()
        ListView1.Items.Clear()
        b = 0
        conn.Open()
        sql = "Select * from tblReceiptNum"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()

        dr.Read()

        ReceiptNo.Text = Val(dr(0)) + 1

        conn.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim item1 As ListViewItem

        Total.Text = Val(Total.Text) - Val(ListView1.SelectedItems(0).SubItems(4).Text)
        item1 = ListView1.SelectedItems(0)
        item1.Remove()

    End Sub

    Private Sub AmountTend_TextChanged(sender As Object, e As EventArgs) Handles AmountTend.TextChanged
        AmountChange.Text = Format(Val(AmountTend.Text) - Val(Total.Text), "#,##0.00;(#,##0.00)")

    End Sub

    Private Sub AmountTend_LostFocus(sender As Object, e As EventArgs) Handles AmountTend.LostFocus
        AmountTend.Text = Format(Val(AmountTend.Text), "#,##0.00;(#,##0.00)")
    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click

        conn.Open()
        sql = "Select * from tblSales WHERE receiptnum='" & ReceiptNo.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        ProdCode.Text = ""
        ProdName.Text = ""
        ProdPrice.Text = ""
        ProdQnty.Text = ""
        Total.Text = ""
        AmountTend.Text = ""
        AmountChange.Text = ""
        ListView1.Items.Clear()
        i = 0
        Do While dr.Read = True
            item1 = ListView1.Items.Add(dr(1))
            item1.SubItems.Add(dr(2))
            item1.SubItems.Add(Format(Val(dr(3)), "#,##0.00;(#,##0.00)"))
            item1.SubItems.Add(dr(4))
            item1.SubItems.Add(Format(Val(dr(5)), "#,##0.00;(#,##0.00)"))
            Total.Text = Val(dr(6))
            AmountChange.Text = Val(dr(8))
            AmountTend.Text = Val(dr(7))
            Total.Text = Format(Val(Total.Text), "#,##0.00;(#,##0.00)")
            AmountTend.Text = Format(Val(AmountTend.Text), "#,##0.00;(#,##0.00)")
            AmountChange.Text = Format(Val(AmountChange.Text), "#,##0.00;(#,##0.00)")
            If i = 0 Then
                i = 1
            End If
        Loop

        If i > 0 Then
            b = 1
            MsgBox("Transaction found")
        Else
            MsgBox("Transaction Not found!")
        End If

        conn.Close()
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        conn.Open()

        sql = "Delete * from tblSales WHERE receiptnum='" & ReceiptNo.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = sql
        i = cmd.ExecuteNonQuery()

        conn.Close()

        ProdCode.Text = ""
        ProdName.Text = ""
        ProdPrice.Text = ""
        ProdQnty.Text = ""
        Total.Text = ""
        AmountTend.Text = ""
        AmountChange.Text = ""
        ProdCode.Focus()
        ListView1.Items.Clear()
        b = 0
        conn.Open()
        sql = "Select * from tblReceiptNum"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()

        dr.Read()

        ReceiptNo.Text = Val(dr(0)) + 1

        conn.Close()
        MsgBox("Transaction has been deleted")
    End Sub
    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        conn.Open()

        sql = "Delete * from tblSales WHERE receiptnum='" & ReceiptNo.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = sql
        i = cmd.ExecuteNonQuery()

        For a = 0 To ListView1.Items.Count - 1
            sql = "INSERT INTO tblSales(receiptnum,code,prodname,price,qnty,subtotal,total,amounttend,amountchange) values ('" & ReceiptNo.Text & "','" & ListView1.Items(a).Text & "', '" & ListView1.Items(a).SubItems(1).Text & "','" & ListView1.Items(a).SubItems(2).Text & "','" & ListView1.Items(a).SubItems(3).Text & "','" & ListView1.Items(a).SubItems(4).Text & "','" & Total.Text & "','" & AmountTend.Text & "','" & AmountChange.Text & "');"
            cmd = New OleDbCommand(sql, conn)
            cmd.Connection = conn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery()
        Next a
        If b = 0 Then
            sql = "UPDATE tblReceiptNum SET ReceiptNum='" & ReceiptNo.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Connection = conn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery()
        End If
        MsgBox("Transaction has been saved")

        conn.Close()
    End Sub
End Class