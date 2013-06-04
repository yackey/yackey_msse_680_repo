using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

namespace SAYQuiltProject.services
{
    public class COrderSvcSOAPImpl : IOrderSvc
    {
        public void StoreOrder(Order order)
        {
            FileStream fileStream = new FileStream("Order.soap", FileMode.Create, FileAccess.Write);
            //IFormatter formatter = new SoapFormatter();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, order);
            fileStream.Close();
        }

        public Order RetrieveOrder(int id)
        {
            FileStream fileStream = new FileStream("Order.soap", FileMode.Open, FileAccess.Read);
            //IFormatter formatter = new SoapFormatter();
            IFormatter formatter = new BinaryFormatter();
            Order order = formatter.Deserialize(fileStream) as Order;
            fileStream.Close();
            return order;
        }

        public void UpdateOrder(Order ord)
        {
            Console.WriteLine("Entering UpdateOrder");
        }

        public void DeleteOrder(Order ord)
        {
            Console.WriteLine("Entering DeleteOrder");
        }

    }
}
