using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("BusinessAcademy");
        
    }

    public void QuitGame()
    {
        // Logika na ukonèenie hry
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
