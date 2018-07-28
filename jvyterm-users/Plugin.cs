using jvyterm;
using System;


namespace jvyterm_users
{
    public class Plugin
    {
        public static void init() {
            pluginHandler.addCommand("logout");
            login(true);
        }

        public static void logout() { login(); }

        public static void login(bool isinit = false) {
            logger.log("Login initialized. Prompting login.", logger.logType.silent);
            //Console.Clear();
            logger.log("", logger.logType.regular);
            logger.log("Welcome to jvyterm. Please login.", logger.logType.regular);

            Console.Write("u>");
            string u = Console.ReadLine();
            Console.Write("p>");
            string p = Console.ReadLine();
            

        }
    }
}
