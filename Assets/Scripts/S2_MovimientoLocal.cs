using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_MovimientoLocal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        float constante_velocidad= 5;
       if(Input.GetKey(KeyCode.W)){
                                                   //transform.Translate(Vector3.forward)
        //transform.Translate(constante_velocidad * Time.deltaTime * transform.forward);
        transform.position += constante_velocidad * Time.deltaTime * transform.forward;
       }
      else if (Input.GetKey(KeyCode.S)){
       // transform.Translate(constante_velocidad * -1 *Time.deltaTime * transform.forward);
        transform.position +=constante_velocidad * -1 * Time.deltaTime * transform.forward;
       
       }
    }}

