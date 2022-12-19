using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HardMode : MonoBehaviour
{
    public static bool isHard = false;
    public static bool levelOneComplete = false;
    public static bool levelTwoComplete = false;
    public static bool levelThreeComplete = false;
    public static bool levelFourComplete = false;
    public static bool levelFiveComplete = false;
    string text;
    public TextMeshProUGUI hardText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHard == false)
        {
            text = "Normal";
        }
        else if (isHard == true)
        {
            text = "Hard";
        }
        hardText.text = $"Difficulty: {text}";
    }
    public void EnableHardMode()
    {
        if (levelFiveComplete == true && levelFourComplete == true && levelOneComplete == true && levelThreeComplete == true && levelTwoComplete == true)
        {
            isHard = true;
            Debug.Log("Hard Mode Active");
            SceneManager.LoadScene("Level Select");
        }
        
    }
    public void DisableHardMode()
    {
        isHard = false;
        Debug.Log("Hard Mode Disabled");
        SceneManager.LoadScene("Level Select");
    }
}
