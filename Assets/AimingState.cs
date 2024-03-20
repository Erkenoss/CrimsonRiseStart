using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AimingState : StateMachineBehaviour
{
    Transform player;
    NavMeshAgent agent;
    float aimRange = 6f;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = animator.GetComponent<NavMeshAgent>();
        animator.SetLayerWeight(1, 1f);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(player.position);
        agent.speed = 1f;
        animator.transform.LookAt(player);
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance > 10f)
        {
            animator.SetBool("isAiming", false);
            animator.SetLayerWeight(1, 0f);
            animator.SetBool("isPatrolling", true);
        }
        if (distance < 8f)
        {
            //Shoot
            Vector3 directionToPlayer = player.position - animator.transform.position;
            animator.transform.LookAt(player.position);
            RaycastHit hit;
            Debug.Log("Ah!");
            int layerMask = 1 << 7;
            Debug.Log(layerMask);
            Physics.Raycast(animator.transform.position, directionToPlayer, out hit, 100f);
            if (Physics.Raycast(animator.transform.position, directionToPlayer, out hit, 100f, layerMask))
            {
                Debug.Log("On est dans le if");
                Debug.DrawLine(animator.transform.position, hit.point, Color.red, 1f);
                Debug.Log(hit.collider.gameObject.name + " was hit");
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(animator.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
