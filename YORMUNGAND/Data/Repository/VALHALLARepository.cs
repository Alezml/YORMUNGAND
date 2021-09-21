using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.SUPPORT;
using System.Linq.Dynamic;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using System.Linq.Dynamic.Core;
using VALHALLA.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class VALHALLARepository 
    {
        private readonly AppDBContent appDBContent;
        private readonly VALHALLADBContent valDBContent;
        public VALHALLARepository(VALHALLADBContent valDBContent, AppDBContent appDBContent)
        {
            this.valDBContent = valDBContent;
            this.appDBContent = appDBContent;
        }

       //Вывести записи по параметрам поиска
        public IEnumerable<HR_REPORT_CHATBOT_MAIN> ChatBotReport(HR_REPORT_CHATBOT_MAIN_FS SearchParam)
        {
            var result = valDBContent.REPORT_MAIN.Include(r => r.REPORT_ROWS).OrderByDescending(i => i.REQUEST_DATE).ThenByDescending(l => l.id)
                .Where(p => p.REQUEST_DATE >= SearchParam.REQUEST_DATEfrom)
                .Where(p => p.REQUEST_DATE <= SearchParam.REQUEST_DATEto)
                .Where(p => p.FINISH_DATE >= SearchParam.FINISH_DATEfrom)
                .Where(p => p.FINISH_DATE <= SearchParam.FINISH_DATEto);
        if (SearchParam.UD_EMPLOYEE_N != null)
            result = result.Where(p => EF.Functions.Like(p.UD_EMPLOYEE_N, SearchParam.UD_EMPLOYEE_N)); 
        if (SearchParam.UD_FULL_NAME != null)
            result = result.Where(p => EF.Functions.Like(p.UD_FULL_NAME, SearchParam.UD_FULL_NAME));
        if (SearchParam.HR_DOMAIN_NAME != null)
            result = result.Where(p => EF.Functions.Like(p.HR_DOMAIN_NAME, SearchParam.HR_DOMAIN_NAME)); 
        if (SearchParam.HR_FULLNAME != null)
            result = result.Where(p => EF.Functions.Like(p.HR_FULLNAME, SearchParam.HR_FULLNAME)); 
        if (SearchParam.HR_MAIL != null)
            result = result.Where(p => EF.Functions.Like(p.HR_MAIL, SearchParam.HR_MAIL)); 
        
        result = result.Skip((SearchParam.page - 1) * SearchParam.pagesize).Take(SearchParam.pagesize);
        return result;
        }

        public void UpdateHRData(int id, string hrDomainName, string hrFullName = null, string hrMail = null)
        {
            HR_REPORT_CHATBOT_MAIN HR = valDBContent.REPORT_MAIN.FirstOrDefault(c => c.id == id);
            HR.HR_DOMAIN_NAME = hrDomainName;
            HR.HR_FULLNAME = hrFullName;
            HR.HR_MAIL = hrMail;
            valDBContent.SaveChanges();
        }
        
        public void UpdateStatus(int id, int statusId)
        {
            HR_REPORT_CHATBOT_MAIN HR = valDBContent.REPORT_MAIN.FirstOrDefault(c => c.id == id);
            HR.PROCESSING_STATUS = statusId;
            valDBContent.SaveChanges();
        }
    }
}
