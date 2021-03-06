// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
            ""name"": ""Gameplay"",
            ""id"": ""572cd982-bf21-460e-96cf-a9bbab1a0c88"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""3b710601-1e51-4fc0-b604-4425dfa1e548"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""f7b0763b-7fa0-4d0a-aafe-992f52e866f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Holder"",
                    ""type"": ""Button"",
                    ""id"": ""322ddfe2-0bbc-4688-b937-eee869575b25"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""GoToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""0fb2a53c-1dfa-4ee3-b066-d7162aec3c21"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""32dec4c7-5365-4b30-ad14-d8e219c13522"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7af7278b-a738-4d76-a137-481e6dabec0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9f6b5e0-39dd-4ace-97dc-e240e677a7b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a23652-2ce4-46d4-b1da-f7c0d0844627"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e49de4b9-a0ed-4891-94bf-2c6bd3717afa"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2b08b4e-76c3-4c0e-ba38-2957ab6fa36c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07d73fe4-b1d5-4226-b5c1-6bad3cb2a46b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""472c3804-f4d6-42d5-b5d7-4080dc13c100"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""189d806e-578d-4d7a-a8aa-b4570e734d09"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Holder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bee7380a-c36e-448e-bb70-05a9dac0c97a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Holder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""fb067cc1-7c8f-4788-9b1a-7e170e521228"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""1b843528-c1bc-487b-a593-aa6d30a1e96d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c212bf77-e4e9-4b76-a730-9688b4ad17bc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""16b23b5d-2fb7-4058-aa53-1075e3f161d2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""e8f677cf-11c0-414c-adbc-08e98c7d33b9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""22d6bad8-c890-4d37-8037-29c9bf455ef9"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""fcc01cda-7d34-45da-8614-834cd2673d88"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ea0bee8a-d879-4e6a-b1b3-50d2b68834af"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""47aece98-b152-4c6e-b79c-6e81b5ad1942"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b82ab04-2bcd-4c3f-9108-20dd7e3b4ea4"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8d3ba7b-3d99-4e5a-97c7-91ae091d8e1d"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""82a236c6-2352-47ae-9104-fc0ef562c214"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""bcd59a15-7978-4c56-82aa-0e10947d9c12"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""6257042b-9866-483f-9f5c-3009b793d20e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""575a1199-9b2e-41b4-9dc7-25fb554b2f56"",
            ""actions"": [
                {
                    ""name"": ""launchLevel"",
                    ""type"": ""Button"",
                    ""id"": ""0c6d1f1b-fb07-492f-9b9b-edf4c29bd521"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""selectLevel"",
                    ""type"": ""Button"",
                    ""id"": ""c5a23765-2d03-44f6-9949-42eff7556810"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""openSettings"",
                    ""type"": ""Button"",
                    ""id"": ""bc5d5260-0950-4799-b4c3-998e65c127af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""selectSettings"",
                    ""type"": ""Button"",
                    ""id"": ""502f3603-19eb-42af-948c-503a4ac03fe5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""changeSettings"",
                    ""type"": ""Button"",
                    ""id"": ""3c6bb396-0aa5-4d6b-a189-5dcfcd921049"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quitSettings"",
                    ""type"": ""Button"",
                    ""id"": ""b1c16633-dda1-494d-8568-b93b67865e3f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Holder"",
                    ""type"": ""Button"",
                    ""id"": ""8649d5d3-425d-4b95-80de-4f4b6743fbcb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Deholder"",
                    ""type"": ""Button"",
                    ""id"": ""e7bb7fef-5023-41dd-84b2-053703c1ee47"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1f776e9c-d37c-44f1-baf9-62c7b2b19b98"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""launchLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31c77076-300c-499b-a612-9f9de5fcf024"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""launchLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9283ecf4-7058-41f8-b11e-bc8df4544f49"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""launchLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0277c1fb-f9b0-47c0-a709-2ad6b194a4f2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""launchLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfc0ebbb-d839-4c85-b23f-d34468a2bf89"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""selectLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""227dae6a-4bc5-4547-8318-af89d6ef589f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""selectLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f850221-7983-4775-9c44-f428ea50f324"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""selectLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d184808-ce6c-4f91-94d0-6c83258b47bf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""selectLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""152722f0-f274-44c2-8947-3bfe965cc1ad"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""239c05e3-ff95-4f84-912f-3428ee61292c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""062e3946-1e26-4627-9966-55bd92928d6e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""0ac3975e-73ad-4ca9-9665-ebe2f1a999c6"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""7d8823e7-2b58-4b72-a81e-e74a63c1dd51"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ef4dca9f-a8dd-4db9-a099-6418998187a9"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""25b6bd66-51fc-471d-9fc4-c059f5368bff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""selectSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f5efe38-37ea-41d4-b622-e436539a1f9a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""selectSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39f17b89-8b23-4003-bce7-31f2071089ac"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""selectSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a5d5af1-1e93-425b-ae89-d244c8cab617"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Tap(duration=0.75)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""selectSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d65091-936a-45d6-8190-962f4c2c5335"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""changeSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4dc0b51-57e5-4f6a-8ef4-fa890958bdab"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""changeSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5065be30-46b7-4c10-a962-c990ccb2dad9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""changeSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5f81975-08dc-4808-9f80-c61599ed9d80"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""changeSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1919af8-bc84-4a98-8df3-bcef08d174d6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=0.4)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Holder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5f427ec-75e7-423b-80c2-d682ce127aee"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Hold(duration=0.4)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Holder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""bd1dfe42-5e31-407f-b6b8-6a93e3692c2e"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""b0d9c9bb-bf2c-4c0c-9816-7cad77216e79"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""d6f7a1c2-30a2-42f1-888b-a0542ff6d92d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""1007c675-aab3-45f3-892b-b593aa19a88d"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""6b957813-d3c7-4a9c-af51-8852aaae9d54"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""1f05fc97-cfe9-4fc9-b8a1-b6fa880e2514"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quitSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8e6dc157-f6d2-4cdf-8884-3dadab03cc26"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press(pressPoint=0.4,behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deholder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70a9bee7-4ced-4466-8144-e53b1a19cf32"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(pressPoint=0.4,behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deholder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": []
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_A = m_Gameplay.FindAction("A", throwIfNotFound: true);
        m_Gameplay_B = m_Gameplay.FindAction("B", throwIfNotFound: true);
        m_Gameplay_Holder = m_Gameplay.FindAction("Holder", throwIfNotFound: true);
        m_Gameplay_GoToMenu = m_Gameplay.FindAction("GoToMenu", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_launchLevel = m_Menu.FindAction("launchLevel", throwIfNotFound: true);
        m_Menu_selectLevel = m_Menu.FindAction("selectLevel", throwIfNotFound: true);
        m_Menu_openSettings = m_Menu.FindAction("openSettings", throwIfNotFound: true);
        m_Menu_selectSettings = m_Menu.FindAction("selectSettings", throwIfNotFound: true);
        m_Menu_changeSettings = m_Menu.FindAction("changeSettings", throwIfNotFound: true);
        m_Menu_quitSettings = m_Menu.FindAction("quitSettings", throwIfNotFound: true);
        m_Menu_Holder = m_Menu.FindAction("Holder", throwIfNotFound: true);
        m_Menu_Deholder = m_Menu.FindAction("Deholder", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_A;
    private readonly InputAction m_Gameplay_B;
    private readonly InputAction m_Gameplay_Holder;
    private readonly InputAction m_Gameplay_GoToMenu;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Gameplay_A;
        public InputAction @B => m_Wrapper.m_Gameplay_B;
        public InputAction @Holder => m_Wrapper.m_Gameplay_Holder;
        public InputAction @GoToMenu => m_Wrapper.m_Gameplay_GoToMenu;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @Holder.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHolder;
                @Holder.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHolder;
                @Holder.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHolder;
                @GoToMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGoToMenu;
                @GoToMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGoToMenu;
                @GoToMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGoToMenu;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Holder.started += instance.OnHolder;
                @Holder.performed += instance.OnHolder;
                @Holder.canceled += instance.OnHolder;
                @GoToMenu.started += instance.OnGoToMenu;
                @GoToMenu.performed += instance.OnGoToMenu;
                @GoToMenu.canceled += instance.OnGoToMenu;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_launchLevel;
    private readonly InputAction m_Menu_selectLevel;
    private readonly InputAction m_Menu_openSettings;
    private readonly InputAction m_Menu_selectSettings;
    private readonly InputAction m_Menu_changeSettings;
    private readonly InputAction m_Menu_quitSettings;
    private readonly InputAction m_Menu_Holder;
    private readonly InputAction m_Menu_Deholder;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @launchLevel => m_Wrapper.m_Menu_launchLevel;
        public InputAction @selectLevel => m_Wrapper.m_Menu_selectLevel;
        public InputAction @openSettings => m_Wrapper.m_Menu_openSettings;
        public InputAction @selectSettings => m_Wrapper.m_Menu_selectSettings;
        public InputAction @changeSettings => m_Wrapper.m_Menu_changeSettings;
        public InputAction @quitSettings => m_Wrapper.m_Menu_quitSettings;
        public InputAction @Holder => m_Wrapper.m_Menu_Holder;
        public InputAction @Deholder => m_Wrapper.m_Menu_Deholder;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @launchLevel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLaunchLevel;
                @launchLevel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLaunchLevel;
                @launchLevel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLaunchLevel;
                @selectLevel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLevel;
                @selectLevel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLevel;
                @selectLevel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLevel;
                @openSettings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnOpenSettings;
                @openSettings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnOpenSettings;
                @openSettings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnOpenSettings;
                @selectSettings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectSettings;
                @selectSettings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectSettings;
                @selectSettings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectSettings;
                @changeSettings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeSettings;
                @changeSettings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeSettings;
                @changeSettings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeSettings;
                @quitSettings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuitSettings;
                @quitSettings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuitSettings;
                @quitSettings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnQuitSettings;
                @Holder.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnHolder;
                @Holder.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnHolder;
                @Holder.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnHolder;
                @Deholder.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDeholder;
                @Deholder.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDeholder;
                @Deholder.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDeholder;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @launchLevel.started += instance.OnLaunchLevel;
                @launchLevel.performed += instance.OnLaunchLevel;
                @launchLevel.canceled += instance.OnLaunchLevel;
                @selectLevel.started += instance.OnSelectLevel;
                @selectLevel.performed += instance.OnSelectLevel;
                @selectLevel.canceled += instance.OnSelectLevel;
                @openSettings.started += instance.OnOpenSettings;
                @openSettings.performed += instance.OnOpenSettings;
                @openSettings.canceled += instance.OnOpenSettings;
                @selectSettings.started += instance.OnSelectSettings;
                @selectSettings.performed += instance.OnSelectSettings;
                @selectSettings.canceled += instance.OnSelectSettings;
                @changeSettings.started += instance.OnChangeSettings;
                @changeSettings.performed += instance.OnChangeSettings;
                @changeSettings.canceled += instance.OnChangeSettings;
                @quitSettings.started += instance.OnQuitSettings;
                @quitSettings.performed += instance.OnQuitSettings;
                @quitSettings.canceled += instance.OnQuitSettings;
                @Holder.started += instance.OnHolder;
                @Holder.performed += instance.OnHolder;
                @Holder.canceled += instance.OnHolder;
                @Deholder.started += instance.OnDeholder;
                @Deholder.performed += instance.OnDeholder;
                @Deholder.canceled += instance.OnDeholder;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnHolder(InputAction.CallbackContext context);
        void OnGoToMenu(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnLaunchLevel(InputAction.CallbackContext context);
        void OnSelectLevel(InputAction.CallbackContext context);
        void OnOpenSettings(InputAction.CallbackContext context);
        void OnSelectSettings(InputAction.CallbackContext context);
        void OnChangeSettings(InputAction.CallbackContext context);
        void OnQuitSettings(InputAction.CallbackContext context);
        void OnHolder(InputAction.CallbackContext context);
        void OnDeholder(InputAction.CallbackContext context);
    }
}
