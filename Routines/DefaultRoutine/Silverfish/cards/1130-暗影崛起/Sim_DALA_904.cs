namespace HREngine.Bots
{
	class Sim_DALA_904 : SimTemplate //* 上等佳肴 Good Food
//Increase your starting Health by 5.
//你的初始生命值提高5点。 
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