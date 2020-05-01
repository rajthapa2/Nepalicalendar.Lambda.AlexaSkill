using System;
using Amazon.Lambda.Core;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Microsoft.Extensions.DependencyInjection;
using NepaliCalendar.Lambda.AlexaSkill.Services;
using TimeZoneConverter;

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
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            // var serviceProvider = StartUp.InitialiseServices();
            // _nepaliCalendarService = serviceProvider.GetService<INepaliCalendarService>();

            var info = TZConvert.GetTimeZoneInfo("Nepal Standard Time");
            var localServerTime = DateTimeOffset.Now;
            var localTime = TimeZoneInfo.ConvertTime(localServerTime, info);

            var nepaliDate = _nepaliCalendarService.GetNepaliDate(localTime.DateTime);

            return MakeSkillResponse($"Nepali Date is {nepaliDate} and Time in Nepal is {localTime:hh:mm tt}" , true);
        }

        private SkillResponse MakeSkillResponse(string outputSpeech, bool shouldEndSession,
            string repromptText = "Just say, What is Nepali Date.")
        {
            var response = new ResponseBody
            {
                ShouldEndSession = shouldEndSession,
                OutputSpeech = new PlainTextOutputSpeech { Text = outputSpeech }
            };

            if (repromptText != null)
            {
                response.Reprompt = new Reprompt() { OutputSpeech = new PlainTextOutputSpeech() { Text = repromptText } };
            }

            var skillResponse = new SkillResponse
            {
                Response = response,
                Version = "1.0"
            };
            return skillResponse;
        }
    }
}
