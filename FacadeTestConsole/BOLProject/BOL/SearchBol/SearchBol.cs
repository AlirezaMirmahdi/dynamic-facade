using BOLProject.BOL.BaseBol;
using BOLProject.BOL.SystemBOL.Facade;

namespace Rastinware.CRM.UI.Web.Api.BOL.SearchBol
{
    public class SearchBol : BaseBol, IBaseBol
    {
        public SearchBol(Facade facade) : base(facade)
        {
        }

        public string QuickSearch(string searchTxt)
        {
            return $"QuickSearch from SearchBol called! searched text is : {searchTxt}";
        }
    }
}
