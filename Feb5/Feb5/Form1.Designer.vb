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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ClickerControl5 = New Feb5.ClickerControl()
        Me.ClickerControl4 = New Feb5.ClickerControl()
        Me.ClickerControl3 = New Feb5.ClickerControl()
        Me.ClickerControl2 = New Feb5.ClickerControl()
        Me.ClickerControl1 = New Feb5.ClickerControl()
        Me.ClickerControl6 = New Feb5.ClickerControl()
        Me.SuspendLayout()
        '
        'ClickerControl5
        '
        Me.ClickerControl5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl5.Location = New System.Drawing.Point(8, 253)
        Me.ClickerControl5.Name = "ClickerControl5"
        Me.ClickerControl5.Size = New System.Drawing.Size(74, 101)
        Me.ClickerControl5.TabIndex = 16
        '
        'ClickerControl4
        '
        Me.ClickerControl4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl4.Location = New System.Drawing.Point(111, 133)
        Me.ClickerControl4.Name = "ClickerControl4"
        Me.ClickerControl4.Size = New System.Drawing.Size(74, 101)
        Me.ClickerControl4.TabIndex = 15
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl3.Location = New System.Drawing.Point(111, 12)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(74, 101)
        Me.ClickerControl3.TabIndex = 14
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl2.Location = New System.Drawing.Point(8, 133)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(74, 101)
        Me.ClickerControl2.TabIndex = 13
        '
        'ClickerControl1
        '
        Me.ClickerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl1.Location = New System.Drawing.Point(8, 12)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(74, 101)
        Me.ClickerControl1.TabIndex = 12
        '
        'ClickerControl6
        '
        Me.ClickerControl6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClickerControl6.Location = New System.Drawing.Point(111, 253)
        Me.ClickerControl6.Name = "ClickerControl6"
        Me.ClickerControl6.Size = New System.Drawing.Size(71, 96)
        Me.ClickerControl6.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 493)
        Me.Controls.Add(Me.ClickerControl6)
        Me.Controls.Add(Me.ClickerControl5)
        Me.Controls.Add(Me.ClickerControl4)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
    Friend WithEvents ClickerControl4 As ClickerControl
    Friend WithEvents ClickerControl5 As ClickerControl
    Friend WithEvents ClickerControl6 As ClickerControl
End Class
