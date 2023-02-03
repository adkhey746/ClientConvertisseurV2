using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientConvertisseurV2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConvertisseurV2.ViewModels;

namespace ClientConvertisseurV2.Services.Tests
{
    [TestClass()]
    public class WSServiceTests
    {
        [TestMethod()]
        public void WSServiceTest()
        {
            WSService uri = new WSService("https://localhost:44340/api/");
            Assert.IsNotNull(uri);
        }

        [TestMethod()]
        public void GetDevisesAsyncTest()
        {
            WSService service = new WSService("https://localhost:44340/api/");
            var result = service.GetDevisesAsync("devises").Result;
            Assert.IsNotNull(result);   
        }
    }
}