using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    
        void OnCollisionEnter(Collision collisionInfo)
  {
if(collisionInfo.collider.tag=="Obstacle")
{
   movement.enabled=false;
    FindAnyObjectByType<GameManager>().EndGame();
}
  }
   
}
