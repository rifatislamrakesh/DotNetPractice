using Newtonsoft.Json;
using static SalesTotal;
String salesJson = File.ReadAllText("sales.json");
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

Console.WriteLine(salesData?.Total);

File.WriteAllText("totals.txt", salesData?.Total.ToString());

//File.AppendAllText("totals.txt", $"{salesData.Total}{Environment.NewLine}");
