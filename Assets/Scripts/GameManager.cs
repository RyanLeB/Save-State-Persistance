using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Playables;


public class GameData
{
    public int currentLevel;
    public int playerExp;
}
public class GameManager : MonoBehaviour
{
   
    
    public static GameManager Instance;

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
        saveFilePath = Path.Combine(Application.persistentDataPath, "savefile.json");
    
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
        if (File.Exists(saveFilePath))
        {
            string json = File.ReadAllText(saveFilePath);
            GameData data = JsonUtility.FromJson<GameData>(json);
            currentLevel = data.currentLevel;
            playerExp = data.playerExp;
            Debug.Log("Game Loaded");
        }
        else
        {
            currentLevel = 1;
            playerExp = 0;
            Debug.Log("No save data found, starting new game");
        }
    }

    public void SaveGame()
    {
        GameData data = new GameData
        {
            currentLevel = currentLevel,
            playerExp = playerExp
        };

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(saveFilePath, json);
        Debug.Log("Game Saved");
    }

}
