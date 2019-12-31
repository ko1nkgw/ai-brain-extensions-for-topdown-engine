﻿using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionTimeSinceStartNode))]
    public class AIDecisionTimeSinceStartNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _afterTime;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            if (CollapseNodeOn) return;

            _afterTime = serializedObject.FindProperty("afterTime");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_afterTime);
            serializedObject.ApplyModifiedProperties();
        }
    }
}