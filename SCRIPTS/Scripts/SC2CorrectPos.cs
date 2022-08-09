using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC2CorrectPos : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public bool correct = false;
    public GameObject brkheart;

    // Start is called before the first frame update
    void Start()
    {
        brkheart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(point1.transform.position, Vector2.up, 0f);


        RaycastHit2D hit1 = Physics2D.Raycast(point2.transform.position, Vector2.up, 0f);


        if (hit.transform.gameObject.name == "ROmeo(Clone)" && hit1.transform.gameObject.name == "Grave(Clone)" )
        {
            correct = true;
            brkheart.SetActive(true);
        }
        else
        {
            correct = false;
        }

        if (hit.collider == null)
        {
            correct = false;
        }
        if (hit1.collider == null)
        {
            correct = false;
        }
    }
}
