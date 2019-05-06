using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NancyDemo.Modules
{
    /// <summary>
    /// 测试模块
    /// </summary>
    public class TestModule : Nancy.NancyModule
    {
        public TestModule()
        {
            Get("/h" , q => @"Hellow word!");
        }
    }
}
