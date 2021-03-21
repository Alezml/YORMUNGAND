//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;

//namespace YORMUNGAND.Data.Models
//{
//    public class MainReportWave1FS
//    {
//        //[BindNever]
        
//        public int page { set; get; }
//        public int pagesize { set; get; }
//        public IEnumerable<MainReportWave1> data { set; get; }
//        public int id { set; get; }
//        public string NRI_LINK { set; get; }
//        public string ZM_LOT { set; get; }
//        public string REGION { set; get; }
//        public string FILIAL { set; get; }
//        public string NRI_BS_N { set; get; }
//        public string NRI_BS_NAME { set; get; }
//        public string DS_N { set; get; }
//        public string PROVIDER { set; get; }
//        public string VIR_DOC_TYPE { set; get; }
//        public string VIR_DOP { set; get; }
//        public string VIR_DOP_N { set; get; }
//        public DateTime VIR_DATEfrom { set; get; }
//        public DateTime VIR_DATEto { set; get; }
//        public decimal VIR_SUMM_WO_NDSfrom { set; get; }
//        public decimal VIR_SUMM_WO_NDSto { set; get; }
//        public string VIR_PAY_CONDITIONS { set; get; }
//        public string INITIATOR_FIO { set; get; }
//        public string RESPONSIBLE_FIO { set; get; }
//        public string STAGE { set; get; }
//        public string PR_N { set; get; }
//        public string PR_STATUS { set; get; }
//        public string PR_COM { set; get; }
//        public string SEVD { set; get; }
//        public string SEVD_N { set; get; }
//        public string ECM_LINK { set; get; }
//        public string DS_DATE { set; get; }
//        public string GFK { set; get; }
//        public string VIR_START_WORK { set; get; }
//        public string VIR_END_WORK { set; get; }
//        public string VIR_INTEGRATION_DATE { set; get; }
//        public string DIADOK_UPLOAD_DATE { set; get; }
//        public string DIADOK_SIGN_DATE { set; get; }
//        public string IMS_LINK { set; get; }
//        public string DIADOK_ID { set; get; }
//        public string DIADOK_LINK { set; get; }
//        public string NRI_CODE_PROJECT { set; get; }
//        public string CONTRACT_N { set; get; }
//        public string DOG_N { set; get; }
//        public string DOG_DATE { set; get; }
//        public string INITIATOR_MAIL { set; get; }
//        public string PROVIDER_INN { set; get; }
//        public string ERROR1 { set; get; }
//        public string ERROR2 { set; get; }
//        public string TECH_ERROR { set; get; }
//        public string STATUS { set; get; }
//        public string PROCESSING { set; get; }
//        public string GEO { set; get; }
//        public string ZP_N { set; get; }
//        public string ZP_STATUS { set; get; }
//        public string BD_COM { set; get; }
//        public string PR_FILE { set; get; }
//        public string VIR_COM { set; get; }
//        public string DOUBLE { set; get; }
//        public string VIR_DIAP { set; get; }
//        public string PROSTAVLENIE { set; get; }
//        public string ECM_FILL { set; get; }
//        public MainReportWave1FS()
//        {
//            this.pagesize = 100;
//            this.page = 1;
//            this.VIR_DATEto = DateTime.Now;
//            this.VIR_DATEfrom = new DateTime(2020, 1, 1);
//            this.VIR_SUMM_WO_NDSto = 999999999;
//        }
//        public static MainReportWave1FS Check (MainReportWave1FS SearchParam)
//        {
//            MainReportWave1FS Check = new MainReportWave1FS();
//            if (SearchParam.page < 1)
//                Check.page = 1;
//            else
//                Check.page = SearchParam.page;

//            if (SearchParam.pagesize < 1)
//                Check.pagesize = 100;
//            else
//                Check.pagesize = SearchParam.pagesize;

//            if (SearchParam.NRI_LINK == "")
//                Check.NRI_LINK = "%";
//            else
//                Check.NRI_LINK = SearchParam.NRI_LINK;

