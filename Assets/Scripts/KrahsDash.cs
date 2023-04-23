using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrahsDash : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rigidbody;
    public float speed = 50f;
    Vector2 target = new Vector2(0, 0);
    private float a;
    private float b;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.Find("Player").transform;
        rigidbody = animator.GetComponent<Rigidbody2D>();
        
        a = player.position.x - rigidbody.position.x;
        b = player.position.y - rigidbody.position.y;
        Vector2 Direction = new Vector2(a, b).normalized;
        
        target = Direction * 20;
        // for (float i = 0; i < 100; i += Time.deltaTime)
        // {

        // } 
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 newPosition = Vector2.MoveTowards(rigidbody.position, target, speed * Time.fixedDeltaTime);
        rigidbody.MovePosition(newPosition);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
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
