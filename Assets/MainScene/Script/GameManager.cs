using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] Menus;
    public GameObject SettingMenu;

    public void ActiveMenu(string name)
    {
        foreach (GameObject tmp in Menus)
        {
            if (tmp.gameObject.name == name)
                tmp.SetActive(true);
            else tmp.SetActive(false);
        }
    }
    private void Awake()
    {
        instance = this;
        Menus = GameObject.FindGameObjectsWithTag("Menu");
        ActiveMenu(Menus[0].name);
        SettingMenu.SetActive(false);
    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
