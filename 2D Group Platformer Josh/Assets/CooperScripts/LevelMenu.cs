using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void LoadLevelFour()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");

    }
}
