using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndofClassProject
{
    class Quest
    {
        public string questName;
        public string[] keywords;


        public Quest()
        {
            questName = "Default Quest";
            keywords = new string[5];
            keywords[0] = "Hello";
        }

        public Quest(string name, string[] keys)
        {
            questName = name;
            keywords = keys;
        }

        public void setQuestName(string name)
        {
            questName = name;

        }
        public void setKeywords(string[] keys)
        {
            keywords = keys;
        }

        public bool checkKeyword(string key,string[] keyword)
        {
           bool check = false;
           int i = 0;
            foreach (string x in  keywords)
            {
                if (x == keyword[i])
                {

                }
                else
                {
                    i++;
                }
                return check;
        }
    }
}
