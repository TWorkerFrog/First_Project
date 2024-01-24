using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject Player;
    public Image img;

    private void Start()
    {
        img.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Player.transform.position.z <= transform.position.z)
        {
            img.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
