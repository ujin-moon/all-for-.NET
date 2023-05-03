

DateTime now = DateTime.Now;

WriteLine($"D: {now.ToString("D")}");
WriteLine($"d: {now.ToString("d")}");
WriteLine($"F: {now.ToString("F")}");
WriteLine($"f: {now:f}");
WriteLine($"G: {now:G}");
WriteLine($"g: {now:g}");
WriteLine($"M: {now:M}");
WriteLine($"O: {now:O}");
WriteLine($"o: {now:o}");
WriteLine($"R: {now:R}");
WriteLine($"s: {now:s}");
WriteLine($"T: {now:T}");
WriteLine($"t: {now:t}");
WriteLine($"U: {now:U}");
WriteLine($"u: {now:u}");
WriteLine($"Y: {now:Y}");
WriteLine(now.ToString("hh:mm:ss"));

now = now.AddDays(1);   // 28.04.2023
now = now.AddMonths(4); // 28.08.2023
now = now.AddYears(-1); // 28.08.2022
WriteLine(now.ToShortDateString());  // 28.08.2022
WriteLine(now.ToLongDateString());   // 28 августа 2022 г.WriteLine(now.ToString("dd.MM.yyyy"));


TimeOnly time = new TimeOnly(14, 23, 30);
WriteLine(time.Hour);       // 14
WriteLine(time.Minute);     // 23
WriteLine(time.Second);     // 30



 
ScriptEngine engine = Python.CreateEngine();
engine.Execute("print('hello, world')");