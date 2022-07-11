using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedNightOwl : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Night Owl Potion");
			Tooltip.SetDefault("See in the dark.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.NightOwl, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.NightOwlPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
