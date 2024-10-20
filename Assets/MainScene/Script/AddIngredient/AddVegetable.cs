using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVegetable : AddIngredient
{
    //야채 프리팹
    public GameObject Potato;
    public GameObject Lettuce;
    public GameObject Tomato;
    public GameObject Pickle;
    public GameObject Cucumber;
    public GameObject Pepper;
    public GameObject Olive;
    //야채 버튼
    public void OnClickPotato()
    {
        IngredientSet(Instantiate(Potato));
    }
    public void OnClickLettuce()
    {
        IngredientSet(Instantiate(Lettuce));
    }
    public void OnClickTomato()
    {
        IngredientSet(Instantiate(Tomato));
    }
    public void OnClickPickle()
    {
        IngredientSet(Instantiate(Pickle));
    }
    public void OnClickCucumber()
    {
        IngredientSet(Instantiate(Cucumber));
    }
    public void OnClickPepper()
    {
        IngredientSet(Instantiate(Pepper));
    }
    public void OnClickOlive()
    {
        IngredientSet(Instantiate(Olive));
    }
}
