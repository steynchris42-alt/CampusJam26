using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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
    [SerializeField] private float fPlayerEnemy;
    [SerializeField] private float fWaypointEnemy;
    private void Patrolling()
    {

        foreach (Transform t in tEnemyWayPoints)
        {
            Debug.DrawLine(transform.position, t.position, Color.red);
            fWaypointEnemy = Vector3.Distance(transform.position, t.position);
            if (fWaypointEnemy <= 10.0f)
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
        if(playerScr.Is_Player_Moving == true)
        { 
            return true; 
        }
            return false;
    }
    protected override bool IsSprinting()
    {
        if (playerScr.Is_Player_Sprinting == true)
        {
            return true;
        }
        return false;
    }
    protected override void Moving()
    {
        fPlayerEnemy = Vector3.Distance(transform.position, tPlayer.position);

        if (IsSprinting() && fPlayerEnemy <= 1000)
        {
            MoveDir = (tPlayer.position - transform.position).normalized;
        }
        else if (IsMoving() && fPlayerEnemy <= 500)
        {
            MoveDir = (tPlayer.position - transform.position).normalized;
        }
        else
        {
            Patrolling();
            Debug.Log("Not Moving");
            return;
        }

      if (fPlayerEnemy <= 10.0f)
        {
            Die();
        }
       
    }
    protected override void Die()
    {
        SceneManager.LoadScene("StartMenu");
    }
    private void Start()
    {
        GameObject path1 = GameObject.FindWithTag("P1");
        if (path1 != null)
        {
            tCurrentWayPoint = path1.transform;
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
