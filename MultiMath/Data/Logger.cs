using System.Linq;
using MultiLearn.Data.Log;

namespace MultiLearn.Data
{
    static class Logger
    {
        public static SqliteLog Log
        {
            get { return Logger._log; }
        }
        private static SqliteLog _log;

        public static void Initialize()
        {
            Logger._log = new SqliteLog();
        }

        public static LogUser FindUser(int PIN)
        {
            var results = from u in Logger._log.LogUserSet
                          where u.pin == PIN
                          select u;

            if (results.Count() == 0)
                return null;
            else
                return results.First();
        }

        public static void Flush()
        {
            Logger._log.SaveChanges();
        }

        public static void Dispose()
        {
            Logger._log.Dispose();
        }
    }
}
