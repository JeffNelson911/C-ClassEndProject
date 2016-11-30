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
        public int state;


        public Quest()
        {
            questName = "Default Quest";
            keywords = new string[5];
            keywords[0] = "Hello";
            description = "Im a quest you noob";
            qId = -1;
            prompt = "Hey you got your default Quest why don't you say Hello?";
            state = 0;
        }

        public Quest(string name, string[] keys,string desc, int q, string p,int s)
        {
            questName = name;
            keywords = keys;
            description = desc;
            qId = q;
            prompt = p;
            state = s;
        }

        public void setQuestName(string name)
        {
            questName = name;

        }
        public void setKeywords(string[] keys)
        {
            keywords = keys;
        }

        public virtual void checkQuest()
        {
            //This needs to be overridden in it's successors.
        }

        public bool checkKeyword(string key)
        {
           bool check = false;
           
            for(int i=0; i< 5;i++)
            {
                if (key.Equals(keywords[i]))
                {
                    check = true;
                }
            }
                return check;
        }

    }
}
