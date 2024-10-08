using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S6_Contador : MonoBehaviour
{
    int cont;
   [SerializeField] TextMeshProUGUI texto_contador;
    void Start()
    {
       cont = 60;
       StartCoroutine("corrutina_contador");
       
    }
   
     IEnumerator corrutina_contador(){
        while(cont>0){
            cont--;
            texto_contador.text = cont.ToString();
            yield return new WaitForSeconds(0.5f);
        }
     }
}
