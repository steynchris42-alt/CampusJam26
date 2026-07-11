using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyCharater : CharacterSettings
{
    private enum EnemyStates
    {
        Patrolling,
        Chasing,
    }
    [SerializeField] private Transform[] tEnemyWayPoints;
    [SerializeField] private Transform tCurrentWayPoint;
    [SerializeField] private int iIndex;
    public  PlayerCharacter playerScr;
    private void Patrolling()
    {
        foreach (Transform t in tEnemyWayPoints)
        {
            float fWaypointEnemy = Vector3.Distance(transform.position, t.position);
            if (fWaypointEnemy < 10.0f)
            {
               tCurrentWayPoint = t;
            }
            iIndex = Array.IndexOf(tEnemyWayPoints, tCurrentWayPoint);
            switch (iIndex)
            {
                case 0: MoveDir = (tEnemyWayPoints[1].position - transform.position  ).normalized; break;
                case 1: MoveDir = (tEnemyWayPoints[2].position - transform.position).normalized; break;
                case 2: MoveDir = (tEnemyWayPoints[3].position - transform.position).normalized; break;
                case 3: MoveDir = (tEnemyWayPoints[4].position - transform.position).normalized; break;
                case 4: MoveDir = (tEnemyWayPoints[5].position - transform.position).normalized; break;
                case 5: MoveDir = (tEnemyWayPoints[0].position - transform.position).normalized; break;

            }

        }
    }
    protected override bool IsMoving()
    {           
            return true;
    }
    protected override void Moving()
    {
       float fPlayerEnemy = Vector3.Distance(transform.position, tPlayer.position);
        if (playerScr.Is_Player_Moving == true)
        {
            if (IsMoving() == true )
            {
                MoveDir = (tPlayer.position - transform.position).normalized;
                Debug.Log("Moving");
            }
        }
        else
        {
            Patrolling();
            Debug.Log("Not Moving");
            ;
            return;
        }
    }
    private void Update()
    {
        Moving();
    }
    public void FixedUpdate()
    {
        MoveForce = MoveDir * _MoveSpeed;
        Rigbod.AddForce(MoveForce, ForceMode.Force);
    }
}
