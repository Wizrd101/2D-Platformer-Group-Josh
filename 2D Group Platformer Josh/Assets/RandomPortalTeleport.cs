using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPortalTeleport : MonoBehaviour
{
    int roomsComplete = 0;
    public GameObject teleport1;
    public GameObject teleport2;
    public GameObject teleport3;
    public GameObject teleport4;
    public GameObject teleport5;
    public GameObject teleport6;
    public GameObject teleport7;
    public GameObject teleport8;
    public GameObject teleport9;

    public bool roomMini;
    public int roomNumber;

    void OnCollisionEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (roomsComplete == 6)
            {
                other.transform.position = new Vector2(teleport9.transform.position.x, teleport9.transform.position.y);
            } 
            else if (roomsComplete >= 2)
            {
                int randomRoom = Random.Range(1, 10);
                if (randomRoom == 1)
                {
                    other.transform.position = new Vector2(teleport1.transform.position.x, teleport1.transform.position.y);
                }
                else if (randomRoom == 2)
                {
                    other.transform.position = new Vector2(teleport2.transform.position.x, teleport2.transform.position.y);
                }
                else if (randomRoom == 3)
                {
                    other.transform.position = new Vector2(teleport3.transform.position.x, teleport3.transform.position.y);
                }
                else if (randomRoom == 4)
                {
                    other.transform.position = new Vector2(teleport4.transform.position.x, teleport4.transform.position.y);
                }
                else if (randomRoom == 5)
                {
                    other.transform.position = new Vector2(teleport5.transform.position.x, teleport5.transform.position.y);
                }
                else if (randomRoom == 6)
                {
                    other.transform.position = new Vector2(teleport6.transform.position.x, teleport6.transform.position.y);
                }
                else if (randomRoom == 7)
                {
                    other.transform.position = new Vector2(teleport7.transform.position.x, teleport7.transform.position.y);
                }
                else if (randomRoom == 8)
                {
                    other.transform.position = new Vector2(teleport8.transform.position.x, teleport8.transform.position.y);
                }
                else if (randomRoom == 9)
                {
                    other.transform.position = new Vector2(teleport9.transform.position.x, teleport9.transform.position.y);
                }
            }
            else
            {
                int randomRoom = Random.Range(1, 9);
                if (randomRoom == 1)
                {
                    other.transform.position = new Vector2(teleport1.transform.position.x, teleport1.transform.position.y);
                }
                else if (randomRoom == 2)
                {
                    other.transform.position = new Vector2(teleport2.transform.position.x, teleport2.transform.position.y);
                }
                else if (randomRoom == 3)
                {
                    other.transform.position = new Vector2(teleport3.transform.position.x, teleport3.transform.position.y);
                }
                else if (randomRoom == 4)
                {
                    other.transform.position = new Vector2(teleport4.transform.position.x, teleport4.transform.position.y);
                }
                else if (randomRoom == 5)
                {
                    other.transform.position = new Vector2(teleport5.transform.position.x, teleport5.transform.position.y);
                }
                else if (randomRoom == 6)
                {
                    other.transform.position = new Vector2(teleport6.transform.position.x, teleport6.transform.position.y);
                }
                else if (randomRoom == 7)
                {
                    other.transform.position = new Vector2(teleport7.transform.position.x, teleport7.transform.position.y);
                }
                else if (randomRoom == 8)
                {
                    other.transform.position = new Vector2(teleport8.transform.position.x, teleport8.transform.position.y);
                }
            }
            if (roomMini)
            {

            }
        }
    }
}
