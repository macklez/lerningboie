using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace macklegames
{

    [CreateAssetMenu(fileName = "New State", menuName = "macklegames/AbilityData/Landing")]
    public class Land : StateData
    {

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.jump.ToString(), false);
        }
        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

    }

}

