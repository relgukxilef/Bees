using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    Vector3 target;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        target = Flower.flowers[
            Random.Range(0,Flower.flowers.Count)
        ].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target, transform.position) < 0.1f){
            if (Flower.flowers.Count > 0) {
                target = Flower.flowers[
                    Random.Range(0,Flower.flowers.Count)
                ].transform.position;
            }
        }
        transform.position = Vector3.MoveTowards(
            transform.position, target, Time.deltaTime * speed
        );
    }
}
