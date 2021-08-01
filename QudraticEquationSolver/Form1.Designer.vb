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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_clear = New System.Windows.Forms.Button()
        Me.Label_example = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label_precision = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1_method = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button_calculate = New System.Windows.Forms.Button()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.Button_copy = New System.Windows.Forms.Button()
        Me.Button_show_solution = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_x2 = New System.Windows.Forms.TextBox()
        Me.TextBox_x1 = New System.Windows.Forms.TextBox()
        Me.Status_Action = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_C = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.StatusStrip1_method = New System.Windows.Forms.StatusStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1_method.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_clear
        '
        Me.Button_clear.BackColor = System.Drawing.Color.Maroon
        Me.Button_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_clear.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_clear.ForeColor = System.Drawing.Color.White
        Me.Button_clear.Location = New System.Drawing.Point(50, 376)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(63, 35)
        Me.Button_clear.TabIndex = 64
        Me.Button_clear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Button_clear, "Clear all Inputs and Outputs")
        Me.Button_clear.UseVisualStyleBackColor = False
        '
        'Label_example
        '
        Me.Label_example.AutoSize = True
        Me.Label_example.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_example.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_example.Location = New System.Drawing.Point(12, 126)
        Me.Label_example.Name = "Label_example"
        Me.Label_example.Size = New System.Drawing.Size(108, 20)
        Me.Label_example.TabIndex = 63
        Me.Label_example.Text = "Example of:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All roots are Real", "All roots are Imaginary"})
        Me.ComboBox2.Location = New System.Drawing.Point(142, 122)
        Me.ComboBox2.MaximumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox2.MinimumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox2.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Select examples.")
        '
        'Label_precision
        '
        Me.Label_precision.AutoSize = True
        Me.Label_precision.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_precision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_precision.Location = New System.Drawing.Point(456, 126)
        Me.Label_precision.Name = "Label_precision"
        Me.Label_precision.Size = New System.Drawing.Size(99, 20)
        Me.Label_precision.TabIndex = 61
        Me.Label_precision.Text = "Precision:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Upto 3 decimal place", "Upto 4 decimal place", "Upto 9 decimal place"})
        Me.ComboBox1.Location = New System.Drawing.Point(579, 122)
        Me.ComboBox1.MaximumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox1.MinimumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox1.TabIndex = 60
        Me.ComboBox1.Text = "Upto 9 decimal place"
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Set number of Decimal Places. Default is 9.")
        '
        'Label1_method
        '
        Me.Label1_method.AutoSize = True
        Me.Label1_method.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_method.ForeColor = System.Drawing.Color.Green
        Me.Label1_method.Location = New System.Drawing.Point(216, 455)
        Me.Label1_method.Name = "Label1_method"
        Me.Label1_method.Size = New System.Drawing.Size(40, 18)
        Me.Label1_method.TabIndex = 58
        Me.Label1_method.Text = "----"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(26, 455)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 18)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Function Attribute:"
        '
        'Button_calculate
        '
        Me.Button_calculate.BackColor = System.Drawing.Color.Lime
        Me.Button_calculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_calculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_calculate.Location = New System.Drawing.Point(188, 376)
        Me.Button_calculate.Name = "Button_calculate"
        Me.Button_calculate.Size = New System.Drawing.Size(87, 35)
        Me.Button_calculate.TabIndex = 56
        Me.Button_calculate.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.Button_calculate, "Calculate given input.")
        Me.Button_calculate.UseVisualStyleBackColor = False
        '
        'Button_save
        '
        Me.Button_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_save.Location = New System.Drawing.Point(713, 322)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(110, 31)
        Me.Button_save.TabIndex = 55
        Me.Button_save.Text = "Save Output"
        Me.ToolTip1.SetToolTip(Me.Button_save, "Save current calculation.")
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'Button_copy
        '
        Me.Button_copy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_copy.Location = New System.Drawing.Point(540, 322)
        Me.Button_copy.Name = "Button_copy"
        Me.Button_copy.Size = New System.Drawing.Size(114, 31)
        Me.Button_copy.TabIndex = 54
        Me.Button_copy.Text = "Copy Output"
        Me.ToolTip1.SetToolTip(Me.Button_copy, "Copy Inputs and Outputs.")
        Me.Button_copy.UseVisualStyleBackColor = True
        '
        'Button_show_solution
        '
        Me.Button_show_solution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_show_solution.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_show_solution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_show_solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_show_solution.ForeColor = System.Drawing.Color.White
        Me.Button_show_solution.Location = New System.Drawing.Point(713, 447)
        Me.Button_show_solution.Name = "Button_show_solution"
        Me.Button_show_solution.Size = New System.Drawing.Size(112, 35)
        Me.Button_show_solution.TabIndex = 53
        Me.Button_show_solution.Text = "Show History"
        Me.Button_show_solution.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(489, 264)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "x2 ="
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(489, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "x1 ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quadratic Equation Solver"
        Me.ToolTip1.SetToolTip(Me.Label1, "Quadratic Equation Solver created by XE")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(456, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Roots"
        '
        'TextBox_x2
        '
        Me.TextBox_x2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_x2.Location = New System.Drawing.Point(540, 262)
        Me.TextBox_x2.Name = "TextBox_x2"
        Me.TextBox_x2.ReadOnly = True
        Me.TextBox_x2.Size = New System.Drawing.Size(289, 22)
        Me.TextBox_x2.TabIndex = 47
        Me.TextBox_x2.Text = "x2"
        '
        'TextBox_x1
        '
        Me.TextBox_x1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_x1.Location = New System.Drawing.Point(540, 219)
        Me.TextBox_x1.Name = "TextBox_x1"
        Me.TextBox_x1.ReadOnly = True
        Me.TextBox_x1.Size = New System.Drawing.Size(289, 22)
        Me.TextBox_x1.TabIndex = 46
        Me.TextBox_x1.Text = "x1"
        '
        'Status_Action
        '
        Me.Status_Action.ForeColor = System.Drawing.Color.Black
        Me.Status_Action.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Status_Action.Name = "Status_Action"
        Me.Status_Action.Size = New System.Drawing.Size(123, 20)
        Me.Status_Action.Text = "Actions: waiting..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 21)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "c ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 21)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "b ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "a ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Enter Values"
        '
        'TextBox_C
        '
        Me.TextBox_C.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_C.Location = New System.Drawing.Point(87, 303)
        Me.TextBox_C.Name = "TextBox_C"
        Me.TextBox_C.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_C.TabIndex = 39
        Me.TextBox_C.Text = "-22"
        '
        'TextBox_B
        '
        Me.TextBox_B.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_B.Location = New System.Drawing.Point(88, 264)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(186, 22)
        Me.TextBox_B.TabIndex = 38
        Me.TextBox_B.Text = "-4"
        '
        'TextBox_A
        '
        Me.TextBox_A.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_A.Location = New System.Drawing.Point(88, 221)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_A.TabIndex = 37
        Me.TextBox_A.Text = "2"
        '
        'StatusStrip1_method
        '
        Me.StatusStrip1_method.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.StatusStrip1_method.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1_method.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status_Action})
        Me.StatusStrip1_method.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1_method.Name = "StatusStrip1_method"
        Me.StatusStrip1_method.Size = New System.Drawing.Size(855, 26)
        Me.StatusStrip1_method.TabIndex = 36
        Me.StatusStrip1_method.Text = "StatusStrip1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(136, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "quadratic equation format:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 91)
        Me.Panel1.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(443, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ax^2 + bx + c = 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 542)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Label_example)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label_precision)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1_method)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button_calculate)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.Button_copy)
        Me.Controls.Add(Me.Button_show_solution)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox_x2)
        Me.Controls.Add(Me.TextBox_x1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_C)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.StatusStrip1_method)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(873, 589)
        Me.MinimumSize = New System.Drawing.Size(873, 589)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quadratic Equation Solver v1.0.0.0 XENON"
        Me.StatusStrip1_method.ResumeLayout(False)
        Me.StatusStrip1_method.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_clear As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label_example As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label_precision As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1_method As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button_calculate As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents Button_copy As Button
    Friend WithEvents Button_show_solution As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_x2 As TextBox
    Friend WithEvents TextBox_x1 As TextBox
    Friend WithEvents Status_Action As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_C As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents StatusStrip1_method As StatusStrip
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
