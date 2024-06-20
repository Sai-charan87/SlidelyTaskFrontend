<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn1vs = New Button()
        btn2cs = New Button()
        lbform1 = New Label()
        SuspendLayout()
        ' 
        ' btn1vs
        ' 
        btn1vs.Font = New Font("Segoe UI", 14F)
        btn1vs.Location = New Point(51, 144)
        btn1vs.Name = "btn1vs"
        btn1vs.Size = New Size(515, 56)
        btn1vs.TabIndex = 0
        btn1vs.Text = "VIEW SUBMISSIONS ( CTRL + V)"
        btn1vs.UseVisualStyleBackColor = True
        ' 
        ' btn2cs
        ' 
        btn2cs.Font = New Font("Segoe UI", 14F)
        btn2cs.Location = New Point(51, 254)
        btn2cs.Name = "btn2cs"
        btn2cs.Size = New Size(515, 61)
        btn2cs.TabIndex = 1
        btn2cs.Text = "CREATE NEW SUBMISSION ( CTRL + N)"
        btn2cs.UseVisualStyleBackColor = True
        ' 
        ' lbform1
        ' 
        lbform1.AutoSize = True
        lbform1.Font = New Font("Segoe UI", 16F)
        lbform1.Location = New Point(103, 63)
        lbform1.Name = "lbform1"
        lbform1.Size = New Size(432, 30)
        lbform1.TabIndex = 2
        lbform1.Text = "Sai Charan, Slidely Tak 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 368)
        Controls.Add(lbform1)
        Controls.Add(btn2cs)
        Controls.Add(btn1vs)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1vs As Button
    Friend WithEvents btn2cs As Button
    Friend WithEvents lbform1 As Label

End Class
