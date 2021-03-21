using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;

namespace YORMUNGAND.Data.Repository
{
    public class CessReportRepository: ICessReport
    {
        private readonly CESSDBContent appDBContent;
        public CessReportRepository(CESSDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<MainReportWave1> MainReportWave1 { get; }
        public int MainReportWave1c(MainReportWave1FS SerchParam) =>
            appDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).Where(k1 =>
        k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto).Where(p =>
        EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL) || p.ECM_FILL == null).Where(p =>
        EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT) || p.ZM_LOT == null).Where(p =>
        EF.Functions.Like(p.REGION, SerchParam.REGION) || p.REGION == null).Where(p =>
        EF.Functions.Like(p.FILIAL, SerchParam.FILIAL) || p.FILIAL == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N) || p.NRI_BS_N == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME) || p.NRI_BS_NAME == null).Where(p =>
        EF.Functions.Like(p.DS_N, SerchParam.DS_N) || p.DS_N == null).Where(p =>
        EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER) || p.PROVIDER == null).Where(p =>
        EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE) || p.VIR_DOC_TYPE == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP) || p.VIR_DOP == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N) || p.VIR_DOP_N == null).Where(p =>
        EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS) || p.VIR_PAY_CONDITIONS == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO) || p.INITIATOR_FIO == null).Where(p =>
        EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO) || p.RESPONSIBLE_FIO == null).Where(p =>
        EF.Functions.Like(p.STAGE, SerchParam.STAGE) || p.STAGE == null).Where(p =>
        EF.Functions.Like(p.PR_N, SerchParam.PR_N) || p.PR_N == null).Where(p =>
        EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS) || p.PR_STATUS == null).Where(p =>
        EF.Functions.Like(p.PR_COM, SerchParam.PR_COM) || p.PR_COM == null).Where(p =>
        EF.Functions.Like(p.SEVD, SerchParam.SEVD) || p.SEVD == null).Where(p =>
        EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N) || p.SEVD_N == null).Where(p =>
        EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK) || p.ECM_LINK == null).Where(p =>
        EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE) || p.DS_DATE == null).Where(p =>
        EF.Functions.Like(p.GFK, SerchParam.GFK) || p.GFK == null).Where(p =>
        EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK) || p.VIR_START_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK) || p.VIR_END_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE) || p.VIR_INTEGRATION_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE) || p.DIADOK_UPLOAD_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE) || p.DIADOK_SIGN_DATE == null).Where(p =>
        EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK) || p.IMS_LINK == null).Where(p =>
        EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID) || p.DIADOK_ID == null).Where(p =>
        EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK) || p.DIADOK_LINK == null).Where(p =>
        EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT) || p.NRI_CODE_PROJECT == null).Where(p =>
        EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N) || p.CONTRACT_N == null).Where(p =>
        EF.Functions.Like(p.DOG_N, SerchParam.DOG_N) || p.DOG_N == null).Where(p =>
        EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE) || p.DOG_DATE == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL) || p.INITIATOR_MAIL == null).Where(p =>
        EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN) || p.PROVIDER_INN == null).Where(p =>
        EF.Functions.Like(p.ERROR1, SerchParam.ERROR1) || p.ERROR1 == null).Where(p =>
        EF.Functions.Like(p.ERROR2, SerchParam.ERROR2) || p.ERROR2 == null).Where(p =>
        EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR) || p.TECH_ERROR == null).Where(p =>
        EF.Functions.Like(p.STATUS, SerchParam.STATUS) || p.STATUS == null).Where(p =>
        EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING) || p.PROCESSING == null).Where(p =>
        EF.Functions.Like(p.GEO, SerchParam.GEO) || p.GEO == null).Where(p =>
        EF.Functions.Like(p.ZP_N, SerchParam.ZP_N) || p.ZP_N == null).Where(p =>
        EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS) || p.ZP_STATUS == null).Where(p =>
        EF.Functions.Like(p.BD_COM, SerchParam.BD_COM) || p.BD_COM == null).Where(p =>
        EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE) || p.PR_FILE == null).Where(p =>
        EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM) || p.VIR_COM == null).Where(p =>
        EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE) || p.DOUBLE == null).Where(p =>
        EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP) || p.VIR_DIAP == null).Where(p =>
        EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE) || p.PROSTAVLENIE == null).Where(p =>
        EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK) || p.NRI_LINK == null).Count();

        public IEnumerable<MainReportWave1> MainReportWave1s(MainReportWave1FS SerchParam) =>
            appDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).OrderBy(l => l.id).Where(k1 =>
        k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto).Where(p =>
        EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL) || p.ECM_FILL == null).Where(p =>
        EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT) || p.ZM_LOT == null).Where(p =>
        EF.Functions.Like(p.REGION, SerchParam.REGION) || p.REGION == null).Where(p =>
        EF.Functions.Like(p.FILIAL, SerchParam.FILIAL) || p.FILIAL == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N) || p.NRI_BS_N == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME) || p.NRI_BS_NAME == null).Where(p =>
        EF.Functions.Like(p.DS_N, SerchParam.DS_N) || p.DS_N == null).Where(p =>
        EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER) || p.PROVIDER == null).Where(p =>
        EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE) || p.VIR_DOC_TYPE == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP) || p.VIR_DOP == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N) || p.VIR_DOP_N == null).Where(p =>
        EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS) || p.VIR_PAY_CONDITIONS == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO) || p.INITIATOR_FIO == null).Where(p =>
        EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO) || p.RESPONSIBLE_FIO == null).Where(p =>
        EF.Functions.Like(p.STAGE, SerchParam.STAGE) || p.STAGE == null).Where(p =>
        EF.Functions.Like(p.PR_N, SerchParam.PR_N) || p.PR_N == null).Where(p =>
        EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS) || p.PR_STATUS == null).Where(p =>
        EF.Functions.Like(p.PR_COM, SerchParam.PR_COM) || p.PR_COM == null).Where(p =>
        EF.Functions.Like(p.SEVD, SerchParam.SEVD) || p.SEVD == null).Where(p =>
        EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N) || p.SEVD_N == null).Where(p =>
        EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK) || p.ECM_LINK == null).Where(p =>
        EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE) || p.DS_DATE == null).Where(p =>
        EF.Functions.Like(p.GFK, SerchParam.GFK) || p.GFK == null).Where(p =>
        EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK) || p.VIR_START_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK) || p.VIR_END_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE) || p.VIR_INTEGRATION_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE) || p.DIADOK_UPLOAD_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE) || p.DIADOK_SIGN_DATE == null).Where(p =>
        EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK) || p.IMS_LINK == null).Where(p =>
        EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID) || p.DIADOK_ID == null).Where(p =>
        EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK) || p.DIADOK_LINK == null).Where(p =>
        EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT) || p.NRI_CODE_PROJECT == null).Where(p =>
        EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N) || p.CONTRACT_N == null).Where(p =>
        EF.Functions.Like(p.DOG_N, SerchParam.DOG_N) || p.DOG_N == null).Where(p =>
        EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE) || p.DOG_DATE == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL) || p.INITIATOR_MAIL == null).Where(p =>
        EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN) || p.PROVIDER_INN == null).Where(p =>
        EF.Functions.Like(p.ERROR1, SerchParam.ERROR1) || p.ERROR1 == null).Where(p =>
        EF.Functions.Like(p.ERROR2, SerchParam.ERROR2) || p.ERROR2 == null).Where(p =>
        EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR) || p.TECH_ERROR == null).Where(p =>
        EF.Functions.Like(p.STATUS, SerchParam.STATUS) || p.STATUS == null).Where(p =>
        EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING) || p.PROCESSING == null).Where(p =>
        EF.Functions.Like(p.GEO, SerchParam.GEO) || p.GEO == null).Where(p =>
        EF.Functions.Like(p.ZP_N, SerchParam.ZP_N) || p.ZP_N == null).Where(p =>
        EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS) || p.ZP_STATUS == null).Where(p =>
        EF.Functions.Like(p.BD_COM, SerchParam.BD_COM) || p.BD_COM == null).Where(p =>
        EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE) || p.PR_FILE == null).Where(p =>
        EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM) || p.VIR_COM == null).Where(p =>
        EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE) || p.DOUBLE == null).Where(p =>
        EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP) || p.VIR_DIAP == null).Where(p =>
        EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE) || p.PROSTAVLENIE == null).Where(p =>
        EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK) || p.NRI_LINK == null).Skip((SerchParam.page - 1) * SerchParam.pagesize).Take(SerchParam.pagesize);
        
        //public IEnumerable<MainReportWave1> MainReportWave1s(MainReportWave1FS SerchParam) =>
        //    appDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).OrderBy(l => l.id).Where(k1 =>
        //k1.VIR_DATE >= SerchParam.VIR_DATEto).Where(k2 =>
        //k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(d2 =>
        //d2.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(d2 =>
        //d2.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto).Where(p =>
        //EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK)).Where(p =>
        //EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT)).Where(p =>
        //EF.Functions.Like(p.REGION, SerchParam.REGION)).Where(p =>
        //EF.Functions.Like(p.FILIAL, SerchParam.FILIAL)).Where(p =>
        //EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N)).Where(p =>
        //EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME)).Where(p =>
        //EF.Functions.Like(p.DS_N, SerchParam.DS_N)).Where(p =>
        //EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER)).Where(p =>
        //EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE)).Where(p =>
        //EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP)).Where(p =>
        //EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N)).Where(p =>
        //EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS)).Where(p =>
        //EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO)).Where(p =>
        //EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO)).Where(p =>
        //EF.Functions.Like(p.STAGE, SerchParam.STAGE)).Where(p =>
        //EF.Functions.Like(p.PR_N, SerchParam.PR_N)).Where(p =>
        //EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS)).Where(p =>
        //EF.Functions.Like(p.PR_COM, SerchParam.PR_COM)).Where(p =>
        //EF.Functions.Like(p.SEVD, SerchParam.SEVD)).Where(p =>
        //EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N)).Where(p =>
        //EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK)).Where(p =>
        //EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE)).Where(p =>
        //EF.Functions.Like(p.GFK, SerchParam.GFK)).Where(p =>
        //EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK)).Where(p =>
        //EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK)).Where(p =>
        //EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE)).Where(p =>
        //EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE)).Where(p =>
        //EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE)).Where(p =>
        //EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK)).Where(p =>
        //EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID)).Where(p =>
        //EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK)).Where(p =>
        //EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT)).Where(p =>
        //EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N)).Where(p =>
        //EF.Functions.Like(p.DOG_N, SerchParam.DOG_N)).Where(p =>
        //EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE)).Where(p =>
        //EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL)).Where(p =>
        //EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN)).Where(p =>
        //EF.Functions.Like(p.ERROR1, SerchParam.ERROR1)).Where(p =>
        //EF.Functions.Like(p.ERROR2, SerchParam.ERROR2)).Where(p =>
        //EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR)).Where(p =>
        //EF.Functions.Like(p.STATUS, SerchParam.STATUS)).Where(p =>
        //EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING)).Where(p =>
        //EF.Functions.Like(p.GEO, SerchParam.GEO)).Where(p =>
        //EF.Functions.Like(p.ZP_N, SerchParam.ZP_N)).Where(p =>
        //EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS)).Where(p =>
        //EF.Functions.Like(p.BD_COM, SerchParam.BD_COM)).Where(p =>
        //EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE)).Where(p =>
        //EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM)).Where(p =>
        //EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE)).Where(p =>
        //EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP)).Where(p =>
        //EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE)).Where(p =>
        //EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL)).Skip((SerchParam.page - 1) * SerchParam.pagesize).Take(SerchParam.pagesize);

        //public IEnumerable<MainReportWave1> MainReportWave1s(MainReportWave1FS SerchParam)
        //{
        //    MainReportWave1s =
        //}

    }
}
