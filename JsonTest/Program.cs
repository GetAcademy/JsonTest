using System;
using JsonTest.JsonModel;
using Newtonsoft.Json;

namespace JsonTest
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1: kalle api: hente issues
      // 2: for hver issue:
      // 3: gjøre om json-string til objekt: var obj = JsonConvert.DeserializeObject<???>(json);
      // 4: bruke objekt til å hente ut id
      // 5: nytt api-kall etter kommentarene med id
      // 6: gjøre om json-string til objekt: var obj = JsonConvert.DeserializeObject<??>(json);
      // 7: bruke objekt til å hente kommentarene - bruke til det dere skal bruke til

      var json = DummyApi.GetSampleJson();
      var obj = JsonConvert.DeserializeObject<IssuesResponse>(json);
      foreach (var issue in obj.issues)
      {
        var issueId = issue.id;

      }
    }
  }
}
