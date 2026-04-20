using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public IntInteractuable currentInteraction;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteraction!=null)
        {
           currentInteraction.Interact();
           Debug.Log("Test"); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IntInteractuable>() != null)
        {
            Debug.Log("Presiona E para interactuar");
            currentInteraction=other.gameObject.GetComponent<IntInteractuable>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<IntInteractuable>() == currentInteraction)
        {
            Debug.Log("Saliste");
            currentInteraction=null;
        }
    }

}
