using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameoverText;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null) { 
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()  {
        
    }
    
    public void BirdDied()
    {
        gameoverText.SetActive(true);
        gameOver = true;
    }

}
