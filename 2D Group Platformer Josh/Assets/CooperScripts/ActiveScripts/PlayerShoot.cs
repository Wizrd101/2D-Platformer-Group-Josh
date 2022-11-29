 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public float bulletLifeTime = 1.5f;
    public AudioClip shootSound;
    float timer = 0.0f;
    public float shootDelay;
    public static bool grounded = false;
    Animator animator;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        timer += Time.deltaTime;
        if (Time.timeScale == 1)
        {
            if (Input.GetButtonDown("Fire1") && timer >= shootDelay && PlatformerMovement.grounded == true)
            {
                animator.SetTrigger("Active");
                GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Vector3 shootDirection = mousePosition - transform.position;
                shootDirection.Normalize();
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDirection * speed;
                Destroy(bulletSpawn, bulletLifeTime);
                GetComponent<AudioSource>().PlayOneShot(shootSound);
                timer = 0;
            }
        }
        animator.SetFloat("xInput", xInput);
        animator.SetBool("grounded", grounded);
        if (xInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (xInput > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
