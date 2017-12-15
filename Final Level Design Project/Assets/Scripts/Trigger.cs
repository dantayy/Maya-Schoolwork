using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public GameObject obj;
	private bool playedMusic = false;

    void OnTriggerEnter(Collider other)
    {
        obj.GetComponent<Animator>().SetBool("Entered", true);
        //Debug.Log("Entered Diner");
    }
	void OnTriggerExit(Collider other)
	{
		obj.GetComponent<Animator>().SetBool("Entered", false);
        if(gameObject.tag == "Bell")
        {
            AudioSource source = gameObject.GetComponent<AudioSource>();
            source.Play();
        }   
	}
    void Update()
    {
        AnimatorStateInfo state = obj.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        if (state.IsName("Swing"))
            obj.GetComponent<Animator>().SetBool("Entered", false);
		if (state.IsName ("Idle") ) 
		{
			if (Input.GetKeyDown (KeyCode.E) && obj.GetComponent<Animator> ().GetBool ("Entered") == true) {
				obj.GetComponent<Animator> ().SetBool ("Triggered", true);
				// for jukebox playing music
			}
		}

		if(obj.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Take 001") && obj.name == "jukebox_anim" && !playedMusic)
		{
			AudioSource audio = obj.GetComponent<AudioSource> ();
			audio.Play (430000);

			playedMusic = true;
		}


    }

    
}
