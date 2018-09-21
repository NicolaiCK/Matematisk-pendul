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
        Me.components = New System.ComponentModel.Container()
        Me.btnStartExact = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStartEuler = New System.Windows.Forms.Button()
        Me.txtTidsInverval = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpSnor = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.shpLod = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TimerExact = New System.Windows.Forms.Timer(Me.components)
        Me.TimerEuler = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Vægt = New System.Windows.Forms.Label()
        Me.txtVægt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStartExact
        '
        Me.btnStartExact.Location = New System.Drawing.Point(22, 25)
        Me.btnStartExact.Name = "btnStartExact"
        Me.btnStartExact.Size = New System.Drawing.Size(104, 40)
        Me.btnStartExact.TabIndex = 0
        Me.btnStartExact.Text = "Start Exact"
        Me.btnStartExact.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(22, 117)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(104, 40)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStartEuler
        '
        Me.btnStartEuler.Location = New System.Drawing.Point(22, 71)
        Me.btnStartEuler.Name = "btnStartEuler"
        Me.btnStartEuler.Size = New System.Drawing.Size(104, 40)
        Me.btnStartEuler.TabIndex = 2
        Me.btnStartEuler.Text = "Start Euler"
        Me.btnStartEuler.UseVisualStyleBackColor = True
        '
        'txtTidsInverval
        '
        Me.txtTidsInverval.Location = New System.Drawing.Point(363, 43)
        Me.txtTidsInverval.Name = "txtTidsInverval"
        Me.txtTidsInverval.Size = New System.Drawing.Size(100, 22)
        Me.txtTidsInverval.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpSnor, Me.shpLod})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'shpSnor
        '
        Me.shpSnor.Name = "shpSnor"
        Me.shpSnor.X1 = 262
        Me.shpSnor.X2 = 337
        Me.shpSnor.Y1 = 216
        Me.shpSnor.Y2 = 239
        '
        'shpLod
        '
        Me.shpLod.Location = New System.Drawing.Point(432, 185)
        Me.shpLod.Name = "shpLod"
        Me.shpLod.Size = New System.Drawing.Size(50, 50)
        '
        'TimerExact
        '
        '
        'TimerEuler
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Vægt
        '
        Me.Vægt.AutoSize = True
        Me.Vægt.Location = New System.Drawing.Point(19, 239)
        Me.Vægt.Name = "Vægt"
        Me.Vægt.Size = New System.Drawing.Size(81, 17)
        Me.Vægt.TabIndex = 8
        Me.Vægt.Text = "Vægt af lod"
        '
        'txtVægt
        '
        Me.txtVægt.AcceptsReturn = True
        Me.txtVægt.Location = New System.Drawing.Point(129, 275)
        Me.txtVægt.Name = "txtVægt"
        Me.txtVægt.Size = New System.Drawing.Size(100, 22)
        Me.txtVægt.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtVægt)
        Me.Controls.Add(Me.Vægt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTidsInverval)
        Me.Controls.Add(Me.btnStartEuler)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStartExact)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartExact As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStartEuler As Button
    Friend WithEvents txtTidsInverval As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents shpLod As PowerPacks.OvalShape
    Friend WithEvents shpSnor As PowerPacks.LineShape
    Friend WithEvents TimerExact As Timer
    Friend WithEvents TimerEuler As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Vægt As Label
    Friend WithEvents txtVægt As TextBox
End Class
