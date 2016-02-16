//uScript Generated Code - Build 1.0.3024
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class liikkeet : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_0_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_0_UnityEngine_GameObject_previous = null;
   System.Single local_2_System_Single = (float) 0;
   System.Single local_3_System_Single = (float) 0;
   UnityEngine.GameObject local_32_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_32_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_8_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_8_UnityEngine_GameObject_previous = null;
   System.Boolean local_9_System_Boolean = (bool) false;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_4 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_4 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_4 = uScriptAct_ControlGameObjectMove.Direction.Backward;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_4 = (float) 0.1;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_4 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_5 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_5 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_5 = uScriptAct_ControlGameObjectMove.Direction.Forward;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_5 = (float) 0.1;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_5 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_5 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_6 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_6 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_6 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_6 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_6 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_6 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_6 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_6 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_6 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_7 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_7 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_7 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_7 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_10 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_10 = true;
   bool logic_uScriptCon_CompareBool_False_10 = true;
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_11 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_11 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_11 = uScriptAct_ControlGameObjectMove.Direction.Up;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_11 = (float) 1.5;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_11 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_15 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_15 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_15 = new Vector3( (float)0, (float)0.5, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_15 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_15 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_33 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_33 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_33 = uScriptAct_ControlGameObjectMove.Direction.Right;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_33 = (float) 0.1;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_33 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_33 = true;
   //pointer to script instanced logic node
   uScriptAct_ControlGameObjectMove logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_34 = new uScriptAct_ControlGameObjectMove( );
   UnityEngine.GameObject logic_uScriptAct_ControlGameObjectMove_Target_34 = default(UnityEngine.GameObject);
   uScriptAct_ControlGameObjectMove.Direction logic_uScriptAct_ControlGameObjectMove_moveDirection_34 = uScriptAct_ControlGameObjectMove.Direction.Left;
   System.Single logic_uScriptAct_ControlGameObjectMove_Speed_34 = (float) 0.1;
   System.Boolean logic_uScriptAct_ControlGameObjectMove_useLocal_34 = (bool) false;
   bool logic_uScriptAct_ControlGameObjectMove_Out_34 = true;
   
   //event nodes
   System.Single event_UnityEngine_GameObject_Horizontal_1 = (float) 0;
   System.Single event_UnityEngine_GameObject_Vertical_1 = (float) 0;
   System.Boolean event_UnityEngine_GameObject_Fire1_1 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire2_1 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire3_1 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Jump_1 = (bool) false;
   System.Single event_UnityEngine_GameObject_MouseX_1 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseY_1 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseScrollWheel_1 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeX_1 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeY_1 = (float) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_0_UnityEngine_GameObject = GameObject.Find( "Sphere" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_8_UnityEngine_GameObject = GameObject.Find( "Sphere" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_32_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_32_UnityEngine_GameObject = GameObject.Find( "Sphere" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_32_UnityEngine_GameObject_previous != local_32_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_32_UnityEngine_GameObject_previous = local_32_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_32_UnityEngine_GameObject_previous != local_32_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_32_UnityEngine_GameObject_previous = local_32_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_1 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_1 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_1 )
         {
            {
               uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_ManagedInput>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_1.AddComponent<uScript_ManagedInput>();
               }
               if ( null != component )
               {
                  component.OnInputEvent += Instance_OnInputEvent_1;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_1 )
      {
         {
            uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_ManagedInput>();
            if ( null != component )
            {
               component.OnInputEvent -= Instance_OnInputEvent_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_4.SetParent(g);
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_5.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_6.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.SetParent(g);
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_11.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_15.SetParent(g);
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_33.SetParent(g);
      logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_34.SetParent(g);
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnInputEvent_1(object o, uScript_ManagedInput.CustomEventBoolArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Horizontal_1 = e.Horizontal;
      event_UnityEngine_GameObject_Vertical_1 = e.Vertical;
      event_UnityEngine_GameObject_Fire1_1 = e.Fire1;
      event_UnityEngine_GameObject_Fire2_1 = e.Fire2;
      event_UnityEngine_GameObject_Fire3_1 = e.Fire3;
      event_UnityEngine_GameObject_Jump_1 = e.Jump;
      event_UnityEngine_GameObject_MouseX_1 = e.MouseX;
      event_UnityEngine_GameObject_MouseY_1 = e.MouseY;
      event_UnityEngine_GameObject_MouseScrollWheel_1 = e.MouseScrollWheel;
      event_UnityEngine_GameObject_WindowShakeX_1 = e.WindowShakeX;
      event_UnityEngine_GameObject_WindowShakeY_1 = e.WindowShakeY;
      //relay event to nodes
      Relay_OnInputEvent_1( );
   }
   
   void Relay_OnInputEvent_1()
   {
      if (true == CheckDebugBreak("39151b9f-06a4-45cd-83ca-2ff6a8812344", "Managed_Input_Events", Relay_OnInputEvent_1)) return; 
      local_2_System_Single = event_UnityEngine_GameObject_Horizontal_1;
      local_3_System_Single = event_UnityEngine_GameObject_Vertical_1;
      local_9_System_Boolean = event_UnityEngine_GameObject_Jump_1;
      Relay_In_7();
      Relay_In_6();
      Relay_In_10();
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d3c28481-b379-49d8-a1f5-7dbc41d98cfb", "Control_GameObject__Move_", Relay_In_4)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_4 = local_0_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_4.In(logic_uScriptAct_ControlGameObjectMove_Target_4, logic_uScriptAct_ControlGameObjectMove_moveDirection_4, logic_uScriptAct_ControlGameObjectMove_Speed_4, logic_uScriptAct_ControlGameObjectMove_useLocal_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e9ce2358-27f8-4f2d-a38c-b70e36480564", "Control_GameObject__Move_", Relay_In_5)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_5 = local_0_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_5.In(logic_uScriptAct_ControlGameObjectMove_Target_5, logic_uScriptAct_ControlGameObjectMove_moveDirection_5, logic_uScriptAct_ControlGameObjectMove_Speed_5, logic_uScriptAct_ControlGameObjectMove_useLocal_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7fe8ebce-1b60-4459-ae65-913e684b3cfa", "Compare_Float", Relay_In_6)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_6 = local_2_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_6.In(logic_uScriptCon_CompareFloat_A_6, logic_uScriptCon_CompareFloat_B_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_6.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_6.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_33();
         }
         if ( test_1 == true )
         {
            Relay_In_34();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a8a34d0d-91c5-4e6c-b02a-e47417b7293c", "Compare_Float", Relay_In_7)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_7 = local_3_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.In(logic_uScriptCon_CompareFloat_A_7, logic_uScriptCon_CompareFloat_B_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_7.LessThan;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
         if ( test_1 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("84dcdcd9-0616-49b6-84e6-03b07f001300", "Compare_Bool", Relay_In_10)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_10 = local_9_System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.In(logic_uScriptCon_CompareBool_Bool_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.True;
         
         if ( test_0 == true )
         {
            Relay_In_11();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("485009e3-b4ac-4456-b42a-ab594dc0c321", "Control_GameObject__Move_", Relay_In_11)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_11 = local_8_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_11.In(logic_uScriptAct_ControlGameObjectMove_Target_11, logic_uScriptAct_ControlGameObjectMove_moveDirection_11, logic_uScriptAct_ControlGameObjectMove_Speed_11, logic_uScriptAct_ControlGameObjectMove_useLocal_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1e79a310-4d92-40b4-9f13-e0c853e51d59", "Set_Position", Relay_In_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_SetGameObjectPosition_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_15, index + 1);
               }
               logic_uScriptAct_SetGameObjectPosition_Target_15[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_15.In(logic_uScriptAct_SetGameObjectPosition_Target_15, logic_uScriptAct_SetGameObjectPosition_Position_15, logic_uScriptAct_SetGameObjectPosition_AsOffset_15, logic_uScriptAct_SetGameObjectPosition_AsLocal_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Set Position.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_33()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5755b1aa-ab15-41d3-926a-10ddb66fbe65", "Control_GameObject__Move_", Relay_In_33)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_32_UnityEngine_GameObject_previous != local_32_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_32_UnityEngine_GameObject_previous = local_32_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_33 = local_32_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_33.In(logic_uScriptAct_ControlGameObjectMove_Target_33, logic_uScriptAct_ControlGameObjectMove_moveDirection_33, logic_uScriptAct_ControlGameObjectMove_Speed_33, logic_uScriptAct_ControlGameObjectMove_useLocal_33);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_34()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("58988355-f5ae-4e0b-a8c6-138fbe59e646", "Control_GameObject__Move_", Relay_In_34)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_32_UnityEngine_GameObject_previous != local_32_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_32_UnityEngine_GameObject_previous = local_32_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_ControlGameObjectMove_Target_34 = local_32_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_ControlGameObjectMove_uScriptAct_ControlGameObjectMove_34.In(logic_uScriptAct_ControlGameObjectMove_Target_34, logic_uScriptAct_ControlGameObjectMove_moveDirection_34, logic_uScriptAct_ControlGameObjectMove_Speed_34, logic_uScriptAct_ControlGameObjectMove_useLocal_34);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript liikkeet.uscript at Control GameObject (Move).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:0", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7c6c3e90-a08d-45ce-ac55-f0b76d824913", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:2", local_2_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "7434ef57-18d4-422d-abe1-c71290907d54", local_2_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:3", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c8cc6f0e-a4cf-44b5-9fc3-07734a4cb029", local_3_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:8", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5b8a195d-9f3e-492f-84fd-c299063dddeb", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:9", local_9_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "4aa586ee-9ca1-4371-baa8-aad109ab3052", local_9_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "liikkeet.uscript:32", local_32_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b1d3da6e-a83c-4281-83ae-15061839a06d", local_32_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
