using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenMessagesController : MonoBehaviour {

    public Text score;
    public Text statusText;
    public static ScreenMessagesController instance;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    public void SetMessageGameState (int state)
    {

        switch (state)
        {

            case 0: statusText.text = "Par";
                break;
            case 1: statusText.text = "Impar";
                break;
            case 2: statusText.text = "Raices";
                break;
            case 3: statusText.text = "Primos";
                break;
            default: statusText.text = "No funca";
                break;

        }


    }

    public void setScore(int puntos)
    {
        score.text = "Score: " + puntos;
    }

}
