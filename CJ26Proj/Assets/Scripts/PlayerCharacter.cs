using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterSettings
{
    private Keyboard keyboard;
    //Inhereted atributes//
    protected override Rigidbody Rigbod
    {
        get { return Rigbod; }
    }
    protected override float _SprintSpeed 
    { 
        get { return 10.0f; } 
    }
    protected override float _WalkSpeed
    {
        get { return 5.0f;}
    }
    protected override float _CrouchSpeed
    {
        get { return 2.5f; }
    }
 
    }
    //end//
    protected void SprintingLogic()
{

}
}
