using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wolf : MonoBehaviour
{
    [Header("Varibles")]
   
    public float biteDamage;
    public Transform[] wayPoints;
    public int wayPointsIndex;
    private Animator wolfAnima;
    private NavMeshAgent wolfAI;
    void Start()
    {
        wolfAnima = GetComponent<Animator>();
        wolfAI = GetComponent<NavMeshAgent>();
        wayPointsIndex = Random.Range(0, wayPoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        wolfAI.destination = wayPoints[wayPointsIndex].position;
        wolfAnima.SetFloat("Speed", wolfAI.speed);
        if(Vector3.Distance(wolfAI.transform.position,wayPoints[wayPointsIndex].position)<2f)
        {
            {
                wayPointsIndex += 1;
                if(wayPointsIndex== wayPoints.Length)
                {
                    wayPointsIndex = 0;
                }
            } }
    }
}
