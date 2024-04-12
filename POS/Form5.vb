Imports System.Data.OleDb

Public Class Form5
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim i As Integer
    Dim item1 As ListViewItem
    Dim totalsales As Double
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        sql = "Select * from tblSales"
        cmd = New OleDbCommand(Sql, conn)
        dr = cmd.ExecuteReader()
        Total.Text = ""
        ListView1.Items.Clear()

        Do While dr.Read = True
            item1 = ListView1.Items.Add(dr(1))
            item1.SubItems.Add(dr(2))
            item1.SubItems.Add(Format(Val(dr(3)), "#,##0.00;(#,##0.00)"))
            item1.SubItems.Add(dr(4))
            item1.SubItems.Add(Format(Val(dr(5)), "#,##0.00;(#,##0.00)"))
            totalsales = totalsales + Val(dr(5))
        Loop
        Total.Text = Format(totalsales, "#,##0.00;(#,##0.00)")
        conn.Close()
    End Sub
End Class