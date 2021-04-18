<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VeiwAllConulationRequests.aspx.cs" Inherits="Doctor_VeiwAllConulationRequests" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1>Doctor Section</h1>
        <p class="lead">Replay to consultation Requests</p>
    </div>

    <div class="container">
        <div class="ConsulationReq">
            <div class="ConsulationReqBody">
                <textarea class="p-2 form-control" id="ConsulationReqBody" rows="4" Readonly></textarea>
            </div>
            <div class="ConsulationReqKeywords">
                <textarea class="p-2 form-control" id="ConsulationReqKeywords" rows="2" Readonly></textarea>
            </div>
            <div>
                <asp:Button ID="ReplayBtn" runat="server" Text="Replay" CssClass="btn btn-danger" OnClick="ReplayBtn_Click" />
            </div>
            <div id="ReplaySection">
                 <textarea class="p-2 form-control" id="ReplayText" rows="2"></textarea>
                <asp:Button ID="SendReplay" runat="server" Text="Send Replay" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>

