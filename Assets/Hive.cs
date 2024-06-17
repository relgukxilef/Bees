using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hive : Beeable
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact(Bee bee)
    {
        ;
    }

    public override Vector3 GetPosition()
    {
        return transform.position + Vector3.down;
    }
}
