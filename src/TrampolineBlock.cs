using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace Trampoline.src
{
    public class TrampolineBlock : Block
    {
        public AssetLocation tickSound = new AssetLocation("game", "tick");

        public override void OnEntityCollide(IWorldAccessor world, Entity entity, BlockPos pos, BlockFacing facing, Vec3d collideSpeed, bool isImpact)
        {
            if (isImpact && facing.Axis == EnumAxis.Y)
            {
                world.PlaySoundAt(tickSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                entity.Pos.Motion.Y *= -0.8;
            }
        }
    }
}
