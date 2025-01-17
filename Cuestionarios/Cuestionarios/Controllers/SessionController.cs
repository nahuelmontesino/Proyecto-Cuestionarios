﻿using System.Collections.Generic;
using Cuestionarios.DataAccessLayer;
using System;
using Cuestionarios.Sources;
using Cuestionarios.Domain;
using System.Linq;
using Cuestionarios.DTOs;
using AutoMapper;

namespace Cuestionarios.Controllers
{
    public class SessionController
    {
        private readonly UnitOfWork iUOfW = new UnitOfWork();

        /// <summary>
        /// Get the scores
        /// </summary>
        public IEnumerable<SessionDTO> GetHighScores()
        {
            List<SessionDTO> result = new List<SessionDTO>();
            var sessions = iUOfW.SessionRepository.GetHighScores();

            foreach (var session in sessions)
            {
                result.Add(Mapper.Map<Session, SessionDTO>(session));
            }

            return result;
        }

        /// <summary>
        /// Save the session
        /// </summary>
        public void SaveSession(string pUserName, double pScoreValue, TimeSpan pTotalTime)
        {
            iUOfW.SessionRepository.SaveSession(pUserName, pScoreValue, pTotalTime);
            iUOfW.Complete();
        }

        /// <summary>
        /// Calcuate the score of a game
        /// </summary>
        public double GetScore(SetDTO pSet, int correctAnswers, int totalQuestions, string difficulty, double time)
        {
            int difficultyFactor, timeFactor;

            var source = SourceFactory.GetSourceByName(pSet.Name);
            int difficultyKey = source.DifficultyDictionary.FirstOrDefault(x => x.Value == difficulty).Key;

            difficultyFactor = source.GetDifficultyFactor(difficultyKey);
            timeFactor = source.GetTimeFactor(time);

            return ((double)correctAnswers / (double)totalQuestions) * (double)difficultyFactor * (double)timeFactor;
        }
    }        
}
