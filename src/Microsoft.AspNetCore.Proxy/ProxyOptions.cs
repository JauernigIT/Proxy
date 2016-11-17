// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Options to configure host, scheme, and port settings
    /// </summary>
    public class ProxyOptions
    {
        public string Scheme { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public HttpMessageHandler BackChannelMessageHandler { get; set; }
        public ResponseHandlerDelegate ResponseHandler { get; set; }

        public delegate bool ResponseHandlerDelegate(RequestDelegate next, HttpResponseMessage responseMessage, HttpContext context);
    }
}
