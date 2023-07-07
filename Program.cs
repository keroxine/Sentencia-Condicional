using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Hola! :3");
        // Requesting the number to the user
        Console.Write("Ingresa la nota (0-100):");
        
        // Parse the input
        int grade = int.Parse(Console.ReadLine());

        // Validates the grade inputted
        if (grade >= 0 && grade <= 100)
        {
            // Sets variables
            string gradeUS = "";
            string gradeES = "";

            //Determines grade in both US Format and Spanish Format
            if (grade >= 93 && grade <= 100)
            {
                gradeUS = "A+";
                gradeES = "Sobresaliente Alto";
            }

            else if (grade >= 90 && grade <= 92)
            {
                gradeUS = "A";
                gradeES = "Sobresaliente";
            }

            else if (grade >= 87 && grade <= 89)
            {
                gradeUS = "B+";
                gradeES = "Notable Alto";
            }
            
            else if (grade >= 83 && grade <= 86)
            {
                gradeUS = "B";
                gradeES = "Notable";
            }

            else if (grade >= 80 && grade <= 82)
            {
                gradeUS = "B-";
                gradeES = "Notable Bajo";
            }

            else if (grade >= 77 && grade <= 79)
            {
                gradeUS = "C+";
                gradeES = "Bien";
            }

            else if (grade >= 73 && grade <= 76)
            {
                gradeUS = "C";
                gradeES = "Suficiente";
            }
            
            else if (grade >= 70 && grade <= 72)
            {
                gradeUS = "C-";
                gradeES = "Suficiente Bajo";
            }

            else if (grade >= 67 && grade <= 69)
            {
                gradeUS = "D+";
                gradeES = "Insuficiente";
            } 

            else if (grade >= 63 && grade <= 66)
            {
                gradeUS = "D";
                gradeES = "Insuficiente";
            } 

            else if (grade >= 60 && grade <= 62)
            {
                gradeUS = "D-";
                gradeES = "Insuficiente";
            } 

            else if (grade < 60)
            {
                gradeUS = "F";
                gradeES = "Insuficiente";
            } 

            Console.WriteLine("Calificación (EEUU): " + gradeUS);
            Console.WriteLine("Calificación (Español): " + gradeES);
        }

        else
        {
         Console.WriteLine("Error: La nota ingresada no es válida.");
        }
    }





























}
