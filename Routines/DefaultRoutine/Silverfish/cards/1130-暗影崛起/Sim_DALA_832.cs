namespace HREngine.Bots
{
	class Sim_DALA_832 : SimTemplate //* 情节：囚室 Twist - The Prisons
//Both players start the game with a 'Violet Prison.'
//双方玩家在对战开始时获得一个“紫罗兰囚室”。 
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