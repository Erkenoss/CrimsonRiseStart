using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class CharactersAttacks : MonoBehaviour
    {
        private Animator _animator;
        private StarterAssetsInputs _input;
        private int _animIDKick;
        private int _animaIDKickLeft;

        public CharactersAttacks(Animator animator, StarterAssetsInputs _input)
        {
            _animator = animator;
            this._input = _input;
            AssignAnimationIDs();
        }

        private void AssignAnimationIDs ()
        {
            _animIDKick = Animator.StringToHash("Kick");
            _animaIDKickLeft = Animator.StringToHash("KickLeft");
        }

        public void HandleKick ()
        {
            _animator.SetBool("Kick", false);
            _animator.SetBool("KickLeft", false);

            if (_input.kick)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    _animator.SetBool("KickLeft", true);
                    invincible = true;
                }
                else
                {
                    _animator.SetBool("Kick", true);
                    invincible = true;
                }
            }
            _input.kick = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Dragon")
            {
                transform.parent = other.transform;
                other.GetComponent<DragonHealth>().TakeDamage(10);
            }
        }
    }
}
