'Seth Rasmussen
'RCET 0265
'Spring 2022
'Convert And Validate
'

Option Explicit On
Option Strict On
Module ConvertValidate

    Sub Main()

        'User inputs a number that is read as string
        Dim Input As String
        'This variable is used to decide if the string number can be a integer number
        Dim Number As Integer
        'Is the string entered a valid number form?
        Dim numberValid As Boolean = False

        'repeat inputs until the user gets an actual number
        Do Until numberValid
            Console.WriteLine("Enter a number")
            Input = Console.ReadLine()
            numberValid = ConversionValid(Input, Number) ' Call to Function

            'Use $ to concadinate the input number with the rest of the string message also {}
            'True sting is number
            If numberValid Then
                Console.WriteLine($"{Input} Converted to {Number}")

                'False String is not a number try again
            Else
                Console.WriteLine("Not a number try again")
            End If
        Loop

        'stop code so user can see the number is converted
        Console.ReadLine()

    End Sub

    'Create a function that proves if the user input number is a integer or not
    Function ConversionValid(ByVal stringValue As String, ByRef iIteger As Integer) As Boolean
        'True or fasle so code can make an integer or prompt for another input
        Dim Valid As Boolean

        Try
            iIteger = CInt(stringValue)
            Valid = True
        Catch
            Valid = False
        End Try

        Return Valid 'Call function for main

    End Function
End Module