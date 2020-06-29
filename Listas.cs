using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    [System.Serializable]
    public class Inimigo
    {
        public string nome;
        public int velocidade;
        public int dano;

        public Inimigo(string n, int v, int d)
        {
            nome = n;
            velocidade = v;
            dano = d;
        }

    }

    public List<Inimigo> inimigos = new List<Inimigo>();

    void Start()
    {
        inimigos.Add(new Inimigo("Inimigo x", 400, 10));
        inimigos.Add(new Inimigo("Inimigo y", 200, 25));
    }

    /* Update is called once per frame
    void Update()
    {
        
    }*/


}
