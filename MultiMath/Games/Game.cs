using System;
using System.Collections.Generic;
using MultiLearn.Data;

namespace MultiLearn.Games
{
    public interface Game
    {
        event EventHandler GameComplete;

        void Run(List<User> users);

        void Close();
    }
}
