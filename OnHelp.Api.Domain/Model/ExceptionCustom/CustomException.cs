using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Model.ExceptionCustom
{
    public class CustomException : Exception
    {

        public string ValidationMessage { get; set; }

        public CustomException()
         : base() { }

        public CustomException(string message)
            : base(message) { }


        public CustomException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public CustomException(string message, Exception innerException)
            : base(message, innerException) { }

        public CustomException(FluentValidation.Results.ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                this.ValidationMessage += item.ErrorMessage + Environment.NewLine;
            }
        }

        public CustomException(List<CustomException> validationResult)
        {
            foreach (var item in validationResult)
            {
                this.ValidationMessage += item.Message + Environment.NewLine;
            }
        }

        public CustomException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
