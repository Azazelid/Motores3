using UnityEngine;

public class Item : MonoBehaviour, IntInteractuable
{
    public void Interact()
    {
        Debug.Log("Recojiste Item");
        Destroy(gameObject);
    }
}
