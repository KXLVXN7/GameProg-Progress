using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public GantiScene ga;

        public void playerAttack()
    {
        playerAnimator.SetTrigger("isAyamAttack");
    }

        public void invokeVideo()
    {
        Invoke("playVideo",3.0f);
    }

    public void playVideo()
    {
    rawImageVideo.SetActive(true);
    }

}
