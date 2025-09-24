using UnityEngine;

public class Invoker
{
    private PlayerMovement _playerMovement;
    private PlayerData _playerData;
    private PlayerCombat _playerCombat;

    public Invoker(PlayerMovement playerMovement, PlayerData playerData, PlayerCombat playerCombat)
    {
        _playerMovement = playerMovement;
        _playerData = playerData;
        _playerCombat = playerCombat;
    }

    public void InvokeMove(float verticalMove)
    {
        _playerMovement.Move(verticalMove, _playerData.PlayerTransform, _playerData.PlayerMoveSpeed);
    }

    public void InvokeShoot()
    {
        _playerCombat.Shoot(_playerData.BulletPrefab,
                            _playerData.BulletSpeed,
                            _playerData.BulletRoot,
                            _playerData.BulletLifeTime,
                            _playerData.EnemyLayer);
    }
}
