using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.ODIN;
using System.Text.RegularExpressions;

namespace YORMUNGAND.Data.Repository
{
    public class OdinMultiRepository
    {
        private readonly OdinDBContent odinDBContent;
        private readonly BPdev1DBContent bpdev1DBContent;
        private readonly OdinRepository orep;
        public OdinMultiRepository(OdinDBContent odinDBContent, BPdev1DBContent bpdev1DBContent)
        {
            this.odinDBContent = odinDBContent;
            this.bpdev1DBContent = bpdev1DBContent;
            this.orep = new OdinRepository(odinDBContent);
        }
        public string AddNewProcessByBpId(Guid guid)
            //добавить процес из базы призмы в базу планировщика
        {
            Process process = odinDBContent.Process.FirstOrDefault(p => p.BPprocessid == guid);
            if (process == null)
            {
                BPAProcess bpaprocess = bpdev1DBContent.BPAProcess.FirstOrDefault(p => p.processid == guid);
                if (bpaprocess != null)
                {
                    odinDBContent.Process.Add(new Process
                    {
                        ProcessName = bpaprocess.name,
                        Responsible = "", 
                        BPprocessid = bpaprocess.processid

                    });
                    odinDBContent.SaveChanges();
                    return "SUCCESS";
                }
                else
                {
                    return "Процесс не найден в базе призмы";
                }
            }
            else
            {
                return "Процесс был добавлен ранее";
            }
        }
        public IEnumerable<BPAProcess> GetAllNewApprovedProcess()
            //Получить список процессов из призмы, которых нет в планировщике
        {
            return bpdev1DBContent.BPAProcess.Where(p => p.AttributeID == 2 && p.ProcessType == "P" && EF.Functions.Like(p.description, "%#ODIN_APPROVED%") && !orep.GetAllGuidsFromProcess().ToList().Contains(p.processid));
        }
    }
}

