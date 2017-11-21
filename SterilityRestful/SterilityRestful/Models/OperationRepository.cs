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
    }
}
