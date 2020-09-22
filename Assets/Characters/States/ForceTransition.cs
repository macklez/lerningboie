using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace macklegames
{
    [CreateAssetMenu(fileName = "New State", menuName = "macklegames/AbilityData/ForceTransition")]
    public class ForceTransition : StateData
    {
        [Range(0.01f, 1f)]
        public float TransitionTiming;

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            if (stateInfo.normalizedTime >= TransitionTiming)
            {
                animator.SetBool(TransitionParameter.forceTransition.ToString(), true);
            }

        }
        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionParameter.forceTransition.ToString(), false);
        }
    }
}
