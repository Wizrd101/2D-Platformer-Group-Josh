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
         SceneManager.LoadScene("LevelOneScene");
    }
        
    public void LoadLevelTwo()
    {
        if (HardMode.isHard == false)
        {
            SceneManager.LoadScene("LevelTwoScene");
        }
        else if (HardMode.isHard == true)
        {

        }
    }
    public void LoadLevelThree()
    {
        if (HardMode.isHard == false)
        {
            SceneManager.LoadScene("LevelThreeScene");
        }
        else if (HardMode.isHard == true)
        {

        }
    }       
    public void LoadLevelFour()
    {
        if (HardMode.isHard == false)
        {
            SceneManager.LoadScene("LevelFourScene");
        }
        else if (HardMode.isHard == true)
        {

        }
    }
    public void LoadLevelFive()
    {
        if (HardMode.isHard == false)
        {
            SceneManager.LoadScene("LevelFiveScene");
        }
        else if (HardMode.isHard == true)
        {

        }
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
