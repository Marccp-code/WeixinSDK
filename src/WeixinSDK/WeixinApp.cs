﻿/**********************************************************************************************************************
 * 描述：
 *      微信应用。
 * 
 * 变更历史：
 *      作者：李亮  时间：2016年12月18日	 新建
 *      作者：李亮  时间：2016年12月25日     编辑 将 TokenServiceBase 改为 ITokenService 接口。
 * 
 *********************************************************************************************************************/

using System.Security.Cryptography.X509Certificates;
using Wlitsoft.Framework.Common;
using Wlitsoft.Framework.Common.Core;
using Wlitsoft.Framework.Common.Log;
using Wlitsoft.Framework.Common.Serializer.JsonNet;
using Wlitsoft.Framework.WeixinSDK.Configuration;
using Wlitsoft.Framework.WeixinSDK.Core;

namespace Wlitsoft.Framework.WeixinSDK
{
    /// <summary>
    /// 微信应用。
    /// </summary>
    public class WeixinApp
    {
        /// <summary>
        /// 开发配置。
        /// </summary>
        internal static DevConfiguration DevConfig;

        /// <summary>
        /// 令牌服务。
        /// </summary>
        internal static ITokenService TokenService;

        /// <summary>
        /// 日志记录者。
        /// </summary>
        internal static ILog Logger;

        /// <summary>
        /// 消息处理配置。
        /// </summary>
        internal static MessageProcessConfiguration MessageProcessConfig;

        /// <summary>
        /// 支付接口调用所使用的证书。
        /// </summary>
        internal static X509Certificate PayApiCertificate;

        /// <summary>
        /// 初始化 <see cref="WeixinApp"/> 类的静态实例。
        /// </summary>
        static WeixinApp()
        {
            //将json 序列化实现改成 JsonNet。
            App.Builder.AddSerializer(SerializeType.Json, new JsonNetJsonSerializer());

            //设置一个空的日子记录者。
            Logger = new EmptyLogger();

            MessageProcessConfig = new MessageProcessConfiguration();
        }
    }
}
