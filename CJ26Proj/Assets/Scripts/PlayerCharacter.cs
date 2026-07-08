using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterSettings
{
    private Keyboard keyboard;
    [Header ("Settings")]
        //Componenets//
    protected override Rigidbody Rigbod
    {
        get { return Rigbod; }
    }
       //Speed Settings//
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
    protected override float _StandingStill
    {
        get { return 0.0f; }
 
    }
    //State switches//
    protected override bool IsCrouching()
    {
        return false;
    }
    protected override bool IsSprinting()
    {
        return false;
    }
    protected override bool IsStanding()
    {
        return false;
    }
    protected override bool IsWalking()
    {
        return false;
    }
    //end//

}
