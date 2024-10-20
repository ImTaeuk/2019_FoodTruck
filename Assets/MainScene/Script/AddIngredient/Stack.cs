using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    public static Stack instance;
    public List<GameObject> stack;
    private void Awake()
    {
        instance = this;
    }
    public bool AddStack(GameObject prefab)
    {
        if (stack.Count >= 10)
            return false;
        stack.Add(prefab);
        return true;
    }
}
