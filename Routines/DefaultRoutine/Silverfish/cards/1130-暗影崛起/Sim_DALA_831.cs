namespace HREngine.Bots
{
	class Sim_DALA_831 : SimTemplate //* 情节：恶臭 Twist - The Stench
//All minions' Attack and Health are swapped.
//所有随从的攻击力和生命值互换。 
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