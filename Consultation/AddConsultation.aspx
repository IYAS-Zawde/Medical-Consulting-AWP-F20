<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddConsultation.aspx.cs" Inherits="Consoletion_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1>Talke To Doctor</h1>
        <p class="lead">Add your question so that the doctor can give you a consultation</p>
    </div>

    <div class="row d-flex justify-content-center">
        <div class="col-md-12">
            <h4>What are your symptoms?</h4>
            <textarea class="form-control" id="Symptoms" width="100%" rows="4"></textarea>
        </div>
        <div class="col-md-12">
            <h4>ِAdd Some Keywords Assistant</h4>
            <textarea class="form-control" id="Keywords" rows="2"></textarea>
        </div>
    </div>
   
    <div class="container">
        <asp:Button runat="server" OnClick="AddConsulation" Text="Send it" style="margin-top: 10px;" CssClass="btn btn-primary" />
    </div>

</asp:Content>

