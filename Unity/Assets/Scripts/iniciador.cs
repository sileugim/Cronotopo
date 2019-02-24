using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniciador : MonoBehaviour
{
    public GameObject Inciador;
 

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Z))
        {
            Inciador.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Application.Quit();
            Debug.Log("se ha salido");
            this.gameObject.SetActive(false);
        }
    }

}
