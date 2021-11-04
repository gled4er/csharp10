using csharp10.Struct;

var m1 = new Measurement();
Console.WriteLine(m1);

var m2 = default(Measurement);
Console.WriteLine(m2);

var ms = new Measurement[2];
Console.WriteLine(string.Join(",", ms));

