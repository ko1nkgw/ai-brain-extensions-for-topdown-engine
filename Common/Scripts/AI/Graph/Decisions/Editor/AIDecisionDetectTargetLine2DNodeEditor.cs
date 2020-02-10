﻿using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetLine2DNode))]
    public class AIDecisionDetectTargetLine2DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _detectMethod;
        private SerializedProperty _detectionDirection;
        private SerializedProperty _rayWidth;
        private SerializedProperty _detectionDistance;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayer;
        private SerializedProperty _obstaclesLayer;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _detectMethod = serializedObject.FindProperty("detectMethod");
            _detectionDirection = serializedObject.FindProperty("detectionDirection");
            _rayWidth = serializedObject.FindProperty("rayWidth");
            _detectionDistance = serializedObject.FindProperty("detectionDistance");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayer = serializedObject.FindProperty("targetLayer");
            _obstaclesLayer = serializedObject.FindProperty("obstaclesLayer");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_detectMethod);
            NodeEditorGUILayout.PropertyField(_detectionDirection);
            NodeEditorGUILayout.PropertyField(_rayWidth);
            NodeEditorGUILayout.PropertyField(_detectionDistance);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayer);
            NodeEditorGUILayout.PropertyField(_obstaclesLayer);
            serializedObject.ApplyModifiedProperties();
        }
    }
}