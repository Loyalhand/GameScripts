using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SignUI : MonoBehaviour
{
    public Sign sign;
    public Canvas textPanel;
    public TextMeshProUGUI description;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        textPanel.enabled = false;

        description.text = sign.description;
        
        //description.transform.position = new Vector3(-240f, -200f, 0f);
    }

    // enable textPanel if in range 
    void OnTriggerEnter2D(Collider2D col)
    {
            textPanel.enabled = true;  
    }



    // disable panel 
    private void Update()
    {
        if (Input.GetKey("e") && textPanel.enabled == true)
        {
            Debug.Log("e");
            textPanel.enabled = false;
        }
        if (player.transform.position.y > transform.position.y)
        {
            textPanel.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        textPanel.enabled = false;
    }
}
