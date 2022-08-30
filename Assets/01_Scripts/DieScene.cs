using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScene : MonoBehaviour
{
    [SerializeField]
    private GameObject dieScene, StartScene, player, mouse, playScene;
    public void ClickBtn()
    {
        dieScene.SetActive(false);
        playScene.SetActive(true);
        StartScene.SetActive(true);
        mouse.SetActive(false);
        player.SetActive(true);
    }
}
