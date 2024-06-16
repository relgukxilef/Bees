using UnityEngine;

public abstract class Beeable : MonoBehaviour
{
    public abstract Vector3 GetPosition();
    public abstract void Interact(Bee bee);
    
    public void OnMouseDown()
    {
        if (Bee.selected != null) {
            Bee.target = this;
            Bee.selected = null;
        }
    }

    public void Destroy()
    {
        if (Bee.target == this) {
            Bee.target = null;
        }
    }
}
