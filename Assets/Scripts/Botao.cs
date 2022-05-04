using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ParteMovel")
        {
            var exercicio = Slot.ExercicioAtivo;
            var resposta = CaixaTransformacao.RespostaNaCaixa;
            if (resposta != null && exercicio != null && exercicio.name == "ExercicioH2O" && resposta.name == "Angular_Small")
            {
                AtivarGameObjectPorNome("Agua");
            }
        }
    }
    public static void AtivarGameObjectPorNome(string nomeGameObject)
    {
        var gameObject = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == nomeGameObject).FirstOrDefault();
        gameObject.SetActive(true);
    }
}
