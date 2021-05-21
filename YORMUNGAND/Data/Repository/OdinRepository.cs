using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.ODIN;

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
        //Добавить машинку
        public string AddNewMachine(MachineForm MF)
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
}

