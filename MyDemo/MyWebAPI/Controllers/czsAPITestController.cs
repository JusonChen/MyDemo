using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    [RoutePrefix("czs/czsTest")]
    public class czsAPITestController : ApiController
    {
        Product[] products = new Product[] {
            new Product() { ID=1,Num=1,Name="手机1",IsOK=true },
            new Product() {ID=2,Num=2,Name="手机2",IsOK=true  },
            new Product() {ID=3,Num=3,Name="手机3",IsOK=true  },
            new Product() { ID=4,Num=4,Name="手机4",IsOK=true },
            new Product() { ID=5,Num=5,Name="手机5",IsOK=true }
        };

        // GET: api/czsAPITest
        
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        // GET: api/czsAPITest/5
        [ActionName("GetProductsByID")]
        
        public Product GetProduct(int id)
        {
            return products.Where(c => c.ID == id).FirstOrDefault();
        }

        // POST: api/czsAPITest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/czsAPITest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/czsAPITest/5
        [ActionName("Delete")]

        public string GetDelete(int DeleteID)
        {
            return "delete";
        }
        //自己设置访问的路由规则
        [Route("testApiRoute/Test/GetDelete")]
        public string GetDelete2(int DeleteID)
        {
            return "delete222";
        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }       

        public int Num { get; set; }

        public bool IsOK { get; set; }
    }
}
