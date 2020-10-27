using System;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;
using DiffPlex.Model;

namespace DiffPlex.ConsoleRunner
{
    internal static class Program
    {
        private static void Main()
        {
            //var diffBuilder = new InlineDiffBuilder(new Differ());
            //var diff = diffBuilder.BuildDiffModel(OldText, NewText);

            //foreach (var line in diff.Lines)
            //{
            //    switch (line.Type)
            //    {
            //        case ChangeType.Inserted:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.Write("+ ");
            //            break;
            //        case ChangeType.Deleted:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write("- ");
            //            break;
            //        default:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.Write("  ");
            //            break;
            //    }

            //    Console.WriteLine(line.Text);
            //}

            DiffResult result = new Differ().CreateLineDiffs(OldText, NewText, true, true);
            SideBySideDiffBuilder builder = new SideBySideDiffBuilder();
            SideBySideDiffModel result1 = builder.BuildDiffModel(OldText, NewText, true);

        }

        private const string OldText =
            @"interface ethernet 0
 ip address 10.1.1.2 255.255.255.0
 mac-address 4000.0000.0010
 standby 1 ip 10.1.1.1
 standby 1 priority 200
interface ethernet 1
 ip address 10.1.2.2 255.255.255.0
 mac-address 4000.0000.0011
 standby 1 ip 10.1.2.1
 standby 1 priority 200";

        private const string NewText =
            @"standby 1 ip 10.2.2.1
 standby 1 priority 200";
    }
}