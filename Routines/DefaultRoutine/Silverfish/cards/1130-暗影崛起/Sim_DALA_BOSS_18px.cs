namespace HREngine.Bots
{
	class Sim_DALA_BOSS_18px : SimTemplate //* 召唤图腾 Totemic Summons
//<b>Hero Power</b>Summon ANY random Totem.
//<b>英雄技能</b>随机召唤任意图腾。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}