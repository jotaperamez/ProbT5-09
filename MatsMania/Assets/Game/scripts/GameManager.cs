using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

   
    public static event GameEventHandler OnNewGame;
    public static event GameEventHandler OnEndGame;
    public static bool IsPlaying;
    public static int CurrentPoints;
    public static int BestPoints;

    
    void Awake()
    {
        BestPoints = PlayerPrefs.GetInt("Game.BestPoints", 0);
    }

    
    public void NewGame()
    {
        CurrentPoints = 0;

        IsPlaying = true;

        if (OnNewGame != null)
            OnNewGame();
    }

    
    void Update()
    {
       
    }

    
    private void EndGame()
    {
        IsPlaying = false;

        if (CurrentPoints > BestPoints)
        {
            BestPoints = CurrentPoints;
            PlayerPrefs.SetInt("Game.BestPoints", BestPoints);
        }

        if (OnEndGame != null)
            OnEndGame();
    }
}
public delegate void GameEventHandler();