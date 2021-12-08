Public Class Class1
     Imports System.Data.SqlClient   
Public Class Form1
        Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load



            Me.CUSTOMERSTableAdapter.Fill(Enter Coolprop SQL SERVER LINK)
            ' Set the caption bar text of the form.   
            Me.Text = "Element Properties"
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim connection As SqlConnection = New sqlconnection()
            connection.ConnectionString = "Data Source=(ENTER SQL QUERY); _
         Initial Catalog=testDB;Integrated Security=True"
            connection.Open()
            Dim adp As SqlDataAdapter = New SqlDataAdapter _
            ("select * from Properties", connection)
            Dim ds As DataSet = New DataSet()
            adp.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End Sub
    End Class
End Class
