using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public ErrorDto()
        {
            ErrorMessages = new List<string>();

        }

        public ErrorDto(string error , bool isshow)
        {
            ErrorMessages.Add(error);
            IsShow = true;
        }


        public ErrorDto(List<string> error, bool isshow)
        {
            ErrorMessages = error;
            IsShow = true;
        }

        List<string> ErrorMessages { get; set; }
        public bool IsShow { get; set; }
        public bool Flag { get; set; }
    
    
    }
}
