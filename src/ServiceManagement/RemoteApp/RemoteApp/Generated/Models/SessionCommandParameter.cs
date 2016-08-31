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

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// Parameter definition for session commands.
    /// </summary>
    public partial class SessionCommandParameter
    {
        private string _userUpn;
        
        /// <summary>
        /// Required. User UPN associated with the session.
        /// </summary>
        public string UserUpn
        {
            get { return this._userUpn; }
            set { this._userUpn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SessionCommandParameter class.
        /// </summary>
        public SessionCommandParameter()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SessionCommandParameter class
        /// with required arguments.
        /// </summary>
        public SessionCommandParameter(string userUpn)
            : this()
        {
            if (userUpn == null)
            {
                throw new ArgumentNullException("userUpn");
            }
            this.UserUpn = userUpn;
        }
    }
}