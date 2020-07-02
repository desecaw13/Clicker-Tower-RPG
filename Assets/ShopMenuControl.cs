using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ShopMenuControl : MonoBehaviour
{
    public PlayerS player;

    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }
}
