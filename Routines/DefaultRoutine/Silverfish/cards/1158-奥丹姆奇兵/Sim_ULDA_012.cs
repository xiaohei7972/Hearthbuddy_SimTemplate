namespace HREngine.Bots
{
	class Sim_ULDA_012 : SimTemplate //* 石狐雕像 Stone Fox Statue
//Choose a minion and add 2 copies of it to your hand that cost (0).
//选择一个随从，将两张它的复制置入你的手牌，其法力值消耗为（0）点。 
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