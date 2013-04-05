/*******************************************************************************
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

using System.Text;

namespace AsimovDeploy.WinAgent.Framework.Models
{
    public abstract class ActionParameter
    {
        public string Name { get; set; }
        
        public ActionParameterType Mode { get; set; }

        public abstract dynamic GetDescriptor();

        public abstract void ApplyToPowershellScript(StringBuilder script, dynamic value);
        
        public ActionParameter()
        {
        	Mode = ActionParameterType.Deploy;
        }
        
        public bool IsInstallParameter { get { return Mode == ActionParameterType.Install; } }
    }
    
    public enum ActionParameterType 
    {
    	Install,
    	Deploy
    }
}