<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTaxes = New System.Windows.Forms.Button()
        Me.lblPayrollCalc = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblEnterGross = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.txtFICA = New System.Windows.Forms.TextBox()
        Me.txtFedTax = New System.Windows.Forms.TextBox()
        Me.txtStateTax = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 409)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnTaxes
        '
        Me.btnTaxes.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTaxes.Location = New System.Drawing.Point(151, 557)
        Me.btnTaxes.Name = "btnTaxes"
        Me.btnTaxes.Size = New System.Drawing.Size(231, 82)
        Me.btnTaxes.TabIndex = 1
        Me.btnTaxes.Text = "Compute Taxes"
        Me.btnTaxes.UseVisualStyleBackColor = False
        '
        'lblPayrollCalc
        '
        Me.lblPayrollCalc.AutoSize = True
        Me.lblPayrollCalc.Font = New System.Drawing.Font("Segoe Print", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollCalc.Location = New System.Drawing.Point(617, 69)
        Me.lblPayrollCalc.Name = "lblPayrollCalc"
        Me.lblPayrollCalc.Size = New System.Drawing.Size(525, 94)
        Me.lblPayrollCalc.TabIndex = 4
        Me.lblPayrollCalc.Text = "Payroll Calculator"
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe Print", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblInstruction.Location = New System.Drawing.Point(727, 218)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(269, 152)
        Me.lblInstruction.TabIndex = 5
        Me.lblInstruction.Text = "Paycheck " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnterGross
        '
        Me.lblEnterGross.AutoSize = True
        Me.lblEnterGross.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterGross.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblEnterGross.Location = New System.Drawing.Point(237, 454)
        Me.lblEnterGross.Name = "lblEnterGross"
        Me.lblEnterGross.Size = New System.Drawing.Size(391, 65)
        Me.lblEnterGross.TabIndex = 6
        Me.lblEnterGross.Text = "Enter Gross Pay:"
        Me.lblEnterGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(683, 454)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(235, 62)
        Me.txtGrossPay.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(496, 557)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(231, 82)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(829, 557)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(231, 82)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(160, 674)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(99, 45)
        Me.lblFica.TabIndex = 10
        Me.lblFica.Text = "FICA:"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.Location = New System.Drawing.Point(414, 674)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(202, 45)
        Me.lblFedTax.TabIndex = 11
        Me.lblFedTax.Text = "Federal Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(795, 674)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(168, 45)
        Me.lblStateTax.TabIndex = 12
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Ebrima", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblNetIncome.Location = New System.Drawing.Point(195, 779)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(471, 59)
        Me.lblNetIncome.TabIndex = 16
        Me.lblNetIncome.Text = "Net Paycheck Income:"
        Me.lblNetIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFICA
        '
        Me.txtFICA.BackColor = System.Drawing.SystemColors.Window
        Me.txtFICA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFICA.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFICA.Location = New System.Drawing.Point(265, 674)
        Me.txtFICA.Name = "txtFICA"
        Me.txtFICA.ReadOnly = True
        Me.txtFICA.Size = New System.Drawing.Size(117, 41)
        Me.txtFICA.TabIndex = 18
        Me.txtFICA.Text = "123"
        '
        'txtFedTax
        '
        Me.txtFedTax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFedTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFedTax.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFedTax.Location = New System.Drawing.Point(622, 674)
        Me.txtFedTax.Name = "txtFedTax"
        Me.txtFedTax.ReadOnly = True
        Me.txtFedTax.Size = New System.Drawing.Size(117, 41)
        Me.txtFedTax.TabIndex = 19
        Me.txtFedTax.Text = "456"
        '
        'txtStateTax
        '
        Me.txtStateTax.BackColor = System.Drawing.SystemColors.Window
        Me.txtStateTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStateTax.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateTax.Location = New System.Drawing.Point(969, 674)
        Me.txtStateTax.Name = "txtStateTax"
        Me.txtStateTax.ReadOnly = True
        Me.txtStateTax.Size = New System.Drawing.Size(109, 41)
        Me.txtStateTax.TabIndex = 20
        Me.txtStateTax.Text = "789"
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNetPay.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(692, 774)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(271, 62)
        Me.txtNetPay.TabIndex = 21
        Me.txtNetPay.Text = "$$$$"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1202, 886)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtStateTax)
        Me.Controls.Add(Me.txtFedTax)
        Me.Controls.Add(Me.txtFICA)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblEnterGross)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.lblPayrollCalc)
        Me.Controls.Add(Me.btnTaxes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTaxes As Button
    Friend WithEvents lblPayrollCalc As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblEnterGross As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents txtFICA As TextBox
    Friend WithEvents txtFedTax As TextBox
    Friend WithEvents txtStateTax As TextBox
    Friend WithEvents txtNetPay As TextBox
End Class
