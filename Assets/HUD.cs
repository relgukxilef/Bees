using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = 
            "Day " + (int)(World.day + 1) + "\n" +
            "Seeds " + World.seeds + "\n" +
            "Honey " + (int)World.honey + "\n" +
            "Health " + (int)World.life;
    }
}
