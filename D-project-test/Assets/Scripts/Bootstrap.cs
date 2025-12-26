using UnityEngine;
using Zenject;

[DefaultExecutionOrder(-1)]
public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private Item[] items;

    [SerializeField]
    private Transform startSpawnPoint;

    [Inject]
    private IPlayer player;

    private void Awake()
    {
        foreach (var item in items)
        {
            item.gameObject.SetActive(false);

            player.AddEquipment(item);
        }

        player.TakeCurrentItem();
        player.SetPosition(startSpawnPoint.position);
    }

    private void OnDestroy()
    {
        player.Dispose();
    }
}