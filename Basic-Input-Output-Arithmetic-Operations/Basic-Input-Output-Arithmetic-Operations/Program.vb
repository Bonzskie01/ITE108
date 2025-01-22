Imports System

Module Program
    Sub Main(args As String())
        Dim fNum, secNum, sum, productResult, rDifference As Integer
        Dim quotientResult As Double

        Console.WriteLine("Simple Arithmetic Operation")
        Console.Write("Enter the First Number: ")
        fNum = Convert.ToInt32(Console.ReadLine)
        Console.Write("Enter the Second Number: ")
        secNum = Convert.ToInt32(Console.ReadLine)

        'FORMULAS'
        sum = (fNum + secNum)
        productResult = (fNum * secNum)
        rDifference = (fNum - secNum)
        quotientResult = (fNum / secNum) ' Dividing two integers results in an integer quotient

        Console.WriteLine("====THE OUTPUT=====")
        Console.WriteLine("The sum of two numbers is: " & sum)
        Console.WriteLine("The product of two numbers is: " & productResult)
        Console.WriteLine("The difference of two numbers is: " & rDifference)
        Console.WriteLine("The quotient of two numbers is: " & quotientResult)



    End Sub
End Module
