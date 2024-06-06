using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = new Color(
            0, 0, 0, Mathf.Cos(World.day * Mathf.PI * 2) * 0.5f + 0.5f
        );
    }
}
