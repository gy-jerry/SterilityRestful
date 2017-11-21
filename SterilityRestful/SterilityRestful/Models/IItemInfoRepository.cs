using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public interface IItemInfoRepository
    {
        int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId);

        int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId);

        int ItemReagentSetData(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string TerminalIP, string TerminalName, string revUserId);

        int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, int Temperature, string TerminalIP, string TerminalName, string revUserId);

        int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId);

        List<GetIsolatorInfo> ItemIsolatorGetIsolatorsInfoByAnyProperty(DataConnection pclsCache, string IsolatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo);

        List<GetIncubatorInfo> ItemIncubatorGetIncubatorsInfoByAnyProperty(DataConnection pclsCache, string IncubatorId, string ProductDayS, string ProductDayE, string EquipPro, string InsDescription, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetProductDay, int GetEquipPro, int GetInsDescription, int GetRevisionInfo);

        List<GetReagentInfo> ItemReagentGetReagentsInfoByAnyProperty(DataConnection pclsCache, string ReagentId, string ReagentSource, string ReagentName, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetReagentSource, int GetReagentName, int GetRevisionInfo);

        List<GetSampleInfo> ItemSampleGetSamplesInfoByAnyProperty(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, string SamplingTimeS, string SamplingTimeE, string Warning, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetObjectName, int GetObjectType, int GetSamplingPeople, int GetSamplingTime, int GetWarning, int GetRevisionInfo);

        List<GetIncubatorEnv> EnvIncubatorGetIncubatorEnvsByAnyProperty(DataConnection pclsCache, string IncubatorId, string MeaTimeS, string MeaTimeE, string Temperature, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetTemperature, int GetRevisionInfo);

        List<GetIsolatorEnv> EnvIsolatorGetIsolatorEnvsByAnyProperty(DataConnection pclsCache, string IsolatorId, string CabinId, string MeaTimeS, string MeaTimeE, string IsoCode, string IsoValue, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetIsoValue, int GetRevisionInfo);

        List<string> ItemSampleCreateNewSample(DataConnection pclsCache, string ObjCompany, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string Warning, string TerminalIP, string TerminalName, string revUserId);

        int ItemSampleUpdateSampleInfo(DataConnection pclsCache, string ObjectNo, string ObjCompany, string NewObjIncuSeq, string SamplingPeople, DateTime SamplingTime, string TerminalIP, string TerminalName, string revUserId);

        List<string> EnvIsolatorGetNewIsolatorEnv(DataConnection pclsCache, string IsolatorId, string CabinId);
    }
}
