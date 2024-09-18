using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 100, 30), "Player Level Up"))
        {
            GameManager.instance.levelsCleared += 1;
        }
        if (GUI.Button(new Rect(10, 60, 100, 30), "Player Level Down"))
        {
            GameManager.instance.levelsCleared -= 1;
        }

        if (GUI.Button(new Rect(10, 100, 100, 30), "Health Up"))
        {
            GameManager.instance.playerHealth += 10;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Health Down"))
        {
            GameManager.instance.playerHealth -= 10;
        }
        if (GUI.Button(new Rect(10, 180, 100, 30), "Exp Up"))
        {
            GameManager.instance.playerExp += 10;
        }
        if (GUI.Button(new Rect(10, 220, 100, 30), "Exp Down"))
        {
            GameManager.instance.playerExp -= 10;
        }
        if (GUI.Button(new Rect(10, 260, 100, 30), "Mana Up"))
        {
            GameManager.instance.playerMana += 10;
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Mana Down"))
        {
            GameManager.instance.playerMana -= 10;
        }
        if (GUI.Button(new Rect(10, 340, 100, 30), "Stamina Up"))
        {
            GameManager.instance.playerStamina += 10;
        }
        if (GUI.Button(new Rect(10, 380, 100, 30), "Stamina Down"))
        {
            GameManager.instance.playerStamina -= 10;
        }
        if (GUI.Button(new Rect(10, 420, 100, 30), "Save"))
        {
            GameManager.instance.Save();
        }
        if (GUI.Button(new Rect(10, 460, 100, 30), "Load"))
        {
            GameManager.instance.Load();
        }
    }
    
}
