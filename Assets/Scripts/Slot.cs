using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject ExercicioAtivo;
    void Start()
    {
        ExercicioAtivo = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (Utils.ListaExercicio.Contains(other.name))
        {
            var exercicio = other.gameObject;
            Text titulo = exercicio.transform.FindChildRecursive("Titulo").gameObject.GetComponent<Text>();
            Text texto = exercicio.transform.FindChildRecursive("Text").gameObject.GetComponent<Text>();
            var telaProjetor = GameObject.Find("TelaProjetor");

            telaProjetor.transform.Find("Titulo").GetComponent<Text>().text = titulo.text;
            telaProjetor.transform.Find("Text").GetComponent<Text>().text = texto.text;

            AtivarGameObjectPorNome("Angular_Small");
            AtivarGameObjectPorNome("Linear_Small");
            AtivarGameObjectPorNome("EmT_Small");
            AtivarGameObjectPorNome("QuadradoPlanar_Small");
            AtivarGameObjectPorNome("TrigonalPlana_Small");
            AtivarGameObjectPorNome("AreaExercicioH2O");
            ExercicioAtivo = other.gameObject;
        }
    }

    public static void AtivarGameObjectPorNome(string nomeGameObject)
    {
        var gameObject = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == nomeGameObject).FirstOrDefault();
        gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (Utils.ListaExercicio.Contains(other.name))
        {
            var telaProjetor = GameObject.Find("TelaProjetor");

            telaProjetor.transform.Find("Titulo").GetComponent<Text>().text = string.Empty;
            telaProjetor.transform.Find("Text").GetComponent<Text>().text = string.Empty;
        }
    }
}
