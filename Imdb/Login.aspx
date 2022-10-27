<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Imdb.Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section id="main-content">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Log In</h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="" runat="server" />
                                        <asp:TextBox ID="userName" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="User name" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-5 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="" runat="server" />
                                        <asp:TextBox ID="pw" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="Password" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6 col-md-offset-5">
                                    <div class="form-group">
                                        <asp:Button id="loginbtn" Text="Log In!" runat="server" OnClick="Loginbtn_Click"/>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6 col-md-offset-5">
                                    <div class="form-group">
                                        <asp:Label id="information" Text="" runat="server"/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>

                </div>

            </div>

        </section>

    </section>
</asp:Content>
