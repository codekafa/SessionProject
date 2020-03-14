using Session.Model.Infrastructure;
using System.Collections.Generic;

namespace Session.Model.Infrastructure
{
    public class BaseResultModel<T> 
    {
        public bool IsSuccess { get; set; }

        public T  Data { get; set; }

        public List<string> Messages { get; set; }
    }
}
