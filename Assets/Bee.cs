using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    static public Beeable target;
    public float speed = 2f;

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
                );
            }
        }
    }
}
