// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes an OS profile.
    /// </summary>
    public partial class OSProfile
    {
        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        public OSProfile() { }

        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        public OSProfile(string computerName = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), IList<VaultSecretGroup> secrets = default(IList<VaultSecretGroup>))
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
        }

        /// <summary>
        /// the computer name.
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// the admin user name.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// the admin user password.
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// a base-64 encoded string of custom data.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// the Windows Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// the Linux Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// the List of certificates for addition to the VM.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<VaultSecretGroup> Secrets { get; set; }

    }
}
