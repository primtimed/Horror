//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/Input.inputactions
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

public partial class @Input: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""e9f30f75-efb8-4f9a-a3bd-f6699d3bb016"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9d9a6319-54b0-45c9-bc72-d0daa7461a71"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""41fdcc94-e32f-45d2-8c58-d376285f80c0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""1f90e680-9382-4da8-ac88-14b5e3deea4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d4cd4d97-a526-4fee-be96-9a89d49b7514"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""23467d4e-8b74-4535-b83e-8528be7335c8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e02f532a-a3c7-4103-8185-1decb12d7ef7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1309f6cd-5602-44c6-9a47-0d67aa9c6b65"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fae772e0-af19-4f2e-beaf-abfa0c7690e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""881189bd-893c-4e37-8614-99a792ae0378"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a58025dc-be9b-44be-95f8-5600d4d7d32f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c2937b4-11cb-43f4-82bf-2153d33c6090"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a8be330-e45d-40ee-ab6a-57d5f4590ab8"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13ec0a4-144d-41e6-b834-da43e7053840"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ui"",
            ""id"": ""9d6c4793-b1c4-43df-b315-8742f3c58203"",
            ""actions"": [
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""f668174d-9a49-4a7d-8935-2bc08af1bc11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Tab"",
                    ""type"": ""Button"",
                    ""id"": ""23d121a1-8a37-4081-9b44-4ff015db0c22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""0c00d0e3-23aa-49b4-a099-5456d12b3006"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bba80bea-7a68-412a-b24a-8bf6df81d2b5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe735bc9-c48d-4426-95fa-160eadbe2ada"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c21d07a-2aeb-4217-98a6-b798d534acd4"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interect"",
            ""id"": ""278784fb-3b16-432e-8632-bceab24bbb16"",
            ""actions"": [
                {
                    ""name"": ""Interect"",
                    ""type"": ""Button"",
                    ""id"": ""a73b5682-1f42-474d-b960-35005c43aba4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlashLight"",
                    ""type"": ""Button"",
                    ""id"": ""6ae9e620-9378-4500-82fa-b6f91b06ae20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68afd79b-da33-4619-9a5a-bad85524db23"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20a300a7-9b77-40b8-8711-74d01c08f810"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlashLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Rotate = m_Movement.FindAction("Rotate", throwIfNotFound: true);
        m_Movement_Sprint = m_Movement.FindAction("Sprint", throwIfNotFound: true);
        // Ui
        m_Ui = asset.FindActionMap("Ui", throwIfNotFound: true);
        m_Ui_Esc = m_Ui.FindAction("Esc", throwIfNotFound: true);
        m_Ui_Tab = m_Ui.FindAction("Tab", throwIfNotFound: true);
        m_Ui_Map = m_Ui.FindAction("Map", throwIfNotFound: true);
        // Interect
        m_Interect = asset.FindActionMap("Interect", throwIfNotFound: true);
        m_Interect_Interect = m_Interect.FindAction("Interect", throwIfNotFound: true);
        m_Interect_FlashLight = m_Interect.FindAction("FlashLight", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Rotate;
    private readonly InputAction m_Movement_Sprint;
    public struct MovementActions
    {
        private @Input m_Wrapper;
        public MovementActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Rotate => m_Wrapper.m_Movement_Rotate;
        public InputAction @Sprint => m_Wrapper.m_Movement_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Ui
    private readonly InputActionMap m_Ui;
    private List<IUiActions> m_UiActionsCallbackInterfaces = new List<IUiActions>();
    private readonly InputAction m_Ui_Esc;
    private readonly InputAction m_Ui_Tab;
    private readonly InputAction m_Ui_Map;
    public struct UiActions
    {
        private @Input m_Wrapper;
        public UiActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Esc => m_Wrapper.m_Ui_Esc;
        public InputAction @Tab => m_Wrapper.m_Ui_Tab;
        public InputAction @Map => m_Wrapper.m_Ui_Map;
        public InputActionMap Get() { return m_Wrapper.m_Ui; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiActions set) { return set.Get(); }
        public void AddCallbacks(IUiActions instance)
        {
            if (instance == null || m_Wrapper.m_UiActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UiActionsCallbackInterfaces.Add(instance);
            @Esc.started += instance.OnEsc;
            @Esc.performed += instance.OnEsc;
            @Esc.canceled += instance.OnEsc;
            @Tab.started += instance.OnTab;
            @Tab.performed += instance.OnTab;
            @Tab.canceled += instance.OnTab;
            @Map.started += instance.OnMap;
            @Map.performed += instance.OnMap;
            @Map.canceled += instance.OnMap;
        }

        private void UnregisterCallbacks(IUiActions instance)
        {
            @Esc.started -= instance.OnEsc;
            @Esc.performed -= instance.OnEsc;
            @Esc.canceled -= instance.OnEsc;
            @Tab.started -= instance.OnTab;
            @Tab.performed -= instance.OnTab;
            @Tab.canceled -= instance.OnTab;
            @Map.started -= instance.OnMap;
            @Map.performed -= instance.OnMap;
            @Map.canceled -= instance.OnMap;
        }

        public void RemoveCallbacks(IUiActions instance)
        {
            if (m_Wrapper.m_UiActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUiActions instance)
        {
            foreach (var item in m_Wrapper.m_UiActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UiActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UiActions @Ui => new UiActions(this);

    // Interect
    private readonly InputActionMap m_Interect;
    private List<IInterectActions> m_InterectActionsCallbackInterfaces = new List<IInterectActions>();
    private readonly InputAction m_Interect_Interect;
    private readonly InputAction m_Interect_FlashLight;
    public struct InterectActions
    {
        private @Input m_Wrapper;
        public InterectActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interect => m_Wrapper.m_Interect_Interect;
        public InputAction @FlashLight => m_Wrapper.m_Interect_FlashLight;
        public InputActionMap Get() { return m_Wrapper.m_Interect; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InterectActions set) { return set.Get(); }
        public void AddCallbacks(IInterectActions instance)
        {
            if (instance == null || m_Wrapper.m_InterectActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InterectActionsCallbackInterfaces.Add(instance);
            @Interect.started += instance.OnInterect;
            @Interect.performed += instance.OnInterect;
            @Interect.canceled += instance.OnInterect;
            @FlashLight.started += instance.OnFlashLight;
            @FlashLight.performed += instance.OnFlashLight;
            @FlashLight.canceled += instance.OnFlashLight;
        }

        private void UnregisterCallbacks(IInterectActions instance)
        {
            @Interect.started -= instance.OnInterect;
            @Interect.performed -= instance.OnInterect;
            @Interect.canceled -= instance.OnInterect;
            @FlashLight.started -= instance.OnFlashLight;
            @FlashLight.performed -= instance.OnFlashLight;
            @FlashLight.canceled -= instance.OnFlashLight;
        }

        public void RemoveCallbacks(IInterectActions instance)
        {
            if (m_Wrapper.m_InterectActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInterectActions instance)
        {
            foreach (var item in m_Wrapper.m_InterectActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InterectActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InterectActions @Interect => new InterectActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnEsc(InputAction.CallbackContext context);
        void OnTab(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
    }
    public interface IInterectActions
    {
        void OnInterect(InputAction.CallbackContext context);
        void OnFlashLight(InputAction.CallbackContext context);
    }
}
