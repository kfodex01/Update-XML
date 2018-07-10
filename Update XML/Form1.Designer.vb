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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbWorkbookPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSavePath = New System.Windows.Forms.TextBox()
        Me.btnCreateXml = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(13, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(175, 25)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Update Message"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Workbook Path"
        '
        'tbWorkbookPath
        '
        Me.tbWorkbookPath.Location = New System.Drawing.Point(18, 59)
        Me.tbWorkbookPath.Name = "tbWorkbookPath"
        Me.tbWorkbookPath.Size = New System.Drawing.Size(559, 20)
        Me.tbWorkbookPath.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "XML Output Directory"
        '
        'tbSavePath
        '
        Me.tbSavePath.Location = New System.Drawing.Point(18, 103)
        Me.tbSavePath.Name = "tbSavePath"
        Me.tbSavePath.Size = New System.Drawing.Size(559, 20)
        Me.tbSavePath.TabIndex = 4
        '
        'btnCreateXml
        '
        Me.btnCreateXml.Location = New System.Drawing.Point(584, 99)
        Me.btnCreateXml.Name = "btnCreateXml"
        Me.btnCreateXml.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateXml.TabIndex = 5
        Me.btnCreateXml.Text = "Create XML"
        Me.btnCreateXml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 139)
        Me.Controls.Add(Me.btnCreateXml)
        Me.Controls.Add(Me.tbSavePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbWorkbookPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Update XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbWorkbookPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSavePath As TextBox
    Friend WithEvents btnCreateXml As Button
End Class
