namespace Test
{
    internal class Lecture6_StudentDMS
    {
        static Dictionary<string, Dictionary<string, List<double>>> students = new Dictionary<string, Dictionary<string, List<double>>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Data Management System!\n");

            while (true)
            {

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Assign student to subject");
                Console.WriteLine("4. Update a student's grades");
                Console.WriteLine("5. Display all students");
                Console.WriteLine("6. Exit");

                string choice = GetValidChoice();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        AssignSubjectToStudent();
                        break;
                    case "4":
                        UpdateStudentGrade();
                        break;
                    case "5":
                        DisplayAllStudents();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            }
        }
        static string GetValidChoice()
        {
            string choice;

            while (true)
            {
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Allowed choices are: 1, 2, 3, 4, 5, 6.\n");
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter a student's name to add: ");
            string studentName = Console.ReadLine();

            if (students.ContainsKey(studentName))
            {
                Console.WriteLine("The student already exists.\n");
            }
            else
            {
                students[studentName] = new Dictionary<string, List<double>>();
                Console.WriteLine($"Student {studentName} was added to the system.\n");
            }
        }

        static void RemoveStudent()
        {
            Console.Write("Enter a student's name to remove: ");
            string studentName = Console.ReadLine();

            if (students.ContainsKey(studentName))
            {
                students.Remove(studentName);
                Console.WriteLine($"Student {studentName} was removed from the system.\n");
            }
            else
            {
                Console.WriteLine("Student not found.\n");
            }
        }

        static void AssignSubjectToStudent()
        {
            Console.Write("Enter the student name and subject (e.g. John-Math): ");

            string[] input = Console.ReadLine().Split('-');
            if (input.Length != 2)
            {
                Console.WriteLine("Invalid format. Please use: StudentName-Subject.\n");
                return;
            }

            string studentName = input[0].Trim();
            string subject = input[1].Trim();

            if (!students.ContainsKey(studentName))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            List<String> allowedSubjects = new List<string> { "Math", "Biology", "History", "English", "Sport", "Physics" };

            if (!allowedSubjects.Contains(subject))
            {
                Console.WriteLine("Invalid subject. Allowed subjects are: Math, Biology, History, English, Sport, Physics.");
                return;
            }

            if (students[studentName].ContainsKey(subject))
            {
                Console.WriteLine($"{studentName} is already assigned to {subject}.\n");
            }
            else
            {
                students[studentName][subject] = new List<double>();
                Console.WriteLine($"Assigned {studentName} to {subject}.\n");
            }
        }

        static void UpdateStudentGrade()
        {
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            if (!students.ContainsKey(studentName))
            {
                Console.WriteLine("Student not found.\n");
                return;
            }

            Console.Write("Enter the subject name and grade (e.g., Math - 5): ");

            string[] input = Console.ReadLine().Split('-');
            if (input.Length != 2)
            {
                Console.WriteLine("Invalid format. Please use: Subject - Grade.\n");
                return;
            }

            string subject = input[0].Trim();
            if (!students[studentName].ContainsKey(subject))
            {
                Console.WriteLine($"{studentName} is not assigned to {subject}.\n");
                return;
            }

            if (double.TryParse(input[1].Trim(), out double grade) && grade >= 2 && grade <= 6)
            {
                students[studentName][subject].Add(grade);
                Console.WriteLine($"Added grade {grade} for {studentName} in {subject}.\n");
            }
            else
            {
                Console.WriteLine("Invalid grade. The grade should be between 2 and 6.\n");
            }
        }

        static void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.\n");
                return;
            }

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> student in students)
            {
                Console.Write($"{student.Key}");

                foreach (KeyValuePair<string, List<double>> subject in student.Value)
                {

                    double averageSubjectGrade = 0;
                    if (subject.Value.Count > 0)
                    {
                        double sum = 0;
                        foreach (double grade in subject.Value)
                        {
                            sum += grade;
                        }
                        averageSubjectGrade = sum / subject.Value.Count;
                    }

                    Console.WriteLine($", Subjects:\n{subject.Key} - Average grade: {averageSubjectGrade:F2}");
                }

                double overallSum = 0;
                int overallCount = 0;
                foreach (KeyValuePair<string, List<double>> subject in student.Value)
                {
                    overallSum += subject.Value.Sum();
                    overallCount += subject.Value.Count;
                }

                double overallAverage = (overallCount > 0) ? (overallSum / overallCount) : 0;
                Console.WriteLine($"  Overall Average Grade: {overallAverage:F2}\n");
            }
        }
    }
}
