using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public Slider HPBar;
    public PlayerS player;
    
    void Update()//dont use update, call from player
    {
        HPBar.value = (float) player.currHP/player.maxHP;
    }
    
    public void ItemButton ()
    {
        SceneManager.LoadScene("Item");
        Debug.Log("Item scene load");
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");
        Debug.Log("Shop scene load");
    }

    public void ExitButton()
    {
        Debug.Log("Quitted");
    }
}