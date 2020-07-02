using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public Slider HPBar;
    public PlayerS player;
    
    void Update()//dont use update, call from PlayerS
    {
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