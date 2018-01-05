using SterilityRestful.CommonLibrary;
using SterilityRestful.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SterilityRestful.DataModels;

namespace SterilityRestful.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*"), WebApiTracker]
    public class OperationController : ApiController
    {
        static readonly IOperationRepository repository = new OperationRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 无菌隔离器、培养箱操作记录
        /// </summary>
        /// <param name="operationInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/OpEquipmentSetData")]
        public HttpResponseMessage OpEquipmentSetData(OperationInfo operationInfo)
        {
            int ret = repository.OpEquipmentSetData(pclsCache, operationInfo.EquipmentId, operationInfo.OperationNo, operationInfo.OperationTime, operationInfo.OperationCode, operationInfo.OperationValue, operationInfo.OperationResult, operationInfo.TerminalIP, operationInfo.TerminalName, operationInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到仪器操作记录们的信息
        /// </summary>
        /// <param name="queryOperationInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/OpEquipmentGetEquipmentOpsByAnyProperty")]
        public List<GetOperationInfo> OpEquipmentGetEquipmentOpsByAnyProperty(QueryOperationInfo queryOperationInfo)
        {
            return repository.OpEquipmentGetEquipmentOpsByAnyProperty(pclsCache, queryOperationInfo.EquipmentId, queryOperationInfo.OperationNo, queryOperationInfo.OperationTimeS, queryOperationInfo.OperationTimeE, queryOperationInfo.OperationCode, queryOperationInfo.OperationValue, queryOperationInfo.OperationResult, queryOperationInfo.ReDateTimeS, queryOperationInfo.ReDateTimeE, queryOperationInfo.ReTerminalIP, queryOperationInfo.ReTerminalName, queryOperationInfo.ReUserId, queryOperationInfo.ReIdentify, queryOperationInfo.GetOperationTime, queryOperationInfo.GetOperationCode, queryOperationInfo.GetOperationValue, queryOperationInfo.GetOperationResult, queryOperationInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 基本操作插入数据 GY 2017-11-23
        /// </summary>
        /// <param name="operationInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationSetData")]
        public HttpResponseMessage MstOperationSetData(MstOperationInfo operationInfo)
        {
            int ret = repository.MstOperationSetData(pclsCache, operationInfo.OperationId, operationInfo.OperationName, operationInfo.OutputCode);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 查询基本操作 GY 2017-11-23
        /// </summary>
        /// <param name="GetMstOperationInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationGetInfoByAnyProperty")]
        public List<MstOperationInfo> MstOperationGetInfoByAnyProperty(GetMstOperationInfo GetMstOperationInfo)
        {
            return repository.GetOperationInfoByAnyProperty(pclsCache, GetMstOperationInfo.OperationId, GetMstOperationInfo.OperationName, GetMstOperationInfo.OutputCode, GetMstOperationInfo.GetOperationName, GetMstOperationInfo.GetOutputCode);
        }

        /// <summary>
        /// MstOperationOrder数据录入 GY 2017-11-29
        /// </summary>
        /// <param name="MstOperationOrder"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationOrderSetData")]
        public HttpResponseMessage MstOperationOrderSetData(MstOperationOrder MstOperationOrder)
        {
            int ret = repository.MstOperationOrderSetData(pclsCache, MstOperationOrder.OrderId, MstOperationOrder.SampleType, MstOperationOrder.OperationId, MstOperationOrder.OperationValue, MstOperationOrder.OpDescription, MstOperationOrder.PreviousStep, MstOperationOrder.LaterStep);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 按供试品类型得到无菌检测流程规划 GY 2017-11-28
        /// </summary>
        /// <param name="SampleTypeInput"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationOrdersBySampleType")]
        public List<GetOrdersBySampleType> MstOperationOrdersBySampleType(SampleTypeInput SampleTypeInput)
        {
            return repository.GetOrdersBySampleType(pclsCache, SampleTypeInput.SampleType);
        }

        /// <summary>
        /// 输出所有供试品类型 GY 2017-12-04
        /// </summary>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstAllOperationSampleTypes")]
        public List<string> MstAllOperationSampleTypes()
        {
            return repository.GetAllSampleTypes(pclsCache);
        }

        /// <summary>
        /// 根据主键删除MstOperation数据 GY 2018-01-03
        /// </summary>
        /// <param name="MstOperationDelete"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationDeleteByPK")]
        public HttpResponseMessage MstOperationDeleteByPK(MstOperationDelete MstOperationDelete)
        {
            int ret = repository.DeleteMstOperation(pclsCache, MstOperationDelete.OperationId);
            return new ExceptionHandler().DeleteData(Request, ret);
        }

        /// <summary>
        /// 根据主键删除MstOperationOrder数据 GY 2018-01-03
        /// </summary>
        /// <param name="MstOperationOrderDelete"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/MstOperationOrderDeleteByPK")]
        public HttpResponseMessage MstOperationOrderDeleteByPK(MstOperationOrderDelete MstOperationOrderDelete)
        {
            int ret = repository.DeleteMstOperationOrder(pclsCache, MstOperationOrderDelete.OrderId);
            return new ExceptionHandler().DeleteData(Request, ret);
        }
    }
}