<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Tabib</h1>
        <p class="lead">This is a medical site where you can get a consultation</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="TopicsList">
                <!-- first Topic-->
                <div class ="TopicDiv" id="TopicID_001">
                    <div class="row">
                        <div class="col-sm-4">
                            <img src="./Res/topic.png" class="img-thumbnail img-rounded" alt="Cinque Terre">
                        </div>
                        <div class="col-sm-8">
                            <h3>Topic Title</h3>
                            <span class="label label-info float-right">Creation Date</span>
                            <p class ="TopicBrif">
                                                Topic Brief    .....
                            </p>
                            <asp:Button class="btn btn-primary" ID="FullTopicView" runat="server" Text="Continue Reading" OnClick="FullTopicView_Click" />
                        </div>
                    </div>
                </div>
                <!-- Second Topic-->
                <div class ="TopicDiv" id ="TopicID_002">
                    <div class="row">
                        <div class="col-sm-4">
                            <img src="./Res/topic.png" class="img-thumbnail img-rounded" alt="Cinque Terre">
                        </div>
                        <div class="col-sm-8">
                            <h2>Topic Title</h2>
                            <span class="label label-info float-right">Creation Date</span>
                            <p class ="TopicBrif">
                                                Topic Brief    .....
                            </p>
                            <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Continue Reading" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
