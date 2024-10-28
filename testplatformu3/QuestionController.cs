using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3
{
    
        internal class QuestionController
        {
            private List<Question> questions = new List<Question>();

            public void AddQuestion(string questionText, string correctAnswer, string category)
            {
                var question = new Question
                {
                    Text = questionText,
                    CorrectAnswer = correctAnswer,
                    Category = category
                };
                questions.Add(question);
                Console.WriteLine($"Soru eklendi: {question.Text} (Kategori: {category})");
            }

            public void RemoveQuestion(string questionText)
            {
                var questionToRemove = questions.Find(q => q.Text == questionText);
                if (questionToRemove != null)
                {
                    questions.Remove(questionToRemove);
                    Console.WriteLine($"Soru silindi: {questionToRemove.Text}");
                }
                else
                {
                    Console.WriteLine("Soru bulunamadı.");
                }
            }

            public List<Question> GetQuestions()
            {
                return questions;
            }

            public Question GetRandomQuestion(string category)
            {
                var filteredQuestions = questions.FindAll(q => q.Category == category);
                if (filteredQuestions.Count == 0) return null;

                Random rand = new Random();
                int index = rand.Next(filteredQuestions.Count);
                return filteredQuestions[index];
            }
        }
    }
