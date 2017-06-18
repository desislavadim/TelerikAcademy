using System;


class EmployeesRecord
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        ushort uniqueEmpNumber;

        firstName = "Ivan";
        familyName = "Ivanov";
        age = 25;
        gender = 'm';
        idNumber = 345;
        uniqueEmpNumber = 213;

        Console.WriteLine("Personal Information about {0} {1}\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}