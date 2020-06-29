using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarGameObjectComponent : MonoBehaviour
{
    //Forma de ativar ou desativar objetos em uma cena

    public GameObject Objeto;

    // Start is called before the first frame update
    void Start()
    {
        //Objeto.SetActive(false);
        //Objeto.GetComponent<Light>().enabled = false;

        if (Objeto.activeSelf)
        {
            Objeto.SetActive(false);
            Debug.Log(Objeto.activeSelf);
        }

        else
        {
            Objeto.SetActive(true);
            Debug.Log(Objeto.activeSelf);
        }
            


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
