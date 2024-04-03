using System;
using UnityEngine;

namespace Platform
{
    public class PlatformColor : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _platformColor;

        private void OnTriggerEnter2D(Collider2D other)
        {
            _platformColor.color = Color.yellow;
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            _platformColor.color = Color.white;
        }
        
    }
}
