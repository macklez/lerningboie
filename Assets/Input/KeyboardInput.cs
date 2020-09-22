using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace macklegames
{
    public class KeyboardInput : MonoBehaviour
    {
      

        void Update()
        {
            //This script checks if the inputs are being recognized; when the button is pressed = true

            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.Instance.MoveRight = true; //instance of the class VirtualInputManager, calls a variable
            } 
            else
            {
                VirtualInputManager.Instance.MoveRight = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManager.Instance.MoveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeft = false;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                VirtualInputManager.Instance.Jump = true;
            }
            else
            {
                VirtualInputManager.Instance.Jump = false;
            }
        }
    }

}


