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
    public class ResultController : ApiController
    {
        static readonly IResultRepository repository = new ResultRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 检测结果录入
        /// </summary>
        /// <param name="testResult"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestResultSetData")]
        public HttpResponseMessage ResTestResultSetData(TestResultInfo testResultInfo)
        {
            int ret = repository.ResTestResultSetData(pclsCache, testResultInfo.TestId, testResultInfo.ObjectNo, testResultInfo.ObjCompany, testResultInfo.ObjIncuSeq, testResultInfo.TestType, testResultInfo.TestStand, testResultInfo.TestEquip, testResultInfo.Description, testResultInfo.CollectStart, testResultInfo.CollectEnd, testResultInfo.TestTime, testResultInfo.TestResult, testResultInfo.TestPeople, testResultInfo.ReStatus, testResultInfo.RePeople, testResultInfo.ReTime, testResultInfo.TerminalIP, testResultInfo.TerminalName, testResultInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到检测结果们的信息
        /// </summary>
        /// <param name="queryTestResultInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestResultGetResultInfosByAnyProperty")]
        public List<GetTestResultInfo> ResTestResultGetResultInfosByAnyProperty(QueryTestResultInfo queryTestResultInfo)
        {
            return repository.ResTestResultGetResultInfosByAnyProperty(pclsCache, queryTestResultInfo.TestId, queryTestResultInfo.ObjectNo, queryTestResultInfo.ObjCompany, queryTestResultInfo.ObjIncuSeq, queryTestResultInfo.TestType, queryTestResultInfo.TestStand, queryTestResultInfo.TestEquip, queryTestResultInfo.Description, queryTestResultInfo.CollectStartS, queryTestResultInfo.CollectStartE, queryTestResultInfo.CollectEndS, queryTestResultInfo.CollectEndE, queryTestResultInfo.TestTimeS, queryTestResultInfo.TestTimeE, queryTestResultInfo.TestResult, queryTestResultInfo.TestPeople, queryTestResultInfo.ReStatus, queryTestResultInfo.RePeople, queryTestResultInfo.ReTimeS, queryTestResultInfo.ReTimeE, queryTestResultInfo.ReDateTimeS, queryTestResultInfo.ReDateTimeE, queryTestResultInfo.ReTerminalIP, queryTestResultInfo.ReTerminalName, queryTestResultInfo.ReUserId, queryTestResultInfo.ReIdentify, queryTestResultInfo.GetObjectNo, queryTestResultInfo.GetObjCompany, queryTestResultInfo.GetObjIncuSeq, queryTestResultInfo.GetTestType, queryTestResultInfo.GetTestStand, queryTestResultInfo.GetTestEquip, queryTestResultInfo.GetDescription, queryTestResultInfo.GetCollectStart, queryTestResultInfo.GetCollectEnd, queryTestResultInfo.GetTestTime, queryTestResultInfo.GetTestResult, queryTestResultInfo.GetTestPeople, queryTestResultInfo.GetReStatus, queryTestResultInfo.GetRePeople, queryTestResultInfo.GetReTime, queryTestResultInfo.GetRevisionInfo);
        }

        /// <summary>
        /// 样品培养记录
        /// </summary>
        /// <param name="resIncubator"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResIncubatorSetData")]
        public HttpResponseMessage ResIncubatorSetData(ResIncubator resIncubator)
        {
            int ret = repository.ResIncubatorSetData(pclsCache, resIncubator.TestId, resIncubator.TubeNo, resIncubator.CultureId, resIncubator.BacterId, resIncubator.OtherRea, resIncubator.IncubatorId, resIncubator.StartTime, resIncubator.EndTime, resIncubator.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到样品培养记录们的信息
        /// </summary>
        /// <param name="queryResIncubator"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResIncubatorGetResultTubesByAnyProperty")]
        public List<ResIncubator> ResIncubatorGetResultTubesByAnyProperty(QueryResIncubator queryResIncubator)
        {
            return repository.ResIncubatorGetResultTubesByAnyProperty(pclsCache, queryResIncubator.TestId, queryResIncubator.TubeNo, queryResIncubator.CultureId, queryResIncubator.BacterId, queryResIncubator.OtherRea, queryResIncubator.IncubatorId, queryResIncubator.StartTimeS, queryResIncubator.StartTimeE, queryResIncubator.EndTimeS, queryResIncubator.EndTimeE, queryResIncubator.AnalResult, queryResIncubator.GetCultureId, queryResIncubator.GetBacterId, queryResIncubator.GetOtherRea, queryResIncubator.GetIncubatorId, queryResIncubator.GetStartTime, queryResIncubator.GetEndTime, queryResIncubator.GetAnalResult);
        }

        /// <summary>
        /// 机器视觉记录
        /// </summary>
        /// <param name="resTestPicture"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestPictureSetData")]
        public HttpResponseMessage ResTestPictureSetData(ResTestPicture resTestPicture)
        {
            int ret = repository.ResTestPictureSetData(pclsCache, resTestPicture.TestId, resTestPicture.TubeNo, resTestPicture.PictureId, resTestPicture.CameraTime, resTestPicture.ImageAddress, resTestPicture.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到机器视觉检测们的信息
        /// </summary>
        /// <param name="queryResTestPicture"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestPictureGetTestPicturesByAnyProperty")]
        public List<ResTestPicture> ResTestPictureGetTestPicturesByAnyProperty(QueryResTestPicture queryResTestPicture)
        {
            return repository.ResTestPictureGetTestPicturesByAnyProperty(pclsCache, queryResTestPicture.TestId, queryResTestPicture.TubeNo, queryResTestPicture.PictureId, queryResTestPicture.CameraTimeS, queryResTestPicture.CameraTimeE, queryResTestPicture.ImageAddress, queryResTestPicture.AnalResult, queryResTestPicture.GetCameraTime, queryResTestPicture.GetImageAddress, queryResTestPicture.GetAnalResult);
        }

        /// <summary>
        /// 顶空分析记录
        /// </summary>
        /// <param name="resTopAnalysis"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTopAnalysisSetData")]
        public HttpResponseMessage ResTopAnalysisSetData(ResTopAnalysis resTopAnalysis)
        {
            int ret = repository.ResTopAnalysisSetData(pclsCache, resTopAnalysis.TestId, resTopAnalysis.TubeNo, resTopAnalysis.PictureId, resTopAnalysis.CameraTime, resTopAnalysis.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到顶空分析们的信息
        /// </summary>
        /// <param name="queryResTopAnalysis"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTopAnalysisGetTopAnalysisByAnyProperty")]
        public List<ResTopAnalysis> ResTopAnalysisGetTopAnalysisByAnyProperty(QueryResTopAnalysis queryResTopAnalysis)
        {
            return repository.ResTopAnalysisGetTopAnalysisByAnyProperty(pclsCache, queryResTopAnalysis.TestId, queryResTopAnalysis.TubeNo, queryResTopAnalysis.PictureId, queryResTopAnalysis.CameraTimeS, queryResTopAnalysis.CameraTimeE, queryResTopAnalysis.AnalResult, queryResTopAnalysis.GetCameraTime, queryResTopAnalysis.GetAnalResult);
        }

        /// <summary>
        /// 故障信息记录
        /// </summary>
        /// <param name="breakDown"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/BreakDownSetData")]
        public HttpResponseMessage BreakDownSetData(BreakDown breakDown)
        {
            int ret = repository.BreakDownSetData(pclsCache, breakDown.BreakId, breakDown.BreakTime, breakDown.BreakEquip, breakDown.BreakPara, breakDown.BreakValue, breakDown.BreakReason, breakDown.ResponseTime);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 根据任何筛选条件得到故障们的信息
        /// </summary>
        /// <param name="queryBreakDown"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/BreakDownGetBreakDownsByAnyProperty")]
        public List<BreakDown> BreakDownGetBreakDownsByAnyProperty(QueryBreakDown queryBreakDown)
        {
            return repository.BreakDownGetBreakDownsByAnyProperty(pclsCache, queryBreakDown.BreakId, queryBreakDown.BreakTimeS, queryBreakDown.BreakTimeE, queryBreakDown.BreakEquip, queryBreakDown.BreakPara, queryBreakDown.BreakValue, queryBreakDown.BreakReason, queryBreakDown.ResponseTimeS, queryBreakDown.ResponseTimeE, queryBreakDown.GetBreakTime, queryBreakDown.GetBreakEquip, queryBreakDown.GetBreakPara, queryBreakDown.GetBreakValue, queryBreakDown.GetBreakReason, queryBreakDown.GetResponseTime);
        }
    }
}