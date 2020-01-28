Module Module1

    Sub Main()
        Dim mName, sName As String
        Dim IDNo As Integer
        Dim isFound As Boolean

        mName = " "
        sName = " "
        IDNo = 0
        isFound = False

        Console.WriteLine("Please enter the name to search: ")
        sName = Console.ReadLine

        FileOpen(1, "D:\mRec.txt", OpenMode.Input)
        While Not EOF(1) And isFound = False
            Input(1, mName)
            Input(1, IDNo)

            If mName = sName Then
                isFound = True
                Console.WriteLine("Member name: " & mName)
                Console.WriteLine("Member ID: " & IDNo)
            End If
        End While
        FileClose(1)
        If isFound = False Then
            Console.WriteLine("Member not found...")
        End If
        Console.ReadKey()

    End Sub

End Module
