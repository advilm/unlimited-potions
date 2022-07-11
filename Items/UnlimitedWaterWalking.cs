using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedWaterWalking : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Water Walking Potion");
			Tooltip.SetDefault("Now you don't need to bother building that platform for Wall of Flesh.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.WaterWalking, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WaterWalkingPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
