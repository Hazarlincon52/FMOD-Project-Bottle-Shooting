using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_FMOD : MonoBehaviour
{

    [SerializeField] private EventReference click;

    //Gun
    [SerializeField] private EventReference shootSound;
    [SerializeField] private EventReference outOfBullets;
    [SerializeField] private EventReference reload;

    //private FMOD.Studio.EventInstance shoot;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    public void ClickSFX()
    {
        RuntimeManager.PlayOneShot(click);
    }

    public void ShootSound()
    {
        RuntimeManager.PlayOneShot(shootSound);
    }

    public void OutOfBulletsSound()
    {
        RuntimeManager.PlayOneShot(outOfBullets);
    }

    public void ReloadSound()
    {
        RuntimeManager.PlayOneShot(reload);
    }


}
