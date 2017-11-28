using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class OperationRepository : IOperationRepository
    {
        OperationMethod OperationMethod = new OperationMethod();
        public int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, string OperationNo, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId)
        {
            return OperationMethod.OpEquipmentSetData(pclsCache, EquipmentId, OperationNo, OperationTime, OperationCode, OperationValue, OperationResult, TerminalIP, TerminalName, revUserId);
        }

        public List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(DataConnection pclsCache, string EquipmentId, string OperationNo, string OperationTimeS, string OperationTimeE, string OperationCode, string OperationValue, string OperationResult, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetOperationTime, int GetOperationCode, int GetOperationValue, int GetOperationResult, int GetRevisionInfo)
        {
            return OperationMethod.OpEquipmentGetEquipmentOpsByAnyProperty(pclsCache, EquipmentId, OperationNo, OperationTimeS, OperationTimeE, OperationCode, OperationValue, OperationResult, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetOperationTime, GetOperationCode, GetOperationValue, GetOperationResult, GetRevisionInfo);
        }

        public int MstOperationSetData(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode)
        {
            return OperationMethod.MstOperationSetData(pclsCache, OperationId, OperationName, OutputCode);
        }

        public List<MstOperationInfo> GetOperationInfoByAnyProperty(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode, int GetOperationName, int GetOutputCode)
        {
            return OperationMethod.GetOperationInfoByAnyProperty(pclsCache, OperationId, OperationName, OutputCode, GetOperationName, GetOutputCode);
        }

        public List<GetOrdersBySampleType> GetOrdersBySampleType(DataConnection pclsCache, string SampleType)
        {
            return OperationMethod.GetOrdersBySampleType(pclsCache, SampleType);
        }
    }
}
