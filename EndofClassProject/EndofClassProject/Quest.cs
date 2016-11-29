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
        public string description;
        public int qId;
        public string prompt;
        public int stage;


        public Quest()
        {
            questName = "Default Quest";
            keywords = new string[5];
            keywords[0] = "Hello";
            description = "Im a quest you noob";
            qId = -1;
            prompt = "Hey you got your default Quest why don't you say Hello?";
            stage = 0;
        }

        public Quest(string name, string[] keys,string desc, int q, string p,int s)
        {
            questName = name;
            keywords = keys;
            description = desc;
            qId = q;
            prompt = p;
            stage = s;
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
           
            for(int i=0; i< 5;i++)
            {
                if (key.Equals(keyword[i]))
                {
                    check = true;
                    description = updateDescription(i, check, key);
                }
                else
                {
                    //fill in in a minute
                }
            }
                return check;
        }

        public string updateDescription(int i, bool check, string key)
        {
            if (check == true)
            {
                switch (i)
                {
                    case 0:
                        description = "";
                        break;
                    case 1:
                        description = " words here";
                        
                        break;
                    case 2:
                        description = "more words here";
                        break;
                    case 3:
                        description = " continue words";
                        break;
                    case 4:
                        description = "words continued";
                        break;
                    case 5:
                        description = "etc etc etc";
                        break;
                }
            }
            return description;
        }

    }
}
