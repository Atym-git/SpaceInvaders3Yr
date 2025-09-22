using UnityEngine;

public class PlayerMovement
{
    private const float SIZE_POSITION_MULTIPLIER = 1.55f;

    public void Move(float verticalMove, Transform playerTransform, float moveSpeed)
    {
        float posX = playerTransform.position.x;
        if (Mathf.Abs(posX) <= Camera.main.orthographicSize * SIZE_POSITION_MULTIPLIER)
        {
            posX += verticalMove * moveSpeed;
        }
        
    }
}
