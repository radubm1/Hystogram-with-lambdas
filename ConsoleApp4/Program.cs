// Hystogram example

var arr = new int[] {1,2,3,4,4,4,5,5,5,6,7,7};

var hst = arr.GroupBy(x => x).Select(x => new { Key = x.Key, Value = x.Count() }).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=> x.Value);

foreach (var h in hst)  
    Console.WriteLine(String.Join(" ", h));
