﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YORMUNGAND.Data.Interfaces;
using YORMUNGAND.Data.Models;
using YORMUNGAND.Data.Models.SUPPORT;
using System.Linq.Dynamic;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using System.Linq.Dynamic.Core;

namespace YORMUNGAND.Data.Repository
{
    public class CessReportRepository: ICessReport
    {
        private readonly AppDBContent appDBContent;
        private readonly CESSDBContent cessDBContent;
        public CessReportRepository(CESSDBContent cessDBContent, AppDBContent appDBContent)
        {
            this.cessDBContent = cessDBContent;
            this.appDBContent = appDBContent;
        }
        public IEnumerable<MainReportWave1> MainReportWave1 { get; }
        //Получить итем по ID
        public MainReportWave1 Detail1stWaveById(int ID) =>
            cessDBContent.MAIN_1.FirstOrDefault(i => i.id == ID);
        //Посчитать колличество записей для вывода по параметрам поиска
        public int MainReportWave1c(MainReportWave1FS SerchParam)
        {
            var result = cessDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).ThenByDescending(l => l.id).Where(k1 =>
       k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
       k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
       p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
       p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto);
            if (SerchParam.NRI_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK));
            if (SerchParam.ZM_LOT != null)
                result = result.Where(p => EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT));
            if (SerchParam.REGION != null)
                result = result.Where(p => EF.Functions.Like(p.REGION, SerchParam.REGION));
            if (SerchParam.FILIAL != null)
                result = result.Where(p => EF.Functions.Like(p.FILIAL, SerchParam.FILIAL));
            if (SerchParam.NRI_BS_N != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N));
            if (SerchParam.NRI_BS_NAME != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME));
            if (SerchParam.DS_N != null)
                result = result.Where(p => EF.Functions.Like(p.DS_N, SerchParam.DS_N));
            if (SerchParam.PROVIDER != null)
                result = result.Where(p => EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER));
            if (SerchParam.VIR_DOC_TYPE != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE));
            if (SerchParam.VIR_DOP != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP));
            if (SerchParam.VIR_DOP_N != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N));
            if (SerchParam.VIR_PAY_CONDITIONS != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS));
            if (SerchParam.INITIATOR_FIO != null)
                result = result.Where(p => EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO));
            if (SerchParam.RESPONSIBLE_FIO != null)
                result = result.Where(p => EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO));
            if (SerchParam.STAGE != null)
                result = result.Where(p => EF.Functions.Like(p.STAGE, SerchParam.STAGE));
            if (SerchParam.PR_N != null)
                result = result.Where(p => EF.Functions.Like(p.PR_N, SerchParam.PR_N));
            if (SerchParam.PR_STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS));
            if (SerchParam.PR_COM != null)
                result = result.Where(p => EF.Functions.Like(p.PR_COM, SerchParam.PR_COM));
            if (SerchParam.SEVD != null)
                result = result.Where(p => EF.Functions.Like(p.SEVD, SerchParam.SEVD));
            if (SerchParam.SEVD_N != null)
                result = result.Where(p => EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N));
            if (SerchParam.ECM_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK));
            if (SerchParam.DS_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE));
            if (SerchParam.GFK != null)
                result = result.Where(p => EF.Functions.Like(p.GFK, SerchParam.GFK));
            if (SerchParam.VIR_START_WORK != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK));
            if (SerchParam.VIR_END_WORK != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK));
            if (SerchParam.VIR_INTEGRATION_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE));
            if (SerchParam.DIADOK_UPLOAD_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE));
            if (SerchParam.DIADOK_SIGN_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE));
            if (SerchParam.IMS_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK));
            if (SerchParam.DIADOK_ID != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID));
            if (SerchParam.DIADOK_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK));
            if (SerchParam.NRI_CODE_PROJECT != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT));
            if (SerchParam.CONTRACT_N != null)
                result = result.Where(p => EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N));
            if (SerchParam.DOG_N != null)
                result = result.Where(p => EF.Functions.Like(p.DOG_N, SerchParam.DOG_N));
            if (SerchParam.DOG_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE));
            if (SerchParam.INITIATOR_MAIL != null)
                result = result.Where(p => EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL));
            if (SerchParam.PROVIDER_INN != null)
                result = result.Where(p => EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN));
            if (SerchParam.ERROR1 != null)
                result = result.Where(p => EF.Functions.Like(p.ERROR1, SerchParam.ERROR1));
            if (SerchParam.ERROR2 != null)
                result = result.Where(p => EF.Functions.Like(p.ERROR2, SerchParam.ERROR2));
            if (SerchParam.TECH_ERROR != null)
                result = result.Where(p => EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR));
            if (SerchParam.STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.STATUS, SerchParam.STATUS));
            if (SerchParam.PROCESSING != null)
                result = result.Where(p => EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING));
            if (SerchParam.GEO != null)
                result = result.Where(p => EF.Functions.Like(p.GEO, SerchParam.GEO));
            if (SerchParam.ZP_N != null)
                result = result.Where(p => EF.Functions.Like(p.ZP_N, SerchParam.ZP_N));
            if (SerchParam.ZP_STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS));
            if (SerchParam.BD_COM != null)
                result = result.Where(p => EF.Functions.Like(p.BD_COM, SerchParam.BD_COM));
            if (SerchParam.PR_FILE != null)
                result = result.Where(p => EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE));
            if (SerchParam.VIR_COM != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM));
            if (SerchParam.DOUBLE != null)
                result = result.Where(p => EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE));
            if (SerchParam.VIR_DIAP != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP));
            if (SerchParam.PROSTAVLENIE != null)
                result = result.Where(p => EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE));
            if (SerchParam.ECM_FILL != null)
                result = result.Where(p => EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL));
            if (SerchParam.REFILLING_TERMINATION != null)
                result = result.Where(p => EF.Functions.Like(p.REFILLING_TERMINATION, SerchParam.REFILLING_TERMINATION));
            if (SerchParam.RECEIVED_PORTAL_STR != null)
                result = result.Where(p => p.RECEIVED_PORTAL == SerchParam.RECEIVED_PORTAL);

            int Count = result.Count(); 
            return Count;
        }
        //Посчитать колличество записей всего
        public int MainReportWave1ct(MainReportWave1FS SerchParam) =>
            cessDBContent.MAIN_1.Count();

        public IEnumerable<MainReportWave1> MainReportWave1Export(MainReportWave1FS SerchParam) =>
        //Заменено на MainReportWave1Exports
            cessDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).OrderBy(l => l.id).Where(k1 =>
        k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto).Where(p =>
        EF.Functions.Like(p.ECM_FILL, (SerchParam.ECM_FILL ?? "%")) || p.ECM_FILL == null).Where(p =>
        EF.Functions.Like(p.ZM_LOT, (SerchParam.ZM_LOT ?? "%")) || p.ZM_LOT == null).Where(p =>
        EF.Functions.Like(p.REGION, (SerchParam.REGION ?? "%")) || p.REGION == null).Where(p =>
        EF.Functions.Like(p.FILIAL, (SerchParam.FILIAL ?? "%")) || p.FILIAL == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_N, (SerchParam.NRI_BS_N ?? "%")) || p.NRI_BS_N == null).Where(p =>
        EF.Functions.Like(p.NRI_BS_NAME, (SerchParam.NRI_BS_NAME ?? "%")) || p.NRI_BS_NAME == null).Where(p =>
        EF.Functions.Like(p.DS_N, (SerchParam.DS_N ?? "%")) || p.DS_N == null).Where(p =>
        EF.Functions.Like(p.PROVIDER, (SerchParam.PROVIDER ?? "%")) || p.PROVIDER == null).Where(p =>
        EF.Functions.Like(p.VIR_DOC_TYPE, (SerchParam.VIR_DOC_TYPE ?? "%")) || p.VIR_DOC_TYPE == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP, (SerchParam.VIR_DOP ?? "%")) || p.VIR_DOP == null).Where(p =>
        EF.Functions.Like(p.VIR_DOP_N, (SerchParam.VIR_DOP_N ?? "%")) || p.VIR_DOP_N == null).Where(p =>
        EF.Functions.Like(p.VIR_PAY_CONDITIONS, (SerchParam.VIR_PAY_CONDITIONS ?? "%")) || p.VIR_PAY_CONDITIONS == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_FIO, (SerchParam.INITIATOR_FIO ?? "%")) || p.INITIATOR_FIO == null).Where(p =>
        EF.Functions.Like(p.RESPONSIBLE_FIO, (SerchParam.RESPONSIBLE_FIO ?? "%")) || p.RESPONSIBLE_FIO == null).Where(p =>
        EF.Functions.Like(p.STAGE, (SerchParam.STAGE ?? "%")) || p.STAGE == null).Where(p =>
        EF.Functions.Like(p.PR_N, (SerchParam.PR_N ?? "%")) || p.PR_N == null).Where(p =>
        EF.Functions.Like(p.PR_STATUS, (SerchParam.PR_STATUS ?? "%")) || p.PR_STATUS == null).Where(p =>
        EF.Functions.Like(p.PR_COM, (SerchParam.PR_COM ?? "%")) || p.PR_COM == null).Where(p =>
        EF.Functions.Like(p.SEVD, (SerchParam.SEVD ?? "%")) || p.SEVD == null).Where(p =>
        EF.Functions.Like(p.SEVD_N, (SerchParam.SEVD_N ?? "%")) || p.SEVD_N == null).Where(p =>
        EF.Functions.Like(p.ECM_LINK, (SerchParam.ECM_LINK ?? "%")) || p.ECM_LINK == null).Where(p =>
        EF.Functions.Like(p.DS_DATE, (SerchParam.DS_DATE ?? "%")) || p.DS_DATE == null).Where(p =>
        EF.Functions.Like(p.GFK, (SerchParam.GFK ?? "%")) || p.GFK == null).Where(p =>
        EF.Functions.Like(p.VIR_START_WORK, (SerchParam.VIR_START_WORK ?? "%")) || p.VIR_START_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_END_WORK, (SerchParam.VIR_END_WORK ?? "%")) || p.VIR_END_WORK == null).Where(p =>
        EF.Functions.Like(p.VIR_INTEGRATION_DATE, (SerchParam.VIR_INTEGRATION_DATE ?? "%")) || p.VIR_INTEGRATION_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_UPLOAD_DATE, (SerchParam.DIADOK_UPLOAD_DATE ?? "%")) || p.DIADOK_UPLOAD_DATE == null).Where(p =>
        EF.Functions.Like(p.DIADOK_SIGN_DATE, (SerchParam.DIADOK_SIGN_DATE ?? "%")) || p.DIADOK_SIGN_DATE == null).Where(p =>
        EF.Functions.Like(p.IMS_LINK, (SerchParam.IMS_LINK ?? "%")) || p.IMS_LINK == null).Where(p =>
        EF.Functions.Like(p.DIADOK_ID, (SerchParam.DIADOK_ID ?? "%")) || p.DIADOK_ID == null).Where(p =>
        EF.Functions.Like(p.DIADOK_LINK, (SerchParam.DIADOK_LINK ?? "%")) || p.DIADOK_LINK == null).Where(p =>
        EF.Functions.Like(p.NRI_CODE_PROJECT, (SerchParam.NRI_CODE_PROJECT ?? "%")) || p.NRI_CODE_PROJECT == null).Where(p =>
        EF.Functions.Like(p.CONTRACT_N, (SerchParam.CONTRACT_N ?? "%")) || p.CONTRACT_N == null).Where(p =>
        EF.Functions.Like(p.DOG_N, (SerchParam.DOG_N ?? "%")) || p.DOG_N == null).Where(p =>
        EF.Functions.Like(p.DOG_DATE, (SerchParam.DOG_DATE ?? "%")) || p.DOG_DATE == null).Where(p =>
        EF.Functions.Like(p.INITIATOR_MAIL, (SerchParam.INITIATOR_MAIL ?? "%")) || p.INITIATOR_MAIL == null).Where(p =>
        EF.Functions.Like(p.PROVIDER_INN, (SerchParam.PROVIDER_INN ?? "%")) || p.PROVIDER_INN == null).Where(p =>
        EF.Functions.Like(p.ERROR1, (SerchParam.ERROR1 ?? "%")) || p.ERROR1 == null).Where(p =>
        EF.Functions.Like(p.ERROR2, (SerchParam.ERROR2 ?? "%")) || p.ERROR2 == null).Where(p =>
        EF.Functions.Like(p.TECH_ERROR, (SerchParam.TECH_ERROR ?? "%")) || p.TECH_ERROR == null).Where(p =>
        EF.Functions.Like(p.STATUS, (SerchParam.STATUS ?? "%")) || p.STATUS == null).Where(p =>
        EF.Functions.Like(p.PROCESSING, (SerchParam.PROCESSING ?? "%")) || p.PROCESSING == null).Where(p =>
        EF.Functions.Like(p.GEO, (SerchParam.GEO ?? "%")) || p.GEO == null).Where(p =>
        EF.Functions.Like(p.ZP_N, (SerchParam.ZP_N ?? "%")) || p.ZP_N == null).Where(p =>
        EF.Functions.Like(p.ZP_STATUS, (SerchParam.ZP_STATUS ?? "%")) || p.ZP_STATUS == null).Where(p =>
        EF.Functions.Like(p.BD_COM, (SerchParam.BD_COM ?? "%")) || p.BD_COM == null).Where(p =>
        EF.Functions.Like(p.PR_FILE, (SerchParam.PR_FILE ?? "%")) || p.PR_FILE == null).Where(p =>
        EF.Functions.Like(p.VIR_COM, (SerchParam.VIR_COM ?? "%")) || p.VIR_COM == null).Where(p =>
        EF.Functions.Like(p.DOUBLE, (SerchParam.DOUBLE ?? "%")) || p.DOUBLE == null).Where(p =>
        EF.Functions.Like(p.VIR_DIAP, (SerchParam.VIR_DIAP ?? "%")) || p.VIR_DIAP == null).Where(p =>
        EF.Functions.Like(p.PROSTAVLENIE, (SerchParam.PROSTAVLENIE ?? "%")) || p.PROSTAVLENIE == null).Where(p =>
        EF.Functions.Like(p.NRI_LINK, (SerchParam.NRI_LINK ?? "%")) || p.NRI_LINK == null);
        ////Вывести записи по параметрам поиска
        //public IEnumerable<MainReportWave1> MainReportWave1s(MainReportWave1FS SerchParam) =>
        //    appDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).OrderBy(l => l.id).Where(k1 =>
        //k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        //k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        //p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        //p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto).Where(p =>
        //EF.Functions.Like(p.ECM_FILL, (SerchParam.ECM_FILL ?? "%")) || p.ECM_FILL == null).Where(p =>
        //EF.Functions.Like(p.ZM_LOT, (SerchParam.ZM_LOT ?? "%")) || p.ZM_LOT == null).Where(p =>
        //EF.Functions.Like(p.REGION, (SerchParam.REGION ?? "%")) || p.REGION == null).Where(p =>
        //EF.Functions.Like(p.FILIAL, (SerchParam.FILIAL ?? "%")) || p.FILIAL == null).Where(p =>
        //EF.Functions.Like(p.NRI_BS_N, (SerchParam.NRI_BS_N ?? "%")) || p.NRI_BS_N == null).Where(p =>
        //EF.Functions.Like(p.NRI_BS_NAME, (SerchParam.NRI_BS_NAME ?? "%")) || p.NRI_BS_NAME == null).Where(p =>
        //EF.Functions.Like(p.DS_N, (SerchParam.DS_N ?? "%")) || p.DS_N == null).Where(p =>
        //EF.Functions.Like(p.PROVIDER, (SerchParam.PROVIDER ?? "%")) || p.PROVIDER == null).Where(p =>
        //EF.Functions.Like(p.VIR_DOC_TYPE, (SerchParam.VIR_DOC_TYPE ?? "%")) || p.VIR_DOC_TYPE == null).Where(p =>
        //EF.Functions.Like(p.VIR_DOP, (SerchParam.VIR_DOP ?? "%")) || p.VIR_DOP == null).Where(p =>
        //EF.Functions.Like(p.VIR_DOP_N, (SerchParam.VIR_DOP_N ?? "%")) || p.VIR_DOP_N == null).Where(p =>
        //EF.Functions.Like(p.VIR_PAY_CONDITIONS, (SerchParam.VIR_PAY_CONDITIONS ?? "%")) || p.VIR_PAY_CONDITIONS == null).Where(p =>
        //EF.Functions.Like(p.INITIATOR_FIO, (SerchParam.INITIATOR_FIO ?? "%")) || p.INITIATOR_FIO == null).Where(p =>
        //EF.Functions.Like(p.RESPONSIBLE_FIO, (SerchParam.RESPONSIBLE_FIO ?? "%")) || p.RESPONSIBLE_FIO == null).Where(p =>
        //EF.Functions.Like(p.STAGE, (SerchParam.STAGE ?? "%")) || p.STAGE == null).Where(p =>
        //EF.Functions.Like(p.PR_N, (SerchParam.PR_N ?? "%")) || p.PR_N == null).Where(p =>
        //EF.Functions.Like(p.PR_STATUS, (SerchParam.PR_STATUS ?? "%")) || p.PR_STATUS == null).Where(p =>
        //EF.Functions.Like(p.PR_COM, (SerchParam.PR_COM ?? "%")) || p.PR_COM == null).Where(p =>
        //EF.Functions.Like(p.SEVD, (SerchParam.SEVD ?? "%")) || p.SEVD == null).Where(p =>
        //EF.Functions.Like(p.SEVD_N, (SerchParam.SEVD_N ?? "%")) || p.SEVD_N == null).Where(p =>
        //EF.Functions.Like(p.ECM_LINK, (SerchParam.ECM_LINK ?? "%")) || p.ECM_LINK == null).Where(p =>
        //EF.Functions.Like(p.DS_DATE, (SerchParam.DS_DATE ?? "%")) || p.DS_DATE == null).Where(p =>
        //EF.Functions.Like(p.GFK, (SerchParam.GFK ?? "%")) || p.GFK == null).Where(p =>
        //EF.Functions.Like(p.VIR_START_WORK, (SerchParam.VIR_START_WORK ?? "%")) || p.VIR_START_WORK == null).Where(p =>
        //EF.Functions.Like(p.VIR_END_WORK, (SerchParam.VIR_END_WORK ?? "%")) || p.VIR_END_WORK == null).Where(p =>
        //EF.Functions.Like(p.VIR_INTEGRATION_DATE, (SerchParam.VIR_INTEGRATION_DATE ?? "%")) || p.VIR_INTEGRATION_DATE == null).Where(p =>
        //EF.Functions.Like(p.DIADOK_UPLOAD_DATE, (SerchParam.DIADOK_UPLOAD_DATE ?? "%")) || p.DIADOK_UPLOAD_DATE == null).Where(p =>
        //EF.Functions.Like(p.DIADOK_SIGN_DATE, (SerchParam.DIADOK_SIGN_DATE ?? "%")) || p.DIADOK_SIGN_DATE == null).Where(p =>
        //EF.Functions.Like(p.IMS_LINK, (SerchParam.IMS_LINK ?? "%")) || p.IMS_LINK == null).Where(p =>
        //EF.Functions.Like(p.DIADOK_ID, (SerchParam.DIADOK_ID ?? "%")) || p.DIADOK_ID == null).Where(p =>
        //EF.Functions.Like(p.DIADOK_LINK, (SerchParam.DIADOK_LINK ?? "%")) || p.DIADOK_LINK == null).Where(p =>
        //EF.Functions.Like(p.NRI_CODE_PROJECT, (SerchParam.NRI_CODE_PROJECT ?? "%")) || p.NRI_CODE_PROJECT == null).Where(p =>
        //EF.Functions.Like(p.CONTRACT_N, (SerchParam.CONTRACT_N ?? "%")) || p.CONTRACT_N == null).Where(p =>
        //EF.Functions.Like(p.DOG_N, (SerchParam.DOG_N ?? "%")) || p.DOG_N == null).Where(p =>
        //EF.Functions.Like(p.DOG_DATE, (SerchParam.DOG_DATE ?? "%")) || p.DOG_DATE == null).Where(p =>
        //EF.Functions.Like(p.INITIATOR_MAIL, (SerchParam.INITIATOR_MAIL ?? "%")) || p.INITIATOR_MAIL == null).Where(p =>
        //EF.Functions.Like(p.PROVIDER_INN, (SerchParam.PROVIDER_INN ?? "%")) || p.PROVIDER_INN == null).Where(p =>
        //EF.Functions.Like(p.ERROR1, (SerchParam.ERROR1 ?? "%")) || p.ERROR1 == null).Where(p =>
        //EF.Functions.Like(p.ERROR2, (SerchParam.ERROR2 ?? "%")) || p.ERROR2 == null).Where(p =>
        //EF.Functions.Like(p.TECH_ERROR, (SerchParam.TECH_ERROR ?? "%")) || p.TECH_ERROR == null).Where(p =>
        //EF.Functions.Like(p.STATUS, (SerchParam.STATUS ?? "%")) || p.STATUS == null).Where(p =>
        //EF.Functions.Like(p.PROCESSING, (SerchParam.PROCESSING ?? "%")) || p.PROCESSING == null).Where(p =>
        //EF.Functions.Like(p.GEO, (SerchParam.GEO ?? "%")) || p.GEO == null).Where(p =>
        //EF.Functions.Like(p.ZP_N, (SerchParam.ZP_N ?? "%")) || p.ZP_N == null).Where(p =>
        //EF.Functions.Like(p.ZP_STATUS, (SerchParam.ZP_STATUS ?? "%")) || p.ZP_STATUS == null).Where(p =>
        //EF.Functions.Like(p.BD_COM, (SerchParam.BD_COM ?? "%")) || p.BD_COM == null).Where(p =>
        //EF.Functions.Like(p.PR_FILE, (SerchParam.PR_FILE ?? "%")) || p.PR_FILE == null).Where(p =>
        //EF.Functions.Like(p.VIR_COM, (SerchParam.VIR_COM ?? "%")) || p.VIR_COM == null).Where(p =>
        //EF.Functions.Like(p.DOUBLE, (SerchParam.DOUBLE ?? "%")) || p.DOUBLE == null).Where(p =>
        //EF.Functions.Like(p.VIR_DIAP, (SerchParam.VIR_DIAP ?? "%")) || p.VIR_DIAP == null).Where(p =>
        //EF.Functions.Like(p.PROSTAVLENIE, (SerchParam.PROSTAVLENIE ?? "%")) || p.PROSTAVLENIE == null).Where(p =>
        //EF.Functions.Like(p.NRI_LINK, (SerchParam.NRI_LINK ?? "%")) || p.NRI_LINK == null).Skip((SerchParam.page - 1) * SerchParam.pagesize).Take(SerchParam.pagesize);
        public IEnumerable<MainReportWave1> MainReportWave1post(IEnumerable<MainReportWave1> data)
        {
            foreach (MainReportWave1 row in data)
            {
                //row.NRI_BS_NAME_FULL = row.NRI_BS_NAME;
                //row.NRI_BS_NAME_FULL = row.NRI_BS_NAME;
                //row.VIR_DOP_N_FULL = row.VIR_DOP_N;
                //row.PROVIDER_FULL = row.PROVIDER;
                //row.INITIATOR_FIO_FULL = row.INITIATOR_FIO;
                //row.RESPONSIBLE_FIO_FULL = row.RESPONSIBLE_FIO;
                //row.STATUS_FULL = row.STATUS;

                //row.INITIATOR_FIO = SupportClass.FIOshort(row.INITIATOR_FIO);
                //row.RESPONSIBLE_FIO = SupportClass.FIOshort(row.RESPONSIBLE_FIO);
            }
            return data;
        }
        //Вывести записи по параметрам поиска
        public IEnumerable<MainReportWave1> MainReportWave1ss(MainReportWave1FS SerchParam)
        {

            var result = cessDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).ThenByDescending(l => l.id).Where(k1 =>
        k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto);
        if (SerchParam.NRI_LINK != null)
            result = result.Where(p => EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK)); 
        if (SerchParam.ZM_LOT != null)
            result = result.Where(p => EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT));
            if (SerchParam.REGION != null)
                result = result.Where(p => EF.Functions.Like(p.REGION, SerchParam.REGION));
            if (SerchParam.FILIAL != null)
            result = result.Where(p => EF.Functions.Like(p.FILIAL, SerchParam.FILIAL)); 
        if (SerchParam.NRI_BS_N != null)
            result = result.Where(p => EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N)); 
        if (SerchParam.NRI_BS_NAME != null)
            result = result.Where(p => EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME)); 
        if (SerchParam.DS_N != null)
            result = result.Where(p => EF.Functions.Like(p.DS_N, SerchParam.DS_N)); 
        if (SerchParam.PROVIDER != null)
            result = result.Where(p => EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER)); 
        if (SerchParam.VIR_DOC_TYPE != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE)); 
        if (SerchParam.VIR_DOP != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP)); 
        if (SerchParam.VIR_DOP_N != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N)); 
        if (SerchParam.VIR_PAY_CONDITIONS != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS)); 
        if (SerchParam.INITIATOR_FIO != null)
            result = result.Where(p => EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO)); 
        if (SerchParam.RESPONSIBLE_FIO != null)
            result = result.Where(p => EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO)); 
        if (SerchParam.STAGE != null)
            result = result.Where(p => EF.Functions.Like(p.STAGE, SerchParam.STAGE)); 
        if (SerchParam.PR_N != null)
            result = result.Where(p => EF.Functions.Like(p.PR_N, SerchParam.PR_N)); 
        if (SerchParam.PR_STATUS != null)
            result = result.Where(p => EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS)); 
        if (SerchParam.PR_COM != null)
            result = result.Where(p => EF.Functions.Like(p.PR_COM, SerchParam.PR_COM)); 
        if (SerchParam.SEVD != null)
            result = result.Where(p => EF.Functions.Like(p.SEVD, SerchParam.SEVD)); 
        if (SerchParam.SEVD_N != null)
            result = result.Where(p => EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N)); 
        if (SerchParam.ECM_LINK != null)
            result = result.Where(p => EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK)); 
        if (SerchParam.DS_DATE != null)
            result = result.Where(p => EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE)); 
        if (SerchParam.GFK != null)
            result = result.Where(p => EF.Functions.Like(p.GFK, SerchParam.GFK)); 
        if (SerchParam.VIR_START_WORK != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK)); 
        if (SerchParam.VIR_END_WORK != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK)); 
        if (SerchParam.VIR_INTEGRATION_DATE != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE)); 
        if (SerchParam.DIADOK_UPLOAD_DATE != null)
            result = result.Where(p => EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE)); 
        if (SerchParam.DIADOK_SIGN_DATE != null)
            result = result.Where(p => EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE)); 
        if (SerchParam.IMS_LINK != null)
            result = result.Where(p => EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK)); 
        if (SerchParam.DIADOK_ID != null)
            result = result.Where(p => EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID)); 
        if (SerchParam.DIADOK_LINK != null)
            result = result.Where(p => EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK)); 
        if (SerchParam.NRI_CODE_PROJECT != null)
            result = result.Where(p => EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT)); 
        if (SerchParam.CONTRACT_N != null)
            result = result.Where(p => EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N)); 
        if (SerchParam.DOG_N != null)
            result = result.Where(p => EF.Functions.Like(p.DOG_N, SerchParam.DOG_N)); 
        if (SerchParam.DOG_DATE != null)
            result = result.Where(p => EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE)); 
        if (SerchParam.INITIATOR_MAIL != null)
            result = result.Where(p => EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL)); 
        if (SerchParam.PROVIDER_INN != null)
            result = result.Where(p => EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN)); 
        if (SerchParam.ERROR1 != null)
            result = result.Where(p => EF.Functions.Like(p.ERROR1, SerchParam.ERROR1)); 
        if (SerchParam.ERROR2 != null)
            result = result.Where(p => EF.Functions.Like(p.ERROR2, SerchParam.ERROR2)); 
        if (SerchParam.TECH_ERROR != null)
            result = result.Where(p => EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR)); 
        if (SerchParam.STATUS != null)
            result = result.Where(p => EF.Functions.Like(p.STATUS, SerchParam.STATUS)); 
        if (SerchParam.PROCESSING != null)
            result = result.Where(p => EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING)); 
        if (SerchParam.GEO != null)
            result = result.Where(p => EF.Functions.Like(p.GEO, SerchParam.GEO)); 
        if (SerchParam.ZP_N != null)
            result = result.Where(p => EF.Functions.Like(p.ZP_N, SerchParam.ZP_N)); 
        if (SerchParam.ZP_STATUS != null)
            result = result.Where(p => EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS)); 
        if (SerchParam.BD_COM != null)
            result = result.Where(p => EF.Functions.Like(p.BD_COM, SerchParam.BD_COM)); 
        if (SerchParam.PR_FILE != null)
            result = result.Where(p => EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE)); 
        if (SerchParam.VIR_COM != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM)); 
        if (SerchParam.DOUBLE != null)
            result = result.Where(p => EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE)); 
        if (SerchParam.VIR_DIAP != null)
            result = result.Where(p => EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP)); 
        if (SerchParam.PROSTAVLENIE != null)
            result = result.Where(p => EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE)); 
        if (SerchParam.ECM_FILL != null)
            result = result.Where(p => EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL));
        if (SerchParam.REFILLING_TERMINATION != null)
            result = result.Where(p => EF.Functions.Like(p.REFILLING_TERMINATION, SerchParam.REFILLING_TERMINATION));
        if (SerchParam.RECEIVED_PORTAL_STR != null)
            result = result.Where(p => p.RECEIVED_PORTAL == SerchParam.RECEIVED_PORTAL);

            result = result.Skip((SerchParam.page - 1) * SerchParam.pagesize).Take(SerchParam.pagesize);
        return result;
        }
        public IEnumerable<MainReportWave1> MainReportWave1Exports(MainReportWave1FS SerchParam)
        {
            var result = cessDBContent.MAIN_1.OrderByDescending(i => i.VIR_DATE).ThenByDescending(l => l.id).Where(k1 =>
        k1.VIR_DATE >= SerchParam.VIR_DATEfrom).Where(k2 =>
        k2.VIR_DATE <= SerchParam.VIR_DATEto).Where(p =>
        p.VIR_SUMM_WO_NDS >= SerchParam.VIR_SUMM_WO_NDSfrom).Where(p =>
        p.VIR_SUMM_WO_NDS <= SerchParam.VIR_SUMM_WO_NDSto);
            if (SerchParam.NRI_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_LINK, SerchParam.NRI_LINK));
            if (SerchParam.ZM_LOT != null)
                result = result.Where(p => EF.Functions.Like(p.ZM_LOT, SerchParam.ZM_LOT));
            if (SerchParam.REGION != null)
                result = result.Where(p => EF.Functions.Like(p.REGION, SerchParam.REGION));
            if (SerchParam.FILIAL != null)
                result = result.Where(p => EF.Functions.Like(p.FILIAL, SerchParam.FILIAL));
            if (SerchParam.NRI_BS_N != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_BS_N, SerchParam.NRI_BS_N));
            if (SerchParam.NRI_BS_NAME != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_BS_NAME, SerchParam.NRI_BS_NAME));
            if (SerchParam.DS_N != null)
                result = result.Where(p => EF.Functions.Like(p.DS_N, SerchParam.DS_N));
            if (SerchParam.PROVIDER != null)
                result = result.Where(p => EF.Functions.Like(p.PROVIDER, SerchParam.PROVIDER));
            if (SerchParam.VIR_DOC_TYPE != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOC_TYPE, SerchParam.VIR_DOC_TYPE));
            if (SerchParam.VIR_DOP != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOP, SerchParam.VIR_DOP));
            if (SerchParam.VIR_DOP_N != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DOP_N, SerchParam.VIR_DOP_N));
            if (SerchParam.VIR_PAY_CONDITIONS != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_PAY_CONDITIONS, SerchParam.VIR_PAY_CONDITIONS));
            if (SerchParam.INITIATOR_FIO != null)
                result = result.Where(p => EF.Functions.Like(p.INITIATOR_FIO, SerchParam.INITIATOR_FIO));
            if (SerchParam.RESPONSIBLE_FIO != null)
                result = result.Where(p => EF.Functions.Like(p.RESPONSIBLE_FIO, SerchParam.RESPONSIBLE_FIO));
            if (SerchParam.STAGE != null)
                result = result.Where(p => EF.Functions.Like(p.STAGE, SerchParam.STAGE));
            if (SerchParam.PR_N != null)
                result = result.Where(p => EF.Functions.Like(p.PR_N, SerchParam.PR_N));
            if (SerchParam.PR_STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.PR_STATUS, SerchParam.PR_STATUS));
            if (SerchParam.PR_COM != null)
                result = result.Where(p => EF.Functions.Like(p.PR_COM, SerchParam.PR_COM));
            if (SerchParam.SEVD != null)
                result = result.Where(p => EF.Functions.Like(p.SEVD, SerchParam.SEVD));
            if (SerchParam.SEVD_N != null)
                result = result.Where(p => EF.Functions.Like(p.SEVD_N, SerchParam.SEVD_N));
            if (SerchParam.ECM_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.ECM_LINK, SerchParam.ECM_LINK));
            if (SerchParam.DS_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DS_DATE, SerchParam.DS_DATE));
            if (SerchParam.GFK != null)
                result = result.Where(p => EF.Functions.Like(p.GFK, SerchParam.GFK));
            if (SerchParam.VIR_START_WORK != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_START_WORK, SerchParam.VIR_START_WORK));
            if (SerchParam.VIR_END_WORK != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_END_WORK, SerchParam.VIR_END_WORK));
            if (SerchParam.VIR_INTEGRATION_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_INTEGRATION_DATE, SerchParam.VIR_INTEGRATION_DATE));
            if (SerchParam.DIADOK_UPLOAD_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_UPLOAD_DATE, SerchParam.DIADOK_UPLOAD_DATE));
            if (SerchParam.DIADOK_SIGN_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_SIGN_DATE, SerchParam.DIADOK_SIGN_DATE));
            if (SerchParam.IMS_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.IMS_LINK, SerchParam.IMS_LINK));
            if (SerchParam.DIADOK_ID != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_ID, SerchParam.DIADOK_ID));
            if (SerchParam.DIADOK_LINK != null)
                result = result.Where(p => EF.Functions.Like(p.DIADOK_LINK, SerchParam.DIADOK_LINK));
            if (SerchParam.NRI_CODE_PROJECT != null)
                result = result.Where(p => EF.Functions.Like(p.NRI_CODE_PROJECT, SerchParam.NRI_CODE_PROJECT));
            if (SerchParam.CONTRACT_N != null)
                result = result.Where(p => EF.Functions.Like(p.CONTRACT_N, SerchParam.CONTRACT_N));
            if (SerchParam.DOG_N != null)
                result = result.Where(p => EF.Functions.Like(p.DOG_N, SerchParam.DOG_N));
            if (SerchParam.DOG_DATE != null)
                result = result.Where(p => EF.Functions.Like(p.DOG_DATE, SerchParam.DOG_DATE));
            if (SerchParam.INITIATOR_MAIL != null)
                result = result.Where(p => EF.Functions.Like(p.INITIATOR_MAIL, SerchParam.INITIATOR_MAIL));
            if (SerchParam.PROVIDER_INN != null)
                result = result.Where(p => EF.Functions.Like(p.PROVIDER_INN, SerchParam.PROVIDER_INN));
            if (SerchParam.ERROR1 != null)
                result = result.Where(p => EF.Functions.Like(p.ERROR1, SerchParam.ERROR1));
            if (SerchParam.ERROR2 != null)
                result = result.Where(p => EF.Functions.Like(p.ERROR2, SerchParam.ERROR2));
            if (SerchParam.TECH_ERROR != null)
                result = result.Where(p => EF.Functions.Like(p.TECH_ERROR, SerchParam.TECH_ERROR));
            if (SerchParam.STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.STATUS, SerchParam.STATUS));
            if (SerchParam.PROCESSING != null)
                result = result.Where(p => EF.Functions.Like(p.PROCESSING, SerchParam.PROCESSING));
            if (SerchParam.GEO != null)
                result = result.Where(p => EF.Functions.Like(p.GEO, SerchParam.GEO));
            if (SerchParam.ZP_N != null)
                result = result.Where(p => EF.Functions.Like(p.ZP_N, SerchParam.ZP_N));
            if (SerchParam.ZP_STATUS != null)
                result = result.Where(p => EF.Functions.Like(p.ZP_STATUS, SerchParam.ZP_STATUS));
            if (SerchParam.BD_COM != null)
                result = result.Where(p => EF.Functions.Like(p.BD_COM, SerchParam.BD_COM));
            if (SerchParam.PR_FILE != null)
                result = result.Where(p => EF.Functions.Like(p.PR_FILE, SerchParam.PR_FILE));
            if (SerchParam.VIR_COM != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_COM, SerchParam.VIR_COM));
            if (SerchParam.DOUBLE != null)
                result = result.Where(p => EF.Functions.Like(p.DOUBLE, SerchParam.DOUBLE));
            if (SerchParam.VIR_DIAP != null)
                result = result.Where(p => EF.Functions.Like(p.VIR_DIAP, SerchParam.VIR_DIAP));
            if (SerchParam.PROSTAVLENIE != null)
                result = result.Where(p => EF.Functions.Like(p.PROSTAVLENIE, SerchParam.PROSTAVLENIE));
            if (SerchParam.ECM_FILL != null)
                result = result.Where(p => EF.Functions.Like(p.ECM_FILL, SerchParam.ECM_FILL));
            if (SerchParam.REFILLING_TERMINATION != null)
                result = result.Where(p => EF.Functions.Like(p.REFILLING_TERMINATION, SerchParam.REFILLING_TERMINATION));
            if (SerchParam.RECEIVED_PORTAL_STR != null)
                result = result.Where(p => p.RECEIVED_PORTAL == SerchParam.RECEIVED_PORTAL);
            return result;
        }
        public List<SelectListItem> GetSelectList(string FieldName, string DefaultText, string region, string filial, string stage, string processing)
        {
            var result = cessDBContent.MAIN_1.OrderBy(p => p.id);
            if (region != "" && region != null)
                result = result.Where(p => p.REGION == region).OrderBy(p => p.id);
            if (filial != "" && filial != null)
                result = result.Where(p => p.FILIAL == filial).OrderBy(p => p.id);
            if (stage != "" && stage != null)
                result = result.Where(p => p.STAGE == stage).OrderBy(p => p.id);
            if (processing != "" && processing != null)
                result = result.Where(p => p.PROCESSING == processing).OrderBy(p => p.id);
            var result2 = result.Select("m => m." + FieldName).Distinct();
            //var list2 = cessDBContent.MAIN_1;
            //list2 = list2.Where(m => m.REGION == region);
            //list2 = list2.Select("m => m." + FieldName).Distinct();

            //var list = appDBContent.MAIN_1.Select(m => new { REG = m.PROVIDER, VAL = m.PROVIDER }).Distinct().ToList();
            //var list3 = list2.ToList();
            var list = new List<SelectListItem>();
            int counter = 0;
            foreach (var c in result2)
            {
                if (c.ToString() != "")
                {
                    list.Insert(counter, new SelectListItem { Selected = false, Text = c.ToString(), Value = c.ToString() });
                    counter++;
                }
            }
            list.Insert(0, new SelectListItem { Selected = true, Text = DefaultText, Value = "" });
            //list.Insert(0, new { REG = "Все регионы", VAL = "" });
            return list;
            //.Select(r =>
            //  new SelectListItem
            //  {
            //      Selected = false,
            //      Text = r.REG,
            //      Value = r.VAL
            //  });
        }
        public List<SelectListItem>  GetSelectListTrueFalse()
        {
            var list = new List<SelectListItem>();
            list.Insert(0, new SelectListItem { Selected = true, Text = "Все", Value = null });
            list.Insert(1, new SelectListItem { Selected = false, Text = "Да", Value = "true" });
            list.Insert(2, new SelectListItem { Selected = false, Text = "Нет", Value = "false" });
            return list;
        }
        public void AddStatisticCessReprtDwld(string user, int count)
        {
            appDBContent.StatCessReportDwnld.Add(new StatistikCessReportDwnld
            {
                USER = user,
                ROWS_COUNT = count,
                EVENT_DATE = DateTime.Now
            });
            appDBContent.SaveChanges();
        }
    }
}
