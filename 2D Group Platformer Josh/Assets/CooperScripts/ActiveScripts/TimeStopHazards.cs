using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStopHazards : MonoBehaviour
{
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
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<TimeStop>().StopTime(0.05f, 5, 0.1f);
        }
    }
}
