using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace macklegames
{
    public class CharacterStateBase : StateMachineBehaviour
    {

        public List<StateData> ListAbilityData = new List<StateData>(); //creates a list of ability data

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           foreach(StateData d in ListAbilityData)
            {
                d.OnEnter(this, animator, stateInfo);
            }
        }

        public void UpdateAll(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo) //updates CharacterStateBase variables
        {
            foreach(StateData d in ListAbilityData)
            {
                d.UpdateAbility(characterStateBase, animator, stateInfo); //updates the data in characterStateBase and animator
            }

        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this, animator,stateInfo); //on refresh of frame, update this object and animator
        }


        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.OnEnter(this, animator, stateInfo);
            }
        }

        private CharacterControl characterControl;
        public CharacterControl GetCharacterControl(Animator animator) //a method to get the characterControl variable from the class CharacterControl
        {
            if (characterControl == null)
            {
               characterControl = animator.GetComponentInParent<CharacterControl>();
            }
            return characterControl;
        }
    }
}

