using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleIt : MonoBehaviour
{
    float go = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Pulse());
    }

    // Update is called once per frame
    void Update()
    {
       

 
        //transform.DOScale(2,1);
        //transform.DOScale(1, 1);
    }

    IEnumerator Pulse()
    {

        yield return new WaitForSeconds(go);
        transform.DOScale(2, 1);
        yield return new WaitForSeconds(0.5f);
        transform.DOScale(1, 1);
        StartCoroutine(Pulse());

    }
}
