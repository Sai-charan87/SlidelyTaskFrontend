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

        ' Set KeyPreview to True to allow the form to process key events before any other control.
        Me.KeyPreview = True

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
        ShowPreviousSubmission()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ShowNextSubmission()
    End Sub

    Private Sub ShowPreviousSubmission()
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub ShowNextSubmission()
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    ' Add key down event handler to manage keyboard shortcuts
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ShowPreviousSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ShowNextSubmission()
        End If
    End Sub

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ViewSubmissionsForm
        Inherits System.Windows.Forms.Form

        ' Required designer variable.
        Private components As System.ComponentModel.IContainer

        ' Clean up any resources being used.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ' Required method for Designer support - do not modify
        ' the contents of this method with the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.txtPhone = New System.Windows.Forms.TextBox()
            Me.txtGithub = New System.Windows.Forms.TextBox()
            Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
            Me.btnPrevious = New System.Windows.Forms.Button()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(12, 12)
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnly = True
            Me.txtName.Size = New System.Drawing.Size(260, 20)
            Me.txtName.TabIndex = 0
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(12, 38)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.ReadOnly = True
            Me.txtEmail.Size = New System.Drawing.Size(260, 20)
            Me.txtEmail.TabIndex = 1
            '
            'txtPhone
            '
            Me.txtPhone.Location = New System.Drawing.Point(12, 64)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.ReadOnly = True
            Me.txtPhone.Size = New System.Drawing.Size(260, 20)
            Me.txtPhone.TabIndex = 2
            '
            'txtGithub
            '
            Me.txtGithub.Location = New System.Drawing.Point(12, 90)
            Me.txtGithub.Name = "txtGithub"
            Me.txtGithub.ReadOnly = True
            Me.txtGithub.Size = New System.Drawing.Size(260, 20)
            Me.txtGithub.TabIndex = 3
            '
            'txtStopwatchTime
            '
            Me.txtStopwatchTime.Location = New System.Drawing.Point(12, 116)
            Me.txtStopwatchTime.Name = "txtStopwatchTime"
            Me.txtStopwatchTime.ReadOnly = True
            Me.txtStopwatchTime.Size = New System.Drawing.Size(260, 20)
            Me.txtStopwatchTime.TabIndex = 4
            '
            'btnPrevious
            '
            Me.btnPrevious.Location = New System.Drawing.Point(12, 142)
            Me.btnPrevious.Name = "btnPrevious"
            Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
            Me.btnPrevious.TabIndex = 5
            Me.btnPrevious.Text = "Previous"
            Me.btnPrevious.UseVisualStyleBackColor = True
            '
            'btnNext
            '
            Me.btnNext.Location = New System.Drawing.Point(197, 142)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(75, 23)
            Me.btnNext.TabIndex = 6
            Me.btnNext.Text = "Next"
            Me.btnNext.UseVisualStyleBackColor = True
            '
            'ViewSubmissionsForm
            '
            Me.ClientSize = New System.Drawing.Size(284, 177)
            Me.Controls.Add(Me.btnNext)
            Me.Controls.Add(Me.btnPrevious)
            Me.Controls.Add(Me.txtStopwatchTime)
            Me.Controls.Add(Me.txtGithub)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtName)
            Me.Name = "ViewSubmissionsForm"
            Me.Text = "View Submissions"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents txtName As TextBox
        Friend WithEvents txtEmail As TextBox
        Friend WithEvents txtPhone As TextBox
        Friend WithEvents txtGithub As TextBox
        Friend WithEvents txtStopwatchTime As TextBox
        Friend WithEvents btnPrevious As Button
        Friend WithEvents btnNext As Button
    End Class

End Class
