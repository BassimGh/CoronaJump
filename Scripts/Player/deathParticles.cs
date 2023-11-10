using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathParticles : MonoBehaviour
{
    public Transform mainCamera;
    public Transform ball;
    public ParticleSystem particle;
    public int yOffsetTrigger;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position;
        if(ball.position.y < mainCamera.position.y + yOffsetTrigger) particle.Emit(200);
        
    }
}