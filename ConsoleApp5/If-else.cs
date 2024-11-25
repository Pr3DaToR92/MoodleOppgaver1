using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp5;

//If og else oppgaver fra Moodle
public class Class1
{
    public static void WhatIf()
    {
        var nr1 = 2;
        var nr2 = 2;
        var isEqual = false;

        if (nr1 == nr2)
        {
            isEqual = true;
            Console.WriteLine(isEqual);
        }
        else
        {
            isEqual = false;
            Console.WriteLine(isEqual);
        }
    }
    public static void WhatIf2()
    {
        var nr1 = 2;
        var nr2 = 3;
        bool isEqual = true;

        if (nr1 == nr2)
        {
            isEqual = false;
            int sum = nr1 + nr2;
            Console.WriteLine(sum);
        }
        else
        {
            isEqual = true;
            int sum = nr1 * nr2;
            Console.WriteLine(sum);
        }
    }
}