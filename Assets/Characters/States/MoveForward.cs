using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace macklegames
{
    [CreateAssetMenu(fileName = "New State", menuName = "macklegames/AbilityData/MoveForward")]
    public class MoveForward : StateData
    {
        public float Speed;

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
           
        }
        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

            CharacterControl control = characterStateBase.GetCharacterControl(animator);
        

            if (control.MoveRight && control.MoveLeft)
            {
                animator.SetBool(TransitionParameter.move.ToString(), false);
                return;
            }

            if (!control.MoveRight && !control.MoveLeft)
            {
                animator.SetBool(TransitionParameter.move.ToString(), false);
                return;
            }
            if (control.MoveRight)
            {
                control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                control.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            }
            if (control.MoveLeft)
            {
                control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                control.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            }

        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            
        }
    }
}

