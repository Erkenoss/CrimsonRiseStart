using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAttacks : MonoBehaviour
{
    private Animator _animator;
    private StarterAssets.StarterAssetsInputs _input;
    public bool isAttacking;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _input = GetComponent<StarterAssets.StarterAssetsInputs>();
    }

    public void SetAnimatorAndInput(Animator animator, StarterAssets.StarterAssetsInputs input) //Constructor
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
            isAttacking = true;
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
        if (other.tag == "Enemy")
        {
            if (isAttacking)
            {
                other.GetComponent<ElyHealth>().TakeDamage(20);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isAttacking = false;
    }
}
