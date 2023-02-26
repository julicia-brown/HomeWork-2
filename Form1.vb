Public Class frmPayroll
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFICA.Clear()
        txtFedTax.Clear()
        txtStateTax.Clear()
        txtNetPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFICA.Clear()
        txtFedTax.Clear()
        txtStateTax.Clear()
        txtNetPay.Clear()
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnTaxes_Click(sender As Object, e As EventArgs) Handles btnTaxes.Click
        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        Dim strIncome As String
        strIncome = txtGrossPay.Text

        Dim decIncome As Decimal
        decIncome = Convert.ToDecimal(strIncome)

        Dim decFica As Decimal
        decFica = decIncome * cdecFica

        Dim decFederal As Decimal
        decFederal = decIncome * cdecFed

        Dim decState As Decimal
        decState = decIncome * cdecState

        Dim decNet As Decimal
        decNet = decIncome - (decFica + decState + decFederal)

        txtFICA.Text = decFica.ToString("C")
        txtFedTax.Text = decFederal.ToString("C")
        txtStateTax.Text = decState.ToString("C")
        txtNetPay.Text = decNet.ToString("C")

    End Sub
End Class
