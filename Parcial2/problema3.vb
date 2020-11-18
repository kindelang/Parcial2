Public Class problema3

    Dim A As Integer = 0
    Dim B As Integer = 0
    Dim C As Integer = 0
    Dim Mayor As Integer = 0
    Dim Menor As Integer = 0
    Dim MayorSuma As Integer = 0
    Dim MenorSuma As Integer = 0
    Dim MayorCantidad As Integer = 0
    Dim MenorCantidad As Integer = 0


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub problema3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyFont As New Font(lblTitulo.Font.FontFamily, 25)
        lblTitulo.Font = MyFont

        Dim MyFont2 As New Font(lblNumero1.Font.FontFamily, 12)

        lblNumero1.Font = MyFont2

        lblNumero2.Font = MyFont2

        lblNumero3.Font = MyFont2

        lblProgramador.Font = MyFont2

        grbResultados.Font = MyFont2

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click

        If txtN1.Text = "" Or txtN2.Text = "" Or txtN3.Text = "" Then
            MsgBox("Faltan datos")

        Else
            Dim A As Integer = Integer.Parse(txtN1.Text)
            Dim B As Integer = Integer.Parse(txtN2.Text)
            Dim C As Integer = Integer.Parse(txtN3.Text)

            If A > B And A > C Then
                'Escribir "el mayor es:", A'
                Mayor = A
                lblRMayor.Text = Mayor
                MayorSuma = MayorSuma + Mayor
                lblRMayorS.Text = MayorSuma
                MayorCantidad = MayorCantidad + 1
                lblRMayorC.Text = MayorCantidad

            Else
                If B > A And B > C Then
                    'Escribir "el mayor es:", B'
                    Mayor = B
                    lblRMayor.Text = Mayor
                    MayorSuma = MayorSuma + Mayor
                    lblRMayorS.Text = MayorSuma
                    MayorCantidad = MayorCantidad + 1
                    lblRMayorC.Text = MayorCantidad
                Else
                    If C > A And C > B Then
                        'Escribir "el mayor es:", C'
                        Mayor = C
                        lblRMayor.Text = Mayor
                        MayorSuma = MayorSuma + Mayor
                        lblRMayorS.Text = MayorSuma
                        MayorCantidad = MayorCantidad + 1
                        lblRMayorC.Text = MayorCantidad
                    Else
                        'Escribir "son iguales";'
                        'MsgBox("Los numero son iguales.")'
                        If A = B And A = C Then
                            MsgBox("Los numero son iguales.")
                        Else
                            If A = C Or C = A Then
                                Mayor = A
                                lblRMayor.Text = Mayor
                                MayorSuma = MayorSuma + (Mayor + Mayor)
                                lblRMayorS.Text = MayorSuma
                                MayorCantidad = MayorCantidad + 2
                                lblRMayorC.Text = MayorCantidad
                            Else
                                If A = B Then
                                    Mayor = A
                                    lblRMayor.Text = Mayor
                                    MayorSuma = MayorSuma + (Mayor + Mayor)
                                    lblRMayorS.Text = MayorSuma
                                    MayorCantidad = MayorCantidad + 2
                                    lblRMayorC.Text = MayorCantidad
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            'Sumatorias'


            If A < B And A < C Then
                'Escribir "el menor es:", A'
                Menor = A
                lblRMenor.Text = Menor
                MenorSuma = MenorSuma + Menor
                lblRMenorS.Text = MenorSuma
            Else
                If B < A And B < C Then
                    'Escribir "el menor es:", B'
                    Menor = B
                    lblRMenor.Text = Menor
                    MenorSuma = MenorSuma + Menor
                    lblRMenorS.Text = MenorSuma
                Else
                    If C < A And C < B Then
                        'Escribir "el menor es:", C'
                        Menor = C
                        lblRMenor.Text = Menor
                        MenorSuma = MenorSuma + Menor
                        lblRMenorS.Text = MenorSuma
                    Else

                        'Escribir "Son iguales";'

                    End If
                End If
            End If

        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grbResultados.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblMenorC.Click

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles lblRMayorC.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblRMayor.Click

    End Sub
End Class