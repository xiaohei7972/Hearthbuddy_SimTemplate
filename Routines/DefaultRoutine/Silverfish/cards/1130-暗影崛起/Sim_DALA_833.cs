namespace HREngine.Bots
{
	class Sim_DALA_833 : SimTemplate //* 情节：市集 Twist - The Carts
//Both players can only have four minions.
//每个玩家至多可以拥有四个随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}