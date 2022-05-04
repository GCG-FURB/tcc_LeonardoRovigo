using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Utils : MonoBehaviour
{
    public static List<string> ListaRespostas = new List<string>() { 
        "Angular_Small",
        "Linear_Small",
        "EmT_Small",
        "QuadradoPlanar_Small",
        "TrigonalPlana_Small"
    };
    
    public static List<string> ListaExercicio = new List<string>() {
        "ExercicioH2O"
    };

    
    public static void AtivarGameObjectPorNome(string nomeGameObject)
    {
        var gameObject = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == nomeGameObject).FirstOrDefault();
        gameObject.SetActive(true);
    }


}

