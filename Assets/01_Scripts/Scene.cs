using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField]
    private GameObject player, DieScene;
    [SerializeField]
    private GameObject mouse;
    [SerializeField]
    private GameObject fourth_Scene, five_Scene, six_Scene, seven_Scene, eight_Scene, nine_Scene, ten_Scene, end_Scene, playScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Die")
        {
            playScene.SetActive(false);
            fourth_Scene.SetActive(false);
            five_Scene.SetActive(false);
            six_Scene.SetActive(false);
            seven_Scene.SetActive(false);
            eight_Scene.SetActive(false);
            nine_Scene.SetActive(false);
            ten_Scene.SetActive(false);
            player.SetActive(false);
            DieScene.SetActive(true);
            mouse.SetActive(true);
        }

        if (collision.tag == "Exit")
        {
            fourth_Scene.SetActive(false);
            five_Scene.SetActive(true);
        }

        if(collision.tag == "Exit1")
        {
            five_Scene.SetActive(false);
            six_Scene.SetActive(true);
        }

        if (collision.tag == "Exit2")
        {
            six_Scene.SetActive(false);
            seven_Scene.SetActive(true);
        }

        if (collision.tag == "Exit3")
        {
            seven_Scene.SetActive(false);
            eight_Scene.SetActive(true);
        }

        if (collision.tag == "Exit4")
        {
            eight_Scene.SetActive(false);
            nine_Scene.SetActive(true);
        }

        if (collision.tag == "Exit5")
        {
            nine_Scene.SetActive(false);
            ten_Scene.SetActive(true);
        }

        if (collision.tag == "Exit6")
        {
            ten_Scene.SetActive(false);
            end_Scene.SetActive(true);
            player.SetActive(false);
            mouse.SetActive(true);
        }
    }
}
