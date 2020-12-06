// <auto-generated>
// Code generated by LUISGen .\Koinonos.json -cs Luis.Koinonos -o .
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public partial class Koinonos: IRecognizerConvert
    {
        [JsonProperty("text")]
        public string Text;

        [JsonProperty("alteredText")]
        public string AlteredText;

        public enum Intent {
            Calendar_CreateCalendarEntry, 
            Health_concerns, 
            None, 
            ToDo_AddToDo, 
            Web_WebSearch
        };
        [JsonProperty("intents")]
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Calendar_EndDate;

            public string[] Calendar_EndTime;

            public string[] Calendar_StartDate;

            public string[] Calendar_StartTime;

            public string[] Health_issues;

            public string[] ToDo_TaskContent;

            public string[] Web_SearchText;

            // Built-in entities
            public string[] personName;

            // Lists
            public string[][] Web_SearchEngine;
            public string[][] google_com;
            public string[][] www_google_com;

            // Pattern.any
            public string[] ToDo_TaskContent_Any;

            // Instance
            public class _Instance
            {
                public InstanceData[] Calendar_EndDate;
                public InstanceData[] Calendar_EndTime;
                public InstanceData[] Calendar_StartDate;
                public InstanceData[] Calendar_StartTime;
                public InstanceData[] Health_issues;
                public InstanceData[] ToDo_TaskContent;
                public InstanceData[] ToDo_TaskContent_Any;
                public InstanceData[] Web_SearchEngine;
                public InstanceData[] google_com;
                public InstanceData[] www_google_com;
                public InstanceData[] Web_SearchText;
                public InstanceData[] personName;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        [JsonProperty("entities")]
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Koinonos>(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}