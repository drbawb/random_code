Public Class CoursesFormUI

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using db1 = New testEntities
            Try
                Dim newCourse As Courses = New Courses
                newCourse.Name = txtName.Text
                newCourse.Credits = CInt(txtCredits.Text)
                newCourse.Description = txtDescription.Text

                db1.AddToCourses(newCourse)
                db1.SaveChanges()

                CourseGridUI.lolz() 'tell form1 to refresh its stuff, yo.
                Me.Close() 'close this box, yo.
            Catch ex As Exception
                MsgBox("Credits must be an integer between 0 and 999")
            End Try

        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtCredits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCredits.TextChanged
        'validation of textbox
        Try
            Dim validation = CInt(txtCredits.Text)
            lblError.Visible = False
        Catch ex As Exception
            lblError.Text = "Must be a number!"
            lblError.Visible = True
            lblError.ForeColor = Color.Crimson
        End Try
    End Sub
End Class