using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrahsEnraged : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rigidbody;
    public float speed = 10f;
    GameObject Krahs;
    private float time = 0f;
    public float dashRange = 20;
    float counter = 10;
    bool cooldown = false;

   

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.Find("Player").transform;
        rigidbody = animator.GetComponent<Rigidbody2D>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 target = new Vector2(player.position.x, player.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rigidbody.position, target, speed * Time.fixedDeltaTime);
        rigidbody.MovePosition(newPosition);
        
        if (cooldown == false && Vector2.Distance(player.position, rigidbody.position) < dashRange)
        {
            animator.SetTrigger("Dash");
            cooldown = true;   
        }
        else if (cooldown == true)
        {
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                cooldown = false;
                counter = 10;
            }
        }
        

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.ResetTrigger("Dash");
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