//            if (SearchParam.ZM_LOT == "")
//                Check.ZM_LOT = "%";
//            else
//                Check.ZM_LOT = SearchParam.ZM_LOT;

//            if (SearchParam.REGION == "")
//                Check.REGION = "%";
//            else
//                Check.REGION = SearchParam.REGION;

//            if (SearchParam.FILIAL == "")
//                Check.FILIAL = "%";
//            else
//                Check.FILIAL = SearchParam.FILIAL;

//            if (SearchParam.NRI_BS_N == "")
//                Check.NRI_BS_N = "%";
//            else
//                Check.NRI_BS_N = SearchParam.NRI_BS_N;

//            if (SearchParam.NRI_BS_NAME == "")
//                Check.NRI_BS_NAME = "%";
//            else
//                Check.NRI_BS_NAME = SearchParam.NRI_BS_NAME;

//            if (SearchParam.DS_N == "")
//                Check.DS_N = "%";
//            else
//                Check.DS_N = SearchParam.DS_N;

//            if (SearchParam.PROVIDER == "")
//                Check.PROVIDER = "%";
//            else
//                Check.PROVIDER = SearchParam.PROVIDER;

//            if (SearchParam.VIR_DOC_TYPE == "")
//                Check.VIR_DOC_TYPE = "%";
//            else
//                Check.VIR_DOC_TYPE = SearchParam.VIR_DOC_TYPE;

//            if (SearchParam.VIR_DOP == "")
//                Check.VIR_DOP = "%";
//            else
//                Check.VIR_DOP = SearchParam.VIR_DOP;

//            if (SearchParam.VIR_DOP_N == "")
//                Check.VIR_DOP_N = "%";
//            else
//                Check.VIR_DOP_N = SearchParam.VIR_DOP_N;

//            if (SearchParam.VIR_PAY_CONDITIONS == "")
//                Check.VIR_PAY_CONDITIONS = "%";
//            else
//                Check.VIR_PAY_CONDITIONS = SearchParam.VIR_PAY_CONDITIONS;

//            if (SearchParam.INITIATOR_FIO == "")
//                Check.INITIATOR_FIO = "%";
//            else
//                Check.INITIATOR_FIO = SearchParam.INITIATOR_FIO;

//            if (SearchParam.RESPONSIBLE_FIO == "")
//                Check.RESPONSIBLE_FIO = "%";
//            else
//                Check.RESPONSIBLE_FIO = SearchParam.RESPONSIBLE_FIO;

//            if (SearchParam.STAGE == "")
//                Check.STAGE = "%";
//            else
//                Check.STAGE = SearchParam.STAGE;

//            if (SearchParam.PR_N == "")
//                Check.PR_N = "%";
//            else
//                Check.PR_N = SearchParam.PR_N;

//            if (SearchParam.PR_STATUS == "")
//                Check.PR_STATUS = "%";
//            else
//                Check.PR_STATUS = SearchParam.PR_STATUS;

//            if (SearchParam.PR_COM == "")
//                Check.PR_COM = "%";
//            else
//                Check.PR_COM = SearchParam.PR_COM;

//            if (SearchParam.SEVD == "")
//                Check.SEVD = "%";
//            else
//                Check.SEVD = SearchParam.SEVD;

//            if (SearchParam.SEVD_N == "")
//                Check.SEVD_N = "%";
//            else
//                Check.SEVD_N = SearchParam.SEVD_N;

//            if (SearchParam.ECM_LINK == "")
//                Check.ECM_LINK = "%";
//            else
//                Check.ECM_LINK = SearchParam.ECM_LINK;

//            if (SearchParam.DS_DATE == "")
//                Check.DS_DATE = "%";
//            else
//                Check.DS_DATE = SearchParam.DS_DATE;

//            if (SearchParam.GFK == "")
//                Check.GFK = "%";
//            else
//                Check.GFK = SearchParam.GFK;

//            if (SearchParam.VIR_START_WORK == "")
//                Check.VIR_START_WORK = "%";
//            else
//                Check.VIR_START_WORK = SearchParam.VIR_START_WORK;

