using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpollo
{
   
   public class User
    {
        
        public int score=0;
        string pass;
        string name;
        
        public User(string _name, string _pass)
        {
            
            name = _name;
            pass = _pass;
        }
        public User()
        {
            name = "teszt";
            pass = "123";
            score = 5;
        }
        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }
        public override string ToString()
        {
            return "Person: " + Name + " " + Score;
        }
    }
}
