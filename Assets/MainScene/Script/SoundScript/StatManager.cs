using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public string truckName;
    public int date;
    public int money;
    public float rate;
    void Start()
    {
        truckName = InputName.instance.userName;
        GameObject.Find("name").GetComponent<Text>().text = truckName;
        GameObject.Find("date").GetComponent<Text>().text = date.ToString();
        GameObject.Find("money").GetComponent<Text>().text = money.ToString();
        GameObject.Find("rate").GetComponent<Text>().text = rate.ToString();
    }
    void Update()
    {
        
    }
}
