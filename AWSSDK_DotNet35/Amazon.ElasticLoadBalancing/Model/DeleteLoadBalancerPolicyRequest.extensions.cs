﻿/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoadBalancerPolicy operation.
    /// Deletes a policy from the load balancer. The specified policy must not be enabled
    /// for any listeners.
    /// </summary>
    public partial class DeleteLoadBalancerPolicyRequest 
    {
        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerPolicyRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerPolicyRequest() { }

        /// <summary>
        /// Constructs a new DeleteLoadBalancerPolicyRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. </param>
        /// <param name="policyName"> The mnemonic name for the policy being deleted. </param>
        public DeleteLoadBalancerPolicyRequest(string loadBalancerName, string policyName)
        {
            _loadBalancerName = loadBalancerName;
            _policyName = policyName;
        }
    }
}
