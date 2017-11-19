using Rastinware.CRM.UI.Web.Api.BOL.SystemBOL.Facade;

namespace Rastinware.CRM.UI.Web.Api.BOL.BOL.UserBol
{
    public class UserBol : BaseBol.BaseBol, BaseBol.IBaseBol
    {
        public UserBol(Facade facade) : base(facade)
        {
        }

        public string GetUserNameById(int Id)
        {
            return $"GetUserNameById from UserBol called! result is student-{Id} with id = {Id}";
        }
    }
}
