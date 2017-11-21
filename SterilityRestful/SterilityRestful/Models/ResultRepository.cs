using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Collections.Generic;
using SterilityRestful.DataModels;

namespace SterilityRestful.Models
{
    public class ResultRepository : IResultRepository
    {
        ResultMethod ResultMethod = new ResultMethod();
        public int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string Description, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId)
        {
            return ResultMethod.ResTestResultSetData(pclsCache, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, Description, CollectStart, CollectEnd, TestTime, TestResult, TestPeople, ReStatus, RePeople, ReTime, TerminalIP, TerminalName, revUserId);
        }

        public int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string StartTime, string EndTime, string AnalResult)
        {
            return ResultMethod.ResIncubatorSetData(pclsCache, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, StartTime, EndTime, AnalResult);
        }

        public int ResTestPictureSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string ImageAddress, string AnalResult)
        {
            return ResultMethod.ResTestPictureSetData(pclsCache, TestId, TubeNo, PictureId, CameraTime, ImageAddress, AnalResult);
        }

        public int ResTopAnalysisSetData(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, DateTime CameraTime, string AnalResult)
        {
            return ResultMethod.ResTopAnalysisSetData(pclsCache, TestId, TubeNo, PictureId, CameraTime, AnalResult);
        }
        
        public int BreakDownSetData(DataConnection pclsCache, string BreakId, DateTime BreakTime, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, DateTime ResponseTime)
        {
            return ResultMethod.BreakDownSetData(pclsCache, BreakId, BreakTime, BreakEquip, BreakPara, BreakValue, BreakReason, ResponseTime);
        }

        public List<GetTestResultInfo> ResTestResultGetResultInfosByAnyProperty(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string Description, string CollectStartS, string CollectStartE, string CollectEndS, string CollectEndE, string TestTimeS, string TestTimeE, string TestResult, string TestPeople, string ReStatus, string RePeople, string ReTimeS, string ReTimeE, string ReDateTimeS, string ReDateTimeE, string ReTerminalIP, string ReTerminalName, string ReUserId, string ReIdentify, int GetObjectNo, int GetObjCompany, int GetObjIncuSeq, int GetTestType, int GetTestStand, int GetTestEquip, int GetDescription, int GetCollectStart, int GetCollectEnd, int GetTestTime, int GetTestResult, int GetTestPeople, int GetReStatus, int GetRePeople, int GetReTime, int GetRevisionInfo)
        {
            return ResultMethod.ResTestResultGetResultInfosByAnyProperty(pclsCache, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, Description, CollectStartS, CollectStartE, CollectEndS, CollectEndE, TestTimeS, TestTimeE, TestResult, TestPeople, ReStatus, RePeople, ReTimeS, ReTimeE, ReDateTimeS, ReDateTimeE, ReTerminalIP, ReTerminalName, ReUserId, ReIdentify, GetObjectNo, GetObjCompany, GetObjIncuSeq, GetTestType, GetTestStand, GetTestEquip, GetDescription, GetCollectStart, GetCollectEnd, GetTestTime, GetTestResult, GetTestPeople, GetReStatus, GetRePeople, GetReTime, GetRevisionInfo);
        }

        public List<ResIncubator> ResIncubatorGetResultTubesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string StartTimeS, string StartTimeE, string EndTimeS, string EndTimeE, string AnalResult, int GetCultureId, int GetBacterId, int GetOtherRea, int GetIncubatorId, int GetStartTime, int GetEndTime, int GetAnalResult)
        {
            return ResultMethod.ResIncubatorGetResultTubesByAnyProperty(pclsCache, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, StartTimeS, StartTimeE, EndTimeS, EndTimeE, AnalResult, GetCultureId, GetBacterId, GetOtherRea, GetIncubatorId, GetStartTime, GetEndTime, GetAnalResult);
        }

        public List<ResTestPicture> ResTestPictureGetTestPicturesByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string ImageAddress, string AnalResult, int GetCameraTime, int GetImageAddress, int GetAnalResult)
        {
            return ResultMethod.ResTestPictureGetTestPicturesByAnyProperty(pclsCache, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, ImageAddress, AnalResult, GetCameraTime, GetImageAddress, GetAnalResult);
        }

        public List<ResTopAnalysis> ResTopAnalysisGetTopAnalysisByAnyProperty(DataConnection pclsCache, string TestId, string TubeNo, string PictureId, string CameraTimeS, string CameraTimeE, string AnalResult, int GetCameraTime, int GetAnalResult)
        {
            return ResultMethod.ResTopAnalysisGetTopAnalysisByAnyProperty(pclsCache, TestId, TubeNo, PictureId, CameraTimeS, CameraTimeE, AnalResult, GetCameraTime, GetAnalResult);
        }

        public List<BreakDown> BreakDownGetBreakDownsByAnyProperty(DataConnection pclsCache, string BreakId, string BreakTimeS, string BreakTimeE, string BreakEquip, string BreakPara, string BreakValue, string BreakReason, string ResponseTimeS, string ResponseTimeE, int GetBreakTime, int GetBreakEquip, int GetBreakPara, int GetBreakValue, int GetBreakReason, int GetResponseTime)
        {
            return ResultMethod.BreakDownGetBreakDownsByAnyProperty(pclsCache, BreakId, BreakTimeS, BreakTimeE, BreakEquip, BreakPara, BreakValue, BreakReason, ResponseTimeS, ResponseTimeE, GetBreakTime, GetBreakEquip, GetBreakPara, GetBreakValue, GetBreakReason, GetResponseTime);
        }
    }
}
