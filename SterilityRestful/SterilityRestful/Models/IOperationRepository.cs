using SterilityRestful.CommonLibrary;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public interface IOperationRepository
    {
        int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, string OperationNo, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId);

        List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(DataConnection pclsCache, string EquipmentId, string OperationNo, string OperationTimeS, string OperationTimeE, string OperationCode, string OperationValue, string OperationResult, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetOperationTime, int GetOperationCode, int GetOperationValue, int GetOperationResult, int GetRevisionInfo);

        int MstOperationSetData(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode);

        List<MstOperationInfo> GetOperationInfoByAnyProperty(DataConnection pclsCache, string OperationId, string OperationName, string OutputCode, int GetOperationName, int GetOutputCode);

        List<GetOrdersBySampleType> GetOrdersBySampleType(DataConnection pclsCache, string SampleType);
    }
}
