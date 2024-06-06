using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public static List<Flower> flowers = new List<Flower>();

    public int startDay;
    public int lifeExpectancy;

    // Start is called before the first frame update
    void Start()
    {
        flowers.Add(this);
        startDay = (int)World.day;
    }

    // Update is called once per frame
    void Update()
    {
        if (World.day > startDay + lifeExpectancy) {
            flowers.Remove(this);
            Destroy(gameObject);
        }
    }
}
