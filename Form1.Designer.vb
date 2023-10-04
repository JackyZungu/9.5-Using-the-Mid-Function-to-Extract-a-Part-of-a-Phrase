<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbPhrase = New Label()
        lbExtract = New Label()
        btnShow = New Button()
        SuspendLayout()
        ' 
        ' lbPhrase
        ' 
        lbPhrase.AutoSize = True
        lbPhrase.Location = New Point(189, 52)
        lbPhrase.Name = "lbPhrase"
        lbPhrase.Size = New Size(0, 20)
        lbPhrase.TabIndex = 0
        ' 
        ' lbExtract
        ' 
        lbExtract.AutoSize = True
        lbExtract.Location = New Point(191, 117)
        lbExtract.Name = "lbExtract"
        lbExtract.Size = New Size(150, 20)
        lbExtract.TabIndex = 1
        lbExtract.Text = "Number of character "
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(276, 187)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(94, 47)
        btnShow.TabIndex = 2
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnShow)
        Controls.Add(lbExtract)
        Controls.Add(lbPhrase)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbPhrase As Label
    Friend WithEvents lbExtract As Label
    Friend WithEvents btnShow As Button
End Class