//            if (SearchParam.VIR_END_WORK == "")
//                Check.VIR_END_WORK = "%";
//            else
//                Check.VIR_END_WORK = SearchParam.VIR_END_WORK;

//            if (SearchParam.VIR_INTEGRATION_DATE == "")
//                Check.VIR_INTEGRATION_DATE = "%";
//            else
//                Check.VIR_INTEGRATION_DATE = SearchParam.VIR_INTEGRATION_DATE;

//            if (SearchParam.DIADOK_UPLOAD_DATE == "")
//                Check.DIADOK_UPLOAD_DATE = "%";
//            else
//                Check.DIADOK_UPLOAD_DATE = SearchParam.DIADOK_UPLOAD_DATE;

//            if (SearchParam.DIADOK_SIGN_DATE == "")
//                Check.DIADOK_SIGN_DATE = "%";
//            else
//                Check.DIADOK_SIGN_DATE = SearchParam.DIADOK_SIGN_DATE;

//            if (SearchParam.IMS_LINK == "")
//                Check.IMS_LINK = "%";
//            else
//                Check.IMS_LINK = SearchParam.IMS_LINK;

//            if (SearchParam.DIADOK_ID == "")
//                Check.DIADOK_ID = "%";
//            else
//                Check.DIADOK_ID = SearchParam.DIADOK_ID;

//            if (SearchParam.DIADOK_LINK == "")
//                Check.DIADOK_LINK = "%";
//            else
//                Check.DIADOK_LINK = SearchParam.DIADOK_LINK;

//            if (SearchParam.NRI_CODE_PROJECT == "")
//                Check.NRI_CODE_PROJECT = "%";
//            else
//                Check.NRI_CODE_PROJECT = SearchParam.NRI_CODE_PROJECT;

//            if (SearchParam.CONTRACT_N == "")
//                Check.CONTRACT_N = "%";
//            else
//                Check.CONTRACT_N = SearchParam.CONTRACT_N;

//            if (SearchParam.DOG_N == "")
//                Check.DOG_N = "%";
//            else
//                Check.DOG_N = SearchParam.DOG_N;

//            if (SearchParam.DOG_DATE == "")
//                Check.DOG_DATE = "%";
//            else
//                Check.DOG_DATE = SearchParam.DOG_DATE;

//            if (SearchParam.INITIATOR_MAIL == "")
//                Check.INITIATOR_MAIL = "%";
//            else
//                Check.INITIATOR_MAIL = SearchParam.INITIATOR_MAIL;

//            if (SearchParam.PROVIDER_INN == "")
//                Check.PROVIDER_INN = "%";
//            else
//                Check.PROVIDER_INN = SearchParam.PROVIDER_INN;

//            if (SearchParam.ERROR1 == "")
//                Check.ERROR1 = "%";
//            else
//                Check.ERROR1 = SearchParam.ERROR1;

//            if (SearchParam.ERROR2 == "")
//                Check.ERROR2 = "%";
//            else
//                Check.ERROR2 = SearchParam.ERROR2;

//            if (SearchParam.TECH_ERROR == "")
//                Check.TECH_ERROR = "%";
//            else
//                Check.TECH_ERROR = SearchParam.TECH_ERROR;

//            if (SearchParam.STATUS == "")
//                Check.STATUS = "%";
//            else
//                Check.STATUS = SearchParam.STATUS;

//            if (SearchParam.PROCESSING == "")
//                Check.PROCESSING = "%";
//            else
//                Check.PROCESSING = SearchParam.PROCESSING;

//            if (SearchParam.GEO == "")
//                Check.GEO = "%";
//            else
//                Check.GEO = SearchParam.GEO;

//            if (SearchParam.ZP_N == "")
//                Check.ZP_N = "%";
//            else
//                Check.ZP_N = SearchParam.ZP_N;

//            if (SearchParam.ZP_STATUS == "")
//                Check.ZP_STATUS = "%";
//            else
//                Check.ZP_STATUS = SearchParam.ZP_STATUS;

