﻿using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionHit"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Hit")]
    public class AIDecisionHitNode : AIDecisionNode
    {
        public int numberOfHits = 1;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionHit>();
            decision.Label = label;
            decision.NumberOfHits = numberOfHits;
            return decision;
        }
    }
}