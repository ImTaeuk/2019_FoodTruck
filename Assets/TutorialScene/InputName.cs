using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour
{
    public AudioSource click;
    public string userName;
    public static InputName instance;
    public InputField nameField;
    private void Start()
    {
        instance = this;
    }
    public void SetName()
    {
        click.Play();
        userName = nameField.text;
    }
    public void NextScene()
    {
        click.Play();
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        yield return null;
        SceneManager.LoadScene("MainScene");
    }
}
