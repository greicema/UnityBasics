// Estrutura básica de código na Unity
// Os itens com 'using' são as bibliotecas utilizadas no código
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Variáveis podem ser públicas ou privadas
public class Script : MonoBehaviour // -> referência ao nome do código na Unity
{
    //Variáveis possíveis na Unity
    int Valor = 10; //Números inteiros
    float NumeroDecimal = 10.10f; //Números decimais. Precisa acrescentar um f ao final do valor
    string Texto = "um texto"; //Texto
    //Exclusivas da Unity
    public GameObject gameobject; //Torna possível a associação do código a um outro GameObject
    public Transform TransformUnity;
    //Tantos outros...

    
    public int ValorInteiro;

    private int ValorInt; // Variáveis privadas elas só podem ser acessadas na classe que estão inseridas
    // Além disso, não aparecem no editor da unity
    // int Valor = private int Valor

    
    // Start e Update são métodos que já estão no código por padrão
    // Start é chamado quando o jogo inicia
    void Start()
    {
        gameobject = gameObject;
    }

    // Update é chamado por frame. ex: movimentação do personagem
    void Update()
    {
        
    }

}
