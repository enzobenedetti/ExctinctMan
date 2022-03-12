// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""08d54505-8e87-4a15-ad39-2df00d981296"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5bee5430-7db0-455e-8fc9-67f2d625bfc3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spray"",
                    ""type"": ""Button"",
                    ""id"": ""0bbe202d-535a-441b-b57f-a1897b48a902"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""94898794-5da5-4852-90ee-cd2cc9e6e5dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""21591d8c-c0ef-4d08-892a-f4a62d5ccd51"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b4a683ec-ca13-47fc-a613-f9b6bb8028fc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d82d9f9-780c-4259-97a4-39beee956435"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Letters"",
                    ""id"": ""dde0c2f2-2ea0-4089-9345-f7222b4ab17f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7fa0183c-a122-40fa-b48f-986113e20609"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9b6d4531-cc2a-4355-abf0-e7fbeb54bc96"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c07cbbcd-32b5-4e21-ab45-96fffe366cfd"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ee1b07c-0bfb-4106-879c-56dca5bd94aa"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""015ec4fd-f0e7-4c3c-be76-16c6df69f164"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Spray"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1293446-12b4-451e-ac98-9ea0a4914387"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""175e3cc3-22d3-425c-9f4a-ec86a90d11ad"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e33fb5cc-51ec-4492-9a89-cd2067d60e4f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Spray"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Input"",
            ""bindingGroup"": ""Input"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
        m_Character_Spray = m_Character.FindAction("Spray", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    private readonly InputAction m_Character_Spray;
    private readonly InputAction m_Character_Jump;
    public struct CharacterActions
    {
        private @InputMaster m_Wrapper;
        public CharacterActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @Spray => m_Wrapper.m_Character_Spray;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Spray.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSpray;
                @Spray.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSpray;
                @Spray.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSpray;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Spray.started += instance.OnSpray;
                @Spray.performed += instance.OnSpray;
                @Spray.canceled += instance.OnSpray;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    private int m_InputSchemeIndex = -1;
    public InputControlScheme InputScheme
    {
        get
        {
            if (m_InputSchemeIndex == -1) m_InputSchemeIndex = asset.FindControlSchemeIndex("Input");
            return asset.controlSchemes[m_InputSchemeIndex];
        }
    }
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSpray(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
