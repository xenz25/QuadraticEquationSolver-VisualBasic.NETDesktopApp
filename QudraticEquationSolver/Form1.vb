Imports Microsoft.Office.Interop.Word

Public Class Form1
    Dim tbx_list As New List(Of TextBox)
    Dim program_started As Boolean = False
    Dim decimal_precision As Integer = 9
    Dim history_toggle As Integer = 0
    Dim logger_file_name_main As String = ""
    Public calculation_count As Integer = 0
    Public number_of_calculation As Integer = 0
    Dim computed_from_combox As Boolean = False
    Dim saved_text As String = ""
    Dim inserted_equation As String = ""
    Dim coefficient_list_main As List(Of Double) = New List(Of Double)
    Dim tool_tip_method_description As String = ""
    Dim prev As String = "Upto 9 decimal place"

    Class GeneralComputations
        Dim A, B, C As Double
        Dim x, y, z As Double
        Dim method_use As String = ""
        Dim xyz_list As List(Of Double) = New List(Of Double)

        Public Sub ExecuteComputations()
            ComputeY()
        End Sub
        Public Sub GetABCD(ByVal list_ABC As List(Of Double))
            'Gets the list of a,b,c coefficients
            A = list_ABC(0)
            B = list_ABC(1)
            C = list_ABC(2)
        End Sub

        Private Sub ComputeY()
            y = (B ^ 2) - (4 * A * C)
            If y < 0 Then
                method_use = "IMAG"
            ElseIf y >= 0 Then
                method_use = "REAL"
            End If
            AssignValues()
        End Sub

        Private Sub AssignValues()
            x = -1 * B
            z = 2 * A
        End Sub

        Public Function ReturnMethodUse()
            Return method_use
        End Function

        Public Function ReturnXYZList()
            xyz_list.Add(x)
            xyz_list.Add(y)
            xyz_list.Add(z)
            Return xyz_list
        End Function
    End Class

    Class MethodComputations
        Dim x, y, z As Double
        Dim method As String = ""
        Dim imag_roots As List(Of String) = New List(Of String)
        Dim real_roots As List(Of Double) = New List(Of Double)
        Dim imag_x1, imag_x2 As String
        Dim real_x1, real_x2 As Double
        Dim returning_list
        Public Sub GetXYZ(ByVal list_of_xyz As List(Of Double))
            x = list_of_xyz(0)
            y = list_of_xyz(1)
            z = list_of_xyz(2)
        End Sub

        Public Sub GetMethodUse(ByVal met As String)
            method = met
        End Sub

        Public Sub ExecuteComputations()
            ComputeRoots()
        End Sub

        Private Sub ComputeRoots()
            If method = "IMAG" Then 'if imaginary perform absolute value function on y
                Form1.Label1_method.Text = "All roots are Imaginary"
                Form1.tool_tip_method_description = "All roots are Imaginary"
                imag_x1 = String.Format("{0} + {1}i", Math.Round((x / z), Form1.decimal_precision), Math.Round(Math.Sqrt(Math.Abs(y)) / 2, Form1.decimal_precision))
                imag_x2 = String.Format("{0} - {1}i", Math.Round((x / z), Form1.decimal_precision), Math.Round(Math.Sqrt(Math.Abs(y)) / 2, Form1.decimal_precision))
                imag_roots.Add(imag_x1)
                imag_roots.Add(imag_x2)
                returning_list = imag_roots
            ElseIf method = "REAL" Then
                Form1.Label1_method.Text = "All roots are Real"
                Form1.tool_tip_method_description = "All roots are Real"
                real_x1 = Math.Round((x + Math.Sqrt(y)) / 2, Form1.decimal_precision)
                real_x2 = Math.Round((x - Math.Sqrt(y)) / 2, Form1.decimal_precision)
                real_roots.Add(real_x1)
                real_roots.Add(real_x2)
                returning_list = real_roots
            End If
        End Sub

        Public Function ReturnRoots()
            Return returning_list
        End Function


    End Class

    Public Function AddinputsToList(ByVal a As Double, b As Double, c As Double)
        Dim coefficient_list As List(Of Double) = New List(Of Double)
        coefficient_list.Add(a)
        coefficient_list.Add(b)
        coefficient_list.Add(c)
        Return coefficient_list
    End Function

    Public Sub HistoryToggle()
        If history_toggle Mod 2 = 0 Then
            Button_show_solution.Text = "Close History"
            History.Show()
            history_toggle += 1
        Else
            Button_show_solution.Text = "Show History"
            History.Dispose()
            history_toggle = 0
        End If
    End Sub

    Public Sub DeleteLogFile()
        Dim logger_path As String = System.IO.Path.GetFullPath(logger_file_name_main)
        System.IO.File.Delete(logger_path)
    End Sub

    Public Sub CalculationLogger(ByVal Optional text As String = "")
        Dim logger_file_number = 2
        Dim logger_file_name = "quadratic_log.txt"
        logger_file_name_main = "quadratic_log.txt"

        If computed_from_combox Then 'we dont want to log again the same answer in a different number of decimal place
            'pass
        Else
            If Not program_started Then
                Try
                    FileOpen(logger_file_number, logger_file_name, OpenMode.Output)
                    FileClose(logger_file_number)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    calculation_count += 1
                    FileOpen(logger_file_number, logger_file_name, OpenMode.Append)
                    PrintLine(logger_file_number, String.Format("Computation {0}:" & vbNewLine & text & vbNewLine, calculation_count))
                    FileClose(logger_file_number)
                Catch ex As Exception

                End Try
            End If
            History.LoadHistory()
        End If

    End Sub

    Public Sub ClearOutput()
        tbx_list.Clear()
        TextBox_x1.Text = "x1"
        TextBox_x2.Text = "x2"
        Label1_method.Text = "----"
    End Sub

    Public Sub ClearInput()
        TextBox_A.Clear()
        TextBox_B.Clear()
        TextBox_C.Clear()
    End Sub

    Public Sub ClearCombos()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Public Sub ActivateButtons()
            Button_copy.Enabled = True
            Button_save.Enabled = True
            Button_show_solution.Enabled = True
            TextBox_x1.Enabled = True
            TextBox_x2.Enabled = True
        End Sub

    Public Sub DeactivateButtons()
        program_started = False
        Status_Action.Text = "Actions: waiting..."
        Button_copy.Enabled = False
        Button_save.Enabled = False
        TextBox_x1.Enabled = False
        TextBox_x2.Enabled = False
    End Sub

    Public Sub WhenValid()
        Status_Action.Text = "Actions: Calculation Finished."
    End Sub

    Public Sub WhenInvalid()
        MessageBox.Show("Invalid input, cannot calculate", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Status_Action.Text = "Actions: Please check the inputs."
    End Sub

    Public Sub WhenInvalid2()
        MessageBox.Show("Math Error, 'a' cannot be Zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Status_Action.Text = "Actions: 'a' cannot be Zero."
    End Sub


    Private Sub Button_copy_Click(sender As Object, e As EventArgs) Handles Button_copy.Click
        My.Computer.Clipboard.SetText(saved_text)
        Status_Action.Text = "Actions: Successfully copied to clipboard."
    End Sub

    Private Sub Button_calculate_Click(sender As Object, e As EventArgs) Handles Button_calculate.Click
        program_started = True
        computed_from_combox = False
        number_of_calculation += 1
        Dim tbx_index As New List(Of Integer)
        tbx_list.Add(TextBox_A)
        tbx_list.Add(TextBox_B)
        tbx_list.Add(TextBox_C)

        Dim zero_occured As Boolean = False
        '=========================== colorize wrong input
        For item_num = 0 To tbx_list.Count() - 1
            If tbx_list(0).Text.ToString = "0" And Not zero_occured Then
                zero_occured = True
                tbx_index.Add(0)
                Continue For
            End If
            If IsNumeric(tbx_list(item_num).Text) Then
                'do nothing
            Else
                tbx_index.Add(item_num)
            End If
        Next

        For err_item = 0 To tbx_index.Count() - 1
            tbx_list(tbx_index(err_item)).ForeColor = Color.Red
        Next
        '=========================== 
        If tbx_index.Count > 0 Then
            If zero_occured Then
                WhenInvalid2()
            End If
            WhenInvalid()
        Else
            History.clear_trigger = False
            ActivateButtons()
            WhenValid()
            coefficient_list_main = AddinputsToList(TextBox_A.Text, TextBox_B.Text, TextBox_C.Text)
            DoCalculation()
        End If
    End Sub


    Public Sub SaveResults()
        'formatting the input values into a quadratic equation
        Dim temp As List(Of String) = New List(Of String)
        temp.Clear()
        For tbx_items = 1 To tbx_list.Count - 1
            If tbx_list(tbx_items).Text >= 0 Then 'if number is positive add plus sign
                temp.Add(String.Format("+ {0}", tbx_list(tbx_items).Text))
            ElseIf tbx_list(tbx_items).Text Then 'if number is negative add minus sign
                temp.Add(String.Format("- {0}", tbx_list(tbx_items).Text * -1))
            End If
        Next
        'saving current calculation 
        inserted_equation = String.Format("Equation: {0}x^2 {1}x {2}", TextBox_A.Text, temp(0), temp(1))
        saved_text = String.Format("Equation: {0}x^2 {1}x {2}" & vbNewLine _
            & "x1 = {3} | x2 = {4}", TextBox_A.Text, temp(0), temp(1), TextBox_x1.Text, TextBox_x2.Text)
        CalculationLogger(saved_text)
    End Sub

    Public Sub DoCalculation()
        Dim general_computation As New GeneralComputations
        general_computation.GetABCD(coefficient_list_main)
        general_computation.ExecuteComputations()

        Dim method_computation As New MethodComputations()
        method_computation.GetXYZ(general_computation.ReturnXYZList())
        method_computation.GetMethodUse(general_computation.ReturnMethodUse())
        method_computation.ExecuteComputations()

        TextBox_x1.Text = method_computation.ReturnRoots()(0)
        TextBox_x2.Text = method_computation.ReturnRoots()(1)

        SaveResults()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculationLogger()
        ClearOutput()
        DeactivateButtons()
        AcceptButton = Button_calculate
    End Sub

    Private Sub TextBox_A_TextChanged(sender As Object, e As EventArgs) Handles TextBox_A.TextChanged
        TextBox_A.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub TextBox_B_TextChanged(sender As Object, e As EventArgs) Handles TextBox_B.TextChanged
        TextBox_B.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub TextBox_C_TextChanged(sender As Object, e As EventArgs) Handles TextBox_C.TextChanged
        TextBox_C.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to exit now?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteLogFile()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        decimal_precision = 9
        Label1_method.Text = "----"
        ClearCombos()
        ClearInput()
        ClearOutput()
    End Sub

    Private Sub Button_show_solution_Click(sender As Object, e As EventArgs) Handles Button_show_solution.Click
        HistoryToggle()
    End Sub

    Private Sub TextBox_x1_MouseHover(sender As Object, e As EventArgs) Handles TextBox_x1.MouseHover
        ToolTip1.SetToolTip(TextBox_x1, String.Format("x1 = {0}", TextBox_x1.Text))
    End Sub

    Private Sub TextBox_x2_MouseHover(sender As Object, e As EventArgs) Handles TextBox_x2.MouseHover
        ToolTip1.SetToolTip(TextBox_x2, String.Format("x2 = {0}", TextBox_x2.Text))
    End Sub

    Private Sub Label1_method_MouseHover(sender As Object, e As EventArgs) Handles Label1_method.MouseHover
        If program_started Then
            ToolTip1.SetToolTip(Label1_method, String.Format("{0} for {1}", tool_tip_method_description, inserted_equation))
        Else
            ToolTip1.SetToolTip(Label1_method, "Shows inputed equation attribute.")
        End If
    End Sub

    Private Sub Button_copy_MouseLeave(sender As Object, e As EventArgs) Handles Button_copy.MouseLeave
        Button_copy.BackColor = Color.White
    End Sub

    Private Sub Button_copy_MouseHover(sender As Object, e As EventArgs) Handles Button_copy.MouseHover
        Button_copy.BackColor = Color.Magenta
    End Sub

    Private Sub Button_save_MouseHover(sender As Object, e As EventArgs) Handles Button_save.MouseHover
        Button_save.BackColor = Color.Magenta
    End Sub

    Private Sub Button_save_MouseLeave(sender As Object, e As EventArgs) Handles Button_save.MouseLeave
        Button_save.BackColor = Color.White
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Upto 3 decimal place" Then
            decimal_precision = 3
        ElseIf ComboBox1.Text = "Upto 4 decimal place" Then
            decimal_precision = 4
        Else
            decimal_precision = 9
        End If

        If program_started And ComboBox1.Text <> prev Then
            computed_from_combox = True
            DoCalculation()
        End If
        prev = ComboBox1.Text
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            Dim extension_name As String = ""
            Dim complete_fname As String = ""
            SaveFileDialog1.Filter = "Text File|*.txt|Rich Text Format|*.rtf|Word Document|*.docx"
            SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            SaveFileDialog1.FileName = "quadratic_computation"

            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
                Status_Action.Text = "Actions: Saving Cancelled."
            Else
                complete_fname = System.IO.Path.GetFileName(SaveFileDialog1.FileName)
                extension_name = System.IO.Path.GetExtension(SaveFileDialog1.FileName)

                If extension_name = ".docx" Then
                    'save as a word document to make this work add reference named
                    'Microsoft word object library And Microsoft office object library
                    Dim word_application As Microsoft.Office.Interop.Word.Application 'create your application
                    Dim word_document As Microsoft.Office.Interop.Word.Document 'create your document
                    Dim word_paragraph As Microsoft.Office.Interop.Word.Paragraph 'create the paragraph container

                    word_application = CreateObject("Word.Application") 'create a reference object
                    word_application.Visible = False 'if true the word application starts up and open if you dont quit the application at the end

                    word_document = word_application.Documents.Add 'adding the document
                    word_paragraph = word_document.Content.Paragraphs.Add 'adding paragraph to the document

                    word_paragraph.Range.Text = saved_text 'getting what the paragaraph contains
                    word_document.SaveAs2(SaveFileDialog1.FileName) 'saving the file 
                    word_application.Quit() 'closing the application
                Else
                    System.IO.File.WriteAllText(SaveFileDialog1.FileName, saved_text)
                End If
                Status_Action.Text = String.Format("Actions: The File Has Been Saved. Location: {0}", SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "All roots are Real" Then
            TextBox_A.Text = 2
            TextBox_B.Text = -4
            TextBox_C.Text = -22
        ElseIf ComboBox2.Text = "All roots are Imaginary" Then
            TextBox_A.Text = 1
            TextBox_B.Text = 2
            TextBox_C.Text = 3
        End If
    End Sub

    Private Sub StatusStrip1_method_MouseHover(sender As Object, e As EventArgs) Handles StatusStrip1_method.MouseHover
        ToolTip1.SetToolTip(StatusStrip1_method, Status_Action.Text)
    End Sub

    Private Sub Button_show_solution_MouseHover(sender As Object, e As EventArgs) Handles Button_show_solution.MouseHover
        If Button_show_solution.Text = "Close History" Then
            ToolTip1.SetToolTip(Button_show_solution, "Close History.")
        Else
            ToolTip1.SetToolTip(Button_show_solution, "Show previous calculations.")
        End If
    End Sub
End Class
