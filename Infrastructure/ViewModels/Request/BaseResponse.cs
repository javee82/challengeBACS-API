using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModels.Request
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Body { get; set; }
    }
}
