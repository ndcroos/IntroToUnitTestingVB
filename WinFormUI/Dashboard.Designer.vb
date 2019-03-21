<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.calculateSection = New System.Windows.Forms.GroupBox()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.subtractButton = New System.Windows.Forms.Button()
        Me.resultsLabel = New System.Windows.Forms.Label()
        Me.resultsText = New System.Windows.Forms.TextBox()
        Me.secondNumberValue = New System.Windows.Forms.NumericUpDown()
        Me.firstNumberValue = New System.Windows.Forms.NumericUpDown()
        Me.addButton = New System.Windows.Forms.Button()
        Me.secondNumberLabel = New System.Windows.Forms.Label()
        Me.firstNumberLabel = New System.Windows.Forms.Label()
        Me.databaseSectionGroup = New System.Windows.Forms.GroupBox()
        Me.addPersonButton = New System.Windows.Forms.Button()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.lastNameText = New System.Windows.Forms.TextBox()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.firstNameText = New System.Windows.Forms.TextBox()
        Me.usersLabel = New System.Windows.Forms.Label()
        Me.usersDropdown = New System.Windows.Forms.ComboBox()
        Me.calculateSection.SuspendLayout()
        CType(Me.secondNumberValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firstNumberValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.databaseSectionGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'calculateSection
        '
        Me.calculateSection.Controls.Add(Me.divideButton)
        Me.calculateSection.Controls.Add(Me.multiplyButton)
        Me.calculateSection.Controls.Add(Me.subtractButton)
        Me.calculateSection.Controls.Add(Me.resultsLabel)
        Me.calculateSection.Controls.Add(Me.resultsText)
        Me.calculateSection.Controls.Add(Me.secondNumberValue)
        Me.calculateSection.Controls.Add(Me.firstNumberValue)
        Me.calculateSection.Controls.Add(Me.addButton)
        Me.calculateSection.Controls.Add(Me.secondNumberLabel)
        Me.calculateSection.Controls.Add(Me.firstNumberLabel)
        Me.calculateSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateSection.Location = New System.Drawing.Point(22, 22)
        Me.calculateSection.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.calculateSection.Name = "calculateSection"
        Me.calculateSection.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.calculateSection.Size = New System.Drawing.Size(338, 313)
        Me.calculateSection.TabIndex = 8
        Me.calculateSection.TabStop = False
        Me.calculateSection.Text = "Calculate Section"
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(23, 256)
        Me.divideButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(150, 38)
        Me.divideButton.TabIndex = 12
        Me.divideButton.Text = "Divide"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(23, 213)
        Me.multiplyButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(150, 38)
        Me.multiplyButton.TabIndex = 11
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.Location = New System.Drawing.Point(23, 170)
        Me.subtractButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(150, 38)
        Me.subtractButton.TabIndex = 10
        Me.subtractButton.Text = "Subtract"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'resultsLabel
        '
        Me.resultsLabel.AutoSize = True
        Me.resultsLabel.Location = New System.Drawing.Point(195, 172)
        Me.resultsLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.resultsLabel.Name = "resultsLabel"
        Me.resultsLabel.Size = New System.Drawing.Size(85, 26)
        Me.resultsLabel.TabIndex = 7
        Me.resultsLabel.Text = "Results"
        '
        'resultsText
        '
        Me.resultsText.Location = New System.Drawing.Point(200, 204)
        Me.resultsText.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.resultsText.Name = "resultsText"
        Me.resultsText.Size = New System.Drawing.Size(123, 32)
        Me.resultsText.TabIndex = 9
        '
        'secondNumberValue
        '
        Me.secondNumberValue.Location = New System.Drawing.Point(200, 74)
        Me.secondNumberValue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.secondNumberValue.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.secondNumberValue.Name = "secondNumberValue"
        Me.secondNumberValue.Size = New System.Drawing.Size(123, 32)
        Me.secondNumberValue.TabIndex = 8
        '
        'firstNumberValue
        '
        Me.firstNumberValue.Location = New System.Drawing.Point(200, 35)
        Me.firstNumberValue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.firstNumberValue.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.firstNumberValue.Name = "firstNumberValue"
        Me.firstNumberValue.Size = New System.Drawing.Size(123, 32)
        Me.firstNumberValue.TabIndex = 7
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(23, 127)
        Me.addButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(150, 38)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'secondNumberLabel
        '
        Me.secondNumberLabel.AutoSize = True
        Me.secondNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondNumberLabel.Location = New System.Drawing.Point(18, 79)
        Me.secondNumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.secondNumberLabel.Name = "secondNumberLabel"
        Me.secondNumberLabel.Size = New System.Drawing.Size(170, 26)
        Me.secondNumberLabel.TabIndex = 5
        Me.secondNumberLabel.Text = "Second Number"
        '
        'firstNumberLabel
        '
        Me.firstNumberLabel.AutoSize = True
        Me.firstNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumberLabel.Location = New System.Drawing.Point(18, 40)
        Me.firstNumberLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.firstNumberLabel.Name = "firstNumberLabel"
        Me.firstNumberLabel.Size = New System.Drawing.Size(138, 26)
        Me.firstNumberLabel.TabIndex = 3
        Me.firstNumberLabel.Text = "First Number"
        '
        'databaseSectionGroup
        '
        Me.databaseSectionGroup.Controls.Add(Me.addPersonButton)
        Me.databaseSectionGroup.Controls.Add(Me.lastNameLabel)
        Me.databaseSectionGroup.Controls.Add(Me.lastNameText)
        Me.databaseSectionGroup.Controls.Add(Me.firstNameLabel)
        Me.databaseSectionGroup.Controls.Add(Me.firstNameText)
        Me.databaseSectionGroup.Controls.Add(Me.usersLabel)
        Me.databaseSectionGroup.Controls.Add(Me.usersDropdown)
        Me.databaseSectionGroup.Location = New System.Drawing.Point(369, 22)
        Me.databaseSectionGroup.Name = "databaseSectionGroup"
        Me.databaseSectionGroup.Size = New System.Drawing.Size(393, 313)
        Me.databaseSectionGroup.TabIndex = 9
        Me.databaseSectionGroup.TabStop = False
        Me.databaseSectionGroup.Text = "Database Section"
        '
        'addPersonButton
        '
        Me.addPersonButton.Location = New System.Drawing.Point(94, 215)
        Me.addPersonButton.Name = "addPersonButton"
        Me.addPersonButton.Size = New System.Drawing.Size(171, 39)
        Me.addPersonButton.TabIndex = 6
        Me.addPersonButton.Text = "Add Person"
        Me.addPersonButton.UseVisualStyleBackColor = True
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Location = New System.Drawing.Point(20, 168)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(99, 24)
        Me.lastNameLabel.TabIndex = 5
        Me.lastNameLabel.Text = "Last Name"
        '
        'lastNameText
        '
        Me.lastNameText.Location = New System.Drawing.Point(142, 165)
        Me.lastNameText.Name = "lastNameText"
        Me.lastNameText.Size = New System.Drawing.Size(192, 29)
        Me.lastNameText.TabIndex = 4
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Location = New System.Drawing.Point(20, 131)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(101, 24)
        Me.firstNameLabel.TabIndex = 3
        Me.firstNameLabel.Text = "First Name"
        '
        'firstNameText
        '
        Me.firstNameText.Location = New System.Drawing.Point(142, 128)
        Me.firstNameText.Name = "firstNameText"
        Me.firstNameText.Size = New System.Drawing.Size(192, 29)
        Me.firstNameText.TabIndex = 2
        '
        'usersLabel
        '
        Me.usersLabel.AutoSize = True
        Me.usersLabel.Location = New System.Drawing.Point(20, 76)
        Me.usersLabel.Name = "usersLabel"
        Me.usersLabel.Size = New System.Drawing.Size(58, 24)
        Me.usersLabel.TabIndex = 1
        Me.usersLabel.Text = "Users"
        '
        'usersDropdown
        '
        Me.usersDropdown.FormattingEnabled = True
        Me.usersDropdown.Location = New System.Drawing.Point(94, 73)
        Me.usersDropdown.Name = "usersDropdown"
        Me.usersDropdown.Size = New System.Drawing.Size(240, 32)
        Me.usersDropdown.TabIndex = 0
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 366)
        Me.Controls.Add(Me.databaseSectionGroup)
        Me.Controls.Add(Me.calculateSection)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.calculateSection.ResumeLayout(False)
        Me.calculateSection.PerformLayout()
        CType(Me.secondNumberValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firstNumberValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.databaseSectionGroup.ResumeLayout(False)
        Me.databaseSectionGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents calculateSection As GroupBox
    Private WithEvents divideButton As Button
    Private WithEvents multiplyButton As Button
    Private WithEvents subtractButton As Button
    Private WithEvents resultsLabel As Label
    Private WithEvents resultsText As TextBox
    Private WithEvents secondNumberValue As NumericUpDown
    Private WithEvents firstNumberValue As NumericUpDown
    Private WithEvents addButton As Button
    Private WithEvents secondNumberLabel As Label
    Private WithEvents firstNumberLabel As Label
    Private WithEvents databaseSectionGroup As GroupBox
    Private WithEvents addPersonButton As Button
    Private WithEvents lastNameLabel As Label
    Private WithEvents lastNameText As TextBox
    Private WithEvents firstNameLabel As Label
    Private WithEvents firstNameText As TextBox
    Private WithEvents usersLabel As Label
    Private WithEvents usersDropdown As ComboBox
End Class
