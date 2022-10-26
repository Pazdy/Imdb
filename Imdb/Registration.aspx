<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Imdb.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="main-content">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Registration</h1>
                            </div>

                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="User name" runat="server" />
                                        <asp:TextBox ID="usernameid" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="User name" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-5 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="Email" runat="server" />
                                        <asp:TextBox ID="emailid" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="Email adress" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="Password" runat="server" />
                                        <asp:TextBox ID="pwid" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="Password" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-7 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="Confirm password" runat="server" />
                                        <asp:TextBox id="rpwid" runat="server" Enabled="true" CssClass="form-control input-group-sm" placeholder="Again password" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-8 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label Text="Date of Birth" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" TextMode="Date" CssClass="form-control input-group-sm" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-9 col-md-offset-5">
                                    <div class="form-group">
                                        <asp:Label Text="Gender" runat="server" />
                                        <asp:RadioButtonList Id="genderid" runat="server">
                                            <asp:ListItem Text="Male"></asp:ListItem>
                                            <asp:ListItem Text="Female"></asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-10 col-md-offset-5">
                                    <div class="form-group">
                                        <asp:Button id="registerbtn" Text="Registrate!" runat="server" OnClick="Registerbtn_Click"/>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-11 col-md-offset-4">
                                    <div class="form-group">
                                        <asp:Label ID="information" Text="" runat="server" />
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
