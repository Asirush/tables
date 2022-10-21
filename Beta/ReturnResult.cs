using System;

namespace Tables.dll
{
    public class ReturnResult
    {
        public bool BoolResult { get; set; } = false;
        public string Message { set; get; } = "";

        public ReturnResult()
        {

        }
        public ReturnResult(bool res, string msg)
        {
            BoolResult = res;
            Message = msg;
        }
    }
}
