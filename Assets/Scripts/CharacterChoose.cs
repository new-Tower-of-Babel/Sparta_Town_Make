using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChoose : MonoBehaviour
{
    public Image characterDisplay;
    public Image changeDisplay1;
    public Image changeDisplay2;

    public void ChangeDisplay()
    {
        characterDisplay.gameObject.SetActive(false);
        changeDisplay1.gameObject.SetActive(true);
        changeDisplay2.gameObject.SetActive(true);
    }
}
