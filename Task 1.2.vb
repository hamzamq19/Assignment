Module Module1

    Sub Main()

        Dim mName As String
        Dim IDNo As Integer

        mName = " "
        IDNo = 0


       FileOpen(1, "d:\mRec.txt", OpenMode.Input)
        While Not EOF(1)
            
            Input(1, mName)
            Input(1, IDNo)


            Console.WriteLine("Member Name: " & mName)
            Console.WriteLine("Member ID: " & IDNo)
        
        End While

        FileClose(1)

        Console.ReadKey()

    End Sub
End Module 
