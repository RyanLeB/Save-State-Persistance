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
    public SceneLoader sceneLoader;




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
        // press 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sceneLoader.LoadScene(0);
        }

        // press 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sceneLoader.LoadScene(1);
        }

        // press 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sceneLoader.LoadScene(2);
        }

        // press 4
        if (Input.GetKeyDown(KeyCode.Alpha4))        {
            sceneLoader.LoadScene(3);
        }
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
