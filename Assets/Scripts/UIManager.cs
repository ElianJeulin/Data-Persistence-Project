using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Best Score: " + MainManagerMenu.Instance.name + " - " + MainManagerMenu.Instance.bestScore; 
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
        MainManagerMenu.Instance.SaveScore();
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
