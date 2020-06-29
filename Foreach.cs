using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    //Foreach tem a função parecida com For, a diferença é que só funciona em arrays
    //Arrays são estruturas de armazenamento

    string[] Inimigos = new string[3]; //Exemplo de array

    // Start is called before the first frame update
    void Start()
    {

        Inimigos[0] = "Inimigo 1";
        Inimigos[1] = "Inimigo 2";
        Inimigos[2] = "Inimigo 3";

        foreach(string i in Inimigos)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
