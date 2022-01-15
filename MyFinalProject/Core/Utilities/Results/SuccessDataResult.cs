using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //her şey dönsün
        public SuccessDataResult(T data,string message): base(data,true,message)
        {

        }
        //Mesajsız
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //datayı default haliyle döndürmek,
        //çalıştığım T default bir şey döndürmek istemiyorum.
        public SuccessDataResult(string message) : base(default,true,message)
        {

        }
        //hem default döndüreyim hem de mesajsız
        public SuccessDataResult() : base(default,true)
        {

        }
    }
}
