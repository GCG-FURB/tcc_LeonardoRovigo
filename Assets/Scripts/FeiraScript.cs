using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class FeiraScript : MonoBehaviour
{
    public GameObject Exercicio;
    private bool ExercicioMovido;
    private int vezesMovidas = 0;
    public static string MoleculaNaVisao = string.Empty;
    void Start()
    {
        ExercicioMovido = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Exercicio != null && !ExercicioMovido)
        {               
            var vetor = Vector3.forward;
            vetor.z = 0.003f;
            Exercicio.transform.Translate(vetor);
            vezesMovidas++;
            if(vezesMovidas >= 80)
            {
                Exercicio.GetComponent<Rigidbody>().useGravity = true;
                Exercicio.transform.SetParent(null, true);
                Exercicio = null;
                ExercicioMovido = true;
                vezesMovidas = 0;
            }
        }
    }

    
    public void AtivarExercicio(string nomeObjeto)
    {
        Exercicio = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == nomeObjeto).FirstOrDefault();
        Exercicio.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "AngularFragmentada" && other.GetType().Name == "CapsuleCollider")
        {
            MoleculaNaVisao = "AngularFragmentada";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "AngularFragmentada" && other.GetType().Name == "CapsuleCollider")
        {
            MoleculaNaVisao = "";
        }
    }
}
