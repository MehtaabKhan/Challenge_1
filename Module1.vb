Module Module1

    Sub Main()
        Dim userNames() = {"User1", "User2", "User3", "User4", "User5", ""}
        Dim newUserNames() As Array
        Dim menuInput As String
        Dim newUsersEntered As String
        Dim enterNewUser, loginExistingUser As String
        Dim userName As String
        Dim userPassword As String
        Dim taken As Boolean

        Console.WriteLine("""
Enter menu choice:
Enter 1: login with username and password
Enter 2: register with username and password
Enter 3: quit the program
        """)
        menuInput = Console.ReadLine()

        If menuInput = "3" Then
            exit_program()
        End If
        If menuInput = "1" Or menuInput = "2" Then
            While True
                Console.WriteLine("Welcome to AQA User Registration")
                Console.WriteLine("Username: ")
                userName = Console.ReadLine()
                Console.WriteLine("Password: ")
                userPassword = Console.ReadLine()

                If userPassword.Length <> 12 Then
                    Console.WriteLine("Password not long enough")
                    Continue While
                End If
                For i = 0 To userNames.Length - 1
                    If userName = userNames(i) Then
                        Console.WriteLine("Username is already in the system")
                        taken = True
                    ElseIf userName <> userNames(i) Then
                        Console.WriteLine("User entered")
                        newUsersEntered = userName
                        Dim x = userNames.Length
                        ReDim Preserve userNames(i)
                    Else
                        Continue While
                    End If
                Next
            End While
        End If
    End Sub

    Sub create_user()

    End Sub

    Sub exit_program()
        Console.WriteLine("Goodbye. Program terminated...")
        Threading.Thread.Sleep(1000)
        End
    End Sub

End Module
