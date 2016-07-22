using System;

namespace BreakingSingleResponsibility
{
    public class logger
    {
        public void logMeUp(Exception ex)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", ex.ToString());
        }
    }
}