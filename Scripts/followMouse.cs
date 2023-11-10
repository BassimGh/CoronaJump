using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    public GameObject Stickman;
    private void Start()
    {
        GetComponent<Animation>().enabled = false;
        //print(transform.parent.transform.parent);
        //StartCoroutine(Aimcontrol());
    }
    // Update is called once per frame
    void Update()
    {
        //if (Stickman.GetComponent<stickman>().started)
    
        transform.parent.transform.parent = null;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Stickman.GetComponent<Animator>().cullingMode = AnimatorCullingMode.CullUpdateTransforms;
    }
    private IEnumerator Aimcontrol()
    {
        Stickman.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        Stickman.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(1);
        Stickman.GetComponent<Animator>().enabled = true;
    }
}