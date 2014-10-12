<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldMainWindow
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
      Me.HelloWorldLabel = New System.Windows.Forms.Label()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'HelloWorldLabel
      '
      Me.HelloWorldLabel.AutoSize = True
      Me.HelloWorldLabel.Font = New System.Drawing.Font("Century Schoolbook", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelloWorldLabel.Location = New System.Drawing.Point(1, 9)
      Me.HelloWorldLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
      Me.HelloWorldLabel.Name = "HelloWorldLabel"
      Me.HelloWorldLabel.Size = New System.Drawing.Size(328, 64)
      Me.HelloWorldLabel.TabIndex = 0
      Me.HelloWorldLabel.Text = "Hello World"
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(12, 76)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(298, 96)
      Me.Button1.TabIndex = 1
      Me.Button1.Text = "Hello"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'HelloWorldMainWindow
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(324, 188)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.HelloWorldLabel)
      Me.Name = "HelloWorldMainWindow"
      Me.Text = "Hello World Application"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents HelloWorldLabel As System.Windows.Forms.Label
   Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
