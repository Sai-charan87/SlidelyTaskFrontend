Imports System.IO
Imports System.Reflection
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    ' Class to represent a submission
    Private Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        <JsonProperty("github_link")>
        Public Property GithubLink As String
        <JsonProperty("stopwatch_time")>
        Public Property StopwatchTime As String
    End Class



    ' Helper class to match the JSON structure
    Private Class SubmissionsWrapper
        Public Property submissions As List(Of Submission)
    End Class

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadSubmissionsFromJson()

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

    Private Sub LoadSubmissionsFromJson()
        Try
            ' Get the base directory of the application
            Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory

            ' Construct the full path to db.json within the backend folder
            Dim dbJsonPath As String = Path.Combine(baseDirectory, "..", "..", "..", "..", "Backend", "src", "db.json")

            ' Normalize the path
            dbJsonPath = Path.GetFullPath(dbJsonPath)

            ' Check if the file exists
            If File.Exists(dbJsonPath) Then
                ' Read submissions from db.json file and deserialize JSON to List(Of Submission)
                Dim json As String = File.ReadAllText(dbJsonPath)
                Dim submissionsWrapper As SubmissionsWrapper = JsonConvert.DeserializeObject(Of SubmissionsWrapper)(json)

                ' Assign the submissions list
                submissions = submissionsWrapper.submissions

                ' Check if the submissions list is initialized
                If submissions Is Nothing Then
                    MessageBox.Show("Failed to deserialize submissions from the JSON file.")
                ElseIf submissions.Count = 0 Then
                    MessageBox.Show("The submissions list is empty.")
                End If
            Else
                MessageBox.Show($"Database file not found at: {dbJsonPath}")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading the submissions: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso index >= 0 AndAlso index < submissions.Count Then
            txtName.Text = submissions(index).Name
            txtEmail.Text = submissions(index).Email
            txtPhone.Text = submissions(index).Phone
            txtGithub.Text = submissions(index).GithubLink
            txtStopwatchTime.Text = submissions(index).StopwatchTime
        Else
            ' Clear the text boxes if no valid submission is found
            txtName.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            txtGithub.Clear()
            txtStopwatchTime.Clear()
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
