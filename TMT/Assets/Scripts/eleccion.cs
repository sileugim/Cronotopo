using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleccion : MonoBehaviour
{
    public GameObject opcion_a;
    public GameObject opcion_b;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Z))
        {
            opcion_a.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            opcion_b.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
