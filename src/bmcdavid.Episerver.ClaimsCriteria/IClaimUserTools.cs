﻿using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace bmcdavid.Episerver.ClaimsCriteria
{
    /// <summary>
    /// Provides tools for using claims criteria
    /// </summary>
    public interface IClaimUserTools
    {
        /// <summary>
        /// Adds visitor groups setup as security groups to role claims
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="httpContextBase"></param>
        /// <returns></returns>
        Task AddVisitorGroupRolesAsClaimsAsync(ClaimsIdentity identity, HttpContextBase httpContextBase = null);
    }
}