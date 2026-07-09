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
    
         //boolean State switches//
   
  abstract protected bool IsMoving();
  

    //movement logic
    abstract protected void Moving();

   
    }
