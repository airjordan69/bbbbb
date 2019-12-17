using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    public class ZlaOperacjaEXCEPTION : Exception
    {
        public ZlaOperacjaEXCEPTION()
        {
        }

        public ZlaOperacjaEXCEPTION(string message) : base(message)
        {
        }

        public ZlaOperacjaEXCEPTION(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ZlaOperacjaEXCEPTION(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }


}
