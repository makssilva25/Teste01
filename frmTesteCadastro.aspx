<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmTesteCadastro.aspx.vb" Inherits="frmTesteCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="content-header">

    </section>
    <section class="content">
           <h4 class="page-header">Teste Formulario Cadastro</h4>
        <div class="row">
           <div class="box-body">

               <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtNomeMae">Nome da Mãe:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="txtNomeMae" name="NomeMae" placeholder="Ex.: Maria" maxlength="50"/>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="CPFMae">CPF da Mãe:</label>
                            <asp:TextBox runat="server" required="required" type="text" class="form-control" id="CPF_Mae" name="CPFMae" placeholder="Ex.: 010.011.111-00" maxlength="14"/>
                        </div>
                    </div>
                </div>
               <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtNomePai">Nome do Pai:</label>
                            <asp:TextBox runat="server" type="text" class="form-control" id="txtNomePai" name="NomePai" placeholder="Ex.: João" maxlength="50"/>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <label for="CPFPai">CPF do Pai:</label>
                            <asp:TextBox runat="server" type="text" class="form-control" id="CPF_Pai" name="CPFPai" placeholder="Ex.: 010.011.111-00" maxlength="14"/>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <label for="txtTelefoneResp">Telefone do Responsavel:</label>
                            <asp:TextBox runat="server" type="tel" class="form-control" id="txtTelefoneResp" name="TelefoneResp" placeholder="Ex.: (11) 2020-3030" maxlength="15"/>
                        </div>
                    </div>
                </div>

               <div class="row">
                   <div class="col-md-3">
                        <div class="form-group">
                            <label for="txtRg">RG do Aluno:</label>
                            <asp:TextBox runat="server" type="tel" class="form-control" id="txtRg" name="rg" placeholder="Ex.: 03260..." maxlength="12"/>
                        </div>
                    </div>
                   <div class="col-md-3">
                        <div class="form-group">
                            <label for="txtDataEmissaoRg">Data de Emissão RG:</label>
                            <asp:TextBox runat="server" type="tel" class="form-control" id="txtDataEmissaoRg" name="emissaoRG" placeholder="Ex.: 22/12/1992" maxlength="10"/>
                        </div>
                    </div>
                   <div class="col-md-3">
                        <div class="form-group">
                            <label for="nascAluno">Nascimento do aluno:</label>
                            <asp:TextBox runat="server" required="required" type="tel" class="form-control" id="nascAluno" name="nascAluno" placeholder="Ex.: 22/12/1992" maxlength="15"/>
                        </div>
                    </div>

                   <div class="col-md-3">
                        <div class="form-group">
                            <label for="txtDataEmissaoRg">Sexo:</label> <br/>
                                   <label class="" style="margin-top: 6px;">
                                    <div class="iradio_minimal" aria-checked="false" aria-disabled="false" style="position: relative;">
                                        <input type="radio" name="sexoAluno" required="required"  id="sexoAluno1" value="M" checked="" style="position: absolute; opacity: 0;"/>
                                     
                                    </div>
                                        Masculino
                                 </label>
                                <label class="" style="margin-top: 6px;">
                                  <div class="iradio_minimal checked" aria-checked="true" aria-disabled="false" style="position: relative;">
                                      <input type="radio" name="sexoAluno" id="sexoAluno2" value="F" style="position: absolute; opacity: 0;"/>
                                  </div>
                                        Feminino
                                </label>


                            <div class="row">

                                <div class="form-group">
                                    <br /><br />
                                    <asp:Button class="btn btn-primary" runat="server" ID="btnSalvar" Text="Salvar" /> <br />
                                </div>                      
                           </div>

                     
                       </div>


                    </div>
                   
                </div>
  
           </div>
        </div>

        <div class="row">

            <div class="box-body">
            <div class="row">
                <div class="col-md-12">
                    <asp:Label ID="lblRegistros" runat="server" CssClass="badge bg-aqua" />
                    <asp:GridView ID="grdAluno" runat="server" CssClass="table table-bordered" PagerStyle-CssClass="paginacao" AllowSorting="True" AllowPaging="True" PageSize="20" AutoGenerateColumns="False" DataKeyNames="CI01_ID_ALUNO" DataSourceID="SqlDataSource1">


                        <Columns>
                            <asp:BoundField DataField="CI01_ID_ALUNO" HeaderText="Codigo" ReadOnly="True" InsertVisible="False" SortExpression="CI01_ID_ALUNO"></asp:BoundField>
                            <asp:BoundField DataField="CI01_NM_ALUNO" HeaderText="Aluno" SortExpression="CI01_NM_ALUNO"></asp:BoundField>
                            <asp:BoundField DataField="CI01_NU_CPF" HeaderText="CPF" SortExpression="CI01_NU_CPF"></asp:BoundField>
                            <asp:BoundField DataField="CI01_NM_CIDADE" HeaderText="CIDADE" SortExpression="CI01_NM_CIDADE"></asp:BoundField>
                            <asp:CommandField ShowSelectButton="true" />

                             <asp:TemplateField HeaderText="" SortExpression="" Visible="true" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="text-center">

                                <HeaderTemplate>
                                    Editar
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="btn-group">
                                        <asp:LinkButton ID="lnkEditarAluno" runat="server" class="btn btn-social-icon bg-blue" CommandName="EDITAR" ToolTip="EditarAluno" >
                                            <i id="iEditarAluno" runat="server" class="fa fa-mortar-board"></i>
                                        </asp:LinkButton>
                                    </div>
                                </ItemTemplate>

                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:StringConexao %>' SelectCommand="SELECT [CI01_ID_ALUNO], [CI01_NM_ALUNO], [CI01_NU_CPF], [CI01_NM_CIDADE] FROM [CI01_ALUNO]"></asp:SqlDataSource>
                </div>
            </div>
        </div>

        

           </div>
    </section>
</asp:Content>
