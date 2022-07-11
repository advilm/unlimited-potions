using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedLifeforce : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Lifeforce Potion");
			Tooltip.SetDefault("More health.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Lifeforce, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LifeforcePotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
