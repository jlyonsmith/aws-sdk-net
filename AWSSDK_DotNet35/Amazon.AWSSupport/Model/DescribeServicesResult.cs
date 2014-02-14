/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Contains the following objects or data if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class DescribeServicesResult : AmazonWebServiceResponse
    {
        
        private List<Service> services = new List<Service>();


        /// <summary>
        /// A JSON-formatted list of AWS services.
        ///  
        /// </summary>
        public List<Service> Services
        {
            get { return this.services; }
            set { this.services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this.services.Count > 0;
        }
    }
}
