using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class RPARepository 
    {
        private readonly AppDBContent appDBContent;
        public RPARepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public void AddAlert(string proces, string tag, string errorMsg, string dolist)
        {
            appDBContent.RPAAlert.Add(new Alert
            {
                PROCES = proces,
                TAG = tag,
                ERROR_MSG = errorMsg,
                DOLIST = dolist,
                EVENT_TIME = DateTime.Now,
                WORKED = false,
            });
            appDBContent.SaveChanges();
        }
        public void WorkAlert(int id)
        {
            Alert alert = appDBContent.RPAAlert.FirstOrDefault(a => a.id == id);
            if (alert != null) 
            {
                alert.WORKED = true;
                alert.WORKED_TIME = DateTime.Now;
                appDBContent.SaveChanges();
            };
        }
        public void ToDoAlert(int id)
        {
            Alert alert = appDBContent.RPAAlert.FirstOrDefault(a => a.id == id);
            if (alert != null)
            {
                alert.WORKED = false;
                appDBContent.SaveChanges();
            };
        }
        // получить отработанные алерты
        public IEnumerable<Alert> GetWorkedAlerts()
        {
            return appDBContent.RPAAlert.Where(a => a.WORKED == true).OrderByDescending(a => a.WORKED_TIME).Take(3);
        }
        // получить не отработанные алерты
        public IEnumerable<Alert> GetToDoAlerts()
        {
            IEnumerable<Alert> alerts = appDBContent.RPAAlert.Where(a => a.WORKED == false).OrderByDescending(a => a.WORKED_TIME);
            foreach (Alert alert in alerts)
            {
                //доавить признак мигания если событие недавние
                alert.Blink = alert.EVENT_TIME.AddMinutes(5) > DateTime.Now;
            }
            return alerts;
        }
        public Alert GetAlertByID(int id)
        {
            return appDBContent.RPAAlert.FirstOrDefault(a => a.id == id);
        }
        public DateTime GetLastAlertDate()
        {
            return appDBContent.RPAAlert.OrderByDescending(a => a.EVENT_TIME).Select(a => a.EVENT_TIME).FirstOrDefault();
        }
    }
}

