using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.Items.KaiyoTier.Ores
{
	public class KaiyoOre : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Yea, it's wet");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 2;
		}
	}
}