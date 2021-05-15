﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Adnc.Application.Shared.Consts;

namespace Adnc.Usr.Application.Contracts.Consts
{
    /// <summary>
    /// cache key 常量
    /// </summary>
    public class CachingConsts : SharedCachingConsts
    {
        //cache key
        public const string MenuListCacheKey = "adnc:usr:menus:list";
        public const string MenuTreeListCacheKey = "adnc:usr:menus:tree";
        public const string MenuRelationCacheKey = "adnc:usr:menus:relation";
        public const string MenuCodesCacheKey = "adnc:usr:menus:codes";

        public const string DetpListCacheKey = "adnc:usr:depts:list";
        public const string DetpTreeListCacheKey = "adnc:usr:depts:tree";
        public const string DetpSimpleTreeListCacheKey = "adnc:usr:depts:tree:simple";

        public const string RoleAllCacheKey = "adnc:usr:roles";

        //cache prefix
        public const string UserValidateInfoKeyPrefix = "adnc:usr:users:validateinfo";
    }
}
