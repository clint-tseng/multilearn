using System;
using System.Collections.Generic;
using MultiLearn.Data.Log;
using System.Windows.Forms;

namespace MultiLearn.Data
{
    static class MultimathLogger
    {
        public static Session CreateSession(List<User> users)
        {
            return MultimathLogger.CreateSession(users, Constants.MultiMath.TypeIdentifier);
        }
        public static Session CreateSession(List<User> users, string gameType)
        {
            Session session = new Session { timestamp = DateTime.Now };
            Logger.Log.AddToSessionSet(session);
            Logger.Log.SaveChanges();
            foreach (User user in users)
            {
                UserSession userSession = new UserSession
                {
                    user_id = user.Log.uid,
                    session_id = session.id,
                    start_difficulty = (int)user.Level,
                    color = user.CurrentColor.ToString(),
                    type = gameType
                };
                user.CurrentSession = userSession;
                Logger.Log.AddToUserSessionSet(userSession);
            }
            Logger.Log.SaveChanges();
            MessageBox.Show(String.Format("This game's session id is: {0}", session.id));
            return session;
        }

        public static void UpdateSession(Session session, User winner)
        {
            session.winner_user_id = winner.Log.uid;
        }

        public static MultiMathQuestion CreateQuestion(MathQuestion question, int number, List<User> users, Session session)
        {
            MultiMathQuestion logQuestion = new MultiMathQuestion
            {
                session_id = session.id,
                user_id = users[0].Log.uid,
                difficulty = (int)users[0].Level,
                number = number,
                start = DateTime.Now,
                x = question.A,
                y = question.B,
                operand = question.Operand.ToString()
            };
            if (users.Count > 1)
                logQuestion.user_2_id = users[1].Log.uid;
            Logger.Log.AddToMultiMathQuestionSet(logQuestion);
            Logger.Log.SaveChanges();

            return logQuestion;
        }

        public static void LogKeystroke(User user, MultiMathQuestion logQuestion, int keycode)
        {
            Keystrokes keystroke = new Keystrokes
            {
                user_id = user.Log.uid,
                question_id = logQuestion.id,
                keycode = keycode
            };
            Logger.Log.AddToKeystrokesSet(keystroke);
        }

        public static void UpdateQuestion(MultiMathQuestion logQuestion, int answer, bool correct)
        {
            logQuestion.answer = answer;
            logQuestion.correct = correct;
            logQuestion.end = DateTime.Now;
        }
    }
}
