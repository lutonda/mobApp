
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace mobgo.Applications
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        private string clientAutorizationKey = "dffa5119e5876bdc685ab77046a29644127443b965668df54bc1884bccda7cb8-fedec5a0e65735d2e37dcc4ec16c444716cf83280ea64fe5d8fcbcb676fb1900-cec69639c6b76e897fa03cce512a76e9386fd3e9cd5451563f255dfccc0121af";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
            }
            else if (!actionContext.Request.Headers.Authorization.ToString().Equals(this.clientAutorizationKey))
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);

            }
            else
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(this.clientAutorizationKey), null);
            }

        }
    }
}