namespace HREngine.Bots
{
	class Sim_GILA_BOSS_23t : SimTemplate //* 抛击 Chuck
//Discard all minionsfrom your hand anddeal their Attack tothe enemy hero.
//弃掉手牌中的所有随从牌，并对敌方英雄造成等同于其攻击力总和的伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}