//            if (SearchParam.BD_COM == "")
//                Check.BD_COM = "%";
//            else
//                Check.BD_COM = SearchParam.BD_COM;

//            if (SearchParam.PR_FILE == "")
//                Check.PR_FILE = "%";
//            else
//                Check.PR_FILE = SearchParam.PR_FILE;

//            if (SearchParam.VIR_COM == "")
//                Check.VIR_COM = "%";
//            else
//                Check.VIR_COM = SearchParam.VIR_COM;

//            if (SearchParam.DOUBLE == "")
//                Check.DOUBLE = "%";
//            else
//                Check.DOUBLE = SearchParam.DOUBLE;

//            if (SearchParam.VIR_DIAP == "")
//                Check.VIR_DIAP = "%";
//            else
//                Check.VIR_DIAP = SearchParam.VIR_DIAP;

//            if (SearchParam.PROSTAVLENIE == "")
//                Check.PROSTAVLENIE = "%";
//            else
//                Check.PROSTAVLENIE = SearchParam.PROSTAVLENIE;

//            if (SearchParam.ECM_FILL == "")
//                Check.ECM_FILL = "%";
//            else
//                Check.ECM_FILL = SearchParam.ECM_FILL;
//            return Check;
//        }
//        public static MainReportWave1FS UnCheck(MainReportWave1FS SearchParam)
//        {
//            MainReportWave1FS UnCheck = new MainReportWave1FS();
//            if (SearchParam.page < 1)
//                UnCheck.page = 1;
//            else
//                UnCheck.page = SearchParam.page;

//            if (SearchParam.pagesize < 1)
//                UnCheck.pagesize = 100;
//            else
//                UnCheck.pagesize = SearchParam.pagesize;

//            if (SearchParam.NRI_LINK == "%")
//                UnCheck.NRI_LINK = "";
//            else
//                UnCheck.NRI_LINK = SearchParam.NRI_LINK;

//            if (SearchParam.ZM_LOT == "%")
//                UnCheck.ZM_LOT = "";
//            else
//                UnCheck.ZM_LOT = SearchParam.ZM_LOT;

//            if (SearchParam.REGION == "%")
//                UnCheck.REGION = "";
//            else
//                UnCheck.REGION = SearchParam.REGION;

//            if (SearchParam.FILIAL == "%")
//                UnCheck.FILIAL = "";
//            else
//                UnCheck.FILIAL = SearchParam.FILIAL;

//            if (SearchParam.NRI_BS_N == "%")
//                UnCheck.NRI_BS_N = "";
//            else
//                UnCheck.NRI_BS_N = SearchParam.NRI_BS_N;

//            if (SearchParam.NRI_BS_NAME == "%")
//                UnCheck.NRI_BS_NAME = "";
//            else
//                UnCheck.NRI_BS_NAME = SearchParam.NRI_BS_NAME;

//            if (SearchParam.DS_N == "%")
//                UnCheck.DS_N = "";
//            else
//                UnCheck.DS_N = SearchParam.DS_N;

//            if (SearchParam.PROVIDER == "%")
//                UnCheck.PROVIDER = "";
//            else
//                UnCheck.PROVIDER = SearchParam.PROVIDER;

//            if (SearchParam.VIR_DOC_TYPE == "%")
//                UnCheck.VIR_DOC_TYPE = "";
//            else
//                UnCheck.VIR_DOC_TYPE = SearchParam.VIR_DOC_TYPE;

//            if (SearchParam.VIR_DOP == "%")
//                UnCheck.VIR_DOP = "";
//            else
//                UnCheck.VIR_DOP = SearchParam.VIR_DOP;

//            if (SearchParam.VIR_DOP_N == "%")
//                UnCheck.VIR_DOP_N = "";
//            else
//                UnCheck.VIR_DOP_N = SearchParam.VIR_DOP_N;

//            if (SearchParam.VIR_PAY_CONDITIONS == "%")
//                UnCheck.VIR_PAY_CONDITIONS = "";
//            else
//                UnCheck.VIR_PAY_CONDITIONS = SearchParam.VIR_PAY_CONDITIONS;

