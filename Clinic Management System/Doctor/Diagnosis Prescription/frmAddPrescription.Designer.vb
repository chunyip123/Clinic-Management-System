<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPrescription
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
        Me.cboMedicine = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.rbBeforeMeal = New System.Windows.Forms.RadioButton()
        Me.rbAfterMeal = New System.Windows.Forms.RadioButton()
        Me.rbBetweenMeal = New System.Windows.Forms.RadioButton()
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMedicine
        '
        Me.cboMedicine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboMedicine.FormattingEnabled = True
        Me.cboMedicine.Location = New System.Drawing.Point(220, 78)
        Me.cboMedicine.Name = "cboMedicine"
        Me.cboMedicine.Size = New System.Drawing.Size(352, 33)
        Me.cboMedicine.TabIndex = 31
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnClose.Location = New System.Drawing.Point(358, 518)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 50)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAdd.Location = New System.Drawing.Point(143, 518)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 50)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(75, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Remarks: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(96, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Taken: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(84, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Amount: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(73, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Medicine: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Prescription"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 49)
        Me.Panel1.TabIndex = 19
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAmount.Location = New System.Drawing.Point(220, 138)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(352, 30)
        Me.txtAmount.TabIndex = 32
        '
        'rbBeforeMeal
        '
        Me.rbBeforeMeal.AutoSize = True
        Me.rbBeforeMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rbBeforeMeal.Location = New System.Drawing.Point(220, 198)
        Me.rbBeforeMeal.Name = "rbBeforeMeal"
        Me.rbBeforeMeal.Size = New System.Drawing.Size(138, 29)
        Me.rbBeforeMeal.TabIndex = 33
        Me.rbBeforeMeal.TabStop = True
        Me.rbBeforeMeal.Text = "Before Meal"
        Me.rbBeforeMeal.UseVisualStyleBackColor = True
        '
        'rbAfterMeal
        '
        Me.rbAfterMeal.AutoSize = True
        Me.rbAfterMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rbAfterMeal.Location = New System.Drawing.Point(220, 237)
        Me.rbAfterMeal.Name = "rbAfterMeal"
        Me.rbAfterMeal.Size = New System.Drawing.Size(122, 29)
        Me.rbAfterMeal.TabIndex = 34
        Me.rbAfterMeal.TabStop = True
        Me.rbAfterMeal.Text = "After Meal"
        Me.rbAfterMeal.UseVisualStyleBackColor = True
        '
        'rbBetweenMeal
        '
        Me.rbBetweenMeal.AutoSize = True
        Me.rbBetweenMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rbBetweenMeal.Location = New System.Drawing.Point(220, 276)
        Me.rbBetweenMeal.Name = "rbBetweenMeal"
        Me.rbBetweenMeal.Size = New System.Drawing.Size(157, 29)
        Me.rbBetweenMeal.TabIndex = 35
        Me.rbBetweenMeal.TabStop = True
        Me.rbBetweenMeal.Text = "Between Meal"
        Me.rbBetweenMeal.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(220, 331)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(352, 146)
        Me.txtRemarks.TabIndex = 37
        Me.txtRemarks.Text = ""
        '
        'frmAddPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 618)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.rbBetweenMeal)
        Me.Controls.Add(Me.rbAfterMeal)
        Me.Controls.Add(Me.rbBeforeMeal)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cboMedicine)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddPrescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddPrescription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMedicine As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents rbBeforeMeal As RadioButton
    Friend WithEvents rbAfterMeal As RadioButton
    Friend WithEvents rbBetweenMeal As RadioButton
    Friend WithEvents txtRemarks As RichTextBox
End Class
