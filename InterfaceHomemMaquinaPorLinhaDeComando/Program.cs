using Mono.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli
{
    class Program
    {
        enum Command
        {
            HELP,
            VERSION,
            CREATE,
            DELETE
        }
        static void Main(string[] args)
        {
            var command = Command.HELP;
            string obj = null;
            var options = new OptionSet {
                                //Dummie
                                { "c|create=", "create the specified element.",  c =>  { command = Command.CREATE; obj = c; } },
                                { "d|delete=", "delete the specified element.",  d => { command = Command.DELETE; obj = d; } },
                                //
                                //-y --yes :sempre aceitar as decisões padrão
                                //-i --interactive :modo interativo
                                //-f --force 
                                //-q --quiet suprimir saidas 
                                //Defaults
                                { "v|version", "program version",  v =>  command = Command.VERSION },//version or verbose
                                { "h|help", "show this message and exit",   h => command = Command.HELP },
                                { "<>", _ => command = Command.HELP }
                            };
            try
            {
                // parse the command line
                
            var extra= options.Parse(args);
                switch (command)
                {
                    case Command.VERSION:
                        {
                            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
                        }
                    break;
                    case Command.CREATE:
                        {
                            Console.WriteLine("{0} was created.",obj);
                        }
                    break;
                    case Command.DELETE:
                        {
                            Console.WriteLine("{0} was deleted.", obj);
                        }
                    break;
                    default: //case Command.HELP:
                        {
                       Console.WriteLine(
        @"
   ________    ____   ___________ __  _____    ____  ____ 
  / ____/ /   /  _/  / ____/ ___// / / /   |  / __ \/ __ \
 / /   / /    / /   / /    \__ \/ /_/ / /| | / /_/ / /_/ /
/ /___/ /____/ /   / /___ ___/ / __  / ___ |/ _, _/ ____/ 
\____/_____/___/   \____//____/_/ /_/_/  |_/_/ |_/_/      
                                                          ");
                            options.WriteOptionDescriptions(Console.Out);
                            extra.ForEach(x => Console.Write(x));
                     }
                     break;
                }
                }
            catch (OptionException e)
            {
                
                // output some error message
                Console.Write("greet: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `greet --help' for more information.");
                return;
            }
        }
    }
}
