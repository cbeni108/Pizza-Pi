<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdiameterofpizza = New System.Windows.Forms.TextBox()
        Me.btnCalculateNoofslices = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diameter of Pizza:"
        '
        'txtdiameterofpizza
        '
        Me.txtdiameterofpizza.Location = New System.Drawing.Point(188, 57)
        Me.txtdiameterofpizza.Multiline = True
        Me.txtdiameterofpizza.Name = "txtdiameterofpizza"
        Me.txtdiameterofpizza.Size = New System.Drawing.Size(140, 25)
        Me.txtdiameterofpizza.TabIndex = 1
        '
        'btnCalculateNoofslices
        '
        Me.btnCalculateNoofslices.Location = New System.Drawing.Point(17, 257)
        Me.btnCalculateNoofslices.Name = "btnCalculateNoofslices"
        Me.btnCalculateNoofslices.Size = New System.Drawing.Size(156, 38)
        Me.btnCalculateNoofslices.TabIndex = 2
        Me.btnCalculateNoofslices.Text = "Calculate No. of slices"
        Me.btnCalculateNoofslices.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(253, 257)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(488, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateNoofslices)
        Me.Controls.Add(Me.txtdiameterofpizza)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pizza Pi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdiameterofpizza As TextBox
    Friend WithEvents btnCalculateNoofslices As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
