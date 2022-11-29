using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMode : MonoBehaviour
{
    public static bool isHard = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnableHardMode()
    {
        isHard = true;
        Debug.Log("Hard Mode Active");
    }
    public void DisableHardMode()
    {
        isHard = false;
        Debug.Log("Hard Mode Disabled");
    }
}
