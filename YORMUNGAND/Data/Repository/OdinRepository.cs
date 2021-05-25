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
    public class OdinRepository
    {
        private readonly OdinDBContent odinDBContent;
        public OdinRepository(OdinDBContent odinDBContent)
        {
            this.odinDBContent = odinDBContent;
        }
        //Получить все машинки
        public IEnumerable<Machine> GetAllMachines()
        {
            return odinDBContent.Machine.OrderByDescending(m => m.id);
        }
        public string AddNewMachine(MachineForm MF)
        //Добавить машинку
        {
            if (Regex.IsMatch(MF.machineName, @"[^0-9a-zA-Z\-]"))
            {
                return "Недопустимые символы";
            }
            else
            {
                Machine machine = odinDBContent.Machine.FirstOrDefault(m => m.machineName == MF.machineName);
                if (machine == null)
                {
                    odinDBContent.Machine.Add(new Machine
                    {
                        machineName = MF.machineName
                    }
                        );
                    odinDBContent.SaveChanges();
                    return "Добавлена успешно";
                }
                else
                {
                    return "Уже существует";
                }
            }
        }
        public IEnumerable<Guid> GetAllGuidsFromProcess()
        //Получить список всех гуид процессов в базе планировщика
        {
            return odinDBContent.Process.Select(p => p.BPprocessid);
        }
    }
}

