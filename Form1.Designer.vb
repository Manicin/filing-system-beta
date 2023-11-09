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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtEmployeeID = New TextBox()
        txtLastName = New TextBox()
        chkReportHazards = New CheckBox()
        Finishbtn = New Button()
        Nextbtn = New Button()
        Label4 = New Label()
        txtAge = New TextBox()
        txtMedicalIssues = New TextBox()
        GroupBox1 = New GroupBox()
        txtMiddleInitials = New TextBox()
        Label6 = New Label()
        txtFirstName = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 1
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 2
        Label3.Text = "Medical Concerns"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(130, 25)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(249, 23)
        txtEmployeeID.TabIndex = 3
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(130, 62)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(249, 23)
        txtLastName.TabIndex = 4
        ' 
        ' chkReportHazards
        ' 
        chkReportHazards.AutoSize = True
        chkReportHazards.Location = New Point(10, 352)
        chkReportHazards.Name = "chkReportHazards"
        chkReportHazards.Size = New Size(267, 19)
        chkReportHazards.TabIndex = 6
        chkReportHazards.Text = "Report any workplace hazards you've noticed."
        chkReportHazards.UseVisualStyleBackColor = True
        ' 
        ' Finishbtn
        ' 
        Finishbtn.Location = New Point(245, 404)
        Finishbtn.Name = "Finishbtn"
        Finishbtn.Size = New Size(75, 23)
        Finishbtn.TabIndex = 7
        Finishbtn.Text = "Finish"
        Finishbtn.UseVisualStyleBackColor = True
        ' 
        ' Nextbtn
        ' 
        Nextbtn.Location = New Point(329, 404)
        Nextbtn.Name = "Nextbtn"
        Nextbtn.Size = New Size(75, 23)
        Nextbtn.TabIndex = 8
        Nextbtn.Text = "Next"
        Nextbtn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 15)
        Label4.TabIndex = 9
        Label4.Text = "Employee ID Number"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(130, 179)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(48, 23)
        txtAge.TabIndex = 10
        ' 
        ' txtMedicalIssues
        ' 
        txtMedicalIssues.Location = New Point(130, 219)
        txtMedicalIssues.Multiline = True
        txtMedicalIssues.Name = "txtMedicalIssues"
        txtMedicalIssues.Size = New Size(249, 113)
        txtMedicalIssues.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(txtMiddleInitials)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtMedicalIssues)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtEmployeeID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(10, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(394, 338)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' txtMiddleInitials
        ' 
        txtMiddleInitials.Location = New Point(130, 140)
        txtMiddleInitials.Name = "txtMiddleInitials"
        txtMiddleInitials.Size = New Size(77, 23)
        txtMiddleInitials.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 15)
        Label6.TabIndex = 14
        Label6.Text = "Middle Initials"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(130, 103)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(249, 23)
        txtFirstName.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 12
        Label5.Text = "First Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(10, 408)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 15)
        Label7.TabIndex = 13
        Label7.Text = " Beta by Kelly Ashie"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(416, 439)
        Controls.Add(Label7)
        Controls.Add(GroupBox1)
        Controls.Add(Nextbtn)
        Controls.Add(Finishbtn)
        Controls.Add(chkReportHazards)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Filing System"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents chkReportHazards As CheckBox
    Friend WithEvents Finishbtn As Button
    Friend WithEvents Nextbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtMedicalIssues As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleInitials As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
