using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateERotation : MonoBehaviour
{
    //Interessante para a movimentação de objetos

    public float Velocidade;
    public float Rotacao;
    
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update() //linhas de códigos de movimentação são postas no update
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
            //deltaTime serve para suavizar a movimentação dos objetos
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(-Vector3.up * Rotacao * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * Rotacao * Time.deltaTime);
        }
    }
}
