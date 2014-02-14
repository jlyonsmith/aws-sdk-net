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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InstanceStateChangeReasonUnmarshaller
      /// </summary>
      internal class InstanceStateChangeReasonUnmarshaller : IUnmarshaller<InstanceStateChangeReason, XmlUnmarshallerContext>, IUnmarshaller<InstanceStateChangeReason, JsonUnmarshallerContext>
      {
        InstanceStateChangeReason IUnmarshaller<InstanceStateChangeReason, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstanceStateChangeReason Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            InstanceStateChangeReason instanceStateChangeReason = new InstanceStateChangeReason();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Code", targetDepth))
              {
                context.Read();
                instanceStateChangeReason.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Message", targetDepth))
              {
                context.Read();
                instanceStateChangeReason.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return instanceStateChangeReason;
                }
            }
          

            return instanceStateChangeReason;
        }

        private static InstanceStateChangeReasonUnmarshaller instance;
        public static InstanceStateChangeReasonUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceStateChangeReasonUnmarshaller();
            return instance;
        }
    }
}
  
