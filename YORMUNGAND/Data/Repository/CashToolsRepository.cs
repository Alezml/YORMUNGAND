using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class CashToolsRepository
    {
        private readonly AppDBContent appDBContent;
        public CashToolsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public CashBlock AddCashBlock(DateTime blockdate, string name)
        {
            CashBlock cashblock = appDBContent.CashBlock.FirstOrDefault();
            if (cashblock != null)
            {
                cashblock.BLOCKED = true;
                cashblock.DATE = blockdate;
                cashblock.BLOCK_NAME = name;
                cashblock.BLOCK_DATE = DateTime.Now;
            }
            else
            {
                cashblock = new CashBlock
                {
                    BLOCKED = false,
                    DATE = DateTime.Now,
                    BLOCK_DATE = DateTime.Now,
                };
                appDBContent.CashBlock.Add(cashblock);
            }
            appDBContent.SaveChanges();
            return cashblock;
        }
        public CashBlock GetCashBlock()
        {
            CashBlock cashblock = appDBContent.CashBlock.FirstOrDefault();
            if (cashblock == null)
            {
                cashblock = new CashBlock
                {
                    BLOCKED = false,
                    DATE = DateTime.Now,
                    BLOCK_DATE = DateTime.Now,
                };
                appDBContent.CashBlock.Add(cashblock);
                appDBContent.SaveChanges();
            }
            return cashblock;
        }
        public void Unlock()
        {
            CashBlock cashblock = appDBContent.CashBlock.FirstOrDefault();
            if (cashblock == null)
            {
                cashblock = new CashBlock
                {
                    BLOCKED = false,
                    DATE = DateTime.Now,
                    BLOCK_DATE = DateTime.Now,
                };
                appDBContent.CashBlock.Add(cashblock);
            }
            else
            {
                cashblock.BLOCKED = false;
            }
            appDBContent.SaveChanges();
        }
    }
}

