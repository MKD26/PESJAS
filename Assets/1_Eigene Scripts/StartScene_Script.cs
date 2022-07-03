using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene_Script : MonoBehaviour
{

    public GameObject videoPlayer;
    public int timeToStop;



    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }
}
    
