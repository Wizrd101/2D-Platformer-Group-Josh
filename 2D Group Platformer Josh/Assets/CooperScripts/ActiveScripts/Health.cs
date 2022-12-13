using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Health : MonoBehaviour
{
    public int health = 10;
    public Slider slider;
    public int maxHealth = 10;
    public TextMeshProUGUI healthText;
    public int healing = 4;
    // name of the lose screen
    public string sceneName;
    public static bool isDead = false;
    float timer = 0f;
    // Start is called before the first frame update
    //public AudioClip potionDrink;
    void Start()
    {
        // slider must be set before scene loading will work
        slider.maxValue = health;
        slider.value = health;
    }
    // Update is called once per frame
    void Update()
    {
        //healthText.text = $"Health: {health}";
        if (isDead == true)
        {
            timer += Time.deltaTime;
            GetComponent<Animator>().SetTrigger("Death");
            if (timer > 2f)
            {
                Debug.Log("Next Scene");
                SceneManager.LoadScene(sceneName);
                timer = 0;
                isDead = false;
            }
        }
        


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "DamageTag" && HardMode.isHard == true)
        {
            PlatformerMovement.knockbackCounter = PlatformerMovement.knockbackTotalTime;
            if (collision.transform.position.x <= transform.position.x)
            {
                PlatformerMovement.knockFromRight = true;
            }
            if (collision.transform.position.x > transform.position.x)
            {
                PlatformerMovement.knockFromRight = false;
            }
            health -= 3;
            slider.value = health;
            if (health <= 0)
            {
                isDead = true;
            }
        }
        else if (otherTag == "DamageTag")
        {
            
            PlatformerMovement.knockbackCounter = PlatformerMovement.knockbackTotalTime;
            if (collision.transform.position.x <= transform.position.x)
            {
                PlatformerMovement.knockFromRight = true;
            }
            else if (collision.transform.position.x > transform.position.x)
            {
                PlatformerMovement.knockFromRight = false;
            }
            GetComponent<Animator>().SetTrigger("GetHit");
            health -= 2;
            slider.value = health;
            if (health <= 0)
            {
                    isDead = true;
                Debug.Log("Dead");
            }
            
            
        }
        else if (otherTag == "OutOfBounds")
        {
            SceneManager.LoadScene(sceneName);
        }
        else if (otherTag == "Healing")
        {
            health += healing;
            Destroy(collision.gameObject);
            //GetComponent<AudioSource>().PlayOneShot(potionDrink);
            if (health > maxHealth)
            {
                health = maxHealth;
                
            }
            slider.value = health;
        }
    }
}

