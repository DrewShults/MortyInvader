<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormName
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
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Shot = New System.Windows.Forms.PictureBox()
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.Color.Transparent
        Me.Shot.Image = Global.MortyInvader.My.Resources.Resources.redLaser
        Me.Shot.Location = New System.Drawing.Point(433, 285)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(19, 64)
        Me.Shot.TabIndex = 1
        Me.Shot.TabStop = False
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.Transparent
        Me.Shooter.Image = Global.MortyInvader.My.Resources.Resources.TransparentSpace
        Me.Shooter.Location = New System.Drawing.Point(409, 355)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(76, 60)
        Me.Shooter.TabIndex = 0
        Me.Shooter.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.MortyInvader.My.Resources.Resources.Scaryterry
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(151, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 423)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(195, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "QUIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(51, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(612, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormName"
        Me.Text = "Morty Invaders"
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Shooter As PictureBox
    Friend WithEvents TimerMain As Timer
    Friend WithEvents Shot As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
