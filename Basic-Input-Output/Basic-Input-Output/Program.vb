Imports System

Module My_FirstProgram
    Sub Main(args As String())
        Console.WriteLine("Input your Details: ")
        Dim fName, lName, address, course, motto, age, number As String

        Console.Write($"Input your First Name: {fName}")
        fName = Console.ReadLine()
        Console.Write("Enter your Last Name: " & lName)
        lName = Console.ReadLine()
        Console.Write("Enter your Address: " & address)
        address = Console.ReadLine()
        Console.Write("Enter your Course: " & course)
        course = Console.ReadLine()
        Console.Write("What is your Motto: " & motto)
        motto = Console.ReadLine()
        Console.Write("Enter your Age: " & age)
        age = Console.ReadLine()
        Console.Write("Enter your Phone Number: " & number)
        number = Console.ReadLine()

        Console.WriteLine("=====My Details====")
        Console.WriteLine("My Name is: " & fName & " " & lName)
        Console.WriteLine("My Age is: " & age)
        Console.WriteLine("My Phone# is: " & number)
        Console.WriteLine("My Address is: " & address)
        Console.WriteLine("My Course is: " & course)
        Console.WriteLine("My Motto in life is: " & motto)
        Console.WriteLine("=====END====")

    End Sub
End Module
