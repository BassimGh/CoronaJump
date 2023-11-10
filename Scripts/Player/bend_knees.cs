using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bend_knees : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    //private bool toggle=false;

    void Awake()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        
        if (rb.velocity.y <= 0.1)
        {
            animator.SetBool("BendKnees", true);
        }
        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("BendKnees", false);
    }
}
