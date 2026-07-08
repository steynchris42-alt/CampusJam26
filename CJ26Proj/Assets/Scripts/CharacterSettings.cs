using UnityEngine;

 abstract public class CharacterSettings : MonoBehaviour
   {
             //Components//
    abstract protected Rigidbody Rigbod { get; }
           
            //Speed settings//
   abstract protected float _SprintSpeed { get; }
   abstract protected float _WalkSpeed {  get; }
   abstract protected float _CrouchSpeed {  get; }
   abstract protected float _StandingStill { get; }
    
    //boolean State cheacks//
  abstract protected bool IsSprinting();
  abstract protected bool IsWalking();
  abstract protected bool IsCrouching();
  abstract protected bool IsStanding();
   
  
            

    }
