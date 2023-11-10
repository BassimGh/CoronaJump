using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cough : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        GameObject obj = other.transform.root.gameObject;
        if (obj.CompareTag("Player"))
        {
            print("gottem");
            obj.GetComponent<stickman>().Infected();
        }
    }
}
