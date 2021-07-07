Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Text

Public Class Documentos
    Private CIO2_ID_DOCUMENTOS As Integer
    Private CI01_ID_ALUNO As Integer
    Private CI02_NM_MAE As String
    Private CI02_NU_CPF_MAE As String
    Private CI02_NM_PAI As String
    Private CI02_NU_CPF_PAI As String
    Private CI02_NU_TELEFONE_RESPONSAVEL As String
    Private CI02_NU_RG_ALUNO As String
    Private CI02_DT_EMISSAO_RG_ALUNO As String
    Private CI02_DT_NASCIMENTO_ALUNO As String
    Private CI02_TP_SEXO_ALUNO As Integer
    Private CI02_DH_CADASTRO As String

    Public Property CodigoDocumentos() As Integer
        Get
            Return CIO2_ID_DOCUMENTOS
        End Get
        Set(value As Integer)
            CIO2_ID_DOCUMENTOS = value
        End Set
    End Property

    Public Property CodigoAluno() As Integer
        Get
            Return CI01_ID_ALUNO
        End Get
        Set(value As Integer)
            CI01_ID_ALUNO = value
        End Set
    End Property

    Public Property NomeMae() As String
        Get
            Return CI02_NM_MAE
        End Get
        Set(value As String)
            CI02_NM_MAE = value
        End Set
    End Property

    Public Property CpfMae() As String
        Get
            Return CI02_NU_CPF_MAE
        End Get
        Set(value As String)
            CI02_NU_CPF_MAE = value
        End Set
    End Property

    Public Property NomePai() As String
        Get
            Return CI02_NM_PAI
        End Get
        Set(value As String)
            CI02_NM_PAI = value
        End Set
    End Property

    Public Property CpfPai() As String
        Get
            Return CI02_NU_CPF_PAI
        End Get
        Set(value As String)
            CI02_NU_CPF_PAI = value
        End Set
    End Property

    Public Property TelefoneResponsavel() As String
        Get
            Return CI02_NU_TELEFONE_RESPONSAVEL
        End Get
        Set(value As String)
            CI02_NU_TELEFONE_RESPONSAVEL = value
        End Set
    End Property

    Public Property RgAluno() As String
        Get
            Return CI02_NU_RG_ALUNO
        End Get
        Set(value As String)
            CI02_NU_RG_ALUNO = value
        End Set
    End Property

    Public Property EmissaoRgAluno() As String
        Get
            Return CI02_DT_EMISSAO_RG_ALUNO
        End Get
        Set(value As String)
            CI02_DT_EMISSAO_RG_ALUNO = value
        End Set
    End Property

    Public Property NascAluno() As String
        Get
            Return CI02_DT_NASCIMENTO_ALUNO
        End Get
        Set(value As String)
            CI02_DT_NASCIMENTO_ALUNO = value
        End Set
    End Property

    Public Property SexoAluno() As Integer
        Get
            Return CI02_TP_SEXO_ALUNO
        End Get
        Set(value As Integer)
            CI02_TP_SEXO_ALUNO = value
        End Set
    End Property

    Public Property Cadastro() As String
        Get
            Return CI02_DH_CADASTRO
        End Get
        Set(value As String)
            CI02_DH_CADASTRO = value
        End Set
    End Property

    Public Sub New(Optional ByVal CodigoDocumentos As Integer = 0)
        If CodigoDocumentos > 0 Then
            Obter(CodigoDocumentos)
        End If
    End Sub


    Public Sub Salvar()
        Dim cnn As New Conexao
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSQL As New StringBuilder

        strSQL.Append(" select * ")
        strSQL.Append(" from CI02_DOCUMENTOS")
        strSQL.Append(" where CI01_ID_ALUNO = " & CodigoDocumentos)

        dt = cnn.EditarDataTable(strSQL.ToString)

        If dt.Rows.Count = 0 Then
            dr = dt.NewRow
        Else
            dr = dt.Rows(0)
        End If



        dr("CI01_ID_ALUNO") = ProBanco(CI01_ID_ALUNO, eTipoValor.TEXTO)
        dr("CI02_NM_MAE") = ProBanco(CI02_NM_MAE, eTipoValor.TEXTO_LIVRE)
        dr("CI02_NU_CPF_MAE") = ProBanco(CI02_NU_CPF_MAE, eTipoValor.TEXTO_LIVRE)
        dr("CI02_NM_PAI") = ProBanco(CI02_NM_PAI, eTipoValor.TEXTO)
        dr("CI02_NU_CPF_PAI") = ProBanco(CI02_NU_CPF_PAI, eTipoValor.TEXTO_LIVRE)
        dr("CI02_NU_TELEFONE_RESPONSAVEL") = ProBanco(CI02_NU_TELEFONE_RESPONSAVEL, eTipoValor.TEXTO)
        dr("CI02_NU_RG_ALUNO") = ProBanco(CI02_NU_RG_ALUNO, eTipoValor.TEXTO_LIVRE)
        dr("CI02_DT_EMISSAO_RG_ALUNO") = ProBanco(CI02_DT_EMISSAO_RG_ALUNO, eTipoValor.TEXTO_LIVRE)
        dr("CI02_DT_NASCIMENTO_ALUNO") = ProBanco(CI02_DT_NASCIMENTO_ALUNO, eTipoValor.TEXTO_LIVRE)
        dr("CI02_TP_SEXO_ALUNO") = ProBanco(CI02_TP_SEXO_ALUNO, eTipoValor.TEXTO)
        dr("CI02_DH_CADASTRO") = ProBanco(CI02_DH_CADASTRO, eTipoValor.TEXTO_LIVRE)

        cnn.SalvarDataTable(dr)

        dt.Dispose()
        dt = Nothing

        cnn = Nothing
    End Sub

    Public Sub Obter(ByVal CodigoDocumentos As Integer)
        Dim cnn As New Conexao
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSQL As New StringBuilder

        strSQL.Append(" select * ")
        strSQL.Append(" from CI02_DOCUMENTOS")
        strSQL.Append(" where CI02_ID_DOCUMENTOS = " & CodigoDocumentos)

        dt = cnn.AbrirDataTable(strSQL.ToString)

        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)

            CIO2_ID_DOCUMENTOS = DoBanco(dr("CIO2_ID_DOCUMENTOS"), eTipoValor.CHAVE)
            CI01_ID_ALUNO = DoBanco(dr("CI01_ID_ALUNO"), eTipoValor.TEXTO)
            CI02_NM_MAE = DoBanco(dr("CI02_NM_MAE"), eTipoValor.TEXTO_LIVRE)
            CI02_NU_CPF_MAE = DoBanco(dr("CI02_NU_CPF_MAE"), eTipoValor.TEXTO_LIVRE)
            CI02_NM_PAI = DoBanco(dr("CI02_NM_PAI"), eTipoValor.TEXTO)
            CI02_NU_CPF_PAI = DoBanco(dr("CI02_NU_CPF_PAI"), eTipoValor.TEXTO_LIVRE)
            CI02_NU_TELEFONE_RESPONSAVEL = DoBanco(dr("CI02_NU_TELEFONE_RESPONSAVEL"), eTipoValor.TEXTO)
            CI02_NU_RG_ALUNO = DoBanco(dr("CI02_NU_RG_ALUNO"), eTipoValor.TEXTO_LIVRE)
            CI02_DT_EMISSAO_RG_ALUNO = DoBanco(dr("CI02_DT_EMISSAO_RG_ALUNO"), eTipoValor.TEXTO_LIVRE)
            CI02_DT_NASCIMENTO_ALUNO = DoBanco(dr("CI02_DT_NASCIMENTO_ALUNO"), eTipoValor.TEXTO_LIVRE)
            CI02_TP_SEXO_ALUNO = DoBanco(dr("CI02_TP_SEXO_ALUNO"), eTipoValor.TEXTO)
            CI02_DH_CADASTRO = DoBanco(dr("CI02_DH_CADASTRO"), eTipoValor.TEXTO_LIVRE)
        End If

        cnn = Nothing
    End Sub


End Class
