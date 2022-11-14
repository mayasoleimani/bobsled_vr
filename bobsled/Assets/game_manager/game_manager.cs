using UnityEngine;
using System.Collections;

// Game States
// for now we are only using these two
public enum GameState { INTRO, MAIN_MENU }

public delegate void OnStateChangeHandler();

public class SimpleGameManager
{
    protected SimpleGameManager() { }
    private static SimpleGameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }
    int x = 0;


    public static SimpleGameManager Instance
    {
        get
        {
            if (SimpleGameManager.instance == null)
            {
                SimpleGameManager.instance = new SimpleGameManager();
            }
            return SimpleGameManager.instance;
        }

    }


        public void JXON() {

        int x = 1;
        Debug.Log("works");
        return;
        }

        



    }

