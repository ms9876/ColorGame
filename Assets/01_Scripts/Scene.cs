using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField]
    private GameObject currentScene, nextScene ,player, DieScene;
    [SerializeField]
    private GameObject mouse;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Die"))
        {
            currentScene.SetActive(false);
            player.SetActive(false);
            DieScene.SetActive(true);
            mouse.SetActive(true);
        }

        if(collision.collider.CompareTag("Exit"))
        {
            currentScene.SetActive(false);
            nextScene.SetActive(true);
        }
    }
}
