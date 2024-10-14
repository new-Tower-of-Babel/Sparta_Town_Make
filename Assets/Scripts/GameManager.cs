using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text nametext;
    public static string name;
    private void Awake()
    {
        nametext = GetComponentInChildren<Text>();
        nametext.text = name;
        if (instance == null)
        {
            instance = this;
        }
    }
}
