namespace HREngine.Bots
{
	class Sim_ULD_309 : SimTemplate //* 矮人考古学家 Dwarven Archaeologist
	{
		//After you <b>Discover</b> a card, reduce its cost by (1).
		//在你<b>发现</b>一张卡牌后，使其法力值消耗降低（1）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
			p.owncards[p.owncards.Count - 1].manacost -= 1;
		}

	}
}