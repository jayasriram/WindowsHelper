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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClickThis = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.btnORT = New System.Windows.Forms.Button()
        Me.btnSSLLabs = New System.Windows.Forms.Button()
        Me.btnPostman = New System.Windows.Forms.Button()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lvlMyPC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClickThis
        '
        Me.btnClickThis.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClickThis.Location = New System.Drawing.Point(92, 25)
        Me.btnClickThis.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClickThis.Name = "btnClickThis"
        Me.btnClickThis.Size = New System.Drawing.Size(75, 23)
        Me.btnClickThis.TabIndex = 0
        Me.btnClickThis.Text = "Google"
        Me.btnClickThis.UseVisualStyleBackColor = False
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Location = New System.Drawing.Point(99, 190)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(39, 13)
        Me.lblHelloWorld.TabIndex = 1
        Me.lblHelloWorld.Text = "Label1"
        '
        'btnORT
        '
        Me.btnORT.BackColor = System.Drawing.Color.Black
        Me.btnORT.ForeColor = System.Drawing.Color.White
        Me.btnORT.Location = New System.Drawing.Point(3, 25)
        Me.btnORT.Name = "btnORT"
        Me.btnORT.Size = New System.Drawing.Size(75, 23)
        Me.btnORT.TabIndex = 2
        Me.btnORT.Text = "ORT"
        Me.btnORT.UseVisualStyleBackColor = False
        '
        'btnSSLLabs
        '
        Me.btnSSLLabs.BackColor = System.Drawing.Color.Black
        Me.btnSSLLabs.ForeColor = System.Drawing.Color.White
        Me.btnSSLLabs.Location = New System.Drawing.Point(92, 54)
        Me.btnSSLLabs.Name = "btnSSLLabs"
        Me.btnSSLLabs.Size = New System.Drawing.Size(75, 23)
        Me.btnSSLLabs.TabIndex = 3
        Me.btnSSLLabs.Text = "SSL Labs"
        Me.btnSSLLabs.UseVisualStyleBackColor = False
        '
        'btnPostman
        '
        Me.btnPostman.BackColor = System.Drawing.Color.Black
        Me.btnPostman.ForeColor = System.Drawing.Color.White
        Me.btnPostman.Location = New System.Drawing.Point(3, 54)
        Me.btnPostman.Name = "btnPostman"
        Me.btnPostman.Size = New System.Drawing.Size(75, 23)
        Me.btnPostman.TabIndex = 4
        Me.btnPostman.Text = "Postman"
        Me.btnPostman.UseVisualStyleBackColor = False
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.ForeColor = System.Drawing.Color.White
        Me.lblWeb.Location = New System.Drawing.Point(108, 9)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(30, 13)
        Me.lblWeb.TabIndex = 5
        Me.lblWeb.Text = "Web"
        '
        'lvlMyPC
        '
        Me.lvlMyPC.AutoSize = True
        Me.lvlMyPC.ForeColor = System.Drawing.Color.White
        Me.lvlMyPC.Location = New System.Drawing.Point(23, 9)
        Me.lvlMyPC.Name = "lvlMyPC"
        Me.lvlMyPC.Size = New System.Drawing.Size(38, 13)
        Me.lvlMyPC.TabIndex = 6
        Me.lvlMyPC.Text = "My PC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(188, 251)
        Me.Controls.Add(Me.lvlMyPC)
        Me.Controls.Add(Me.lblWeb)
        Me.Controls.Add(Me.btnPostman)
        Me.Controls.Add(Me.btnSSLLabs)
        Me.Controls.Add(Me.btnORT)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.btnClickThis)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Favs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickThis As Button
    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents btnORT As Button
    Friend WithEvents btnSSLLabs As Button
    Friend WithEvents btnPostman As Button
    Friend WithEvents lblWeb As Label
    Friend WithEvents lvlMyPC As Label
End Class
