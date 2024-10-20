using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPatty : AddIngredient
{
    //패티 프리팹
    public GameObject Beef;
    public GameObject Pork;
    public GameObject Chicken;
    public GameObject Egg;
    public GameObject Cheese;
    public GameObject Tuna;
    //패티메뉴 버튼 메소드
    public void OnClickBeefButton()
    {
        IngredientSet(Instantiate(Beef));
    }
    public void OnClickPorkButton()
    {
        IngredientSet(Instantiate(Pork));
    }
    public void OnClickChickenButton()
    {
        IngredientSet(Instantiate(Chicken));
    }
    public void OnClickEggButton()
    {
        IngredientSet(Instantiate(Egg));
    }
    public void OnClickCheeseButton()
    {
        IngredientSet(Instantiate(Cheese));
    }
    public void OnClickTunaButton()
    {
        IngredientSet(Instantiate(Tuna));
    }
}
