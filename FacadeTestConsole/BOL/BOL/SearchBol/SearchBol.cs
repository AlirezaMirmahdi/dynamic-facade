using Rastinware.CRM.UI.Web.Api.BOL.SystemBOL.Facade;

namespace Rastinware.CRM.UI.Web.Api.BOL.BOL.SearchBol
{
    public class SearchBol : BaseBol.BaseBol, BaseBol.IBaseBol
    {
        public SearchBol(Facade facade) : base(facade)
        {
        }

        public string QuickSearch(string searchTxt)
        {
            return "QuickSearch from SearchBol called!";
        }
    }
}
