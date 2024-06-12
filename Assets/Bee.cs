using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    static public Beeable target;
    static public Bee selected;
    
    public float speed = 2f;
    public float bobSpeed = 2f;
    public List<Item> inventory = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) {
            if (
                Vector3.Distance(target.GetPosition(), transform.position) < 
                0.1f
            ) {
                target.Interact();
            } else {
                transform.position = Vector3.MoveTowards(
                    transform.position, target.GetPosition(), 
                    speed * Time.deltaTime
                ) + new Vector3(
                    0f, 
                    Mathf.Sin(Time.time * Mathf.PI * bobSpeed) * Time.deltaTime, 
                    0f
                );
                
                GetComponent<SpriteRenderer>().flipX = 
                    target.GetPosition().x > transform.position.x;
            }
        }
    }

    void OnMouseDown()
    {
        if (!selected) {
            selected = this;
        } else {
        }
    }
}
