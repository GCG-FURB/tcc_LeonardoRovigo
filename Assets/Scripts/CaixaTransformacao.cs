using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CaixaTransformacao : MonoBehaviour
{
    public static GameObject RespostaNaCaixa;
    private static List<GameObject> ListaRespostasNaCaixa;
    // Start is called before the first frame update
    void Start()
    {
        ListaRespostasNaCaixa = new List<GameObject>();
        RespostaNaCaixa = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (Utils.ListaRespostas.Any(p => p == other.name))
        {
            ListaRespostasNaCaixa.Add(other.gameObject);
            RespostaNaCaixa = other.gameObject;
            if (ListaRespostasNaCaixa.Count() > 1)
                RespostaNaCaixa = null;
        }
        
           
    }

    private void OnTriggerExit(Collider other)
    {
        if (Utils.ListaRespostas.Any(p => p == other.name))
        {
            ListaRespostasNaCaixa.Remove(other.gameObject);
            RespostaNaCaixa = null;
            if (ListaRespostasNaCaixa.Count() == 1)
                RespostaNaCaixa = ListaRespostasNaCaixa.FirstOrDefault();
            
        }
    }
}
