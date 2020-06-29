using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanteateEDestroy : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Criando cópias de um objeto na cena ao pressionar uma tecla
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Instantiate(Prefab, transform.position, transform.rotation); // -> indica a posição em que o objeto será gerado
            //Instantiate(Prefab);
            Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }

        
        
    }

}
