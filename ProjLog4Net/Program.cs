using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp1
{
    class Program
    {
        private static readonly log4net.ILog log =
            //LogHelper.GetLogger();
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            for (var j = 0; j < 100; j++) {
                log.Info("Teste de log info -"+j);
            }
            log.Debug("Teste de log debug");
            
            log.Warn("Teste de log de alerta");

            var i = 0;

            try {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex) {
                log.Error("Developer: Não existe divisão por zero", ex);
            }
            log.Fatal("Erro Fatal");

            Console.ReadLine();
            
            
        }
    }
}
