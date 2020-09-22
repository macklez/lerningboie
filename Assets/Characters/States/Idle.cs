using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace macklegames
{

    [CreateAssetMenu(fileName = "New State", menuName = "macklegames/AbilityData/Idle")]
    public class Idle : StateData
    {

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
          
        }
        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterStateBase.GetCharacterControl(animator);

            if (control.MoveRight)
            {

                animator.SetBool(TransitionParameter.move.ToString(), true);
            }
            if (control.MoveLeft)
            {

                animator.SetBool(TransitionParameter.move.ToString(), true);
            }

            if (control.Jump)
            {
                animator.SetBool(TransitionParameter.jump.ToString(), true);
            }

        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
           
        }

    }

}

