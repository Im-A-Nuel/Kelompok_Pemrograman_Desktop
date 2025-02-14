<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pbPlay = New PictureBox()
        CType(pbPlay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbPlay
        ' 
        pbPlay.BackColor = Color.Transparent
        pbPlay.BackgroundImage = CType(resources.GetObject("pbPlay.BackgroundImage"), Image)
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.Location = New Point(4, -5)
        pbPlay.Margin = New Padding(2, 2, 2, 2)
        pbPlay.Name = "pbPlay"
        pbPlay.Size = New Size(546, 674)
        pbPlay.TabIndex = 0
        pbPlay.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(558, 662)
        Controls.Add(pbPlay)
        DoubleBuffered = True
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Wack a Mole!"
        CType(pbPlay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbPlay As PictureBox

End Class
