using UnityEngine;
namespace Debugging.Player
{
    [ComponentMenu("RPG/Player/Movement")]
    [RequireComponent((CharacterController))]
    public class movement  
    {
        [Header("Speed Vars")]
        public float moveSpeed;
        public float walkSpeed, runSpeed, crouchSpeed, jumpSpeed;
        private float _gravity = 20.0;
        private Vector3 _moveDir;
        private void Start()
        {

        }
        private void update()
        {
            Move();
        }
        private void Move()
        {
            if (_charC.isGrounded)
            {
                if (Input.GetButton("Sprint")))
                {
                    moveSpeed = runSpeed;
                }
                else if (Input.GetButton("Crouch"))
                {
                    moveSpeed = crouchSpeed;
                }
                else
                {
                    moveSpeed = walkSpeed;
                }
                _moveDir = transform.TransformDirection(new Vector3(Input.GetAxis("Horisontal"), 0, Input.GetAxis("Vertical")) * moveSpeed); 
                if (Input.GetButton("Jump"))
                {
                    _moveDir.y = jumpSpeed
                }
            }
            _moveDir.y -= _gravity * Time.deltaTime;
            _charC.Move(_moveDir * Time.deltaTime);
        }
        }
    }
}
