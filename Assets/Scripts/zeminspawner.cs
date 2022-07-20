using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminspawner : MonoBehaviour
{
    public GameObject sonZemin;
    
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            ZeminOlustur();
        }
    }

    void Update()
    {
        
    }

    public void ZeminOlustur()
    {
        Vector3 yon;
        if (Random.Range(0, 2) == 0)
        {
            yon = Vector3.left;
        }
        else
        {
            yon = Vector3.forward;
        }
        sonZemin = Instantiate(sonZemin, sonZemin.transform.position + yon, sonZemin.transform.rotation);
    }

    
}
