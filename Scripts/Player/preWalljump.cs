using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preWalljump : MonoBehaviour
{
    private Animator animator;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (transform.position.x - player.transform.position.x < 0) player.GetComponent<stickman>().angle = 0;
            if (transform.position.x - player.transform.position.x > 0) player.GetComponent<stickman>().angle = 180;
            animator = player.GetComponent<Animator>();
            animator.SetBool("preWallJump", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") animator.SetBool("preWallJump", false);
    }
}