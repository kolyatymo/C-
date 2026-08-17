using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkExam
{
    internal class Quiz
    {
        public string Title { get; set; }
        public int QuestionCount => Questions?.Count ?? 0;
        public List<Question> Questions { get; set; } = new List<Question>();

        public Quiz()
        {
            Questions = new List<Question>(QuestionCount);
        }
        public void menu()
        {
            Console.WriteLine($"write");
        }
    }

    class MyEnum
    {
        public enum myEnum { Geography = 1, Biology, Mathematics }
    }

    class Question
    {
        public string queston { get; set; }
        public string[] answers { get; set; }
        public int[] correctIndexes { get; set; }
    }

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
        }

        public void Run()
        {

            for (int i = 0; i < Quizes.Count; i++)
            {
                Console.WriteLine($"{i+1} --> {Quizes[i].Title}");
            }

            Console.WriteLine("enter quiz");
            int numberQiuz = int.Parse(Console.ReadLine());

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
                        Console.WriteLine($"Question --> {i}");
                        Console.WriteLine(item1.queston);
                        for (int j = 0; j < item1.answers.Length; j++)
                        {
                            Console.WriteLine($"{j + 1} --> {item1.answers[j]}");
                        }
                        i++;
                        var key = Console.ReadKey();
                        /*Console.Clear();*/

                        if (key.Key == ConsoleKey.D4)
                        {

                        }
                    }
                }
            }
        }
    }
}
