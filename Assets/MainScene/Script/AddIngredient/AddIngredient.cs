using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    //메인메뉴의 재료 추가 메소드
    public void IngredientSet(GameObject prefab)
    {
        SoundManager2.instance.PlayClickSound();
        prefab.transform.SetParent(GameObject.Find("IngredientStack").transform);
        prefab.transform.localPosition = new Vector3(0, 0.2f, 0);
        prefab.GetComponent<Rigidbody2D>().freezeRotation = true;
    }
}
