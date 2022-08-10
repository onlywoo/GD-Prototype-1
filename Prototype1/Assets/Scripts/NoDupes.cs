using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDupes : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeNoDuplicates()
    {
        if (this.gameObject.transform.position != slot1.transform.position || this.gameObject.transform.position != slot2.transform.position|| this.gameObject.transform.position != slot3.transform.position|| this.gameObject.transform.position != slot4.transform.position)
        {
            Destroy(this.gameObject);
        }
    }
}
