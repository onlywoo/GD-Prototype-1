using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInsertedCheck : MonoBehaviour
{
    public GameObject[] snappers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void SnapInPlace()
    {
        for(int i=0; i < snappers.Length; i++)
        {
            if (Vector3.Distance(snappers[i].transform.position, transform.position) < 2f)
            {
                transform.position = new Vector3(snappers[i].transform.position.x, snappers[i].transform.position.y, snappers[i].transform.position.z);
            }

        }
    }
}
