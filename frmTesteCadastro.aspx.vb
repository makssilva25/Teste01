
Partial Class frmTesteCadastro
    Inherits System.Web.UI.Page
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Validacao.Outros(CPF_Mae, False, "CPF",, Validacao.eFormato.CPF)
        Validacao.Outros(CPF_Pai, False, "CPF",, Validacao.eFormato.CPF)
        JavaScript.ExibirConfirmacao(btnSalvar, eTipoConfirmacao.SALVAR)




    End Sub

#Region "Funções de Cadastro"
    Private Sub Salvar()
        Dim objDocumentos As New Documentos(ViewState("CodigoDocumentos"))
        With objDocumentos
            .NomeMae = txtNomeMae.Text
            .CpfMae = CPF_Mae.Text

            .NomePai = txtNomePai.Text
            .CpfPai = CPF_Pai.Text

            .TelefoneResponsavel = txtTelefoneResp.Text
            .RgAluno = txtRg.Text
            .EmissaoRgAluno = txtDataEmissaoRg.Text
            .NascAluno = nascAluno.Text





            .Salvar()

        End With
        objDocumentos = Nothing
    End Sub

#End Region

#Region "Eventos de Cadastro"





#End Region

#Region "Funções de Listagem"


#End Region

#Region "Eventos de Listagem"


#End Region

    Protected Sub lnkEditarAluno_Click(sender As Object, e As EventArgs)

    End Sub



    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
       

    End Sub

    Protected Sub grdAluno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdAluno.SelectedIndexChanged

    End Sub
End Class
