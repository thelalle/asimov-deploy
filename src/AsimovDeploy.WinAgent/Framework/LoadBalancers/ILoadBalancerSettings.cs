﻿/*******************************************************************************
* Copyright (C) 2012 eBay Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*   http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
******************************************************************************/

namespace AsimovDeploy.WinAgent.Framework.LoadBalancers
{
    public interface ILoadBalancerSettings
    {
        string Host { get; }
        string Password { get; }
        bool AllowCookiePersistedSessions { get; }
        bool RemoveExistingConnectionsFromSessionTable { get; }
    }


    public class LoadBalancerSettings : ILoadBalancerSettings
    {
        public string Host { get; set; }
        public string Password { get; set; }

        public bool AllowCookiePersistedSessions { get; set; }
        public bool RemoveExistingConnectionsFromSessionTable { get; set; }
    }
}