using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfEmpty : MonoBehaviour
{
    public GameObject checkMe;
     public bool empty= true;
    // Start is called before the first frame update
    void Start()
    {
        checkMe = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(checkMe.transform.position, Vector2.up, 0f);
        if (hit.collider != null)
        {
            empty = false;
        }
        else if (hit.collider == null)
        {
            empty = true;

        }

        if (hit.collider == null)
        {
           
        }
    }
}
