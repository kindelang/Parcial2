<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problema3
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
        Me.lblProgramador = New System.Windows.Forms.Label()
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.lblNumero3 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.grbResultados = New System.Windows.Forms.GroupBox()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.lblMenor = New System.Windows.Forms.Label()
        Me.lblMayorS = New System.Windows.Forms.Label()
        Me.lblMenorS = New System.Windows.Forms.Label()
        Me.lblMayorC = New System.Windows.Forms.Label()
        Me.lblMenorC = New System.Windows.Forms.Label()
        Me.lblRMayor = New System.Windows.Forms.Label()
        Me.lblRMenor = New System.Windows.Forms.Label()
        Me.lblRMayorS = New System.Windows.Forms.Label()
        Me.lblRMenorS = New System.Windows.Forms.Label()
        Me.lblRMayorC = New System.Windows.Forms.Label()
        Me.lblRMenorC = New System.Windows.Forms.Label()
        Me.grbResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProgramador
        '
        Me.lblProgramador.AutoSize = True
        Me.lblProgramador.Location = New System.Drawing.Point(482, 410)
        Me.lblProgramador.Name = "lblProgramador"
        Me.lblProgramador.Size = New System.Drawing.Size(173, 13)
        Me.lblProgramador.TabIndex = 0
        Me.lblProgramador.Text = "Programado por Kindelan Gonzalez"
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(81, 127)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(122, 13)
        Me.lblNumero1.TabIndex = 1
        Me.lblNumero1.Text = "Ingrese el primer numero"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(81, 169)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(135, 13)
        Me.lblNumero2.TabIndex = 2
        Me.lblNumero2.Text = "Ingrese el segundo numero"
        '
        'lblNumero3
        '
        Me.lblNumero3.AutoSize = True
        Me.lblNumero3.Location = New System.Drawing.Point(81, 216)
        Me.lblNumero3.Name = "lblNumero3"
        Me.lblNumero3.Size = New System.Drawing.Size(121, 13)
        Me.lblNumero3.TabIndex = 3
        Me.lblNumero3.Text = "Ingrese el tercer numero"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(67, 13)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Problema #3"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(386, 124)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(100, 20)
        Me.txtN1.TabIndex = 5
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(386, 166)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(100, 20)
        Me.txtN2.TabIndex = 6
        '
        'txtN3
        '
        Me.txtN3.Location = New System.Drawing.Point(386, 213)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(100, 20)
        Me.txtN3.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 21)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(239, 284)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(75, 23)
        Me.btnComparar.TabIndex = 9
        Me.btnComparar.Text = "Comparar"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(713, 50)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 10
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'grbResultados
        '
        Me.grbResultados.Controls.Add(Me.lblRMenorC)
        Me.grbResultados.Controls.Add(Me.lblRMayorC)
        Me.grbResultados.Controls.Add(Me.lblRMenorS)
        Me.grbResultados.Controls.Add(Me.lblRMayorS)
        Me.grbResultados.Controls.Add(Me.lblRMenor)
        Me.grbResultados.Controls.Add(Me.lblRMayor)
        Me.grbResultados.Controls.Add(Me.lblMenorC)
        Me.grbResultados.Controls.Add(Me.lblMayorC)
        Me.grbResultados.Controls.Add(Me.lblMenorS)
        Me.grbResultados.Controls.Add(Me.lblMayorS)
        Me.grbResultados.Controls.Add(Me.lblMenor)
        Me.grbResultados.Controls.Add(Me.lblMayor)
        Me.grbResultados.Location = New System.Drawing.Point(588, 124)
        Me.grbResultados.Name = "grbResultados"
        Me.grbResultados.Size = New System.Drawing.Size(200, 254)
        Me.grbResultados.TabIndex = 11
        Me.grbResultados.TabStop = False
        Me.grbResultados.Text = "Reultados"
        '
        'lblMayor
        '
        Me.lblMayor.AutoSize = True
        Me.lblMayor.Location = New System.Drawing.Point(24, 30)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(36, 13)
        Me.lblMayor.TabIndex = 0
        Me.lblMayor.Text = "Mayor"
        '
        'lblMenor
        '
        Me.lblMenor.AutoSize = True
        Me.lblMenor.Location = New System.Drawing.Point(24, 58)
        Me.lblMenor.Name = "lblMenor"
        Me.lblMenor.Size = New System.Drawing.Size(37, 13)
        Me.lblMenor.TabIndex = 1
        Me.lblMenor.Text = "Menor"
        '
        'lblMayorS
        '
        Me.lblMayorS.AutoSize = True
        Me.lblMayorS.Location = New System.Drawing.Point(24, 89)
        Me.lblMayorS.Name = "lblMayorS"
        Me.lblMayorS.Size = New System.Drawing.Size(84, 13)
        Me.lblMayorS.TabIndex = 2
        Me.lblMayorS.Text = "Mayor sumatoria"
        '
        'lblMenorS
        '
        Me.lblMenorS.AutoSize = True
        Me.lblMenorS.Location = New System.Drawing.Point(24, 116)
        Me.lblMenorS.Name = "lblMenorS"
        Me.lblMenorS.Size = New System.Drawing.Size(85, 13)
        Me.lblMenorS.TabIndex = 3
        Me.lblMenorS.Text = "Menor sumatoria"
        '
        'lblMayorC
        '
        Me.lblMayorC.AutoSize = True
        Me.lblMayorC.Location = New System.Drawing.Point(24, 147)
        Me.lblMayorC.Name = "lblMayorC"
        Me.lblMayorC.Size = New System.Drawing.Size(91, 13)
        Me.lblMayorC.TabIndex = 4
        Me.lblMayorC.Text = "Mayores cantidad"
        '
        'lblMenorC
        '
        Me.lblMenorC.AutoSize = True
        Me.lblMenorC.Location = New System.Drawing.Point(24, 179)
        Me.lblMenorC.Name = "lblMenorC"
        Me.lblMenorC.Size = New System.Drawing.Size(92, 13)
        Me.lblMenorC.TabIndex = 5
        Me.lblMenorC.Text = "Menores cantidad"
        '
        'lblRMayor
        '
        Me.lblRMayor.AutoSize = True
        Me.lblRMayor.Location = New System.Drawing.Point(164, 30)
        Me.lblRMayor.Name = "lblRMayor"
        Me.lblRMayor.Size = New System.Drawing.Size(16, 13)
        Me.lblRMayor.TabIndex = 6
        Me.lblRMayor.Text = "---"
        '
        'lblRMenor
        '
        Me.lblRMenor.AutoSize = True
        Me.lblRMenor.Location = New System.Drawing.Point(164, 58)
        Me.lblRMenor.Name = "lblRMenor"
        Me.lblRMenor.Size = New System.Drawing.Size(16, 13)
        Me.lblRMenor.TabIndex = 7
        Me.lblRMenor.Text = "---"
        '
        'lblRMayorS
        '
        Me.lblRMayorS.AutoSize = True
        Me.lblRMayorS.Location = New System.Drawing.Point(164, 89)
        Me.lblRMayorS.Name = "lblRMayorS"
        Me.lblRMayorS.Size = New System.Drawing.Size(16, 13)
        Me.lblRMayorS.TabIndex = 8
        Me.lblRMayorS.Text = "---"
        '
        'lblRMenorS
        '
        Me.lblRMenorS.AutoSize = True
        Me.lblRMenorS.Location = New System.Drawing.Point(164, 116)
        Me.lblRMenorS.Name = "lblRMenorS"
        Me.lblRMenorS.Size = New System.Drawing.Size(16, 13)
        Me.lblRMenorS.TabIndex = 9
        Me.lblRMenorS.Text = "---"
        '
        'lblRMayorC
        '
        Me.lblRMayorC.AutoSize = True
        Me.lblRMayorC.Location = New System.Drawing.Point(164, 147)
        Me.lblRMayorC.Name = "lblRMayorC"
        Me.lblRMayorC.Size = New System.Drawing.Size(16, 13)
        Me.lblRMayorC.TabIndex = 10
        Me.lblRMayorC.Text = "---"
        '
        'lblRMenorC
        '
        Me.lblRMenorC.AutoSize = True
        Me.lblRMenorC.Location = New System.Drawing.Point(164, 179)
        Me.lblRMenorC.Name = "lblRMenorC"
        Me.lblRMenorC.Size = New System.Drawing.Size(16, 13)
        Me.lblRMenorC.TabIndex = 11
        Me.lblRMenorC.Text = "---"
        '
        'problema3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbResultados)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblNumero3)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.lblNumero1)
        Me.Controls.Add(Me.lblProgramador)
        Me.Name = "problema3"
        Me.Text = "problema3"
        Me.grbResultados.ResumeLayout(False)
        Me.grbResultados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgramador As Label
    Friend WithEvents lblNumero1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents lblNumero3 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents txtN3 As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnComparar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents grbResultados As GroupBox
    Friend WithEvents lblMenorC As Label
    Friend WithEvents lblMayorC As Label
    Friend WithEvents lblMenorS As Label
    Friend WithEvents lblMayorS As Label
    Friend WithEvents lblMenor As Label
    Friend WithEvents lblMayor As Label
    Friend WithEvents lblRMenorC As Label
    Friend WithEvents lblRMayorC As Label
    Friend WithEvents lblRMenorS As Label
    Friend WithEvents lblRMayorS As Label
    Friend WithEvents lblRMenor As Label
    Friend WithEvents lblRMayor As Label
End Class
