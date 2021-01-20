using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;

    float mx;
    float my;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
       checkDistance(); 
    }
    void checkDistance(){
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position,transform.position) > attackRadius){
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
}
