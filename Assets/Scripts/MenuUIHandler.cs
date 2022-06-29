using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{

    public TextMeshProUGUI bestscoreDetails;
    public TextMeshProUGUI getName;

    private void Start()
    {
        if (MenuManager.Instance.loadScore != 0)
        {
            UpdateBestScore();
        }
    }

    public void StartNew()
    {
        MenuManager.Instance.Name = getName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        if (Application.isEditor)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit(); // original code to quit Unity player
        }

    }

    public void UpdateBestScore()
    {
        bestscoreDetails.text = "Best Score : " + MenuManager.Instance.loadName + " : " + MenuManager.Instance.loadScore;
    }
}
