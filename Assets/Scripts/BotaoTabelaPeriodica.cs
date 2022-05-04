using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BotaoTabelaPeriodica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void RenderizarMenu()
    {
        var menu = Resources.FindObjectsOfTypeAll<GameObject>().Where(p => p.name == "MenuMoleculas" && p.transform.parent == this.transform).FirstOrDefault();

        if (menu != null)
            menu.SetActive(true);

    }
}
