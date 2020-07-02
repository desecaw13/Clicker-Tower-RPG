using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    //player stats
    public int Level;
    public int Gold;
    public int Exp;

    public int currHP;
    public int maxHP;
    public int Str;
    public int Def;
    public int Speed;
    public int Luck;

    void Start()
    {
        Level = 1;
        Gold = 0;
        Exp = 0;
        currHP = 10;
        maxHP = 10;
        Str = 1;
        Def = 1;
        Speed = 1;
        Luck = 1;
    }

    void Update()
    {
        //;
    }

}
