using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using Cuestionarios.Entities;
using System.Linq;

namespace Cuestionarios.Source
{
    class OpendbSource: ISource
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
            DifficultyDictionary = GetDificulties();
        }

        private dynamic CallTheTribiaApi(string pUrl)
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
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    string mErrorText = mReader.ReadToEnd();

                    Console.WriteLine("Error: {0}", mErrorText);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return null;
            }
        }

        private Dictionary<int, string> GetCategories()
        {
            string url = "https://opentdb.com/api_category.php";

            dynamic mResponseJSON = CallTheTribiaApi(url);

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

        private Dictionary<int, string> GetDificulties()
        {
            var categories = new Dictionary<int, string>()
            {
                {0,"any dificulty"},
                {1,"easy"},
                {2,"medium"},
                {3,"hard"},
                
            };

            return categories;
        }

        public List<Question> GetQuestions(string pDificulty, int pCategory, int pAmount)
        {
            string category, dificulty;

            category = pCategory == 0 ? "" : "&category=" + pCategory;

            dificulty = pDificulty == "any dificulty" ? "" : "&difficulty=" + pDificulty.ToLower();

            var apiUrl = UrlBase + "amount=" + pAmount + category + dificulty + "&type=multiple";


            dynamic mResponseJSON = CallTheTribiaApi(apiUrl);

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
    }
}
