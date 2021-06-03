using System.Collections.Generic;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaSample
{
    public class Function
    {
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            string inputBody = input.Body;

            // Logger
            LambdaLogger.Log("test log");

            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = null,
                /*
                Body = System.Text.Json.JsonSerializer.Serialize(
                    responseBody, typeof(APIGatewayProxyRequest),
                    new System.Text.Json.JsonSerializerOptions { WriteIndented = true }),
                */
                IsBase64Encoded = false,
                Headers = new Dictionary<string, string>() { { "Content-Type", "application/json" } }
            };
        }
    }
}
