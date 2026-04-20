using UnityEngine;

public class Door : MonoBehaviour, IntInteractuable
{
    public void Interact()
    {
        Debug.Log("ABRIR PUERTA");
        transform.position=new Vector3(transform.position.x+2,transform.position.y,transform.position.z);
    }
}
