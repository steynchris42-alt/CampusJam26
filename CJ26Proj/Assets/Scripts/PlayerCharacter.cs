using UnityEngine;

public class PlayerCharacter : CharacterSettings
{
    protected override Rigidbody Rigbod
    {
        get { return Rigbod; }
    }
    protected override float _MoveSpeed 
    { 
        
        get { return _MoveSpeed; } 
    }
    protected override float _MoveSpeed_Inc1
    {
        get { return _MoveSpeed_Inc1;}
    }

    protected override float _MoveSpeed_Inc2
    {
        get { return _MoveSpeed_Inc2; }
    }

}
