using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipImage : MonoBehaviour
{
    public GameObject Juli;
    public GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Juli.transform.position.x == point.transform.position.x)
        {
            Juli.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            Juli.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
