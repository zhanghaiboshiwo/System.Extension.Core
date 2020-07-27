﻿// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using EInfrastructure.Core.Config.Entities.Configuration;

namespace EInfrastructure.Core.CustomConfiguration.Core.Domain
{
    /// <summary>
    /// 应用名称空间
    /// </summary>
    public class AppNamespaces : AggregateRoot<long>
    {
        /// <summary>
        ///
        /// </summary>
        public AppNamespaces()
        {
            this.Id = ServiceCollectionExtensions.SnowflakeId.NextId();
            this.AddTime = DateTime.Now;
            this.EditTime = DateTime.Now;
            this.IsDel = false;
            this.DelTime = null;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="appId">应用id</param>
        /// <param name="name">命名空间</param>
        /// <param name="format">格式</param>
        /// <param name="remark">备注</param>
        public AppNamespaces(string appId, string name, string format, string remark):this()
        {
            AppId = appId;
            Name = name;
            Format = format;
            Remark = remark;
        }

        /// <summary>
        /// 应用id
        /// </summary>
        public string AppId { get; private set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 格式
        /// 目前仅支持Json、Properties、Xml
        /// </summary>
        public string Format { get; private set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; private set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; private set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime EditTime { get; private set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDel { get; private set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DelTime { get; private set; }

        #region 名称空间值

        /// <summary>
        ///
        /// </summary>
        private List<NamespaceItems> _namespaceItems;

        /// <summary>
        ///
        /// </summary>
        public IReadOnlyCollection<NamespaceItems> NamespaceItems => _namespaceItems;

        #endregion
    }
}