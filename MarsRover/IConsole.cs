﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IConsole
    {
        string ReadLine();

        void Write(string format);

        void WriteLine(string format);

        void WriteLine();
    }
}
