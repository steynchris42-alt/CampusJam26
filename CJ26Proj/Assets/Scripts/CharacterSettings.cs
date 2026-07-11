using Unity.VisualScripting;
using UnityEngine;

 abstract public class CharacterSettings : MonoBehaviour
   {
    //Components and general assignments//
   private Rigidbody rb;
  protected virtual Rigidbody Rigbod
    {
        get //If the rigidbody is unasigned (defualt) then it is assigned 
        {
            if (rb == null)
            {
                rb = GetComponent<Rigidbody>();
            }
            return rb;
        }
        set //allows the value of the rigidbody to be changed dynamically in inheriting classes
        {
            rb = value;
        }
    }

    //GameObject assignements
    protected Transform tPlayer;
    protected Transform tEnemy;


    protected virtual void Awake()
    {
        CharacterAssignment();
    }
        //Object assignment
    protected void CharacterAssignment()
    {
        //finding by their tags
        GameObject player = GameObject.FindWithTag("Player");
        GameObject enemy = GameObject.FindWithTag("Enemy");
        //assigning them here instead of inspector
        if (player != null || enemy != null)
        {
            tPlayer = player.transform;
            tEnemy = enemy.transform;
        }
    }

    //Speed settings//
    [SerializeField]private float move_speed = 10.0f;
   protected virtual float _MoveSpeed
    {
        get { return move_speed; }
        set { move_speed = value; }
    }

   [SerializeField] private float standing_still = 0.0f;
    protected virtual float _StandingStill
    {
        get { return standing_still; }
        set { standing_still = value; }
    }
   
   /* [SerializeField] protected bool Is_Player_Moving;
    protected virtual bool IsPlayerMove
    {
        get { return Is_Player_Moving; }
        set { Is_Player_Moving = value; }
    } */

    //Physics stuff
    protected virtual Vector3 MoveDir { get; set; }
    protected virtual Vector3 MoveForce { get; set; }


    //boolean State switches//
    abstract protected bool IsMoving();
        
    //movement logic
    abstract protected void Moving();

   
    }
