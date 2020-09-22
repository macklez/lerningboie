using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.UIElements;
using UnityEngine;


namespace macklegames
{

    public enum TransitionParameter //variable that simplifies writing strings
    {
        move,
        jump,
        forceTransition
    }
    public class CharacterControl : MonoBehaviour
    {
        public float Speed;
        public Animator animator;
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public GameObject ColliderEdgePrefab;
        private List<GameObject> BottomSpheres = new List<GameObject>();

        private Rigidbody rigid;
        public Rigidbody RIGID_BODY
        {
            get
            {
                if (rigid == null)
                {
                    rigid = GetComponent<Rigidbody>();
                }
                return rigid;
            }

        }

        private void Awake()
        {
            BoxCollider box = GetComponent<BoxCollider>();

            float Bottom = box.bounds.center.y - box.bounds.extents.y;
            float Top = box.bounds.center.y + box.bounds.extents.y;
            float Front = box.bounds.center.z + box.bounds.extents.z;
            float Back = box.bounds.center.z - box.bounds.extents.z;

            GameObject bottomFront = CreateEdgeSphere(new Vector3(0f, Bottom, Front));
            GameObject bottomBack = CreateEdgeSphere(new Vector3(0f, Bottom, Back));

            bottomFront.transform.parent = this.transform; //make spheres child of the parent aka character control
            bottomBack.transform.parent = this.transform;

            BottomSpheres.Add(bottomFront);
            BottomSpheres.Add(bottomBack);

            float sec = (bottomFront.transform.position - bottomBack.transform.position).magnitude / 5f;

            for (int i = 0; i < 5; i++)
            {
                Vector3 pos = bottomBack.transform.position + (Vector3.forward*sec*(i + 1));

                GameObject newObj = CreateEdgeSphere(pos);
                newObj.transform.parent = this.transform;
                BottomSpheres.Add(newObj);
            }

        }

        public GameObject CreateEdgeSphere(Vector3 pos)
        {
            GameObject obj = Instantiate(ColliderEdgePrefab, pos, Quaternion.identity);
            return obj;
        }
    }
}

