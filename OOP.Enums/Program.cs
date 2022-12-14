using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using OOP.Enums.Enums;


namespace OOP.Enums
{   
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnumDisplay<Connections>.Display(Connections.MsSql));
        }
    }

    public static class EnumDisplay<T> where T : Enum
    {
        public static string Display(T enm)
        {
            return enm.GetType().GetMember(enm.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName();
        }
    }
}