using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    public float tiempo = 0f;
    public float regulador = 0f;
    public GameObject video;
 

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;

        if (tiempo <= 0)
        {
            video.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            tiempo = regulador;
        }
    }
}
