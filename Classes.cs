using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    [System.Serializable]
    //pode servir para a criação de inimigos! 
    public class Cachorro
    {
        public string raca;
        public int idade;
        public int tamanho;

        public Cachorro(string Raca, int Idade, int Tamanho)
        {
            raca = Raca;
            idade = Idade;
            tamanho = Tamanho;
        }
    }

    public Cachorro Dog = new Cachorro("Poodle", 5, 80);
    
    // Start is called before the first frame update
   private void Start()
    {
        Debug.Log(Dog.raca);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
