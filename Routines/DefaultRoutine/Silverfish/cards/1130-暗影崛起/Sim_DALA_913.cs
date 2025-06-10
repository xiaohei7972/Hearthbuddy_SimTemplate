namespace HREngine.Bots
{
	class Sim_DALA_913 : SimTemplate //* 夸大其词 Tall Tales
//[x]Choose a friendly minion.It gains +4/+4 but costs(2) more for this run.
//选择一个友方随从，使其在本次冒险中获得+4/+4，且法力值消耗增加（2）点。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}