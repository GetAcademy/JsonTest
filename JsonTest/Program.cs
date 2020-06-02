using System;
using JsonTest.JsonModel;
using Newtonsoft.Json;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
          var json = DummyApi.GetSampleJson();
          var obj = JsonConvert.DeserializeObject<IssuesResponse>(json);
          foreach (var issue in obj.issues)
          {
            var issueId = issue.id;

          }
        }
    }
}
