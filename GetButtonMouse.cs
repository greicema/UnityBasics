using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonMouse : MonoBehaviour
{
    //Serve para reconhecer entradas pelo teclado, mouse e touch screem

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicou");
    }


    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown; -> Retorna verdadeiro 
        //Input.GetKeyUp; -> Retorna verdadeiro enquanto determinada tecla é pressionada

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tecla A pressionada");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Pressionou B");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Pressionou C");
        }

    }

}
