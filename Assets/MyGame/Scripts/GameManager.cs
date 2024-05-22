using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float TimeFinish = 0;
    public bool FinishGame = false;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if(instance = null )
                {
                    GameObject gameManagemeObject = new GameObject("GameManager");
                    instance = gameManagemeObject.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }
    private void Update()
    {
        if(!FinishGame)
        {
            TimeFinish += Time.deltaTime;
            //Debug.Log(TimeFinish);
            if(TimeFinish < 0) 
            {
                EndGame();
            }
        }
    }
    public void EndGame()
    {
        FinishGame = true;
    }
}
