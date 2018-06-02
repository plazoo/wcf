using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Response
    {
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
        public string Message { get; set; }
        protected void PrepareResponse(bool r, string m = "")
        {
            Exito = r;

            if (r)
            {
                Message = m;
            }
            else
            {
                Message = (m == "" ? "An unexpected error occurred" : m);
            }
        }

        public Response()
        {
            Exito = false;
            Message = "An unexpected error occurred";
        }
    }

    public class ResponseHelper : Response
    {
        public dynamic Result { get; set; }

        public ResponseHelper SetResponse(bool r, string m = "")
        {
            PrepareResponse(r, m);
            return this;
        }
    }

    public class ResponseHelper<T> : Response where T : class
    {
        public T Result { get; set; }

        public ResponseHelper<T> SetResponse(bool r, string m = "")
        {
            PrepareResponse(r, m);
            return this;
        }
    }
}
