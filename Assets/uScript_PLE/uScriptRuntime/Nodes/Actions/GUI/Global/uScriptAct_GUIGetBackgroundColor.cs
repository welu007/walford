// uScript Action Node
// (C) 2011 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/GUI/Global")]

[NodeCopyright("Copyright 2011 by Detox Studios LLC")]
[NodeToolTip("Gets the current background tint color for the GUI.")]
[NodeAuthor("Detox Studios LLC", "http://www.detoxstudios.com")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("GUI Get Background Color", "Gets the current background tint color for the GUI.")]
public class uScriptAct_GUIGetBackgroundColor : uScriptLogic
{
   public bool Out { get { return true; } }

   public void In(
      [FriendlyName("Color", "The current color that the GUI background objects are tinted with.")]
      out Color color
      )
   {
      color = GUI.backgroundColor;
   }
}
