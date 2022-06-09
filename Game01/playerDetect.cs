using UnityEngine;

public class playerDetect : MonoBehaviour
{

    public string interactable;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sign") {
            interactable = "Sign";
        }
        else if (other.gameObject.tag == "Collectible") {
            interactable = "Collectible";
        }
        else if (other.gameObject.tag == "Fountain") {
            interactable = "Fountain";
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        interactable = "null";
    }


}
