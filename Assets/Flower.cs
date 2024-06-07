using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour, Beeable
{
    public static List<Flower> flowers = new List<Flower>();
    public Seed seed;

    public int startDay;
    public int lifeExpectancy;
    public float honeyGain;
    public float honeySpeed;
    public float lifeGain;
    public float lifeSpeed;

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
            Instantiate(seed, transform.position, Quaternion.identity);
            if (Bee.target == this)
                Bee.target = null;
            Destroy(gameObject);
        }
    }

    public void OnMouseDown()
    {
        Bee.target = this;
    }

    public void Interact()
    {
        float delta = Mathf.Min(honeyGain, Time.deltaTime * honeySpeed);
        World.honey += delta;
        honeyGain -= delta;
        delta = Mathf.Min(lifeGain, Time.deltaTime * lifeSpeed);
        World.life += delta;
        lifeGain -= delta;
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
