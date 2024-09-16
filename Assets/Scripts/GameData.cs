using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public int currentLevel;
    public int playerExp;


    public GameData(int currentLevel, int playerExp)
    {
        this.currentLevel = currentLevel;
        this.playerExp = playerExp;
    }
}
