using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Playables;



public class GameManager : MonoBehaviour
{
   
    
    public static GameManager Instance { get; private set; }

    private int currentLevel;
    private int playerExp;

    private string saveFilePath;   
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }
        
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        currentLevel = 1;
        playerExp = 0;


    }


    public void LoadGame()
    {
   
        
    }

   

}
