using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class top : MonoBehaviour
{
    Vector3 yon;
    public float hiz;
    public zeminspawner ZeminSpawner;
    public bool topDustumu = false;
    public float hizlandirma = 1;
    GameObject dusenZemin;
    public int skor;
    public Text skorText;

    void Start()
    {

        yon = Vector3.forward;
    }

    void Update()
    {
         string skorString = skor.ToString();
        skorText.text = "Skor: " + skorString;
        Debug.Log(skor);

        if(transform.position.y < 0.677000)
        {
            topDustumu = true;
        }
        if (topDustumu == true)
        {
            return;

        }


        if (Input.GetMouseButtonDown(0))
        {
            skor++;

            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
        }


        

    }

    private void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hiz * hizlandirma;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "zemin")
        {
            dusenZemin = collision.gameObject;
            dusenZemin.AddComponent<Rigidbody>();
            hizlandirma += 0.01f;
            ZeminSpawner.ZeminOlustur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }

    IEnumerator ZeminiSil(GameObject silinenZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinenZemin);
    }
}


    