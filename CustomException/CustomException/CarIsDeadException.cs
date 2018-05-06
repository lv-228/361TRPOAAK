using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
            :base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        public override string Message
        {
            get
            {
                return string.Format("Сообщение об ошибке в машине {0}", messageDetails);
            }
        }
        
    }
}
