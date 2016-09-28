using System;
using System.Collections.Generic;
using MultiLearn.Data.Log;

namespace MultiLearn.Data
{
    static class MultispellLogger
    {
        public static Session CreateSession(List<User> users)
        {
            Session session = new Session { timestamp = DateTime.Now };
            Logger.Log.AddToSessionSet(session);
            foreach (User user in users)
            {
                UserSession userSession = new UserSession
                {
                    user_id = user.Log.uid,
                    session_id = session.id,
                    start_difficulty = (int)user.Level,
                    color = user.CurrentColor.ToString(),
                    type = Constants.MultiSpell.TypeIdentifier
                };
                user.CurrentSession = userSession;
                Logger.Log.AddToUserSessionSet(userSession);
            }
            Logger.Log.SaveChanges();
            return session;
        }

        public static void UpdateSession(Session session, User winner)
        {
            session.winner_user_id = winner.Log.uid;
        }

        public static MultiSpellQuestion CreateQuestion(SpellingQuestion question, int number, User user, Session session)
        {
            MultiSpellQuestion logQuestion = new MultiSpellQuestion
            {
                session_id = session.id,
                user_id = user.Log.uid,
                difficulty = (int)user.Level,
                number = number,
                start = DateTime.Now,
                word = question.Word
            };
            Logger.Log.AddToMultiSpellQuestionSet(logQuestion);

            return logQuestion;
        }

        public static void AddMistakeToQuestion(MultiSpellQuestion logQuestion, int index, char attempt)
        {
            MultiSpellMistake logMistake = new MultiSpellMistake
            {
                question_id = logQuestion.id,
                word = logQuestion.word,
                index = index,
                attempt = attempt.ToString()
            };
            Logger.Log.AddToMultiSpellMistakeSet(logMistake);
        }

        public static void UpdateQuestion(MultiSpellQuestion logQuestion, bool correct)
        {
            logQuestion.correct = correct;
            logQuestion.end = DateTime.Now;
        }
    }
}
