namespace HREngine.Bots
{
	class Sim_ULD_191 : SimTemplate //* 欢快的同伴 Beaming Sidekick
	{
		//<b>Battlecry:</b> Give a friendly minion +2 Health.
		//<b>战吼：</b>使一个友方随从获得+2生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 0, 2);
			}
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}