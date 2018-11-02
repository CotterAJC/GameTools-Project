using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoCapMan : MonoBehaviour {

    private Animator animator;
    private bool examined_here;

    private bool m_enableIK;
    private float m_weightIK;
    private Vector3 m_positionIK;


    void Start ()
    {
        animator = GetComponent<Animator>();
	}

    public void Move(float turn, float move, bool examined, bool acuse, bool fall)
    {
        animator.SetFloat("Turn", turn);
        animator.SetFloat("Forward", move);

        examined_here = examined;
        if(fall)
        {
            animator.SetTrigger("Fall");
            fall = false;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Evidence")
        {
            var Evidence = other.GetComponent<Evidence>();


            if (examined_here && Evidence != null && !Evidence.examined)
            {
                Transform rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
                Evidence.BeExamined(rightHand);

                animator.SetTrigger("Examine");
            }
        }
    }
}
