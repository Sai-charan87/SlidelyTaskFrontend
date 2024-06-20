Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    ' Class to represent a submission
    Private Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        submissions = New List(Of Submission) From {
            New Submission With {.Name = "John Doe", .Email = "john@example.com", .Phone = "123-456-7890", .GithubLink = "https://github.com/johndoe", .StopwatchTime = "00:01:23"},
            New Submission With {.Name = "Jane Smith", .Email = "jane@example.com", .Phone = "987-654-3210", .GithubLink = "https://github.com/janesmith", .StopwatchTime = "00:02:34"}
        }

        ' Set TextBoxes to read-only
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True
        txtGithub.ReadOnly = True
        txtStopwatchTime.ReadOnly = True

        ' Display the first submission
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            txtName.Text = submissions(index).Name
            txtEmail.Text = submissions(index).Email
            txtPhone.Text = submissions(index).Phone
            txtGithub.Text = submissions(index).GithubLink
            txtStopwatchTime.Text = submissions(index).StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
