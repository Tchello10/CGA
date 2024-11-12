using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private bool canInteract = false;
    [SerializeField] private KeyCode interactKey;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(interactKey) && canInteract)
        {
            gameObject.SetActive(false);
            canInteract = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
    }
}
