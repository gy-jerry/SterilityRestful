using System.Net;
using System.Net.Http;
using SterilityRestful.DataModels;

namespace SterilityRestful.CommonLibrary
{
    public class ExceptionHandler
    {
        public HttpResponseMessage Register(HttpRequestMessage request, int operationResult)
        {

            Result res = new Result();
            res.result = "注册失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "注册成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "注册失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "同一用户名的同一角色已经存在";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage Login(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "用户不存在";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "登录成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "用户不存在";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "密码错误";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage ChangePassword(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "修改失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "修改成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "修改失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -1:
                    res.result = "旧密码错误";
                    resp = request.CreateResponse(HttpStatusCode.BadRequest, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public HttpResponseMessage SetData(HttpRequestMessage request, int operationResult)
        {
            Result res = new Result();
            res.result = "插入失败";
            var resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);

            switch (operationResult)
            {
                case 1:
                    res.result = "插入成功";
                    resp = request.CreateResponse(HttpStatusCode.OK, res);
                    break;
                case 0:
                    res.result = "插入失败";
                    resp = request.CreateResponse(HttpStatusCode.InternalServerError, res);
                    break;
                case -2:
                    res.result = "数据库连接失败";
                    resp = request.CreateResponse(HttpStatusCode.NotFound, res);
                    break;
                default:
                    break;
            }
            return resp;
        }

        public string UpdateData(HttpRequestMessage request, int operationResult)
        {
            string result = "插入失败";
            switch (operationResult)
            {
                case 1:
                    result = "插入成功";
                    break;
                case 0:
                    result = "插入失败";
                    break;
                case -1:
                    result = "数据不存在";
                    break;
                case -2:
                    result = "数据库连接失败";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
