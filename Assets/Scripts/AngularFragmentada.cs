using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AngularFragmentada : MonoBehaviour
{
    private static bool PlayerNaArea; 
    // Start is called before the first frame update
    void Start()
    {
        PlayerNaArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        var fragmentadaEmPosicao = FeiraScript.MoleculaNaVisao == "AngularFragmentada" && PlayerNaArea;

        AlternarRenderers(fragmentadaEmPosicao);
        AlternarMolecula(fragmentadaEmPosicao, "Angular_Small_Static");
    }

    private void AlternarMolecula(bool fragmentadaEmPosicao, string nome)
    {
        var molecula = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == nome).FirstOrDefault();
        molecula.SetActive(fragmentadaEmPosicao);
    }

    private void AlternarRenderers(bool fragmentadaEmPosicao)
    {
        foreach (var render in GetComponentsInChildren<Renderer>())
            render.enabled = !fragmentadaEmPosicao;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "OVRPlayerController" && other.GetType().Name == "CharacterController")
        {
            PlayerNaArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "OVRPlayerController" && other.GetType().Name == "CharacterController")
        {
            PlayerNaArea = false;
        }
    }
}
