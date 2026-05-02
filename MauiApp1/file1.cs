using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1
{
    internal class file1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello..");
            Console.Read();
            Entry[] entries;
            {  entries = new Entry[1];}   
            // config error : ambiguous.. 
        }   

    }
    
    internal class Entry
    {
        public Entry()
        {
            // Constructor logic here
        }
    }

    public class Entry2
    { 
        

    }
    
    // entry block

    
}

static void HelperMain(string[] args)
{
   Console.Beep();

}   
