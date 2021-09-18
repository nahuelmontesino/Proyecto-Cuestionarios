using Cuestionarios.DAL;
using Cuestionarios.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cuestionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (QuestionnaireDbContext questionnaireDbContext = new QuestionnaireDbContext())
            {
                Question question = new Question
                {
                    Id = 1,
                    SetID = 1,
                    Difficulty = 1,
                    Category = 1,
                    QuestionSentence = "ss",
                    Options = new List<Option>
                    {
                        new Option
                        {
                            Id = 1,
                            Answer = "hola",
                            Correct = true,
                        }

                    }
                };


                questionnaireDbContext.Question.Add(question);
                questionnaireDbContext.SaveChanges();
            }
        }
    }
}
