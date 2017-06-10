using System;

namespace WebApiSandbox.Requests.Base
{
    public abstract class BaseRequest
    {
        public string RequestId => Guid.NewGuid().ToString();
    }
}