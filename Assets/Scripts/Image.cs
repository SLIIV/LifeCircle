using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Image : MonoBehaviour
{
    public stage LifeStage;

    public GameObject Sprite;

    public GameObject Text;

    public AudioClip Audio;

    public AudioSource effectManager;

    public void PlayAudio()
    {
        if(Audio != null && effectManager != null)
        {
            effectManager.clip = Audio;
            effectManager.Play();
        }
    }
    public enum stage
    {
        childhood,
        youth,
        adulthood,
        oldness
    }

}
