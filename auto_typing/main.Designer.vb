<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Tbhunt = New System.Windows.Forms.TextBox()
        Me.BtnStart_hunt = New System.Windows.Forms.Button()
        Me.TbhuntIn = New System.Windows.Forms.TextBox()
        Me.BtnStop_hunt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer_hunt = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnStop_axe = New System.Windows.Forms.Button()
        Me.TbAxe_In = New System.Windows.Forms.TextBox()
        Me.BtnStart_axe = New System.Windows.Forms.Button()
        Me.tbAxe = New System.Windows.Forms.TextBox()
        Me.BtnStop_All = New System.Windows.Forms.Button()
        Me.BtnStart_All = New System.Windows.Forms.Button()
        Me.label_title = New System.Windows.Forms.Label()
        Me.Timer_Axe = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Tbhunt
        '
        Me.Tbhunt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbhunt.Location = New System.Drawing.Point(12, 94)
        Me.Tbhunt.Name = "Tbhunt"
        Me.Tbhunt.Size = New System.Drawing.Size(179, 20)
        Me.Tbhunt.TabIndex = 0
        '
        'BtnStart_hunt
        '
        Me.BtnStart_hunt.Location = New System.Drawing.Point(12, 166)
        Me.BtnStart_hunt.Name = "BtnStart_hunt"
        Me.BtnStart_hunt.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart_hunt.TabIndex = 1
        Me.BtnStart_hunt.Text = "Start"
        Me.BtnStart_hunt.UseVisualStyleBackColor = True
        '
        'TbhuntIn
        '
        Me.TbhuntIn.Location = New System.Drawing.Point(70, 131)
        Me.TbhuntIn.Name = "TbhuntIn"
        Me.TbhuntIn.Size = New System.Drawing.Size(121, 20)
        Me.TbhuntIn.TabIndex = 2
        '
        'BtnStop_hunt
        '
        Me.BtnStop_hunt.Location = New System.Drawing.Point(116, 166)
        Me.BtnStop_hunt.Name = "BtnStop_hunt"
        Me.BtnStop_hunt.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop_hunt.TabIndex = 3
        Me.BtnStop_hunt.Text = "Stop"
        Me.BtnStop_hunt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input Text :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Interval (S)"
        '
        'Timer_hunt
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Interval (S)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Input Text :"
        '
        'BtnStop_axe
        '
        Me.BtnStop_axe.Location = New System.Drawing.Point(349, 166)
        Me.BtnStop_axe.Name = "BtnStop_axe"
        Me.BtnStop_axe.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop_axe.TabIndex = 10
        Me.BtnStop_axe.Text = "Stop"
        Me.BtnStop_axe.UseVisualStyleBackColor = True
        '
        'TbAxe_In
        '
        Me.TbAxe_In.Location = New System.Drawing.Point(303, 131)
        Me.TbAxe_In.Name = "TbAxe_In"
        Me.TbAxe_In.Size = New System.Drawing.Size(121, 20)
        Me.TbAxe_In.TabIndex = 9
        '
        'BtnStart_axe
        '
        Me.BtnStart_axe.Location = New System.Drawing.Point(245, 166)
        Me.BtnStart_axe.Name = "BtnStart_axe"
        Me.BtnStart_axe.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart_axe.TabIndex = 8
        Me.BtnStart_axe.Text = "Start"
        Me.BtnStart_axe.UseVisualStyleBackColor = True
        '
        'tbAxe
        '
        Me.tbAxe.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAxe.Location = New System.Drawing.Point(245, 94)
        Me.tbAxe.Name = "tbAxe"
        Me.tbAxe.Size = New System.Drawing.Size(179, 20)
        Me.tbAxe.TabIndex = 7
        '
        'BtnStop_All
        '
        Me.BtnStop_All.Location = New System.Drawing.Point(245, 250)
        Me.BtnStop_All.Name = "BtnStop_All"
        Me.BtnStop_All.Size = New System.Drawing.Size(97, 42)
        Me.BtnStop_All.TabIndex = 26
        Me.BtnStop_All.Text = "Stop All"
        Me.BtnStop_All.UseVisualStyleBackColor = True
        '
        'BtnStart_All
        '
        Me.BtnStart_All.Location = New System.Drawing.Point(94, 250)
        Me.BtnStart_All.Name = "BtnStart_All"
        Me.BtnStart_All.Size = New System.Drawing.Size(97, 42)
        Me.BtnStart_All.TabIndex = 25
        Me.BtnStart_All.Text = "Start All"
        Me.BtnStart_All.UseVisualStyleBackColor = True
        '
        'label_title
        '
        Me.label_title.AutoSize = True
        Me.label_title.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.Location = New System.Drawing.Point(169, 22)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(101, 23)
        Me.label_title.TabIndex = 27
        Me.label_title.Text = "Auto Typing"
        '
        'Timer_Axe
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 332)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.BtnStop_All)
        Me.Controls.Add(Me.BtnStart_All)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnStop_axe)
        Me.Controls.Add(Me.TbAxe_In)
        Me.Controls.Add(Me.BtnStart_axe)
        Me.Controls.Add(Me.tbAxe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStop_hunt)
        Me.Controls.Add(Me.TbhuntIn)
        Me.Controls.Add(Me.BtnStart_hunt)
        Me.Controls.Add(Me.Tbhunt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "Auto Typing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbhunt As TextBox
    Friend WithEvents BtnStart_hunt As Button
    Friend WithEvents TbhuntIn As TextBox
    Friend WithEvents BtnStop_hunt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer_hunt As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnStop_axe As Button
    Friend WithEvents TbAxe_In As TextBox
    Friend WithEvents BtnStart_axe As Button
    Friend WithEvents tbAxe As TextBox
    Friend WithEvents BtnStop_All As Button
    Friend WithEvents BtnStart_All As Button
    Friend WithEvents label_title As Label
    Friend WithEvents Timer_Axe As Timer
End Class
