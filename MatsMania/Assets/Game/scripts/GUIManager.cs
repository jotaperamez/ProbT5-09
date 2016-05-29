using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

    public GameObject Title;

    public Text TextTitle;
    public Text TextSubTitle;
    public Text TextPoints;

    void Awake()
    {
        GameManager.OnNewGame += GameManager_OnNewGame;
        GameManager.OnEndGame += GameManager_OnEndGame;
    }

    /// <summary>
    /// Inicializador
    /// </summary>
    void Start()
    {
        Title.SetActive(true);

        TextTitle.text = "JAM EXAMPLE";
        TextSubTitle.text = "PRESS TO START";
        TextPoints.text = "RECORD " + GameManager.BestPoints;
    }

   
    private void GameManager_OnNewGame()
    {
        Title.SetActive(false);
    }

   
    private void GameManager_OnEndGame()
    {
        Title.SetActive(true);

        TextTitle.text = "¡FAILED!";
        TextSubTitle.text = "PRESS TO RETRY";
        TextPoints.text = "RECORD " + GameManager.BestPoints;
    }

    
    void Update()
    {
        if (GameManager.IsPlaying)
            TextPoints.text = GameManager.CurrentPoints.ToString();
    }

}
