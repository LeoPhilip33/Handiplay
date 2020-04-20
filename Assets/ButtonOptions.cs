using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOptions : MonoBehaviour
{
    public GameObject OptionsMenu;
    
    public AudioClip impact;
    AudioSource audioSource;
    
    public void ButtonClick()
    {
        OptionsMenu.SetActive(true);
        
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(impact, 0.7F);
    }
}
