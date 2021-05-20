using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class CessToolsRepository
    {
        private readonly AppDBContent appDBContent;
        private readonly eCESSDBContent ecessDBContent;
        public CessToolsRepository(AppDBContent appDBContent, eCESSDBContent ecessDBContent)
        {
            this.appDBContent = appDBContent;
            this.ecessDBContent = ecessDBContent;
        }
        public IEnumerable<VIRCommentAnalitics> GetAllVirCommentAnalitics()
        {
            return ecessDBContent.CESSVIRCOMMENTS.OrderByDescending(c => c.ENABLE).ThenByDescending(c => c.START_TIME);
        }
        public VIRCommentAnaliticsForm AddNewVirCommentAnalitics(VIRCommentAnaliticsForm inptForm, string author)
        {
            if (inptForm.SQL_STRING == null || inptForm.SQL_STRING.Replace(" ", "") == "" || inptForm.SQL_STRING == "Запрос не может быть пустым")
            {
                inptForm.SQL_STRING = "Запрос не может быть пустым";
            }
            else if (inptForm.COMMENT == null || inptForm.COMMENT.Replace(" ", "") == "" || inptForm.COMMENT == "Описание не может быть пустым")
            {
                inptForm.COMMENT = "Комментарий не может быть пустым";
            }
            else
            {
                ecessDBContent.CESSVIRCOMMENTS.Add(new VIRCommentAnalitics
                {
                    AUTHOR = author,
                    SQL_STRING = inptForm.SQL_STRING,
                    COMMENT = inptForm.COMMENT,
                    START_TIME = DateTime.Now,
                    ENABLE = true
                });
                ecessDBContent.SaveChanges();
                inptForm.SQL_STRING = "Добавлено успешно";
                inptForm.COMMENT = "";
            }
            return inptForm;
        }
        public void DeleteVirCom(int id)
        {
            VIRCommentAnalitics VCA = ecessDBContent.CESSVIRCOMMENTS.FirstOrDefault(c => c.id == id);
            if (VCA != null)
            {
                VCA.END_TIME = DateTime.Now;
                VCA.ENABLE = false;
                ecessDBContent.SaveChanges();
            }
        }
    }
}

