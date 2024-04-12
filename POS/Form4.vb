Imports System.Data.OleDb

Public Class Form4
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim i, a As Integer
    Dim item1 As ListViewItem
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        sql = "Select * from tblRegistration"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()

        ListView1.Items.Clear()

        Do While dr.Read = True
            item1 = ListView1.Items.Add(dr(0))
            item1.SubItems.Add(dr(1))
            item1.SubItems.Add(dr(3))
            item1.SubItems.Add("0")
            item1.SubItems.Add("0")
        Loop
        conn.Close()


        For a = 0 To ListView1.Items.Count - 1
            conn.Open()
            sql = "Select * from tblSales WHERE code='" & ListView1.Items(a).Text & "'"
            cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
            Do While dr.Read = True
                ListView1.Items(a).SubItems(3).Text = Val(ListView1.Items(a).SubItems(3).Text) + Val(dr(4))
                ListView1.Items(a).SubItems(4).Text = Val(ListView1.Items(a).SubItems(2).Text) - Val(ListView1.Items(a).SubItems(3).Text)
            Loop
            conn.Close()
        Next a



    End Sub
End Class