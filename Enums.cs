using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    //Coleção de constantes

   public enum Direcoes
    {
        Norte, 
        Sul,
        Leste,
        Oeste,
    }

    public Direcoes MinhaDirecao;

    // Start is called before the first frame update
    void Start()
    {
        switch (MinhaDirecao)
        {
            case Direcoes.Norte:
                DirecaoSelecionada("Norte selecionado");
                break;

            case Direcoes.Sul:
                DirecaoSelecionada("Sul selecionado");
                break;

            case Direcoes.Leste:
                DirecaoSelecionada("Leste selecionado");
                break;

            case Direcoes.Oeste:
                DirecaoSelecionada("Oeste selecionado");
                break;
        }
    }

    void DirecaoSelecionada(string texto)
    {
        Debug.Log(texto);
    }

}
