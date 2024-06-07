using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour, Beeable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Bee.target = this;
    }

    public void Interact()
    {
        World.seeds += Random.Range(2, 3);
        Destroy(gameObject);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
