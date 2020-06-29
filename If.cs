using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public int n1;
    public int n2;

    public bool Valor;

    // Start is called before the first frame update
    void Start()
    {

        if (n1 > 0)
        {
            Debug.Log("positivo");
        }

        else if (n1 < 0)
        {
            Debug.Log("negativo");
        }

        else
        {
            Debug.Log("zero");
        }           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}