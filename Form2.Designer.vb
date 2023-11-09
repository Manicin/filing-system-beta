<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        CheckedListBox1 = New CheckedListBox()
        Label2 = New Label()
        Clearbtn = New Button()
        GroupBox1 = New GroupBox()
        chkOthers = New CheckBox()
        GroupBox2 = New GroupBox()
        txtOthers = New TextBox()
        btnClear = New Button()
        btnFinish = New Button()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.BackColor = SystemColors.Menu
        CheckedListBox1.BorderStyle = BorderStyle.None
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Noise-Related Issues", "Ergonomic Concerns", "Chemical Hazards", "Machinery an Equipment", "Electrical Safety", "Slips, Trips, and Falls", "Fire Safety", "Air Quality", "Manual Handling and Lifting", "Biological Hazards", "Workplace Violence", "Radiation Exposure", "Temperatute Extremes", "Confined Spaces"})
        CheckedListBox1.Location = New Point(0, 33)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(208, 252)
        CheckedListBox1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' Clearbtn
        ' 
        Clearbtn.Location = New Point(244, 276)
        Clearbtn.Name = "Clearbtn"
        Clearbtn.Size = New Size(75, 23)
        Clearbtn.TabIndex = 4
        Clearbtn.Text = "Clear"
        Clearbtn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkOthers)
        GroupBox1.Controls.Add(Clearbtn)
        GroupBox1.Controls.Add(CheckedListBox1)
        GroupBox1.Location = New Point(11, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(362, 311)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "What safety issues have you observed? Select all that apply."
        ' 
        ' chkOthers
        ' 
        chkOthers.AutoSize = True
        chkOthers.Location = New Point(1, 286)
        chkOthers.Name = "chkOthers"
        chkOthers.Size = New Size(61, 19)
        chkOthers.TabIndex = 5
        chkOthers.Text = "Others"
        chkOthers.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtOthers)
        GroupBox2.Controls.Add(btnClear)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(9, 333)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(364, 166)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "State any other concerns not mentioned above."
        ' 
        ' txtOthers
        ' 
        txtOthers.Location = New Point(6, 22)
        txtOthers.Multiline = True
        txtOthers.Name = "txtOthers"
        txtOthers.Size = New Size(315, 106)
        txtOthers.TabIndex = 6
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(246, 134)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnFinish
        ' 
        btnFinish.Location = New Point(401, 467)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(75, 23)
        btnFinish.TabIndex = 7
        btnFinish.Text = "Finish"
        btnFinish.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(11, 502)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 15)
        Label7.TabIndex = 14
        Label7.Text = " Beta by Kelly Ashie"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(498, 522)
        Controls.Add(Label7)
        Controls.Add(btnFinish)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Filing System"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Clearbtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents txtOthers As TextBox
End Class
