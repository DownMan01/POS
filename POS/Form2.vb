Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim i As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand

        Dim dr As OleDbDataReader

        conn.Open()
        sql = "Select * from tblRegistration WHERE pcode='" & ProdCode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            sql = "UPDATE tblRegistration SET pname='" & ProdName.Text & "', pprice='" & ProdPrice.Text & "', " &
        " qnty='" & ProdQnty.Text & "' WHERE pcode='" & ProdCode.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Connection = conn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            MsgBox("Record has been edited")

        Else
            sql = "INSERT INTO tblRegistration (pcode,pname,pprice,qnty) values ('" & ProdCode.Text & "', '" & ProdName.Text & "','" & ProdPrice.Text & "','" & ProdQnty.Text & "');"
            cmd = New OleDbCommand(sql, conn)
            cmd.Connection = conn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            MsgBox("New record has been saved")
        End If
        conn.Close()

    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim sql As String

        conn.Open()
        sql = "Select * from tblRegistration WHERE pcode='" & ProdCode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        ProdName.Text = ""
        ProdPrice.Text = ""
        ProdQnty.Text = ""
        i = 0
        Do While dr.Read = True
            ProdName.Text = dr(1)
            ProdPrice.Text = dr(2)
            ProdQnty.Text = dr(3)
            If i = 0 Then
                i = 1
            End If
        Loop

        If i > 0 Then
            MsgBox("Record found")

        Else
            MsgBox("No record found!")
        End If

        conn.Close()
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        ProdCode.Text = ""
        ProdName.Text = ""
        ProdPrice.Text = ""
        ProdQnty.Text = ""
        ProdCode.Focus()
    End Sub

    Private Sub ProdCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProdCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ProdName.Focus()
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand


        If MsgBox("Do you want to delete", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            conn.Open()
            sql = "Delete * from tblRegistration WHERE pcode='" & ProdCode.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                ProdCode.Text = ""
                ProdName.Text = ""
                ProdPrice.Text = ""
                ProdQnty.Text = ""
                ProdCode.Focus()
                MsgBox("Record has been deleted successfully!")

            Else
                MsgBox("No record has been deleted!")
            End If

            conn.Close()

        End If
    End Sub
End Class