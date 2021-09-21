using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    [Table("MAIN-1")]
    //[Keyless]
    public class MainReportWave1
    {
        [Column("Ключ (счетчик)")]
        public int id { set; get; }

        [Column("NRI_ссылка")]
        public string NRI_LINK { set; get; }

        [Column("ЗМ_с_лотом")]
        public string ZM_LOT { set; get; }

        [Column("Регион")]
        public string REGION { set; get; }

        [Column("Филиал")]
        public string FILIAL { set; get; }

        [Column("NRI_БС_Номер")]
        public string NRI_BS_N { set; get; }

        [Column("NRI_БС_Наименование")]
        public string NRI_BS_NAME { set; get; }

        [Column("ДС_Номер")]
        public string DS_N { set; get; }

        [Column("Поставщик")]
        public string PROVIDER { set; get; }

        [Column("ВИР_Тип_документа")]
        public string VIR_DOC_TYPE { set; get; }

        [Column("ВИР_Дополнение")]
        public string VIR_DOP { set; get; }

        [Column("ВИР_Дополнение_номер")]
        public string VIR_DOP_N { set; get; }

        [Column("ВИР_дата")]
        public DateTime VIR_DATE { set; get; }

        [Column("ВИР_Сумма_без_НДС")]
        public  decimal VIR_SUMM_WO_NDS { set; get; }

        [Column("ВИР_Условия_платежа")]
        public string VIR_PAY_CONDITIONS { set; get; }

        [Column("Инициатор_ФИО")]
        public string INITIATOR_FIO { set; get; }

        [Column("Ответственный_ФИО")]
        public string RESPONSIBLE_FIO { set; get; }

        [Column("Этап")]
        public string STAGE { set; get; }

        [Column("PR_Номер")]
        public string PR_N { set; get; }

        [Column("PR_статус")]
        public string PR_STATUS { set; get; }

        [Column("PR_Комментарий")]
        public string PR_COM { set; get; }

        [Column("СЭВД")]
        public string SEVD { set; get; }

        [Column("СЭВД_Номер")]
        public string SEVD_N { set; get; }

        [Column("ЕСМ_ссылка")]
        public string ECM_LINK { set; get; }

        [Column("ДС_Дата")]
        public string DS_DATE { set; get; }

        [Column("ГФК")]
        public string GFK { set; get; }

        [Column("ВИР_Начало_работ")]
        public string VIR_START_WORK { set; get; }

        [Column("ВИР_Завершение_работ")]
        public string VIR_END_WORK { set; get; }

        [Column("ВИР_Дата_интеграции")]
        public string VIR_INTEGRATION_DATE { set; get; }

        [Column("Диадок_Дата_загрузки")]
        public string DIADOK_UPLOAD_DATE { set; get; }

        [Column("Диадок_Дата_подписания")]
        public string DIADOK_SIGN_DATE { set; get; }

        [Column("IMS_ссылка")]
        public string IMS_LINK { set; get; }

        [Column("Диадок_ID")]
        public string DIADOK_ID { set; get; }

        [Column("Диадок_ссылка")]
        public string DIADOK_LINK { set; get; }

        [Column("NRI_Код_проекта")]
        public string NRI_CODE_PROJECT { set; get; }

        [Column("Контракт_номер")]
        public string CONTRACT_N { set; get; }

        [Column("Договор_номер")]
        public string DOG_N { set; get; }

        [Column("Договор_дата")]
        public string DOG_DATE { set; get; }

        [Column("Инициатор_почта")]
        public string INITIATOR_MAIL { set; get; }

        [Column("Поставщик_ИНН")]
        public string PROVIDER_INN { set; get; }

        [Column("Ошибка1")]
        public string ERROR1 { set; get; }

        [Column("Ошибка2")]
        public string ERROR2 { set; get; }

        [Column("Тех_Ошибка")]
        public string TECH_ERROR { set; get; }

        [Column("Статус")]
        public string STATUS { set; get; }

        [Column("Обработка")]
        public string PROCESSING { set; get; }

        [Column("География")]
        public string GEO { set; get; }

        [Column("ЗП_Номер")]
        public string ZP_N { set; get; }

        [Column("ЗП_Статус")]
        public string ZP_STATUS { set; get; }

        [Column("БД_комментарий")]
        public string BD_COM { set; get; }

        [Column("PR_файл")]
        public string PR_FILE { set; get; }

        [Column("ВИР_комментарий")]
        public string VIR_COM { set; get; }

        [Column("Дубль")]
        public string DOUBLE { set; get; }

        [Column("ВИР_Диапазоны")]
        public string VIR_DIAP { set; get; }

        [Column("Проставление")]
        public string PROSTAVLENIE { set; get; }

        [Column("Дозаполнение_ЕСМ")]
        public string ECM_FILL { set; get; }

        [Column("Дополнение\\Расторжение")]
        public string REFILLING_TERMINATION { set; get; }

        [Column("RECEIVED_PORTAL")]
        public bool RECEIVED_PORTAL { set; get; }

        //public virtual string NRI_BS_NAME_FULL { set; get; }
        //public virtual string VIR_DOP_N_FULL { set; get; }
        //public virtual string PROVIDER_FULL { set; get; }
        //public virtual string INITIATOR_FIO_FULL { set; get; }
        //public virtual string RESPONSIBLE_FIO_FULL { set; get; }
        //public virtual string STATUS_FULL { set; get; }
    }
}
