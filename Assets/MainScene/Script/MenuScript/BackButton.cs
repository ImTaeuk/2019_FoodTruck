using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void OnClickBackButton()
    {
        string activeName = "";
        SoundManager2.instance.PlayClickSound();
        foreach (GameObject tmp in GameManager.instance.Menus)
        {
            if (tmp.activeSelf == true)
                activeName = tmp.name;
        }

        if (activeName == "")
            Debug.Log("BackButtonNameError");
        if (activeName == "Ingredient")
            GameManager.instance.ActiveMenu("Main");
        if (activeName == "Patty" || activeName == "Bread" || activeName == "Vegetable")
            GameManager.instance.ActiveMenu("Ingredient");
            
    }
}