//            if (SearchParam.INITIATOR_FIO == "%")
//                UnCheck.INITIATOR_FIO = "";
//            else
//                UnCheck.INITIATOR_FIO = SearchParam.INITIATOR_FIO;

//            if (SearchParam.RESPONSIBLE_FIO == "%")
//                UnCheck.RESPONSIBLE_FIO = "";
//            else
//                UnCheck.RESPONSIBLE_FIO = SearchParam.RESPONSIBLE_FIO;

//            if (SearchParam.STAGE == "%")
//                UnCheck.STAGE = "";
//            else
//                UnCheck.STAGE = SearchParam.STAGE;

//            if (SearchParam.PR_N == "%")
//                UnCheck.PR_N = "";
//            else
//                UnCheck.PR_N = SearchParam.PR_N;

//            if (SearchParam.PR_STATUS == "%")
//                UnCheck.PR_STATUS = "";
//            else
//                UnCheck.PR_STATUS = SearchParam.PR_STATUS;

//            if (SearchParam.PR_COM == "%")
//                UnCheck.PR_COM = "";
//            else
//                UnCheck.PR_COM = SearchParam.PR_COM;

//            if (SearchParam.SEVD == "%")
//                UnCheck.SEVD = "";
//            else
//                UnCheck.SEVD = SearchParam.SEVD;

//            if (SearchParam.SEVD_N == "%")
//                UnCheck.SEVD_N = "";
//            else
//                UnCheck.SEVD_N = SearchParam.SEVD_N;

//            if (SearchParam.ECM_LINK == "%")
//                UnCheck.ECM_LINK = "";
//            else
//                UnCheck.ECM_LINK = SearchParam.ECM_LINK;

//            if (SearchParam.DS_DATE == "%")
//                UnCheck.DS_DATE = "";
//            else
//                UnCheck.DS_DATE = SearchParam.DS_DATE;

//            if (SearchParam.GFK == "%")
//                UnCheck.GFK = "";
//            else
//                UnCheck.GFK = SearchParam.GFK;

//            if (SearchParam.VIR_START_WORK == "%")
//                UnCheck.VIR_START_WORK = "";
//            else
//                UnCheck.VIR_START_WORK = SearchParam.VIR_START_WORK;

//            if (SearchParam.VIR_END_WORK == "%")
//                UnCheck.VIR_END_WORK = "";
//            else
//                UnCheck.VIR_END_WORK = SearchParam.VIR_END_WORK;

//            if (SearchParam.VIR_INTEGRATION_DATE == "%")
//                UnCheck.VIR_INTEGRATION_DATE = "";
//            else
//                UnCheck.VIR_INTEGRATION_DATE = SearchParam.VIR_INTEGRATION_DATE;

//            if (SearchParam.DIADOK_UPLOAD_DATE == "%")
//                UnCheck.DIADOK_UPLOAD_DATE = "";
//            else
//                UnCheck.DIADOK_UPLOAD_DATE = SearchParam.DIADOK_UPLOAD_DATE;

//            if (SearchParam.DIADOK_SIGN_DATE == "%")
//                UnCheck.DIADOK_SIGN_DATE = "";
//            else
//                UnCheck.DIADOK_SIGN_DATE = SearchParam.DIADOK_SIGN_DATE;

//            if (SearchParam.IMS_LINK == "%")
//                UnCheck.IMS_LINK = "";
//            else
//                UnCheck.IMS_LINK = SearchParam.IMS_LINK;

//            if (SearchParam.DIADOK_ID == "%")
//                UnCheck.DIADOK_ID = "";
//            else
//                UnCheck.DIADOK_ID = SearchParam.DIADOK_ID;

//            if (SearchParam.DIADOK_LINK == "%")
//                UnCheck.DIADOK_LINK = "";
//            else
//                UnCheck.DIADOK_LINK = SearchParam.DIADOK_LINK;

