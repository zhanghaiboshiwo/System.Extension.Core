// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Reflection;
using EInfrastructure.Core.Configuration.Ioc.Plugs.Storage;
using EInfrastructure.Core.Configuration.Ioc.Plugs.Storage.Params.Storage.Pictures;
using EInfrastructure.Core.UCloud.Storage.Config;
using Microsoft.Extensions.Logging;

namespace EInfrastructure.Core.UCloud.Storage
{
    /// <summary>
    /// 图片服务
    /// </summary>
    public class PictureProvider : BaseStorageProvider, IPictureProvider
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="uCloudConfig"></param>
        public PictureProvider(ILogger logger, UCloudStorageConfig uCloudConfig) : base(logger,
            uCloudConfig)
        {
        }

        #region 得到实现类唯一标示

        /// <summary>
        /// 得到实现类唯一标示
        /// </summary>
        /// <returns></returns>
        public string GetIdentify()
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            return method.ReflectedType.Namespace;
        }

        #endregion

        #region 根据图片base64上传

        /// <summary>
        /// 根据图片base64上传
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool Upload(UploadByBase64Param param)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
