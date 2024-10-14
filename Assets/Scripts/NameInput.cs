using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    //¸¶¿ì½º
    public void InputName()
    {
        playerName = playerNameInput.text;
        if (playerName.Length >= 2)
        {
            playerName = playerNameInput.text;
            GameManager.name = playerName;
            SceneManager.LoadScene("SampleScene");
        }
    }
}

