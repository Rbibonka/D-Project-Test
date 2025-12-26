using System;
using UnityEngine.InputSystem;

public class PlayerInputListener : IDisposable
{
    public event Action EquipmentChanged;

    private GameInput input;
    private bool disposed;

    public PlayerInputListener()
    {
        input = new GameInput();
        input.Enable();

        input.Player.Equipment.performed += OnEquipmentChanged;
    }

    public void Dispose()
    {
        if (disposed)
        {
            return;
        }

        input.Player.Equipment.performed -= OnEquipmentChanged;

        disposed = true;
    }

    private void OnEquipmentChanged(InputAction.CallbackContext context)
    {
        EquipmentChanged?.Invoke();
    }
}