using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class FreeGhosts : MonoBehaviour
{
    public int ghostCount = 0;
    public int ghostsNeeded = 2;
    public TextMeshProUGUI coinText;
    public string sceneName;
    public string currentScene;
    static public bool isBossDead = false;
    // Start is called before the first frame update
    void Start()
    {
        isBossDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = $"Ghosts Freed: {ghostCount} / {ghostsNeeded}";
        if (ghostCount >= ghostsNeeded && isBossDead == true)
        {
            if (currentScene == "LevelOneScene")
            {
                HardMode.levelOneComplete = true;
            }
            else if (currentScene == "LevelTwoScene")
            {
                HardMode.levelTwoComplete = true;
            }
            else if (currentScene == "LevelThreeScene")
            {
                HardMode.levelThreeComplete = true;
            }
            else if (currentScene == "LevelFourScene")
            {
                HardMode.levelFourComplete = true;
            }
            else if (currentScene == "LevelFiveScene")
            {
                HardMode.levelFiveComplete = true;
            }
            SceneManager.LoadScene(sceneName);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GhostCage")
        {
            ghostCount++;
            Destroy(collision.gameObject);
        }
        
    }
}
