Imports System.Data.Linq
Public Class MainWindow

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim db As New DataContext("Northwind.sdf")
        Dim customers As Table(Of Customers) = db.GetTable(Of Customers)()

        For Each cust As Customers In customers
            ListBox1.Items.Add(cust.ContactName)
        Next

    End Sub
End Class
