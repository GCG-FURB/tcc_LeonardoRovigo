using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ParteMovel : MonoBehaviour
{
    // Start is called before the first frame update
    private float posicaoYInicial = 0;
    void Start()
    {
        posicaoYInicial = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Limitador")
            this.transform.position = new Vector3(transform.position.x, posicaoYInicial, transform.position.z);
        
    }
}
