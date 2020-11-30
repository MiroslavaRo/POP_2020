using System;

namespace POP_Class_work_lesson_9
{
        internal class Program
        {
            private static void Main(string[] args)
            {
                #region FileHelper

                //FileHelper.CreateOrUpdateFile("file1.txt", "Content number 1 on new line");
                //string fileContent = FileHelper.ReadFile("file1.txt");
                //Console.WriteLine(fileContent);
                //Console.ReadLine();
                //FileHelper.DeleteFile("file1.txt");

                #endregion FileHelper

                #region Count words

                //UpdateFile("file2.txt", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s");

                //string file2content = ReadFile("file2.txt");

                //int wordsCount = CountWords(file2content);

                //Console.WriteLine(file2content);

                //Console.WriteLine($"Words count = {wordsCount}");

                #endregion Count words

                #region Read Write Int Array to File

                //string fileName = "test3.txt";

                //int[] intArray = { 1, 2, 3, 4, 5 };

                //WriteIntArrayToFile(fileName, intArray);

                //intArray = ReadIntArrayFromFile(fileName);

                //Console.ReadLine();

                #endregion Read Write Int Array to File

                // ProcessExpressionsFile();

                StudentScores();
            }

            public static void StudentScores()
            {
                string studentsFileName = "../../../students.txt";
                string coursesFileName = "../../../scores.txt";

                List<Student> students = new List<Student>();

                string[] inputLines = File.ReadAllLines(studentsFileName);

                // Import students
                foreach (string line in inputLines)
                {
                    string[] studentArray = line.Split('|');

                    Student student = new Student
                    {
                        FirstName = studentArray[0].Trim(),
                        LastName = studentArray[1].Trim(),
                        StudentNumber = studentArray[2].Trim()
                    };

                    students.Add(student);
                }

                // Import scores
                inputLines = File.ReadAllLines(coursesFileName);
                string courseName = "";
                foreach (string line in inputLines)
                {
                    if (line.StartsWith("Course"))
                    {
                        string[] courseArray = line.Split(' ');
                        courseName = courseArray[1];
                    }
                    else
                    {
                        string[] scoreArray = line.Split('|');
                        string studentNumber = scoreArray[0].Trim();
                        if (decimal.TryParse(scoreArray[1], out decimal score))
                        {
                            Student s = students.Find(s => s.StudentNumber == studentNumber); // Using Linq
                            if (s != null)
                            {
                                s.Scores.Add(new Score
                                {
                                    Course = courseName,
                                    Value = score
                                });
                            }
                        }
                    }
                }

                // Display all students
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
                Console.WriteLine();

                // Search for student
                while (true)
                {
                    Console.Write("Enter student number or 0 to exit: ");
                    string numberToFind = Console.ReadLine();

                    if (numberToFind == "0")
                    {
                        break;
                    }

                    Console.WriteLine();

                    Student student = students.Find(s => s.StudentNumber == numberToFind); // Using Linq

                    if (student != null)
                    {
                        Console.WriteLine(student.ToString());
                        foreach (var score in student.Scores)
                        {
                            Console.WriteLine($"{score.Course,-10} {score.Value:0.00}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"There is no student with student number = {numberToFind}");
                    }
                    Console.WriteLine();
                }
            }

            public static void ProcessExpressionsFile()
            {
                string inputFileName = "../../../input.txt";
                string outputFileName = "../../../output.txt";

                string[] inputLines = File.ReadAllLines(inputFileName);

                string result = "";

                foreach (string line in inputLines)
                {
                    result += Calculation(line) + Environment.NewLine;
                }

                File.WriteAllText(outputFileName, result);
            }

            public static string Calculation(string expression)
            {
                string[] expArray = expression.Split(' ');

                decimal A = decimal.Parse(expArray[0].Replace(".", ","));
                decimal B = decimal.Parse(expArray[2].Replace(".", ","));
                decimal result = 0;

                string operation = expArray[1];

                switch (operation)
                {
                    case "+":
                        result = A + B;
                        break;

                    case "-":
                        result = A - B;
                        break;

                    case "*":
                        result = A * B;
                        break;

                    case "/":
                        result = A / B;
                        break;
                }

                return result.ToString();
            }

            public static void WriteIntArrayToFile(string fileName, int[] array)
            {
                StreamWriter writer = File.AppendText(fileName);
                foreach (int i in array)
                {
                    writer.Write(i.ToString() + " ");
                }
                writer.Close();
            }

            public static int[] ReadIntArrayFromFile(string fileName)
            {
                string[] fileContent = File.ReadAllText(fileName).Trim().Split(' ');

                int[] intArray = new int[fileContent.Length];

                for (int i = 0; i < fileContent.Length; i++)
                {
                    intArray[i] = int.Parse(fileContent[i]);
                }

                return intArray;
            }

            public static void UpdateFile(string fileName, string content)
            {
                if (!File.Exists(fileName))
                {
                    StreamWriter writer = File.CreateText(fileName);
                    writer.Write(content);
                    writer.Close();
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(fileName))
                    {
                        writer.Write(content);
                    }
                }
            }

            public static string ReadFile(string fileName)
            {
                return File.ReadAllText(fileName);
            }

            public static int CountWords(string freeText)
            {
                if (string.IsNullOrWhiteSpace(freeText))
                {
                    return 0;
                }

                freeText = freeText.Replace("  ", " ");
                freeText = freeText.Replace(Environment.NewLine, " ");

                return freeText.Split(' ').Length;
            }
        }
    }

}
