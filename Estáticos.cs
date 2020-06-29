using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estáticos : MonoBehaviour
{
    //CÓDIGO INCOMPLETO, MAS BASICAMENTE A IDEIA É ACESSAR UM SCRIPT EM OUTRO POR MEIO DE UM MÉTODO ESÁTICO

    public static Estáticos estaticos;

    // Start is called before the first frame update
    void Start()
    {
        estaticos = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
