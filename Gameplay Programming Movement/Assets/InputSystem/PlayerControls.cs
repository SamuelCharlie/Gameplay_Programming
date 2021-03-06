// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0e26f988-94b4-4f24-a22f-78a891fba0c5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9e5ec323-7726-4596-9630-54fbf6b8bcba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerJump"",
                    ""type"": ""Button"",
                    ""id"": ""03c14ffb-3968-4425-9233-c531e6f5c808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""a83c1037-ce52-4090-8d00-9cd5587bc38e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerAttack"",
                    ""type"": ""Button"",
                    ""id"": ""4f995bee-004a-4a90-840c-1b3d83ba1d0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerInteract"",
                    ""type"": ""Button"",
                    ""id"": ""1ba39dbf-9d84-4ef2-8bab-10b4efc58051"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""04d7b67b-be22-4a49-8640-3ec466360624"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerInventory"",
                    ""type"": ""Button"",
                    ""id"": ""bf37e42a-9605-4368-988e-0832d69f53bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""POVSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""973a76be-d95a-442b-a20a-02d9ed0eaeff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""e6271e94-1eca-4fd4-81f9-6ab7a3831f16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d30d25e1-cec5-4c58-ad60-9fc114f8a814"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""e46a52e8-8024-425b-ad08-9953243ab66a"",
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
                    ""id"": ""f3ae11c5-bda7-4b6f-8cdb-e0d72a9a7ca0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d42862b1-a5f3-4166-af3f-1cffac275168"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24af7af2-2bc5-4904-978d-3a878b17b205"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""91c618d4-4df8-47b3-8aec-7f7d5c5a5964"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f4939c0e-8f6c-48b8-ac70-d277b1aca4be"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlayerJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c22715e-772a-4ec0-812e-b6d9d77e5ccf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41a54ac5-8b09-4643-b579-75618fd0da49"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""243b5f73-4cb4-4b03-b2cf-90e794d3fe32"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlayerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0147d55-a93b-4979-a7e7-6f493eb098e4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlayerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25e937e7-b764-4a22-8aa7-0b1646ac6d66"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlayerInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a95489e6-abe3-4ffe-a5b1-b0b9040223ae"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c0253a8-af43-4981-b476-7fa50191d69d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b267fd36-5255-4863-886f-9093910c5e06"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""POVSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e983f05b-56f1-493e-99d2-fce9299039b6"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""POVSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ebb9431-d618-4d43-9d37-59df47c4a553"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_PlayerJump = m_Player.FindAction("PlayerJump", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_PlayerAttack = m_Player.FindAction("PlayerAttack", throwIfNotFound: true);
        m_Player_PlayerInteract = m_Player.FindAction("PlayerInteract", throwIfNotFound: true);
        m_Player_PauseMenu = m_Player.FindAction("PauseMenu", throwIfNotFound: true);
        m_Player_PlayerInventory = m_Player.FindAction("PlayerInventory", throwIfNotFound: true);
        m_Player_POVSwitch = m_Player.FindAction("POVSwitch", throwIfNotFound: true);
        m_Player_LockOn = m_Player.FindAction("LockOn", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_PlayerJump;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_PlayerAttack;
    private readonly InputAction m_Player_PlayerInteract;
    private readonly InputAction m_Player_PauseMenu;
    private readonly InputAction m_Player_PlayerInventory;
    private readonly InputAction m_Player_POVSwitch;
    private readonly InputAction m_Player_LockOn;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @PlayerJump => m_Wrapper.m_Player_PlayerJump;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @PlayerAttack => m_Wrapper.m_Player_PlayerAttack;
        public InputAction @PlayerInteract => m_Wrapper.m_Player_PlayerInteract;
        public InputAction @PauseMenu => m_Wrapper.m_Player_PauseMenu;
        public InputAction @PlayerInventory => m_Wrapper.m_Player_PlayerInventory;
        public InputAction @POVSwitch => m_Wrapper.m_Player_POVSwitch;
        public InputAction @LockOn => m_Wrapper.m_Player_LockOn;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @PlayerJump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
                @PlayerJump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
                @PlayerJump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @PlayerAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerAttack;
                @PlayerAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerAttack;
                @PlayerAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerAttack;
                @PlayerInteract.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInteract;
                @PlayerInteract.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInteract;
                @PlayerInteract.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInteract;
                @PauseMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PlayerInventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInventory;
                @PlayerInventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInventory;
                @PlayerInventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerInventory;
                @POVSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOVSwitch;
                @POVSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOVSwitch;
                @POVSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOVSwitch;
                @LockOn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLockOn;
                @LockOn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLockOn;
                @LockOn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLockOn;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @PlayerJump.started += instance.OnPlayerJump;
                @PlayerJump.performed += instance.OnPlayerJump;
                @PlayerJump.canceled += instance.OnPlayerJump;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @PlayerAttack.started += instance.OnPlayerAttack;
                @PlayerAttack.performed += instance.OnPlayerAttack;
                @PlayerAttack.canceled += instance.OnPlayerAttack;
                @PlayerInteract.started += instance.OnPlayerInteract;
                @PlayerInteract.performed += instance.OnPlayerInteract;
                @PlayerInteract.canceled += instance.OnPlayerInteract;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @PlayerInventory.started += instance.OnPlayerInventory;
                @PlayerInventory.performed += instance.OnPlayerInventory;
                @PlayerInventory.canceled += instance.OnPlayerInventory;
                @POVSwitch.started += instance.OnPOVSwitch;
                @POVSwitch.performed += instance.OnPOVSwitch;
                @POVSwitch.canceled += instance.OnPOVSwitch;
                @LockOn.started += instance.OnLockOn;
                @LockOn.performed += instance.OnLockOn;
                @LockOn.canceled += instance.OnLockOn;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPlayerJump(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnPlayerAttack(InputAction.CallbackContext context);
        void OnPlayerInteract(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnPlayerInventory(InputAction.CallbackContext context);
        void OnPOVSwitch(InputAction.CallbackContext context);
        void OnLockOn(InputAction.CallbackContext context);
    }
}
