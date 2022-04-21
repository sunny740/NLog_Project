using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NlogDemo
{
    public class AddNumber
    {
        private readonly Nlog nLog = new Nlog();
        public int Sum(int firstNumber, int secondNumber)
        {
            ////Checking values equal to 0
            if (firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting not null values");
                nLog.LogWarn("FirstNumber or secondNumber should not equal to 0");
            }
            int result = secondNumber + secondNumber;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum Method passed, Result" + result);
            return result;
        }
    }
}