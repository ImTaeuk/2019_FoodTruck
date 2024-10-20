using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBread : AddIngredient
{
    //빵 프리팹
    public GameObject HoneyOat;
    public GameObject Oregano;
    public GameObject White;
    public GameObject Flat;
    public GameObject Wit;
    public GameObject Sesame;
    // 빵 버튼 메소드
    public void OnClickHoneyOatButton()
    {
        IngredientSet(Instantiate(HoneyOat));
    }
    public void OnClickOregano()
    {
        IngredientSet(Instantiate(Oregano));
    }
    public void OnClickWhite()
    {
        IngredientSet(Instantiate(White));
    }
    public void OnClickWit()
    {
        IngredientSet(Instantiate(Wit));
    }
    public void OnClickSesame()
    {
        IngredientSet(Instantiate(Sesame));
    }
    public void OnClickFlat()
    {
        IngredientSet(Instantiate(Flat));
    }
}
