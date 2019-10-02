using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int XP;
    public int currentLevel;


    // Start is called before the first frame update
    void Start()
    {
        UpdateXP(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateXP(int exp)
    {
        XP += exp;
        int ourLvl = (int)(0.1f * Mathf.Sqrt(XP));

        if( ourLvl != currentLevel)
        {
            currentLevel = ourLvl;
            //you
        }

        int xpNxtLevel = 100 * (currentLevel + 1) * (currentLevel + 1);
        int differenceXp = xpNxtLevel - XP;

        int totalDifference = xpNxtLevel - (100 * currentLevel * currentLevel);
    }
}
