using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiValidationErrorRespons : ApiResponse
    {
        public ApiValidationErrorRespons() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}