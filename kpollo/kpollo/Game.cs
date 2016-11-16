using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpollo
{
    class Game
    {
        int user;
        int gep;
        public Game(int _user, int _gep)
        {

            user = _user;
            gep = _gep;         
            

        }


        public int User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public int Gep
        {
            get
            {
                return gep;
            }

            set
            {
                gep = value;
            }
            
        }
        
    }
}
