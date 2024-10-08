using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_ResetPosicion : MonoBehaviour
{
    [SerializeField] Transform Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.R)){
      transform.position = Spawn.transform.position;
      }      
    }
}
