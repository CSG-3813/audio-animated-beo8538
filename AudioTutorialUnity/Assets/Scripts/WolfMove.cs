/***
 * Author: Betzaida Ortiz Rivas
 * Create: 10/31/2022
 * Modified:
 * Description: triggers the wolf animation and sound
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour
{
    public string animationParamater;
    Animator anim;
    AudioSource audioSource;
    AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        clip = audioSource.clip;
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animationParamater, true);
        }
    }
private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animationParamater, false);
        }
    }
    public void playCackle() //using cackle since Howl is not working
    {
        audioSource.PlayOneShot(clip);
    }
}
