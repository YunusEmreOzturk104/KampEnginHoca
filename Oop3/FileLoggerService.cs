﻿using System;

namespace Oop3
{
    class FileLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
