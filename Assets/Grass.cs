using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        Debug.Log("Grass.OnMouseDown");
        if (Item.selection == null)
            return;
        if (Item.selection.plantable == null)
            return;
        
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position = new Vector3(position.x, position.y, 0);
        Instantiate<Flower>(
            Item.selection.plantable, position, Quaternion.identity
        );
        Destroy(Item.selection.gameObject);
    }
}
