//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""f71b4936-d815-407d-9b67-115706f79384"",
            ""actions"": [
                {
                    ""name"": ""H_Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f92252d1-d02c-48d5-a666-8621dc5dcb46"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2c42e26d-8a1a-41b8-be89-e7efb2dd0127"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow_Keys"",
                    ""id"": ""b5c382dd-39f2-482f-8951-9239cc0e25a2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9d84b9e0-c2b1-49a7-89b9-6ce62e105fce"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""67e0fcb5-ebfa-46be-bdba-a11c79970d23"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f7bd07c7-9371-4df8-af97-de155ddf4de5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c11f4d3b-a1cd-4699-b0b1-d9d4a0c9d2d4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e18121a5-6af8-4535-9c20-82799e03dbda"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""H_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9675eab2-5955-4e48-81d2-5eb1d4e0956d"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cd93e81-645b-43f8-8b84-b09ce56870e6"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Top-Down"",
            ""id"": ""c4cf2fd2-eb71-44c7-9c1a-69120d8fc622"",
            ""actions"": [
                {
                    ""name"": ""V_Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f91059e5-6d3f-49bb-8ab7-7c43209f93c4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow_Keys"",
                    ""id"": ""0e9f2809-b982-4ebe-baba-cf6c01959329"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c3c6ff78-8016-4b05-80b0-a2cfe91375e7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4c276c02-8cb3-4297-8837-4d87991a8286"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""faae6fb7-b43e-474d-88fa-5be58c44e158"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""98c68682-5bfd-4f6e-af51-4195e91b48fc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""84885bb9-2124-4493-8f6f-6caf45d18e6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""V_Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Platformer"",
            ""id"": ""5164da10-30db-4d0e-a664-55a060cb2eb8"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6ea1f691-ce8b-444a-afa6-6a06f54824ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ea644ed-0bc4-4ec8-9be7-ed64b8f775c4"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906bbe67-26a3-4c18-8625-838f9a7496c9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_H_Movement = m_Default.FindAction("H_Movement", throwIfNotFound: true);
        m_Default_Attack = m_Default.FindAction("Attack", throwIfNotFound: true);
        // Top-Down
        m_TopDown = asset.FindActionMap("Top-Down", throwIfNotFound: true);
        m_TopDown_V_Movement = m_TopDown.FindAction("V_Movement", throwIfNotFound: true);
        // Platformer
        m_Platformer = asset.FindActionMap("Platformer", throwIfNotFound: true);
        m_Platformer_Jump = m_Platformer.FindAction("Jump", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_H_Movement;
    private readonly InputAction m_Default_Attack;
    public struct DefaultActions
    {
        private @PlayerControls m_Wrapper;
        public DefaultActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @H_Movement => m_Wrapper.m_Default_H_Movement;
        public InputAction @Attack => m_Wrapper.m_Default_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @H_Movement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnH_Movement;
                @H_Movement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnH_Movement;
                @H_Movement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnH_Movement;
                @Attack.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @H_Movement.started += instance.OnH_Movement;
                @H_Movement.performed += instance.OnH_Movement;
                @H_Movement.canceled += instance.OnH_Movement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);

    // Top-Down
    private readonly InputActionMap m_TopDown;
    private ITopDownActions m_TopDownActionsCallbackInterface;
    private readonly InputAction m_TopDown_V_Movement;
    public struct TopDownActions
    {
        private @PlayerControls m_Wrapper;
        public TopDownActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @V_Movement => m_Wrapper.m_TopDown_V_Movement;
        public InputActionMap Get() { return m_Wrapper.m_TopDown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TopDownActions set) { return set.Get(); }
        public void SetCallbacks(ITopDownActions instance)
        {
            if (m_Wrapper.m_TopDownActionsCallbackInterface != null)
            {
                @V_Movement.started -= m_Wrapper.m_TopDownActionsCallbackInterface.OnV_Movement;
                @V_Movement.performed -= m_Wrapper.m_TopDownActionsCallbackInterface.OnV_Movement;
                @V_Movement.canceled -= m_Wrapper.m_TopDownActionsCallbackInterface.OnV_Movement;
            }
            m_Wrapper.m_TopDownActionsCallbackInterface = instance;
            if (instance != null)
            {
                @V_Movement.started += instance.OnV_Movement;
                @V_Movement.performed += instance.OnV_Movement;
                @V_Movement.canceled += instance.OnV_Movement;
            }
        }
    }
    public TopDownActions @TopDown => new TopDownActions(this);

    // Platformer
    private readonly InputActionMap m_Platformer;
    private IPlatformerActions m_PlatformerActionsCallbackInterface;
    private readonly InputAction m_Platformer_Jump;
    public struct PlatformerActions
    {
        private @PlayerControls m_Wrapper;
        public PlatformerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Platformer_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Platformer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlatformerActions set) { return set.Get(); }
        public void SetCallbacks(IPlatformerActions instance)
        {
            if (m_Wrapper.m_PlatformerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlatformerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlatformerActions @Platformer => new PlatformerActions(this);
    public interface IDefaultActions
    {
        void OnH_Movement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface ITopDownActions
    {
        void OnV_Movement(InputAction.CallbackContext context);
    }
    public interface IPlatformerActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}