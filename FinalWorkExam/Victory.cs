namespace FinalWorkExam
{
    class Victory
    {
        public List<Quiz> Quizes { get; set; } = new List<Quiz>();

        public Victory()
        {
            Quizes.Add(new Quiz()
            {
                Title = "Geography",
                Questions = new List<Question>()
        {
            new Question()
            {
                queston = "Which countries are located in Europe?",
                answers = ["Ukraine", "Brazil", "France", "Egypt"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "Which oceans exist on Earth?",
                answers = ["Atlantic Ocean", "Indian Ocean", "Mediterranean Sea", "Pacific Ocean"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is the capital of Ukraine?",
                answers = ["Lviv", "Kyiv", "Odesa", "Kharkiv"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which countries have a coastline on the Black Sea?",
                answers = ["Ukraine", "Turkey", "Poland", "Bulgaria"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which of these are among the longest rivers in the world?",
                answers = ["Nile", "Amazon", "Dnipro", "Yangtze"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which of these are continents?",
                answers = ["Africa", "Eurasia", "Europe", "Australia"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is the highest mountain in the world?",
                answers = ["Mount Everest", "Kilimanjaro", "Mont Blanc", "Hoverla"],
                correctIndexes = [0]
            },
            new Question()
            {
                queston = "Which countries are among the largest in the world by area?",
                answers = ["Russia", "Canada", "China", "Italy"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which seas border Ukraine?",
                answers = ["Black Sea", "Sea of Azov", "Baltic Sea", "Mediterranean Sea"],
                correctIndexes = [0, 1]
            },
            new Question()
            {
                queston = "Which of these are European capitals?",
                answers = ["Paris", "Berlin", "New York", "Rome"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which of these are deserts?",
                answers = ["Sahara", "Gobi", "Karakum", "Antarctic Desert"],
                correctIndexes = [0, 1, 2, 3]
            },
            new Question()
            {
                queston = "Which countries are located in South America?",
                answers = ["Brazil", "Argentina", "Spain", "Chile"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which natural zones can be found in Ukraine?",
                answers = ["Forest", "Forest-steppe", "Steppe", "Tundra"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which countries are members of the European Union?",
                answers = ["Germany", "France", "Canada", "Italy"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which mountains are located in Europe?",
                answers = ["Alps", "Carpathians", "Himalayas", "Pyrenees"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which rivers flow through Ukraine?",
                answers = ["Dnipro", "Dnister", "Volga", "Southern Bug"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which countries are located in Asia?",
                answers = ["China", "Japan", "India", "Portugal"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which is the largest ocean?",
                answers = ["Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which countries are located in Africa?",
                answers = ["Egypt", "Kenya", "Nigeria", "Norway"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which coordinates are used to determine a location on Earth?",
                answers = ["Latitude", "Longitude", "Altitude", "Temperature"],
                correctIndexes = [0, 1]
            }
        }
            });


            Quizes.Add(new Quiz()
            {
                Title = "Biology",
                Questions = new List<Question>()
        {
            new Question()
            {
                queston = "Which organs belong to the digestive system?",
                answers = ["Stomach", "Heart", "Intestines", "Liver"],
                correctIndexes = [0, 2, 3]
            },
            new Question()
            {
                queston = "Which organisms are multicellular?",
                answers = ["Human", "Dog", "Amoeba", "Tree"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which organ pumps blood through the body?",
                answers = ["Lungs", "Heart", "Liver", "Kidneys"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which organs are responsible for breathing?",
                answers = ["Lungs", "Stomach", "Bronchi", "Trachea"],
                correctIndexes = [0, 2, 3]
            },
            new Question()
            {
                queston = "What do plants need for photosynthesis?",
                answers = ["Light", "Carbon dioxide", "Oxygen", "Water"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which animals are mammals?",
                answers = ["Whale", "Dolphin", "Shark", "Dog"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which structures are found in plant cells?",
                answers = ["Cell wall", "Chloroplasts", "Nucleus", "Lungs"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which organs belong to the excretory system?",
                answers = ["Kidneys", "Ureters", "Heart", "Urinary bladder"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which animals are vertebrates?",
                answers = ["Fish", "Frog", "Butterfly", "Bird"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which are the main nutrients needed by the human body?",
                answers = ["Proteins", "Fats", "Carbohydrates", "Sand"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which structures belong to the nervous system?",
                answers = ["Brain", "Spinal cord", "Nerves", "Stomach"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which animals are amphibians?",
                answers = ["Frog", "Newt", "Lizard", "Salamander"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Where does photosynthesis take place?",
                answers = ["Chloroplasts", "Mitochondria", "Nuclei", "Chlorophyll"],
                correctIndexes = [0, 3]
            },
            new Question()
            {
                queston = "Which blood types exist in the ABO system?",
                answers = ["Type O", "Type A", "Type B", "Type AB"],
                correctIndexes = [0, 1, 2, 3]
            },
            new Question()
            {
                queston = "Which bones are part of the human skeleton?",
                answers = ["Femur", "Humerus", "Skull", "Lung"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which organisms belong to the fungi kingdom?",
                answers = ["Mold", "Yeast", "Mushroom", "Moss"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "What carries oxygen in the blood?",
                answers = ["Red blood cells", "Hemoglobin", "Platelets", "White blood cells"],
                correctIndexes = [0, 1]
            },
            new Question()
            {
                queston = "Which organs belong to the reproductive system?",
                answers = ["Ovaries", "Testes", "Uterus", "Heart"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which animals are reptiles?",
                answers = ["Snake", "Crocodile", "Turtle", "Dolphin"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which characteristics are typical of living organisms?",
                answers = ["Growth", "Reproduction", "Respiration", "Rusting"],
                correctIndexes = [0, 1, 2]
            }
        }
            });


            Quizes.Add(new Quiz()
            {
                Title = "Mathematics",
                Questions = new List<Question>()
        {
            new Question()
            {
                queston = "What is 5 + 7?",
                answers = ["10", "11", "12", "13"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which numbers are even?",
                answers = ["2", "5", "8", "11"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "What is 9 × 6?",
                answers = ["45", "54", "56", "63"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which numbers are prime?",
                answers = ["2", "3", "4", "7"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 100 ÷ 4?",
                answers = ["20", "25", "30", "40"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which fractions are proper fractions?",
                answers = ["1/2", "3/2", "2/3", "5/3"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "How many degrees are in a right angle?",
                answers = ["45", "90", "180", "360"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which shapes are polygons?",
                answers = ["Triangle", "Square", "Circle", "Pentagon"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 15 - 8?",
                answers = ["5", "6", "7", "8"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which numbers are divisible by 3?",
                answers = ["9", "12", "14", "18"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "How many sides does a triangle have?",
                answers = ["2", "3", "4", "5"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which numbers are negative?",
                answers = ["-5", "3", "-10", "0"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "What is 7²?",
                answers = ["14", "21", "49", "56"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which equations have x = 5 as a solution?",
                answers = ["x + 2 = 7", "x - 3 = 2", "2x = 10", "x + 1 = 10"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "How many centimeters are in 1 meter?",
                answers = ["10", "50", "100", "1000"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which numbers are multiples of 5?",
                answers = ["10", "15", "22", "30"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "How many degrees are in a straight angle?",
                answers = ["90", "180", "270", "360"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which numbers are natural numbers?",
                answers = ["1", "5", "-3", "10"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 12 × 12?",
                answers = ["124", "144", "154", "164"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which shapes have four sides?",
                answers = ["Square", "Rectangle", "Triangle", "Rhombus"],
                correctIndexes = [0, 1, 3]
            }
        }
            });

            Quizes.Add(new Quiz()
            {
                Title = "Mixed",
                Questions = new List<Question>()
            {
            new Question()
            {
                queston = "What is the capital of France?",
                answers = ["Paris", "Berlin", "Madrid", "Rome"],
                correctIndexes = [0]
            },
            new Question()
            {
                queston = "What is 8 × 7?",
                answers = ["54", "56", "64", "48"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which countries are located in South America?",
                answers = ["Brazil", "Argentina", "Spain", "Chile"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 144 ÷ 12?",
                answers = ["10", "11", "12", "14"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which is the largest continent?",
                answers = ["Africa", "Asia", "Europe", "Australia"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which numbers are prime?",
                answers = ["2", "4", "7", "9"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "Which oceans exist on Earth?",
                answers = ["Atlantic Ocean", "Indian Ocean", "Mediterranean Sea", "Pacific Ocean"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 25 + 37?",
                answers = ["52", "62", "72", "60"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which countries have a coastline on the Black Sea?",
                answers = ["Ukraine", "Turkey", "Poland", "Bulgaria"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "How many degrees are in a right angle?",
                answers = ["45", "90", "180", "360"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which of these are deserts?",
                answers = ["Sahara", "Gobi", "Karakum", "Amazon"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "What is 9²?",
                answers = ["18", "72", "81", "90"],
                correctIndexes = [2]
            },
            new Question()
            {
                queston = "Which rivers flow through Ukraine?",
                answers = ["Dnipro", "Dnister", "Volga", "Southern Bug"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which numbers are divisible by 5?",
                answers = ["10", "13", "25", "32"],
                correctIndexes = [0, 2]
            },
            new Question()
            {
                queston = "Which mountains are located in Europe?",
                answers = ["Alps", "Carpathians", "Himalayas", "Pyrenees"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "What is 100 - 47?",
                answers = ["43", "53", "57", "63"],
                correctIndexes = [1]
            },
            new Question()
            {
                queston = "Which countries are located in Asia?",
                answers = ["China", "Japan", "India", "Portugal"],
                correctIndexes = [0, 1, 2]
            },
            new Question()
            {
                queston = "Which shapes have four sides?",
                answers = ["Square", "Rectangle", "Triangle", "Rhombus"],
                correctIndexes = [0, 1, 3]
            },
            new Question()
            {
                queston = "Which seas border Ukraine?",
                answers = ["Black Sea", "Sea of Azov", "Baltic Sea", "Mediterranean Sea"],
                correctIndexes = [0, 1]
            },
            new Question()
            {
                queston = "What is 15 × 4?",
                answers = ["50", "55", "60", "65"],
                correctIndexes = [2]
            }
        }
            });

        }

        public void SortResult(string fileName)
        {
            string[] result = File.ReadAllLines(fileName);

            var top20 = from line in result
                orderby int.Parse(line.Split(" --> ")[1].Split('/')[0]) 
                descending
                select line;

            File.WriteAllLines(fileName, top20.Take(20));

            Console.WriteLine("____TOP 20____");

            foreach (var item in top20.Take(20))
            {
                Console.WriteLine(item);
            }
        }


        public void EditingVictory()
        {
            for (int i = 0; i < Quizes.Count; i++)
            {
                Console.WriteLine($"{i + 1} --> {Quizes[i].Title}");
            }

            Console.WriteLine("enter quiz");
            int numberQiuz = int.Parse(Console.ReadLine());

            var selectedQuizData = Quizes[numberQiuz - 1];

            MyEnum.myEnum selectedQuiz = (MyEnum.myEnum)numberQiuz;


            foreach (var item in Quizes)
            {
                if (item.Title == selectedQuiz.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item.Title);
                    Console.ResetColor();
                    int i = 1;
                    foreach (var item1 in item.Questions)
                    {
                        Console.WriteLine($"\nQuestion --> {i}\n");

                        Console.WriteLine(item1.queston);
                        for (int j = 0; j < item1.answers.Length; j++)
                        {
                            Console.WriteLine($"{j + 1} --> {item1.answers[j]}");
                        }
                        i++;
                    }
                    Console.WriteLine("Which question should be changed?");
                    
                    int choice = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Write new Question");

                    string NewQuestion = Console.ReadLine();

                    item.Questions[choice - 1].queston = NewQuestion;

                    Console.WriteLine($"Enter answers");

                    string[] NewAnswers = new string[4];

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Enter answers {j + 1} --> ");
                        NewAnswers[j] = Console.ReadLine();

                    }

                    item.Questions[choice - 1].answers = NewAnswers;

                    Console.Write("How many correct answers? --> ");

                    int countCorrect = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter correct answer indexes (1-4)");

                    int[] CorrectAnswers = new int[countCorrect];

                    for (int j = 0; j < countCorrect; j++)
                    {
                        Console.Write($"Correct answer {j + 1} --> ");
                        CorrectAnswers[j] = int.Parse(Console.ReadLine());
                    }

                    item.Questions[choice - 1].correctIndexes = CorrectAnswers;
                }
            }
        }

        public void Run()
        {
            string fileResultGeo = "resultGeo.txt";
            string fileResultMath = "resultMath.txt";
            string fileResultBiol = "resultBiol.txt";
            string fileResultMixed = "resultMixed.txt";

            int correctAnwers = 0;


            for (int i = 0; i < Quizes.Count; i++)
            {
                Console.WriteLine($"{i+1} --> {Quizes[i].Title}");
            }

            Console.WriteLine("enter quiz");
            int numberQiuz = int.Parse(Console.ReadLine());

            var selectedQuizData = Quizes[numberQiuz - 1];

            Console.Clear();
            MyEnum.myEnum selectedQuiz = (MyEnum.myEnum)numberQiuz;

            foreach (var item in Quizes)
            {
                if (item.Title == selectedQuiz.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item.Title);
                    Console.ResetColor();
                    int i = 1;
                    foreach (var item1 in item.Questions)
                    {
                        Console.WriteLine($"\nQuestion --> {i}\n");
                        Console.WriteLine(item1.queston);
                        for (int j = 0; j < item1.answers.Length; j++)
                        {
                            Console.WriteLine($"{j + 1} --> {item1.answers[j]}");
                        }
                        i++;

                        List<int> userAnswers = new List<int>();

                        while (true)
                        {
                            var key = Console.ReadKey();

                            if (key.Key == ConsoleKey.D1)
                            {
                                userAnswers.Add(0);
                                Console.WriteLine(" --> selected");
                            }
                            else if (key.Key == ConsoleKey.D2)
                            {
                                userAnswers.Add(1);
                                Console.WriteLine(" --> selected");
                            }
                            else if (key.Key == ConsoleKey.D3)
                            {
                                userAnswers.Add(2);
                                Console.WriteLine(" --> selected");
                            }
                            else if (key.Key == ConsoleKey.D4)
                            {
                                userAnswers.Add(3);
                                Console.WriteLine(" --> selected");
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                        bool correct = true;

                        if (userAnswers.Count != item1.correctIndexes.Length)
                        {
                            correct = false;
                        }

                        foreach (var index in item1.correctIndexes)
                        {
                            if(!userAnswers.Contains(index))
                            {
                                correct = false;
                                break;
                            }
                        }

                        if (correct)
                        {
                            correctAnwers += 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correct!!!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong!!!");
                        }
                        Console.ResetColor();

                    }
                    if (item.Title.Equals("Biology"))
                    {
                        File.AppendAllText(fileResultBiol, $"{CreateAccount.CurrentUser} --> {correctAnwers}/{selectedQuizData.Questions.Count}\n");
                        SortResult(fileResultBiol);
                        correctAnwers = 0;
                    }
                    
                    else if (item.Title.Equals("Geography"))
                    {
                        File.AppendAllText(fileResultGeo, $"{CreateAccount.CurrentUser} --> {correctAnwers}/{selectedQuizData.Questions.Count}\n");
                        SortResult(fileResultGeo);
                        correctAnwers = 0;
                    }
                    
                    else if (item.Title.Equals("Mathematics"))
                    {
                        File.AppendAllText(fileResultMath, $"{CreateAccount.CurrentUser} --> {correctAnwers}/{selectedQuizData.Questions.Count}\n");
                        SortResult(fileResultMath);
                        correctAnwers = 0;
                    }
                    
                    else if (item.Title.Equals("Mixed"))
                    {
                        File.AppendAllText(fileResultMixed, $"{CreateAccount.CurrentUser} --> {correctAnwers}/{selectedQuizData.Questions.Count}\n");
                        SortResult(fileResultMixed);
                        correctAnwers = 0;
                    }

                }
            }
        }
    }
}
