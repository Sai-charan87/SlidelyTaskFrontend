Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private timer As Timer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        stopwatch = New Stopwatch()
        timer = New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' 1 second

        lblStopwatch.Text = "00:00:00"

        ' Set KeyPreview to True to allow the form to process key events before any other control.
        Me.KeyPreview = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        ToggleStopwatch()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Await SubmitFormAsync()
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnStartStop.Text = "Resume"
        Else
            stopwatch.Start()
            timer.Start()
            btnStartStop.Text = "Pause"
        End If
    End Sub

    Private Async Function SubmitFormAsync() As Task
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithub.Text,
            .stopwatch_time = lblStopwatch.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
                Me.Close() ' Close the form after successful submission
            Else
                MessageBox.Show("Submission failed.")
            End If
        End Using
    End Function

    ' Add key down event handler to manage keyboard shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CreateSubmissionForm
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
            Me.lblStopwatch = New System.Windows.Forms.Label()
            Me.btnStartStop = New System.Windows.Forms.Button()
            Me.btnSubmit = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(12, 12)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(260, 20)
            Me.txtName.TabIndex = 0
            '
            'txtEmail
            '
            Me.txtEmail.Location = New System.Drawing.Point(12, 38)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(260, 20)
            Me.txtEmail.TabIndex = 1
            '
            'txtPhone
            '
            Me.txtPhone.Location = New System.Drawing.Point(12, 64)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(260, 20)
            Me.txtPhone.TabIndex = 2
            '
            'txtGithub
            '
            Me.txtGithub.Location = New System.Drawing.Point(12, 90)
            Me.txtGithub.Name = "txtGithub"
            Me.txtGithub.Size = New System.Drawing.Size(260, 20)
            Me.txtGithub.TabIndex = 3
            '
            'lblStopwatch
            '
            Me.lblStopwatch.AutoSize = True
            Me.lblStopwatch.Location = New System.Drawing.Point(12, 113)
            Me.lblStopwatch.Name = "lblStopwatch"
            Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
            Me.lblStopwatch.TabIndex = 4
            Me.lblStopwatch.Text = "00:00:00"
            '
            'btnStartStop
            '
            Me.btnStartStop.Location = New System.Drawing.Point(12, 129)
            Me.btnStartStop.Name = "btnStartStop"
            Me.btnStartStop.Size = New System.Drawing.Size(75, 23)
            Me.btnStartStop.TabIndex = 5
            Me.btnStartStop.Text = "Start"
            Me.btnStartStop.UseVisualStyleBackColor = True
            '
            'btnSubmit
            '
            Me.btnSubmit.Location = New System.Drawing.Point(197, 158)
            Me.btnSubmit.Name = "btnSubmit"
            Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
            Me.btnSubmit.TabIndex = 6
            Me.btnSubmit.Text = "Submit"
            Me.btnSubmit.UseVisualStyleBackColor = True
            '
            'CreateSubmissionForm
            '
            Me.ClientSize = New System.Drawing.Size(284, 193)
            Me.Controls.Add(Me.btnSubmit)
            Me.Controls.Add(Me.btnStartStop)
            Me.Controls.Add(Me.lblStopwatch)
            Me.Controls.Add(Me.txtGithub)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.txtName)
            Me.Name = "CreateSubmissionForm"
            Me.Text = "Create Submission"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents txtName As TextBox
        Friend WithEvents txtEmail As TextBox
        Friend WithEvents txtPhone As TextBox
        Friend WithEvents txtGithub As TextBox
        Friend WithEvents lblStopwatch As Label
        Friend WithEvents btnStartStop As Button
        Friend WithEvents btnSubmit As Button
    End Class

End Class
