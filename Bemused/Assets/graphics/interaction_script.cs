using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_script : MonoBehaviour
{

    public GameObject item;
    public GameObject blur;
    public BoxCollider2D blurCollider;
    public GameObject detailedObject;


    // Start is called before the first frame update
    void Start()
    {
        detailedObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        item.GetComponent<Renderer>().enabled = false;
        blur.GetComponent<Renderer>().enabled = true;
        detailedObject.GetComponent<Renderer>().enabled = true;
        blurCollider.enabled = true;  
    }
}
