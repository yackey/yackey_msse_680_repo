using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAYQuiltProject.services;

namespace SAYQuiltProject.business
{
    public class COrderManager : CSimpleManager
    {
        public Order GetOrderFromQuilt(Quilt q)
        {
            // the business rule might be don't allow delete unless the order is cancelled
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            Order orderFromQuilt = null;
            try
            {
                orderFromQuilt = simpleQuiltSvc.GetOrder(q.Name);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
            }
            return orderFromQuilt;
        }

        public int GetQuiltIdFromQuiltName(string qName)
        {
            ISimpleQuiltService simpleQuiltSvc = null;
            try
            {
                simpleQuiltSvc = (ISimpleQuiltService) GetService("ISimpleQuiltService");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
                return 0;
            }
            IEnumerable<Quilt> qEnum = simpleQuiltSvc.GetQuiltList();
            List<Quilt> qList = qEnum.ToList();
            foreach (var item in qList)
            {
                if (item.Name.CompareTo(qName) == 0)
                {
                    return item.QuiltId;
                }
            }
            return 0;
        }

        public IEnumerable<OrderHistory> GetOrderHistory(int orderId)
        {
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<OrderHistory> orderHistory = null;
            try
            {
                orderHistory = simpleQuiltSvc.GetOrderHistory(orderId);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
            }
            return orderHistory;
        }

        public IEnumerable<BOM> GetBOM(int quiltId)
        {
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<BOM> bom = null;
            try
            {
                bom = simpleQuiltSvc.GetBOM(quiltId);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
            }
            return bom;
        }

        public IEnumerable<Award> GetAwards(int quiltId)
        {
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            IEnumerable<Award> awards = null;
            try
            {
                awards = simpleQuiltSvc.GetAwards(quiltId);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
                throw ex; 
            }
            return awards;
        }

        public Recipient GetOrderRecipient(int orderId)
        {
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            Recipient r = null;
            try
            {
                r = simpleQuiltSvc.GetOrderRecipient(orderId);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
            }
            return r;
        }

        public DesignBlock GetDesignBlock(int quiltId)
        {
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
            DesignBlock blk = null;
            try
            {
                blk = simpleQuiltSvc.GetDesignBlock(quiltId);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
            }
            return blk;
        }

        public bool DeleteOrder(string sQuiltOrderToDelete)
        {
            // the business rule might be don't allow delete unless the order is cancelled
            ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService) GetService("ISimpleQuiltService");
            Order orderToDelete = null;
            try
            {
                orderToDelete = simpleQuiltSvc.GetOrder(sQuiltOrderToDelete);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
                return false;
            }

            IEnumerable<OrderHistory> orderHistory = simpleQuiltSvc.GetOrderHistory(orderToDelete.OrderId);

            bool bIsCancelled = false;
            foreach (var item in orderHistory)
            {
                if (item.Phase.CompareTo("Cancelled") == 0)
                {
                    bIsCancelled = true;
                    break;
                }
            }
            if (bIsCancelled == false)
            {
                //Console.WriteLine("The order has not been cancelled and cannot be deleted.");
            }
            else
            {
                bool bRet = simpleQuiltSvc.DeleteOrder(orderToDelete.OrderId);
            }
            return true;
        }

        public void SetupDb(bool bMakeCancelledHistory)
        {
            try
            {            
                ISimpleQuiltService simpleQuiltSvc = (ISimpleQuiltService)GetService("ISimpleQuiltService");
                simpleQuiltSvc.SetupDb(false);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex.Message);
                throw ex;
            }
        }

    }
}
