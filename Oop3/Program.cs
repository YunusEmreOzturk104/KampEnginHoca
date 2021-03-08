using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            IloggerService databaseloggerservice = new DatabaseLoggerService();
            IloggerService fileloggerservice = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager , new List<IloggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
