using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bystander : MonoBehaviour
{

    private NavMeshAgent m_NavMeshAgent;
    private int m_CurrentWaypoint;
    private Animator m_Animator;

    [SerializeField] float m_ThresholdDistance;
    [SerializeField] private Transform[] m_Waypoints;


    void Start ()
    {
        m_NavMeshAgent = GetComponent<NavMeshAgent>();
        m_Animator = GetComponent<Animator>();
        m_CurrentWaypoint = 0;

        m_NavMeshAgent.updatePosition = false;
        m_NavMeshAgent.updateRotation = true;
    }
	
	void Update ()
    {
        m_NavMeshAgent.nextPosition = transform.position;

        Patrol();
    }

    void Patrol()
    {
        CheckWaypointDistance();
        m_NavMeshAgent.SetDestination(m_Waypoints[m_CurrentWaypoint].position);
    }

    void CheckWaypointDistance()
    {
        if (Vector3.Distance(m_Waypoints[m_CurrentWaypoint].position, this.transform.position) < m_ThresholdDistance)
        {
            m_CurrentWaypoint = (m_CurrentWaypoint + 1) % m_Waypoints.Length;
        }
    }

}
