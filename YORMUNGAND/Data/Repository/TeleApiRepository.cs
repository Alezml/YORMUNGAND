using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class TeleApiRepository
    {
        private readonly AppDBContent appDBContent;
        public TeleApiRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string GetHash()
        {
            TeleApiAccess taa = appDBContent.TeleApiAccess.FirstOrDefault(a => a.id == 1);
            if (taa != null)
            {
                return taa.HASH;
            }
            else
            {
                return "";
            }
        }
        public string GetCode()
        {
            TeleApiAccess taa = appDBContent.TeleApiAccess.FirstOrDefault(a => a.id == 1);
            if (taa != null)
            {
                return taa.CODE;
            }
            else
            {
                return "";
            }
        }
        public bool IsNeedNewHash()
        {
            TeleApiAccess taa = appDBContent.TeleApiAccess.FirstOrDefault(a => a.id == 1);
            if (taa != null)
            {
                if (taa.HASH != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public async Task AddNewHash(string hash)
        {
            TeleApiAccess taa = appDBContent.TeleApiAccess.FirstOrDefault(a => a.id == 1);
            if (taa != null)
            {
                taa.HASH = hash;
                taa.CODE = "";
                taa.ERROR = "Введите код";
                await appDBContent.SaveChangesAsync();
            }
        }
        public async Task WriteError(string msg)
        {
            TeleApiAccess taa = appDBContent.TeleApiAccess.FirstOrDefault(a => a.id == 1);
            if (taa != null)
            {
                taa.HASH = "";
                taa.CODE = "";
                taa.ERROR = msg;
                await appDBContent.SaveChangesAsync();
            }
        }
        public async Task<bool> CodeIsExist()
        {
            TeleApiAccess taa = await appDBContent.TeleApiAccess.FirstOrDefaultAsync(a => a.id == 1);
            if (taa != null)
            {
                if (taa.CODE != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}

