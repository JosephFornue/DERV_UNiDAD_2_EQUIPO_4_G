using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class S9_Destruye2ekibidis : MonoBehaviour
{
      
    [SerializeField] TextMeshProUGUI txt_contador1;
    [SerializeField] TextMeshProUGUI txt_contador;
    public int contador;
    public int contador1
    ;
    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Ekibidis")){
            Destroy(obj);
            contador++;
            txt_contador.text = "enemigos B: " + contador.ToString();
        }
        GameObject obj2 = other.gameObject;
        if(obj.CompareTag("NoRompible")){
            Destroy(obj2);
            contador1++;
            txt_contador1.text = "enemigos A: " + contador1.ToString();
        }

    }
   
    // Start is called before the first frame update
    void Start()
    {
      contador = 0;
      contador1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
