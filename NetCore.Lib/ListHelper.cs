using System;
using System.Collections.Generic;
namespace NetCore.Lib
{
    public class Util
    {
        public static List<string> GetList()
        {
            List<string> list = new List<string>();

            list.Add("test");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");

            return list;
        }
    }
}
 