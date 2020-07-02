using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ItemMenuControl : MonoBehaviour
{
    public PlayerS player;

    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }
}
