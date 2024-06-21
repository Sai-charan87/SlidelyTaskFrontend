<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtGithub = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtName = New TextBox()
        btnSubmit = New Button()
        lbform3 = New Label()
        btnStartStop = New Button()
        lblStopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(39, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 25)
        Label4.TabIndex = 27
        Label4.Text = "Github Link for Task2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(82, 307)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 25)
        Label3.TabIndex = 26
        Label3.Text = "Phone Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(114, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 25
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(110, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 24
        Label1.Text = "Name"
        ' 
        ' txtGithub
        ' 
        txtGithub.Font = New Font("Segoe UI", 14F)
        txtGithub.Location = New Point(261, 406)
        txtGithub.Multiline = True
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(330, 32)
        txtGithub.TabIndex = 22
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 14F)
        txtEmail.Location = New Point(261, 212)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(330, 32)
        txtEmail.TabIndex = 21
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 14F)
        txtPhone.Location = New Point(261, 304)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(330, 32)
        txtPhone.TabIndex = 20
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 14F)
        txtName.Location = New Point(261, 126)
        txtName.Name = "txtName"
        txtName.Size = New Size(330, 32)
        txtName.TabIndex = 19
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 14F)
        btnSubmit.Location = New Point(39, 615)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(552, 44)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lbform3
        ' 
        lbform3.AutoSize = True
        lbform3.Font = New Font("Segoe UI", 16F)
        lbform3.Location = New Point(110, 36)
        lbform3.Name = "lbform3"
        lbform3.Size = New Size(445, 30)
        lbform3.TabIndex = 16
        lbform3.Text = "Sai Charan, Slidely Tak 2 - Create Submission"
        ' 
        ' btnStartStop
        ' 
        btnStartStop.Font = New Font("Segoe UI", 14F)
        btnStartStop.Location = New Point(39, 519)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(309, 36)
        btnStartStop.TabIndex = 29
        btnStartStop.Text = "TOGGLE STOPWATCH ( CTRL + T)"
        btnStartStop.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.Font = New Font("Segoe UI", 14F)
        lblStopwatch.Location = New Point(376, 523)
        lblStopwatch.Multiline = True
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.ReadOnly = True
        lblStopwatch.Size = New Size(215, 32)
        lblStopwatch.TabIndex = 30
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 755)
        Controls.Add(lblStopwatch)
        Controls.Add(btnStartStop)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGithub)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(lbform3)
        Font = New Font("Segoe UI", 9F)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lbform3 As Label
    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblStopwatch As TextBox
End Class
