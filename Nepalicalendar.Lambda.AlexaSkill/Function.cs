using Amazon.Lambda.Core;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Microsoft.Extensions.DependencyInjection;
using Nepalicalendar.Lambda.AlexaSkill.Services;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Nepalicalendar.Lambda.AlexaSkill
{
    public class Function
    {
        private INepaliCalendarService _nepaliCalendarService;

        public Function()
        {
            var serviceProvider = StartUp.InitialiseServices();
            _nepaliCalendarService = serviceProvider.GetService<INepaliCalendarService>();
        }
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            var requestType = input.GetRequestType();
            return "";
            //if (requestType == typeof(IntentRequest))
            //{
            //    return await HandleIntentRequest(input, context);
            //}
            //else if (requestType == typeof(LaunchRequest))
            //{
            //    return HandleLaunchRequest(input, context);
            //}
            //else if (requestType == typeof(SessionEndedRequest))
            //{
            //    return MakeSkillResponse($"Thanks for using {INVOCATION_NAME}. Goodbye.", true);
            //}
            //else
            //{
            //    return MakeSkillResponse($"I don't know how to handle this intent. Please say something like Alexa, ask {INVOCATION_NAME} about Canada.", true);
            //}

        }
    }
}
