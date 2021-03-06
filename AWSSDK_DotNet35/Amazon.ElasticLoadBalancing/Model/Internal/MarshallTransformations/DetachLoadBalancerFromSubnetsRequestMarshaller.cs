/*
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DetachLoadBalancerFromSubnets Request Marshaller
    /// </summary>       
    public class DetachLoadBalancerFromSubnetsRequestMarshaller : IMarshaller<IRequest, DetachLoadBalancerFromSubnetsRequest>
    {
        public IRequest Marshall(DetachLoadBalancerFromSubnetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "DetachLoadBalancerFromSubnets");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
                if(publicRequest.IsSetSubnets())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Subnets)
                    {
                        request.Parameters.Add("Subnets" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}