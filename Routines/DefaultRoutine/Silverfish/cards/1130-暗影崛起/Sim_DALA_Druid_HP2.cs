namespace HREngine.Bots
{
	class Sim_DALA_Druid_HP2 : SimTemplate //* 树木之触 Touch of Bark
//<b>Hero Power</b>Give a minion +1/+1.
//<b>英雄技能</b>使一个随从获得+1/+1。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}