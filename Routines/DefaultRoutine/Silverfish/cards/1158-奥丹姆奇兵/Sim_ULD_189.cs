namespace HREngine.Bots
{
	class Sim_ULD_189 : SimTemplate //* 无面潜伏者 Faceless Lurker
	{
		//<b>Taunt</b><b>Battlecry:</b> Double this minion's Health.
		//<b>嘲讽，战吼：</b>将该随从的生命值翻倍。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.minionGetBuffed(own, 0, own.Hp);
		}

	}
}