<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lbform2 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtGithub = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lbform2
        ' 
        lbform2.AutoSize = True
        lbform2.Font = New Font("Segoe UI", 16F)
        lbform2.Location = New Point(103, 22)
        lbform2.Name = "lbform2"
        lbform2.Size = New Size(437, 30)
        lbform2.TabIndex = 3
        lbform2.Text = "Sai Charan, Slidely Tak 2 - View Submissions"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Font = New Font("Segoe UI", 14F)
        btnPrevious.Location = New Point(26, 601)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(276, 44)
        btnPrevious.TabIndex = 4
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Font = New Font("Segoe UI", 14F)
        btnNext.Location = New Point(308, 601)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(276, 44)
        btnNext.TabIndex = 5
        btnNext.Text = "NEXT ( CTRL + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 14F)
        txtName.Location = New Point(254, 112)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(330, 32)
        txtName.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 14F)
        txtPhone.Location = New Point(254, 290)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(330, 32)
        txtPhone.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 14F)
        txtEmail.Location = New Point(254, 198)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(330, 32)
        txtEmail.TabIndex = 8
        ' 
        ' txtGithub
        ' 
        txtGithub.Font = New Font("Segoe UI", 14F)
        txtGithub.Location = New Point(257, 392)
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(327, 32)
        txtGithub.TabIndex = 9
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Font = New Font("Segoe UI", 14F)
        txtStopwatchTime.Location = New Point(257, 482)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(327, 32)
        txtStopwatchTime.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(103, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(107, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 12
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(75, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 25)
        Label3.TabIndex = 13
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(32, 395)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 25)
        Label4.TabIndex = 14
        Label4.Text = "Github Link for Task2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.Location = New Point(75, 489)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 25)
        Label5.TabIndex = 15
        Label5.Text = "Stopwatch time"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 695)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithub)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lbform2)
        Location = New Point(51, 254)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbform2 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
