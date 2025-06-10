namespace HREngine.Bots
{
	class Sim_DALA_BOSS_74px : SimTemplate //* 灵魂编织 Soul Weave
//<b>Hero Power</b>Discard a card. Summon a random minion of the same cost.
//<b>英雄技能</b>弃一张牌。随机召唤一个法力值消耗相同的随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}