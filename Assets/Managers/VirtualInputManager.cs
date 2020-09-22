using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace macklegames
{
    public class VirtualInputManager : Singleton<VirtualInputManager> //instance of the singleton, creates an object in which we populate it with these variables
    {
        //add more abilities here
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
    }

}

