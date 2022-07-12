using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedBattle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Battle Potion");
			Tooltip.SetDefault("Increased Spawns.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Battle, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BattlePotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
