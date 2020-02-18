Module Program
    Sub Main(args As String())
        Dim Salary As ULong
        Dim Tax_Percent As Double
        Dim afterIncomeTaxReduction As Double
        Console.WriteLine("Enter your Salary")
        Salary = Console.ReadLine()
        If Salary <= 100000 Then
            Tax_Percent = 10 / 100
            Console.WriteLine("As your salary is less and equal to than 100000 the income tax is 10%")
        ElseIf 100000 < Salary And Salary < 500000 Then
            Tax_Percent = 20 / 100
            Console.WriteLine("As your salary is more than 100000 but less than 500000 the income tax is 20%")
        ElseIf Salary >= 500000 Then
            Tax_Percent = 30 / 100
            Console.WriteLine("As your salary is more than and equal to 500000 the income tax is 30%")
        Else
            Console.WriteLine()
        End If
        afterIncomeTaxReduction = Salary - (Salary * Tax_Percent)
        Console.WriteLine("Your Salary after income tax reduction is " & afterIncomeTaxReduction)
        Console.ReadLine()
    End Sub
End Module
