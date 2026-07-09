using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterSettings
{
    public Keyboard keyboard;
    [Header("Settings")]
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
        get { return 5.0f; }
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
   protected void Start()
    {
        keyboard = Keyboard.current;
    }
    protected override bool IsMoving()
    {
        if (keyboard == null)
        {
            return false;
        }
         return true;
        
    }     
    //end//
    //MovementLogic
    protected override void Moving()
    {
        if (IsMoving() == true)
        {
            if (keyboard.wKey.isPressed || keyboard.aKey.isPressed || keyboard.sKey.isPressed || keyboard.dKey.isPressed)
            {
                Debug.Log(keyboard.wKey.isPressed + ("W"));
                Debug.Log(keyboard.aKey.isPressed + ("a"));
                Debug.Log(keyboard.sKey.isPressed + ("s")) ;
                Debug.Log(keyboard.dKey.isPressed + ("d")) ;
            }
        }

            Debug.Log("huweh");
    }

    public void Update()
    {
        Moving();
  
    }
    public void FixedUpdate()
    {
        
    }
}
