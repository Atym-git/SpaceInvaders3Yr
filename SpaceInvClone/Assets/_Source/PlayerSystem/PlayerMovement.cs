using UnityEngine;

public class PlayerMovement
{
    private const float SIZE_POSITION_MULTIPLIER = 1.55f;

    public void Move(float verticalMove, Transform playerTransform, float moveSpeed)
    {
        float playerPosX = playerTransform.position.x;
        float visibleXAxis = Camera.main.orthographicSize * SIZE_POSITION_MULTIPLIER;
        //if (Mathf.Abs(posX) <= visibleScreenPanel)
        //{
        //    playerTransform.position += new Vector3(verticalMove, 0f, 0f) * moveSpeed;
        //}
        
        //Mathf.Clamp(playerPos.x, -visibleScreenPanel, visibleScreenPanel);
        
        if (verticalMove > 0
            && playerPosX <= visibleXAxis)
        {
            playerTransform.position += new Vector3(verticalMove, 0f, 0f) * moveSpeed * Time.deltaTime;
        }
        else if (verticalMove < 0
            && playerPosX >= -visibleXAxis)
        {
            playerTransform.position += new Vector3(verticalMove, 0f, 0f) * moveSpeed * Time.deltaTime;
        }
        
    }
}
