using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyCharater : CharacterSettings
{
    protected override bool IsMoving()
    {           
            return true;
    }
    protected override void Moving()
    {
       float fPlayerEnemy = Vector3.Distance(transform.position, tPlayer.position);
        if (IsMoving() == true && fPlayerEnemy < 50.0f)
        {
            MoveDir = (tPlayer.position - transform.position  ).normalized;
        }
        else
        {
            MoveDir = Vector3.zero;
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
