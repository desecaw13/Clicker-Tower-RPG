using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuControl : MonoBehaviour
{
    public PlayerS player;

    public Slider HPBar;

    public TextMeshProUGUI level_text;
    public TextMeshProUGUI gold_text;
    public TextMeshProUGUI exp_text;
    public TextMeshProUGUI hp_text;
    public TextMeshProUGUI str_text;
    public TextMeshProUGUI def_text;
    public TextMeshProUGUI speed_text;
    public TextMeshProUGUI luck_text;
    public string levelText;
    public string goldText;
    public string expText;
    public string hpText;
    public string strText;
    public string defText;
    public string speedText;
    public string luckText;

    void Start()
    {
        level_text = level_text.GetComponent<TextMeshProUGUI>();
        gold_text = gold_text.GetComponent<TextMeshProUGUI>();
        exp_text = exp_text.GetComponent<TextMeshProUGUI>();
        hp_text = hp_text.GetComponent<TextMeshProUGUI>();
        str_text = str_text.GetComponent<TextMeshProUGUI>();
        def_text = def_text.GetComponent<TextMeshProUGUI>();
        speed_text = speed_text.GetComponent<TextMeshProUGUI>();
        luck_text = luck_text.GetComponent<TextMeshProUGUI>();
    }

    void Update()//dont use update, call from PlayerS
    {
        levelText = "Level: " + player.Level;
        level_text.text = levelText;

        goldText = "Gold: " + player.Gold;
        gold_text.text = goldText;

        expText = "Exp: " + player.Exp;
        exp_text.text = expText;

        hpText = "HP: " + player.currHP;
        hp_text.text = hpText;

        strText = "Str: " + player.Str;
        str_text.text = strText;

        defText = "Def: " + player.Def;
        def_text.text = defText;

        speedText = "Speed: " + player.Speed;
        speed_text.text = speedText;

        luckText = "Luck: " + player.Luck;
        luck_text.text = luckText;

        HPBar.value = (float) player.currHP/player.maxHP;
    }
    
    public void ItemButton ()
    {
        SceneManager.LoadScene("Item");
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");
    }

    public void ExitButton()
    {
        Debug.Log("Quitted");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }
}
