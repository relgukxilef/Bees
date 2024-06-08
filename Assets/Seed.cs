using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : Beeable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        World.seeds += Random.Range(2, 3);
        Destroy(gameObject);
    }

    public override Vector3 GetPosition()
    {
        return transform.position;
    }
}
