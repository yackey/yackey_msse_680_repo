﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYQuiltProject.services
{
    public interface ISimpleQuiltService : ISimpleService
    {
        String [] GetProjectNames();

        Order GetOrder(string sQuiltName);
        IEnumerable<OrderHistory> GetOrderHistory(int nOrderId);
        Recipient GetOrderRecipient(int nOrderId);

        DesignBlock GetDesignBlock(int nBlkId);
        IEnumerable<Award> GetAwards(int nQuiltId);
        IEnumerable<BOM> GetBOM(int nQuiltId);

        bool DeleteOrder(int nOrderId);

        bool CreateQuiltOrder(Order order, Quilt quilt, Recipient recipient, DesignBlock dblock,
            List<OrderHistory> listOh, List<Award> listAw, List<BOM> listBom);

        //IUnitOfWork GetInformationStoreUow();
        //IRepository<Order> GetOrderInformationStore();
        bool SaveProject(String sProjectName);

        IEnumerable<Order> GetOrderList(); 
        IEnumerable<Quilt> GetQuiltList();
        IEnumerable<Award> GetAwardList();
        IEnumerable<Recipient> GetRecipientList();
        IEnumerable<BOM> GetBomList();
        IEnumerable<OrderHistory> GetOrderHistoryList();
        IEnumerable<DesignBlock> GetDesignBlockList();

        void SetupDb(bool bMakeCancelledHistory);

    }
}
