using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    static public float day = 0f;
    static public int seeds = 0;

    public float dayLength = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / dayLength;
    }
}
