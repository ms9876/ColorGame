using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScene : MonoBehaviour
{
    [SerializeField]
    private GameObject dieScene, StartScene, player, mouse;
    public void ClickBtn()
    {
        dieScene.SetActive(false);
        StartScene.SetActive(true);
        mouse.SetActive(false);
        player.SetActive(true);
    }
}
