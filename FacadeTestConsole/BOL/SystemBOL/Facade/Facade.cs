using Rastinware.CRM.UI.Web.Api.BOL.BOL.BaseBol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using Rastinware.CRM.UI.Web.Api.BOL.SystemBOL.ApiCall;

namespace Rastinware.CRM.UI.Web.Api.BOL.SystemBOL.Facade
{
    public class Facade
    {
        private Dictionary<Type, IBaseBol> _bolsList = new Dictionary<Type, IBaseBol>();

        public CookieCollection ClientCookieCollection { get; set; }
        public string UserName { get; set; }

        public Facade() { }
        public Facade(string userName, CookieCollection cookies=null)
        {
            this.UserName = userName;
            ClientCookieCollection = cookies;
        }

        public void SetUserClientCookiesByRequest(HttpRequestMessage request)
        {
            this.ClientCookieCollection = CookieBOL.ConvertCookiesToCookieHeaderValueList(request.Headers.GetCookies().FirstOrDefault(),
                    ServiceStasckCall.ServiceStackBaseUrl);
        }

        public void SetUserNameAndClientCookies(string userName, CookieCollection cookies)
        {
            this.UserName = userName;
            this.ClientCookieCollection = cookies;
        }

        public T GetBol<T>() where T : BaseBol
        {
            Type requestedType = typeof(T);
            IBaseBol resValue;
            var canGetValue = _bolsList.TryGetValue(requestedType, out resValue);
            if (canGetValue)
            {
                return resValue as T;
            }
            var requestedObj = Activator.CreateInstance(requestedType, this);
            _bolsList.Add(requestedType, requestedObj as BaseBol);
            return requestedObj as T;
        }
    }
}
