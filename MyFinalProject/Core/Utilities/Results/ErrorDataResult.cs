using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //her şey dönsün
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //Mesajsız
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //datayı default haliyle döndürmek,
        //çalıştığım T default bir şey döndürmek istemiyorum.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //hem default döndüreyim hem de mesajsız
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
