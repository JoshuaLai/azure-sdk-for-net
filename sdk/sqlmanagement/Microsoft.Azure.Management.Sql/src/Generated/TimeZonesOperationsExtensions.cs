// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TimeZonesOperations.
    /// </summary>
    public static partial class TimeZonesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of managed instance time zones by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            public static IPage<TimeZone> ListByLocation(this ITimeZonesOperations operations, string locationName)
            {
                return operations.ListByLocationAsync(locationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instance time zones by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TimeZone>> ListByLocationAsync(this ITimeZonesOperations operations, string locationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationWithHttpMessagesAsync(locationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed instance time zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='timeZoneId'>
            /// </param>
            public static TimeZone Get(this ITimeZonesOperations operations, string locationName, string timeZoneId)
            {
                return operations.GetAsync(locationName, timeZoneId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed instance time zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='timeZoneId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TimeZone> GetAsync(this ITimeZonesOperations operations, string locationName, string timeZoneId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(locationName, timeZoneId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of managed instance time zones by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TimeZone> ListByLocationNext(this ITimeZonesOperations operations, string nextPageLink)
            {
                return operations.ListByLocationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed instance time zones by location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TimeZone>> ListByLocationNextAsync(this ITimeZonesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
