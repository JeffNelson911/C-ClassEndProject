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

        public virtual bool checkKeyword(string key)
        {
           bool check = false;
           
            for(int i=0; i< 5;i++)
            {
                if (key.Equals(keywords[i]))
                {
                    check = true;
                    description = updateDescription(state);
                }
                else
                {
                    //fill in in a minute
                }
            }
                return check;
        }

        public virtual string updateDescription(int state)
        {
            if ( == true)
            {
                switch (state)
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
