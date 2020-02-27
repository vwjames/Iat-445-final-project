using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioZoneTrigger : MonoBehaviour
{
  void OnTriggerEnter(Collider col){

    if(col.gameObject.tag == "Player"){
GetComponent<AudioSource>().Play();
GetComponent<AudioSource>().loop = true;
    }
  }
  void OnTriggerExit(Collider col){

    if(col.gameObject.tag == "Player"){
GetComponent<AudioSource>().Stop();
GetComponent<AudioSource>().loop = true;
    }
  }

}
