using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Aether.Physics2D
{
    internal class AetherPhysics2DSystem : UnifiedSystem<AetherPhysics2DWorldComponent>
    {
        public float ElapsedGameTimeTotalSeconds { get; set; }

        public override void ProcessSingleEntity(int entityId, ref AetherPhysics2DWorldComponent t)
        {
            t.World.Step(ElapsedGameTimeTotalSeconds);
        }
    }
}