//            if (SearchParam.NRI_CODE_PROJECT == "%")
//                UnCheck.NRI_CODE_PROJECT = "";
//            else
//                UnCheck.NRI_CODE_PROJECT = SearchParam.NRI_CODE_PROJECT;

//            if (SearchParam.CONTRACT_N == "%")
//                UnCheck.CONTRACT_N = "";
//            else
//                UnCheck.CONTRACT_N = SearchParam.CONTRACT_N;

//            if (SearchParam.DOG_N == "%")
//                UnCheck.DOG_N = "";
//            else
//                UnCheck.DOG_N = SearchParam.DOG_N;

//            if (SearchParam.DOG_DATE == "%")
//                UnCheck.DOG_DATE = "";
//            else
//                UnCheck.DOG_DATE = SearchParam.DOG_DATE;

//            if (SearchParam.INITIATOR_MAIL == "%")
//                UnCheck.INITIATOR_MAIL = "";
//            else
//                UnCheck.INITIATOR_MAIL = SearchParam.INITIATOR_MAIL;

//            if (SearchParam.PROVIDER_INN == "%")
//                UnCheck.PROVIDER_INN = "";
//            else
//                UnCheck.PROVIDER_INN = SearchParam.PROVIDER_INN;

//            if (SearchParam.ERROR1 == "%")
//                UnCheck.ERROR1 = "";
//            else
//                UnCheck.ERROR1 = SearchParam.ERROR1;

//            if (SearchParam.ERROR2 == "%")
//                UnCheck.ERROR2 = "";
//            else
//                UnCheck.ERROR2 = SearchParam.ERROR2;

//            if (SearchParam.TECH_ERROR == "%")
//                UnCheck.TECH_ERROR = "";
//            else
//                UnCheck.TECH_ERROR = SearchParam.TECH_ERROR;

//            if (SearchParam.STATUS == "%")
//                UnCheck.STATUS = "";
//            else
//                UnCheck.STATUS = SearchParam.STATUS;

//            if (SearchParam.PROCESSING == "%")
//                UnCheck.PROCESSING = "";
//            else
//                UnCheck.PROCESSING = SearchParam.PROCESSING;

//            if (SearchParam.GEO == "%")
//                UnCheck.GEO = "";
//            else
//                UnCheck.GEO = SearchParam.GEO;

//            if (SearchParam.ZP_N == "%")
//                UnCheck.ZP_N = "";
//            else
//                UnCheck.ZP_N = SearchParam.ZP_N;

//            if (SearchParam.ZP_STATUS == "%")
//                UnCheck.ZP_STATUS = "";
//            else
//                UnCheck.ZP_STATUS = SearchParam.ZP_STATUS;

//            if (SearchParam.BD_COM == "%")
//                UnCheck.BD_COM = "";
//            else
//                UnCheck.BD_COM = SearchParam.BD_COM;

//            if (SearchParam.PR_FILE == "%")
//                UnCheck.PR_FILE = "";
//            else
//                UnCheck.PR_FILE = SearchParam.PR_FILE;

//            if (SearchParam.VIR_COM == "%")
//                UnCheck.VIR_COM = "";
//            else
//                UnCheck.VIR_COM = SearchParam.VIR_COM;

//            if (SearchParam.DOUBLE == "%")
//                UnCheck.DOUBLE = "";
//            else
//                UnCheck.DOUBLE = SearchParam.DOUBLE;

//            if (SearchParam.VIR_DIAP == "%")
//                UnCheck.VIR_DIAP = "";
//            else
//                UnCheck.VIR_DIAP = SearchParam.VIR_DIAP;

//            if (SearchParam.PROSTAVLENIE == "%")
//                UnCheck.PROSTAVLENIE = "";
//            else
//                UnCheck.PROSTAVLENIE = SearchParam.PROSTAVLENIE;

//            if (SearchParam.ECM_FILL == "%")
//                UnCheck.ECM_FILL = "";
//            else
//                UnCheck.ECM_FILL = SearchParam.ECM_FILL;
//            return UnCheck;
//        }
//    }
//}
