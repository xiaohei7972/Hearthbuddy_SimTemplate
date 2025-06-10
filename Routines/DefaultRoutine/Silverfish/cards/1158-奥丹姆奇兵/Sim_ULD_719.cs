namespace HREngine.Bots
{
	class Sim_ULD_719 : SimTemplate //* 沙漠野兔 Desert Hare
	{
		//<b>Battlecry:</b> Summon two 1/1 Desert Hares.
		//<b>战吼：</b>召唤两只1/1的沙漠野兔。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			CardDB.Card Hare = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_719);
			p.callKid(Hare, own.zonepos - 1, own.own);
			p.callKid(Hare, own.zonepos, own.own);
		}

	}
}