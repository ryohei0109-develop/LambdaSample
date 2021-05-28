using System;
using System.Collections.Generic;
using System.Reflection;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaSample
{
    public class Function
    {
        public string FunctionHandler(object request, ILambdaContext context)
        {
            string response = "ok4";

            if (request != null)
            {
                LambdaLogger.Log(request.ToString());
            }

            return response;
        }
    }
}
