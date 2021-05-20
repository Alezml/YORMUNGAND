using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class MainReportWave1FS
    {
        //[BindNever]
        
        public int page { set; get; }
        public int pagesize { set; get; }
        public int count { set; get; }
        public int countTotal { set; get; }
        public IEnumerable<MainReportWave1> data { set; get; }
        public List<MainReportWave1> list { set; get; }
        public int id { set; get; }
        public string NRI_LINK { set; get; }
        public string ZM_LOT { set; get; }
        public string REGION { set; get; }
        public List<SelectListItem> REGIONSELECT { set; get; }
        public string FILIAL { set; get; }
        public string NRI_BS_N { set; get; }
        public string NRI_BS_NAME { set; get; }
        public string DS_N { set; get; }
        public string PROVIDER { set; get; }
        public string VIR_DOC_TYPE { set; get; }
        public string VIR_DOP { set; get; }
        public string VIR_DOP_N { set; get; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime VIR_DATEfrom { set; get; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime VIR_DATEto { set; get; }
        public decimal VIR_SUMM_WO_NDSfrom { set; get; }
        public decimal VIR_SUMM_WO_NDSto { set; get; }
        public string VIR_PAY_CONDITIONS { set; get; }
        public string INITIATOR_FIO { set; get; }
        public string RESPONSIBLE_FIO { set; get; }
        public string STAGE { set; get; }
        public string PR_N { set; get; }
        public string PR_STATUS { set; get; }
        public string PR_COM { set; get; }
        public string SEVD { set; get; }
        public string SEVD_N { set; get; }
        public string ECM_LINK { set; get; }
        public string DS_DATE { set; get; }
        public string GFK { set; get; }
        public string VIR_START_WORK { set; get; }
        public string VIR_END_WORK { set; get; }
        public string VIR_INTEGRATION_DATE { set; get; }
        public string DIADOK_UPLOAD_DATE { set; get; }
        public string DIADOK_SIGN_DATE { set; get; }
        public string IMS_LINK { set; get; }
        public string DIADOK_ID { set; get; }
        public string DIADOK_LINK { set; get; }
        public string NRI_CODE_PROJECT { set; get; }
        public string CONTRACT_N { set; get; }
        public string DOG_N { set; get; }
        public string DOG_DATE { set; get; }
        public string INITIATOR_MAIL { set; get; }
        public string PROVIDER_INN { set; get; }
        public string ERROR1 { set; get; }
        public string ERROR2 { set; get; }
        public string TECH_ERROR { set; get; }
        public string STATUS { set; get; }
        public string PROCESSING { set; get; }
        public string GEO { set; get; }
        public string ZP_N { set; get; }
        public string ZP_STATUS { set; get; }
        public string BD_COM { set; get; }
        public string PR_FILE { set; get; }
        public string VIR_COM { set; get; }
        public string DOUBLE { set; get; }
        public string VIR_DIAP { set; get; }
        public string PROSTAVLENIE { set; get; }
        public string ECM_FILL { set; get; }
        public MainReportWave1FS()
        {
            this.pagesize = 50;
            this.page = 1;
            this.VIR_DATEto = DateTime.Now; // DateTime.Now;
            this.VIR_DATEfrom = new DateTime(2020, 1, 1); // new DateTime(2020, 1, 1);
            this.VIR_SUMM_WO_NDSto = 999999999;
        }
        public static MainReportWave1FS Check (MainReportWave1FS SearchParam)
        {
            if (SearchParam.page < 1)
                SearchParam.page = 1;

            if (SearchParam.pagesize < 1)
                SearchParam.pagesize = 50;

            //if (SearchParam.NRI_LINK == "" || SearchParam.NRI_LINK == null)
            //    SearchParam.NRI_LINK = "%";

            //if (SearchParam.ZM_LOT == "" || SearchParam.ZM_LOT == null)
            //    SearchParam.ZM_LOT = "%";

            //if (SearchParam.REGION == "" || SearchParam.REGION == null)
            //    SearchParam.REGION = "%";

            //if (SearchParam.FILIAL == "" || SearchParam.FILIAL == null)
            //    SearchParam.FILIAL = "%";

            //if (SearchParam.NRI_BS_N == "" || SearchParam.NRI_BS_N == null)
            //    SearchParam.NRI_BS_N = "%";

            //if (SearchParam.NRI_BS_NAME == "" || SearchParam.NRI_BS_NAME == null)
            //    SearchParam.NRI_BS_NAME = "%";

            //if (SearchParam.DS_N == "" || SearchParam.DS_N == null)
            //    SearchParam.DS_N = "%";

            //if (SearchParam.PROVIDER == "" || SearchParam.PROVIDER == null)
            //    SearchParam.PROVIDER = "%";

            //if (SearchParam.VIR_DOC_TYPE == "" || SearchParam.VIR_DOC_TYPE == null)
            //    SearchParam.VIR_DOC_TYPE = "%";

            //if (SearchParam.VIR_DOP == "" || SearchParam.VIR_DOP == null)
            //    SearchParam.VIR_DOP = "%";

            //if (SearchParam.VIR_DOP_N == "" || SearchParam.VIR_DOP_N == null)
            //    SearchParam.VIR_DOP_N = "%";

            //if (SearchParam.VIR_PAY_CONDITIONS == "" || SearchParam.VIR_PAY_CONDITIONS == null)
            //    SearchParam.VIR_PAY_CONDITIONS = "%";

            //if (SearchParam.INITIATOR_FIO == "" || SearchParam.INITIATOR_FIO == null)
            //    SearchParam.INITIATOR_FIO = "%";

            //if (SearchParam.RESPONSIBLE_FIO == "" || SearchParam.RESPONSIBLE_FIO == null)
            //    SearchParam.RESPONSIBLE_FIO = "%";

            //if (SearchParam.STAGE == "" || SearchParam.STAGE == null)
            //    SearchParam.STAGE = "%";

            //if (SearchParam.PR_N == "" || SearchParam.PR_N == null)
            //    SearchParam.PR_N = "%";

            //if (SearchParam.PR_STATUS == "" || SearchParam.PR_STATUS == null)
            //    SearchParam.PR_STATUS = "%";

            //if (SearchParam.PR_COM == "" || SearchParam.PR_COM == null)
            //    SearchParam.PR_COM = "%";

            //if (SearchParam.SEVD == "" || SearchParam.SEVD == null)
            //    SearchParam.SEVD = "%";

            //if (SearchParam.SEVD_N == "" || SearchParam.SEVD_N == null)
            //    SearchParam.SEVD_N = "%";

            //if (SearchParam.ECM_LINK == "" || SearchParam.ECM_LINK == null)
            //    SearchParam.ECM_LINK = "%";

            //if (SearchParam.DS_DATE == "" || SearchParam.DS_DATE == null)
            //    SearchParam.DS_DATE = "%";

            //if (SearchParam.GFK == "" || SearchParam.GFK == null)
            //    SearchParam.GFK = "%";

            //if (SearchParam.VIR_START_WORK == "" || SearchParam.VIR_START_WORK == null)
            //    SearchParam.VIR_START_WORK = "%";

            //if (SearchParam.VIR_END_WORK == "" || SearchParam.VIR_END_WORK == null)
            //    SearchParam.VIR_END_WORK = "%";

            //if (SearchParam.VIR_INTEGRATION_DATE == "" || SearchParam.VIR_INTEGRATION_DATE == null)
            //    SearchParam.VIR_INTEGRATION_DATE = "%";

            //if (SearchParam.DIADOK_UPLOAD_DATE == "" || SearchParam.DIADOK_UPLOAD_DATE == null)
            //    SearchParam.DIADOK_UPLOAD_DATE = "%";

            //if (SearchParam.DIADOK_SIGN_DATE == "" || SearchParam.DIADOK_SIGN_DATE == null)
            //    SearchParam.DIADOK_SIGN_DATE = "%";

            //if (SearchParam.IMS_LINK == "" || SearchParam.IMS_LINK == null)
            //    SearchParam.IMS_LINK = "%";

            //if (SearchParam.DIADOK_ID == "" || SearchParam.DIADOK_ID == null)
            //    SearchParam.DIADOK_ID = "%";

            //if (SearchParam.DIADOK_LINK == "" || SearchParam.DIADOK_LINK == null)
            //    SearchParam.DIADOK_LINK = "%";

            //if (SearchParam.NRI_CODE_PROJECT == "" || SearchParam.NRI_CODE_PROJECT == null)
            //    SearchParam.NRI_CODE_PROJECT = "%";

            //if (SearchParam.CONTRACT_N == "" || SearchParam.CONTRACT_N == null)
            //    SearchParam.CONTRACT_N = "%";

            //if (SearchParam.DOG_N == "" || SearchParam.DOG_N == null)
            //    SearchParam.DOG_N = "";

            //if (SearchParam.DOG_DATE == "" || SearchParam.DOG_DATE == null)
            //    SearchParam.DOG_DATE = "%";

            //if (SearchParam.INITIATOR_MAIL == "" || SearchParam.INITIATOR_MAIL == null)
            //    SearchParam.INITIATOR_MAIL = "%";

            //if (SearchParam.PROVIDER_INN == "" || SearchParam.PROVIDER_INN == null)
            //    SearchParam.PROVIDER_INN = "%";

            //if (SearchParam.ERROR1 == "" || SearchParam.ERROR1 == null)
            //    SearchParam.ERROR1 = "%";

            //if (SearchParam.ERROR2 == "" || SearchParam.ERROR2 == null)
            //    SearchParam.ERROR2 = "%";

            //if (SearchParam.TECH_ERROR == "" || SearchParam.TECH_ERROR == null)
            //    SearchParam.TECH_ERROR = "%";

            //if (SearchParam.STATUS == "" || SearchParam.STATUS == null)
            //    SearchParam.STATUS = "%";

            //if (SearchParam.PROCESSING == "" || SearchParam.PROCESSING == null)
            //    SearchParam.PROCESSING = "%";

            //if (SearchParam.GEO == "" || SearchParam.GEO == null)
            //    SearchParam.GEO = "%";

            //if (SearchParam.ZP_N == "" || SearchParam.ZP_N == null)
            //    SearchParam.ZP_N = "%";

            //if (SearchParam.ZP_STATUS == "" || SearchParam.ZP_STATUS == null)
            //    SearchParam.ZP_STATUS = "%";

            //if (SearchParam.BD_COM == "" || SearchParam.BD_COM == null)
            //    SearchParam.BD_COM = "%";

            //if (SearchParam.PR_FILE == "" || SearchParam.PR_FILE == null)
            //    SearchParam.PR_FILE = "%";

            //if (SearchParam.VIR_COM == "" || SearchParam.VIR_COM == null)
            //    SearchParam.VIR_COM = "%";

            //if (SearchParam.DOUBLE == "" || SearchParam.DOUBLE == null)
            //    SearchParam.DOUBLE = "%";

            //if (SearchParam.VIR_DIAP == "" || SearchParam.VIR_DIAP == null)
            //    SearchParam.VIR_DIAP = "%";

            //if (SearchParam.PROSTAVLENIE == "" || SearchParam.PROSTAVLENIE == null)
            //    SearchParam.PROSTAVLENIE = "%";

            //if (SearchParam.ECM_FILL == "" || SearchParam.ECM_FILL == null)
            //    SearchParam.ECM_FILL = "%";
            return SearchParam;
        }
        //public static MainReportWave1FS UnCheck(MainReportWave1FS SearchParam)
        //{

        //    if (SearchParam.NRI_LINK == "%")
        //        SearchParam.NRI_LINK = null;

        //    if (SearchParam.ZM_LOT == "%")
        //        SearchParam.ZM_LOT = null;

        //    if (SearchParam.REGION == "%")
        //        SearchParam.REGION = null;

        //    if (SearchParam.FILIAL == "%")
        //        SearchParam.FILIAL = null;

        //    if (SearchParam.NRI_BS_N == "%")
        //        SearchParam.NRI_BS_N = null;

        //    if (SearchParam.NRI_BS_NAME == "%")
        //        SearchParam.NRI_BS_NAME = null;

        //    if (SearchParam.DS_N == "%")
        //        SearchParam.DS_N = null;

        //    if (SearchParam.PROVIDER == "%")
        //        SearchParam.PROVIDER = null;

        //    if (SearchParam.VIR_DOC_TYPE == "%")
        //        SearchParam.VIR_DOC_TYPE = null;

        //    if (SearchParam.VIR_DOP == "%")
        //        SearchParam.VIR_DOP = null;

        //    if (SearchParam.VIR_DOP_N == "%")
        //        SearchParam.VIR_DOP_N = null;

        //    if (SearchParam.VIR_PAY_CONDITIONS == "%")
        //        SearchParam.VIR_PAY_CONDITIONS = null;

        //    if (SearchParam.INITIATOR_FIO == "%")
        //        SearchParam.INITIATOR_FIO = null;

        //    if (SearchParam.RESPONSIBLE_FIO == "%")
        //        SearchParam.RESPONSIBLE_FIO = null;

        //    if (SearchParam.STAGE == "%")
        //        SearchParam.STAGE = null;

        //    if (SearchParam.PR_N == "%")
        //        SearchParam.PR_N = null;

        //    if (SearchParam.PR_STATUS == "%")
        //        SearchParam.PR_STATUS = null;

        //    if (SearchParam.PR_COM == "%")
        //        SearchParam.PR_COM = null;

        //    if (SearchParam.SEVD == "%")
        //        SearchParam.SEVD = null;

        //    if (SearchParam.SEVD_N == "%")
        //        SearchParam.SEVD_N = null;

        //    if (SearchParam.ECM_LINK == "%")
        //        SearchParam.ECM_LINK = null;

        //    if (SearchParam.DS_DATE == "%")
        //        SearchParam.DS_DATE = null;

        //    if (SearchParam.GFK == "%")
        //        SearchParam.GFK = null;

        //    if (SearchParam.VIR_START_WORK == "%")
        //        SearchParam.VIR_START_WORK = null;

        //    if (SearchParam.VIR_END_WORK == "%")
        //        SearchParam.VIR_END_WORK = null;

        //    if (SearchParam.VIR_INTEGRATION_DATE == "%")
        //        SearchParam.VIR_INTEGRATION_DATE = null;

        //    if (SearchParam.DIADOK_UPLOAD_DATE == "%")
        //        SearchParam.DIADOK_UPLOAD_DATE = null;

        //    if (SearchParam.DIADOK_SIGN_DATE == "%")
        //        SearchParam.DIADOK_SIGN_DATE = null;

        //    if (SearchParam.IMS_LINK == "%")
        //        SearchParam.IMS_LINK = null;

        //    if (SearchParam.DIADOK_ID == "%")
        //        SearchParam.DIADOK_ID = null;

        //    if (SearchParam.DIADOK_LINK == "%")
        //        SearchParam.DIADOK_LINK = null;

        //    if (SearchParam.NRI_CODE_PROJECT == "%")
        //        SearchParam.NRI_CODE_PROJECT = null;

        //    if (SearchParam.CONTRACT_N == "%")
        //        SearchParam.CONTRACT_N = null;

        //    if (SearchParam.DOG_N == "%")
        //        SearchParam.DOG_N = null;

        //    if (SearchParam.DOG_DATE == "%")
        //        SearchParam.DOG_DATE = null;

        //    if (SearchParam.INITIATOR_MAIL == "%")
        //        SearchParam.INITIATOR_MAIL = null;

        //    if (SearchParam.PROVIDER_INN == "%")
        //        SearchParam.PROVIDER_INN = null;

        //    if (SearchParam.ERROR1 == "%")
        //        SearchParam.ERROR1 = null;

        //    if (SearchParam.ERROR2 == "%")
        //        SearchParam.ERROR2 = null;

        //    if (SearchParam.TECH_ERROR == "%")
        //        SearchParam.TECH_ERROR = null;

        //    if (SearchParam.STATUS == "%")
        //        SearchParam.STATUS = null;

        //    if (SearchParam.PROCESSING == "%")
        //        SearchParam.PROCESSING = null;

        //    if (SearchParam.GEO == "%")
        //        SearchParam.GEO = null;

        //    if (SearchParam.ZP_N == "%")
        //        SearchParam.ZP_N = null;

        //    if (SearchParam.ZP_STATUS == "%")
        //        SearchParam.ZP_STATUS = null;

        //    if (SearchParam.BD_COM == "%")
        //        SearchParam.BD_COM = null;

        //    if (SearchParam.PR_FILE == "%")
        //        SearchParam.PR_FILE = null;

        //    if (SearchParam.VIR_COM == "%")
        //        SearchParam.VIR_COM = null;

        //    if (SearchParam.DOUBLE == "%")
        //        SearchParam.DOUBLE = null;

        //    if (SearchParam.VIR_DIAP == "%")
        //        SearchParam.VIR_DIAP = null;

        //    if (SearchParam.PROSTAVLENIE == "%")
        //        SearchParam.PROSTAVLENIE = null;

        //    if (SearchParam.ECM_FILL == "%")
        //        SearchParam.ECM_FILL = null;
        //    return SearchParam;
        //}
    }
}
