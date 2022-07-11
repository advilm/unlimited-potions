using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedDangersense : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Dangersense Potion");
			Tooltip.SetDefault("Don't be surprised.\nUse the Settings UI to toggle the effect.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Dangersense, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TrapsightPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
