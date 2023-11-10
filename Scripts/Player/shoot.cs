using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public stickman Stickman;

    private void Start()
    {
        //GetComponent<ParticleSystem>()
    }

    // Update is called once per frame
    void Update()
    {
        if (Stickman.started && Input.GetMouseButton(0))
        {
            GetComponent<ParticleSystem>().Play();
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        //GameObject obj = other.transform.root.gameObject;
        GameObject obj = FindParentWithTag(other, "sickman");
        if (obj)
        {
            obj.GetComponent<sickman>().Hit();
        }
    }
    public static GameObject FindParentWithTag(GameObject childObject, string tag)
    {
        Transform t = childObject.transform;
        while (t.parent != null)
        {
            if (t.parent.tag == tag)
            {
                return t.parent.gameObject;
            }
            t = t.parent.transform;
        }
        return null; // Could not find a parent with given tag.
    }
}

