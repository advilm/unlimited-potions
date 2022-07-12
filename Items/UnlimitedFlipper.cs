using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedFlipper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Flipper Potion");
			Tooltip.SetDefault("Allows swimming.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Flipper, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FlipperPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
