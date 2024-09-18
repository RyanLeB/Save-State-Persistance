using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Playables;



public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public static int instanceCount = 0;

    public float levelsCleared;
    public float playerExp;
    public float playerHealth;
    public float playerMana;
    public float playerStamina;
    public SceneLoader sceneLoader;




    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }

        instanceCount++;
    }
    private void OnDestroy()
    {
        instanceCount--; 
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


    private void OnGUI()
    {
        GUI.Label(new Rect(150, 10, 100, 20), "Level: " + levelsCleared);
        GUI.Label(new Rect(150, 30, 100, 20), "Exp: " + playerExp);
        GUI.Label(new Rect(150, 50, 100, 20), "Health: " + playerHealth);
        GUI.Label(new Rect(150, 70, 100, 20), "Mana: " + playerMana);
        GUI.Label(new Rect(150, 90, 100, 20), "Stamina: " + playerStamina);
        GUI.Label(new Rect(150, 300, 150, 20), "Instances: " + instanceCount);
    }




// Saves the game data
public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerData.save");

        PlayerData data = new PlayerData();
        data.levelsCleared = levelsCleared;
        data.playerExp = playerExp;
        data.playerHealth = playerHealth;
        data.playerMana = playerMana;
        data.playerStamina = playerStamina;

        bf.Serialize(file, data);
        file.Close();
    }

    // Loads the game data
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerData.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerData.save", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            levelsCleared = data.levelsCleared;
            playerExp = data.playerExp;
            playerHealth = data.playerHealth;
            playerMana = data.playerMana;
            playerStamina = data.playerStamina;
        }   
    }

}

// Storage class for player data
[System.Serializable]
class PlayerData
{
    public float levelsCleared;
    public float playerExp;
    public float playerHealth;
    public float playerMana;
    public float playerStamina;
}

