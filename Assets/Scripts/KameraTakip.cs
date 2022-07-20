using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform topunKonumu;
    Vector3 fark;
    public top top;
    void Start()
    {
        fark = transform.position - topunKonumu.position;
        
    }

    void Update()
    {
        

        if (top.topDustumu == false)
        {

            transform.position = topunKonumu.position + fark;
        }

    }
}
