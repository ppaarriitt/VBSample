<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlab1
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.bntcalculate = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Red
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(40, 68)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "เงินเดือน "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายได้ทั้งปี"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ภาษีที่ต้องชำระ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เงินได้คงเหลือหลังหักภาษา"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(178, 71)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(105, 20)
        Me.txtSalary.TabIndex = 1
        '
        'bntcalculate
        '
        Me.bntcalculate.BackColor = System.Drawing.Color.Black
        Me.bntcalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntcalculate.ForeColor = System.Drawing.Color.Red
        Me.bntcalculate.Location = New System.Drawing.Point(178, 275)
        Me.bntcalculate.Name = "bntcalculate"
        Me.bntcalculate.Size = New System.Drawing.Size(116, 61)
        Me.bntcalculate.TabIndex = 2
        Me.bntcalculate.Text = "คำนวน"
        Me.bntcalculate.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Red
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(178, 120)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(105, 23)
        Me.lbl1.TabIndex = 0
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Red
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(178, 174)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(105, 23)
        Me.lbl2.TabIndex = 0
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Red
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(178, 223)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(105, 23)
        Me.lbl3.TabIndex = 0
        Me.lbl3.Text = "รายได้ทั้งปี"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "โปรแกรมคำนวนรายได้"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(44, 274)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(112, 59)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "ปิด"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmlab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 377)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.bntcalculate)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.ForeColor = System.Drawing.Color.Chocolate
        Me.Name = "frmlab1"
        Me.Text = "IncomeCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents bntcalculate As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button

End Class
