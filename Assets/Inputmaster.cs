//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Inputmaster.inputactions
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

public partial class @Inputmaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputmaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputmaster"",
    ""maps"": [
        {
            ""name"": ""Music"",
            ""id"": ""1ad6b040-fb73-4980-aaef-51f0319d8bb9"",
            ""actions"": [
                {
                    ""name"": ""addbeat_Ljab"",
                    ""type"": ""Button"",
                    ""id"": ""6e7bf865-d302-448f-8057-17f66282c345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""addbeat_Lhook"",
                    ""type"": ""Button"",
                    ""id"": ""ff22425b-ccad-4b7b-9a9d-0a2b91c9149d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""addbeat_Luppercut"",
                    ""type"": ""Button"",
                    ""id"": ""a826482e-9bd3-4ca7-b71e-a1d23d96eaff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""addbeat_Rjab"",
                    ""type"": ""Button"",
                    ""id"": ""08581832-2afd-4deb-a464-5b9839ff1689"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""addbeat_Rhook"",
                    ""type"": ""Button"",
                    ""id"": ""b7b180ed-a6bd-4057-aaa4-419bc2b7ca13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""addbeat_Ruppercut"",
                    ""type"": ""Button"",
                    ""id"": ""7c9e00e9-3e11-4a25-af57-8e2dddda8b30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d2389ebc-c5a5-469b-b4b9-bc561ea26d44"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Ljab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a819e43-b7dc-406b-9bbc-96f06f28a569"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Lhook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55d33c42-8599-44fd-a977-85a0f770df70"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Luppercut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfeda959-d79f-4a0b-9d43-7849e441d75d"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Rjab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52aa37f7-a1c8-406e-9b36-6ceb670ef2ba"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Rhook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1981178-8e6e-4b05-9cca-27aaca42a7fc"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""addbeat_Ruppercut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Music
        m_Music = asset.FindActionMap("Music", throwIfNotFound: true);
        m_Music_addbeat_Ljab = m_Music.FindAction("addbeat_Ljab", throwIfNotFound: true);
        m_Music_addbeat_Lhook = m_Music.FindAction("addbeat_Lhook", throwIfNotFound: true);
        m_Music_addbeat_Luppercut = m_Music.FindAction("addbeat_Luppercut", throwIfNotFound: true);
        m_Music_addbeat_Rjab = m_Music.FindAction("addbeat_Rjab", throwIfNotFound: true);
        m_Music_addbeat_Rhook = m_Music.FindAction("addbeat_Rhook", throwIfNotFound: true);
        m_Music_addbeat_Ruppercut = m_Music.FindAction("addbeat_Ruppercut", throwIfNotFound: true);
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

    // Music
    private readonly InputActionMap m_Music;
    private IMusicActions m_MusicActionsCallbackInterface;
    private readonly InputAction m_Music_addbeat_Ljab;
    private readonly InputAction m_Music_addbeat_Lhook;
    private readonly InputAction m_Music_addbeat_Luppercut;
    private readonly InputAction m_Music_addbeat_Rjab;
    private readonly InputAction m_Music_addbeat_Rhook;
    private readonly InputAction m_Music_addbeat_Ruppercut;
    public struct MusicActions
    {
        private @Inputmaster m_Wrapper;
        public MusicActions(@Inputmaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @addbeat_Ljab => m_Wrapper.m_Music_addbeat_Ljab;
        public InputAction @addbeat_Lhook => m_Wrapper.m_Music_addbeat_Lhook;
        public InputAction @addbeat_Luppercut => m_Wrapper.m_Music_addbeat_Luppercut;
        public InputAction @addbeat_Rjab => m_Wrapper.m_Music_addbeat_Rjab;
        public InputAction @addbeat_Rhook => m_Wrapper.m_Music_addbeat_Rhook;
        public InputAction @addbeat_Ruppercut => m_Wrapper.m_Music_addbeat_Ruppercut;
        public InputActionMap Get() { return m_Wrapper.m_Music; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MusicActions set) { return set.Get(); }
        public void SetCallbacks(IMusicActions instance)
        {
            if (m_Wrapper.m_MusicActionsCallbackInterface != null)
            {
                @addbeat_Ljab.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ljab;
                @addbeat_Ljab.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ljab;
                @addbeat_Ljab.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ljab;
                @addbeat_Lhook.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Lhook;
                @addbeat_Lhook.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Lhook;
                @addbeat_Lhook.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Lhook;
                @addbeat_Luppercut.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Luppercut;
                @addbeat_Luppercut.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Luppercut;
                @addbeat_Luppercut.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Luppercut;
                @addbeat_Rjab.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rjab;
                @addbeat_Rjab.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rjab;
                @addbeat_Rjab.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rjab;
                @addbeat_Rhook.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rhook;
                @addbeat_Rhook.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rhook;
                @addbeat_Rhook.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Rhook;
                @addbeat_Ruppercut.started -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ruppercut;
                @addbeat_Ruppercut.performed -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ruppercut;
                @addbeat_Ruppercut.canceled -= m_Wrapper.m_MusicActionsCallbackInterface.OnAddbeat_Ruppercut;
            }
            m_Wrapper.m_MusicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @addbeat_Ljab.started += instance.OnAddbeat_Ljab;
                @addbeat_Ljab.performed += instance.OnAddbeat_Ljab;
                @addbeat_Ljab.canceled += instance.OnAddbeat_Ljab;
                @addbeat_Lhook.started += instance.OnAddbeat_Lhook;
                @addbeat_Lhook.performed += instance.OnAddbeat_Lhook;
                @addbeat_Lhook.canceled += instance.OnAddbeat_Lhook;
                @addbeat_Luppercut.started += instance.OnAddbeat_Luppercut;
                @addbeat_Luppercut.performed += instance.OnAddbeat_Luppercut;
                @addbeat_Luppercut.canceled += instance.OnAddbeat_Luppercut;
                @addbeat_Rjab.started += instance.OnAddbeat_Rjab;
                @addbeat_Rjab.performed += instance.OnAddbeat_Rjab;
                @addbeat_Rjab.canceled += instance.OnAddbeat_Rjab;
                @addbeat_Rhook.started += instance.OnAddbeat_Rhook;
                @addbeat_Rhook.performed += instance.OnAddbeat_Rhook;
                @addbeat_Rhook.canceled += instance.OnAddbeat_Rhook;
                @addbeat_Ruppercut.started += instance.OnAddbeat_Ruppercut;
                @addbeat_Ruppercut.performed += instance.OnAddbeat_Ruppercut;
                @addbeat_Ruppercut.canceled += instance.OnAddbeat_Ruppercut;
            }
        }
    }
    public MusicActions @Music => new MusicActions(this);
    public interface IMusicActions
    {
        void OnAddbeat_Ljab(InputAction.CallbackContext context);
        void OnAddbeat_Lhook(InputAction.CallbackContext context);
        void OnAddbeat_Luppercut(InputAction.CallbackContext context);
        void OnAddbeat_Rjab(InputAction.CallbackContext context);
        void OnAddbeat_Rhook(InputAction.CallbackContext context);
        void OnAddbeat_Ruppercut(InputAction.CallbackContext context);
    }
}