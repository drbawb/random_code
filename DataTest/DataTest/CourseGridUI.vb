Public Class CourseGridUI

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.TestDataSet.Courses)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CoursesFormUI.Show()
    End Sub

    Public Sub lolz()
        CoursesTableAdapter.Fill(TestDataSet.Courses)
        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        CoursesTableAdapter.Update(TestDataSet.Courses)
        DataGridView1.Refresh()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CoursesTableAdapter.Update(CoursesBindingSource.DataSource)
    End Sub
End Class