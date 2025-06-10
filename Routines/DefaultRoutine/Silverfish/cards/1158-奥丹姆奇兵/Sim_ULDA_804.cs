namespace HREngine.Bots
{
	class Sim_ULDA_804 : SimTemplate //* 情节：死亡之灾祸 Twist - Plague of Death
//Both players start the game with an'Eternal Tomb.'
//对战开始时，双方玩家的场上都会有一座“永恒陵墓”。 
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