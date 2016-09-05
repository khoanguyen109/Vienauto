using System.Linq;

namespace Vienauto.Service.Result
{
    public class ServiceResult<TData> : ErrorHelper
    {
        public TData Target { get; set; }

        public bool HasErrors
        {
            get
            {
                return Errors.Count > 0 ? true : false;
            }
        }
    }
}
