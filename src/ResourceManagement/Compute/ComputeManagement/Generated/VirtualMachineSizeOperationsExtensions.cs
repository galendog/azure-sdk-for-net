// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute
{
    /// <summary>
    /// The Compute Management Client.
    /// </summary>
    public static partial class VirtualMachineSizeOperationsExtensions
    {
        /// <summary>
        /// Lists virtual-machine-sizes available in a location for a
        /// subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineSizeOperations.
        /// </param>
        /// <param name='location'>
        /// Required. The location upon which virtual-machine-sizes is queried.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static VirtualMachineSizeListResponse List(this IVirtualMachineSizeOperations operations, string location)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineSizeOperations)s).ListAsync(location);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists virtual-machine-sizes available in a location for a
        /// subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Compute.IVirtualMachineSizeOperations.
        /// </param>
        /// <param name='location'>
        /// Required. The location upon which virtual-machine-sizes is queried.
        /// </param>
        /// <returns>
        /// The List Virtual Machine operation response.
        /// </returns>
        public static Task<VirtualMachineSizeListResponse> ListAsync(this IVirtualMachineSizeOperations operations, string location)
        {
            return operations.ListAsync(location, CancellationToken.None);
        }
    }
}