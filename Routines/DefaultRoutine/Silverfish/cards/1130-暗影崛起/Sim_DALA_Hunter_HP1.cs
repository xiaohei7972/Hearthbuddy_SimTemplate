namespace HREngine.Bots
{
	class Sim_DALA_Hunter_HP1 : SimTemplate //* 待时而动 Opportunist
//<b>Hero Power</b>Give a minion +2_Attack this turn.
//<b>英雄技能</b>在本回合中，使一个随从获得+2攻击力。 
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