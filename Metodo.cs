using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Metodo : MonoBehaviour
{
    // O método/função executa um bloco de ações (códigos) toda vez que é chamado
    public int Vida;
    public int ValorDano;

    // Start is called before the first frame update
    void Start()
    {
        DiminuirVida(ValorDano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //o void significa que o método não retornará nada
    void DiminuirVida(int dano)
    {
        Vida -= dano;
    }
}
