using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

   public int DiaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                Debug.Log("domingo");
                break;

            case 2:
                Debug.Log("segunda");
                break;

            case 3:
                Debug.Log("terça");
                break;

            case 4:
                Debug.Log("quarta");
                break;

            default:
                Debug.Log("Fora de data");
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
