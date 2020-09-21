<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWinndowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.SalaryDetailsToolStripMenuItem, Me.ToolStripMenuItem1, Me.EmployeeInformationToolStripMenuItem, Me.CourseDetailsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.OpenWinndowToolStripMenuItem, Me.AboutDeveloperrToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information "
        '
        'SalaryDetailsToolStripMenuItem
        '
        Me.SalaryDetailsToolStripMenuItem.Name = "SalaryDetailsToolStripMenuItem"
        Me.SalaryDetailsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.SalaryDetailsToolStripMenuItem.Text = "Salary Details   "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(97, 20)
        Me.ToolStripMenuItem1.Text = "Fee Structure   "
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(149, 20)
        Me.EmployeeInformationToolStripMenuItem.Text = "Employee Information    "
        '
        'CourseDetailsToolStripMenuItem
        '
        Me.CourseDetailsToolStripMenuItem.Name = "CourseDetailsToolStripMenuItem"
        Me.CourseDetailsToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.CourseDetailsToolStripMenuItem.Text = "Course Details  "
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ReportToolStripMenuItem.Text = "Report    "
        '
        'OpenWinndowToolStripMenuItem
        '
        Me.OpenWinndowToolStripMenuItem.Name = "OpenWinndowToolStripMenuItem"
        Me.OpenWinndowToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.OpenWinndowToolStripMenuItem.Text = "Open Winndow    "
        '
        'AboutDeveloperrToolStripMenuItem
        '
        Me.AboutDeveloperrToolStripMenuItem.Name = "AboutDeveloperrToolStripMenuItem"
        Me.AboutDeveloperrToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.AboutDeveloperrToolStripMenuItem.Text = "About Developerr    "
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'Collection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.The_School_System.My.Resources.Resources.gri
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(972, 489)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Collection"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenWinndowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDeveloperrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
