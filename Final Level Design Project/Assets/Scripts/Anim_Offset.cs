using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Offset : MonoBehaviour {

    public string animStateName = "Take 001";

    private void Start()
    {
        float frameNumber = Random.Range(1f, 90f);
        gameObject.GetComponent<Animator>().Play(animStateName, 0, (1f / 60f) * frameNumber);
    }
}
