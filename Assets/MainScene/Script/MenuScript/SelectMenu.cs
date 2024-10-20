using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
    public void OnClickMainButton()
    {
        SoundManager2.instance.PlayClickSound();
        GameManager.instance.ActiveMenu("Ingredient");
    }
    // 메인메뉴의 세부 메뉴
    public void OnClickPattyButton()
    {
        SoundManager2.instance.PlayClickSound();
        GameManager.instance.ActiveMenu("Patty");
    }
    public void OnClickBreadButton()
    {
        SoundManager2.instance.PlayClickSound();
        GameManager.instance.ActiveMenu("Bread");
    }
    public void OnClickVegetableButton()
    {
        SoundManager2.instance.PlayClickSound();
        GameManager.instance.ActiveMenu("Vegetable");
    }
    //메인메뉴의 재료 추가 메소드
    private void IngredientSet(GameObject prefab)
    {
        SoundManager2.instance.PlayClickSound();
        prefab.transform.SetParent(GameObject.Find("IngredientStack").transform);
        prefab.transform.localPosition = new Vector3(0, 0.2f, 0);
        prefab.GetComponent<Rigidbody2D>().freezeRotation = true;
    }
    
}
