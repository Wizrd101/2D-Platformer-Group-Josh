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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GhostCage")
        {
            ghostCount++;
            Destroy(collision.gameObject);
            if (ghostCount >= ghostsNeeded)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
