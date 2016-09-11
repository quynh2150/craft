using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class JSon
    {
        string jsonString = @"{
    ""HasErrors"": false,
    ""Includes"": {
        ""test"": {
            ""testdata1"": {
                ""ReviewStatistics"": {
                    ""RecommendedCount"": 0,
                    ""TotalReviewCount"": 2
                }
            },
            ""testdata2"": {
                ""ReviewStatistics"": {
                    ""RecommendedCount"": 1,
                    ""TotalReviewCount"": 2
                }
            },
            ""testdata3"": {
                ""ReviewStatistics"": {
                    ""RecommendedCount"": 3,
                    ""TotalReviewCount"": 2
                }
            }
        }
    }
}";
        public void JSONMethod() {
            JObject obj = JObject.Parse(jsonString);
            var testdata = obj.SelectTokens("$..ReviewStatistics.RecommendedCount").ToList();
        }
    }
}
//var testDataList = obj["Includes"]["test"].Children();
//var reviewStatsList = testDataList.Children();
//var datatads = reviewStatsList.Children()["RecommendedCount"];
//foreach (var item in reviewStatsList)
//{

//}

//var recCounts = reviewStatsList.Children().Select(a => a).ToList();
//var totalCounts = reviewStatsList.Select(r => (int)r["TotalReviewCount"]).ToList();
//foreach (var item in recCounts)
//{
//    Console.WriteLine(item.ToString());
//}
////Console.Read();

//var testdata = obj["Includes"]["test"].Children();
//var stats = testdata.Children().Children().Children();
//var rec = stats.(x=>x["RecommendedCount"]).ToList();
