using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System;
using Cuestionarios.Domain;

namespace Cuestionarios.Sources
{
    class OpendbSource: IQuestionnaireSource
    {
        public string UrlBase { get; private set; }
        public string Name { get; private set; }
        public Dictionary<int, string> CategoryDictionary { get; private set; }
        public Dictionary<int, string> DifficultyDictionary { get; private set; }

        public OpendbSource()
        {
            UrlBase = "https://opentdb.com/api.php?";
            Name = "opentdb";
            CategoryDictionary = GetCategories();
            DifficultyDictionary = GetDifficulties();
        }

        private Dictionary<int, string> GetCategories()
        {
            string url = "https://opentdb.com/api_category.php";

            dynamic mResponseJSON = CallTheAPI(url);

            Dictionary<int, string> categoriesDictionary = new Dictionary<int, string> { };

            //Each of the results is iterated
            foreach (var category in mResponseJSON.trivia_categories)
            {
                int id = category.id;
                string name = category.name;
                categoriesDictionary.Add(id, name);
            }

            return (categoriesDictionary);

        }

        /// <summary>
        /// Gets a response form the URL
        /// </summary>
        private dynamic CallTheAPI(string pUrl)
        {
            // Establishment of the transport ssl protocol
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // The request http is created
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(pUrl);

            try
            {
                // The query is executed
                WebResponse mResponse = mRequest.GetResponse();

                // The response data is obtained
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // The response is parsed and JSON is serialized to a dynamic object
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    Console.WriteLine("Código de respuesta: {0}", mResponseJSON.response_code);

                    if (mResponseJSON == null)
                    {
                        throw new ArgumentNullException(nameof(mResponseJSON));
                    }

                    return mResponseJSON;
                }
            }
            catch (WebException ex)
            {
                var mErrorResponse = ex.Message;
                throw new Exception("error trying to get the data from the api");
            }
        }

        /// <summary>
        /// Difficulty mapping
        /// </summary>
        private Dictionary<int, string> GetDifficulties()
        {
            var difficulties = new Dictionary<int, string>()
                                            {
                                                {0,"easy"},
                                                {1,"medium"},
                                                {2,"hard"},
                                                {3,"any dificulty"},
                                            };

            return difficulties;
        }

        /// <summary>
        /// Get the questions from the api
        /// </summary>
        public IEnumerable<Question> GetQuestions(string pDificulty, int pCategory, int pAmount)
        {
            string category, dificulty;

            category = pCategory == 0 ? "" : "&category=" + pCategory;

            dificulty = pDificulty == "any dificulty" ? "" : "&difficulty=" + pDificulty.ToLower();

            var apiUrl = UrlBase + "amount=" + pAmount + category + dificulty + "&type=multiple";


            if (pAmount > 50)
            {
                throw new NullReferenceException("The maximum number of questions that can be request is: " + 50);
            }

            dynamic mResponseJSON = CallTheAPI(apiUrl);

            if (mResponseJSON.response_code == 1 || pAmount > 50)
            {
                throw new NullReferenceException("The API doesn't have enough questions for your query");
            }
            else if (mResponseJSON.response_code == 2)
            {
                throw new ArgumentException("One of the parameters entered is not valid");
            }

            List<Question> questionsList = new List<Question>();

            foreach (var responseItem in mResponseJSON.results)
            {
                List<Option> optionList = new List<Option>();

                //Mark the correct answer
                optionList.Add(new Option
                {
                    Answer = responseItem.correct_answer,
                    Correct = true
                });

                //Adds the other answers
                foreach (var opt in responseItem.incorrect_answers)
                {
                    optionList.Add(new Option
                    {
                        Answer = opt,
                        Correct = false
                    });
                }

                questionsList.Add(new Question
                {
                    QuestionSentence = responseItem.question,
                    Difficulty = DifficultyDictionary.FirstOrDefault(x => x.Value == responseItem.difficulty.ToString()).Key,
                    Category = CategoryDictionary.FirstOrDefault(x => x.Value == responseItem.category.ToString()).Key,
                    Options = optionList
                });
            }

            return (questionsList);
        }

        public int GetDifficultyFactor(int difficulty)
        {
            switch (difficulty)
            {
                case 0:
                    return 1;
                case 1:
                    return 3;
                case 2:
                    return 5;
                default:
                    throw new ArgumentOutOfRangeException(nameof(difficulty));
            }
        }

        public int GetTimeFactor(double time)
        {
            if (time < 5)
            {
                return 5;
            }
            else if (time >= 5 && time <= 20)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
    }
}
