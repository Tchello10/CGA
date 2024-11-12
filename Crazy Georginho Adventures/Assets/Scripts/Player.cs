using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int health = 3;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            //TODO load menu/death screen
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health = 0;
        }
    }
}
