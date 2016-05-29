using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {


    public void Jugar()
    {
        Debug.Log("jugar pulsado");
        Application.LoadLevel(3);
    }
    public void Acercade()
    {
        Debug.Log("Acerca de pulsado");
        Application.LoadLevel(1);
    }
    public void Instrucciones()
    {
        Debug.Log("Instrucciones Pulsado");
        Application.LoadLevel(2);
    }
}
