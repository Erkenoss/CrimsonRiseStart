using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAttacks : MonoBehaviour
{
    private Animator _animator;
    private StarterAssets.StarterAssetsInputs _input;
    private int _animIDKick;
    private int _animaIDKickLeft;
    public Health _health;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _input = GetComponent<StarterAssets.StarterAssetsInputs>();
        _health = GetComponent<Health>();
    }

    public void SetAnimatorAndInput(Animator animator, StarterAssets.StarterAssetsInputs input)
    {
        _animator = animator;
        _input = input;
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
            }
            else
            {
                _animator.SetBool("Kick", true);
            }
        }
        _input.kick = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon")
        {
            transform.parent = other.transform;
            other.GetComponent<DragonHealth>().TakeDamage(20);
        }
    }

}
