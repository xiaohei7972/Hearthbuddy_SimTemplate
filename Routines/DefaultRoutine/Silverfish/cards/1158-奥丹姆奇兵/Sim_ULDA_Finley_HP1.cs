namespace HREngine.Bots
{
	class Sim_ULDA_Finley_HP1 : SimTemplate //* 更新的“新兵” New "Recruits"
//<b>Hero Power</b>Summon a 2/2 Amalgam Explorer.
//<b>英雄技能</b>召唤一个2/2的融合怪探险者。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}