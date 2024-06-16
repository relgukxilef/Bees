using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : Beeable
{
    public static List<Flower> flowers = new List<Flower>();

    public Sprite[] phases;
    public Item item;

    public float growth;
    public float growthSpeed;
    public int phase;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        flowers.Add(this);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (growth < 2) {
            growth += growthSpeed * Time.deltaTime;
        }
        if (growth < 5) {
            phase = (int)growth;
            spriteRenderer.sprite = phases[phase];
        } else {
            flowers.Remove(this);
            Destroy(gameObject);
        }
    }

    public override void Interact(Bee bee)
    {
        InventorySlot slot = bee.inventory.GetEmptySlot();
        if (phase == 2 && slot) {
            Item newItem = Instantiate(item, slot.transform);
            newItem.transform.parent = slot.transform;
            slot.item = newItem;
            growth = 1;
        }
    }

    public override Vector3 GetPosition()
    {
        return transform.position;
    }
}
