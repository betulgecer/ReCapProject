using System;
using System.Collections.Generic;
using System.Text;

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
        //datayı default haliyle döndürmek
        //çalıştırdığım T default bir şey döndürmek istemiyorum
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //hem default dçndüreyim hem de mesajsız
        public ErrorDataResult() : base(default, false)
        {

        }

    }
}
