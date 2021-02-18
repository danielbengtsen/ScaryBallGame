using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class AgentScript : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
 
    Animator animator;
 
    GameObject ball;
 
    Vector3 targetPos;
 
 
 
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        ball = GameObject.Find("the_ball"); // dårlig stil!
    }
 
    // Update is called once per frame
    void Update()
    {
        targetPos = ball.transform.position;
 
        navMeshAgent.SetDestination(targetPos);
        animator.SetFloat("Speed", 0.7f);
    }
}