using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _player;
        [SerializeField] private float _jumpPower;
        [SerializeField] private float _moveSpeed;

        private bool _isGrounded;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (_isGrounded)
                {
                    _player.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
                    _isGrounded = false;
                }
            }
        }
            
        private void FixedUpdate()
        {
                var direction = Input.GetAxis("Horizontal");
                _player.velocity = new Vector2(direction * _moveSpeed, _player.velocity.y);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            _isGrounded = true;
        }
    }

}
