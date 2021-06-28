using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class VBARepository
    {
        private readonly AppDBContent appDBContent;
        public VBARepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<VBAproject> GetAllVBAprojects()
        {
            return appDBContent.VBAproject.OrderBy(v => v.id);
        }
        public VBAprojectForm AddNewVBAproject(VBAprojectForm inptForm)
        {
            if (inptForm.NAME == null || inptForm.NAME.Replace(" ", "") == "" || inptForm.NAME == "Имя не может быть пустым")
            {
                inptForm.NAME = "Имя не может быть пустым";
            }
            else if (inptForm.DESC == null || inptForm.DESC.Replace(" ", "") == "" || inptForm.DESC == "Описание не может быть пустым")
            {
                inptForm.DESC = "Описание не может быть пустым";
            }
            else
            {
                VBAproject IsExists = appDBContent.VBAproject.FirstOrDefault(i => i.NAME == inptForm.NAME.Replace(" ", ""));
                if (IsExists == null)
                {
                    appDBContent.VBAproject.Add(new VBAproject
                    {
                        NAME = inptForm.NAME.Replace(" ", ""),
                        DESC = inptForm.DESC
                    });
                    appDBContent.SaveChanges();
                    inptForm.NAME = "Добавлено успешно";
                    inptForm.DESC = "";
                }
                else
                {
                    inptForm.NAME = "Имя занято";
                    inptForm.DESC = "";
                }
            }
            return inptForm;
        }
        public void WriteVBAlog(int id)
        {
            appDBContent.VBAlog.Add(new VBAlog
            {
                VBAprojectID = id,
                StartTime = DateTime.Now,
                VER = 0,
                CompName = ""
            });
            appDBContent.SaveChanges();
        }
        public void WriteVBAlog2(int id, double ver, string pcname)
        {
            appDBContent.VBAlog.Add(new VBAlog
            {
                VBAprojectID = id,
                StartTime = DateTime.Now,
                VER = ver,
                CompName = pcname
            });
            appDBContent.SaveChanges();
        }
        public string CheckVBAver(int id, double ver)
        {
            VBAproject vp = appDBContent.VBAproject.FirstOrDefault(v => v.id == id);
            if (vp.VER > ver)
            {
                return "NEED_UPDATE___" + vp.VER + "___" + vp.LINK;
            }
            else
            {
                return "SUCCESS";
            }
        }
    }
}

