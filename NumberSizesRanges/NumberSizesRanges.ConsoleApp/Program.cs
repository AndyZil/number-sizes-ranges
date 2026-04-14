using Spectre.Console;

namespace NumberSizesRanges.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = GenerateNumbers();

            var table = new Table();
            table.AddColumn("[yellow bold]Type[/]");
            table.AddColumn("[yellow bold]Byte(s) of memory[/]");
            table.AddColumn("[yellow bold]Min[/]");
            table.AddColumn("[yellow bold]Max[/]");
            for (int i = 0; i < nums.Length; i++)
                        {
                var item = nums[i];
                if (i % 2 == 0)
                {
                    table.AddRow(
                        $"[green]{item.Alias}[/]",
                        $"[green]{item.BytesOfMemory}[/]",
                        $"[green]{item.Min}[/]",
                        $"[green]{item.Max}[/]"
                    );
                }
                else
                {
                    table.AddRow(
                        $"[blue]{item.Alias}[/]",
                        $"[blue]{item.BytesOfMemory}[/]",
                        $"[blue]{item.Min}[/]",
                        $"[blue]{item.Max}[/]"
                    );
                }
            }

            AnsiConsole.Write(table);

            Console.WriteLine("\nPress any key to exit the program");
            Console.ReadKey();
        }

        static NumberContainer[] GenerateNumbers()
        {
            return
            [
                new NumberContainer(
                    "sbyte",
                    1,
                    "-128",
                    "127"
                ),
                new NumberContainer(
                    "byte",
                    1,
                    "0",
                    "255"
                ),
                new NumberContainer(
                    "short",
                    2,
                    "-32768",
                    "32767"
                ),
                new NumberContainer(
                    "ushort",
                    2,
                    "0",
                    "65535"
                ),
                new NumberContainer(
                    "int",
                    4,
                    "-2147483648",
                    "2147483647"
                ),
                new NumberContainer(
                    "uint",
                    4,
                    "0",
                    "4294967295"
                ),
                new NumberContainer(
                    "long",
                    8,
                    "-9_223_372_036_854_775_808",
                    "9_223_372_036_854_775_807"
                ),
                new NumberContainer(
                    "ulong",
                    8,
                    "0",
                    "18_446_744_073_709_551_615"
                ),
                new NumberContainer(
                    "int128",
                    16,
                    "-170_141_183_460_469_231_731_687_303_715_884_105_728",
                    "170_141_183_460_469_231_731_687_303_715_884_105_727"
                ),
                new NumberContainer(
                    "uint128",
                    16,
                    "0",
                    "340_282_366_920_938_463_463_374_607_431_768_211_455"
                ),
                new NumberContainer(
                    "half",
                    2,
                    "-65500",
                    "65500"
                ),
                new NumberContainer(
                    "float",
                    4,
                    "-3.4028235E+38",
                    "3.4028235E+38"
                ),
                new NumberContainer(
                    "double",
                    8,
                    "-1.7976931348623157E+308",
                    "1.7976931348623157E+308"
                ),
                new NumberContainer(
                    "decimal",
                    16,
                    "-79_228_162_514_264_337_593_543_950_335",
                    "79_228_162_514_264_337_593_543_950_335"
                ),
            ];
        }
    }
}