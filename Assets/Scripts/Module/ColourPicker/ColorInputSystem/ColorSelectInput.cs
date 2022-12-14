//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Module/ColourPicker/ColorInputSystem/ColorSelectInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ColorSelectInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ColorSelectInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ColorSelectInput"",
    ""maps"": [
        {
            ""name"": ""SelectColorKeyboardLeft"",
            ""id"": ""fa7a9edc-f728-4694-b5ba-17b65c8b5908"",
            ""actions"": [
                {
                    ""name"": ""Prev"",
                    ""type"": ""Button"",
                    ""id"": ""414b235a-5204-4f4c-ab30-0cb663c7534e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""218cfab7-adda-4026-92ab-a8c4a6065632"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""5adf8bbb-5fc5-45bb-82e6-7b38e50a6315"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""b206df38-b770-45dc-b103-7bccfc55e533"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7bdc9e11-98df-43e6-a815-667b396a1177"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""652dccd8-5f0d-42fa-81c2-bb3ec1bba509"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prev"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9f37679-9ad2-4734-b94a-3c58f72b0a1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8a851f1-6f1a-4579-9f46-091d63c6ab0c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SelectColorKeyboardRight"",
            ""id"": ""661d3610-af27-4430-a0d6-a9f9c0087abd"",
            ""actions"": [
                {
                    ""name"": ""Prev"",
                    ""type"": ""Button"",
                    ""id"": ""6da51e5d-6e0c-47fd-8631-3df4519376e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""efca1064-e0e7-46a1-8694-3ee67330e7ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""4cec401f-e486-4f8e-91e6-773bb32b74a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""ee2cff8f-a9a0-464c-b607-f0ae664738ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0fc73491-f70f-49cc-b890-ee9d8316fc11"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcd80b5f-33c9-4402-bd86-011e2b33e1b8"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prev"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c27f1c1-6c80-4a21-a076-3c7ab9521946"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7df18afe-3a13-4216-99a2-6f65f60c23d8"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SelectColorKeyboardGamepad"",
            ""id"": ""f6bf293e-d25d-44b9-8d55-c7dda722d1b3"",
            ""actions"": [
                {
                    ""name"": ""Prev"",
                    ""type"": ""Button"",
                    ""id"": ""3f4cfe5a-3f70-465e-88be-875535629ae3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""524dab3b-336d-4b12-b1ba-2ba83e60c485"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""c0805d74-baea-4d80-a7c1-06120b3aca32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""05b9e225-cc5c-4f87-9bbf-dfd9b3ca9e40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8d5f1452-4931-412a-ae76-019da6e6df09"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d04abc6e-e2cf-4501-a26e-a7a8a8ac2e58"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prev"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cd1bedb-20c1-4229-ae5f-42fb7f520b41"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75736748-dcd6-4bff-807b-93b45cc2f8ee"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SelectColorKeyboardLeft
        m_SelectColorKeyboardLeft = asset.FindActionMap("SelectColorKeyboardLeft", throwIfNotFound: true);
        m_SelectColorKeyboardLeft_Prev = m_SelectColorKeyboardLeft.FindAction("Prev", throwIfNotFound: true);
        m_SelectColorKeyboardLeft_Next = m_SelectColorKeyboardLeft.FindAction("Next", throwIfNotFound: true);
        m_SelectColorKeyboardLeft_Confirm = m_SelectColorKeyboardLeft.FindAction("Confirm", throwIfNotFound: true);
        m_SelectColorKeyboardLeft_Cancel = m_SelectColorKeyboardLeft.FindAction("Cancel", throwIfNotFound: true);
        // SelectColorKeyboardRight
        m_SelectColorKeyboardRight = asset.FindActionMap("SelectColorKeyboardRight", throwIfNotFound: true);
        m_SelectColorKeyboardRight_Prev = m_SelectColorKeyboardRight.FindAction("Prev", throwIfNotFound: true);
        m_SelectColorKeyboardRight_Next = m_SelectColorKeyboardRight.FindAction("Next", throwIfNotFound: true);
        m_SelectColorKeyboardRight_Confirm = m_SelectColorKeyboardRight.FindAction("Confirm", throwIfNotFound: true);
        m_SelectColorKeyboardRight_Cancel = m_SelectColorKeyboardRight.FindAction("Cancel", throwIfNotFound: true);
        // SelectColorKeyboardGamepad
        m_SelectColorKeyboardGamepad = asset.FindActionMap("SelectColorKeyboardGamepad", throwIfNotFound: true);
        m_SelectColorKeyboardGamepad_Prev = m_SelectColorKeyboardGamepad.FindAction("Prev", throwIfNotFound: true);
        m_SelectColorKeyboardGamepad_Next = m_SelectColorKeyboardGamepad.FindAction("Next", throwIfNotFound: true);
        m_SelectColorKeyboardGamepad_Confirm = m_SelectColorKeyboardGamepad.FindAction("Confirm", throwIfNotFound: true);
        m_SelectColorKeyboardGamepad_Cancel = m_SelectColorKeyboardGamepad.FindAction("Cancel", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // SelectColorKeyboardLeft
    private readonly InputActionMap m_SelectColorKeyboardLeft;
    private ISelectColorKeyboardLeftActions m_SelectColorKeyboardLeftActionsCallbackInterface;
    private readonly InputAction m_SelectColorKeyboardLeft_Prev;
    private readonly InputAction m_SelectColorKeyboardLeft_Next;
    private readonly InputAction m_SelectColorKeyboardLeft_Confirm;
    private readonly InputAction m_SelectColorKeyboardLeft_Cancel;
    public struct SelectColorKeyboardLeftActions
    {
        private @ColorSelectInput m_Wrapper;
        public SelectColorKeyboardLeftActions(@ColorSelectInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Prev => m_Wrapper.m_SelectColorKeyboardLeft_Prev;
        public InputAction @Next => m_Wrapper.m_SelectColorKeyboardLeft_Next;
        public InputAction @Confirm => m_Wrapper.m_SelectColorKeyboardLeft_Confirm;
        public InputAction @Cancel => m_Wrapper.m_SelectColorKeyboardLeft_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_SelectColorKeyboardLeft; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectColorKeyboardLeftActions set) { return set.Get(); }
        public void SetCallbacks(ISelectColorKeyboardLeftActions instance)
        {
            if (m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface != null)
            {
                @Prev.started -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnPrev;
                @Prev.performed -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnPrev;
                @Prev.canceled -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnPrev;
                @Next.started -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnNext;
                @Confirm.started -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_SelectColorKeyboardLeftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Prev.started += instance.OnPrev;
                @Prev.performed += instance.OnPrev;
                @Prev.canceled += instance.OnPrev;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public SelectColorKeyboardLeftActions @SelectColorKeyboardLeft => new SelectColorKeyboardLeftActions(this);

    // SelectColorKeyboardRight
    private readonly InputActionMap m_SelectColorKeyboardRight;
    private ISelectColorKeyboardRightActions m_SelectColorKeyboardRightActionsCallbackInterface;
    private readonly InputAction m_SelectColorKeyboardRight_Prev;
    private readonly InputAction m_SelectColorKeyboardRight_Next;
    private readonly InputAction m_SelectColorKeyboardRight_Confirm;
    private readonly InputAction m_SelectColorKeyboardRight_Cancel;
    public struct SelectColorKeyboardRightActions
    {
        private @ColorSelectInput m_Wrapper;
        public SelectColorKeyboardRightActions(@ColorSelectInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Prev => m_Wrapper.m_SelectColorKeyboardRight_Prev;
        public InputAction @Next => m_Wrapper.m_SelectColorKeyboardRight_Next;
        public InputAction @Confirm => m_Wrapper.m_SelectColorKeyboardRight_Confirm;
        public InputAction @Cancel => m_Wrapper.m_SelectColorKeyboardRight_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_SelectColorKeyboardRight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectColorKeyboardRightActions set) { return set.Get(); }
        public void SetCallbacks(ISelectColorKeyboardRightActions instance)
        {
            if (m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface != null)
            {
                @Prev.started -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnPrev;
                @Prev.performed -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnPrev;
                @Prev.canceled -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnPrev;
                @Next.started -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnNext;
                @Confirm.started -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_SelectColorKeyboardRightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Prev.started += instance.OnPrev;
                @Prev.performed += instance.OnPrev;
                @Prev.canceled += instance.OnPrev;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public SelectColorKeyboardRightActions @SelectColorKeyboardRight => new SelectColorKeyboardRightActions(this);

    // SelectColorKeyboardGamepad
    private readonly InputActionMap m_SelectColorKeyboardGamepad;
    private ISelectColorKeyboardGamepadActions m_SelectColorKeyboardGamepadActionsCallbackInterface;
    private readonly InputAction m_SelectColorKeyboardGamepad_Prev;
    private readonly InputAction m_SelectColorKeyboardGamepad_Next;
    private readonly InputAction m_SelectColorKeyboardGamepad_Confirm;
    private readonly InputAction m_SelectColorKeyboardGamepad_Cancel;
    public struct SelectColorKeyboardGamepadActions
    {
        private @ColorSelectInput m_Wrapper;
        public SelectColorKeyboardGamepadActions(@ColorSelectInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Prev => m_Wrapper.m_SelectColorKeyboardGamepad_Prev;
        public InputAction @Next => m_Wrapper.m_SelectColorKeyboardGamepad_Next;
        public InputAction @Confirm => m_Wrapper.m_SelectColorKeyboardGamepad_Confirm;
        public InputAction @Cancel => m_Wrapper.m_SelectColorKeyboardGamepad_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_SelectColorKeyboardGamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectColorKeyboardGamepadActions set) { return set.Get(); }
        public void SetCallbacks(ISelectColorKeyboardGamepadActions instance)
        {
            if (m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface != null)
            {
                @Prev.started -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnPrev;
                @Prev.performed -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnPrev;
                @Prev.canceled -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnPrev;
                @Next.started -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnNext;
                @Confirm.started -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_SelectColorKeyboardGamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Prev.started += instance.OnPrev;
                @Prev.performed += instance.OnPrev;
                @Prev.canceled += instance.OnPrev;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public SelectColorKeyboardGamepadActions @SelectColorKeyboardGamepad => new SelectColorKeyboardGamepadActions(this);
    public interface ISelectColorKeyboardLeftActions
    {
        void OnPrev(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface ISelectColorKeyboardRightActions
    {
        void OnPrev(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface ISelectColorKeyboardGamepadActions
    {
        void OnPrev(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
