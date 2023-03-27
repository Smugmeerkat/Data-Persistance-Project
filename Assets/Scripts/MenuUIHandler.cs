using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField userInputField;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.LoadScore();
    }

    public void setName()
    {
        GameManager.Instance.userName = userInputField.text;
    }
}
