using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace macklegames
{
    public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
             //   _instance = (T)FindObjectOfType(typeof(T));
                if (_instance == null) //initializes the game object when there is no instance (at initiation)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).ToString();

                }
                return _instance;
            }
        }
    }


}
