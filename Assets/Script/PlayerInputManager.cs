using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance;

    public Action<ElementType> OnElementSelected;

    public bool isInputReceived;
    private List<ClickableItemView> clickableItems;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        OnElementSelected += OnInputReceived;
    }

    private void OnInputReceived(ElementType type)
    {
        Debug.Log("Input rcv: " + type);
    }

    private void ResetAllItem()
    {
        foreach (var item in clickableItems)
        {
            item.ResetItemView();
        }
    }

    public enum ElementType
    {
        Rock = 1,
        Paper = 2,
        Scissor = 3,
        Lizard = 4,
        Spock = 5,
    }
}
