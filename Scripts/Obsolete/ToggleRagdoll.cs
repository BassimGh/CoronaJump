using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRagdoll : MonoBehaviour
{
    public bool Ragdoll;
    private Rigidbody2D[] rb;
    private HingeJoint2D[] hingejoints;
    private FixedJoint2D[] fixedjoints;
    private Animator animator;
    public GameObject stickman;
    void Start()
    {
        rb = GetComponentsInChildren<Rigidbody2D>();
        hingejoints = GetComponentsInChildren<HingeJoint2D>();
        fixedjoints = GetComponentsInChildren<FixedJoint2D>();
        animator = GetComponent<Animator>();



        if (Ragdoll)
        {
            for (int i = 1; i <= rb.Length; i++) rb[i].simulated = true;
            foreach (HingeJoint2D i in hingejoints) i.enabled = true;
            foreach (FixedJoint2D i in fixedjoints) i.enabled = true;

            animator.enabled = false;
        }
        else
        {
            for (int i = 1; i <= rb.Length; i++) rb[i].simulated = true;
            foreach (HingeJoint2D i in hingejoints) i.enabled = false;
            foreach (FixedJoint2D i in fixedjoints) i.enabled = false;
            animator.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
