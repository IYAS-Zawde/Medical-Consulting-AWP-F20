using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        Code to add:
         - load all medical articles in DEVs like below
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
         */
    }

    protected void FullTopicView_Click(object sender, EventArgs e)
    {
        /*
        Code to add:
        - Go to page ~/Article/ViewArticle
        - load Article information in this page
        */
    }
}