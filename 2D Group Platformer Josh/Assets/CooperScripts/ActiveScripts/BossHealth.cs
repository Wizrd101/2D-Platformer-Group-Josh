using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject enemy;
    public static int damageAmount = 2;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        if (HardMode.isHard == true)
        {
            health += 5;
        }
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "PlayerBullet")
        {
            health -= damageAmount;
            slider.value = health;
            if (health <= 0)
            {
                Destroy(enemy);
                Debug.Log("Boss Killed");
                FreeGhosts.isBossDead = true;
            }
        }
    }
}
