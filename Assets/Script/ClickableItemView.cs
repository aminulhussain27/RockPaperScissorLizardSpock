using UnityEngine;
using UnityEngine.UI;
using static PlayerInputManager;

public class ClickableItemView : MonoBehaviour
{
    public ElementType type;
    [SerializeField] public Image itemImage;
    private Color initialColor;
    private void Awake()
    {
        initialColor = itemImage.color;
    }

    void Start()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Button>().onClick.AddListener(() =>
            {
                OnClickItem();
            });
    }

    private void OnClickItem()
    {
        if (PlayerInputManager.Instance.isInputReceived)
            return;
        itemImage.color = Color.green;
        PlayerInputManager.Instance.OnElementSelected.Invoke(type);
    }

    public void ResetItemView()
    {
        itemImage.color = initialColor;
    }
}
