﻿// -----------------------------------------------------------------------
//  <copyright file="SecurityManager.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using System;

using Liuliu.Demo.Identity.Entities;
using Liuliu.Demo.Security.Dtos;
using Liuliu.Demo.Security.Entities;

using OSharp.Core.EntityInfos;
using OSharp.Core.Functions;
using OSharp.Entity;
using OSharp.EventBuses;
using OSharp.Security;


namespace Liuliu.Demo.Security
{
    /// <summary>
    /// 权限安全管理器
    /// </summary>
    public class SecurityManager
        : SecurityManagerBase<Function, FunctionInputDto, EntityInfo, EntityInfoInputDto,
            Module, ModuleInputDto, int, ModuleFunction, ModuleRole, ModuleUser, UserRole, Role, int, User, int>
    {
        /// <summary>
        /// 初始化一个<see cref="SecurityManager"/>类型的新实例
        /// </summary>
        public SecurityManager(
            IEventBus eventBus,
            IRepository<Function, Guid> functionRepository,
            IRepository<EntityInfo, Guid> entityInfoRepository,
            IRepository<Module, int> moduleRepository,
            IRepository<ModuleFunction, Guid> moduleFunctionRepository,
            IRepository<ModuleRole, Guid> moduleRoleRepository,
            IRepository<ModuleUser, Guid> moduleUserRepository,
            IRepository<Role, int> roleRepository,
            IRepository<User, int> userRepository,
            IRepository<UserRole, Guid> userRoleRepository)
            : base(eventBus,
                functionRepository,
                entityInfoRepository,
                moduleRepository,
                moduleFunctionRepository,
                moduleRoleRepository,
                moduleUserRepository,
                roleRepository,
                userRepository,
                userRoleRepository)
        { }
    }
}