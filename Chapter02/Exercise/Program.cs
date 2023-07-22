using static System.Console;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

WriteLine("基本数据类型大小展示");
WriteLine($"type:sbyte,memerySize:{sizeof(sbyte)},min{sbyte.MinValue},max{sbyte.MaxValue}");
WriteLine($"type:byte,memerySize:{sizeof(byte)},min{byte.MinValue},max{byte.MaxValue}");
WriteLine($"type:short,memerySize:{sizeof(short)},min{short.MinValue},max{short.MaxValue}");
WriteLine($"type:ushort,memerySize:{sizeof(ushort)},min{ushort.MinValue},max{ushort.MaxValue}");
WriteLine($"type:int,memerySize:{sizeof(int)},min{int.MinValue},max{int.MaxValue}");
WriteLine($"type:uint,memerySize:{sizeof(uint)},min{uint.MinValue},max{uint.MaxValue}");
WriteLine($"type:long,memerySize:{sizeof(long)},min{long.MinValue},max{long.MaxValue}");
WriteLine($"type:ulong,memerySize:{sizeof(ulong)},min{ulong.MinValue},max{ulong.MaxValue}");
WriteLine($"type:float,memerySize:{sizeof(float)},min{float.MinValue},max{float.MaxValue}");
WriteLine($"type:double,memerySize:{sizeof(double)},min{double.MinValue},max{double.MaxValue}");
WriteLine($"type:decimal,memerySize:{sizeof(decimal)},min{decimal.MinValue},max{decimal.MaxValue}");