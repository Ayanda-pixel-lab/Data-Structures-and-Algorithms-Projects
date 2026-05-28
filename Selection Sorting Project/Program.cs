using System;

class Student
{
    static void Main(string[] args)
    {
        //Phase 1 Declaring variables
        var Students = new List<(int ID, string name)>{ 
                                             (45038, "\tLily Morgan"),
                                             (23379, "\tSamuel Price"),
                                             (65921, "\tAria Torres"),
                                             (98412, "\tOwen Foster"),
                                             (30746, "\tGrace Coleman"),
                                             (52461, "\tHenry Hughes"),
                                             (14329, "\tRuby Bennett"),
                                             (87605, "\tJulian Knight"),
                                             (39817, "\tNatalie Cruz"),
                                             (58241, "\tAaliyah Moreno"),
                                             (74029, "\tMarcus Holt"),
	                                         (31658, "\tZoe Patel"),
                                             (49503, "\tElijah Turner"),
                                             (20874, "\tClara Nguyen"),
                                             (83716, "\tXavier Cruz"),
                                             (67120, "\tPriya Shah"),
                                             (15984, "\tNoah Bennett"),
                                             (92340, "\tSofia Ricci"),
                                             (40472, "\tIsaac Kim"),
                                             (25061, "\tMaya Jackson"),
                                             (78653, "\tLiam O'Connor"),
                                             (31905, "\tHannah Rivera"),
                                             (54897, "\tDaniel Brooks"),
                                             (61284, "\tChloe Park"),
                                             (47215, "\tGabriel Flores"),
                                             (13790, "\tOlivia Simmons"),
                                             (80542, "\tMateo Alvarez"),
                                             (26813, "\tEmma Wallace"),
                                             (79164, "\tBenjamin Reed"),
                                             (87014, "\tFelix Dawson")

        };
        Console.WriteLine("~~~~~~~~~~ STUDENTS ~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Students Unsorted List: ");
        Console.WriteLine();
        Console.WriteLine("Student Number \tStudent Name");
        Console.WriteLine("-------------------------------------------");

        //Show the unsorted list of students
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        //Phase 2: Sorting
        for (int i = 0; i < Students.Count - 1; i++)
        {
            int min_index = i;
           
            for(int j = i+1; j < Students.Count; j++)
            {
                if (Students[j].ID < Students[min_index].ID)
                {
                    min_index = j;

                }
            }
            var temp = Students[min_index];
            Students[min_index] = Students[i];
            Students[i]= temp;

        }
        Console.WriteLine("Students Sorted List: ");
        Console.WriteLine();
        Console.WriteLine("Student Number \t\tStudent Name");
        Console.WriteLine("-------------------------------------------");

        //Show the lists with sorted student IDs
        for(int k = 1; k <= Students.Count; k++)
        {
            Console.WriteLine(k + "."+ Students[k-1].ID + " \t" + Students[k-1].name);
        }
        Console.WriteLine();

        //Phase 3: Allow the user to add more students if they want to
        Console.Write("Do you want to add more students? Y/N: ");
        string answer = Console.ReadLine();

       

        if (answer == "Y")
        {
            Console.Write("How many students do you want to add? : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int a = 0; a < num; a++)
            {
                Console.Write("Enter student ID: ");
                int id = int.Parse(Console.ReadLine());
                if (id < 10000 || id > 99999)
                {
                    Console.Write("INVALID ID! Student Id should have 5 digits.\nEnter student id: ");
                    id = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter student Fullname: ");
                string fullname = Console.ReadLine();

                Students.Add((id , "\t" + fullname));
                Console.WriteLine("Students added successfully.");
                Console.WriteLine();
            }

            //Sort the list after adding more students
            for (int i = 0; i < Students.Count - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < Students.Count; j++)
                {
                    if (Students[j].ID < Students[min_index].ID)
                    {
                        min_index = j;

                    }
                }
                var temp = Students[min_index];
                Students[min_index] = Students[i];
                Students[i] = temp;

            }
            Console.WriteLine("Students Updated List: ");
            Console.WriteLine();
            Console.WriteLine("Student Number \t\tStudent Name");
            Console.WriteLine("-------------------------------------------");

            //Show the lists with sorted student IDs
            for (int k = 1; k <= Students.Count; k++)
            {
                Console.WriteLine(k + "." + Students[k - 1].ID + " \t" + Students[k - 1].name);
            }
            Console.WriteLine();
        }
        if(answer == "N")
        {
            Console.WriteLine("Nothing was changed!");
            Console.WriteLine();
        }
       

        //Phase 4: Allow the user to remove students
        Console.Write("Do you want to remove any student? Y/N: ");
        string reply = Console.ReadLine();
       

        if (reply == "Y")
        {
            Console.Write("How many students do you want to remove?: ");
            int numb = int.Parse(Console.ReadLine());

            for(int b =0; b < numb; b++)
            {
                Console.Write("Enter student ID: ");
                int ID = int.Parse(Console.ReadLine());
                int result = Students.FindIndex(s => s.ID == ID);
                if (result != -1)
                {
                    string studentRemoved = Students[result].name;
                    Students.RemoveAt(result);
                    Console.WriteLine("You just removed " + studentRemoved);
                }
                else
                {
                    Console.WriteLine("Student not found! Nothing was changed.");
                }
            }
            Console.WriteLine("Students Updated List: ");
            Console.WriteLine();
            Console.WriteLine("Student Number \t\tStudent Name");
            Console.WriteLine("-------------------------------------------");

            
            for (int k = 1; k <= Students.Count; k++)
            {
                Console.WriteLine(k + "." + Students[k - 1].ID + " \t" + Students[k - 1].name);
            }
            Console.WriteLine();
        }
        if (reply == "N")
        {
            Console.WriteLine("Nothing was changed!");
            Console.WriteLine();
        }
       
    }
}
