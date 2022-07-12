using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedHunter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Hunter Potion");
			Tooltip.SetDefault("Spot the enemy before they spot you.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Hunter, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HunterPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
