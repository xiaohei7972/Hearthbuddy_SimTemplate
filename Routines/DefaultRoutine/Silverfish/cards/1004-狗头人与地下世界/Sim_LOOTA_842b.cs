namespace HREngine.Bots
{
	class Sim_LOOTA_842b : SimTemplate //* 奎尔德拉的剑柄 Hilt of Quel'Delar
//Give a minion +3/+3.
//使一个随从获得+3/+3。 
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