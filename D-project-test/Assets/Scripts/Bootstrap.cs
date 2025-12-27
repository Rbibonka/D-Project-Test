using UnityEngine;
using Zenject;

[DefaultExecutionOrder(-1)]
public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private Transform startSpawnPoint;

    [SerializeField]
    private PlayerInfoController playerInfoController;

    [Inject]
    private IPlayer player;

    [Inject]
    private IPlayerInfo playerInfo;

    [Inject]
    private IItemsCreator itemsCreator;

    private void Awake()
    {
        player.AddEquipment(itemsCreator.CreateWeapon());
        player.AddEquipment(itemsCreator.CreateParachute());
        player.AddEquipment(itemsCreator.CreateJatPack());

        player.SetPosition(startSpawnPoint.position);

        playerInfoController.Initialize(playerInfo.Nickname, playerInfo.Health);
    }

    private void OnDestroy()
    {
        player.Dispose();
    }
}