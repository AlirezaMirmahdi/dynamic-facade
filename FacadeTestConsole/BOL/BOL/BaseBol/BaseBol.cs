using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rastinware.CRM.UI.Web.Api.BOL.SystemBOL.Facade;

namespace Rastinware.CRM.UI.Web.Api.BOL.BOL.BaseBol
{
    public class BaseBol : IBaseBol
    {
        private Facade _facade;
        public Facade facade
        {
            get
            {
                return _facade;
            }
            set
            {
                _facade = value;
            }
        }

        public BaseBol(Facade facade)
        {
            this.facade = facade;
        }
    }
}
