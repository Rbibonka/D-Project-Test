using DG.Tweening;
using UnityEngine;

public class ItemView : IViewable
{
    private Transform transform;

    private readonly Vector3 ActiveSize = Vector3.one;
    private readonly Vector3 DeactiveSize = Vector3.zero;

    private const float DurationTime = 0.2f;

    public ItemView(Transform transform)
    {
        this.transform = transform;
    }

    public void HideImmediately()
    {
        transform.localScale = DeactiveSize;
        transform.gameObject.SetActive(false);
    }

    public void Hide()
    {
        transform.localScale = ActiveSize;
        transform.DOScale(DeactiveSize, DurationTime).SetEase(Ease.OutCirc)
            .OnComplete(() =>
            {
                transform.gameObject.SetActive(false);
            });
    }

    public void Show()
    {
        transform.localScale = DeactiveSize;
        transform.gameObject.SetActive(true);
        transform.DOScale(ActiveSize, DurationTime).SetEase(Ease.OutCirc);
    }
}