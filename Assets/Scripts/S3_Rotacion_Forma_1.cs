using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Rotacion_Forma_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     float velocidad = 5;   
     float angulos = 5 * Time.deltaTime * velocidad;
                   // x     y     z
     transform.Rotate(0, angulos, 0);   
    }
}
