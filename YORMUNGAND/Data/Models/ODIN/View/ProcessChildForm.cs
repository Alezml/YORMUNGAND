using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models.ODIN
{
    public class ProcessChildForm
    {
        [Display(Name = "Выберите процесс")]
        public int processId { get; set; }
        public List<SelectListItem> processIdListSelect { get; set; }

        [Display(Name = "Укажите стартовые параметры")]
        public string startParams { get; set; }

        [Display(Name = "Укажите приоритет. 0 - Минимальный, 65535 - Максимальный")]
        [Range(0,65535, ErrorMessage = "Диапазон от 0 до 65535")]
        public int priority { get; set; }

        [Display(Name = "Выберите доступные для процесса ресурсы")]
        public virtual List<Machine> machineList { get; set; }
        public virtual List<int> machineListID { get; set; }
        public List<SelectListItem> machineListSelect { get; set; }

        [Display(Name = "Укажите максимально желаемое колличество ресурсов. Минимум 1")]
        [Range(1, 200, ErrorMessage = "Диапазон от 1 до 200")]
        public int maxCountMachines { get; set; }

        [Display(Name = "Укажите минимально необходимое количество ресурсов. Минимум 0")]
        [Range(0, 20, ErrorMessage = "Диапазон от 0 до 20")]
        public int minCountMachines { get; set; }
        public virtual List<SchedulerProcess> SchedulerProcessesList { get; set; }
        public virtual List<QueueProcesses> QueueProcessesList { get; set; }
        public virtual List<DefaultQueueProcesses> DefaultQueueProcessesList { get; set; }
        public virtual List<QueueProcessLog> QueueProcessLogList { get; set; }
    }
}
