using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDepacker : MonoBehaviour
{
    public Item item;
    private SpriteRenderer spriteRender;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        spriteRender.sprite = item.icon;

        transform.localScale = new Vector3(item.size, item.size, 1f);
         
        Debug.Log(item.itemName);
        Debug.Log(item.itemDescription);
    }

}
