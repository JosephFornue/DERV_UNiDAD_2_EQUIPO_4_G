using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class S7_Corrutina : MonoBehaviour
{
    int contador_segundos;
   [SerializeField] TextMeshProUGUI Texto_Tiempo;
    void Start()
    {
      contador_segundos = 0;
      StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
   
    
       IEnumerator corrutinaTiempo(){
        while (true){
        Texto_Tiempo.text =contador_segundos++.ToString();
        yield return new  WaitForSeconds(0.25f); 
    

        } 
    }
}
