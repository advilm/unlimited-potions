using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedGills : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Gills Potion");
			Tooltip.SetDefault("Never drown again.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Gills, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GillsPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}