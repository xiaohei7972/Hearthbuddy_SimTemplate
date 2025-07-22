namespace HREngine.Bots
{
	class Sim_ULDA_403 : SimTemplate //* 远古映像 Ancient Reflections
//Choose a minion.Fill your board with 1/1 copies of it.
//选择一个随从。召唤数个它的1/1的复制，直到你的随从数量达到上限。 
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