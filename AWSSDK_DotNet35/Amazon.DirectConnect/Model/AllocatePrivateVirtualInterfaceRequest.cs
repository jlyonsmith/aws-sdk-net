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
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the AllocatePrivateVirtualInterface operation.
    /// <para>Provisions a private virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
    /// to provision a private virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
    /// function must be confirmed by the virtual interface owner by calling ConfirmPrivateVirtualInterface. Until this step has been completed,
    /// the virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
    /// </summary>
    public partial class AllocatePrivateVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string connectionId;
        private string ownerAccount;
        private NewPrivateVirtualInterfaceAllocation newPrivateVirtualInterfaceAllocation;


        /// <summary>
        /// The connection ID on which the private virtual interface is provisioned. Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// The AWS account that will own the new private virtual interface. Default: None
        ///  
        /// </summary>
        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// Detailed information of the private virtual interface to be provisioned. Default: None
        ///  
        /// </summary>
        public NewPrivateVirtualInterfaceAllocation NewPrivateVirtualInterfaceAllocation
        {
            get { return this.newPrivateVirtualInterfaceAllocation; }
            set { this.newPrivateVirtualInterfaceAllocation = value; }
        }

        // Check to see if NewPrivateVirtualInterfaceAllocation property is set
        internal bool IsSetNewPrivateVirtualInterfaceAllocation()
        {
            return this.newPrivateVirtualInterfaceAllocation != null;
        }

    }
}
    
