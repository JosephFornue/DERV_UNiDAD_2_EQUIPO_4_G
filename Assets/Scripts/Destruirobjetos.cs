using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destruirobjetos : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_puntuacion;

    int contador;

    private void Start()
    {
        contador = 0;
        if (texto_puntuacion == null)
        {
            Debug.LogError("TextMeshProUGUI no está asignado en el inspector.");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject objeto = other.gameObject;
        if (objeto.CompareTag("NoRompible"))
        {
            contador++;
            texto_puntuacion.text = contador.ToString();
            Destroy(objeto);
        }
    }
}
