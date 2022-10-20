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
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEdad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CALCULAR
        '
        Me.CALCULAR.BackColor = System.Drawing.Color.Transparent
        Me.CALCULAR.ForeColor = System.Drawing.Color.Black
        Me.CALCULAR.Location = New System.Drawing.Point(211, 197)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.CALCULAR.TabIndex = 0
        Me.CALCULAR.Text = "CALCULAR"
        Me.CALCULAR.UseVisualStyleBackColor = False
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Nombre.Location = New System.Drawing.Point(125, 67)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(51, 15)
        Me.Nombre.TabIndex = 1
        Me.Nombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(279, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(125, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Edad"
        '
        'TextEdad
        '
        Me.TextEdad.Location = New System.Drawing.Point(279, 124)
        Me.TextEdad.Name = "TextEdad"
        Me.TextEdad.Size = New System.Drawing.Size(100, 23)
        Me.TextEdad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(195, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "VOTACION"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(448, 231)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEdad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.CALCULAR)
        Me.Name = "Form1"
        Me.Text = "Edad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CALCULAR As Button
    Friend WithEvents Nombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextEdad As TextBox
    Friend WithEvents Label1 As Label
End Class
