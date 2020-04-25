using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blur_script : MonoBehaviour
{
    public List<GameObject> itemList;
    public BoxCollider2D blurCollider;
    public List<GameObject> detailedObjectsList;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        blurCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        foreach (GameObject item in itemList)
        {
            item.GetComponent<Renderer>().enabled = true;
        }

        foreach (GameObject item in detailedObjectsList)
        {
            item.GetComponent<Renderer>().enabled = false;
        }

        this.GetComponent<Renderer>().enabled = false;
        blurCollider.enabled = false;
    }
}
