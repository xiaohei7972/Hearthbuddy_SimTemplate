namespace HREngine.Bots
{
	class Sim_DRG_107 : SimTemplate //* 紫罗兰魔翼鸦 Violet Spellwing
	{
		//<b>Deathrattle:</b> Add an 'Arcane Missiles' spell to your hand.
		//<b>亡语：</b>将一张“奥术飞弹”置入你的手牌。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.drawACard(CardDB.cardIDEnum.EX1_277, m.own);
		}

	}
}