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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAccountLimits operation
    /// </summary>  
    public class DescribeAccountLimitsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeAccountLimitsResponse response = new DescribeAccountLimitsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeAccountLimitsResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeAccountLimitsResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("MaxNumberOfAutoScalingGroups", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.MaxNumberOfAutoScalingGroups = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxNumberOfLaunchConfigurations", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.MaxNumberOfLaunchConfigurations = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonAutoScalingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeAccountLimitsResponseUnmarshaller _instance = new DescribeAccountLimitsResponseUnmarshaller();        

        internal static DescribeAccountLimitsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeAccountLimitsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}