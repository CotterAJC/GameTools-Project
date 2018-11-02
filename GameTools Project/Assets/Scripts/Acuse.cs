using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acuse : MonoBehaviour {

    private bool acuse;
    private Animator animator;



    void Start ()
    {
        animator = GetComponent<Animator>();
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Acuse Zone")
        {
            acuse = Input.GetKeyDown(KeyCode.Q);
        }
    }

    void Update ()
    {
        if (acuse)
        {
            animator.SetTrigger("Acuse");
        }
    }
}
