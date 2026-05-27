using System.Runtime.Intrinsics.Arm;

Counter c1=new Counter();
Counter c2=new Counter();


Counter.add();
Counter.add();
Counter.add();
Counter.add();
Console.WriteLine($"Count1 is {c1.GetCount()}");
Counter.add();
Counter.add();
Console.WriteLine($"New Count1 is {c1.GetCount()}");



Counter.add();
Counter.add();
Console.WriteLine($"Count is {c2.GetCount}");
Counter.add();
Counter.add();
Console.WriteLine($"New Count is {c2.GetCount()}");