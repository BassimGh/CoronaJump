using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mucus : MonoBehaviour
{
    private Rigidbody2D rb;
    float delay = 5f;
    float t = 0f;

    void Start()
    {
        transform.parent = null;
        rb = GetComponent<Rigidbody2D>();
        float radius = Random.Range(0.05f, 0.2f);
        transform.localScale = new Vector3(radius,radius,radius);
        Vector2 coughforce = new Vector2(Random.Range(-800f, -200f), Random.Range(-200f,200f));
        rb.AddForce(coughforce);
    }

    private void Update()
    {
        t += Time.deltaTime;
        if (t >= delay && gameObject.transform.parent == null) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.transform.root.gameObject.CompareTag("germ")) print(collision.transform.root.gameObject.tag);
        if (!collision.gameObject.transform.root.CompareTag("Player") && !collision.gameObject.CompareTag("germ"))
        {
            /*
            FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();

            joint.anchor = collision.GetContact(0).point;
            joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            print(collision.gameObject.GetComponent<Rigidbody2D>());*/

            //collision.rigidbody.simulated = false;
            //GameObject empty = new GameObject();
            //empty.transform.parent = collision.transform;
            gameObject.GetComponent<Rigidbody2D>().simulated = false;
            GameObject empty = new GameObject();
            empty.transform.parent = collision.transform;
            transform.parent = empty.transform;
        }
    }
}