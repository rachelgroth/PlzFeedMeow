
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
    public string LevelName;
    public void OnTriggerEnter2D(Collider2D Battle)
    {
        if (Battle.CompareTag("Player"))
        {
            SceneManager.LoadScene(LevelName);
        }
    }
    public void GoToNewScene()
    {
        SceneManager.LoadScene(LevelName);
    }
    public void EndGame()
    {
        Debug.Log("Quit the Game");
        Application.Quit();
    }
}