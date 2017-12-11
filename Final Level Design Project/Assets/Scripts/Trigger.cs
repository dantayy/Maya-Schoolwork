using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public GameObject obj;
    void OnTriggerEnter(Collider other)
    {
        obj.GetComponent<Animator>().SetBool("Entered", true);
        Debug.Log("Entered Diner");
    }
    void Update()
    {
        AnimatorStateInfo state = obj.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        if (state.IsName("Swing"))
            obj.GetComponent<Animator>().SetBool("Entered", false);
		if (state.IsName ("Idle") ) 
		{
			if(Input.GetKeyDown(KeyCode.E) && obj.GetComponent<Animator>().GetBool("Entered") == true)
				obj.GetComponent<Animator>().SetBool("Triggered", true);
		}
    }

    
}
