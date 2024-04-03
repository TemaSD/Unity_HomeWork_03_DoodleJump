using UnityEngine;

namespace Doodle.Core
{
    public class Player : MonoBehaviour
    {
        [SerializeField] Rigidbody2D _rigidbody;
        [SerializeField] private float _jumpPower;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _castLength;
        
        void Update()
        {
            bool isHit = Physics2D.Raycast(_rigidbody.transform.position, Vector2.down, _castLength);
            Debug.DrawLine(_rigidbody.transform.position, _rigidbody.transform.position + Vector3.down * _castLength, Color.magenta);
            
            var direction = Input.GetAxis("Horizontal");
            
            _rigidbody.velocity = new Vector2(direction * _moveSpeed, _rigidbody.velocity.y);
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
            }
        }
    }

}
