<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MineWeeper_Board
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
        Me.pnlMineBoard = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlMineBoard
        '
        Me.pnlMineBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMineBoard.Location = New System.Drawing.Point(17, 5)
        Me.pnlMineBoard.Name = "pnlMineBoard"
        Me.pnlMineBoard.Size = New System.Drawing.Size(700, 700)
        Me.pnlMineBoard.TabIndex = 0
        '
        'MineWeeper_Board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 711)
        Me.Controls.Add(Me.pnlMineBoard)
        Me.Name = "MineWeeper_Board"
        Me.Text = "MineWeeper"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMineBoard As Panel
End Class
